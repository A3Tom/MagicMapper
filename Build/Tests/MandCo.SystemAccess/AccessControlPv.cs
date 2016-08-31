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
using Firefly.Box.Advanced;
namespace MandCo.SystemAccess
{
    
    /// <summary>Access Control(pv)(P#46)</summary>
    // Last change before Migration: 16/07/2007 16:09:04
    internal class AccessControlPv : BusinessProcessBase 
    {
        
        #region Models
        
        /// <summary>UserGroups</summary>
        readonly Models.UserGroups UserGroups = new Models.UserGroups { Cached = false, ReadOnly = true };
        
        /// <summary>Users</summary>
        readonly Models.Users Users = new Models.Users { Cached = false, ReadOnly = true };
        
        /// <summary>Version</summary>
        readonly Models.Version Version = new Models.Version { ReadOnly = true };
        #endregion
        
        
        /// <summary>Access Control(pv)(P#46)</summary>
        public AccessControlPv()
        {
            Title = "Access Control(pv)";
            InitializeDataView();
        }
        void InitializeDataView()
        {
            From = UserGroups;
            Relations.Add(Users, 
            		Users.UserID.IsEqualTo(() => ENV.Security.UserManager.CurrentUser.Name), 
            	Users.SortBySA_USER_X1);
            
            Relations.Add(Version);
            
            Where.Add(UserGroups.UserID.IsEqualTo(() => ENV.Security.UserManager.CurrentUser.Name));
            OrderBy = UserGroups.SortBySA_USERGROUP_X2;
            
            #region Columns
            
            Columns.Add(UserGroups.UserID);
            Columns.Add(UserGroups.GroupID);
            // Get User Name
            Columns.Add(Users.UserID);
            Columns.Add(Users.UserName);
            // Get Version & Service Pack info
            Columns.Add(Version.Version1);
            Columns.Add(Version.ServicePack);
            #endregion
        }
        protected override void OnLoad()
        {
            Activity = Activities.Browse;
            AllowUserAbort = true;
        }
        protected override void OnStart()
        {
            Cached<DeleteAccessList>().Run();
        }
        protected override void OnLeaveRow()
        {
            Cached<CreateAccessList>().Run();
        }
        protected override void OnEnd()
        {
            new AccessScreen(this).Run();
        }
        
        
        
        /// <summary>AccessScreen(P#46.1)</summary>
        // Last change before Migration: 16/07/2007 16:09:04
        internal class AccessScreen : UIControllerBase 
        {
            
            #region Models
            
            /// <summary>UserAccessList</summary>
            internal readonly Models.UserAccessList UserAccessList = new Models.UserAccessList { ReadOnly = true };
            
            /// <summary>Applications</summary>
            internal readonly Models.Applications Applications = new Models.Applications { Cached = false, ReadOnly = true };
            #endregion
            
            #region Columns
            
            /// <summary>v:Select</summary>
            internal readonly TextColumn vSelect = new TextColumn("v:Select", "U");
            
            /// <summary>v:Exit</summary>
            internal readonly TextColumn vExit = new TextColumn("v:Exit", "U");
            
            /// <summary>v:ChosenApplication</summary>
            readonly Types.Application1 vChosenApplication = new Types.Application1
            {
            	Caption = "v:ChosenApplication"
            };
            #endregion
            
            AccessControlPv _parent;
            
            
            /// <summary>AccessScreen(P#46.1)</summary>
            public AccessScreen(AccessControlPv parent)
            {
                _parent = parent;
                Title = "AccessScreen";
                InitializeDataView();
                #region Event Handlers
                
                Handlers.Add(Command.Select).Invokes += SelectHandler;
                
                Handlers.Add(Commands.CustomCommand_1).Invokes += CustomCommand_1Handler;
                
                #endregion
            }
            void InitializeDataView()
            {
                From = UserAccessList;
                Relations.Add(Applications, 
                		Applications.Application1.IsEqualTo(UserAccessList.Application1), 
                	Applications.SortBySA_APP_X1);
                
                OrderBy = UserAccessList.SortByUserAccess_X1;
                
                #region Columns
                
                Columns.Add(vSelect);
                Columns.Add(vExit);
                Columns.Add(vChosenApplication);
                
                Columns.Add(UserAccessList.Application1);
                
                Columns.Add(Applications.Application1);
                Columns.Add(Applications.ApplicationNumber);
                Columns.Add(Applications.ApplicationDescript);
                #endregion
            }
            
