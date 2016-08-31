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
    
    /// <summary>Attach User to Groups(P#9)</summary>
    // Last change before Migration: 27/02/2004 17:16:49
    internal class AttachUserToGroups : FlowUIControllerBase 
    {
        
        #region Models
        
        /// <summary>Users</summary>
        internal readonly Models.Users Users = new Models.Users { Cached = false, ReadOnly = true };
        #endregion
        
        
        /// <summary>Attach User to Groups(P#9)</summary>
        public AttachUserToGroups()
        {
            Title = "Attach User to Groups";
            InitializeDataViewAndUserFlow();
        }
        void InitializeDataViewAndUserFlow()
        {
            From = Users;
            OrderBy = Users.SortBySA_USER_X1;
            
            #region Columns and User Flow
            
            Columns.Add(Users.UserID);
            Flow.Add<Groups1>(c => 
            	{
            		LockCurrentRow();
            		c.Run();
            	}, FlowMode.Tab);
            #endregion
        }
        
        #region Run Overloads
        
        /// <summary>Attach User to Groups</summary>
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
            View = ()=> new Views.AttachUserToGroupsView(this);
        }
        protected override void OnEnterRow()
        {
            Cached<Groups1>().Run();
        }
        
        
        
        /// <summary>Groups(P#9.1)</summary>
        // Last change before Migration: 27/02/2004 17:16:49
        internal class Groups1 : FlowUIControllerBase 
        {
            
            #region Models
            
            /// <summary>UserGroups</summary>
            internal readonly Models.UserGroups UserGroups = new Models.UserGroups { Cached = false, AllowRowLocking = true };
            
            /// <summary>Groups</summary>
            internal readonly Models.Groups1 Groups11 = new Models.Groups1 { Cached = false, AllowRowLocking = true };
            #endregion
            
            #region Columns
            
            /// <summary>RC_LNK_1</summary>
            readonly BoolColumn RC_LNK_1 = new BoolColumn("RC_LNK_1")
            {
            	DefaultValue = true
            };
            #endregion
            
            AttachUserToGroups _parent;
            
            
            /// <summary>Groups(P#9.1)</summary>
            public Groups1(AttachUserToGroups parent)
            {
                _parent = parent;
                Title = "Groups";
                InitializeDataViewAndUserFlow();
            }
            void InitializeDataViewAndUserFlow()
            {
                From = UserGroups;
                Relations.Add(Groups11, 
                		Groups11.GroupID.IsEqualTo(UserGroups.GroupID), 
                	Groups11.SortBySA_GROUP_X1);
                
                Where.Add(UserGroups.UserID.BindEqualTo(_parent.Users.UserID));
                OrderBy = UserGroups.SortBySA_USERGROUP_X2;
                
                #region Columns and User Flow
                
                Columns.Add(UserGroups.UserID);
                Columns.Add(UserGroups.GroupID);
                
                
                Columns.Add(RC_LNK_1);
                Relations[Groups11].NotifyRowWasFoundTo(RC_LNK_1);
                Flow.Add(() => Message.ShowErrorInStatusBar("Row not found in data source: " + u.DBName(typeof(Models.Groups1), 2)), () => u.Not(RC_LNK_1));
                Columns.Add(Groups11.GroupID);
                Columns.Add(Groups11.GroupDescription);
                #endregion
            }
            
            #region Run Overloads
            
            /// <summary>Groups</summary>
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
                    View = ()=> new Views.AttachUserToGroupsGroups(this);
                }
            }
            
            
        }
    }
}
