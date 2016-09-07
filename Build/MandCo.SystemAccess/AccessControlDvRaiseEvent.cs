﻿#region Copyright Firefly Ltd 2014
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
    
    /// <summary>Access Control(dv raise event)(P#50)</summary>
    // Last change before Migration: 16/07/2007 16:21:06
    internal class AccessControlDvRaiseEvent : BusinessProcessBase 
    {
        
        #region Models
        
        /// <summary>UserGroups</summary>
        readonly Models.UserGroups UserGroups = new Models.UserGroups { Cached = false, ReadOnly = true };
        
        /// <summary>Users</summary>
        readonly Models.Users Users = new Models.Users { Cached = false, ReadOnly = true };
        
        /// <summary>Control</summary>
        readonly Models.Control Control = new Models.Control { AllowRowLocking = true };
        
        /// <summary>Control</summary>
        readonly Models.Control Control1 = new Models.Control { AllowRowLocking = true };
        #endregion
        
        #region Columns
        
        /// <summary>v:Version</summary>
        readonly TextColumn vVersion = new TextColumn("v:Version", "10");
        
        /// <summary>v:ServicePack</summary>
        readonly TextColumn vServicePack = new TextColumn("v:ServicePack", "10");
        #endregion
        
        
        /// <summary>Access Control(dv raise event)(P#50)</summary>
        public AccessControlDvRaiseEvent()
        {
            Title = "Access Control(dv raise event)";
            InitializeDataView();
        }
        void InitializeDataView()
        {
            From = UserGroups;
            Relations.Add(Users, 
            		Users.UserID.IsEqualTo(() => u.Upper(ENV.Security.UserManager.CurrentUser.Name)), 
            	Users.SortBySA_USER_X1);
            
            Relations.Add(Control, 
            		Control.RecordType.IsEqualTo("MAGIC").And(
            		Control.RecordSubType.IsEqualTo("VERSION")), 
            	Control.SortBySA_Control_X1);
            
            Relations.Add(Control1, 
            		Control1.RecordType.IsEqualTo("ALLOW").And(
            		Control1.RecordSubType.IsEqualTo("USERS")), 
            	Control1.SortBySA_Control_X1);
            
            Where.Add(UserGroups.UserID.IsEqualTo(() => u.Upper(ENV.Security.UserManager.CurrentUser.Name)));
            OrderBy = UserGroups.SortBySA_USERGROUP_X2;
            
            #region Columns
            
            Columns.Add(UserGroups.UserID);
            Columns.Add(UserGroups.GroupID);
            // Get User Name
            Columns.Add(Users.UserID);
            Columns.Add(Users.UserName);
            // Get Version & Service Pack info
            Columns.Add(Control.RecordType);
            Columns.Add(Control.RecordSubType);
            Columns.Add(Control.DelimitedDataString);
            
            Columns.Add(vVersion);
            Columns.Add(vServicePack);
            
            // Determine whether users are allowed
            Columns.Add(Control1.RecordType);
            Columns.Add(Control1.RecordSubType);
            Columns.Add(Control1.DelimitedDataString);
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
            vVersion.Value = u.StrToken(Control.DelimitedDataString, 1, ",");
            vServicePack.Value = u.StrToken(Control.DelimitedDataString, 2, ",");
            
            if(u.StrToken(Control1.DelimitedDataString, 1, ",") == "N")
            {
                if(u.Not(Roles.AccessControl3.Allowed) || Roles.ModifyInBrowse.Allowed)
                {
                    new UsersDisAllowed().Run();
                }
            }
            
            Cached<CreateAccessList>().Run();
        }
        protected override void OnEnd()
        {
            new AccessScreen(this).Run();
        }
        
        
        
        /// <summary>AccessScreen(P#50.1)</summary>
        // Last change before Migration: 16/07/2007 16:21:06
        internal class AccessScreen : FlowUIControllerBase 
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
            
            /// <summary>v:Chosen Application Number</summary>
            readonly NumberColumn vChosenApplicationNumber = new NumberColumn("v:Chosen Application Number", "N4");
            
            /// <summary>v:AllowUsers</summary>
            readonly TextColumn vAllowUsers = new TextColumn("v:AllowUsers", "1");
            
            /// <summary>v:AllowUserAccess</summary>
            internal readonly TextColumn vAllowUserAccess = new TextColumn("v:AllowUserAccess", "1");
            
            /// <summary>v:DisAllowUserAccess</summary>
            internal readonly TextColumn vDisAllowUserAccess = new TextColumn("v:DisAllowUserAccess", "1");
            
            /// <summary>v:UserAccessMessage</summary>
            internal readonly TextColumn vUserAccessMessage = new TextColumn("v:UserAccessMessage", "30");
            #endregion
            
            AccessControlDvRaiseEvent _parent;
            
            
            /// <summary>AccessScreen(P#50.1)</summary>
            public AccessScreen(AccessControlDvRaiseEvent parent)
            {
                _parent = parent;
                Title = "AccessScreen";
                InitializeDataViewAndUserFlow();
                #region Event Handlers
                
                Handlers.Add(Command.Select).Invokes += SelectHandler;
                
                Handlers.Add(Commands.CustomCommand_1).Invokes += CustomCommand_1Handler;
                
                #endregion
            }
            void InitializeDataViewAndUserFlow()
            {
                From = UserAccessList;
                Relations.Add(Applications, 
                		Applications.Application1.IsEqualTo(UserAccessList.Application1), 
                	Applications.SortBySA_APP_X1);
                
                OrderBy = UserAccessList.SortByUserAccess_X1;
                
                #region Columns and User Flow
                
                Columns.Add(vSelect);
                Columns.Add(vExit);
                Columns.Add(vChosenApplication);
                Columns.Add(vChosenApplicationNumber);
                
                Columns.Add(UserAccessList.Application1);
                
                Columns.Add(Applications.Application1);
                Columns.Add(Applications.ApplicationNumber);
                Columns.Add(Applications.ApplicationDescript);
                Columns.Add(vAllowUsers).BindValue(() => u.StrToken(_parent.Control1.DelimitedDataString, 1, ","));
                Columns.Add(vAllowUserAccess);
                Flow.StartBlock(FlowMode.ExpandAfter);
                #region Block
                {
                    Flow.Add(() => vAllowUsers.SilentSet("Y"));
                    Flow.Add<UsersAccessControl>(c => c.Run(), FlowMode.Tab);
                    Flow.Add(() => vUserAccessMessage.SilentSet("Users Allowed"));
                }
                Flow.EndBlock();
                #endregion
                Columns.Add(vDisAllowUserAccess);
                Flow.StartBlock(FlowMode.ExpandAfter);
                #region Block
                {
                    Flow.Add(() => vAllowUsers.SilentSet("N"));
                    Flow.Add<UsersAccessControl>(c => c.Run(), FlowMode.Tab);
                    Flow.Add(() => vUserAccessMessage.SilentSet("Users Dis-Allowed"));
                }
                Flow.EndBlock();
                #endregion
                
                Flow.Add(() => u.KBPut(Command.ReloadData), ()=> false);
                Columns.Add(vUserAccessMessage).BindValue(() => u.If(vAllowUsers == "Y", "Users Allowed", "Users Dis-Allowed"));
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
                AllowDelete = false;
                AllowInsert = false;
                AllowUpdate = false;
                AllowSelect = true;
                View = ()=> new Views.AccessControlDvRaiseEventSystemAccess(this);
            }
            protected override void OnEnd()
            {
                if(vChosenApplicationNumber != 0)
                {
                    u.WinMinimize();
                    Raise(Commands.RestartApplication, vChosenApplicationNumber);
                    u.WinMaximize();
                    
                }
                else 
                {
                    new EndProgram().Run();
                }
            }
            
            #region Handlers
            void SelectHandler(HandlerInvokeEventArgs e)
            {
                vChosenApplicationNumber.SilentSet(Applications.ApplicationNumber);
                e.Handled = true;
            }
            void CustomCommand_1Handler(HandlerInvokeEventArgs e)
            {
                vChosenApplicationNumber.SilentSet(Applications.ApplicationNumber);
                e.Handled = true;
            }
            #endregion
            
            #region Expressions
            internal Number Exp_4()
            {
                return u.If(vAllowUsers == "N", 104, 103);
            }
            internal Text Exp_9()
            {
                return u.DStr(Date.Now, "WWWWWWWWW  DD MMMMMMMMM YYYY");
            }
            internal Text Exp_10()
            {
                return "Good " + u.If(u.TStr(Time.Now, "HH:MM") > "17:00", "evening", u.If(u.TStr(Time.Now, "HH:MM") > "12:00", "afternoon", "morning")) + " " + u.Trim(_parent.Users.UserName) + ",";
            }
            internal Text Exp_13()
            {
                return "Magic for Windows 95/NT - Version " + u.Trim(_parent.vVersion) + "/SP" + u.Trim(_parent.vServicePack);
            }
            internal Bool Exp_14()
            {
                return Roles.AccessControl3.Allowed && u.Not(Roles.ModifyInBrowse.Allowed);
            }
            #endregion
            
            
            
            /// <summary>UsersAccessControl(P#50.1.1)</summary>
            // Last change before Migration: 31/05/2004 16:23:26
            internal class UsersAccessControl : BusinessProcessBase 
            {
                
                #region Models
                
                /// <summary>Control</summary>
                readonly Models.Control Control = new Models.Control { AllowRowLocking = true };
                #endregion
                
                AccessScreen _parent;
                
                
                /// <summary>UsersAccessControl(P#50.1.1)</summary>
                public UsersAccessControl(AccessScreen parent)
                {
                    _parent = parent;
                    Title = "UsersAccessControl";
                    InitializeDataView();
                }
                void InitializeDataView()
                {
                    Relations.Add(Control, RelationType.InsertIfNotFound, 
                    		Control.RecordType.IsEqualTo("ALLOW").And(
                    		Control.RecordSubType.IsEqualTo("USERS")), 
                    	Control.SortBySA_Control_X1);
                    
                    
                    #region Columns
                    
                    Columns.Add(Control.RecordType);
                    Columns.Add(Control.RecordSubType);
                    Columns.Add(Control.DelimitedDataString);
                    Columns.Add(Control.Comments);
                    #endregion
                }
                
                #region Run Overloads
                
                /// <summary>UsersAccessControl</summary>
                internal void Run()
                {
                    Execute();
                }
                #endregion
                
                protected override void OnLoad()
                {
                    Exit(ExitTiming.AfterRow);
                    AllowUserAbort = true;
                }
                protected override void OnLeaveRow()
                {
                    Control.DelimitedDataString.Value = u.Trim(_parent.vAllowUsers) + ",";
                    Control.Comments.Value = "Y=Yes N=No";
                }
                protected override void OnEnd()
                {
                    if(_parent.vAllowUsers == "N")
                    {
                        Windows.OSCommand("%saCTL%/scripts/killusers.scr");
                        Cached<KillActiveUsers>().Run();
                    }
                }
                
                
                
                /// <summary>KillActiveUsers(P#50.1.1.1)</summary>
                // Last change before Migration: 31/05/2004 16:23:26
                internal class KillActiveUsers : BusinessProcessBase 
                {
                    
                    #region Models
                    
                    /// <summary>Users</summary>
                    readonly Models.Users Users = new Models.Users { ReadOnly = true };
                    #endregion
                    
                    #region Columns
                    
                    /// <summary>v:ListRecord</summary>
                    readonly TextColumn vListRecord = new TextColumn("v:ListRecord", "50");
                    
                    /// <summary>v:UID</summary>
                    internal readonly TextColumn vUID = new TextColumn("v:UID", "10");
                    
                    /// <summary>v:PID</summary>
                    internal readonly TextColumn vPID = new TextColumn("v:PID", "10");
                    
                    /// <summary>v:ValidOnlineUser</summary>
                    readonly BoolColumn vValidOnlineUser = new BoolColumn("v:ValidOnlineUser");
                    #endregion
                    
                    #region Streams
                    
                    /// <summary>List of Users</summary>
                    ENV.IO.FileReader _ioListOfUsers;
                    
                    /// <summary>Current Users Report</summary>
                    ENV.Printing.PrinterWriter _ioCurrentUsersReport;
                    #endregion
                    
                    #region Layouts
                    
                    /// <summary>List of Users</summary>
                    MandCo.Theme.IO.TextSection _viewListOfUsers;
                    #endregion
                    
                    #region Printing Layouts
                    Printing.AccessControlDvRaiseEventKillActiveUsers _layout;
                    #endregion
                    
                    
                    /// <summary>KillActiveUsers(P#50.1.1.1)</summary>
                    public KillActiveUsers()
                    {
                        Title = "KillActiveUsers";
                        InitializeDataView();
                        #region form List of Users
                        
                        _viewListOfUsers = new MandCo.Theme.IO.TextSection(this)
                        			{
                        				Height = 1,
                        				Width = 50
                        			};
                        var txtVListRecord = new MandCo.Theme.IO.TextBox()
                        			{
                        				Width = 50,
                        				Data = vListRecord
                        			};
                        _viewListOfUsers.Controls.Add(txtVListRecord);
                        
                        #endregion
                        _layout = new Printing.AccessControlDvRaiseEventKillActiveUsers(this);
                    }
                    void InitializeDataView()
                    {
                        Relations.Add(Users, 
                        		Users.UserID.IsEqualTo(() => u.Trim(vUID)), 
                        	Users.SortBySA_USER_X1);
                        
                        
                        #region Columns
                        
                        Columns.Add(vListRecord);
                        
                        Columns.Add(vUID).BindValue(() => u.StrToken(vListRecord, 1, ","));
                        Columns.Add(vPID).BindValue(() => u.StrToken(vListRecord, 2, ","));
                        
                        Columns.Add(vValidOnlineUser);
                        Relations[Users].NotifyRowWasFoundTo(vValidOnlineUser);
                        Columns.Add(Users.UserID);
                        #endregion
                    }
                    
                    #region Run Overloads
                    
                    /// <summary>KillActiveUsers</summary>
                    internal void Run()
                    {
                        Execute();
                    }
                    #endregion
                    
                    protected override void OnLoad()
                    {
                        Exit(ExitTiming.BeforeRow, () => _ioListOfUsers.EndOfFile);
                        AllowUserAbort = true;
                        
                        _ioListOfUsers = new ENV.IO.FileReader("%AIXserver%/tmp/killusers.lst")
                        			{
                        				Name = "List of Users"
                        			};
                        Streams.Add(_ioListOfUsers);
                        
                        _ioCurrentUsersReport = new ENV.Printing.PrinterWriter()
                        			{
                        				Name = "Current Users Report",
                        				PrinterName = Printing.Printers.Printer1.PrinterName,
                        				PrintPreview = true
                        			};
                        Streams.Add(_ioCurrentUsersReport);
                        _layout.Reset();
                    }
                    protected override void OnStart()
                    {
                        _layout.UserListHeader.WriteTo(_ioCurrentUsersReport);
                    }
                    protected override void OnEnterRow()
                    {
                        _viewListOfUsers.ReadFrom(_ioListOfUsers);
                    }
                    protected override void OnLeaveRow()
                    {
                        if(vValidOnlineUser && u.Trim(vUID) != u.Trim(ENV.Security.UserManager.CurrentUser.Name))
                        {
                            _layout.UserListDetail.WriteTo(_ioCurrentUsersReport);
                        }
                    }
                    
                    #region Expressions
                    internal Text Exp_1()
                    {
                        return "Page: " + u.Str(u.Page(0, 1), "###");
                    }
                    internal Text Exp_2()
                    {
                        return u.DStr(Date.Now, "DD-MMM-YYYY") + " " + u.TStr(Time.Now, "HH:MM:SS");
                    }
                    #endregion
                    
                    
                }
            }
        }
        
        /// <summary>DeleteAccessList(P#50.2)</summary>
        // Last change before Migration: 06/08/2001 12:42:54
        class DeleteAccessList : BusinessProcessBase 
        {
            
            
            /// <summary>DeleteAccessList(P#50.2)</summary>
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
        
        /// <summary>CreateAccessList(P#50.3)</summary>
        // Last change before Migration: 06/08/2001 12:52:58
        class CreateAccessList : BusinessProcessBase 
        {
            
            #region Models
            
            /// <summary>GroupApplications</summary>
            readonly Models.GroupApplications GroupApplications = new Models.GroupApplications { Cached = false, ReadOnly = true };
            
            /// <summary>UserAccessList</summary>
            readonly Models.UserAccessList UserAccessList = new Models.UserAccessList { KeepCacheAliveAfterExit = true, AllowRowLocking = true };
            #endregion
            
            AccessControlDvRaiseEvent _parent;
            
            
            /// <summary>CreateAccessList(P#50.3)</summary>
            public CreateAccessList(AccessControlDvRaiseEvent parent)
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
        
        /// <summary>Users DisAllowed(P#50.4)</summary>
        // Last change before Migration: 14/01/2004 12:46:35
        internal class UsersDisAllowed : BusinessProcessBase 
        {
            
            #region Columns
            
            /// <summary>v:Count</summary>
            readonly NumberColumn vCount = new NumberColumn("v:Count", "2");
            
            /// <summary>v:OK</summary>
            internal readonly TextColumn vOK = new TextColumn("v:OK", "1");
            #endregion
            
            
            /// <summary>Users DisAllowed(P#50.4)</summary>
            public UsersDisAllowed()
            {
                Title = "Users DisAllowed";
                InitializeDataView();
            }
            void InitializeDataView()
            {
                #region Columns
                
                Columns.Add(vCount);
                Columns.Add(vOK);
                #endregion
            }
            
            #region Run Overloads
            
            /// <summary>Users DisAllowed</summary>
            internal void Run()
            {
                Execute();
            }
            #endregion
            
            protected override void OnLoad()
            {
                Exit(ExitTiming.AfterRow, () => vCount < 1);
                AllowUserAbort = true;
                if(NewViewRequired)
                {
                    View = ()=> new Views.AccessControlDvRaiseEventUsersDisAllowed(this);
                }
            }
            protected override void OnStart()
            {
                vCount.Value = 9;
                u.SetCrsr(4);
            }
            protected override void OnLeaveRow()
            {
                u.Delay(10);
                vCount.Value--;
            }
            protected override void OnEnd()
            {
                u.SetCrsr(1);
                u.KBPut(Command.ExitApplication);
            }
            
            #region Expressions
            internal Text Exp_1()
            {
                return "You will be automatically logged out in approximately " + u.Str(vCount, "#") + " seconds";
            }
            #endregion
            
            
        }
    }
}