            #region Run Overloads
            
            /// <summary>AccessScreen</summary>
            internal void Run()
            {
                Execute();
            }
            #endregion
            
            protected override void OnLoad()
            {
                OnDatabaseErrorRetry = false;
                Activity = Activities.Browse;
                SwitchToInsertWhenNoRows = true;
                AllowDelete = false;
                AllowInsert = false;
                AllowUpdate = false;
                AllowSelect = true;
                View = ()=> new Views.AccessControlPvSystemAccess(this);
            }
            protected override void OnEnd()
            {
                if(u.KBGet(1) == Command.Select)
                {
                    vChosenApplication.Value = UserAccessList.Application1;
                    Cached<OpenApplication>().Run();
                }
            }
            
            #region Handlers
            void SelectHandler(HandlerInvokeEventArgs e)
            {
                Cached<OpenApplication>().Run();
                e.Handled = true;
            }
            void CustomCommand_1Handler(HandlerInvokeEventArgs e)
            {
                Cached<OpenApplication>().Run();
                e.Handled = true;
            }
            #endregion
            
            #region Expressions
            internal Text Exp_1()
            {
                return u.DStr(Date.Now, "WWWWWWWWW  DD MMMMMMMMM YYYY");
            }
            internal Text Exp_2()
            {
                return "Good " + u.If(u.TStr(Time.Now, "HH:MM") > "17:00", "evening", u.If(u.TStr(Time.Now, "HH:MM") > "12:00", "afternoon", "morning")) + " " + u.Trim(_parent.Users.UserName) + ",";
            }
            internal Text Exp_6()
            {
                return "Magic for Windows 95/NT - Version " + u.Trim(_parent.Version.Version1) + "/SP" + u.Trim(_parent.Version.ServicePack);
            }
            #endregion
            
            
            
            /// <summary>OpenApplication(P#46.1.1)</summary>
            // Last change before Migration: 06/08/2001 14:18:47
            class OpenApplication : BusinessProcessBase 
            {
                
                #region Columns
                
                /// <summary>v:Counter</summary>
                readonly NumberColumn vCounter = new NumberColumn("v:Counter", "4");
                #endregion
                
                AccessScreen _parent;
                
                
                /// <summary>OpenApplication(P#46.1.1)</summary>
                public OpenApplication(AccessScreen parent)
                {
                    _parent = parent;
                    Title = "OpenApplication";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    #region Columns
                    
                    Columns.Add(vCounter);
                    #endregion
                }
                
                #region Run Overloads
                
                /// <summary>OpenApplication</summary>
                internal void Run()
                {
                    Execute();
                }
                #endregion
                
                protected override void OnLoad()
                {
                    Exit(ExitTiming.BeforeRow, () => vCounter == _parent.Applications.ApplicationNumber);
                    Activity = Activities.Browse;
                    AllowUserAbort = true;
                }
                protected override void OnStart()
                {
                    vCounter.Value = 0;
                    // Minimize to hide 'Open Application' dialogue
                    u.WinMinimize();
                    u.KBPut(Commands.RestartApplication);
                    Cached<GoTopApplications>().Run();
                    // Positioned on title bar of Applications List
                }
                protected override void OnLeaveRow()
                {
                    // Move down Application List until positioned on seleced Application
                    u.KBPut(Command.GoToNextRow);
                    vCounter.Value++;
                }
                protected override void OnEnd()
                {
                    u.KBPut(Command.Select);
                }
                
                
                
