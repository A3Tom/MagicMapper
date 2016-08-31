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
    
    /// <summary>Import - Applications(P#38)</summary>
    // Last change before Migration: 21/12/2010 16:08:29
    class ImportApplications : BusinessProcessBase 
    {
        
        #region Models
        
        /// <summary>Applications</summary>
        readonly Models.Applications1 Applications1 = new Models.Applications1 { AllowRowLocking = true };
        #endregion
        
        #region Streams
        
        /// <summary>Import - Application</summary>
        ENV.IO.FileReader _ioImportApplication;
        #endregion
        
        #region Layouts
        
        /// <summary>Import - Applications</summary>
        MandCo.Theme.IO.TextSection _viewImportApplications;
        #endregion
        
        
        /// <summary>Import - Applications(P#38)</summary>
        public ImportApplications()
        {
            Title = "Import - Applications";
            ConfirmExecution = true;
            InitializeDataView();
            #region form Import - Applications
            
            _viewImportApplications = new MandCo.Theme.IO.TextSection(this)
            			{
            				Height = 1,
            				Width = 84
            			};
            var txtApplications1Application1 = new MandCo.Theme.IO.TextBox()
            			{
            				Width = 30,
            				Data = Applications1.Application1
            			};
            var txtApplications1ApplicationID = new MandCo.Theme.IO.TextBox()
            			{
            				Left = 31,
            				Width = 2,
            				Data = Applications1.ApplicationID
            			};
            var txtApplications1ApplicationDescript = new MandCo.Theme.IO.TextBox()
            			{
            				Left = 34,
            				Width = 50,
            				Data = Applications1.ApplicationDescript
            			};
            _viewImportApplications.Controls.Add(txtApplications1ApplicationDescript);
            _viewImportApplications.Controls.Add(txtApplications1ApplicationID);
            _viewImportApplications.Controls.Add(txtApplications1Application1);
            
            #endregion
        }
        void InitializeDataView()
        {
            From = Applications1;
            OrderBy = Applications1.SortBySA_UP_APP_X1;
            
            #region Columns
            
            Columns.Add(Applications1.Application1);
            Columns.Add(Applications1.ApplicationID);
            Columns.Add(Applications1.ApplicationDescript);
            #endregion
        }
        
        #region Run Overloads
        
        /// <summary>Import - Applications</summary>
        public void Run()
        {
            Execute();
        }
        #endregion
        
        protected override void OnLoad()
        {
            Exit(ExitTiming.BeforeRow, () => _ioImportApplication.EndOfFile);
            RowLocking = LockingStrategy.OnRowLoading;
            TransactionScope = TransactionScopes.Task;
            OnDatabaseErrorRetry = true;
            Activity = Activities.Insert;
            AllowUserAbort = true;
            
            _ioImportApplication = new ENV.IO.FileReader(@"%magic%\sa\SA_App.TXT")
            			{
            				Name = "Import - Application"
            			};
            Streams.Add(_ioImportApplication);
        }
        protected override void OnLeaveRow()
        {
            _viewImportApplications.ReadFrom(_ioImportApplication);
        }
        
        
    }
}
