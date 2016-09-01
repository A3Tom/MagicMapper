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
namespace MandCo.SystemAccess.Printing
{
    partial class AccessControlDVKillActiveUsers
    {
        internal Theme.Printing.ReportSection UserListHeader;
        Theme.Colors.DefaultPrintFormColor clrDefaultPrintFormColor;
        Theme.Printing.Label lblAccessControl;
        Theme.Printing.Label lblListOfCurrentUsers;
        Theme.Printing.TextBox txtExp_2;
        Theme.Printing.TextBox txtExp_1;
        Theme.Printing.Label lblUserID;
        Theme.Printing.Label lblProcessID;
        Theme.Fonts.MackaysUserDefined28 fntMackaysUserDefined;
        Theme.Fonts.MackaysUserDefined27 fntMackaysUserDefined1;
        internal Theme.Printing.ReportSection UserListDetail;
        Theme.Colors.DefaultPrintFormColor clrDefaultPrintFormColor1;
        Theme.Printing.TextBox txtVUID;
        Theme.Printing.TextBox txtVPID;
        Theme.Fonts.MackaysUserDefined27 fntMackaysUserDefined2;
        void InitializeComponent()
        {
            this.UserListHeader = new MandCo.Theme.Printing.ReportSection();
            this.clrDefaultPrintFormColor = new MandCo.Theme.Colors.DefaultPrintFormColor();
            this.lblAccessControl = new MandCo.Theme.Printing.Label();
            this.lblListOfCurrentUsers = new MandCo.Theme.Printing.Label();
            this.fntMackaysUserDefined = new MandCo.Theme.Fonts.MackaysUserDefined28();
            this.txtExp_2 = new MandCo.Theme.Printing.TextBox();
            this.fntMackaysUserDefined1 = new MandCo.Theme.Fonts.MackaysUserDefined27();
            this.txtExp_1 = new MandCo.Theme.Printing.TextBox();
            this.lblUserID = new MandCo.Theme.Printing.Label();
            this.lblProcessID = new MandCo.Theme.Printing.Label();
            this.UserListDetail = new MandCo.Theme.Printing.ReportSection();
            this.clrDefaultPrintFormColor1 = new MandCo.Theme.Colors.DefaultPrintFormColor();
            this.txtVUID = new MandCo.Theme.Printing.TextBox();
            this.fntMackaysUserDefined2 = new MandCo.Theme.Fonts.MackaysUserDefined27();
            this.txtVPID = new MandCo.Theme.Printing.TextBox();
            this.UserListHeader.SuspendLayout();
            this.UserListDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserListHeader
            // 
            this.UserListHeader.ColorScheme = this.clrDefaultPrintFormColor;
            this.UserListHeader.Controls.Add(this.lblProcessID);
            this.UserListHeader.Controls.Add(this.lblUserID);
            this.UserListHeader.Controls.Add(this.txtExp_1);
            this.UserListHeader.Controls.Add(this.txtExp_2);
            this.UserListHeader.Controls.Add(this.lblListOfCurrentUsers);
            this.UserListHeader.Controls.Add(this.lblAccessControl);
            this.UserListHeader.Height = 49;
            this.UserListHeader.Location = new System.Drawing.Point(0, 0);
            this.UserListHeader.Name = "UserListHeader";
            this.UserListHeader.PageHeader = true;
            // 
            // lblAccessControl
            // 
            this.lblAccessControl.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAccessControl.ColorScheme = this.clrDefaultPrintFormColor;
            this.lblAccessControl.Name = "lblAccessControl";
            this.lblAccessControl.Rtf = "(Access Control)";
            this.lblAccessControl.Size = new System.Drawing.Size(82, 13);
            this.lblAccessControl.Text = "(Access Control)";
            // 
            // lblListOfCurrentUsers
            // 
            this.lblListOfCurrentUsers.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblListOfCurrentUsers.ColorScheme = this.clrDefaultPrintFormColor;
            this.lblListOfCurrentUsers.FontScheme = this.fntMackaysUserDefined;
            this.lblListOfCurrentUsers.Location = new System.Drawing.Point(123, 0);
            this.lblListOfCurrentUsers.Name = "lblListOfCurrentUsers";
            this.lblListOfCurrentUsers.Rtf = "List of Current Users";
            this.lblListOfCurrentUsers.Size = new System.Drawing.Size(122, 14);
            this.lblListOfCurrentUsers.Text = "List of Current Users";
            // 
            // txtExp_2
            // 
            this.txtExp_2.ColorScheme = this.clrDefaultPrintFormColor;
            this.txtExp_2.FontScheme = this.fntMackaysUserDefined1;
            this.txtExp_2.Format = "20";
            this.txtExp_2.Location = new System.Drawing.Point(270, 0);
            this.txtExp_2.Name = "txtExp_2";
            this.txtExp_2.Size = new System.Drawing.Size(145, 14);
            this.txtExp_2.Data = Firefly.Box.UI.Advanced.ControlData.FromText(_controller.Exp_2);
            // 
            // txtExp_1
            // 
            this.txtExp_1.ColorScheme = this.clrDefaultPrintFormColor;
            this.txtExp_1.FontScheme = this.fntMackaysUserDefined1;
            this.txtExp_1.Format = "10";
            this.txtExp_1.Location = new System.Drawing.Point(419, 0);
            this.txtExp_1.Name = "txtExp_1";
            this.txtExp_1.Size = new System.Drawing.Size(75, 14);
            this.txtExp_1.Data = Firefly.Box.UI.Advanced.ControlData.FromText(_controller.Exp_1);
            // 
            // lblUserID
            // 
            this.lblUserID.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserID.ColorScheme = this.clrDefaultPrintFormColor;
            this.lblUserID.FontScheme = this.fntMackaysUserDefined;
            this.lblUserID.Location = new System.Drawing.Point(118, 26);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Rtf = "User ID";
            this.lblUserID.Size = new System.Drawing.Size(44, 14);
            this.lblUserID.Text = "User ID";
            // 
            // lblProcessID
            // 
            this.lblProcessID.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProcessID.ColorScheme = this.clrDefaultPrintFormColor;
            this.lblProcessID.FontScheme = this.fntMackaysUserDefined;
            this.lblProcessID.Location = new System.Drawing.Point(221, 26);
            this.lblProcessID.Name = "lblProcessID";
            this.lblProcessID.Rtf = "Process ID";
            this.lblProcessID.Size = new System.Drawing.Size(64, 14);
            this.lblProcessID.Text = "Process ID";
            // 
            // UserListDetail
            // 
            this.UserListDetail.ColorScheme = this.clrDefaultPrintFormColor1;
            this.UserListDetail.Controls.Add(this.txtVPID);
            this.UserListDetail.Controls.Add(this.txtVUID);
            this.UserListDetail.Height = 15;
            this.UserListDetail.Location = new System.Drawing.Point(0, 0);
            this.UserListDetail.Name = "UserListDetail";
            // 
            // txtVUID
            // 
            this.txtVUID.ColorScheme = this.clrDefaultPrintFormColor1;
            this.txtVUID.FontScheme = this.fntMackaysUserDefined2;
            this.txtVUID.Location = new System.Drawing.Point(118, 0);
            this.txtVUID.Name = "txtVUID";
            this.txtVUID.Size = new System.Drawing.Size(75, 14);
            this.txtVUID.Data = this._controller.vUID;
            // 
            // txtVPID
            // 
            this.txtVPID.ColorScheme = this.clrDefaultPrintFormColor1;
            this.txtVPID.FontScheme = this.fntMackaysUserDefined2;
            this.txtVPID.Location = new System.Drawing.Point(221, 0);
            this.txtVPID.Name = "txtVPID";
            this.txtVPID.Size = new System.Drawing.Size(75, 14);
            this.txtVPID.Data = this._controller.vPID;
            // 
            // AccessControlDVKillActiveUsers
            // 
            this.Controls.Add(this.UserListHeader);
            this.Controls.Add(this.UserListDetail);
            this.HorizontalExpressionFactor = 100D;
            this.HorizontalScale = 37.7952755905512D;
            this.Name = "AccessControlDVKillActiveUsers";
            this.VerticalExpressionFactor = 100D;
            this.VerticalScale = 37.7952755905512D;
            this.Width = 515;
            this.UserListHeader.ResumeLayout(false);
            this.UserListDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
