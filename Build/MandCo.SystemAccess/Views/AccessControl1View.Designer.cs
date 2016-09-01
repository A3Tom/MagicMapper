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
    partial class AccessControl1View
    {
        System.ComponentModel.IContainer components;
        Theme.Controls.Grid grd;
        Theme.Controls.GridColumn gclUserID;
        Theme.Controls.GridColumn gclGroupID;
        Theme.Controls.GridColumn gclUserID1;
        Theme.Controls.GridColumn gclUserName;
        Theme.Controls.GridColumn gclRecordType;
        Theme.Controls.GridColumn gclRecordSubType;
        Theme.Controls.GridColumn gclDelimitedDataString;
        Theme.Controls.GridColumn gclVVersion;
        Theme.Controls.GridColumn gclVServicePack;
        Theme.Controls.GridColumn gclRecordType1;
        Theme.Controls.GridColumn gclRecordSubType1;
        Theme.Controls.GridColumn gclDelimitedDataString1;
        Theme.Controls.TextBox txtUserGroupsUserID;
        Theme.Controls.TextBox txtUserGroupsGroupID;
        Theme.Controls.TextBox txtUsersUserID;
        Theme.Controls.TextBox txtUsersUserName;
        Theme.Controls.TextBox txtControlRecordType;
        Theme.Controls.TextBox txtControlRecordSubType;
        Theme.Controls.TextBox txtControlDelimitedDataString;
        Theme.Controls.TextBox txtVVersion;
        Theme.Controls.TextBox txtVServicePack;
        Theme.Controls.TextBox txtControl1RecordType;
        Theme.Controls.TextBox txtControl1RecordSubType;
        Theme.Controls.TextBox txtControl1DelimitedDataString;
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
            this.gclUserID = new MandCo.Theme.Controls.GridColumn();
            this.txtUserGroupsUserID = new MandCo.Theme.Controls.TextBox();
            this.gclGroupID = new MandCo.Theme.Controls.GridColumn();
            this.txtUserGroupsGroupID = new MandCo.Theme.Controls.TextBox();
            this.gclUserID1 = new MandCo.Theme.Controls.GridColumn();
            this.txtUsersUserID = new MandCo.Theme.Controls.TextBox();
            this.gclUserName = new MandCo.Theme.Controls.GridColumn();
            this.txtUsersUserName = new MandCo.Theme.Controls.TextBox();
            this.gclRecordType = new MandCo.Theme.Controls.GridColumn();
            this.txtControlRecordType = new MandCo.Theme.Controls.TextBox();
            this.gclRecordSubType = new MandCo.Theme.Controls.GridColumn();
            this.txtControlRecordSubType = new MandCo.Theme.Controls.TextBox();
            this.gclDelimitedDataString = new MandCo.Theme.Controls.GridColumn();
            this.txtControlDelimitedDataString = new MandCo.Theme.Controls.TextBox();
            this.gclVVersion = new MandCo.Theme.Controls.GridColumn();
            this.txtVVersion = new MandCo.Theme.Controls.TextBox();
            this.gclVServicePack = new MandCo.Theme.Controls.GridColumn();
            this.txtVServicePack = new MandCo.Theme.Controls.TextBox();
            this.gclRecordType1 = new MandCo.Theme.Controls.GridColumn();
            this.txtControl1RecordType = new MandCo.Theme.Controls.TextBox();
            this.gclRecordSubType1 = new MandCo.Theme.Controls.GridColumn();
            this.txtControl1RecordSubType = new MandCo.Theme.Controls.TextBox();
            this.gclDelimitedDataString1 = new MandCo.Theme.Controls.GridColumn();
            this.txtControl1DelimitedDataString = new MandCo.Theme.Controls.TextBox();
            this.grd.SuspendLayout();
            this.gclUserID.SuspendLayout();
            this.gclGroupID.SuspendLayout();
            this.gclUserID1.SuspendLayout();
            this.gclUserName.SuspendLayout();
            this.gclRecordType.SuspendLayout();
            this.gclRecordSubType.SuspendLayout();
            this.gclDelimitedDataString.SuspendLayout();
            this.gclVVersion.SuspendLayout();
            this.gclVServicePack.SuspendLayout();
            this.gclRecordType1.SuspendLayout();
            this.gclRecordSubType1.SuspendLayout();
            this.gclDelimitedDataString1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.grd.AllowMultiSelect = false;
            this.grd.Controls.Add(this.gclUserID);
            this.grd.Controls.Add(this.gclGroupID);
            this.grd.Controls.Add(this.gclUserID1);
            this.grd.Controls.Add(this.gclUserName);
            this.grd.Controls.Add(this.gclRecordType);
            this.grd.Controls.Add(this.gclRecordSubType);
            this.grd.Controls.Add(this.gclDelimitedDataString);
            this.grd.Controls.Add(this.gclVVersion);
            this.grd.Controls.Add(this.gclVServicePack);
            this.grd.Controls.Add(this.gclRecordType1);
            this.grd.Controls.Add(this.gclRecordSubType1);
            this.grd.Controls.Add(this.gclDelimitedDataString1);
            this.grd.Location = new System.Drawing.Point(10, 13);
            this.grd.Name = "grd";
            this.grd.RowHeight = 21;
            this.grd.Size = new System.Drawing.Size(1620, 179);
            // 
            // gclUserID
            // 
            this.gclUserID.AllowSort = true;
            this.gclUserID.Controls.Add(this.txtUserGroupsUserID);
            this.gclUserID.Name = "gclUserID";
            this.gclUserID.Text = "UserID";
            this.gclUserID.UseTextEndEllipsis = true;
            this.gclUserID.Width = 70;
            // 
            // txtUserGroupsUserID
            // 
            this.txtUserGroupsUserID.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtUserGroupsUserID.Location = new System.Drawing.Point(3, 2);
            this.txtUserGroupsUserID.Name = "txtUserGroupsUserID";
            this.txtUserGroupsUserID.Size = new System.Drawing.Size(60, 17);
            this.txtUserGroupsUserID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUserGroupsUserID.Tag = "UserID";
            this.txtUserGroupsUserID.Data = this._controller.UserGroups.UserID;
            // 
            // gclGroupID
            // 
            this.gclGroupID.AllowSort = true;
            this.gclGroupID.Controls.Add(this.txtUserGroupsGroupID);
            this.gclGroupID.Name = "gclGroupID";
            this.gclGroupID.Text = "GroupID";
            this.gclGroupID.UseTextEndEllipsis = true;
            this.gclGroupID.Width = 152;
            // 
            // txtUserGroupsGroupID
            // 
            this.txtUserGroupsGroupID.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtUserGroupsGroupID.Location = new System.Drawing.Point(2, 2);
            this.txtUserGroupsGroupID.Name = "txtUserGroupsGroupID";
            this.txtUserGroupsGroupID.Size = new System.Drawing.Size(144, 17);
            this.txtUserGroupsGroupID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUserGroupsGroupID.Tag = "GroupID";
            this.txtUserGroupsGroupID.Data = this._controller.UserGroups.GroupID;
            // 
            // gclUserID1
            // 
            this.gclUserID1.Controls.Add(this.txtUsersUserID);
            this.gclUserID1.Name = "gclUserID1";
            this.gclUserID1.Text = "UserID";
            this.gclUserID1.UseTextEndEllipsis = true;
            this.gclUserID1.Width = 69;
            // 
            // txtUsersUserID
            // 
            this.txtUsersUserID.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtUsersUserID.Location = new System.Drawing.Point(2, 2);
            this.txtUsersUserID.Name = "txtUsersUserID";
            this.txtUsersUserID.Size = new System.Drawing.Size(60, 17);
            this.txtUsersUserID.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUsersUserID.Tag = "UserID_0001";
            this.txtUsersUserID.Data = this._controller.Users.UserID;
            // 
            // gclUserName
            // 
            this.gclUserName.Controls.Add(this.txtUsersUserName);
            this.gclUserName.Name = "gclUserName";
            this.gclUserName.Text = "UserName";
            this.gclUserName.UseTextEndEllipsis = true;
            this.gclUserName.Width = 83;
            // 
            // txtUsersUserName
            // 
            this.txtUsersUserName.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtUsersUserName.Location = new System.Drawing.Point(2, 2);
            this.txtUsersUserName.Name = "txtUsersUserName";
            this.txtUsersUserName.Size = new System.Drawing.Size(74, 17);
            this.txtUsersUserName.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtUsersUserName.Tag = "UserName";
            this.txtUsersUserName.Data = this._controller.Users.UserName;
            // 
            // gclRecordType
            // 
            this.gclRecordType.Controls.Add(this.txtControlRecordType);
            this.gclRecordType.Name = "gclRecordType";
            this.gclRecordType.Text = "Record Type";
            this.gclRecordType.UseTextEndEllipsis = true;
            this.gclRecordType.Width = 82;
            // 
            // txtControlRecordType
            // 
            this.txtControlRecordType.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtControlRecordType.Location = new System.Drawing.Point(2, 2);
            this.txtControlRecordType.Name = "txtControlRecordType";
            this.txtControlRecordType.Size = new System.Drawing.Size(73, 17);
            this.txtControlRecordType.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtControlRecordType.Tag = "Record Type";
            this.txtControlRecordType.Data = this._controller.Control.RecordType;
            // 
            // gclRecordSubType
            // 
            this.gclRecordSubType.Controls.Add(this.txtControlRecordSubType);
            this.gclRecordSubType.Name = "gclRecordSubType";
            this.gclRecordSubType.Text = "Record SubType";
            this.gclRecordSubType.UseTextEndEllipsis = true;
            this.gclRecordSubType.Width = 85;
            // 
            // txtControlRecordSubType
            // 
            this.txtControlRecordSubType.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtControlRecordSubType.Location = new System.Drawing.Point(2, 2);
            this.txtControlRecordSubType.Name = "txtControlRecordSubType";
            this.txtControlRecordSubType.Size = new System.Drawing.Size(74, 17);
            this.txtControlRecordSubType.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtControlRecordSubType.Tag = "Record SubType";
            this.txtControlRecordSubType.Data = this._controller.Control.RecordSubType;
            // 
            // gclDelimitedDataString
            // 
            this.gclDelimitedDataString.Controls.Add(this.txtControlDelimitedDataString);
            this.gclDelimitedDataString.Name = "gclDelimitedDataString";
            this.gclDelimitedDataString.Text = "Delimited Data String";
            this.gclDelimitedDataString.UseTextEndEllipsis = true;
            this.gclDelimitedDataString.Width = 363;
            // 
            // txtControlDelimitedDataString
            // 
            this.txtControlDelimitedDataString.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtControlDelimitedDataString.Location = new System.Drawing.Point(2, 2);
            this.txtControlDelimitedDataString.Name = "txtControlDelimitedDataString";
            this.txtControlDelimitedDataString.Size = new System.Drawing.Size(354, 17);
            this.txtControlDelimitedDataString.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtControlDelimitedDataString.Tag = "Delimited Data String";
            this.txtControlDelimitedDataString.Data = this._controller.Control.DelimitedDataString;
            // 
            // gclVVersion
            // 
            this.gclVVersion.Controls.Add(this.txtVVersion);
            this.gclVVersion.Name = "gclVVersion";
            this.gclVVersion.Text = "v:Version";
            this.gclVVersion.UseTextEndEllipsis = true;
            this.gclVVersion.Width = 82;
            // 
            // txtVVersion
            // 
            this.txtVVersion.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtVVersion.Location = new System.Drawing.Point(2, 2);
            this.txtVVersion.Name = "txtVVersion";
            this.txtVVersion.Size = new System.Drawing.Size(73, 17);
            this.txtVVersion.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtVVersion.Tag = "v:Version";
            this.txtVVersion.Data = this._controller.vVersion;
            // 
            // gclVServicePack
            // 
            this.gclVServicePack.Controls.Add(this.txtVServicePack);
            this.gclVServicePack.Name = "gclVServicePack";
            this.gclVServicePack.Text = "v:ServicePack";
            this.gclVServicePack.UseTextEndEllipsis = true;
            this.gclVServicePack.Width = 83;
            // 
            // txtVServicePack
            // 
            this.txtVServicePack.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtVServicePack.Location = new System.Drawing.Point(2, 2);
            this.txtVServicePack.Name = "txtVServicePack";
            this.txtVServicePack.Size = new System.Drawing.Size(74, 17);
            this.txtVServicePack.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtVServicePack.Tag = "v:ServicePack";
            this.txtVServicePack.Data = this._controller.vServicePack;
            // 
            // gclRecordType1
            // 
            this.gclRecordType1.Controls.Add(this.txtControl1RecordType);
            this.gclRecordType1.Name = "gclRecordType1";
            this.gclRecordType1.Text = "Record Type";
            this.gclRecordType1.UseTextEndEllipsis = true;
            this.gclRecordType1.Width = 82;
            // 
            // txtControl1RecordType
            // 
            this.txtControl1RecordType.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtControl1RecordType.Location = new System.Drawing.Point(2, 2);
            this.txtControl1RecordType.Name = "txtControl1RecordType";
            this.txtControl1RecordType.Size = new System.Drawing.Size(73, 17);
            this.txtControl1RecordType.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtControl1RecordType.Tag = "Record Type_0001";
            this.txtControl1RecordType.Data = this._controller.Control1.RecordType;
            // 
            // gclRecordSubType1
            // 
            this.gclRecordSubType1.Controls.Add(this.txtControl1RecordSubType);
            this.gclRecordSubType1.Name = "gclRecordSubType1";
            this.gclRecordSubType1.Text = "Record SubType";
            this.gclRecordSubType1.UseTextEndEllipsis = true;
            this.gclRecordSubType1.Width = 85;
            // 
            // txtControl1RecordSubType
            // 
            this.txtControl1RecordSubType.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtControl1RecordSubType.Location = new System.Drawing.Point(2, 2);
            this.txtControl1RecordSubType.Name = "txtControl1RecordSubType";
            this.txtControl1RecordSubType.Size = new System.Drawing.Size(74, 17);
            this.txtControl1RecordSubType.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtControl1RecordSubType.Tag = "Record SubType_0001";
            this.txtControl1RecordSubType.Data = this._controller.Control1.RecordSubType;
            // 
            // gclDelimitedDataString1
            // 
            this.gclDelimitedDataString1.Controls.Add(this.txtControl1DelimitedDataString);
            this.gclDelimitedDataString1.Name = "gclDelimitedDataString1";
            this.gclDelimitedDataString1.Text = "Delimited Data String";
            this.gclDelimitedDataString1.UseTextEndEllipsis = true;
            this.gclDelimitedDataString1.Width = 363;
            // 
            // txtControl1DelimitedDataString
            // 
            this.txtControl1DelimitedDataString.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 0);
            this.txtControl1DelimitedDataString.Location = new System.Drawing.Point(2, 2);
            this.txtControl1DelimitedDataString.Name = "txtControl1DelimitedDataString";
            this.txtControl1DelimitedDataString.Size = new System.Drawing.Size(354, 17);
            this.txtControl1DelimitedDataString.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtControl1DelimitedDataString.Tag = "Delimited Data String_0001";
            this.txtControl1DelimitedDataString.Data = this._controller.Control1.DelimitedDataString;
            // 
            // AccessControl1View
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1701, 205);
            this.Controls.Add(this.grd);
            this.HorizontalExpressionFactor = 4D;
            this.HorizontalScale = 5D;
            this.Location = new System.Drawing.Point(5, 2);
            this.Name = "AccessControl1View";
            this.Text = "Access Control";
            this.VerticalExpressionFactor = 8D;
            this.VerticalScale = 13D;
            this.grd.ResumeLayout(false);
            this.gclUserID.ResumeLayout(false);
            this.gclGroupID.ResumeLayout(false);
            this.gclUserID1.ResumeLayout(false);
            this.gclUserName.ResumeLayout(false);
            this.gclRecordType.ResumeLayout(false);
            this.gclRecordSubType.ResumeLayout(false);
            this.gclDelimitedDataString.ResumeLayout(false);
            this.gclVVersion.ResumeLayout(false);
            this.gclVServicePack.ResumeLayout(false);
            this.gclRecordType1.ResumeLayout(false);
            this.gclRecordSubType1.ResumeLayout(false);
            this.gclDelimitedDataString1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
