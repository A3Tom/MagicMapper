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
    
    /// <summary>Export - GroupApplications(P#32)</summary>
    // Last change before Migration: 27/02/2004 17:38:01
    class ExportGroupApplications : BusinessProcessBase 
    {
        
        #region Models
        
        /// <summary>GroupApplications</summary>
        readonly Models.GroupApplications GroupApplications = new Models.GroupApplications { ReadOnly = true };
        #endregion
        
        #region Streams
        
        /// <summary>Export - GroupApplic</summary>
        ENV.IO.FileWriter _ioExportGroupApplic;
        #endregion
        
        #region Layouts
        
        /// <summary>Export - GroupApplications</summary>
        MandCo.Theme.IO.TextSection _viewExportGroupApplications;
        #endregion
        
        
        /// <summary>Export - GroupApplications(P#32)</summary>
        public ExportGroupApplications()
        {
            Title = "Export - GroupApplications";
            ConfirmExecution = true;
            InitializeDataView();
            #region form Export - GroupApplications
            
            _viewExportGroupApplications = new MandCo.Theme.IO.TextSection(this)
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
            _viewExportGroupApplications.Controls.Add(txtGroupApplicationsApplication1);
            _viewExportGroupApplications.Controls.Add(txtGroupApplicationsGroupID);
            
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
        
        /// <summary>Export - GroupApplications</summary>
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
            
            _ioExportGroupApplic = new ENV.IO.FileWriter(@"%magic%\sa\SA_GroupApp.TXT")
            			{
            				Name = "Export - GroupApplic"
            			};
            _ioExportGroupApplic.Open();
            Streams.Add(_ioExportGroupApplic);
        }
        protected override void OnLeaveRow()
        {
            _viewExportGroupApplications.WriteTo(_ioExportGroupApplic);
        }
        
        
    }
}
