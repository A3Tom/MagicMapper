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
    partial class ApplicationMdi
    {
        System.ComponentModel.IContainer components;
        System.Windows.Forms.StatusStrip StatusStrip;
        internal System.Windows.Forms.ToolStripStatusLabel mainStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel userStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel versionStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel activityStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel expandStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel expandTextBoxStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel insertOverrideStatusLabel;
        System.Windows.Forms.ToolStripMenuItem mnuUsers;
        System.Windows.Forms.ToolStripMenuItem mnuGroups;
        System.Windows.Forms.ToolStripMenuItem mnuSecuredValues;
        System.Windows.Forms.ToolStripMenuItem mnuDeveloperTools;
        System.Windows.Forms.ToolStripMenuItem mnuTestErrorLog;
        System.Windows.Forms.ToolStripMenuItem mnuFireflyAbout;
        System.Windows.Forms.ToolStripMenuItem mnuCallStack;
        System.Windows.Forms.ToolStripMenuItem mnuCallStackBrowser;
        System.Windows.Forms.ToolStripMenuItem mnuEntityBrowser;
        System.Windows.Forms.ToolStripMenuItem mnuProgramsProwser;
        System.Windows.Forms.ToolStripMenuItem mnuGetDefiniton;
        System.Windows.Forms.ToolStripMenuItem mnuSQLQuery;
        System.Windows.Forms.ToolStripMenuItem mnuPathDecoderValues;
        System.Windows.Forms.ToolStripMenuItem mnuTestPathDecode;
        System.Windows.Forms.ToolStripMenuItem mnuMemoryMonitor;
        System.Windows.Forms.ToolStripMenuItem mnuEnableAdvancedFeatures;
        System.Windows.Forms.ToolStripMenuItem mnuEnableAdvancedFeatures1;
        System.Windows.Forms.ToolStripMenuItem mnuFaceLift;
        System.Windows.Forms.MenuStrip DefaultContextMenu;
        internal System.Windows.Forms.ContextMenuStrip DefaultContextMenu1;
        System.Windows.Forms.MenuStrip DefaultPulldownMenu;
        System.Windows.Forms.ToolStripMenuItem mnu1OffPopUserEmailTable;
        System.Windows.Forms.ToolStripMenuItem mnuAccessControlDV2;
        System.Windows.Forms.ToolStripMenuItem mnu1OffPopUserEmailTable1;
        System.Windows.Forms.ToolStripMenuItem mnuAccessControlDV21;
        System.Windows.Forms.ToolStripMenuItem mnuFile;
        System.Windows.Forms.ToolStripMenuItem mnuShellToOS;
        System.Windows.Forms.ToolStripSeparator seperator;
        System.Windows.Forms.ToolStripMenuItem mnuPrinterSetup;
        System.Windows.Forms.ToolStripSeparator seperator1;
        System.Windows.Forms.ToolStripMenuItem mnuExitSystem;
        System.Windows.Forms.ToolStripMenuItem mnuEdit;
        System.Windows.Forms.ToolStripMenuItem mnuCancel;
        System.Windows.Forms.ToolStripMenuItem mnuUndoEditing;
        System.Windows.Forms.ToolStripSeparator seperator2;
        System.Windows.Forms.ToolStripMenuItem mnuZoom;
        System.Windows.Forms.ToolStripMenuItem mnuWide;
        System.Windows.Forms.ToolStripSeparator seperator3;
        System.Windows.Forms.ToolStripMenuItem mnuDeleteLine;
        System.Windows.Forms.ToolStripMenuItem mnuCreateLine;
        System.Windows.Forms.ToolStripMenuItem mnuCopy;
        System.Windows.Forms.ToolStripMenuItem mnuPaste;
        System.Windows.Forms.ToolStripMenuItem mnuDitto;
        System.Windows.Forms.ToolStripMenuItem mnuSetToNULL;
        System.Windows.Forms.ToolStripMenuItem mnuOptions;
        System.Windows.Forms.ToolStripMenuItem mnuModifyRecords;
        System.Windows.Forms.ToolStripButton tsbModifyRecords;
        System.Windows.Forms.ToolStripMenuItem mnuCreateRecords;
        System.Windows.Forms.ToolStripButton tsbCreateRecords;
        System.Windows.Forms.ToolStripMenuItem mnuQueryRecords;
        System.Windows.Forms.ToolStripButton tsbQueryRecords;
        System.Windows.Forms.ToolStripSeparator seperator4;
        System.Windows.Forms.ToolStripMenuItem mnuLocateARecord;
        System.Windows.Forms.ToolStripButton tsbLocateARecord;
        System.Windows.Forms.ToolStripMenuItem mnuLocateNext;
        System.Windows.Forms.ToolStripButton tsbLocateNext;
        System.Windows.Forms.ToolStripMenuItem mnuRangeOfRecords;
        System.Windows.Forms.ToolStripButton tsbRangeOfRecords;
        System.Windows.Forms.ToolStripMenuItem mnuViewByKey;
        System.Windows.Forms.ToolStripButton tsbViewByKey;
        System.Windows.Forms.ToolStripMenuItem mnuSortRecords;
        System.Windows.Forms.ToolStripButton tsbSortRecords;
        System.Windows.Forms.ToolStripSeparator seperator5;
        System.Windows.Forms.ToolStripMenuItem mnuUsers1;
        System.Windows.Forms.ToolStripMenuItem mnuGroups1;
        System.Windows.Forms.ToolStripMenuItem mnuSecuredValues1;
        System.Windows.Forms.ToolStripMenuItem mnuDeveloperTools1;
        System.Windows.Forms.ToolStripMenuItem mnuTestErrorLog1;
        System.Windows.Forms.ToolStripMenuItem mnuFireflyAbout1;
        System.Windows.Forms.ToolStripMenuItem mnuCallStack1;
        System.Windows.Forms.ToolStripMenuItem mnuCallStackBrowser1;
        System.Windows.Forms.ToolStripMenuItem mnuEntityBrowser1;
        System.Windows.Forms.ToolStripMenuItem mnuProgramsProwser1;
        System.Windows.Forms.ToolStripMenuItem mnuGetDefiniton1;
        System.Windows.Forms.ToolStripMenuItem mnuSQLQuery1;
        System.Windows.Forms.ToolStripMenuItem mnuPathDecoderValues1;
        System.Windows.Forms.ToolStripMenuItem mnuTestPathDecode1;
        System.Windows.Forms.ToolStripMenuItem mnuMemoryMonitor1;
        System.Windows.Forms.ToolStripMenuItem mnuEnableAdvancedFeatures2;
        System.Windows.Forms.ToolStripMenuItem mnuEnableAdvancedFeatures3;
        System.Windows.Forms.ToolStripMenuItem mnuFaceLift1;
        System.Windows.Forms.ToolStripMenuItem mnuClearValue;
        System.Windows.Forms.ToolStripMenuItem mnuClearTemplate;
        System.Windows.Forms.ToolStripMenuItem mnuFromValues;
        System.Windows.Forms.ToolStripMenuItem mnuToValue;
        System.Windows.Forms.ToolStripMenuItem mnuExpression;
        System.Windows.Forms.ToolStripMenuItem mnuMaintenance;
        System.Windows.Forms.ToolStripMenuItem mnuUsers2;
        System.Windows.Forms.ToolStripMenuItem mnuGroups2;
        System.Windows.Forms.ToolStripMenuItem mnuApplications;
        System.Windows.Forms.ToolStripSeparator seperator6;
        System.Windows.Forms.ToolStripMenuItem mnuAttachUserToGroups;
        System.Windows.Forms.ToolStripMenuItem mnuAttachGroupToApplications;
        System.Windows.Forms.ToolStripSeparator seperator7;
        System.Windows.Forms.ToolStripMenuItem mnuAccessControl;
        System.Windows.Forms.ToolStripMenuItem mnuUtilities;
        System.Windows.Forms.ToolStripMenuItem mnuBrowses;
        System.Windows.Forms.ToolStripMenuItem mnuUsers3;
        System.Windows.Forms.ToolStripMenuItem mnuGroups3;
        System.Windows.Forms.ToolStripMenuItem mnuApplications1;
        System.Windows.Forms.ToolStripSeparator seperator8;
        System.Windows.Forms.ToolStripMenuItem mnuUserGroups;
        System.Windows.Forms.ToolStripMenuItem mnuGroupApplications;
        System.Windows.Forms.ToolStripMenuItem mnuUserAccessList;
        System.Windows.Forms.ToolStripSeparator seperator9;
        System.Windows.Forms.ToolStripMenuItem mnuUserEmailAddresses;
        System.Windows.Forms.ToolStripMenuItem mnuControl;
        System.Windows.Forms.ToolStripSeparator seperator10;
        System.Windows.Forms.ToolStripMenuItem mnuAccessControl1;
        System.Windows.Forms.ToolStripSeparator seperator11;
        System.Windows.Forms.ToolStripMenuItem mnuExports;
        System.Windows.Forms.ToolStripMenuItem mnuUsers4;
        System.Windows.Forms.ToolStripMenuItem mnuGroups4;
        System.Windows.Forms.ToolStripMenuItem mnuApplications2;
        System.Windows.Forms.ToolStripSeparator seperator12;
        System.Windows.Forms.ToolStripMenuItem mnuUserGroups1;
        System.Windows.Forms.ToolStripMenuItem mnuGroupApplications1;
        System.Windows.Forms.ToolStripSeparator seperator13;
        System.Windows.Forms.ToolStripMenuItem mnuUserEmailAddresses1;
        System.Windows.Forms.ToolStripMenuItem mnuControl1;
        System.Windows.Forms.ToolStripMenuItem mnuImports;
        System.Windows.Forms.ToolStripMenuItem mnuUsers5;
        System.Windows.Forms.ToolStripMenuItem mnuGroups5;
        System.Windows.Forms.ToolStripMenuItem mnuApplications3;
        System.Windows.Forms.ToolStripSeparator seperator14;
        System.Windows.Forms.ToolStripMenuItem mnuUserGroups2;
        System.Windows.Forms.ToolStripMenuItem mnuGroupApplications2;
        System.Windows.Forms.ToolStripSeparator seperator15;
        System.Windows.Forms.ToolStripMenuItem mnuUserEmailAddresses2;
        System.Windows.Forms.ToolStripMenuItem mnuControl2;
        System.Windows.Forms.ToolStripSeparator seperator16;
        System.Windows.Forms.ToolStripMenuItem mnuDocumentation;
        System.Windows.Forms.ToolStripButton tsbDocumentation;
        System.Windows.Forms.ToolStripMenuItem mnuMackaysIntranet;
        System.Windows.Forms.ToolStripButton tsbMackaysIntranet;
        System.Windows.Forms.ToolStripMenuItem mnuWebGo;
        System.Windows.Forms.ToolStripButton tsbWebGo;
        System.Windows.Forms.ToolStripMenuItem mnuHelp;
        System.Windows.Forms.ToolStripMenuItem mnuHelp1;
        System.Windows.Forms.ToolStripButton tsbHelp;
        System.Windows.Forms.ToolStripSeparator seperator17;
        System.Windows.Forms.ToolStripMenuItem mnuAbout;
        System.Windows.Forms.ToolStripMenuItem mnuVCR;
        System.Windows.Forms.ToolStripMenuItem mnuBeginTable;
        System.Windows.Forms.ToolStripButton tsbBeginTable;
        System.Windows.Forms.ToolStripMenuItem mnuPreviousScreen;
        System.Windows.Forms.ToolStripButton tsbPreviousScreen;
        System.Windows.Forms.ToolStripMenuItem mnuPreviousRow;
        System.Windows.Forms.ToolStripButton tsbPreviousRow;
        System.Windows.Forms.ToolStripMenuItem mnuNextRow;
        System.Windows.Forms.ToolStripButton tsbNextRow;
        System.Windows.Forms.ToolStripMenuItem mnuNextScreen;
        System.Windows.Forms.ToolStripButton tsbNextScreen;
        System.Windows.Forms.ToolStripMenuItem mnuEndTable;
        System.Windows.Forms.ToolStripButton tsbEndTable;
        System.Windows.Forms.ToolStripMenuItem mnuOLE2;
        System.Windows.Forms.ToolStrip DefaultPulldownMenuToolStrip;
        System.Windows.Forms.ToolStripSeparator seperator18;
        System.Windows.Forms.ToolStripSeparator seperator19;
        System.Windows.Forms.ToolStripSeparator seperator20;
        System.Windows.Forms.ToolStripSeparator seperator21;
        protected override void Dispose(bool disposing)
        {
            if(disposing&&(components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.mainStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.userStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.versionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.activityStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.expandStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.expandTextBoxStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.insertOverrideStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._optionsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.DefaultContextMenu = new System.Windows.Forms.MenuStrip();
            this.DefaultContextMenu1 = new System.Windows.Forms.ContextMenuStrip(components);
            this.DefaultPulldownMenu = new System.Windows.Forms.MenuStrip();
            this.mnuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSecuredValues = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeveloperTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestErrorLog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFireflyAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCallStack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCallStackBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEntityBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProgramsProwser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGetDefiniton = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSQLQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPathDecoderValues = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestPathDecode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMemoryMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnableAdvancedFeatures = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnableAdvancedFeatures1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFaceLift = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu1OffPopUserEmailTable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccessControlDV2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu1OffPopUserEmailTable1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccessControlDV21 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShellToOS = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPrinterSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExitSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUndoEditing = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWide = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDeleteLine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateLine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDitto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetToNULL = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModifyRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQueryRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuLocateARecord = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLocateNext = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRangeOfRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewByKey = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSortRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuUsers1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGroups1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSecuredValues1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeveloperTools1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestErrorLog1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFireflyAbout1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCallStack1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCallStackBrowser1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEntityBrowser1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProgramsProwser1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGetDefiniton1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSQLQuery1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPathDecoderValues1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTestPathDecode1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMemoryMonitor1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnableAdvancedFeatures2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnableAdvancedFeatures3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFaceLift1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearValue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFromValues = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToValue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExpression = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsers2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGroups2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAttachUserToGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAttachGroupToApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAccessControl = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtilities = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBrowses = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsers3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGroups3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuApplications1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuUserGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGroupApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserAccessList = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator9 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuUserEmailAddresses = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuControl = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator10 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAccessControl1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator11 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsers4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGroups4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuApplications2 = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator12 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuUserGroups1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGroupApplications1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator13 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuUserEmailAddresses1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuControl1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsers5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGroups5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuApplications3 = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator14 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuUserGroups2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGroupApplications2 = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator15 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuUserEmailAddresses2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuControl2 = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator16 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDocumentation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMackaysIntranet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWebGo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seperator17 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVCR = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBeginTable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPreviousScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPreviousRow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNextRow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNextScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEndTable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOLE2 = new System.Windows.Forms.ToolStripMenuItem();
            this.DefaultPulldownMenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.seperator18 = new System.Windows.Forms.ToolStripSeparator();
            this.seperator19 = new System.Windows.Forms.ToolStripSeparator();
            this.seperator20 = new System.Windows.Forms.ToolStripSeparator();
            this.seperator21 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModifyRecords = new System.Windows.Forms.ToolStripButton();
            this.tsbCreateRecords = new System.Windows.Forms.ToolStripButton();
            this.tsbQueryRecords = new System.Windows.Forms.ToolStripButton();
            this.tsbLocateARecord = new System.Windows.Forms.ToolStripButton();
            this.tsbLocateNext = new System.Windows.Forms.ToolStripButton();
            this.tsbRangeOfRecords = new System.Windows.Forms.ToolStripButton();
            this.tsbViewByKey = new System.Windows.Forms.ToolStripButton();
            this.tsbSortRecords = new System.Windows.Forms.ToolStripButton();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.tsbBeginTable = new System.Windows.Forms.ToolStripButton();
            this.tsbPreviousScreen = new System.Windows.Forms.ToolStripButton();
            this.tsbPreviousRow = new System.Windows.Forms.ToolStripButton();
            this.tsbNextRow = new System.Windows.Forms.ToolStripButton();
            this.tsbNextScreen = new System.Windows.Forms.ToolStripButton();
            this.tsbEndTable = new System.Windows.Forms.ToolStripButton();
            this.tsbDocumentation = new System.Windows.Forms.ToolStripButton();
            this.tsbMackaysIntranet = new System.Windows.Forms.ToolStripButton();
            this.tsbWebGo = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip.SuspendLayout();
            this.DefaultContextMenu.SuspendLayout();
            this.DefaultPulldownMenu.SuspendLayout();
            this.DefaultPulldownMenuToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.AutoSize = false;
            this.StatusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.StatusStrip.ContextMenuStrip = _optionsContextMenuStrip;
            this.StatusStrip.ForeColor = System.Drawing.SystemColors.MenuText;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainStatusLabel,
            this.userStatusLabel,
            this.versionStatusLabel,
            this.activityStatusLabel,
            this.expandStatusLabel,
            this.expandTextBoxStatusLabel,
            this.insertOverrideStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 420);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(600, 20);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 1;
            // 
            // mainStatusLabel
            // 
            this.mainStatusLabel.AutoSize = false;
            this.mainStatusLabel.Name = "mainStatusLabel";
            this.mainStatusLabel.Size = new System.Drawing.Size(255, 15);
            this.mainStatusLabel.Spring = true;
            this.mainStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userStatusLabel
            // 
            this.userStatusLabel.AutoSize = false;
            this.userStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.userStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.userStatusLabel.Name = "userStatusLabel";
            this.userStatusLabel.Size = new System.Drawing.Size(120, 15);
            this.userStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // versionStatusLabel
            // 
            this.versionStatusLabel.AutoSize = false;
            this.versionStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.versionStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.versionStatusLabel.Name = "versionStatusLabel";
            this.versionStatusLabel.Size = new System.Drawing.Size(120, 15);
            this.versionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // activityStatusLabel
            // 
            this.activityStatusLabel.AutoSize = false;
            this.activityStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.activityStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.activityStatusLabel.Name = "activityStatusLabel";
            this.activityStatusLabel.Size = new System.Drawing.Size(60, 15);
            this.activityStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // expandStatusLabel
            // 
            this.expandStatusLabel.AutoSize = false;
            this.expandStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.expandStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.expandStatusLabel.Name = "expandStatusLabel";
            this.expandStatusLabel.Size = new System.Drawing.Size(60, 15);
            this.expandStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expandStatusLabel.Click += new System.EventHandler(this.expandStatusLabel_Click);
            // 
            // expandTextBoxStatusLabel
            // 
            this.expandTextBoxStatusLabel.AutoSize = false;
            this.expandTextBoxStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.expandTextBoxStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.expandTextBoxStatusLabel.Name = "expandTextBoxStatusLabel";
            this.expandTextBoxStatusLabel.Size = new System.Drawing.Size(60, 15);
            this.expandTextBoxStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expandTextBoxStatusLabel.Click += new System.EventHandler(this.expandTextBoxStatusLabel_Click);
            // 
            // insertOverrideStatusLabel
            // 
            this.insertOverrideStatusLabel.AutoSize = false;
            this.insertOverrideStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.insertOverrideStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.insertOverrideStatusLabel.Name = "insertOverrideStatusLabel";
            this.insertOverrideStatusLabel.Size = new System.Drawing.Size(30, 15);
            this.insertOverrideStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _optionsContextMenuStrip
            // 
            _optionsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsers,
            this.mnuGroups,
            this.mnuSecuredValues,
            this.mnuDeveloperTools});
            _optionsContextMenuStrip.Name = "_optionsContextMenuStrip";
            // 
            // mnuUsers
            // 
            this.mnuUsers.Name = "mnuUsers";
            this.mnuUsers.Text = "Users";
            this.mnuUsers.Click += new System.EventHandler(this.Users_Click);
            // 
            // mnuGroups
            // 
            this.mnuGroups.Name = "mnuGroups";
            this.mnuGroups.Text = "Groups";
            this.mnuGroups.Click += new System.EventHandler(this.Groups_Click);
            // 
            // mnuSecuredValues
            // 
            this.mnuSecuredValues.Name = "mnuSecuredValues";
            this.mnuSecuredValues.Text = "Secured Values";
            this.mnuSecuredValues.Click += new System.EventHandler(this.SecuredValues_Click);
            // 
            // mnuDeveloperTools
            // 
            this.mnuDeveloperTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTestErrorLog,
            this.mnuFireflyAbout,
            this.mnuCallStack,
            this.mnuCallStackBrowser,
            this.mnuEntityBrowser,
            this.mnuProgramsProwser,
            this.mnuGetDefiniton,
            this.mnuSQLQuery,
            this.mnuPathDecoderValues,
            this.mnuTestPathDecode,
            this.mnuMemoryMonitor,
            this.mnuEnableAdvancedFeatures,
            this.mnuEnableAdvancedFeatures1,
            this.mnuFaceLift});
            this.mnuDeveloperTools.Name = "mnuDeveloperTools";
            this.mnuDeveloperTools.Text = "Developer Tools";
            // 
            // mnuTestErrorLog
            // 
            this.mnuTestErrorLog.Name = "mnuTestErrorLog";
            this.mnuTestErrorLog.Text = "Test Error Log";
            this.mnuTestErrorLog.Click += new System.EventHandler(this.TestErrorLog_Click);
            // 
            // mnuFireflyAbout
            // 
            this.mnuFireflyAbout.Name = "mnuFireflyAbout";
            this.mnuFireflyAbout.Text = "About Firefly";
            this.mnuFireflyAbout.Click += new System.EventHandler(this.FireflyAbout_Click);
            // 
            // mnuCallStack
            // 
            this.mnuCallStack.Name = "mnuCallStack";
            this.mnuCallStack.Text = "Call Stack";
            this.mnuCallStack.Click += new System.EventHandler(this.CallStack_Click);
            // 
            // mnuCallStackBrowser
            // 
            this.mnuCallStackBrowser.Name = "mnuCallStackBrowser";
            this.mnuCallStackBrowser.Text = "Application Call Stack";
            this.mnuCallStackBrowser.Click += new System.EventHandler(this.CallStackBrowser_Click);
            // 
            // mnuEntityBrowser
            // 
            this.mnuEntityBrowser.Name = "mnuEntityBrowser";
            this.mnuEntityBrowser.Text = "Browse Entity Data";
            this.mnuEntityBrowser.Click += new System.EventHandler(this.EntityBrowser_Click);
            // 
            // mnuProgramsProwser
            // 
            this.mnuProgramsProwser.Name = "mnuProgramsProwser";
            this.mnuProgramsProwser.Text = "Run a Program";
            this.mnuProgramsProwser.Click += new System.EventHandler(this.ProgramsProwser_Click);
            // 
            // mnuGetDefiniton
            // 
            this.mnuGetDefiniton.Name = "mnuGetDefiniton";
            this.mnuGetDefiniton.Text = "Generate Entity C#";
            this.mnuGetDefiniton.Click += new System.EventHandler(this.GetDefiniton_Click);
            // 
            // mnuSQLQuery
            // 
            this.mnuSQLQuery.Name = "mnuSQLQuery";
            this.mnuSQLQuery.Text = "Execute SQL Query";
            this.mnuSQLQuery.Click += new System.EventHandler(this.SQLQuery_Click);
            // 
            // mnuPathDecoderValues
            // 
            this.mnuPathDecoderValues.Name = "mnuPathDecoderValues";
            this.mnuPathDecoderValues.Text = "Logical Names";
            this.mnuPathDecoderValues.Click += new System.EventHandler(this.PathDecoderValues_Click);
            // 
            // mnuTestPathDecode
            // 
            this.mnuTestPathDecode.Name = "mnuTestPathDecode";
            this.mnuTestPathDecode.Text = "Test Logical Name";
            this.mnuTestPathDecode.Click += new System.EventHandler(this.TestPathDecode_Click);
            // 
            // mnuMemoryMonitor
            // 
            this.mnuMemoryMonitor.Name = "mnuMemoryMonitor";
            this.mnuMemoryMonitor.Text = "Memory Monitor";
            this.mnuMemoryMonitor.Click += new System.EventHandler(this.MemoryMonitor_Click);
            // 
            // mnuEnableAdvancedFeatures
            // 
            this.mnuEnableAdvancedFeatures.Name = "mnuEnableAdvancedFeatures";
            this.mnuEnableAdvancedFeatures.Text = "Demo - Enable Enhanced Grid Features";
            this.mnuEnableAdvancedFeatures.Click += new System.EventHandler(this.EnableAdvancedFeatures_Click);
            // 
            // mnuEnableAdvancedFeatures1
            // 
            this.mnuEnableAdvancedFeatures1.Name = "mnuEnableAdvancedFeatures1";
            this.mnuEnableAdvancedFeatures1.Text = "Demo - Enhanced Grid UI";
            this.mnuEnableAdvancedFeatures1.Click += new System.EventHandler(this.EnableAdvancedFeatures_Click1);
            // 
            // mnuFaceLift
            // 
            this.mnuFaceLift.Name = "mnuFaceLift";
            this.mnuFaceLift.Text = "Demo - FaceLift";
            this.mnuFaceLift.Click += new System.EventHandler(this.FaceLift_Click);
            // 
            // DefaultContextMenu
            // 
            this.DefaultContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu1OffPopUserEmailTable,
            this.mnuAccessControlDV2});
            this.DefaultContextMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.DefaultContextMenu.Name = "DefaultContextMenu";
            this.DefaultContextMenu.Visible = false;
            // 
            // DefaultContextMenu1
            // 
            DefaultContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu1OffPopUserEmailTable1,
            this.mnuAccessControlDV21});
            DefaultContextMenu1.Name = "DefaultContextMenu1";
            // 
            // DefaultPulldownMenu
            // 
            this.DefaultPulldownMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuOptions,
            this.mnuMaintenance,
            this.mnuUtilities,
            this.mnuHelp,
            this.mnuVCR,
            this.mnuOLE2});
            this.DefaultPulldownMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.DefaultPulldownMenu.Name = "DefaultPulldownMenu";
            // 
            // mnu1OffPopUserEmailTable
            // 
            this.mnu1OffPopUserEmailTable.Name = "mnu1OffPopUserEmailTable";
            this.mnu1OffPopUserEmailTable.Text = "1 off Pop User Email Table";
            this.mnu1OffPopUserEmailTable.Click += new System.EventHandler(this.No1OffPopUserEmailTable_Click);
            // 
            // mnuAccessControlDV2
            // 
            this.mnuAccessControlDV2.Name = "mnuAccessControlDV2";
            this.mnuAccessControlDV2.Text = "Access Control  DV 2";
            this.mnuAccessControlDV2.Click += new System.EventHandler(this.AccessControlDV2_Click);
            // 
            // mnu1OffPopUserEmailTable1
            // 
            this.mnu1OffPopUserEmailTable1.Name = "mnu1OffPopUserEmailTable1";
            this.mnu1OffPopUserEmailTable1.Text = "1 off Pop User Email Table";
            this.mnu1OffPopUserEmailTable1.Click += new System.EventHandler(this.No1OffPopUserEmailTable_Click1);
            // 
            // mnuAccessControlDV21
            // 
            this.mnuAccessControlDV21.Name = "mnuAccessControlDV21";
            this.mnuAccessControlDV21.Text = "Access Control  DV 2";
            this.mnuAccessControlDV21.Click += new System.EventHandler(this.AccessControlDV2_Click1);
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShellToOS,
            this.seperator,
            this.mnuPrinterSetup,
            this.seperator1,
            this.mnuExitSystem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Text = "&File";
            // 
            // mnuShellToOS
            // 
            this.mnuShellToOS.Name = "mnuShellToOS";
            this.mnuShellToOS.Text = "&Shell to OS";
            // 
            // seperator
            // 
            this.seperator.Name = "seperator";
            // 
            // mnuPrinterSetup
            // 
            this.mnuPrinterSetup.Name = "mnuPrinterSetup";
            this.mnuPrinterSetup.Text = "&Printer Setup";
            // 
            // seperator1
            // 
            this.seperator1.Name = "seperator1";
            // 
            // mnuExitSystem
            // 
            this.mnuExitSystem.Name = "mnuExitSystem";
            this.mnuExitSystem.Text = "E&xit System";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCancel,
            this.mnuUndoEditing,
            this.seperator2,
            this.mnuZoom,
            this.mnuWide,
            this.seperator3,
            this.mnuDeleteLine,
            this.mnuCreateLine,
            this.mnuCopy,
            this.mnuPaste,
            this.mnuDitto,
            this.mnuSetToNULL});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuCancel
            // 
            this.mnuCancel.Name = "mnuCancel";
            this.mnuCancel.Text = "&Cancel";
            // 
            // mnuUndoEditing
            // 
            this.mnuUndoEditing.Name = "mnuUndoEditing";
            this.mnuUndoEditing.Text = "Undo Editing";
            // 
            // seperator2
            // 
            this.seperator2.Name = "seperator2";
            // 
            // mnuZoom
            // 
            this.mnuZoom.Name = "mnuZoom";
            this.mnuZoom.Text = "&Zoom";
            // 
            // mnuWide
            // 
            this.mnuWide.Name = "mnuWide";
            this.mnuWide.Text = "&Wide";
            // 
            // seperator3
            // 
            this.seperator3.Name = "seperator3";
            // 
            // mnuDeleteLine
            // 
            this.mnuDeleteLine.Name = "mnuDeleteLine";
            this.mnuDeleteLine.Text = "&Delete Line";
            // 
            // mnuCreateLine
            // 
            this.mnuCreateLine.Name = "mnuCreateLine";
            this.mnuCreateLine.Text = "Crea&te Line";
            // 
            // mnuCopy
            // 
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.Text = "C&opy";
            // 
            // mnuPaste
            // 
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.Text = "&Paste";
            // 
            // mnuDitto
            // 
            this.mnuDitto.Name = "mnuDitto";
            this.mnuDitto.Text = "Di&tto";
            // 
            // mnuSetToNULL
            // 
            this.mnuSetToNULL.Name = "mnuSetToNULL";
            this.mnuSetToNULL.Text = "Set to &NULL";
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuModifyRecords,
            this.mnuCreateRecords,
            this.mnuQueryRecords,
            this.seperator4,
            this.mnuLocateARecord,
            this.mnuLocateNext,
            this.mnuRangeOfRecords,
            this.mnuViewByKey,
            this.mnuSortRecords,
            this.seperator5,
            this.mnuUsers1,
            this.mnuGroups1,
            this.mnuSecuredValues1,
            this.mnuDeveloperTools1,
            this.mnuClearValue,
            this.mnuClearTemplate,
            this.mnuFromValues,
            this.mnuToValue,
            this.mnuExpression});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Text = "&Options";
            // 
            // mnuModifyRecords
            // 
            this.mnuModifyRecords.Name = "mnuModifyRecords";
            this.mnuModifyRecords.Text = "&Modify Records";
            // 
            // mnuCreateRecords
            // 
            this.mnuCreateRecords.Name = "mnuCreateRecords";
            this.mnuCreateRecords.Text = "&Create Records";
            // 
            // mnuQueryRecords
            // 
            this.mnuQueryRecords.Name = "mnuQueryRecords";
            this.mnuQueryRecords.Text = "&Query Records";
            // 
            // seperator4
            // 
            this.seperator4.Name = "seperator4";
            // 
            // mnuLocateARecord
            // 
            this.mnuLocateARecord.Name = "mnuLocateARecord";
            this.mnuLocateARecord.Text = "&Locate a Record";
            // 
            // mnuLocateNext
            // 
            this.mnuLocateNext.Name = "mnuLocateNext";
            this.mnuLocateNext.Text = "Locate &Next";
            // 
            // mnuRangeOfRecords
            // 
            this.mnuRangeOfRecords.Name = "mnuRangeOfRecords";
            this.mnuRangeOfRecords.Text = "&Range of Records";
            // 
            // mnuViewByKey
            // 
            this.mnuViewByKey.Name = "mnuViewByKey";
            this.mnuViewByKey.Text = "&View by Key";
            // 
            // mnuSortRecords
            // 
            this.mnuSortRecords.Name = "mnuSortRecords";
            this.mnuSortRecords.Text = "&Sort Records";
            // 
            // seperator5
            // 
            this.seperator5.Name = "seperator5";
            // 
            // mnuUsers1
            // 
            this.mnuUsers1.Name = "mnuUsers1";
            this.mnuUsers1.Text = "Users";
            this.mnuUsers1.Click += new System.EventHandler(this.Users_Click1);
            // 
            // mnuGroups1
            // 
            this.mnuGroups1.Name = "mnuGroups1";
            this.mnuGroups1.Text = "Groups";
            this.mnuGroups1.Click += new System.EventHandler(this.Groups_Click1);
            // 
            // mnuSecuredValues1
            // 
            this.mnuSecuredValues1.Name = "mnuSecuredValues1";
            this.mnuSecuredValues1.Text = "Secured Values";
            this.mnuSecuredValues1.Click += new System.EventHandler(this.SecuredValues_Click1);
            // 
            // mnuDeveloperTools1
            // 
            this.mnuDeveloperTools1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTestErrorLog1,
            this.mnuFireflyAbout1,
            this.mnuCallStack1,
            this.mnuCallStackBrowser1,
            this.mnuEntityBrowser1,
            this.mnuProgramsProwser1,
            this.mnuGetDefiniton1,
            this.mnuSQLQuery1,
            this.mnuPathDecoderValues1,
            this.mnuTestPathDecode1,
            this.mnuMemoryMonitor1,
            this.mnuEnableAdvancedFeatures2,
            this.mnuEnableAdvancedFeatures3,
            this.mnuFaceLift1});
            this.mnuDeveloperTools1.Name = "mnuDeveloperTools1";
            this.mnuDeveloperTools1.Text = "Developer Tools";
            // 
            // mnuTestErrorLog1
            // 
            this.mnuTestErrorLog1.Name = "mnuTestErrorLog1";
            this.mnuTestErrorLog1.Text = "Test Error Log";
            this.mnuTestErrorLog1.Click += new System.EventHandler(this.TestErrorLog_Click1);
            // 
            // mnuFireflyAbout1
            // 
            this.mnuFireflyAbout1.Name = "mnuFireflyAbout1";
            this.mnuFireflyAbout1.Text = "About Firefly";
            this.mnuFireflyAbout1.Click += new System.EventHandler(this.FireflyAbout_Click1);
            // 
            // mnuCallStack1
            // 
            this.mnuCallStack1.Name = "mnuCallStack1";
            this.mnuCallStack1.Text = "Call Stack";
            this.mnuCallStack1.Click += new System.EventHandler(this.CallStack_Click1);
            // 
            // mnuCallStackBrowser1
            // 
            this.mnuCallStackBrowser1.Name = "mnuCallStackBrowser1";
            this.mnuCallStackBrowser1.Text = "Application Call Stack";
            this.mnuCallStackBrowser1.Click += new System.EventHandler(this.CallStackBrowser_Click1);
            // 
            // mnuEntityBrowser1
            // 
            this.mnuEntityBrowser1.Name = "mnuEntityBrowser1";
            this.mnuEntityBrowser1.Text = "Browse Entity Data";
            this.mnuEntityBrowser1.Click += new System.EventHandler(this.EntityBrowser_Click1);
            // 
            // mnuProgramsProwser1
            // 
            this.mnuProgramsProwser1.Name = "mnuProgramsProwser1";
            this.mnuProgramsProwser1.Text = "Run a Program";
            this.mnuProgramsProwser1.Click += new System.EventHandler(this.ProgramsProwser_Click1);
            // 
            // mnuGetDefiniton1
            // 
            this.mnuGetDefiniton1.Name = "mnuGetDefiniton1";
            this.mnuGetDefiniton1.Text = "Generate Entity C#";
            this.mnuGetDefiniton1.Click += new System.EventHandler(this.GetDefiniton_Click1);
            // 
            // mnuSQLQuery1
            // 
            this.mnuSQLQuery1.Name = "mnuSQLQuery1";
            this.mnuSQLQuery1.Text = "Execute SQL Query";
            this.mnuSQLQuery1.Click += new System.EventHandler(this.SQLQuery_Click1);
            // 
            // mnuPathDecoderValues1
            // 
            this.mnuPathDecoderValues1.Name = "mnuPathDecoderValues1";
            this.mnuPathDecoderValues1.Text = "Logical Names";
            this.mnuPathDecoderValues1.Click += new System.EventHandler(this.PathDecoderValues_Click1);
            // 
            // mnuTestPathDecode1
            // 
            this.mnuTestPathDecode1.Name = "mnuTestPathDecode1";
            this.mnuTestPathDecode1.Text = "Test Logical Name";
            this.mnuTestPathDecode1.Click += new System.EventHandler(this.TestPathDecode_Click1);
            // 
            // mnuMemoryMonitor1
            // 
            this.mnuMemoryMonitor1.Name = "mnuMemoryMonitor1";
            this.mnuMemoryMonitor1.Text = "Memory Monitor";
            this.mnuMemoryMonitor1.Click += new System.EventHandler(this.MemoryMonitor_Click1);
            // 
            // mnuEnableAdvancedFeatures2
            // 
            this.mnuEnableAdvancedFeatures2.Name = "mnuEnableAdvancedFeatures2";
            this.mnuEnableAdvancedFeatures2.Text = "Demo - Enable Enhanced Grid Features";
            this.mnuEnableAdvancedFeatures2.Click += new System.EventHandler(this.EnableAdvancedFeatures_Click2);
            // 
            // mnuEnableAdvancedFeatures3
            // 
            this.mnuEnableAdvancedFeatures3.Name = "mnuEnableAdvancedFeatures3";
            this.mnuEnableAdvancedFeatures3.Text = "Demo - Enhanced Grid UI";
            this.mnuEnableAdvancedFeatures3.Click += new System.EventHandler(this.EnableAdvancedFeatures_Click3);
            // 
            // mnuFaceLift1
            // 
            this.mnuFaceLift1.Name = "mnuFaceLift1";
            this.mnuFaceLift1.Text = "Demo - FaceLift";
            this.mnuFaceLift1.Click += new System.EventHandler(this.FaceLift_Click1);
            // 
            // mnuClearValue
            // 
            this.mnuClearValue.Name = "mnuClearValue";
            this.mnuClearValue.Text = "Clear Value";
            this.mnuClearValue.Visible = false;
            // 
            // mnuClearTemplate
            // 
            this.mnuClearTemplate.Name = "mnuClearTemplate";
            this.mnuClearTemplate.Text = "Clear Template";
            this.mnuClearTemplate.Visible = false;
            // 
            // mnuFromValues
            // 
            this.mnuFromValues.Name = "mnuFromValues";
            this.mnuFromValues.Text = "From Values";
            this.mnuFromValues.Visible = false;
            // 
            // mnuToValue
            // 
            this.mnuToValue.Name = "mnuToValue";
            this.mnuToValue.Text = "To Value";
            this.mnuToValue.Visible = false;
            // 
            // mnuExpression
            // 
            this.mnuExpression.Name = "mnuExpression";
            this.mnuExpression.Text = "Expression";
            this.mnuExpression.Visible = false;
            // 
            // mnuMaintenance
            // 
            this.mnuMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsers2,
            this.mnuGroups2,
            this.mnuApplications,
            this.seperator6,
            this.mnuAttachUserToGroups,
            this.mnuAttachGroupToApplications,
            this.seperator7,
            this.mnuAccessControl});
            this.mnuMaintenance.Name = "mnuMaintenance";
            this.mnuMaintenance.Text = "&Maintenance";
            // 
            // mnuUsers2
            // 
            this.mnuUsers2.Name = "mnuUsers2";
            this.mnuUsers2.Text = "&Users";
            this.mnuUsers2.Click += new System.EventHandler(this.Users_Click2);
            // 
            // mnuGroups2
            // 
            this.mnuGroups2.Name = "mnuGroups2";
            this.mnuGroups2.Text = "&Groups";
            this.mnuGroups2.Click += new System.EventHandler(this.Groups_Click2);
            // 
            // mnuApplications
            // 
            this.mnuApplications.Name = "mnuApplications";
            this.mnuApplications.Text = "&Applications";
            this.mnuApplications.Click += new System.EventHandler(this.Applications_Click);
            // 
            // seperator6
            // 
            this.seperator6.Name = "seperator6";
            // 
            // mnuAttachUserToGroups
            // 
            this.mnuAttachUserToGroups.Name = "mnuAttachUserToGroups";
            this.mnuAttachUserToGroups.Text = "Attach U&ser to Groups";
            this.mnuAttachUserToGroups.Click += new System.EventHandler(this.AttachUserToGroups_Click);
            // 
            // mnuAttachGroupToApplications
            // 
            this.mnuAttachGroupToApplications.Name = "mnuAttachGroupToApplications";
            this.mnuAttachGroupToApplications.Text = "Attach G&roup to Applications";
            this.mnuAttachGroupToApplications.Click += new System.EventHandler(this.AttachGroupToApplications_Click);
            // 
            // seperator7
            // 
            this.seperator7.Name = "seperator7";
            // 
            // mnuAccessControl
            // 
            this.mnuAccessControl.Name = "mnuAccessControl";
            this.mnuAccessControl.Text = "Access &Control";
            this.mnuAccessControl.Click += new System.EventHandler(this.AccessControl_Click);
            // 
            // mnuUtilities
            // 
            this.mnuUtilities.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBrowses,
            this.seperator10,
            this.mnuAccessControl1,
            this.seperator11,
            this.mnuExports,
            this.mnuImports,
            this.seperator16,
            this.mnuDocumentation,
            this.mnuMackaysIntranet,
            this.mnuWebGo});
            this.mnuUtilities.Name = "mnuUtilities";
            this.mnuUtilities.Text = "&Utilities";
            // 
            // mnuBrowses
            // 
            this.mnuBrowses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsers3,
            this.mnuGroups3,
            this.mnuApplications1,
            this.seperator8,
            this.mnuUserGroups,
            this.mnuGroupApplications,
            this.mnuUserAccessList,
            this.seperator9,
            this.mnuUserEmailAddresses,
            this.mnuControl});
            this.mnuBrowses.Name = "mnuBrowses";
            this.mnuBrowses.Text = "&Browses";
            // 
            // mnuUsers3
            // 
            this.mnuUsers3.Name = "mnuUsers3";
            this.mnuUsers3.Text = "&Users";
            this.mnuUsers3.Click += new System.EventHandler(this.Users_Click3);
            // 
            // mnuGroups3
            // 
            this.mnuGroups3.Name = "mnuGroups3";
            this.mnuGroups3.Text = "&Groups";
            this.mnuGroups3.Click += new System.EventHandler(this.Groups_Click3);
            // 
            // mnuApplications1
            // 
            this.mnuApplications1.Name = "mnuApplications1";
            this.mnuApplications1.Text = "&Applications";
            this.mnuApplications1.Click += new System.EventHandler(this.Applications_Click1);
            // 
            // seperator8
            // 
            this.seperator8.Name = "seperator8";
            // 
            // mnuUserGroups
            // 
            this.mnuUserGroups.Name = "mnuUserGroups";
            this.mnuUserGroups.Text = "U&serGroups";
            this.mnuUserGroups.Click += new System.EventHandler(this.UserGroups_Click);
            // 
            // mnuGroupApplications
            // 
            this.mnuGroupApplications.Name = "mnuGroupApplications";
            this.mnuGroupApplications.Text = "G&roupApplications";
            this.mnuGroupApplications.Click += new System.EventHandler(this.GroupApplications_Click);
            // 
            // mnuUserAccessList
            // 
            this.mnuUserAccessList.Name = "mnuUserAccessList";
            this.mnuUserAccessList.Text = "UserAccess&List";
            this.mnuUserAccessList.Click += new System.EventHandler(this.UserAccessList_Click);
            // 
            // seperator9
            // 
            this.seperator9.Name = "seperator9";
            // 
            // mnuUserEmailAddresses
            // 
            this.mnuUserEmailAddresses.Name = "mnuUserEmailAddresses";
            this.mnuUserEmailAddresses.Text = "User &Email Addresses";
            this.mnuUserEmailAddresses.Click += new System.EventHandler(this.UserEmailAddresses_Click);
            // 
            // mnuControl
            // 
            this.mnuControl.Name = "mnuControl";
            this.mnuControl.Text = "&Control";
            this.mnuControl.Click += new System.EventHandler(this.Control_Click);
            // 
            // seperator10
            // 
            this.seperator10.Name = "seperator10";
            // 
            // mnuAccessControl1
            // 
            this.mnuAccessControl1.Name = "mnuAccessControl1";
            this.mnuAccessControl1.Text = "Access &Control";
            this.mnuAccessControl1.Click += new System.EventHandler(this.AccessControl_Click1);
            // 
            // seperator11
            // 
            this.seperator11.Name = "seperator11";
            // 
            // mnuExports
            // 
            this.mnuExports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsers4,
            this.mnuGroups4,
            this.mnuApplications2,
            this.seperator12,
            this.mnuUserGroups1,
            this.mnuGroupApplications1,
            this.seperator13,
            this.mnuUserEmailAddresses1,
            this.mnuControl1});
            this.mnuExports.Name = "mnuExports";
            this.mnuExports.Text = "&Exports";
            // 
            // mnuUsers4
            // 
            this.mnuUsers4.Name = "mnuUsers4";
            this.mnuUsers4.Text = "&Users";
            this.mnuUsers4.Click += new System.EventHandler(this.Users_Click4);
            // 
            // mnuGroups4
            // 
            this.mnuGroups4.Name = "mnuGroups4";
            this.mnuGroups4.Text = "&Groups";
            this.mnuGroups4.Click += new System.EventHandler(this.Groups_Click4);
            // 
            // mnuApplications2
            // 
            this.mnuApplications2.Name = "mnuApplications2";
            this.mnuApplications2.Text = "&Applications";
            this.mnuApplications2.Click += new System.EventHandler(this.Applications_Click2);
            // 
            // seperator12
            // 
            this.seperator12.Name = "seperator12";
            // 
            // mnuUserGroups1
            // 
            this.mnuUserGroups1.Name = "mnuUserGroups1";
            this.mnuUserGroups1.Text = "U&serGroups";
            this.mnuUserGroups1.Click += new System.EventHandler(this.UserGroups_Click1);
            // 
            // mnuGroupApplications1
            // 
            this.mnuGroupApplications1.Name = "mnuGroupApplications1";
            this.mnuGroupApplications1.Text = "G&roupApplications";
            this.mnuGroupApplications1.Click += new System.EventHandler(this.GroupApplications_Click1);
            // 
            // seperator13
            // 
            this.seperator13.Name = "seperator13";
            // 
            // mnuUserEmailAddresses1
            // 
            this.mnuUserEmailAddresses1.Name = "mnuUserEmailAddresses1";
            this.mnuUserEmailAddresses1.Text = "User &Email Addresses";
            this.mnuUserEmailAddresses1.Click += new System.EventHandler(this.UserEmailAddresses_Click1);
            // 
            // mnuControl1
            // 
            this.mnuControl1.Name = "mnuControl1";
            this.mnuControl1.Text = "&Control";
            this.mnuControl1.Click += new System.EventHandler(this.Control_Click1);
            // 
            // mnuImports
            // 
            this.mnuImports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsers5,
            this.mnuGroups5,
            this.mnuApplications3,
            this.seperator14,
            this.mnuUserGroups2,
            this.mnuGroupApplications2,
            this.seperator15,
            this.mnuUserEmailAddresses2,
            this.mnuControl2});
            this.mnuImports.Name = "mnuImports";
            this.mnuImports.Text = "&Imports";
            // 
            // mnuUsers5
            // 
            this.mnuUsers5.Name = "mnuUsers5";
            this.mnuUsers5.Text = "&Users";
            this.mnuUsers5.Click += new System.EventHandler(this.Users_Click5);
            // 
            // mnuGroups5
            // 
            this.mnuGroups5.Name = "mnuGroups5";
            this.mnuGroups5.Text = "&Groups";
            this.mnuGroups5.Click += new System.EventHandler(this.Groups_Click5);
            // 
            // mnuApplications3
            // 
            this.mnuApplications3.Name = "mnuApplications3";
            this.mnuApplications3.Text = "&Applications";
            this.mnuApplications3.Click += new System.EventHandler(this.Applications_Click3);
            // 
            // seperator14
            // 
            this.seperator14.Name = "seperator14";
            // 
            // mnuUserGroups2
            // 
            this.mnuUserGroups2.Name = "mnuUserGroups2";
            this.mnuUserGroups2.Text = "U&serGroups";
            this.mnuUserGroups2.Click += new System.EventHandler(this.UserGroups_Click2);
            // 
            // mnuGroupApplications2
            // 
            this.mnuGroupApplications2.Name = "mnuGroupApplications2";
            this.mnuGroupApplications2.Text = "G&roupApplications";
            this.mnuGroupApplications2.Click += new System.EventHandler(this.GroupApplications_Click2);
            // 
            // seperator15
            // 
            this.seperator15.Name = "seperator15";
            // 
            // mnuUserEmailAddresses2
            // 
            this.mnuUserEmailAddresses2.Name = "mnuUserEmailAddresses2";
            this.mnuUserEmailAddresses2.Text = "User &Email Addresses";
            this.mnuUserEmailAddresses2.Click += new System.EventHandler(this.UserEmailAddresses_Click2);
            // 
            // mnuControl2
            // 
            this.mnuControl2.Name = "mnuControl2";
            this.mnuControl2.Text = "&Control";
            this.mnuControl2.Click += new System.EventHandler(this.Control_Click2);
            // 
            // seperator16
            // 
            this.seperator16.Name = "seperator16";
            // 
            // mnuDocumentation
            // 
            this.mnuDocumentation.Name = "mnuDocumentation";
            this.mnuDocumentation.Text = "Do&cumentation";
            this.mnuDocumentation.ToolTipText = "Documentation";
            this.mnuDocumentation.Click += new System.EventHandler(this.Documentation_Click);
            // 
            // mnuMackaysIntranet
            // 
            this.mnuMackaysIntranet.Name = "mnuMackaysIntranet";
            this.mnuMackaysIntranet.Text = "Mackays &Intranet";
            this.mnuMackaysIntranet.ToolTipText = "Mackays Intranet";
            this.mnuMackaysIntranet.Click += new System.EventHandler(this.MackaysIntranet_Click);
            // 
            // mnuWebGo
            // 
            this.mnuWebGo.Name = "mnuWebGo";
            this.mnuWebGo.Text = "WebGo";
            this.mnuWebGo.ToolTipText = "Mackays on the Web";
            this.mnuWebGo.Click += new System.EventHandler(this.WebGo_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp1,
            this.seperator17,
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelp1
            // 
            this.mnuHelp1.Name = "mnuHelp1";
            this.mnuHelp1.Text = "&Help";
            // 
            // seperator17
            // 
            this.seperator17.Name = "seperator17";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Text = "&About ";
            // 
            // mnuVCR
            // 
            this.mnuVCR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBeginTable,
            this.mnuPreviousScreen,
            this.mnuPreviousRow,
            this.mnuNextRow,
            this.mnuNextScreen,
            this.mnuEndTable});
            this.mnuVCR.Name = "mnuVCR";
            this.mnuVCR.Text = "&VCR";
            // 
            // mnuBeginTable
            // 
            this.mnuBeginTable.Name = "mnuBeginTable";
            this.mnuBeginTable.Text = "Begin Table";
            // 
            // mnuPreviousScreen
            // 
            this.mnuPreviousScreen.Name = "mnuPreviousScreen";
            this.mnuPreviousScreen.Text = "Previous Screen";
            // 
            // mnuPreviousRow
            // 
            this.mnuPreviousRow.Name = "mnuPreviousRow";
            this.mnuPreviousRow.Text = "Previous Row";
            // 
            // mnuNextRow
            // 
            this.mnuNextRow.Name = "mnuNextRow";
            this.mnuNextRow.Text = "Next Row";
            // 
            // mnuNextScreen
            // 
            this.mnuNextScreen.Name = "mnuNextScreen";
            this.mnuNextScreen.Text = "Next Screen";
            // 
            // mnuEndTable
            // 
            this.mnuEndTable.Name = "mnuEndTable";
            this.mnuEndTable.Text = "End Table";
            // 
            // mnuOLE2
            // 
            this.mnuOLE2.Name = "mnuOLE2";
            this.mnuOLE2.Text = "OLE2";
            // 
            // DefaultPulldownMenuToolStrip
            // 
            this.DefaultPulldownMenuToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.DefaultPulldownMenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbModifyRecords,
            this.tsbCreateRecords,
            this.tsbQueryRecords,
            this.seperator18,
            this.tsbLocateARecord,
            this.tsbLocateNext,
            this.tsbRangeOfRecords,
            this.tsbViewByKey,
            this.tsbSortRecords,
            this.seperator19,
            this.tsbHelp,
            this.seperator20,
            this.tsbBeginTable,
            this.tsbPreviousScreen,
            this.tsbPreviousRow,
            this.tsbNextRow,
            this.tsbNextScreen,
            this.tsbEndTable,
            this.seperator21,
            this.tsbDocumentation,
            this.tsbMackaysIntranet,
            this.tsbWebGo});
            this.DefaultPulldownMenuToolStrip.Name = "DefaultPulldownMenuToolStrip";
            // 
            // seperator18
            // 
            this.seperator18.Name = "seperator18";
            this.seperator18.Size = new System.Drawing.Size(6, 25);
            // 
            // seperator19
            // 
            this.seperator19.Name = "seperator19";
            this.seperator19.Size = new System.Drawing.Size(6, 25);
            // 
            // seperator20
            // 
            this.seperator20.Name = "seperator20";
            this.seperator20.Size = new System.Drawing.Size(6, 25);
            // 
            // seperator21
            // 
            this.seperator21.Name = "seperator21";
            this.seperator21.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbModifyRecords
            // 
            this.tsbModifyRecords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModifyRecords.Image = global::MandCo.SystemAccess.Properties.Resources.UpdateMode;
            this.tsbModifyRecords.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbModifyRecords.Name = "tsbModifyRecords";
            this.tsbModifyRecords.ToolTipText = "Modify Records";
            // 
            // tsbCreateRecords
            // 
            this.tsbCreateRecords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCreateRecords.Image = global::MandCo.SystemAccess.Properties.Resources.UnknownImage;
            this.tsbCreateRecords.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbCreateRecords.Name = "tsbCreateRecords";
            this.tsbCreateRecords.ToolTipText = "Create Records";
            // 
            // tsbQueryRecords
            // 
            this.tsbQueryRecords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbQueryRecords.Image = global::MandCo.SystemAccess.Properties.Resources.BrowseMode;
            this.tsbQueryRecords.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbQueryRecords.Name = "tsbQueryRecords";
            this.tsbQueryRecords.ToolTipText = "Query Records";
            // 
            // tsbLocateARecord
            // 
            this.tsbLocateARecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLocateARecord.Image = global::MandCo.SystemAccess.Properties.Resources.Find;
            this.tsbLocateARecord.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbLocateARecord.Name = "tsbLocateARecord";
            this.tsbLocateARecord.ToolTipText = "Locate a Record";
            // 
            // tsbLocateNext
            // 
            this.tsbLocateNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLocateNext.Image = global::MandCo.SystemAccess.Properties.Resources.FindNext;
            this.tsbLocateNext.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbLocateNext.Name = "tsbLocateNext";
            this.tsbLocateNext.ToolTipText = "Locate Next";
            // 
            // tsbRangeOfRecords
            // 
            this.tsbRangeOfRecords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRangeOfRecords.Image = global::MandCo.SystemAccess.Properties.Resources.Filter;
            this.tsbRangeOfRecords.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbRangeOfRecords.Name = "tsbRangeOfRecords";
            this.tsbRangeOfRecords.ToolTipText = "Range of Records";
            // 
            // tsbViewByKey
            // 
            this.tsbViewByKey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbViewByKey.Image = global::MandCo.SystemAccess.Properties.Resources.SelectSort;
            this.tsbViewByKey.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbViewByKey.Name = "tsbViewByKey";
            this.tsbViewByKey.ToolTipText = "View by Key";
            // 
            // tsbSortRecords
            // 
            this.tsbSortRecords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSortRecords.Image = global::MandCo.SystemAccess.Properties.Resources.SelectSort;
            this.tsbSortRecords.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbSortRecords.Name = "tsbSortRecords";
            this.tsbSortRecords.ToolTipText = "Sort Records";
            // 
            // tsbHelp
            // 
            this.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHelp.Image = global::MandCo.SystemAccess.Properties.Resources.Help;
            this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbHelp.Name = "tsbHelp";
            this.tsbHelp.ToolTipText = "Help";
            // 
            // tsbBeginTable
            // 
            this.tsbBeginTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBeginTable.Image = global::MandCo.SystemAccess.Properties.Resources.First;
            this.tsbBeginTable.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbBeginTable.Name = "tsbBeginTable";
            this.tsbBeginTable.ToolTipText = "Begin Table";
            // 
            // tsbPreviousScreen
            // 
            this.tsbPreviousScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPreviousScreen.Image = global::MandCo.SystemAccess.Properties.Resources.PageUp;
            this.tsbPreviousScreen.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbPreviousScreen.Name = "tsbPreviousScreen";
            this.tsbPreviousScreen.ToolTipText = "Previous Screen";
            // 
            // tsbPreviousRow
            // 
            this.tsbPreviousRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPreviousRow.Image = global::MandCo.SystemAccess.Properties.Resources.Previous;
            this.tsbPreviousRow.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbPreviousRow.Name = "tsbPreviousRow";
            this.tsbPreviousRow.ToolTipText = "Previous Row";
            // 
            // tsbNextRow
            // 
            this.tsbNextRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNextRow.Image = global::MandCo.SystemAccess.Properties.Resources.Next;
            this.tsbNextRow.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbNextRow.Name = "tsbNextRow";
            this.tsbNextRow.ToolTipText = "Next Row";
            // 
            // tsbNextScreen
            // 
            this.tsbNextScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNextScreen.Image = global::MandCo.SystemAccess.Properties.Resources.PageDown;
            this.tsbNextScreen.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbNextScreen.Name = "tsbNextScreen";
            this.tsbNextScreen.ToolTipText = "Next Screen";
            // 
            // tsbEndTable
            // 
            this.tsbEndTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEndTable.Image = global::MandCo.SystemAccess.Properties.Resources.Last;
            this.tsbEndTable.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbEndTable.Name = "tsbEndTable";
            this.tsbEndTable.ToolTipText = "End Table";
            // 
            // tsbDocumentation
            // 
            this.tsbDocumentation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDocumentation.Image = global::MandCo.SystemAccess.Properties.Resources.UnknownImage;
            this.tsbDocumentation.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbDocumentation.Name = "tsbDocumentation";
            this.tsbDocumentation.ToolTipText = "Documentation";
            this.tsbDocumentation.Click += new System.EventHandler(this.Documentation_Click);
            // 
            // tsbMackaysIntranet
            // 
            this.tsbMackaysIntranet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMackaysIntranet.Image = global::MandCo.SystemAccess.Properties.Resources.UnknownImage;
            this.tsbMackaysIntranet.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbMackaysIntranet.Name = "tsbMackaysIntranet";
            this.tsbMackaysIntranet.ToolTipText = "Mackays Intranet";
            this.tsbMackaysIntranet.Click += new System.EventHandler(this.MackaysIntranet_Click);
            // 
            // tsbWebGo
            // 
            this.tsbWebGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbWebGo.Image = global::MandCo.SystemAccess.Properties.Resources.UnknownImage;
            this.tsbWebGo.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbWebGo.Name = "tsbWebGo";
            this.tsbWebGo.ToolTipText = "Mackays on the Web";
            this.tsbWebGo.Click += new System.EventHandler(this.WebGo_Click);
            // 
            // ApplicationMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 440);
            this.ContextMenuStrip = this.DefaultContextMenu1;
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.DefaultContextMenu);
            this.Controls.Add(this.DefaultPulldownMenuToolStrip);
            this.Controls.Add(this.DefaultPulldownMenu);
            this.IsMdiContainer = true;
            this.Name = "ApplicationMdi";
            this.Text = "MandCo.SystemAccess";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.DefaultContextMenu.ResumeLayout(false);
            this.DefaultContextMenu.PerformLayout();
            this.DefaultPulldownMenu.ResumeLayout(false);
            this.DefaultPulldownMenu.PerformLayout();
            this.DefaultPulldownMenuToolStrip.ResumeLayout(false);
            this.DefaultPulldownMenuToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
