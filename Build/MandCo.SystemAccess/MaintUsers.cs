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
    
    /// <summary>Maint - Users(P#5)</summary>
    // Last change before Migration: 12/06/2008 09:15:23
    internal class MaintUsers : FlowUIControllerBase 
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
        
        
        /// <summary>Maint - Users(P#5)</summary>
        public MaintUsers()
        {
            Title = "Maint - Users";
            InitializeDataViewAndUserFlow();
        }
        void InitializeDataViewAndUserFlow()
        {
            From = Users;
            OrderBy = Users.SortBySA_USER_X1;
            
            #region Columns and User Flow
            
            Columns.Add(vInSubTask);
            Columns.Add(vHighSeq);
            
            Columns.Add(Users.UserID);
            Flow.Add(() => Message.ShowErrorInStatusBar("Cannot be Blank!!"), () => u.Len(u.Trim(Users.UserID)) == 0);
            Flow.Add(() => Message.ShowErrorInStatusBar("Cannot set up " + u.Trim(Users.UserID) + " as a User on this system!"), () => u.Upper(u.Left(u.Trim(Users.UserID), 5)) == "MAGIC");
            Columns.Add(Users.UserName);
            
            Flow.Add<EmailAddresses>(c => 
            	{
            		LockCurrentRow();
            		c.Run();
            	}, FlowMode.Tab);
            #endregion
        }
        
        #region Run Overloads
        
        /// <summary>Maint - Users</summary>
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
            BindAllowDelete(() => Roles.AccessControl3.Allowed);
            BindAllowInsert(() => Roles.AccessControl3.Allowed);
            BindAllowUpdate(() => Roles.AccessControl3.Allowed);
            GoToToNextRowAfterLastControl = true;
            View = ()=> new Views.MaintUsersUsers(this);
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
        internal Number Exp_4()
        {
            return u.If(vInSubTask, 3, 5);
        }
        internal Bool Exp_7()
        {
            return Activity == Activities.Insert;
        }
        #endregion
        
        
        
        /// <summary>Email Addresses(P#5.1)</summary>
        // Last change before Migration: 12/06/2008 09:15:23
        internal class EmailAddresses : UIControllerBase 
        {
            
            #region Models
            
            /// <summary>User Email Addresses</summary>
            internal readonly Models.UserEmailAddresses UserEmailAddresses = new Models.UserEmailAddresses { AllowRowLocking = true };
            #endregion
            
            MaintUsers _parent;
            
            
            /// <summary>Email Addresses(P#5.1)</summary>
            public EmailAddresses(MaintUsers parent)
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
                Columns.Add(UserEmailAddresses.AddressSeq).BindValue(() => 1);
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
                    View = ()=> new Views.MaintUsersEmailAddresses(this);
                }
            }
            protected override void OnStart()
            {
                _parent.vInSubTask.Value = true;
                Cached<GetHighSeqNo>().Run();
            }
            protected override void OnSavingRow()
            {
                _parent.vHighSeq.Value = 1;
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
            
            
            
            /// <summary>Get High Seq No(P#5.1.1)</summary>
            // Last change before Migration: 08/05/2003 12:42:08
            class GetHighSeqNo : BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>User Email Addresses</summary>
                readonly Models.UserEmailAddresses UserEmailAddresses = new Models.UserEmailAddresses { AllowRowLocking = true };
                #endregion
                
                EmailAddresses _parent;
                
                
                /// <summary>Get High Seq No(P#5.1.1)</summary>
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
        
        /// <summary>Delete Children(P#5.2)</summary>
        // Last change before Migration: 08/05/2003 14:23:52
        class DeleteChildren : BusinessProcessBase 
        {
            
            #region Models
            
            /// <summary>User Email Addresses</summary>
            readonly Models.UserEmailAddresses UserEmailAddresses = new Models.UserEmailAddresses { AllowRowLocking = true };
            #endregion
            
            MaintUsers _parent;
            
            
            /// <summary>Delete Children(P#5.2)</summary>
            public DeleteChildren(MaintUsers parent)
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
