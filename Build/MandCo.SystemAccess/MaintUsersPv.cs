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
    
    /// <summary>Maint - Users(pv)(P#47)</summary>
    // Last change before Migration: 11/09/2003 09:53:46
    internal class MaintUsersPv : FlowUIControllerBase 
    {
        
        #region Models
        
        /// <summary>Users</summary>
        internal readonly Models.Users Users = new Models.Users { Cached = false, AllowRowLocking = true };
        #endregion
        
        #region Columns
        
        /// <summary>v:In Sub Task</summary>
        readonly BoolColumn vInSubTask = new BoolColumn("v:In Sub Task");
        
        /// <summary>v:High Seq</summary>
        readonly NumberColumn vHighSeq = new NumberColumn("v:High Seq", "2");
        #endregion
        
        
        /// <summary>Maint - Users(pv)(P#47)</summary>
        public MaintUsersPv()
        {
            Title = "Maint - Users(pv)";
            InitializeDataViewAndUserFlow();
        }
        void InitializeDataViewAndUserFlow()
        {
            From = Users;
            OrderBy = Users.SortBySA_USER_X1;
            
            #region Columns and User Flow
            
            Columns.Add(vInSubTask);
            Columns.Add(vHighSeq).BindValue(() => 0);
            
            Columns.Add(Users.UserID);
            Columns.Add(Users.UserName);
            
            Flow.Add<EmailAddresses>(c => 
            	{
            		LockCurrentRow();
            		c.Run();
            	}, FlowMode.Tab);
            #endregion
        }
        protected override void OnLoad()
        {
            RowLocking = LockingStrategy.OnUserEdit;
            TransactionScope = TransactionScopes.RowLocking;
            OnDatabaseErrorRetry = false;
            BindAllowDelete(() => Roles.AccessControl3.Allowed);
            BindAllowInsert(() => Roles.AccessControl3.Allowed);
            BindAllowUpdate(() => Roles.AccessControl3.Allowed);
            GoToToNextRowAfterLastControl = true;
            View = ()=> new Views.MaintUsersPvUsers(this);
        }
        protected override void OnEnterRow()
        {
            Cached<EmailAddresses>().Run();
        }
        protected override void OnSavingRow()
        {
            // if in delete mode
            if(Activity == Activities.Delete)
            {
                LockCurrentRow();
                Cached<DeleteChildren>().Run();
            }
        }
        
        #region Expressions
        internal Number Exp_1()
        {
            return u.If(vInSubTask, 3, 5);
        }
        #endregion
        
        
        
        /// <summary>Email Addresses(P#47.1)</summary>
        // Last change before Migration: 08/05/2003 15:00:42
        internal class EmailAddresses : UIControllerBase 
        {
            
            #region Models
            
            /// <summary>User Email Addresses</summary>
            internal readonly Models.UserEmailAddresses UserEmailAddresses = new Models.UserEmailAddresses { AllowRowLocking = true };
            #endregion
            
            MaintUsersPv _parent;
            
            
            /// <summary>Email Addresses(P#47.1)</summary>
            public EmailAddresses(MaintUsersPv parent)
            {
                _parent = parent;
                Title = "Email Addresses";
                InitializeDataView();
            }
            void InitializeDataView()
            {
                From = UserEmailAddresses;
                Where.Add(UserEmailAddresses.MagicUser.BindEqualTo(_parent.Users.UserID));
                OrderBy = UserEmailAddresses.SortBySA_User_Email_Addresses_X1;
                
                #region Columns
                
                Columns.Add(UserEmailAddresses.MagicUser);
                Columns.Add(UserEmailAddresses.AddressSeq).BindValue(() => _parent.vHighSeq + 1);
                Columns.Add(UserEmailAddresses.EmailAddress);
                #endregion
            }
            
            #region Run Overloads
            
            /// <summary>Email Addresses</summary>
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
                KeepChildRelationCacheAlive = true;
                SwitchToInsertWhenNoRows = true;
                KeepViewVisibleAfterExit = true;
                if(NewViewRequired)
                {
                    View = ()=> new Views.MaintUsersPvEmailAddresses(this);
                }
            }
            protected override void OnStart()
            {
                _parent.vInSubTask.Value = true;
                Cached<GetHighSeqNo>().Run();
            }
            protected override void OnSavingRow()
            {
                _parent.vHighSeq.Value++;
            }
            protected override void OnEnd()
            {
                _parent.vInSubTask.Value = false;
            }
            
            #region Expressions
            internal Bool Exp_3()
            {
                return Activity == Activities.Insert;
            }
            #endregion
            
            
            
            /// <summary>Get High Seq No(P#47.1.1)</summary>
            // Last change before Migration: 08/05/2003 12:42:08
            class GetHighSeqNo : BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>User Email Addresses</summary>
                readonly Models.UserEmailAddresses UserEmailAddresses = new Models.UserEmailAddresses { AllowRowLocking = true };
                #endregion
                
                EmailAddresses _parent;
                
                
                /// <summary>Get High Seq No(P#47.1.1)</summary>
                public GetHighSeqNo(EmailAddresses parent)
                {
                    _parent = parent;
                    Title = "Get High Seq No";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    From = UserEmailAddresses;
                    Where.Add(UserEmailAddresses.MagicUser.IsEqualTo(_parent._parent.Users.UserID));
                    OrderBy = UserEmailAddresses.SortBySA_User_Email_Addresses_X1;
                    
                    #region Columns
                    
                    Columns.Add(UserEmailAddresses.MagicUser);
                    Columns.Add(UserEmailAddresses.AddressSeq);
                    #endregion
                }
                
                #region Run Overloads
                
                /// <summary>Get High Seq No</summary>
                internal void Run()
                {
                    Execute();
                }
                #endregion
                
                protected override void OnLoad()
                {
                    AllowUserAbort = true;
                    KeepViewVisibleAfterExit = true;
                }
                protected override void OnLeaveRow()
                {
                    _parent._parent.vHighSeq.Value = u.Max(_parent._parent.vHighSeq, UserEmailAddresses.AddressSeq);
                }
                
                
            }
        }
        
        /// <summary>Delete Children(P#47.2)</summary>
        // Last change before Migration: 08/05/2003 14:23:52
        class DeleteChildren : BusinessProcessBase 
        {
            
            #region Models
            
            /// <summary>User Email Addresses</summary>
            readonly Models.UserEmailAddresses UserEmailAddresses = new Models.UserEmailAddresses { AllowRowLocking = true };
            #endregion
            
            MaintUsersPv _parent;
            
            
            /// <summary>Delete Children(P#47.2)</summary>
            public DeleteChildren(MaintUsersPv parent)
            {
                _parent = parent;
                Title = "Delete Children";
                InitializeDataView();
            }
            void InitializeDataView()
            {
                From = UserEmailAddresses;
                Where.Add(UserEmailAddresses.MagicUser.IsEqualTo(_parent.Users.UserID));
                OrderBy = UserEmailAddresses.SortBySA_User_Email_Addresses_X1;
                
                #region Columns
                
                Columns.Add(UserEmailAddresses.MagicUser);
                #endregion
            }
            
            #region Run Overloads
            
            /// <summary>Delete Children</summary>
            internal void Run()
            {
                Execute();
            }
            #endregion
            
            protected override void OnLoad()
            {
                RowLocking = LockingStrategy.OnRowLoading;
                TransactionScope = TransactionScopes.RowLocking;
                Activity = Activities.Delete;
                AllowUserAbort = true;
                KeepViewVisibleAfterExit = true;
            }
            
            
        }
    }
}
