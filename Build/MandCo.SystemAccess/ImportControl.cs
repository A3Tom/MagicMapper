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
    
    /// <summary>Import - Control(P#42)</summary>
    // Last change before Migration: 27/02/2004 17:38:39
    class ImportControl : BusinessProcessBase 
    {
        
        #region Models
        
        /// <summary>Control</summary>
        readonly Models.Control Control = new Models.Control { AllowRowLocking = true };
        #endregion
        
        #region Streams
        
        /// <summary>Import - Control</summary>
        ENV.IO.FileReader _ioImportControl;
        #endregion
        
        #region Layouts
        
        /// <summary>Import - Control</summary>
        MandCo.Theme.IO.TextSection _viewImportControl;
        #endregion
        
        
        /// <summary>Import - Control(P#42)</summary>
        public ImportControl()
        {
            Title = "Import - Control";
            ConfirmExecution = true;
            InitializeDataView();
            #region form Import - Control
            
            _viewImportControl = new MandCo.Theme.IO.TextSection(this)
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
            _viewImportControl.Controls.Add(txtControlComments);
            _viewImportControl.Controls.Add(txtControlDelimitedDataString);
            _viewImportControl.Controls.Add(txtControlRecordSubType);
            _viewImportControl.Controls.Add(txtControlRecordType);
            
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
        
        /// <summary>Import - Control</summary>
        public void Run()
        {
            Execute();
        }
        #endregion
        
        protected override void OnLoad()
        {
            Exit(ExitTiming.BeforeRow, () => _ioImportControl.EndOfFile);
            RowLocking = LockingStrategy.OnRowLoading;
            TransactionScope = TransactionScopes.Task;
            OnDatabaseErrorRetry = true;
            Activity = Activities.Insert;
            AllowUserAbort = true;
            
            _ioImportControl = new ENV.IO.FileReader(@"%magic%\sa\SA_Control.TXT")
            			{
            				Name = "Import - Control"
            			};
            Streams.Add(_ioImportControl);
        }
        protected override void OnLeaveRow()
        {
            _viewImportControl.ReadFrom(_ioImportControl);
        }
        
        
    }
}
