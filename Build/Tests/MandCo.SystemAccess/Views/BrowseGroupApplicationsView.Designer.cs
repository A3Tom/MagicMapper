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
    partial class BrowseGroupApplicationsView
    {
        System.ComponentModel.IContainer components;
        Theme.Colors.DefaultHelpWindow clrDefaultHelpWindow;
        Theme.Controls.Label lblBrowseGroupApplications;
        Theme.Controls.Shape shp;
        Controls.V9CompatibleDefaultTable grd;
        Theme.Controls.GridColumn gcl;
        Theme.Controls.GridColumn gcl1;
        Theme.Controls.Label lblGroup;
        Theme.Controls.Label lblApplication;
        Theme.Controls.TextBox txtGroupApplicationsGroupID;
        Theme.Controls.TextBox txtGroupApplicationsApplication1;
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
            this.txtGroupApplicationsGroupID = new MandCo.Theme.Controls.TextBox();
            this.gcl1 = new MandCo.Theme.Controls.GridColumn();
            this.txtGroupApplicationsApplication1 = new MandCo.Theme.Controls.TextBox();
            this.lblBrowseGroupApplications = new MandCo.Theme.Controls.Label();
            this.shp = new MandCo.Theme.Controls.Shape();
            this.lblGroup = new MandCo.Theme.Controls.Label();
            this.lblApplication = new MandCo.Theme.Controls.Label();
            TabOrderMode = Firefly.Box.UI.TabOrderMode.ManualIgnoringContainerHeirarchy;
            this.grd.SuspendLayout();
            this.gcl.SuspendLayout();
            this.gcl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.AllowUserToResizeColumns = false;
            this.grd.ColorScheme = this.clrDefault3DEffect;
            this.grd.Controls.Add(this.gcl);
            this.grd.Controls.Add(this.gcl1);
            this.grd.HeaderHeight = 18;
            this.grd.Location = new System.Drawing.Point(5, 52);
            this.grd.Name = "grd";
            this.grd.RowHeight = 21;
            this.grd.Size = new System.Drawing.Size(411, 301);
            // 
            // gcl
            // 
            this.gcl.Controls.Add(this.txtGroupApplicationsGroupID);
            this.gcl.Name = "gcl";
            this.gcl.UseTextEndEllipsis = true;
            this.gcl.Width = 161;
            // 
            // txtGroupApplicationsGroupID
            // 
            this.txtGroupApplicationsGroupID.ColorScheme = this.clrDefault3DEffect;
            this.txtGroupApplicationsGroupID.Format = "UX19";
            this.txtGroupApplicationsGroupID.Location = new System.Drawing.Point(3, 1);
            this.txtGroupApplicationsGroupID.Name = "txtGroupApplicationsGroupID";
            this.txtGroupApplicationsGroupID.Size = new System.Drawing.Size(150, 16);
            this.txtGroupApplicationsGroupID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtGroupApplicationsGroupID.TabIndex = 1;
            this.txtGroupApplicationsGroupID.Data = this._controller.GroupApplications.GroupID;
            // 
            // gcl1
            // 
            this.gcl1.Controls.Add(this.txtGroupApplicationsApplication1);
            this.gcl1.Name = "gcl1";
            this.gcl1.UseTextEndEllipsis = true;
            this.gcl1.Width = 235;
            // 
            // txtGroupApplicationsApplication1
            // 
            this.txtGroupApplicationsApplication1.ColorScheme = this.clrDefault3DEffect;
            this.txtGroupApplicationsApplication1.Format = "UX29";
            this.txtGroupApplicationsApplication1.Location = new System.Drawing.Point(2, 1);
            this.txtGroupApplicationsApplication1.Name = "txtGroupApplicationsApplication1";
            this.txtGroupApplicationsApplication1.Size = new System.Drawing.Size(220, 16);
            this.txtGroupApplicationsApplication1.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtGroupApplicationsApplication1.TabIndex = 2;
            this.txtGroupApplicationsApplication1.Data = this._controller.GroupApplications.Application1;
            // 
            // lblBrowseGroupApplications
            // 
            this.lblBrowseGroupApplications.ColorScheme = this.clrDefaultFreeText;
            this.lblBrowseGroupApplications.FontScheme = this.fntUnused;
            this.lblBrowseGroupApplications.Location = new System.Drawing.Point(10, 7);
            this.lblBrowseGroupApplications.Name = "lblBrowseGroupApplications";
            this.lblBrowseGroupApplications.Rtf = "Browse - GroupApplications";
            this.lblBrowseGroupApplications.Size = new System.Drawing.Size(245, 26);
            this.lblBrowseGroupApplications.Text = "Browse - GroupApplications";
            // 
            // shp
            // 
            this.shp.ColorScheme = this.clrDefaultFreeText;
            this.shp.FontScheme = this.fntUnused;
            this.shp.LineWidth = 2;
            this.shp.Location = new System.Drawing.Point(5, 39);
            this.shp.Name = "shp";
            this.shp.Size = new System.Drawing.Size(410, 7);
            this.shp.Square = true;
            this.shp.Style = Firefly.Box.UI.ControlStyle.Sunken;
            // 
            // lblGroup
            // 
            this.lblGroup.BoundTo = new Firefly.Box.UI.ControlBinding(gcl);
            this.lblGroup.ColorScheme = this.clrDefaultHelpWindow;
            this.lblGroup.FontScheme = this.fntTableTitle;
            this.lblGroup.Location = new System.Drawing.Point(10, 55);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Rtf = "Group";
            this.lblGroup.Size = new System.Drawing.Size(34, 13);
            this.lblGroup.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblGroup.Text = "Group";
            // 
            // lblApplication
            // 
            this.lblApplication.BoundTo = new Firefly.Box.UI.ControlBinding(gcl1);
            this.lblApplication.ColorScheme = this.clrDefaultHelpWindow;
            this.lblApplication.FontScheme = this.fntTableTitle;
            this.lblApplication.Location = new System.Drawing.Point(170, 55);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Rtf = "Application";
            this.lblApplication.Size = new System.Drawing.Size(58, 13);
            this.lblApplication.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblApplication.Text = "Application";
            // 
            // BrowseGroupApplicationsView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 359);
            this.ColorScheme = this.clrDefaultHelpWindow;
            this.Controls.Add(this.lblApplication);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.shp);
            this.Controls.Add(this.lblBrowseGroupApplications);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Location = new System.Drawing.Point(0, 2);
            this.Name = "BrowseGroupApplicationsView";
            this.Text = "Browse - GroupApplications";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.grd.ResumeLayout(false);
            this.gcl.ResumeLayout(false);
            this.gcl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
