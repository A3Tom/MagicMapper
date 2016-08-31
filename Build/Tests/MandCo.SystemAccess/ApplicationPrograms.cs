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
namespace MandCo.SystemAccess
{
    class ApplicationPrograms : ENV.ProgramCollection 
    {
        
        public ApplicationPrograms()
        {
            Add(2, "Access Control", "", typeof(AccessControl));
            Add(5, "Maint - Users", "", typeof(MaintUsers));
            Add(6, "Maint - Groups", "", typeof(MaintGroups));
            Add(7, "Maint - Applications", "", typeof(MaintApplications));
            Add(9, "Attach User to Groups", "", typeof(AttachUserToGroups));
            Add(10, "Attach Group to Applications", "", typeof(AttachGroupToApplications));
            Add(11, "EndProgram", "EndProgram", typeof(EndProgram));
            Add(12, "DocsList", "", typeof(DocsList));
            Add(13, "IntranetGo", "", typeof(IntranetGo));
            Add(14, "WebGo", "", typeof(WebGo));
            Add(15, "Lookup - Groups", "", typeof(LookupGroups));
            Add(16, "Lookup - Users", "", typeof(LookupUsers));
            Add(17, "Lookup - Applications", "", typeof(LookupApplications));
            Add(19, "Browse - Users", "", typeof(BrowseUsers));
            Add(20, "Browse - Groups", "", typeof(BrowseGroups));
            Add(21, "Browse - Applications", "", typeof(BrowseApplications));
            Add(22, "Browse - UserGroups", "", typeof(BrowseUserGroups));
            Add(23, "Browse - GroupApplications", "", typeof(BrowseGroupApplications));
            Add(24, "Browse - UserAccessList", "", typeof(BrowseUserAccessList));
            Add(25, "Browse - User Email Addresses", "", typeof(BrowseUserEmailAddresses));
            Add(26, "Browse - Control", "", typeof(BrowseControl));
            Add(28, "Export - Users", "", typeof(ExportUsers));
            Add(29, "Export - Groups", "", typeof(ExportGroups));
            Add(30, "Export - Applications", "", typeof(ExportApplications));
            Add(31, "Export - UserGroups", "", typeof(ExportUserGroups));
            Add(32, "Export - GroupApplications", "", typeof(ExportGroupApplications));
            Add(33, "Export - User Email Addresses", "", typeof(ExportUserEmailAddresses));
            Add(34, "Export - Control", "", typeof(ExportControl));
            Add(36, "Import - Users", "", typeof(ImportUsers));
            Add(37, "Import - Groups", "", typeof(ImportGroups));
            Add(38, "Import - Applications", "", typeof(ImportApplications));
            Add(39, "Import - UserGroups", "", typeof(ImportUserGroups));
            Add(40, "Import - GroupApplications", "", typeof(ImportGroupApplications));
            Add(41, "Import - User Email Addresses", "", typeof(ImportUserEmailAddresses));
            Add(42, "Import - Control", "", typeof(ImportControl));
            Add(45, "Access Control(pv July07)", "", typeof(AccessControlPvJuly07));
            Add(46, "Access Control(pv)", "", typeof(AccessControlPv));
            Add(47, "Maint - Users(pv)", "", typeof(MaintUsersPv));
            Add(50, "Access Control(dv raise event)", "", typeof(AccessControlDvRaiseEvent));
            Add(51, "Access Control(dvAP)", "", typeof(AccessControlDvAP));
            Add(52, "Maint - Users (dv)", "", typeof(MaintUsersDv));
            Add(54, "1 off Pop User Email Table", "", typeof(No1OffPopUserEmailTable));
            Add(56, "Access Control", "", typeof(AccessControl1));
            Add(59, "Access Control  DV", "", typeof(AccessControlDV));
            Add(60, "Access Control ORIGINAL", "", typeof(AccessControlORIGINAL));
            Add(61, "Access Control", "", typeof(AccessControl2));
        }
        
        
    }
}
