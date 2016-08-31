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
    partial class AccessControl1UsersAccessControl
    {
        System.ComponentModel.IContainer components;
        Theme.Controls.Label lblRecordType;
        Theme.Controls.TextBox txtControlRecordType;
        Theme.Controls.Label lblRecordSubType;
        Theme.Controls.TextBox txtControlRecordSubType;
        Theme.Controls.Label lblDelimitedDataString;
        Theme.Controls.TextBox txtControlDelimitedDataString;
        Theme.Controls.Label lblComments;
        Theme.Controls.TextBox txtControlComments;
        Theme.Fonts.TableField fntTableField;
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
            this.fntTableField = new MandCo.Theme.Fonts.TableField();
            this.lblRecordType = new MandCo.Theme.Controls.Label();
            this.txtControlRecordType = new MandCo.Theme.Controls.TextBox();
            this.lblRecordSubType = new MandCo.Theme.Controls.Label();
            this.txtControlRecordSubType = new MandCo.Theme.Controls.TextBox();
            this.lblDelimitedDataString = new MandCo.Theme.Controls.Label();
            this.txtControlDelimitedDataString = new MandCo.Theme.Controls.TextBox();
            this.lblComments = new MandCo.Theme.Controls.Label();
            this.txtControlComments = new MandCo.Theme.Controls.TextBox();
            this.SuspendLayout();
            // 
            // lblRecordType
            // 
            this.lblRecordType.FontScheme = this.fntTableField;
            this.lblRecordType.Location = new System.Drawing.Point(5, 13);
            this.lblRecordType.Name = "lblRecordType";
            this.lblRecordType.Rtf = "Record Type";
            this.lblRecordType.Size = new System.Drawing.Size(63, 13);
            this.lblRecordType.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblRecordType.Text = "Record Type";
            // 
            // txtControlRecordType
            // 
            this.txtControlRecordType.Location = new System.Drawing.Point(73, 13);
            this.txtControlRecordType.Name = "txtControlRecordType";
            this.txtControlRecordType.Size = new System.Drawing.Size(73, 16);
            this.txtControlRecordType.Tag = "Record Type";
            this.txtControlRecordType.Data = this._controller.Control.RecordType;
            // 
            // lblRecordSubType
            // 
            this.lblRecordSubType.FontScheme = this.fntTableField;
            this.lblRecordSubType.Location = new System.Drawing.Point(10, 39);
            this.lblRecordSubType.Name = "lblRecordSubType";
            this.lblRecordSubType.Rtf = "Record SubType";
            this.lblRecordSubType.Size = new System.Drawing.Size(81, 13);
            this.lblRecordSubType.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblRecordSubType.Text = "Record SubType";
            // 
            // txtControlRecordSubType
            // 
            this.txtControlRecordSubType.Location = new System.Drawing.Point(96, 39);
            this.txtControlRecordSubType.Name = "txtControlRecordSubType";
            this.txtControlRecordSubType.Size = new System.Drawing.Size(74, 16);
            this.txtControlRecordSubType.Tag = "Record SubType";
            this.txtControlRecordSubType.Data = this._controller.Control.RecordSubType;
            // 
            // lblDelimitedDataString
            // 
            this.lblDelimitedDataString.FontScheme = this.fntTableField;
            this.lblDelimitedDataString.Location = new System.Drawing.Point(0, 65);
            this.lblDelimitedDataString.Name = "lblDelimitedDataString";
            this.lblDelimitedDataString.Rtf = "Delimited Data String";
            this.lblDelimitedDataString.Size = new System.Drawing.Size(99, 13);
            this.lblDelimitedDataString.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblDelimitedDataString.Text = "Delimited Data String";
            // 
            // txtControlDelimitedDataString
            // 
            this.txtControlDelimitedDataString.Location = new System.Drawing.Point(0, 91);
            this.txtControlDelimitedDataString.Name = "txtControlDelimitedDataString";
            this.txtControlDelimitedDataString.Size = new System.Drawing.Size(245, 16);
            this.txtControlDelimitedDataString.Tag = "Delimited Data String";
            this.txtControlDelimitedDataString.Data = this._controller.Control.DelimitedDataString;
            // 
            // lblComments
            // 
            this.lblComments.FontScheme = this.fntTableField;
            this.lblComments.Location = new System.Drawing.Point(0, 117);
            this.lblComments.Name = "lblComments";
            this.lblComments.Rtf = "Comments";
            this.lblComments.Size = new System.Drawing.Size(49, 13);
            this.lblComments.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.lblComments.Text = "Comments";
            // 
            // txtControlComments
            // 
            this.txtControlComments.Location = new System.Drawing.Point(0, 143);
            this.txtControlComments.Name = "txtControlComments";
            this.txtControlComments.Size = new System.Drawing.Size(250, 16);
            this.txtControlComments.Tag = "Comments";
            this.txtControlComments.Data = this._controller.Control.Comments;
            // 
            // AccessControl1UsersAccessControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 177);
            this.Controls.Add(this.txtControlComments);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.txtControlDelimitedDataString);
            this.Controls.Add(this.lblDelimitedDataString);
            this.Controls.Add(this.txtControlRecordSubType);
            this.Controls.Add(this.lblRecordSubType);
            this.Controls.Add(this.txtControlRecordType);
            this.Controls.Add(this.lblRecordType);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Location = new System.Drawing.Point(773, 466);
            this.Name = "AccessControl1UsersAccessControl";
            this.Text = "UsersAccessControl";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.ResumeLayout(false);

        }
    }
}
