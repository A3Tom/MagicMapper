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
    partial class AttachGroupToApplicationsApplications
    {
        System.ComponentModel.IContainer components;
        Theme.Colors.DefaultHelpWindow clrDefaultHelpWindow;
        Theme.Controls.GroupBox grpApplications;
        Controls.V9CompatibleDefaultTable grd;
        Theme.Controls.GridColumn gcl;
        Theme.Controls.Label lblApplication;
        Theme.Controls.TextBox txtGroupApplicationsApplication1;
        Theme.Colors.DefaultHyperlink clrDefaultHyperlink;
        Theme.Colors.Default3DEffect clrDefault3DEffect;
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
            this.clrDefaultHyperlink = new MandCo.Theme.Colors.DefaultHyperlink();
            this.clrDefault3DEffect = new MandCo.Theme.Colors.Default3DEffect();
            this.grd = new MandCo.SystemAccess.Views.Controls.V9CompatibleDefaultTable();
            this.gcl = new MandCo.Theme.Controls.GridColumn();
            this.txtGroupApplicationsApplication1 = new MandCo.Theme.Controls.TextBox();
            this.grpApplications = new MandCo.Theme.Controls.GroupBox();
            this.lblApplication = new MandCo.Theme.Controls.Label();
            TabOrderMode = Firefly.Box.UI.TabOrderMode.ManualIgnoringContainerHeirarchy;
            this.grd.SuspendLayout();
            this.gcl.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.AllowUserToResizeColumns = false;
            this.grd.Controls.Add(this.gcl);
            this.grd.Location = new System.Drawing.Point(10, 26);
            this.grd.Name = "grd";
            this.grd.RowHeight = 23;
            this.grd.Size = new System.Drawing.Size(244, 262);
            // 
            // gcl
            // 
            this.gcl.Controls.Add(this.txtGroupApplicationsApplication1);
            this.gcl.Name = "gcl";
            this.gcl.UseTextEndEllipsis = true;
            this.gcl.Width = 229;
            // 
            // txtGroupApplicationsApplication1
            // 
            this.txtGroupApplicationsApplication1.ColorScheme = this.clrDefault3DEffect;
            this.txtGroupApplicationsApplication1.Format = "UX29";
            this.txtGroupApplicationsApplication1.Location = new System.Drawing.Point(2, 1);
            this.txtGroupApplicationsApplication1.Name = "txtGroupApplicationsApplication1";
            this.txtGroupApplicationsApplication1.Size = new System.Drawing.Size(219, 16);
            this.txtGroupApplicationsApplication1.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtGroupApplicationsApplication1.TabIndex = 1;
            this.txtGroupApplicationsApplication1.Expand += new System.Action(txtGroupApplicationsApplication1_Expand);
            this.txtGroupApplicationsApplication1.Data = this._controller.GroupApplications.Application1;
            // 
            // grpApplications
            // 
            this.grpApplications.ColorScheme = this.clrDefaultHyperlink;
            this.grpApplications.Name = "grpApplications";
            this.grpApplications.Size = new System.Drawing.Size(260, 299);
            this.grpApplications.Text = "Applications";
            // 
            // lblApplication
            // 
            this.lblApplication.BoundTo = new Firefly.Box.UI.ControlBinding(gcl);
            this.lblApplication.ColorScheme = this.clrDefaultHelpWindow;
            this.lblApplication.Location = new System.Drawing.Point(14, 29);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Rtf = "Application";
            this.lblApplication.Size = new System.Drawing.Size(219, 13);
            this.lblApplication.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblApplication.Text = "Application";
            // 
            // AttachGroupToApplicationsApplications
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Border = Firefly.Box.UI.ControlBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(260, 309);
            this.ColorScheme = this.clrDefaultHelpWindow;
            this.Controls.Add(this.lblApplication);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.grpApplications);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Location = new System.Drawing.Point(203, 70);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttachGroupToApplicationsApplications";
            this.SystemMenu = false;
            this.Text = "Applications";
            this.TitleBar = false;
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.grd.ResumeLayout(false);
            this.gcl.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
