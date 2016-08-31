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
    
    /// <summary>Export - User Email Addresses(P#33)</summary>
    // Last change before Migration: 27/02/2004 17:38:05
    class ExportUserEmailAddresses : BusinessProcessBase 
    {
        
        #region Models
        
        /// <summary>User Email Addresses</summary>
        readonly Models.UserEmailAddresses UserEmailAddresses = new Models.UserEmailAddresses { ReadOnly = true };
        #endregion
        
        #region Streams
        
        /// <summary>Export - User Email</summary>
        ENV.IO.FileWriter _ioExportUserEmail;
        #endregion
        
        #region Layouts
        
        /// <summary>Export - User Email Addresses</summary>
        MandCo.Theme.IO.TextSection _viewExportUserEmailAddresses;
        #endregion
        
        
        /// <summary>Export - User Email Addresses(P#33)</summary>
        public ExportUserEmailAddresses()
        {
            Title = "Export - User Email Addresses";
            ConfirmExecution = true;
            InitializeDataView();
            #region form Export - User Email Addresses
            
            _viewExportUserEmailAddresses = new MandCo.Theme.IO.TextSection(this)
            			{
            				Height = 1,
            				Width = 112
            			};
            var txtUserEmailAddressesMagicUser = new MandCo.Theme.IO.TextBox()
            			{
            				Width = 8,
            				Data = UserEmailAddresses.MagicUser
            			};
            var txtUserEmailAddressesAddressSeq = new MandCo.Theme.IO.TextBox()
            			{
            				Left = 9,
            				Width = 2,
            				Data = UserEmailAddresses.AddressSeq
            			};
            var txtUserEmailAddressesEmailAddress = new MandCo.Theme.IO.TextBox()
            			{
            				Left = 12,
            				Width = 100,
            				Data = UserEmailAddresses.EmailAddress
            			};
            _viewExportUserEmailAddresses.Controls.Add(txtUserEmailAddressesEmailAddress);
            _viewExportUserEmailAddresses.Controls.Add(txtUserEmailAddressesAddressSeq);
            _viewExportUserEmailAddresses.Controls.Add(txtUserEmailAddressesMagicUser);
            
            #endregion
        }
        void InitializeDataView()
        {
            From = UserEmailAddresses;
            OrderBy = UserEmailAddresses.SortBySA_User_Email_Addresses_X1;
            
            #region Columns
            
            Columns.Add(UserEmailAddresses.MagicUser);
            Columns.Add(UserEmailAddresses.AddressSeq);
            Columns.Add(UserEmailAddresses.EmailAddress);
            #endregion
        }
        
        #region Run Overloads
        
        /// <summary>Export - User Email Addresses</summary>
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
            
            _ioExportUserEmail = new ENV.IO.FileWriter(@"%magic%\sa\SA_User_Email_Addresses.TXT")
            			{
            				Name = "Export - User Email"
            			};
            _ioExportUserEmail.Open();
            Streams.Add(_ioExportUserEmail);
        }
        protected override void OnLeaveRow()
        {
            _viewExportUserEmailAddresses.WriteTo(_ioExportUserEmail);
        }
        
        
    }
}
