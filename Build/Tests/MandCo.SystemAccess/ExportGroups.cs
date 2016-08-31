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
    
    /// <summary>Export - Groups(P#29)</summary>
    // Last change before Migration: 27/02/2004 17:37:45
    class ExportGroups : BusinessProcessBase 
    {
        
        #region Models
        
        /// <summary>Groups</summary>
        readonly Models.Groups1 Groups1 = new Models.Groups1 { ReadOnly = true };
        #endregion
        
        #region Streams
        
        /// <summary>Export - Groups</summary>
        ENV.IO.FileWriter _ioExportGroups;
        #endregion
        
        #region Layouts
        
        /// <summary>Export - Groups</summary>
        MandCo.Theme.IO.TextSection _viewExportGroups;
        #endregion
        
        
        /// <summary>Export - Groups(P#29)</summary>
        public ExportGroups()
        {
            Title = "Export - Groups";
            ConfirmExecution = true;
            InitializeDataView();
            #region form Export - Groups
            
            _viewExportGroups = new MandCo.Theme.IO.TextSection(this)
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
            _viewExportGroups.Controls.Add(txtGroups1GroupDescription);
            _viewExportGroups.Controls.Add(txtGroups1GroupID);
            
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
        
        /// <summary>Export - Groups</summary>
        public void Run()
        {
            Execute();
        }
        #endregion
        
        protected override void OnLoad()
        {
            RowLocking = LockingStrategy.OnRowLoading;
            TransactionScope = TransactionScopes.Task;
            OnDatabaseErrorRetry = true;
            Activity = Activities.Browse;
            AllowUserAbort = true;
            
            _ioExportGroups = new ENV.IO.FileWriter(@"%magic%\sa\SA_Group.TXT")
            			{
            				Name = "Export - Groups"
            			};
            _ioExportGroups.Open();
            Streams.Add(_ioExportGroups);
        }
        protected override void OnLeaveRow()
        {
            _viewExportGroups.WriteTo(_ioExportGroups);
        }
        
        
    }
}
