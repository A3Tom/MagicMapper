#region Copyright Firefly Ltd 2014
/* *********************** DISCLAIMER **************************************
 * This software and documentation constitute an unpublished work and contain 
 * valuable trade secrets and proprietary information belonging to Firefly Ltd. 
 * None of the foregoing material may be copied, duplicated or disclosed without 
 * the express written permission of Firefly Ltd. 
 * FIREFLY LTD EXPRESSLY DISCLAIMS ANY AND ALL WARRANTIES CONCERNING THIS SOFTWARE 
 * AND DOCUMENTATION, INCLUDING ANY WARRANTIES OF MERCHANTABILITY AND/OR FITNESS 
 * FOR ANY PARTICULAR PURPOSE, AND WARRANTIES OF PERFORMANCE, AND ANY WARRANTY 
 * THAT MIGHT OTHERWISE ARISE FROM COURSE OF DEALING OR USAGE OF TRADE. NO WARRANTY 
 * IS EITHER EXPRESS OR IMPLIED WITH RESPECT TO THE USE OF THE SOFTWARE OR 
 * DOCUMENTATION. 
 * Under no circumstances shall Firefly Ltd be liable for incidental, special, 
 * indirect, direct or consequential damages or loss of profits, interruption of 
 * business, or related expenses which may arise from use of software or documentation, 
 * including but not limited to those resulting from defects in software and/or 
 * documentation, or loss or inaccuracy of data of any kind. 
 */
#endregion
using Firefly.Box;
using ENV.Data;
using ENV;
namespace MandCo.SystemAccess
{
    
    /// <summary>Import - Groups(P#37)</summary>
    // Last change before Migration: 27/02/2004 17:38:20
    class ImportGroups : BusinessProcessBase 
    {
        
        #region Models
        
        /// <summary>Groups</summary>
        readonly Models.Groups1 Groups1 = new Models.Groups1 { AllowRowLocking = true };
        #endregion
        
        #region Streams
        
        /// <summary>Import - Groups</summary>
        ENV.IO.FileReader _ioImportGroups;
        #endregion
        
        #region Layouts
        
        /// <summary>Import - Groups</summary>
        MandCo.Theme.IO.TextSection _viewImportGroups;
        #endregion
        
        
        /// <summary>Import - Groups(P#37)</summary>
        public ImportGroups()
        {
            Title = "Import - Groups";
            ConfirmExecution = true;
            InitializeDataView();
            #region form Import - Groups
            
            _viewImportGroups = new MandCo.Theme.IO.TextSection(this)
            			{
            				Height = 1,
            				Width = 51
            			};
            var txtGroups1GroupID = new MandCo.Theme.IO.TextBox()
            			{
            				Width = 20,
            				Data = Groups1.GroupID
            			};
            var txtGroups1GroupDescription = new MandCo.Theme.IO.TextBox()
            			{
            				Left = 21,
            				Width = 30,
            				Data = Groups1.GroupDescription
            			};
            _viewImportGroups.Controls.Add(txtGroups1GroupDescription);
            _viewImportGroups.Controls.Add(txtGroups1GroupID);
            
            #endregion
        }
        void InitializeDataView()
        {
            From = Groups1;
            OrderBy = Groups1.SortBySA_GROUP_X1;
            
            #region Columns
            
            Columns.Add(Groups1.GroupID);
            Columns.Add(Groups1.GroupDescription);
            #endregion
        }
        
        #region Run Overloads
        
        /// <summary>Import - Groups</summary>
        public void Run()
        {
            Execute();
        }
        #endregion
        
        protected override void OnLoad()
        {
            Exit(ExitTiming.BeforeRow, () => _ioImportGroups.EndOfFile);
            RowLocking = LockingStrategy.OnRowLoading;
            TransactionScope = TransactionScopes.Task;
            OnDatabaseErrorRetry = true;
            Activity = Activities.Insert;
            AllowUserAbort = true;
            
            _ioImportGroups = new ENV.IO.FileReader(@"%magic%\sa\SA_Group.TXT")
            			{
            				Name = "Import - Groups"
            			};
            Streams.Add(_ioImportGroups);
        }
        protected override void OnLeaveRow()
        {
            _viewImportGroups.ReadFrom(_ioImportGroups);
        }
        
        
    }
}
