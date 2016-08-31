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
    
    /// <summary>Maint - Applications(P#7)</summary>
    // Last change before Migration: 21/12/2010 16:01:00
    internal class MaintApplications : UIControllerBase 
    {
        
        #region Models
        
        /// <summary>Applications</summary>
        internal readonly Models.Applications1 Applications1 = new Models.Applications1 { AllowRowLocking = true };
        #endregion
        
        
        /// <summary>Maint - Applications(P#7)</summary>
        public MaintApplications()
        {
            Title = "Maint - Applications";
            InitializeDataView();
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
        
        /// <summary>Maint - Applications</summary>
        public void Run()
        {
            Execute();
        }
        #endregion
        
        protected override void OnLoad()
        {
            RowLocking = LockingStrategy.OnUserEdit;
            TransactionScope = TransactionScopes.RowLocking;
            OnDatabaseErrorRetry = false;
            SwitchToInsertWhenNoRows = true;
            BindAllowDelete(() => Roles.AccessControl3.Allowed);
            BindAllowInsert(() => Roles.AccessControl3.Allowed);
            BindAllowUpdate(() => Roles.AccessControl3.Allowed);
            BindConfirmUpdate(() => Activity == Activities.Update || Activity == Activities.Delete);
            BindConfirmDelete(() => Activity == Activities.Update || Activity == Activities.Delete);
            GoToToNextRowAfterLastControl = true;
            View = ()=> new Views.MaintApplicationsApplications(this);
        }
        
        #region Expressions
        internal Bool Exp_3()
        {
            return Activity == Activities.Insert;
        }
        #endregion
        
        
    }
}
