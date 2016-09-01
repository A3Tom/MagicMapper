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
    
    /// <summary>Attach Group to Applications(P#10)</summary>
    // Last change before Migration: 21/12/2010 16:02:30
    internal class AttachGroupToApplications : FlowUIControllerBase 
    {
        
        #region Models
        
        /// <summary>Groups</summary>
        internal readonly Models.Groups1 Groups1 = new Models.Groups1 { Cached = false, AllowRowLocking = true };
        #endregion
        
        
        /// <summary>Attach Group to Applications(P#10)</summary>
        public AttachGroupToApplications()
        {
            Title = "Attach Group to Applications";
            InitializeDataViewAndUserFlow();
        }
        void InitializeDataViewAndUserFlow()
        {
            From = Groups1;
            OrderBy = Groups1.SortBySA_GROUP_X1;
            
            #region Columns and User Flow
            
            Columns.Add(Groups1.GroupID);
            
            Flow.Add<Applications>(c => 
            	{
            		LockCurrentRow();
            		c.Run();
            	}, FlowMode.Tab);
            #endregion
        }
        
        #region Run Overloads
        
        /// <summary>Attach Group to Applications</summary>
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
            Activity = Activities.Browse;
            BindAllowDelete(() => Roles.AccessControl3.Allowed);
            BindAllowInsert(() => Roles.AccessControl3.Allowed);
            BindAllowUpdate(() => Roles.AccessControl3.Allowed);
            View = ()=> new Views.AttachGroupToApplicationsView(this);
        }
        protected override void OnEnterRow()
        {
            Cached<Applications>().Run();
        }
        
        
        
        /// <summary>Applications(P#10.1)</summary>
        // Last change before Migration: 21/12/2010 16:02:30
        internal class Applications : FlowUIControllerBase 
        {
            
            #region Models
            
            /// <summary>GroupApplications</summary>
            internal readonly Models.GroupApplications GroupApplications = new Models.GroupApplications { Cached = false, AllowRowLocking = true };
            
            /// <summary>Applications</summary>
            readonly Models.Applications1 Applications1 = new Models.Applications1 { Cached = false, ReadOnly = true };
            #endregion
            
            #region Columns
            
            /// <summary>RC_LNK_1</summary>
            readonly BoolColumn RC_LNK_1 = new BoolColumn("RC_LNK_1")
            {
            	DefaultValue = true
            };
            #endregion
            
            AttachGroupToApplications _parent;
            
            
            /// <summary>Applications(P#10.1)</summary>
            public Applications(AttachGroupToApplications parent)
            {
                _parent = parent;
                Title = "Applications";
                InitializeDataViewAndUserFlow();
            }
            void InitializeDataViewAndUserFlow()
            {
                From = GroupApplications;
                Relations.Add(Applications1, 
                		Applications1.Application1.IsEqualTo(GroupApplications.Application1), 
                	Applications1.SortBySA_UP_APP_X1);
                
                Where.Add(GroupApplications.GroupID.BindEqualTo(_parent.Groups1.GroupID));
                OrderBy = GroupApplications.SortBySA_GROUPAPP_X1;
                
                #region Columns and User Flow
                
                Columns.Add(GroupApplications.GroupID);
                Columns.Add(GroupApplications.Application1);
                
                
                Columns.Add(RC_LNK_1);
                Relations[Applications1].NotifyRowWasFoundTo(RC_LNK_1);
                Flow.Add(() => Message.ShowErrorInStatusBar("Row not found in data source: " + u.DBName(typeof(Models.Applications1), 2)), () => u.Not(RC_LNK_1));
                Columns.Add(Applications1.Application1);
                #endregion
            }
            
            #region Run Overloads
            
            /// <summary>Applications</summary>
            internal void Run()
            {
                Execute();
            }
            #endregion
            
            protected override void OnLoad()
            {
                Exit(ExitTiming.BeforeRow, () => u.Level(1) == "RP");
                RowLocking = LockingStrategy.OnUserEdit;
                TransactionScope = TransactionScopes.RowLocking;
                OnDatabaseErrorRetry = false;
                BindAllowDelete(() => Roles.AccessControl3.Allowed);
                BindAllowInsert(() => Roles.AccessControl3.Allowed);
                BindAllowUpdate(() => Roles.AccessControl3.Allowed);
                BindConfirmUpdate(() => Activity == Activities.Update || Activity == Activities.Delete);
                BindConfirmDelete(() => Activity == Activities.Update || Activity == Activities.Delete);
                GoToToNextRowAfterLastControl = true;
                KeepViewVisibleAfterExit = true;
                if(NewViewRequired)
                {
                    View = ()=> new Views.AttachGroupToApplicationsApplications(this);
                }
            }
            
            
        }
    }
}
