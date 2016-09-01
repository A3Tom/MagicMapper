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
    partial class BrowseControlView
    {
        System.ComponentModel.IContainer components;
        Theme.Colors.DefaultHelpWindow clrDefaultHelpWindow;
        Theme.Controls.Label lblBrowseControl;
        Theme.Controls.Line lin;
        Controls.V9CompatibleDefaultTable grd;
        Theme.Controls.GridColumn gcl;
        Theme.Controls.GridColumn gcl1;
        Theme.Controls.GridColumn gcl2;
        Theme.Controls.GridColumn gcl3;
        Theme.Controls.Label lblRecordType;
        Theme.Controls.Label lblRecordSubType;
        Theme.Controls.Label lblDelimitedDataString;
        Theme.Controls.Label lblComments;
        Theme.Controls.TextBox txtControlRecordType;
        Theme.Controls.TextBox txtControlRecordSubType;
        Theme.Controls.TextBox txtControlDelimitedDataString;
        Theme.Controls.TextBox txtControlComments;
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
            this.txtControlRecordType = new MandCo.Theme.Controls.TextBox();
            this.gcl1 = new MandCo.Theme.Controls.GridColumn();
            this.txtControlRecordSubType = new MandCo.Theme.Controls.TextBox();
            this.gcl2 = new MandCo.Theme.Controls.GridColumn();
            this.txtControlDelimitedDataString = new MandCo.Theme.Controls.TextBox();
            this.gcl3 = new MandCo.Theme.Controls.GridColumn();
            this.txtControlComments = new MandCo.Theme.Controls.TextBox();
            this.lblBrowseControl = new MandCo.Theme.Controls.Label();
            this.lin = new MandCo.Theme.Controls.Line();
            this.lblRecordType = new MandCo.Theme.Controls.Label();
            this.lblRecordSubType = new MandCo.Theme.Controls.Label();
            this.lblDelimitedDataString = new MandCo.Theme.Controls.Label();
            this.lblComments = new MandCo.Theme.Controls.Label();
            TabOrderMode = Firefly.Box.UI.TabOrderMode.ManualIgnoringContainerHeirarchy;
            this.grd.SuspendLayout();
            this.gcl.SuspendLayout();
            this.gcl1.SuspendLayout();
            this.gcl2.SuspendLayout();
            this.gcl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.AllowUserToResizeColumns = false;
            this.grd.ColorScheme = this.clrDefault3DEffect;
            this.grd.Controls.Add(this.gcl);
            this.grd.Controls.Add(this.gcl1);
            this.grd.Controls.Add(this.gcl2);
            this.grd.Controls.Add(this.gcl3);
            this.grd.HeaderHeight = 18;
            this.grd.Location = new System.Drawing.Point(5, 65);
            this.grd.Name = "grd";
            this.grd.RowHeight = 20;
            this.grd.Size = new System.Drawing.Size(943, 244);
            // 
            // gcl
            // 
            this.gcl.Controls.Add(this.txtControlRecordType);
            this.gcl.Name = "gcl";
            this.gcl.UseTextEndEllipsis = true;
            this.gcl.Width = 96;
            // 
            // txtControlRecordType
            // 
            this.txtControlRecordType.Location = new System.Drawing.Point(3, 1);
            this.txtControlRecordType.Name = "txtControlRecordType";
            this.txtControlRecordType.Size = new System.Drawing.Size(85, 13);
            this.txtControlRecordType.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtControlRecordType.TabIndex = 1;
            this.txtControlRecordType.Data = this._controller.Control.RecordType;
            // 
            // gcl1
            // 
            this.gcl1.Controls.Add(this.txtControlRecordSubType);
            this.gcl1.Name = "gcl1";
            this.gcl1.UseTextEndEllipsis = true;
            this.gcl1.Width = 96;
            // 
            // txtControlRecordSubType
            // 
            this.txtControlRecordSubType.Location = new System.Drawing.Point(2, 1);
            this.txtControlRecordSubType.Name = "txtControlRecordSubType";
            this.txtControlRecordSubType.Size = new System.Drawing.Size(85, 13);
            this.txtControlRecordSubType.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtControlRecordSubType.TabIndex = 2;
            this.txtControlRecordSubType.Data = this._controller.Control.RecordSubType;
            // 
            // gcl2
            // 
            this.gcl2.Controls.Add(this.txtControlDelimitedDataString);
            this.gcl2.Name = "gcl2";
            this.gcl2.UseTextEndEllipsis = true;
            this.gcl2.Width = 365;
            // 
            // txtControlDelimitedDataString
            // 
            this.txtControlDelimitedDataString.Location = new System.Drawing.Point(2, 1);
            this.txtControlDelimitedDataString.Name = "txtControlDelimitedDataString";
            this.txtControlDelimitedDataString.Size = new System.Drawing.Size(355, 13);
            this.txtControlDelimitedDataString.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtControlDelimitedDataString.TabIndex = 3;
            this.txtControlDelimitedDataString.Data = this._controller.Control.DelimitedDataString;
            // 
            // gcl3
            // 
            this.gcl3.Controls.Add(this.txtControlComments);
            this.gcl3.Name = "gcl3";
            this.gcl3.UseTextEndEllipsis = true;
            this.gcl3.Width = 370;
            // 
            // txtControlComments
            // 
            this.txtControlComments.Location = new System.Drawing.Point(2, 1);
            this.txtControlComments.Name = "txtControlComments";
            this.txtControlComments.Size = new System.Drawing.Size(355, 13);
            this.txtControlComments.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtControlComments.TabIndex = 4;
            this.txtControlComments.Data = this._controller.Control.Comments;
            // 
            // lblBrowseControl
            // 
            this.lblBrowseControl.ColorScheme = this.clrDefaultFreeText;
            this.lblBrowseControl.FontScheme = this.fntUnused;
            this.lblBrowseControl.Location = new System.Drawing.Point(10, 13);
            this.lblBrowseControl.Name = "lblBrowseControl";
            this.lblBrowseControl.Rtf = "Browse - Control";
            this.lblBrowseControl.Size = new System.Drawing.Size(150, 26);
            this.lblBrowseControl.Text = "Browse - Control";
            // 
            // lin
            // 
            this.lin.BoundTo = new Firefly.Box.UI.ControlBinding(this.lblBrowseControl);
            this.lin.ColorScheme = this.clrDefaultFreeText;
            this.lin.End = new System.Drawing.Point(943, 46);
            this.lin.Name = "lin";
            this.lin.Start = new System.Drawing.Point(5, 46);
            this.lin.Style = Firefly.Box.UI.ControlStyle.Sunken;
            // 
            // lblRecordType
            // 
            this.lblRecordType.BoundTo = new Firefly.Box.UI.ControlBinding(gcl);
            this.lblRecordType.ColorScheme = this.clrDefaultHelpWindow;
            this.lblRecordType.FontScheme = this.fntTableTitle;
            this.lblRecordType.Location = new System.Drawing.Point(10, 68);
            this.lblRecordType.Name = "lblRecordType";
            this.lblRecordType.Rtf = "Record Type";
            this.lblRecordType.Size = new System.Drawing.Size(68, 13);
            this.lblRecordType.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblRecordType.Text = "Record Type";
            // 
            // lblRecordSubType
            // 
            this.lblRecordSubType.BoundTo = new Firefly.Box.UI.ControlBinding(gcl1);
            this.lblRecordSubType.ColorScheme = this.clrDefaultHelpWindow;
            this.lblRecordSubType.FontScheme = this.fntTableTitle;
            this.lblRecordSubType.Location = new System.Drawing.Point(105, 68);
            this.lblRecordSubType.Name = "lblRecordSubType";
            this.lblRecordSubType.Rtf = "Record SubType";
            this.lblRecordSubType.Size = new System.Drawing.Size(86, 13);
            this.lblRecordSubType.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblRecordSubType.Text = "Record SubType";
            // 
            // lblDelimitedDataString
            // 
            this.lblDelimitedDataString.BoundTo = new Firefly.Box.UI.ControlBinding(gcl2);
            this.lblDelimitedDataString.ColorScheme = this.clrDefaultHelpWindow;
            this.lblDelimitedDataString.FontScheme = this.fntTableTitle;
            this.lblDelimitedDataString.Location = new System.Drawing.Point(201, 68);
            this.lblDelimitedDataString.Name = "lblDelimitedDataString";
            this.lblDelimitedDataString.Rtf = "Delimited Data String";
            this.lblDelimitedDataString.Size = new System.Drawing.Size(104, 13);
            this.lblDelimitedDataString.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblDelimitedDataString.Text = "Delimited Data String";
            // 
            // lblComments
            // 
            this.lblComments.BoundTo = new Firefly.Box.UI.ControlBinding(gcl3);
            this.lblComments.ColorScheme = this.clrDefaultHelpWindow;
            this.lblComments.FontScheme = this.fntTableTitle;
            this.lblComments.Location = new System.Drawing.Point(566, 68);
            this.lblComments.Name = "lblComments";
            this.lblComments.Rtf = "Comments";
            this.lblComments.Size = new System.Drawing.Size(54, 13);
            this.lblComments.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblComments.Text = "Comments";
            // 
            // BrowseControlView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 325);
            this.ColorScheme = this.clrDefaultHelpWindow;
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblDelimitedDataString);
            this.Controls.Add(this.lblRecordSubType);
            this.Controls.Add(this.lblRecordType);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.lin);
            this.Controls.Add(this.lblBrowseControl);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Name = "BrowseControlView";
            this.Text = "Browse - Control";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.grd.ResumeLayout(false);
            this.gcl.ResumeLayout(false);
            this.gcl1.ResumeLayout(false);
            this.gcl2.ResumeLayout(false);
            this.gcl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
