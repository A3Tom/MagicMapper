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
using Firefly.Box.Flow;
namespace MandCo.SystemAccess
{
    
    /// <summary>Lookup - Applications(P#17)</summary>
    // Last change before Migration: 21/12/2010 16:03:21
    internal class LookupApplications : UIControllerBase 
    {
        
        #region Models
        
        /// <summary>Applications</summary>
        internal readonly Models.Applications1 Applications1 = new Models.Applications1 { ReadOnly = true };
        #endregion
        
        #region Columns
        
        /// <summary>v:Application</summary>
        readonly Types.Application1 vApplication = new Types.Application1
        {
        	Caption = "v:Application"
        };
        #endregion
        
        
        /// <summary>Lookup - Applications(P#17)</summary>
        public LookupApplications()
        {
            Title = "Lookup - Applications";
            InitializeDataView();
        }
        void InitializeDataView()
        {
            From = Applications1;
            OrderBy = Applications1.SortBySA_UP_APP_X1;
            
            #region Columns
            
            Columns.Add(vApplication);
            Columns.Add(Applications1.Application1);
            Columns.Add(Applications1.ApplicationDescript);
            #endregion
        }
        
        #region Run Overloads
        
        /// <summary>Lookup - Applications</summary>
        /// <param name="pvApplication">v:Application</param>
        public void Run(TextParameter pvApplication)
        {
            BindParameter(vApplication, pvApplication);
            Execute();
        }
        #endregion
        
        protected override void OnLoad()
        {
            RowLocking = LockingStrategy.OnUserEdit;
            TransactionScope = TransactionScopes.RowLocking;
            OnDatabaseErrorRetry = false;
            Activity = Activities.Browse;
            SwitchToInsertWhenNoRows = true;
            AllowDelete = false;
            AllowInsert = false;
            AllowUpdate = false;
            AllowSelect = true;
            View = ()=> new Views.LookupApplicationsView(this);
        }
        protected override void OnSavingRow()
        {
            vApplication.Value = Applications1.Application1;
        }
        
        
    }
}
