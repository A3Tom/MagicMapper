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
    partial class MaintApplicationsApplications
    {
        System.ComponentModel.IContainer components;
        Theme.Colors.DefaultHelpWindow clrDefaultHelpWindow;
        Theme.Controls.Label lblMaintenanceApplication;
        Theme.Controls.Shape shp;
        Controls.V9CompatibleDefaultTable grd;
        Theme.Controls.GridColumn gcl;
        Theme.Controls.GridColumn gclAppID;
        Theme.Controls.GridColumn gcl1;
        Theme.Controls.Label lblApplicationName;
        Theme.Controls.Label lblApplicationDescription;
        Theme.Controls.TextBox txtApplications1Application1;
        Theme.Controls.TextBox txtApplications1ApplicationID;
        Theme.Controls.TextBox txtApplications1ApplicationDescript;
        Theme.Colors.Default3DEffect clrDefault3DEffect;
        Theme.Fonts.Unused1 fntUnused;
        Theme.Colors.DefaultFreeText clrDefaultFreeText;
        Theme.Fonts.TableTitle fntTableTitle;
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
            this.clrDefault3DEffect = new MandCo.Theme.Colors.Default3DEffect();
            this.fntUnused = new MandCo.Theme.Fonts.Unused1();
            this.clrDefaultFreeText = new MandCo.Theme.Colors.DefaultFreeText();
            this.fntTableTitle = new MandCo.Theme.Fonts.TableTitle();
            this.grd = new MandCo.SystemAccess.Views.Controls.V9CompatibleDefaultTable();
            this.gcl = new MandCo.Theme.Controls.GridColumn();
            this.txtApplications1Application1 = new MandCo.Theme.Controls.TextBox();
            this.gclAppID = new MandCo.Theme.Controls.GridColumn();
            this.txtApplications1ApplicationID = new MandCo.Theme.Controls.TextBox();
            this.gcl1 = new MandCo.Theme.Controls.GridColumn();
            this.txtApplications1ApplicationDescript = new MandCo.Theme.Controls.TextBox();
            this.lblMaintenanceApplication = new MandCo.Theme.Controls.Label();
            this.shp = new MandCo.Theme.Controls.Shape();
            this.lblApplicationName = new MandCo.Theme.Controls.Label();
            this.lblApplicationDescription = new MandCo.Theme.Controls.Label();
            TabOrderMode = Firefly.Box.UI.TabOrderMode.ManualIgnoringContainerHeirarchy;
            this.grd.SuspendLayout();
            this.gcl.SuspendLayout();
            this.gclAppID.SuspendLayout();
            this.gcl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.AllowUserToResizeColumns = false;
            this.grd.ColorScheme = this.clrDefault3DEffect;
            this.grd.Controls.Add(this.gcl);
            this.grd.Controls.Add(this.gclAppID);
            this.grd.Controls.Add(this.gcl1);
            this.grd.Location = new System.Drawing.Point(5, 52);
            this.grd.Name = "grd";
            this.grd.RowHeight = 21;
            this.grd.Size = new System.Drawing.Size(605, 301);
            // 
            // gcl
            // 
            this.gcl.Controls.Add(this.txtApplications1Application1);
            this.gcl.Name = "gcl";
            this.gcl.UseTextEndEllipsis = true;
            this.gcl.Width = 231;
            // 
            // txtApplications1Application1
            // 
            this.txtApplications1Application1.ColorScheme = this.clrDefault3DEffect;
            this.txtApplications1Application1.Format = "UX29";
            this.txtApplications1Application1.Location = new System.Drawing.Point(3, 1);
            this.txtApplications1Application1.Name = "txtApplications1Application1";
            this.txtApplications1Application1.ReadOnly = true;
            this.txtApplications1Application1.Size = new System.Drawing.Size(220, 16);
            this.txtApplications1Application1.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtApplications1Application1.TabIndex = 1;
            this.txtApplications1Application1.BindReadOnly += new Firefly.Box.UI.Advanced.BindingEventHandler<Firefly.Box.UI.Advanced.BooleanBindingEventArgs>(this.txtApplications1Application1_BindReadOnly);
            this.txtApplications1Application1.Data = this._controller.Applications1.Application1;
            // 
            // gclAppID
            // 
            this.gclAppID.AllowSort = true;
            this.gclAppID.Controls.Add(this.txtApplications1ApplicationID);
            this.gclAppID.Name = "gclAppID";
            this.gclAppID.Text = "App ID";
            this.gclAppID.UseTextEndEllipsis = true;
            this.gclAppID.Width = 48;
            // 
            // txtApplications1ApplicationID
            // 
            this.txtApplications1ApplicationID.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtApplications1ApplicationID.Location = new System.Drawing.Point(12, 1);
            this.txtApplications1ApplicationID.Name = "txtApplications1ApplicationID";
            this.txtApplications1ApplicationID.Size = new System.Drawing.Size(18, 16);
            this.txtApplications1ApplicationID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtApplications1ApplicationID.TabIndex = 3;
            this.txtApplications1ApplicationID.Tag = "Application ID";
            this.txtApplications1ApplicationID.Data = this._controller.Applications1.ApplicationID;
            // 
            // gcl1
            // 
            this.gcl1.Controls.Add(this.txtApplications1ApplicationDescript);
            this.gcl1.Name = "gcl1";
            this.gcl1.UseTextEndEllipsis = true;
            this.gcl1.Width = 308;
            // 
            // txtApplications1ApplicationDescript
            // 
            this.txtApplications1ApplicationDescript.ColorScheme = this.clrDefault3DEffect;
            this.txtApplications1ApplicationDescript.Location = new System.Drawing.Point(7, 1);
            this.txtApplications1ApplicationDescript.Name = "txtApplications1ApplicationDescript";
            this.txtApplications1ApplicationDescript.Size = new System.Drawing.Size(290, 16);
            this.txtApplications1ApplicationDescript.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtApplications1ApplicationDescript.TabIndex = 4;
            this.txtApplications1ApplicationDescript.Data = this._controller.Applications1.ApplicationDescript;
            // 
            // lblMaintenanceApplication
            // 
            this.lblMaintenanceApplication.ColorScheme = this.clrDefaultFreeText;
            this.lblMaintenanceApplication.FontScheme = this.fntUnused;
            this.lblMaintenanceApplication.Location = new System.Drawing.Point(10, 7);
            this.lblMaintenanceApplication.Name = "lblMaintenanceApplication";
            this.lblMaintenanceApplication.Rtf = "Maintenance - Application";
            this.lblMaintenanceApplication.Size = new System.Drawing.Size(340, 26);
            this.lblMaintenanceApplication.Text = "Maintenance - Application";
            // 
            // shp
            // 
            this.shp.ColorScheme = this.clrDefaultFreeText;
            this.shp.FontScheme = this.fntUnused;
            this.shp.LineWidth = 2;
            this.shp.Location = new System.Drawing.Point(5, 39);
            this.shp.Name = "shp";
            this.shp.Size = new System.Drawing.Size(600, 7);
            this.shp.Square = true;
            this.shp.Style = Firefly.Box.UI.ControlStyle.Sunken;
            // 
            // lblApplicationName
            // 
            this.lblApplicationName.BoundTo = new Firefly.Box.UI.ControlBinding(gcl);
            this.lblApplicationName.ColorScheme = this.clrDefaultHelpWindow;
            this.lblApplicationName.FontScheme = this.fntTableTitle;
            this.lblApplicationName.Location = new System.Drawing.Point(15, 57);
            this.lblApplicationName.Name = "lblApplicationName";
            this.lblApplicationName.Rtf = "Application Name";
            this.lblApplicationName.Size = new System.Drawing.Size(135, 13);
            this.lblApplicationName.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblApplicationName.Text = "Application Name";
            // 
            // lblApplicationDescription
            // 
            this.lblApplicationDescription.BoundTo = new Firefly.Box.UI.ControlBinding(gcl1);
            this.lblApplicationDescription.ColorScheme = this.clrDefaultHelpWindow;
            this.lblApplicationDescription.FontScheme = this.fntTableTitle;
            this.lblApplicationDescription.Location = new System.Drawing.Point(293, 57);
            this.lblApplicationDescription.Name = "lblApplicationDescription";
            this.lblApplicationDescription.Rtf = "Application Description";
            this.lblApplicationDescription.Size = new System.Drawing.Size(160, 13);
            this.lblApplicationDescription.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblApplicationDescription.Text = "Application Description";
            // 
            // MaintApplicationsApplications
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 362);
            this.ColorScheme = this.clrDefaultHelpWindow;
            this.Controls.Add(this.lblApplicationDescription);
            this.Controls.Add(this.lblApplicationName);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.shp);
            this.Controls.Add(this.lblMaintenanceApplication);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Location = new System.Drawing.Point(-1, 0);
            this.Name = "MaintApplicationsApplications";
            this.Text = "Applications";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.grd.ResumeLayout(false);
            this.gcl.ResumeLayout(false);
            this.gclAppID.ResumeLayout(false);
            this.gcl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
