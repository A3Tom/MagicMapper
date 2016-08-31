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
using Firefly.Box.UI;
using System.Drawing;
using Firefly.Box.UI.Advanced;
using Firefly.Box;
namespace MandCo.SystemAccess.Views
{
    partial class AccessControlORIGINALSystemAccess
    {
        System.ComponentModel.IContainer components;
        Theme.Colors.DefaultHelpWindow clrDefaultHelpWindow;
        Controls.V9CompatibleDefaultTable grd;
        Theme.Controls.GridColumn gcl;
        Theme.Controls.TextBox txtExp_9;
        Theme.Controls.Label lblApplication;
        Theme.Controls.TextBox txtExp_10;
        Controls.Group_txt txtUserAccessListApplication1;
        Theme.Controls.Label lblWelcomeToMackaysDatabaseSystems;
        Theme.Controls.Label lblYouAreAuthorisedToAccessTheseApplicationsPleaseChooseOne;
        Theme.Controls.Shape shp;
        Theme.Controls.GroupBox grpDescription;
        Theme.Controls.PictureBox picMBMPSMac_logoBmp;
        Theme.Controls.TextBox txtApplicationsApplicationDescript;
        Theme.Controls.GroupBox grpUserAccessControl;
        Theme.Controls.GroupBox grpCurrentStatus;
        Theme.Controls.TextBox txtVUserAccessMessage;
        Theme.Controls.TextBox txtExp_14;
        Theme.Controls.Button btnVAllowUserAccess;
        Theme.Controls.Button btnVDisAllowUserAccess;
        Theme.Controls.Button btnVSelect;
        Theme.Controls.Button btnVExit;
        Theme.Fonts.Unused fntUnused;
        Theme.Colors.Reserved30 clrReserved;
        Theme.Fonts.MackaysUserDefined3 fntMackaysUserDefined;
        Theme.Colors.CommentedEntry clrCommentedEntry;
        Theme.Fonts.Reserved35 fntReserved;
        Theme.Colors.DefaultHyperlink clrDefaultHyperlink;
        Theme.Fonts.Reserved34 fntReserved1;
        Theme.Fonts.Reserved36 fntReserved2;
        Theme.Colors.ComponentBuilderWarning clrComponentBuilderWarning;
        Theme.Fonts.SmallFont fntSmallFont;
        Theme.Colors.Reserved19 clrReserved1;
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
            this.clrDefaultHelpWindow = new MandCo.Theme.Colors.DefaultHelpWindow();
            this.fntUnused = new MandCo.Theme.Fonts.Unused();
            this.clrReserved = new MandCo.Theme.Colors.Reserved30();
            this.fntMackaysUserDefined = new MandCo.Theme.Fonts.MackaysUserDefined3();
            this.clrCommentedEntry = new MandCo.Theme.Colors.CommentedEntry();
            this.fntReserved = new MandCo.Theme.Fonts.Reserved35();
            this.clrDefaultHyperlink = new MandCo.Theme.Colors.DefaultHyperlink();
            this.fntReserved1 = new MandCo.Theme.Fonts.Reserved34();
            this.fntReserved2 = new MandCo.Theme.Fonts.Reserved36();
            this.clrComponentBuilderWarning = new MandCo.Theme.Colors.ComponentBuilderWarning();
            this.fntSmallFont = new MandCo.Theme.Fonts.SmallFont();
            this.clrReserved1 = new MandCo.Theme.Colors.Reserved19();
            this.grd = new MandCo.SystemAccess.Views.Controls.V9CompatibleDefaultTable();
            this.gcl = new MandCo.Theme.Controls.GridColumn();
            this.txtUserAccessListApplication1 = new MandCo.SystemAccess.Views.Controls.Group_txt();
            this.txtExp_9 = new MandCo.Theme.Controls.TextBox();
            this.lblApplication = new MandCo.Theme.Controls.Label();
            this.txtExp_10 = new MandCo.Theme.Controls.TextBox();
            this.lblWelcomeToMackaysDatabaseSystems = new MandCo.Theme.Controls.Label();
            this.lblYouAreAuthorisedToAccessTheseApplicationsPleaseChooseOne = new MandCo.Theme.Controls.Label();
            this.shp = new MandCo.Theme.Controls.Shape();
            this.grpDescription = new MandCo.Theme.Controls.GroupBox();
            this.picMBMPSMac_logoBmp = new MandCo.Theme.Controls.PictureBox();
            this.txtApplicationsApplicationDescript = new MandCo.Theme.Controls.TextBox();
            this.grpUserAccessControl = new MandCo.Theme.Controls.GroupBox();
            this.grpCurrentStatus = new MandCo.Theme.Controls.GroupBox();
            this.txtVUserAccessMessage = new MandCo.Theme.Controls.TextBox();
            this.txtExp_14 = new MandCo.Theme.Controls.TextBox();
            this.btnVAllowUserAccess = new MandCo.Theme.Controls.Button();
            this.btnVDisAllowUserAccess = new MandCo.Theme.Controls.Button();
            this.btnVSelect = new MandCo.Theme.Controls.Button();
            this.btnVExit = new MandCo.Theme.Controls.Button();
            this.grd.SuspendLayout();
            this.gcl.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.AllowUserToResizeColumns = false;
            this.grd.Controls.Add(this.gcl);
            this.grd.Location = new System.Drawing.Point(245, 13);
            this.grd.Name = "grd";
            this.grd.RowHeight = 20;
            this.grd.Size = new System.Drawing.Size(194, 386);
            // 
            // gcl
            // 
            this.gcl.Controls.Add(this.txtUserAccessListApplication1);
            this.gcl.Name = "gcl";
            this.gcl.UseTextEndEllipsis = true;
            this.gcl.Width = 179;
            // 
            // txtUserAccessListApplication1
            // 
            this.txtUserAccessListApplication1.AllowFocus = false;
            this.txtUserAccessListApplication1.FontScheme = this.fntMackaysUserDefined;
            this.txtUserAccessListApplication1.Location = new System.Drawing.Point(3, 1);
            this.txtUserAccessListApplication1.Name = "txtUserAccessListApplication1";
            this.txtUserAccessListApplication1.Size = new System.Drawing.Size(163, 13);
            this.txtUserAccessListApplication1.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUserAccessListApplication1.Data = this._controller.UserAccessList.Application1;
            // 
            // txtExp_9
            // 
            this.txtExp_9.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtExp_9.Border = Firefly.Box.UI.ControlBorderStyle.Thin;
            this.txtExp_9.ColorScheme = this.clrReserved;
            this.txtExp_9.FontScheme = this.fntUnused;
            this.txtExp_9.Format = "30";
            this.txtExp_9.Location = new System.Drawing.Point(445, 13);
            this.txtExp_9.Name = "txtExp_9";
            this.txtExp_9.Size = new System.Drawing.Size(173, 20);
            this.txtExp_9.Style = Firefly.Box.UI.ControlStyle.Sunken;
            this.txtExp_9.Data = Firefly.Box.UI.Advanced.ControlData.FromText(_controller.Exp_9);
            // 
            // lblApplication
            // 
            this.lblApplication.BoundTo = new Firefly.Box.UI.ControlBinding(gcl);
            this.lblApplication.ColorScheme = this.clrDefaultHelpWindow;
            this.lblApplication.FontScheme = this.fntMackaysUserDefined;
            this.lblApplication.Location = new System.Drawing.Point(249, 16);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Rtf = "Application";
            this.lblApplication.Size = new System.Drawing.Size(95, 13);
            this.lblApplication.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblApplication.Text = "Application";
            // 
            // txtExp_10
            // 
            this.txtExp_10.ColorScheme = this.clrCommentedEntry;
            this.txtExp_10.FontScheme = this.fntMackaysUserDefined;
            this.txtExp_10.Format = "30";
            this.txtExp_10.Location = new System.Drawing.Point(5, 20);
            this.txtExp_10.Name = "txtExp_10";
            this.txtExp_10.Size = new System.Drawing.Size(230, 19);
            this.txtExp_10.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtExp_10.Data = Firefly.Box.UI.Advanced.ControlData.FromText(_controller.Exp_10);
            // 
            // lblWelcomeToMackaysDatabaseSystems
            // 
            this.lblWelcomeToMackaysDatabaseSystems.ColorScheme = this.clrCommentedEntry;
            this.lblWelcomeToMackaysDatabaseSystems.FontScheme = this.fntMackaysUserDefined;
            this.lblWelcomeToMackaysDatabaseSystems.Location = new System.Drawing.Point(5, 39);
            this.lblWelcomeToMackaysDatabaseSystems.Name = "lblWelcomeToMackaysDatabaseSystems";
            this.lblWelcomeToMackaysDatabaseSystems.Rtf = "Welcome to Mackays Database Systems";
            this.lblWelcomeToMackaysDatabaseSystems.Size = new System.Drawing.Size(230, 20);
            this.lblWelcomeToMackaysDatabaseSystems.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblWelcomeToMackaysDatabaseSystems.Text = "Welcome to Mackays Database Systems";
            // 
            // lblYouAreAuthorisedToAccessTheseApplicationsPleaseChooseOne
            // 
            this.lblYouAreAuthorisedToAccessTheseApplicationsPleaseChooseOne.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblYouAreAuthorisedToAccessTheseApplicationsPleaseChooseOne.ColorScheme = this.clrCommentedEntry;
            this.lblYouAreAuthorisedToAccessTheseApplicationsPleaseChooseOne.FontScheme = this.fntReserved;
            this.lblYouAreAuthorisedToAccessTheseApplicationsPleaseChooseOne.Location = new System.Drawing.Point(453, 59);
            this.lblYouAreAuthorisedToAccessTheseApplicationsPleaseChooseOne.Multiline = true;
            this.lblYouAreAuthorisedToAccessTheseApplicationsPleaseChooseOne.Name = "lblYouAreAuthorisedToAccessTheseApplicationsPleaseChooseOne";
            this.lblYouAreAuthorisedToAccessTheseApplicationsPleaseChooseOne.Rtf = "You are authorised to access these Applications. Please choose one.";
            this.lblYouAreAuthorisedToAccessTheseApplicationsPleaseChooseOne.Size = new System.Drawing.Size(157, 45);
            this.lblYouAreAuthorisedToAccessTheseApplicationsPleaseChooseOne.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblYouAreAuthorisedToAccessTheseApplicationsPleaseChooseOne.Text = "You are authorised to access these Applications. Please choose one.";
            // 
            // shp
            // 
            this.shp.Location = new System.Drawing.Point(0, 130);
            this.shp.Name = "shp";
            this.shp.Size = new System.Drawing.Size(243, 117);
            this.shp.Square = true;
            // 
            // grpDescription
            // 
            this.grpDescription.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.grpDescription.ColorScheme = this.clrDefaultHyperlink;
            this.grpDescription.Location = new System.Drawing.Point(445, 150);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.Size = new System.Drawing.Size(173, 162);
            this.grpDescription.Text = "Description";
            // 
            // picMBMPSMac_logoBmp
            // 
            this.picMBMPSMac_logoBmp.Border = Firefly.Box.UI.ControlBorderStyle.Thin;
            this.picMBMPSMac_logoBmp.ImageLayout = Firefly.Box.UI.ImageLayout.Stretch;
            this.picMBMPSMac_logoBmp.ImageLocation = "M:\\BMPS\\M&Co_logo__white_on_black_227x72.bmp";
            this.picMBMPSMac_logoBmp.Location = new System.Drawing.Point(8, 156);
            this.picMBMPSMac_logoBmp.Name = "picMBMPSMac_logoBmp";
            this.picMBMPSMac_logoBmp.Size = new System.Drawing.Size(227, 72);
            this.picMBMPSMac_logoBmp.Style = Firefly.Box.UI.ControlStyle.Raised;
            // 
            // txtApplicationsApplicationDescript
            // 
            this.txtApplicationsApplicationDescript.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.txtApplicationsApplicationDescript.AllowFocus = false;
            this.txtApplicationsApplicationDescript.ColorScheme = this.clrReserved;
            this.txtApplicationsApplicationDescript.FontScheme = this.fntReserved1;
            this.txtApplicationsApplicationDescript.Location = new System.Drawing.Point(450, 169);
            this.txtApplicationsApplicationDescript.Multiline = true;
            this.txtApplicationsApplicationDescript.Name = "txtApplicationsApplicationDescript";
            this.txtApplicationsApplicationDescript.Size = new System.Drawing.Size(163, 98);
            this.txtApplicationsApplicationDescript.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtApplicationsApplicationDescript.Data = this._controller.Applications.ApplicationDescript;
            // 
            // grpUserAccessControl
            // 
            this.grpUserAccessControl.ColorScheme = this.clrDefaultHyperlink;
            this.grpUserAccessControl.Location = new System.Drawing.Point(8, 260);
            this.grpUserAccessControl.Name = "grpUserAccessControl";
            this.grpUserAccessControl.Size = new System.Drawing.Size(227, 137);
            this.grpUserAccessControl.Style = Firefly.Box.UI.ControlStyle.Sunken;
            this.grpUserAccessControl.Text = "User Access Control";
            this.grpUserAccessControl.BindVisible += new Firefly.Box.UI.Advanced.BindingEventHandler<Firefly.Box.UI.Advanced.BooleanBindingEventArgs>(this.Exp_15_BindVisible);
            // 
            // grpCurrentStatus
            // 
            this.grpCurrentStatus.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpUserAccessControl);
            this.grpCurrentStatus.ColorScheme = this.clrDefaultHyperlink;
            this.grpCurrentStatus.Location = new System.Drawing.Point(28, 351);
            this.grpCurrentStatus.Name = "grpCurrentStatus";
            this.grpCurrentStatus.Size = new System.Drawing.Size(185, 39);
            this.grpCurrentStatus.Style = Firefly.Box.UI.ControlStyle.Sunken;
            this.grpCurrentStatus.Text = "Current Status";
            this.grpCurrentStatus.BindVisible += new Firefly.Box.UI.Advanced.BindingEventHandler<Firefly.Box.UI.Advanced.BooleanBindingEventArgs>(this.Exp_15_BindVisible);
            // 
            // txtVUserAccessMessage
            // 
            this.txtVUserAccessMessage.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtVUserAccessMessage.AllowFocus = false;
            this.txtVUserAccessMessage.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpCurrentStatus);
            this.txtVUserAccessMessage.ColorScheme = this.clrComponentBuilderWarning;
            this.txtVUserAccessMessage.FontScheme = this.fntReserved2;
            this.txtVUserAccessMessage.Location = new System.Drawing.Point(40, 371);
            this.txtVUserAccessMessage.Name = "txtVUserAccessMessage";
            this.txtVUserAccessMessage.Size = new System.Drawing.Size(163, 13);
            this.txtVUserAccessMessage.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtVUserAccessMessage.BindVisible += new Firefly.Box.UI.Advanced.BindingEventHandler<Firefly.Box.UI.Advanced.BooleanBindingEventArgs>(this.Exp_15_BindVisible);
            this.txtVUserAccessMessage.BindColorScheme += new Firefly.Box.UI.Advanced.BindingEventHandler<Firefly.Box.UI.Advanced.ColorSchemeBindingEventArgs>(this.txtVUserAccessMessage_BindColorScheme);
            this.txtVUserAccessMessage.Data = this._controller.vUserAccessMessage;
            // 
            // txtExp_14
            // 
            this.txtExp_14.ColorScheme = this.clrReserved1;
            this.txtExp_14.FontScheme = this.fntSmallFont;
            this.txtExp_14.Format = "50";
            this.txtExp_14.Location = new System.Drawing.Point(3, 410);
            this.txtExp_14.Name = "txtExp_14";
            this.txtExp_14.Size = new System.Drawing.Size(355, 13);
            this.txtExp_14.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtExp_14.Data = Firefly.Box.UI.Advanced.ControlData.FromText(_controller.Exp_14);
            // 
            // btnVAllowUserAccess
            // 
            this.btnVAllowUserAccess.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpUserAccessControl);
            this.btnVAllowUserAccess.Format = "&\\Allow \\Access";
            this.btnVAllowUserAccess.ImageLocation = "Button";
            this.btnVAllowUserAccess.Location = new System.Drawing.Point(70, 286);
            this.btnVAllowUserAccess.Name = "btnVAllowUserAccess";
            this.btnVAllowUserAccess.RaiseChangeOnClick = true;
            this.btnVAllowUserAccess.Size = new System.Drawing.Size(96, 23);
            this.btnVAllowUserAccess.Click += new Firefly.Box.UI.Advanced.ButtonClickEventHandler(this.btnVAllowUserAccess_Click);
            this.btnVAllowUserAccess.BindVisible += new Firefly.Box.UI.Advanced.BindingEventHandler<Firefly.Box.UI.Advanced.BooleanBindingEventArgs>(this.Exp_15_BindVisible);
            this.btnVAllowUserAccess.Data = this._controller.vAllowUserAccess;
            // 
            // btnVDisAllowUserAccess
            // 
            this.btnVDisAllowUserAccess.BoundTo = new Firefly.Box.UI.ControlBinding(this.grpUserAccessControl);
            this.btnVDisAllowUserAccess.Format = "&Dis-\\Allow \\Access";
            this.btnVDisAllowUserAccess.ImageLocation = "Button";
            this.btnVDisAllowUserAccess.Location = new System.Drawing.Point(70, 319);
            this.btnVDisAllowUserAccess.Name = "btnVDisAllowUserAccess";
            this.btnVDisAllowUserAccess.RaiseChangeOnClick = true;
            this.btnVDisAllowUserAccess.Size = new System.Drawing.Size(96, 22);
            this.btnVDisAllowUserAccess.Click += new Firefly.Box.UI.Advanced.ButtonClickEventHandler(this.btnVDisAllowUserAccess_Click);
            this.btnVDisAllowUserAccess.BindVisible += new Firefly.Box.UI.Advanced.BindingEventHandler<Firefly.Box.UI.Advanced.BooleanBindingEventArgs>(this.Exp_15_BindVisible);
            this.btnVDisAllowUserAccess.Data = this._controller.vDisAllowUserAccess;
            // 
            // btnVSelect
            // 
            this.btnVSelect.FontScheme = this.fntReserved;
            this.btnVSelect.Format = "&Select";
            this.btnVSelect.Location = new System.Drawing.Point(448, 371);
            this.btnVSelect.Name = "btnVSelect";
            this.btnVSelect.Size = new System.Drawing.Size(72, 26);
            this.btnVSelect.Click += new Firefly.Box.UI.Advanced.ButtonClickEventHandler(this.btnVSelect_Click);
            this.btnVSelect.Data = this._controller.vSelect;
            // 
            // btnVExit
            // 
            this.btnVExit.Format = "E&xit";
            this.btnVExit.Location = new System.Drawing.Point(543, 371);
            this.btnVExit.Name = "btnVExit";
            this.btnVExit.Size = new System.Drawing.Size(72, 26);
            this.btnVExit.Click += new Firefly.Box.UI.Advanced.ButtonClickEventHandler(this.btnVExit_Click);
            this.btnVExit.Data = this._controller.vExit;
            // 
            // AccessControlORIGINALSystemAccess
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 427);
            this.ColorScheme = this.clrDefaultHelpWindow;
            this.Controls.Add(this.btnVExit);
            this.Controls.Add(this.btnVSelect);
            this.Controls.Add(this.btnVDisAllowUserAccess);
            this.Controls.Add(this.btnVAllowUserAccess);
            this.Controls.Add(this.txtExp_14);
            this.Controls.Add(this.txtVUserAccessMessage);
            this.Controls.Add(this.grpCurrentStatus);
            this.Controls.Add(this.grpUserAccessControl);
            this.Controls.Add(this.txtApplicationsApplicationDescript);
            this.Controls.Add(this.picMBMPSMac_logoBmp);
            this.Controls.Add(this.grpDescription);
            this.Controls.Add(this.shp);
            this.Controls.Add(this.lblYouAreAuthorisedToAccessTheseApplicationsPleaseChooseOne);
            this.Controls.Add(this.lblWelcomeToMackaysDatabaseSystems);
            this.Controls.Add(this.txtExp_10);
            this.Controls.Add(this.lblApplication);
            this.Controls.Add(this.txtExp_9);
            this.Controls.Add(this.grd);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Name = "AccessControlORIGINALSystemAccess";
            this.Text = "System Access";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.grd.ResumeLayout(false);
            this.gcl.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
