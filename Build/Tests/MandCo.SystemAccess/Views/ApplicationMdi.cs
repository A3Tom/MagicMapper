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
using ENV;
namespace MandCo.SystemAccess.Views
{
    partial class ApplicationMdi : System.Windows.Forms.Form 
    {
        public override System.Drawing.Size MinimumSize { get { return Common.GetMDIMinimumSize(this, base.MinimumSize); } set { base.MinimumSize = value; } }
        internal System.Windows.Forms.ContextMenuStrip _optionsContextMenuStrip;
        
        public ApplicationMdi()
        {
            try
            {
                Common.DefaultIcon = new System.Drawing.Icon(PathDecoder.DecodePath(@"S:\UniPaasDev019\icon\mandco.ico"));
            }
            catch
            {
            }
            Icon = ENV.Common.DefaultIcon;
            InitializeComponent();
            InitUserBasedMenus();
            Common.MDILoad(this);
            MenuManager.Instance.MapMainMenu(2, DefaultContextMenu);
            MenuManager.Instance.MapMainMenu(1, DefaultPulldownMenu, DefaultPulldownMenuToolStrip);
            MenuManager.Instance.ActivateMenu(1);
            Firefly.Box.Context.Current.BusyChanged += () => DefaultContextMenu.Enabled = DefaultContextMenu.Visible && !Firefly.Box.Context.Current.Busy;
            Firefly.Box.Context.Current.BusyChanged += () => DefaultPulldownMenu.Enabled = DefaultPulldownMenu.Visible && !Firefly.Box.Context.Current.Busy;
            MenuManager.Instance.MapMenu("", mnu1OffPopUserEmailTable, ()=>SystemAccess.Roles.ModifyInBrowse.Allowed);
            MenuManager.Instance.MapMenu("", mnuAccessControlDV2);
            Languages.TranslateMenu(DefaultContextMenu);
            MenuManager.Instance.MapMenu("", mnu1OffPopUserEmailTable1, ()=>SystemAccess.Roles.ModifyInBrowse.Allowed);
            MenuManager.Instance.MapMenu("", mnuAccessControlDV21);
            Languages.TranslateMenu(DefaultContextMenu1);
            MenuManager.Instance.MapMenu("", mnuFile);
            MenuManager.Instance.MapMenu("", mnuShellToOS, false);
            Commands.ShellToOS.BindMenuItem(mnuShellToOS);
            MenuManager.Instance.MapMenu("", mnuPrinterSetup, false);
            Commands.PrinterSettingsDialog.BindMenuItem(mnuPrinterSetup);
            MenuManager.Instance.MapMenu("", mnuExitSystem, false);
            Firefly.Box.Command.ExitApplication.BindMenuItem(mnuExitSystem);
            MenuManager.Instance.MapMenu("", mnuEdit, ()=>SystemAccess.Roles.AccessControl3.Allowed);
            MenuManager.Instance.MapMenu("", mnuCancel, false);
            Firefly.Box.Command.UndoChangesInRow.BindMenuItem(mnuCancel);
            MenuManager.Instance.MapMenu("", mnuUndoEditing, false);
            Firefly.Box.Command.UndoEditing.BindMenuItem(mnuUndoEditing);
            MenuManager.Instance.MapMenu("", mnuZoom, false);
            Firefly.Box.Command.Expand.BindMenuItem(mnuZoom);
            MenuManager.Instance.MapMenu("", mnuWide, false);
            Firefly.Box.Command.ExpandTextBox.BindMenuItem(mnuWide);
            MenuManager.Instance.MapMenu("", mnuDeleteLine, false);
            Firefly.Box.Command.DeleteRow.BindMenuItem(mnuDeleteLine);
            MenuManager.Instance.MapMenu("", mnuCreateLine, false);
            Firefly.Box.Command.InsertRow.BindMenuItem(mnuCreateLine);
            MenuManager.Instance.MapMenu("", mnuCopy, false);
            Firefly.Box.Command.Copy.BindMenuItem(mnuCopy);
            MenuManager.Instance.MapMenu("", mnuPaste, false);
            Firefly.Box.Command.Paste.BindMenuItem(mnuPaste);
            MenuManager.Instance.MapMenu("", mnuDitto, false);
            Firefly.Box.Command.SetFocusedControlValueSameAsInPreviousRow.BindMenuItem(mnuDitto);
            MenuManager.Instance.MapMenu("", mnuSetToNULL, false);
            Firefly.Box.Command.SetFocusedControlValueToNull.BindMenuItem(mnuSetToNULL);
            MenuManager.Instance.MapMenu("", mnuOptions, ()=>SystemAccess.Roles.AccessControl3.Allowed);
            MenuManager.Instance.MapMenu("", mnuModifyRecords, false);
            Firefly.Box.Command.SwitchToUpdateActivity.BindMenuItem(mnuModifyRecords);
            MenuManager.Instance.MapMenu("", tsbModifyRecords, false);
            MenuManager.Instance.MapAsChild(mnuOptions, tsbModifyRecords);
            Firefly.Box.Command.SwitchToUpdateActivity.BindMenuItem(tsbModifyRecords);
            MenuManager.Instance.MapMenu("", mnuCreateRecords, false);
            Firefly.Box.Command.SwitchToInsertActivity.BindMenuItem(mnuCreateRecords);
            MenuManager.Instance.MapMenu("", tsbCreateRecords, false);
            MenuManager.Instance.MapAsChild(mnuOptions, tsbCreateRecords);
            Firefly.Box.Command.SwitchToInsertActivity.BindMenuItem(tsbCreateRecords);
            MenuManager.Instance.MapMenu("", mnuQueryRecords, false);
            Firefly.Box.Command.SwitchToBrowseActivity.BindMenuItem(mnuQueryRecords);
            MenuManager.Instance.MapMenu("", tsbQueryRecords, false);
            MenuManager.Instance.MapAsChild(mnuOptions, tsbQueryRecords);
            Firefly.Box.Command.SwitchToBrowseActivity.BindMenuItem(tsbQueryRecords);
            MenuManager.Instance.MapMenu("", mnuLocateARecord, false);
            Commands.FindRows.BindMenuItem(mnuLocateARecord);
            MenuManager.Instance.MapMenu("", tsbLocateARecord, false);
            MenuManager.Instance.MapAsChild(mnuOptions, tsbLocateARecord);
            Commands.FindRows.BindMenuItem(tsbLocateARecord);
            MenuManager.Instance.MapMenu("", mnuLocateNext, false);
            Commands.FindNextRow.BindMenuItem(mnuLocateNext);
            MenuManager.Instance.MapMenu("", tsbLocateNext, false);
            MenuManager.Instance.MapAsChild(mnuOptions, tsbLocateNext);
            Commands.FindNextRow.BindMenuItem(tsbLocateNext);
            MenuManager.Instance.MapMenu("", mnuRangeOfRecords, false);
            Commands.FilterRows.BindMenuItem(mnuRangeOfRecords);
            MenuManager.Instance.MapMenu("", tsbRangeOfRecords, false);
            MenuManager.Instance.MapAsChild(mnuOptions, tsbRangeOfRecords);
            Commands.FilterRows.BindMenuItem(tsbRangeOfRecords);
            MenuManager.Instance.MapMenu("", mnuViewByKey, false);
            Commands.SelectOrderBy.BindMenuItem(mnuViewByKey);
            MenuManager.Instance.MapMenu("", tsbViewByKey, false);
            MenuManager.Instance.MapAsChild(mnuOptions, tsbViewByKey);
            Commands.SelectOrderBy.BindMenuItem(tsbViewByKey);
            MenuManager.Instance.MapMenu("", mnuSortRecords, false);
            Commands.CustomOrderBy.BindMenuItem(mnuSortRecords);
            MenuManager.Instance.MapMenu("", tsbSortRecords, false);
            MenuManager.Instance.MapAsChild(mnuOptions, tsbSortRecords);
            Commands.CustomOrderBy.BindMenuItem(tsbSortRecords);
            ENV.Commands.ClearCurrentValueInTemplate.BindMenuItem(mnuClearValue);
            ENV.Commands.ClearTemplate.BindMenuItem(mnuClearTemplate);
            ENV.Commands.TemplateFromValues.BindMenuItem(mnuFromValues);
            ENV.Commands.TemplateToValues.BindMenuItem(mnuToValue);
            ENV.Commands.TemplateExpression.BindMenuItem(mnuExpression);
            MenuManager.Instance.MapMenu("", mnuMaintenance, ()=>SystemAccess.Roles.AccessControl3.Allowed);
            MenuManager.Instance.MapMenu("", mnuUsers2);
            MenuManager.Instance.MapMenu("", mnuGroups2);
            MenuManager.Instance.MapMenu("", mnuApplications);
            MenuManager.Instance.MapMenu("", mnuAttachUserToGroups);
            MenuManager.Instance.MapMenu("", mnuAttachGroupToApplications);
            MenuManager.Instance.MapMenu("", mnuAccessControl);
            MenuManager.Instance.MapMenu("", mnuUtilities);
            MenuManager.Instance.MapMenu("", mnuBrowses);
            MenuManager.Instance.MapMenu("", mnuUsers3);
            MenuManager.Instance.MapMenu("", mnuGroups3);
            MenuManager.Instance.MapMenu("", mnuApplications1);
            MenuManager.Instance.MapMenu("", mnuUserGroups);
            MenuManager.Instance.MapMenu("", mnuGroupApplications);
            MenuManager.Instance.MapMenu("", mnuUserAccessList);
            MenuManager.Instance.MapMenu("", mnuUserEmailAddresses);
            MenuManager.Instance.MapMenu("", mnuControl);
            MenuManager.Instance.MapMenu("", mnuAccessControl1);
            MenuManager.Instance.MapMenu("", mnuExports, ()=>SystemAccess.Roles.ModifyInBrowse.Allowed);
            MenuManager.Instance.MapMenu("", mnuUsers4);
            MenuManager.Instance.MapMenu("", mnuGroups4);
            MenuManager.Instance.MapMenu("", mnuApplications2);
            MenuManager.Instance.MapMenu("", mnuUserGroups1);
            MenuManager.Instance.MapMenu("", mnuGroupApplications1);
            MenuManager.Instance.MapMenu("", mnuUserEmailAddresses1);
            MenuManager.Instance.MapMenu("", mnuControl1);
            MenuManager.Instance.MapMenu("", mnuImports, ()=>SystemAccess.Roles.ModifyInBrowse.Allowed);
            MenuManager.Instance.MapMenu("", mnuUsers5);
            MenuManager.Instance.MapMenu("", mnuGroups5);
            MenuManager.Instance.MapMenu("", mnuApplications3);
            MenuManager.Instance.MapMenu("", mnuUserGroups2);
            MenuManager.Instance.MapMenu("", mnuGroupApplications2);
            MenuManager.Instance.MapMenu("", mnuUserEmailAddresses2);
            MenuManager.Instance.MapMenu("", mnuControl2);
            MenuManager.Instance.MapMenu("", mnuDocumentation);
            MenuManager.Instance.MapMenu("", tsbDocumentation);
            MenuManager.Instance.MapAsChild(mnuUtilities, tsbDocumentation);
            MenuManager.Instance.MapMenu("", mnuMackaysIntranet);
            MenuManager.Instance.MapMenu("", tsbMackaysIntranet);
            MenuManager.Instance.MapAsChild(mnuUtilities, tsbMackaysIntranet);
            MenuManager.Instance.MapMenu("", mnuWebGo);
            MenuManager.Instance.MapMenu("", tsbWebGo);
            MenuManager.Instance.MapAsChild(mnuUtilities, tsbWebGo);
            MenuManager.Instance.MapMenu("", mnuHelp);
            MenuManager.Instance.MapMenu("", mnuHelp1, false);
            Firefly.Box.Command.Help.BindMenuItem(mnuHelp1);
            MenuManager.Instance.MapMenu("", tsbHelp, false);
            MenuManager.Instance.MapAsChild(mnuHelp, tsbHelp);
            Firefly.Box.Command.Help.BindMenuItem(tsbHelp);
            MenuManager.Instance.MapMenu("", mnuAbout, false);
            Commands.About.BindMenuItem(mnuAbout);
            MenuManager.Instance.MapMenu("", mnuVCR);
            MenuManager.Instance.MapMenu("", mnuBeginTable, false);
            Firefly.Box.Command.GoToFirstRow.BindMenuItem(mnuBeginTable);
            MenuManager.Instance.MapMenu("", tsbBeginTable, false);
            MenuManager.Instance.MapAsChild(mnuVCR, tsbBeginTable);
            Firefly.Box.Command.GoToFirstRow.BindMenuItem(tsbBeginTable);
            MenuManager.Instance.MapMenu("", mnuPreviousScreen, false);
            Firefly.Box.Command.GoToPreviousPage.BindMenuItem(mnuPreviousScreen);
            MenuManager.Instance.MapMenu("", tsbPreviousScreen, false);
            MenuManager.Instance.MapAsChild(mnuVCR, tsbPreviousScreen);
            Firefly.Box.Command.GoToPreviousPage.BindMenuItem(tsbPreviousScreen);
            MenuManager.Instance.MapMenu("", mnuPreviousRow, false);
            Firefly.Box.Command.GoToPreviousRow.BindMenuItem(mnuPreviousRow);
            MenuManager.Instance.MapMenu("", tsbPreviousRow, false);
            MenuManager.Instance.MapAsChild(mnuVCR, tsbPreviousRow);
            Firefly.Box.Command.GoToPreviousRow.BindMenuItem(tsbPreviousRow);
            MenuManager.Instance.MapMenu("", mnuNextRow, false);
            Firefly.Box.Command.GoToNextRow.BindMenuItem(mnuNextRow);
            MenuManager.Instance.MapMenu("", tsbNextRow, false);
            MenuManager.Instance.MapAsChild(mnuVCR, tsbNextRow);
            Firefly.Box.Command.GoToNextRow.BindMenuItem(tsbNextRow);
            MenuManager.Instance.MapMenu("", mnuNextScreen, false);
            Firefly.Box.Command.GoToNextPage.BindMenuItem(mnuNextScreen);
            MenuManager.Instance.MapMenu("", tsbNextScreen, false);
            MenuManager.Instance.MapAsChild(mnuVCR, tsbNextScreen);
            Firefly.Box.Command.GoToNextPage.BindMenuItem(tsbNextScreen);
            MenuManager.Instance.MapMenu("", mnuEndTable, false);
            Firefly.Box.Command.GoToLastRow.BindMenuItem(mnuEndTable);
            MenuManager.Instance.MapMenu("", tsbEndTable, false);
            MenuManager.Instance.MapAsChild(mnuVCR, tsbEndTable);
            Firefly.Box.Command.GoToLastRow.BindMenuItem(tsbEndTable);
            MenuManager.Instance.MapMenu("", mnuOLE2);
            Languages.TranslateMenu(DefaultPulldownMenu);
            Firefly.Box.Context.Current.BusyChanged += () => DefaultPulldownMenuToolStrip.Enabled = DefaultPulldownMenuToolStrip.Visible && !Firefly.Box.Context.Current.Busy;
            TemplateModeFilter.SetTemplateModeMenues(mnuUndoEditing, mnuEdit, mnuZoom, mnuWide, mnuCopy, mnuPaste, mnuSetToNULL, mnuClearValue, mnuOptions, mnuClearTemplate, mnuFromValues, mnuToValue, mnuExpression, mnuHelp1, mnuHelp, tsbHelp);
        }
        public void InitUserBasedMenus()
        {
            mnuUsers.Visible = SystemAccess.Roles.UserManager.Allowed;
            mnuGroups.Visible = SystemAccess.Roles.UserManager.Allowed;
            mnuSecuredValues.Visible = SystemAccess.Roles.UserManager.Allowed;
            mnuDeveloperTools.Visible = Common.EnableDeveloperTools;
            mnuTestErrorLog.Visible = Common.EnableDeveloperTools;
            mnuFireflyAbout.Visible = Common.EnableDeveloperTools;
            mnuCallStack.Visible = Common.EnableDeveloperTools;
            mnuCallStackBrowser.Visible = Common.EnableDeveloperTools;
            mnuEntityBrowser.Visible = Common.EnableDeveloperTools;
            mnuProgramsProwser.Visible = Common.EnableDeveloperTools;
            mnuGetDefiniton.Visible = Common.EnableDeveloperTools;
            mnuSQLQuery.Visible = Common.EnableDeveloperTools;
            mnuPathDecoderValues.Visible = Common.EnableDeveloperTools;
            mnuTestPathDecode.Visible = Common.EnableDeveloperTools;
            mnuMemoryMonitor.Visible = Common.EnableDeveloperTools;
            mnuEnableAdvancedFeatures.Visible = Common.EnableDeveloperTools;
            mnuEnableAdvancedFeatures1.Visible = Common.EnableDeveloperTools;
            mnuFaceLift.Visible = Common.EnableDeveloperTools;
            mnu1OffPopUserEmailTable.Visible = SystemAccess.Roles.ModifyInBrowse.Allowed;
            mnu1OffPopUserEmailTable1.Visible = SystemAccess.Roles.ModifyInBrowse.Allowed;
            mnuEdit.Visible = SystemAccess.Roles.AccessControl3.Allowed;
            mnuOptions.Visible = SystemAccess.Roles.AccessControl3.Allowed;
            tsbModifyRecords.Visible = SystemAccess.Roles.AccessControl3.Allowed;
            tsbCreateRecords.Visible = SystemAccess.Roles.AccessControl3.Allowed;
            tsbQueryRecords.Visible = SystemAccess.Roles.AccessControl3.Allowed;
            tsbLocateARecord.Visible = SystemAccess.Roles.AccessControl3.Allowed;
            tsbLocateNext.Visible = SystemAccess.Roles.AccessControl3.Allowed;
            tsbRangeOfRecords.Visible = SystemAccess.Roles.AccessControl3.Allowed;
            tsbViewByKey.Visible = SystemAccess.Roles.AccessControl3.Allowed;
            tsbSortRecords.Visible = SystemAccess.Roles.AccessControl3.Allowed;
            mnuUsers1.Visible = SystemAccess.Roles.UserManager.Allowed;
            mnuGroups1.Visible = SystemAccess.Roles.UserManager.Allowed;
            mnuSecuredValues1.Visible = SystemAccess.Roles.UserManager.Allowed;
            mnuDeveloperTools1.Visible = Common.EnableDeveloperTools;
            mnuTestErrorLog1.Visible = Common.EnableDeveloperTools;
            mnuFireflyAbout1.Visible = Common.EnableDeveloperTools;
            mnuCallStack1.Visible = Common.EnableDeveloperTools;
            mnuCallStackBrowser1.Visible = Common.EnableDeveloperTools;
            mnuEntityBrowser1.Visible = Common.EnableDeveloperTools;
            mnuProgramsProwser1.Visible = Common.EnableDeveloperTools;
            mnuGetDefiniton1.Visible = Common.EnableDeveloperTools;
            mnuSQLQuery1.Visible = Common.EnableDeveloperTools;
            mnuPathDecoderValues1.Visible = Common.EnableDeveloperTools;
            mnuTestPathDecode1.Visible = Common.EnableDeveloperTools;
            mnuMemoryMonitor1.Visible = Common.EnableDeveloperTools;
            mnuEnableAdvancedFeatures2.Visible = Common.EnableDeveloperTools;
            mnuEnableAdvancedFeatures3.Visible = Common.EnableDeveloperTools;
            mnuFaceLift1.Visible = Common.EnableDeveloperTools;
            mnuMaintenance.Visible = SystemAccess.Roles.AccessControl3.Allowed;
            mnuExports.Visible = SystemAccess.Roles.ModifyInBrowse.Allowed;
            mnuImports.Visible = SystemAccess.Roles.ModifyInBrowse.Allowed;
        }
        protected override void OnClosed(System.EventArgs e)
        {
            Common.MDIClose(this);
            base.OnClosed(e);
        }
        protected override void ScaleControl(System.Drawing.SizeF factor, System.Windows.Forms.BoundsSpecified specified)
        {
            Common.MDIScale(this, factor);
            base.ScaleControl(factor, specified);
        }
        void expandStatusLabel_Click(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(()=>UserMethods.Instance.KBPut(Firefly.Box.Command.Expand));
        }
        void expandTextBoxStatusLabel_Click(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(()=>UserMethods.Instance.KBPut(Firefly.Box.Command.ExpandTextBox));
        }
        void Users_Click(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Security.UserManager.ManageUsers());
        }
        void Groups_Click(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Security.UserManager.ManageGroups());
        }
        void SecuredValues_Click(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Security.UserManager.ManageSecuredValues());
        }
        void TestErrorLog_Click(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ErrorLog.Test());
        }
        void FireflyAbout_Click(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => new ENV.UI.AboutFirefly().ShowDialog());
        }
        void CallStack_Click(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ErrorLog.ShowCurrentLocation());
        }
        void CallStackBrowser_Click(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Utilities.CallStackBrowser.Run());
        }
        void EntityBrowser_Click(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Utilities.EntityBrowser.ShowEntityBrowser(Application.Instance));
        }
        void ProgramsProwser_Click(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Utilities.ProgramRunner.ShowAllPrograms(Application.Instance));
        }
        void GetDefiniton_Click(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Utilities.GetDefinition.Run(typeof (Models.DataSources)));
        }
        void SQLQuery_Click(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Utilities.SQLQuery.Run(typeof (Models.DataSources)));
        }
        void PathDecoderValues_Click(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => PathDecoder.ContextPathDecoder.Display());
        }
        void TestPathDecode_Click(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => PathDecoder.ContextPathDecoder.PathDecoderTester());
        }
        void MemoryMonitor_Click(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Utilities.MemoryMonitor.Run());
        }
        void EnableAdvancedFeatures_Click(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.UI.Grid.AlwaysEnableGridEnhancements = !ENV.UI.Grid.AlwaysEnableGridEnhancements);
        }
        void EnableAdvancedFeatures_Click1(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.UI.Grid.AlwaysUseUnderConstructionNewGridLook = !ENV.UI.Grid.AlwaysUseUnderConstructionNewGridLook);
        }
        void FaceLift_Click(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Labs.FaceLiftDemo.Enabled = !ENV.Labs.FaceLiftDemo.Enabled);
        }
        void No1OffPopUserEmailTable_Click(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnu1OffPopUserEmailTable, () => new SystemAccess.No1OffPopUserEmailTable().Run());
        }
        void AccessControlDV2_Click(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuAccessControlDV2, () => new SystemAccess.AccessControlDV().Run());
        }
        void No1OffPopUserEmailTable_Click1(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnu1OffPopUserEmailTable1, () => new SystemAccess.No1OffPopUserEmailTable().Run());
        }
        void AccessControlDV2_Click1(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuAccessControlDV21, () => new SystemAccess.AccessControlDV().Run());
        }
        void Users_Click1(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Security.UserManager.ManageUsers());
        }
        void Groups_Click1(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Security.UserManager.ManageGroups());
        }
        void SecuredValues_Click1(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Security.UserManager.ManageSecuredValues());
        }
        void TestErrorLog_Click1(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ErrorLog.Test());
        }
        void FireflyAbout_Click1(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => new ENV.UI.AboutFirefly().ShowDialog());
        }
        void CallStack_Click1(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ErrorLog.ShowCurrentLocation());
        }
        void CallStackBrowser_Click1(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Utilities.CallStackBrowser.Run());
        }
        void EntityBrowser_Click1(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Utilities.EntityBrowser.ShowEntityBrowser(Application.Instance));
        }
        void ProgramsProwser_Click1(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Utilities.ProgramRunner.ShowAllPrograms(Application.Instance));
        }
        void GetDefiniton_Click1(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Utilities.GetDefinition.Run(typeof (Models.DataSources)));
        }
        void SQLQuery_Click1(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Utilities.SQLQuery.Run(typeof (Models.DataSources)));
        }
        void PathDecoderValues_Click1(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => PathDecoder.ContextPathDecoder.Display());
        }
        void TestPathDecode_Click1(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => PathDecoder.ContextPathDecoder.PathDecoderTester());
        }
        void MemoryMonitor_Click1(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Utilities.MemoryMonitor.Run());
        }
        void EnableAdvancedFeatures_Click2(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.UI.Grid.AlwaysEnableGridEnhancements = !ENV.UI.Grid.AlwaysEnableGridEnhancements);
        }
        void EnableAdvancedFeatures_Click3(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.UI.Grid.AlwaysUseUnderConstructionNewGridLook = !ENV.UI.Grid.AlwaysUseUnderConstructionNewGridLook);
        }
        void FaceLift_Click1(object sender, System.EventArgs e)
        {
            Common.RunMenuItem(() => ENV.Labs.FaceLiftDemo.Enabled = !ENV.Labs.FaceLiftDemo.Enabled);
        }
        void Users_Click2(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuUsers2, () => new SystemAccess.MaintUsers().Run());
        }
        void Groups_Click2(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuGroups2, () => new SystemAccess.MaintGroups().Run());
        }
        void Applications_Click(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuApplications, () => new SystemAccess.MaintApplications().Run());
        }
        void AttachUserToGroups_Click(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuAttachUserToGroups, () => new SystemAccess.AttachUserToGroups().Run());
        }
        void AttachGroupToApplications_Click(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuAttachGroupToApplications, () => new SystemAccess.AttachGroupToApplications().Run());
        }
        void AccessControl_Click(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuAccessControl, () => new SystemAccess.AccessControl().Run());
        }
        void Users_Click3(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuUsers3, () => new SystemAccess.BrowseUsers().Run());
        }
        void Groups_Click3(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuGroups3, () => new SystemAccess.BrowseGroups().Run());
        }
        void Applications_Click1(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuApplications1, () => new SystemAccess.BrowseApplications().Run());
        }
        void UserGroups_Click(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuUserGroups, () => new SystemAccess.BrowseUserGroups().Run());
        }
        void GroupApplications_Click(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuGroupApplications, () => new SystemAccess.BrowseGroupApplications().Run());
        }
        void UserAccessList_Click(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuUserAccessList, () => new SystemAccess.BrowseUserAccessList().Run());
        }
        void UserEmailAddresses_Click(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuUserEmailAddresses, () => new SystemAccess.BrowseUserEmailAddresses().Run());
        }
        void Control_Click(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuControl, () => new SystemAccess.BrowseControl().Run());
        }
        void AccessControl_Click1(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuAccessControl1, () => new SystemAccess.AccessControl().Run());
        }
        void Users_Click4(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuUsers4, () => new SystemAccess.ExportUsers().Run());
        }
        void Groups_Click4(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuGroups4, () => new SystemAccess.ExportGroups().Run());
        }
        void Applications_Click2(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuApplications2, () => new SystemAccess.ExportApplications().Run());
        }
        void UserGroups_Click1(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuUserGroups1, () => new SystemAccess.ExportUserGroups().Run());
        }
        void GroupApplications_Click1(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuGroupApplications1, () => new SystemAccess.ExportGroupApplications().Run());
        }
        void UserEmailAddresses_Click1(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuUserEmailAddresses1, () => new SystemAccess.ExportUserEmailAddresses().Run());
        }
        void Control_Click1(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuControl1, () => new SystemAccess.ExportControl().Run());
        }
        void Users_Click5(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuUsers5, () => new SystemAccess.ImportUsers().Run());
        }
        void Groups_Click5(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuGroups5, () => new SystemAccess.ImportGroups().Run());
        }
        void Applications_Click3(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuApplications3, () => new SystemAccess.ImportApplications().Run());
        }
        void UserGroups_Click2(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuUserGroups2, () => new SystemAccess.ImportUserGroups().Run());
        }
        void GroupApplications_Click2(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuGroupApplications2, () => new SystemAccess.ImportGroupApplications().Run());
        }
        void UserEmailAddresses_Click2(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuUserEmailAddresses2, () => new SystemAccess.ImportUserEmailAddresses().Run());
        }
        void Control_Click2(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuControl2, () => new SystemAccess.ImportControl().Run());
        }
        void Documentation_Click(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuDocumentation, () => new SystemAccess.DocsList().Run());
        }
        void MackaysIntranet_Click(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuMackaysIntranet, () => new SystemAccess.IntranetGo().Run());
        }
        void WebGo_Click(object sender, System.EventArgs e)
        {
            Common.CloseActiveTasksAndRunMenuItem(mnuWebGo, () => new SystemAccess.WebGo().Run());
        }
        
        
    }
}
