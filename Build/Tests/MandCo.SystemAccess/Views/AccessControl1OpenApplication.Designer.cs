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
    partial class AccessControl1OpenApplication
    {
        System.ComponentModel.IContainer components;
        Theme.Controls.TextBox txt_parentApplicationsApplicationNumber;
        Theme.Controls.Grid grd;
        Theme.Controls.GridColumn gclVCounter;
        Theme.Controls.GridColumn gcl;
        Theme.Controls.GridColumn gcl1;
        Theme.Controls.GridColumn gcl2;
        Theme.Controls.GridColumn gcl3;
        Theme.Controls.GridColumn gcl4;
        Theme.Controls.GridColumn gcl5;
        Theme.Controls.GridColumn gcl6;
        Controls.Group_txt txtVCounter;
        Theme.Controls.TextBox txtExp_1;
        Theme.Controls.TextBox txtExp_3;
        Theme.Controls.TextBox txtExp_4;
        Theme.Controls.TextBox txtExp_5;
        Theme.Controls.TextBox txtExp_6;
        Theme.Controls.TextBox txtExp_7;
        Theme.Controls.TextBox txtExp_8;
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
            this.grd = new MandCo.Theme.Controls.Grid();
            this.gclVCounter = new MandCo.Theme.Controls.GridColumn();
            this.txtVCounter = new MandCo.SystemAccess.Views.Controls.Group_txt();
            this.gcl = new MandCo.Theme.Controls.GridColumn();
            this.txtExp_1 = new MandCo.Theme.Controls.TextBox();
            this.gcl1 = new MandCo.Theme.Controls.GridColumn();
            this.txtExp_3 = new MandCo.Theme.Controls.TextBox();
            this.gcl2 = new MandCo.Theme.Controls.GridColumn();
            this.txtExp_4 = new MandCo.Theme.Controls.TextBox();
            this.gcl3 = new MandCo.Theme.Controls.GridColumn();
            this.txtExp_5 = new MandCo.Theme.Controls.TextBox();
            this.gcl4 = new MandCo.Theme.Controls.GridColumn();
            this.txtExp_6 = new MandCo.Theme.Controls.TextBox();
            this.gcl5 = new MandCo.Theme.Controls.GridColumn();
            this.txtExp_7 = new MandCo.Theme.Controls.TextBox();
            this.gcl6 = new MandCo.Theme.Controls.GridColumn();
            this.txtExp_8 = new MandCo.Theme.Controls.TextBox();
            this.txt_parentApplicationsApplicationNumber = new MandCo.Theme.Controls.TextBox();
            this.grd.SuspendLayout();
            this.gclVCounter.SuspendLayout();
            this.gcl.SuspendLayout();
            this.gcl1.SuspendLayout();
            this.gcl2.SuspendLayout();
            this.gcl3.SuspendLayout();
            this.gcl4.SuspendLayout();
            this.gcl5.SuspendLayout();
            this.gcl6.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.grd.AllowMultiSelect = false;
            this.grd.Controls.Add(this.gclVCounter);
            this.grd.Controls.Add(this.gcl);
            this.grd.Controls.Add(this.gcl1);
            this.grd.Controls.Add(this.gcl2);
            this.grd.Controls.Add(this.gcl3);
            this.grd.Controls.Add(this.gcl4);
            this.grd.Controls.Add(this.gcl5);
            this.grd.Controls.Add(this.gcl6);
            this.grd.Location = new System.Drawing.Point(10, 39);
            this.grd.Name = "grd";
            this.grd.RowHeight = 21;
            this.grd.Size = new System.Drawing.Size(363, 283);
            // 
            // gclVCounter
            // 
            this.gclVCounter.Controls.Add(this.txtVCounter);
            this.gclVCounter.Name = "gclVCounter";
            this.gclVCounter.Text = "v:Counter";
            this.gclVCounter.UseTextEndEllipsis = true;
            this.gclVCounter.Width = 51;
            // 
            // txtVCounter
            // 
            this.txtVCounter.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtVCounter.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txtVCounter.Location = new System.Drawing.Point(3, 2);
            this.txtVCounter.Name = "txtVCounter";
            this.txtVCounter.Size = new System.Drawing.Size(28, 17);
            this.txtVCounter.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtVCounter.Tag = "v:Counter";
            this.txtVCounter.Data = this._controller.vCounter;
            // 
            // gcl
            // 
            this.gcl.Controls.Add(this.txtExp_1);
            this.gcl.Name = "gcl";
            this.gcl.UseTextEndEllipsis = true;
            this.gcl.Width = 41;
            // 
            // txtExp_1
            // 
            this.txtExp_1.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtExp_1.Format = "5";
            this.txtExp_1.Location = new System.Drawing.Point(2, 2);
            this.txtExp_1.Name = "txtExp_1";
            this.txtExp_1.Size = new System.Drawing.Size(33, 17);
            this.txtExp_1.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtExp_1.Data = Firefly.Box.UI.Advanced.ControlData.FromBool(_controller.Exp_1);
            // 
            // gcl1
            // 
            this.gcl1.Controls.Add(this.txtExp_3);
            this.gcl1.Name = "gcl1";
            this.gcl1.UseTextEndEllipsis = true;
            this.gcl1.Width = 42;
            // 
            // txtExp_3
            // 
            this.txtExp_3.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtExp_3.Format = "5";
            this.txtExp_3.Location = new System.Drawing.Point(2, 2);
            this.txtExp_3.Name = "txtExp_3";
            this.txtExp_3.Size = new System.Drawing.Size(33, 17);
            this.txtExp_3.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtExp_3.Data = Firefly.Box.UI.Advanced.ControlData.FromBool(_controller.Exp_3);
            // 
            // gcl2
            // 
            this.gcl2.Controls.Add(this.txtExp_4);
            this.gcl2.Name = "gcl2";
            this.gcl2.UseTextEndEllipsis = true;
            this.gcl2.Width = 41;
            // 
            // txtExp_4
            // 
            this.txtExp_4.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtExp_4.Format = "5";
            this.txtExp_4.Location = new System.Drawing.Point(2, 2);
            this.txtExp_4.Name = "txtExp_4";
            this.txtExp_4.Size = new System.Drawing.Size(32, 17);
            this.txtExp_4.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtExp_4.Data = Firefly.Box.UI.Advanced.ControlData.FromBool(_controller.Exp_4);
            // 
            // gcl3
            // 
            this.gcl3.Controls.Add(this.txtExp_5);
            this.gcl3.Name = "gcl3";
            this.gcl3.UseTextEndEllipsis = true;
            this.gcl3.Width = 41;
            // 
            // txtExp_5
            // 
            this.txtExp_5.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtExp_5.Format = "5";
            this.txtExp_5.Location = new System.Drawing.Point(2, 2);
            this.txtExp_5.Name = "txtExp_5";
            this.txtExp_5.Size = new System.Drawing.Size(32, 17);
            this.txtExp_5.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtExp_5.Data = Firefly.Box.UI.Advanced.ControlData.FromBool(_controller.Exp_5);
            // 
            // gcl4
            // 
            this.gcl4.Controls.Add(this.txtExp_6);
            this.gcl4.Name = "gcl4";
            this.gcl4.UseTextEndEllipsis = true;
            this.gcl4.Width = 41;
            // 
            // txtExp_6
            // 
            this.txtExp_6.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtExp_6.Format = "5";
            this.txtExp_6.Location = new System.Drawing.Point(2, 2);
            this.txtExp_6.Name = "txtExp_6";
            this.txtExp_6.Size = new System.Drawing.Size(33, 17);
            this.txtExp_6.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtExp_6.Data = Firefly.Box.UI.Advanced.ControlData.FromBool(_controller.Exp_6);
            // 
            // gcl5
            // 
            this.gcl5.Controls.Add(this.txtExp_7);
            this.gcl5.Name = "gcl5";
            this.gcl5.UseTextEndEllipsis = true;
            this.gcl5.Width = 42;
            // 
            // txtExp_7
            // 
            this.txtExp_7.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtExp_7.Format = "4";
            this.txtExp_7.Location = new System.Drawing.Point(2, 2);
            this.txtExp_7.Name = "txtExp_7";
            this.txtExp_7.Size = new System.Drawing.Size(33, 17);
            this.txtExp_7.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtExp_7.Data = Firefly.Box.UI.Advanced.ControlData.FromNumber(_controller.Exp_7);
            // 
            // gcl6
            // 
            this.gcl6.Controls.Add(this.txtExp_8);
            this.gcl6.Name = "gcl6";
            this.gcl6.UseTextEndEllipsis = true;
            this.gcl6.Width = 41;
            // 
            // txtExp_8
            // 
            this.txtExp_8.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtExp_8.Format = "5";
            this.txtExp_8.Location = new System.Drawing.Point(2, 2);
            this.txtExp_8.Name = "txtExp_8";
            this.txtExp_8.Size = new System.Drawing.Size(32, 17);
            this.txtExp_8.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtExp_8.Data = Firefly.Box.UI.Advanced.ControlData.FromBool(_controller.Exp_8);
            // 
            // txt_parentApplicationsApplicationNumber
            // 
            this.txt_parentApplicationsApplicationNumber.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.txt_parentApplicationsApplicationNumber.Location = new System.Drawing.Point(20, 13);
            this.txt_parentApplicationsApplicationNumber.Name = "txt_parentApplicationsApplicationNumber";
            this.txt_parentApplicationsApplicationNumber.Size = new System.Drawing.Size(33, 16);
            this.txt_parentApplicationsApplicationNumber.Tag = "Application Number";
            this.txt_parentApplicationsApplicationNumber.Data = this._controller._parent.Applications.ApplicationNumber;
            // 
            // AccessControl1OpenApplication
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 325);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.txt_parentApplicationsApplicationNumber);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Location = new System.Drawing.Point(649, 244);
            this.Name = "AccessControl1OpenApplication";
            this.Text = "Open Application";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.grd.ResumeLayout(false);
            this.gclVCounter.ResumeLayout(false);
            this.gcl.ResumeLayout(false);
            this.gcl1.ResumeLayout(false);
            this.gcl2.ResumeLayout(false);
            this.gcl3.ResumeLayout(false);
            this.gcl4.ResumeLayout(false);
            this.gcl5.ResumeLayout(false);
            this.gcl6.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
