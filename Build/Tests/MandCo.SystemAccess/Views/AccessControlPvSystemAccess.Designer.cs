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
    partial class AccessControlPvSystemAccess
    {
        System.ComponentModel.IContainer components;
        Controls.V9CompatibleDefaultTable grd;
        Theme.Controls.GridColumn gcl;
        Theme.Controls.TextBox txtExp_1;
        Theme.Controls.Label lblApplication;
        Theme.Controls.TextBox txtExp_2;
        Controls.Group_txt txtUserAccessListApplication1;
        Theme.Controls.Label lblWelcomeToMackaysDatabaseSystems;
        Theme.Controls.Label lblYouAreAuthorisedToAccessTheseApplicationsPleaseChooseOne;
        Theme.Controls.Shape shp;
        Theme.Controls.GroupBox grpDescription;
        Theme.Controls.PictureBox picMBMPSMac_logoBmp;
        Theme.Controls.TextBox txtApplicationsApplicationDescript;
        Theme.Controls.TextBox txtExp_6;
        Theme.Controls.Button btnVSelect;
        Theme.Controls.Button btnVExit;
        Theme.Fonts.Unused fntUnused;
        Theme.Colors.Reserved30 clrReserved;
        Theme.Fonts.Reserved35 fntReserved;
        Theme.Colors.DefaultHelpWindow clrDefaultHelpWindow;
        Theme.Fonts.Reserved36 fntReserved1;
        Theme.Colors.DefaultHyperlink clrDefaultHyperlink;
        Theme.Fonts.Reserved34 fntReserved2;
        Theme.Fonts.MackaysUserDefined2 fntMackaysUserDefined;
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
            this.fntUnused = new MandCo.Theme.Fonts.Unused();
            this.clrReserved = new MandCo.Theme.Colors.Reserved30();
            this.fntReserved = new MandCo.Theme.Fonts.Reserved35();
            this.clrDefaultHelpWindow = new MandCo.Theme.Colors.DefaultHelpWindow();
            this.fntReserved1 = new MandCo.Theme.Fonts.Reserved36();
            this.clrDefaultHyperlink = new MandCo.Theme.Colors.DefaultHyperlink();
            this.fntReserved2 = new MandCo.Theme.Fonts.Reserved34();
            this.fntMackaysUserDefined = new MandCo.Theme.Fonts.MackaysUserDefined2();
            this.clrReserved1 = new MandCo.Theme.Colors.Reserved19();
            this.grd = new MandCo.SystemAccess.Views.Controls.V9CompatibleDefaultTable();
            this.gcl = new MandCo.Theme.Controls.GridColumn();
            this.txtUserAccessListApplication1 = new MandCo.SystemAccess.Views.Controls.Group_txt();
            this.txtExp_1 = new MandCo.Theme.Controls.TextBox();
            this.lblApplication = new MandCo.Theme.Controls.Label();
            this.txtExp_2 = new MandCo.Theme.Controls.TextBox();
            this.lblWelcomeToMackaysDatabaseSystems = new MandCo.Theme.Controls.Label();
            this.lblYouAreAuthorisedToAccessTheseApplicationsPleaseChooseOne = new MandCo.Theme.Controls.Label();
            this.shp = new MandCo.Theme.Controls.Shape();
            this.grpDescription = new MandCo.Theme.Controls.GroupBox();
            this.picMBMPSMac_logoBmp = new MandCo.Theme.Controls.PictureBox();
            this.txtApplicationsApplicationDescript = new MandCo.Theme.Controls.TextBox();
            this.txtExp_6 = new MandCo.Theme.Controls.TextBox();
            this.btnVSelect = new MandCo.Theme.Controls.Button();
            this.btnVExit = new MandCo.Theme.Controls.Button();
            TabOrderMode = Firefly.Box.UI.TabOrderMode.ManualIgnoringContainerHeirarchy;
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
            this.grd.Style = Firefly.Box.UI.ControlStyle.Raised;
            this.grd.UseVisualStyles = true;
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
            this.txtUserAccessListApplication1.FontScheme = this.fntReserved1;
            this.txtUserAccessListApplication1.Location = new System.Drawing.Point(3, 1);
            this.txtUserAccessListApplication1.Name = "txtUserAccessListApplication1";
            this.txtUserAccessListApplication1.Size = new System.Drawing.Size(163, 13);
            this.txtUserAccessListApplication1.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUserAccessListApplication1.TabIndex = 3;
            this.txtUserAccessListApplication1.Data = this._controller.UserAccessList.Application1;
            // 
            // txtExp_1
            // 
            this.txtExp_1.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtExp_1.Border = Firefly.Box.UI.ControlBorderStyle.Thin;
            this.txtExp_1.ColorScheme = this.clrReserved;
            this.txtExp_1.FontScheme = this.fntUnused;
            this.txtExp_1.Format = "30";
            this.txtExp_1.Location = new System.Drawing.Point(445, 13);
            this.txtExp_1.Name = "txtExp_1";
            this.txtExp_1.Size = new System.Drawing.Size(173, 20);
            this.txtExp_1.Style = Firefly.Box.UI.ControlStyle.Sunken;
            this.txtExp_1.TabIndex = 8;
            this.txtExp_1.Data = Firefly.Box.UI.Advanced.ControlData.FromText(_controller.Exp_1);
            // 
            // lblApplication
            // 
            this.lblApplication.BoundTo = new Firefly.Box.UI.ControlBinding(gcl);
            this.lblApplication.ColorScheme = this.clrDefaultHelpWindow;
            this.lblApplication.FontScheme = this.fntReserved;
            this.lblApplication.Location = new System.Drawing.Point(249, 16);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Rtf = "Application";
            this.lblApplication.Size = new System.Drawing.Size(95, 13);
            this.lblApplication.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblApplication.Text = "Application";
            // 
            // txtExp_2
            // 
            this.txtExp_2.ColorScheme = this.clrDefaultHelpWindow;
            this.txtExp_2.FontScheme = this.fntReserved1;
            this.txtExp_2.Format = "30";
            this.txtExp_2.Location = new System.Drawing.Point(5, 20);
            this.txtExp_2.Name = "txtExp_2";
            this.txtExp_2.Size = new System.Drawing.Size(230, 19);
            this.txtExp_2.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtExp_2.TabIndex = 5;
            this.txtExp_2.Data = Firefly.Box.UI.Advanced.ControlData.FromText(_controller.Exp_2);
            // 
            // lblWelcomeToMackaysDatabaseSystems
            // 
            this.lblWelcomeToMackaysDatabaseSystems.ColorScheme = this.clrDefaultHelpWindow;
            this.lblWelcomeToMackaysDatabaseSystems.FontScheme = this.fntReserved1;
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
            this.lblYouAreAuthorisedToAccessTheseApplicationsPleaseChooseOne.ColorScheme = this.clrDefaultHelpWindow;
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
            this.picMBMPSMac_logoBmp.TabIndex = 6;
            // 
            // txtApplicationsApplicationDescript
            // 
            this.txtApplicationsApplicationDescript.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.txtApplicationsApplicationDescript.AllowFocus = false;
            this.txtApplicationsApplicationDescript.ColorScheme = this.clrReserved;
            this.txtApplicationsApplicationDescript.FontScheme = this.fntReserved2;
            this.txtApplicationsApplicationDescript.Location = new System.Drawing.Point(450, 169);
            this.txtApplicationsApplicationDescript.Multiline = true;
            this.txtApplicationsApplicationDescript.Name = "txtApplicationsApplicationDescript";
            this.txtApplicationsApplicationDescript.Size = new System.Drawing.Size(163, 98);
            this.txtApplicationsApplicationDescript.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtApplicationsApplicationDescript.TabIndex = 4;
            this.txtApplicationsApplicationDescript.Data = this._controller.Applications.ApplicationDescript;
            // 
            // txtExp_6
            // 
            this.txtExp_6.ColorScheme = this.clrReserved1;
            this.txtExp_6.FontScheme = this.fntMackaysUserDefined;
            this.txtExp_6.Format = "50";
            this.txtExp_6.Location = new System.Drawing.Point(3, 410);
            this.txtExp_6.Name = "txtExp_6";
            this.txtExp_6.Size = new System.Drawing.Size(355, 13);
            this.txtExp_6.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtExp_6.TabIndex = 7;
            this.txtExp_6.Data = Firefly.Box.UI.Advanced.ControlData.FromText(_controller.Exp_6);
            // 
            // btnVSelect
            // 
            this.btnVSelect.FontScheme = this.fntReserved;
            this.btnVSelect.Format = "Select";
            this.btnVSelect.Location = new System.Drawing.Point(448, 371);
            this.btnVSelect.Name = "btnVSelect";
            this.btnVSelect.Size = new System.Drawing.Size(72, 26);
            this.btnVSelect.TabIndex = 1;
            this.btnVSelect.Click += new Firefly.Box.UI.Advanced.ButtonClickEventHandler(this.btnVSelect_Click);
            this.btnVSelect.Data = this._controller.vSelect;
            // 
            // btnVExit
            // 
            this.btnVExit.Format = "Exit";
            this.btnVExit.Location = new System.Drawing.Point(543, 371);
            this.btnVExit.Name = "btnVExit";
            this.btnVExit.Size = new System.Drawing.Size(72, 26);
            this.btnVExit.TabIndex = 2;
            this.btnVExit.Click += new Firefly.Box.UI.Advanced.ButtonClickEventHandler(this.btnVExit_Click);
            this.btnVExit.Data = this._controller.vExit;
            // 
            // AccessControlPvSystemAccess
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 427);
            this.Controls.Add(this.btnVExit);
            this.Controls.Add(this.btnVSelect);
            this.Controls.Add(this.txtExp_6);
            this.Controls.Add(this.txtApplicationsApplicationDescript);
            this.Controls.Add(this.picMBMPSMac_logoBmp);
            this.Controls.Add(this.grpDescription);
            this.Controls.Add(this.shp);
            this.Controls.Add(this.lblYouAreAuthorisedToAccessTheseApplicationsPleaseChooseOne);
            this.Controls.Add(this.lblWelcomeToMackaysDatabaseSystems);
            this.Controls.Add(this.txtExp_2);
            this.Controls.Add(this.lblApplication);
            this.Controls.Add(this.txtExp_1);
            this.Controls.Add(this.grd);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Name = "AccessControlPvSystemAccess";
            this.Text = "System Access";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.grd.ResumeLayout(false);
            this.gcl.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
