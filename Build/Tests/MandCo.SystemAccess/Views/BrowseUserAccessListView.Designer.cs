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
    partial class BrowseUserAccessListView
    {
        System.ComponentModel.IContainer components;
        Theme.Colors.DefaultHelpWindow clrDefaultHelpWindow;
        Theme.Controls.Label lblBrowseUserAccessList;
        Theme.Controls.Line lin;
        Controls.V9CompatibleDefaultTable grd;
        Theme.Controls.GridColumn gcl;
        Theme.Controls.Label lblApplication;
        Controls.Group_txt txtUserAccessListApplication1;
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
            this.txtUserAccessListApplication1 = new MandCo.SystemAccess.Views.Controls.Group_txt();
            this.lblBrowseUserAccessList = new MandCo.Theme.Controls.Label();
            this.lin = new MandCo.Theme.Controls.Line();
            this.lblApplication = new MandCo.Theme.Controls.Label();
            TabOrderMode = Firefly.Box.UI.TabOrderMode.ManualIgnoringContainerHeirarchy;
            this.grd.SuspendLayout();
            this.gcl.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.AllowUserToResizeColumns = false;
            this.grd.ColorScheme = this.clrDefault3DEffect;
            this.grd.Controls.Add(this.gcl);
            this.grd.HeaderHeight = 18;
            this.grd.Location = new System.Drawing.Point(5, 65);
            this.grd.Name = "grd";
            this.grd.RowHeight = 20;
            this.grd.Size = new System.Drawing.Size(248, 257);
            // 
            // gcl
            // 
            this.gcl.Controls.Add(this.txtUserAccessListApplication1);
            this.gcl.Name = "gcl";
            this.gcl.UseTextEndEllipsis = true;
            this.gcl.Width = 232;
            // 
            // txtUserAccessListApplication1
            // 
            this.txtUserAccessListApplication1.Location = new System.Drawing.Point(3, 1);
            this.txtUserAccessListApplication1.Name = "txtUserAccessListApplication1";
            this.txtUserAccessListApplication1.Size = new System.Drawing.Size(216, 13);
            this.txtUserAccessListApplication1.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUserAccessListApplication1.TabIndex = 1;
            this.txtUserAccessListApplication1.Data = this._controller.UserAccessList.Application1;
            // 
            // lblBrowseUserAccessList
            // 
            this.lblBrowseUserAccessList.ColorScheme = this.clrDefaultFreeText;
            this.lblBrowseUserAccessList.FontScheme = this.fntUnused;
            this.lblBrowseUserAccessList.Location = new System.Drawing.Point(10, 13);
            this.lblBrowseUserAccessList.Name = "lblBrowseUserAccessList";
            this.lblBrowseUserAccessList.Rtf = "Browse - UserAccessList";
            this.lblBrowseUserAccessList.Size = new System.Drawing.Size(218, 26);
            this.lblBrowseUserAccessList.Text = "Browse - UserAccessList";
            // 
            // lin
            // 
            this.lin.BoundTo = new Firefly.Box.UI.ControlBinding(this.lblBrowseUserAccessList);
            this.lin.ColorScheme = this.clrDefaultFreeText;
            this.lin.End = new System.Drawing.Point(250, 46);
            this.lin.Name = "lin";
            this.lin.Start = new System.Drawing.Point(5, 46);
            this.lin.Style = Firefly.Box.UI.ControlStyle.Sunken;
            // 
            // lblApplication
            // 
            this.lblApplication.BoundTo = new Firefly.Box.UI.ControlBinding(gcl);
            this.lblApplication.ColorScheme = this.clrDefaultHelpWindow;
            this.lblApplication.FontScheme = this.fntTableTitle;
            this.lblApplication.Location = new System.Drawing.Point(10, 68);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Rtf = "Application";
            this.lblApplication.Size = new System.Drawing.Size(58, 13);
            this.lblApplication.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblApplication.Text = "Application";
            // 
            // BrowseUserAccessListView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 325);
            this.ColorScheme = this.clrDefaultHelpWindow;
            this.Controls.Add(this.lblApplication);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.lin);
            this.Controls.Add(this.lblBrowseUserAccessList);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "BrowseUserAccessListView";
            this.Text = "Browse - UserAccessList";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.grd.ResumeLayout(false);
            this.gcl.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
