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
    partial class LookupApplicationsView
    {
        System.ComponentModel.IContainer components;
        Theme.Colors.DefaultHelpWindow clrDefaultHelpWindow;
        Theme.Controls.Label lblLookupApplications;
        Theme.Controls.Shape shp;
        Controls.V9CompatibleDefaultTable grd;
        Theme.Controls.GridColumn gcl;
        Theme.Controls.GridColumn gcl1;
        Theme.Controls.Label lblApplication;
        Theme.Controls.Label lblDescription;
        Theme.Controls.TextBox txtApplications1Application1;
        Theme.Controls.TextBox txtApplications1ApplicationDescript;
        Theme.Controls.Button btnSelect;
        Theme.Controls.Button btnCancel;
        Theme.Colors.Default3DEffect clrDefault3DEffect;
        Theme.Fonts.Unused1 fntUnused;
        Theme.Colors.DefaultFreeText clrDefaultFreeText;
        Theme.Fonts.Reserved35 fntReserved;
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
            this.fntReserved = new MandCo.Theme.Fonts.Reserved35();
            this.grd = new MandCo.SystemAccess.Views.Controls.V9CompatibleDefaultTable();
            this.gcl = new MandCo.Theme.Controls.GridColumn();
            this.txtApplications1Application1 = new MandCo.Theme.Controls.TextBox();
            this.gcl1 = new MandCo.Theme.Controls.GridColumn();
            this.txtApplications1ApplicationDescript = new MandCo.Theme.Controls.TextBox();
            this.lblLookupApplications = new MandCo.Theme.Controls.Label();
            this.shp = new MandCo.Theme.Controls.Shape();
            this.lblApplication = new MandCo.Theme.Controls.Label();
            this.lblDescription = new MandCo.Theme.Controls.Label();
            this.btnSelect = new MandCo.Theme.Controls.Button();
            this.btnCancel = new MandCo.Theme.Controls.Button();
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
            this.grd.HeaderHeight = 23;
            this.grd.Location = new System.Drawing.Point(5, 52);
            this.grd.Name = "grd";
            this.grd.RowHeight = 21;
            this.grd.Size = new System.Drawing.Size(528, 275);
            // 
            // gcl
            // 
            this.gcl.Controls.Add(this.txtApplications1Application1);
            this.gcl.Name = "gcl";
            this.gcl.UseTextEndEllipsis = true;
            this.gcl.Width = 196;
            // 
            // txtApplications1Application1
            // 
            this.txtApplications1Application1.Format = "UX29";
            this.txtApplications1Application1.Location = new System.Drawing.Point(2, 1);
            this.txtApplications1Application1.Name = "txtApplications1Application1";
            this.txtApplications1Application1.Size = new System.Drawing.Size(187, 15);
            this.txtApplications1Application1.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtApplications1Application1.TabIndex = 1;
            this.txtApplications1Application1.Data = this._controller.Applications1.Application1;
            // 
            // gcl1
            // 
            this.gcl1.Controls.Add(this.txtApplications1ApplicationDescript);
            this.gcl1.Name = "gcl1";
            this.gcl1.UseTextEndEllipsis = true;
            this.gcl1.Width = 316;
            // 
            // txtApplications1ApplicationDescript
            // 
            this.txtApplications1ApplicationDescript.Location = new System.Drawing.Point(1, 1);
            this.txtApplications1ApplicationDescript.Name = "txtApplications1ApplicationDescript";
            this.txtApplications1ApplicationDescript.Size = new System.Drawing.Size(307, 15);
            this.txtApplications1ApplicationDescript.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtApplications1ApplicationDescript.TabIndex = 2;
            this.txtApplications1ApplicationDescript.Data = this._controller.Applications1.ApplicationDescript;
            // 
            // lblLookupApplications
            // 
            this.lblLookupApplications.ColorScheme = this.clrDefaultFreeText;
            this.lblLookupApplications.FontScheme = this.fntUnused;
            this.lblLookupApplications.Location = new System.Drawing.Point(10, 7);
            this.lblLookupApplications.Name = "lblLookupApplications";
            this.lblLookupApplications.Rtf = "Lookup - Applications";
            this.lblLookupApplications.Size = new System.Drawing.Size(200, 26);
            this.lblLookupApplications.Text = "Lookup - Applications";
            // 
            // shp
            // 
            this.shp.ColorScheme = this.clrDefaultFreeText;
            this.shp.LineWidth = 2;
            this.shp.Location = new System.Drawing.Point(5, 39);
            this.shp.Name = "shp";
            this.shp.Size = new System.Drawing.Size(525, 7);
            this.shp.Square = true;
            this.shp.Style = Firefly.Box.UI.ControlStyle.Sunken;
            // 
            // lblApplication
            // 
            this.lblApplication.BoundTo = new Firefly.Box.UI.ControlBinding(gcl);
            this.lblApplication.ColorScheme = this.clrDefaultHelpWindow;
            this.lblApplication.Location = new System.Drawing.Point(9, 55);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Rtf = "Application";
            this.lblApplication.Size = new System.Drawing.Size(57, 17);
            this.lblApplication.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblApplication.Text = "Application";
            // 
            // lblDescription
            // 
            this.lblDescription.BoundTo = new Firefly.Box.UI.ControlBinding(gcl1);
            this.lblDescription.ColorScheme = this.clrDefaultHelpWindow;
            this.lblDescription.Location = new System.Drawing.Point(204, 55);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Rtf = "Description";
            this.lblDescription.Size = new System.Drawing.Size(99, 17);
            this.lblDescription.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblDescription.Text = "Description";
            // 
            // btnSelect
            // 
            this.btnSelect.FontScheme = this.fntReserved;
            this.btnSelect.Format = "&Select";
            this.btnSelect.Location = new System.Drawing.Point(150, 330);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.RaiseClickBeforeFocusChange = true;
            this.btnSelect.Size = new System.Drawing.Size(95, 26);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Click += new Firefly.Box.UI.Advanced.ButtonClickEventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Format = "&Cancel";
            this.btnCancel.Location = new System.Drawing.Point(270, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RaiseClickBeforeFocusChange = true;
            this.btnCancel.Size = new System.Drawing.Size(95, 26);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Click += new Firefly.Box.UI.Advanced.ButtonClickEventHandler(this.btnCancel_Click);
            // 
            // LookupApplicationsView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 359);
            this.ColorScheme = this.clrDefaultHelpWindow;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblApplication);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.shp);
            this.Controls.Add(this.lblLookupApplications);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Location = new System.Drawing.Point(83, 2);
            this.Name = "LookupApplicationsView";
            this.Text = "Lookup - Applications";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.grd.ResumeLayout(false);
            this.gcl.ResumeLayout(false);
            this.gcl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