                /// <summary>GoTopApplications(P#46.1.1.1)</summary>
                // Last change before Migration: 27/03/2000 18:01:46
                class GoTopApplications : BusinessProcessBase 
                {
                    
                    #region Columns
                    
                    /// <summary>v:UpCounter</summary>
                    readonly NumberColumn vUpCounter = new NumberColumn("v:UpCounter", "###");
                    #endregion
                    
                    
                    /// <summary>GoTopApplications(P#46.1.1.1)</summary>
                    public GoTopApplications()
                    {
                        Title = "GoTopApplications";
                        InitializeDataView();
                    }
                    void InitializeDataView()
                    {
                        #region Columns
                        
                        Columns.Add(vUpCounter);
                        #endregion
                    }
                    
                    #region Run Overloads
                    
                    /// <summary>GoTopApplications</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    #endregion
                    
                    protected override void OnLoad()
                    {
                        Exit(ExitTiming.BeforeRow, () => vUpCounter == 100);
                        Activity = Activities.Browse;
                        AllowUserAbort = true;
                    }
                    protected override void OnLeaveRow()
                    {
                        u.KBPut(Command.GoToPreviousRow);
                        vUpCounter.Value++;
                    }
                    
                    
                }
            }
        }
        
        /// <summary>DeleteAccessList(P#46.2)</summary>
        // Last change before Migration: 06/08/2001 12:42:54
        class DeleteAccessList : BusinessProcessBase 
        {
            
            
            /// <summary>DeleteAccessList(P#46.2)</summary>
            public DeleteAccessList()
            {
                Title = "DeleteAccessList";
            }
            
            #region Run Overloads
            
            /// <summary>DeleteAccessList</summary>
            internal void Run()
            {
                Execute();
            }
            #endregion
            
            protected override void OnLoad()
            {
                Exit(ExitTiming.AfterRow);
                KeepChildRelationCacheAlive = true;
                AllowUserAbort = true;
            }
            protected override void OnStart()
            {
                u.DBDel(typeof(Models.UserAccessList), "");
            }
            
            
        }
        
        /// <summary>CreateAccessList(P#46.3)</summary>
        // Last change before Migration: 06/08/2001 12:52:58
        class CreateAccessList : BusinessProcessBase 
        {
            
            #region Models
            
            /// <summary>GroupApplications</summary>
            readonly Models.GroupApplications GroupApplications = new Models.GroupApplications { Cached = false, ReadOnly = true };
            
            /// <summary>UserAccessList</summary>
            readonly Models.UserAccessList UserAccessList = new Models.UserAccessList { KeepCacheAliveAfterExit = true, AllowRowLocking = true };
            #endregion
            
            AccessControlPv _parent;
            
            
            /// <summary>CreateAccessList(P#46.3)</summary>
            public CreateAccessList(AccessControlPv parent)
            {
                _parent = parent;
                Title = "CreateAccessList";
                InitializeDataView();
            }
            void InitializeDataView()
            {
                From = GroupApplications;
                Relations.Add(UserAccessList, RelationType.Insert, 
                		UserAccessList.Application1.BindEqualTo(GroupApplications.Application1), 
                	UserAccessList.SortByUserAccess_X1);
                
                Where.Add(GroupApplications.GroupID.IsEqualTo(_parent.UserGroups.GroupID));
                OrderBy = GroupApplications.SortBySA_GROUPAPP_X1;
                
                #region Columns
                
                Columns.Add(GroupApplications.GroupID);
                Columns.Add(GroupApplications.Application1);
                // Create Access List, excluding Duplicates
                Columns.Add(UserAccessList.Application1);
                #endregion
            }
            
            #region Run Overloads
            
            /// <summary>CreateAccessList</summary>
            internal void Run()
            {
                Execute();
            }
            #endregion
            
            protected override void OnLoad()
            {
                KeepChildRelationCacheAlive = true;
                AllowUserAbort = true;
            }
            
            
        }
    }
}
