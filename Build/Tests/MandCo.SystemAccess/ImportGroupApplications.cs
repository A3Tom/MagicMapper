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
    
    /// <summary>Import - GroupApplications(P#40)</summary>
    // Last change before Migration: 27/02/2004 17:38:32
    class ImportGroupApplications : BusinessProcessBase 
    {
        
        #region Models
        
        /// <summary>GroupApplications</summary>
        readonly Models.GroupApplications GroupApplications = new Models.GroupApplications { AllowRowLocking = true };
        #endregion
        
        #region Streams
        
        /// <summary>Import - GroupApplic</summary>
        ENV.IO.FileReader _ioImportGroupApplic;
        #endregion
        
        #region Layouts
        
        /// <summary>Import - GroupApplications</summary>
        MandCo.Theme.IO.TextSection _viewImportGroupApplications;
        #endregion
        
        
        /// <summary>Import - GroupApplications(P#40)</summary>
        public ImportGroupApplications()
        {
            Title = "Import - GroupApplications";
            ConfirmExecution = true;
            InitializeDataView();
            #region form Import - GroupApplications
            
            _viewImportGroupApplications = new MandCo.Theme.IO.TextSection(this)
            			{
            				Height = 1,
            				Width = 51
            			};
            var txtGroupApplicationsGroupID = new MandCo.Theme.IO.TextBox()
            			{
            				Width = 20,
            				Data = GroupApplications.GroupID
            			};
            var txtGroupApplicationsApplication1 = new MandCo.Theme.IO.TextBox()
            			{
            				Left = 21,
            				Width = 30,
            				Data = GroupApplications.Application1
            			};
            _viewImportGroupApplications.Controls.Add(txtGroupApplicationsApplication1);
            _viewImportGroupApplications.Controls.Add(txtGroupApplicationsGroupID);
            
            #endregion
        }
        void InitializeDataView()
        {
            From = GroupApplications;
            OrderBy = GroupApplications.SortBySA_GROUPAPP_X1;
            
            #region Columns
            
            Columns.Add(GroupApplications.GroupID);
            Columns.Add(GroupApplications.Application1);
            #endregion
        }
        
        #region Run Overloads
        
        /// <summary>Import - GroupApplications</summary>
        public void Run()
        {
            Execute();
        }
        #endregion
        
        protected override void OnLoad()
        {
            Exit(ExitTiming.BeforeRow, () => _ioImportGroupApplic.EndOfFile);
            RowLocking = LockingStrategy.OnRowLoading;
            TransactionScope = TransactionScopes.Task;
            OnDatabaseErrorRetry = true;
            Activity = Activities.Insert;
            AllowUserAbort = true;
            
            _ioImportGroupApplic = new ENV.IO.FileReader(@"%magic%\sa\SA_GroupApp.TXT")
            			{
            				Name = "Import - GroupApplic"
            			};
            Streams.Add(_ioImportGroupApplic);
        }
        protected override void OnLeaveRow()
        {
            _viewImportGroupApplications.ReadFrom(_ioImportGroupApplic);
        }
        
        
    }
}
