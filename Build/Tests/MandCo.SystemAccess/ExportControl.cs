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
    
    /// <summary>Export - Control(P#34)</summary>
    // Last change before Migration: 27/02/2004 17:38:10
    class ExportControl : BusinessProcessBase 
    {
        
        #region Models
        
        /// <summary>Control</summary>
        readonly Models.Control Control = new Models.Control { ReadOnly = true };
        #endregion
        
        #region Streams
        
        /// <summary>Export - Control</summary>
        ENV.IO.FileWriter _ioExportControl;
        #endregion
        
        #region Layouts
        
        /// <summary>Export - Control</summary>
        MandCo.Theme.IO.TextSection _viewExportControl;
        #endregion
        
        
        /// <summary>Export - Control(P#34)</summary>
        public ExportControl()
        {
            Title = "Export - Control";
            ConfirmExecution = true;
            InitializeDataView();
            #region form Export - Control
            
            _viewExportControl = new MandCo.Theme.IO.TextSection(this)
            			{
            				Height = 1,
            				Width = 123
            			};
            var txtControlRecordType = new MandCo.Theme.IO.TextBox()
            			{
            				Width = 10,
            				Data = Control.RecordType
            			};
            var txtControlRecordSubType = new MandCo.Theme.IO.TextBox()
            			{
            				Left = 11,
            				Width = 10,
            				Data = Control.RecordSubType
            			};
            var txtControlDelimitedDataString = new MandCo.Theme.IO.TextBox()
            			{
            				Left = 22,
            				Width = 50,
            				Data = Control.DelimitedDataString
            			};
            var txtControlComments = new MandCo.Theme.IO.TextBox()
            			{
            				Left = 73,
            				Width = 50,
            				Data = Control.Comments
            			};
            _viewExportControl.Controls.Add(txtControlComments);
            _viewExportControl.Controls.Add(txtControlDelimitedDataString);
            _viewExportControl.Controls.Add(txtControlRecordSubType);
            _viewExportControl.Controls.Add(txtControlRecordType);
            
            #endregion
        }
        void InitializeDataView()
        {
            From = Control;
            OrderBy = Control.SortBySA_Control_X1;
            
            #region Columns
            
            Columns.Add(Control.RecordType);
            Columns.Add(Control.RecordSubType);
            Columns.Add(Control.DelimitedDataString);
            Columns.Add(Control.Comments);
            #endregion
        }
        
        #region Run Overloads
        
        /// <summary>Export - Control</summary>
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
            
            _ioExportControl = new ENV.IO.FileWriter(@"%magic%\sa\SA_Control.TXT")
            			{
            				Name = "Export - Control"
            			};
            _ioExportControl.Open();
            Streams.Add(_ioExportControl);
        }
        protected override void OnLeaveRow()
        {
            _viewExportControl.WriteTo(_ioExportControl);
        }
        
        
    }
}
