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
using ENV.IO;
using ENV.Printing;
using ENV;
namespace MandCo.SystemAccess
{
    public static class DebugHelper
    {
        
        
        #region Debug Setup
        public static void Init()
        {
            if(_inited)
            {
                return;
            }
            _inited = true;
            ENV.Advanced.HandlerCollectionWrapper.BeforeHandler += HandlerInvokes;
            ControllerBase.BeforeExecute += ControllerExecute;
            ReportSection.BeforeWrite += SectionWrite;
            TextSection.BeforeWrite += SectionWrite;
            TextTemplate.BeforeWrite += SectionWrite;
            TextSection.BeforeRead += SectionRead;
        }
        #endregion
        
        static void HandlerInvokes(object handler)
        {
            // Add break point to break before handler execition. Press F10 to go to handler code
        }
        static void ControllerExecute(ControllerBase controller)
        {
            // Add break point to break on all controller exection
        }
        static void SectionWrite()
        {
            // Add break point to break on all section write to printer or file
        }
        static void SectionRead()
        {
            // Add break point to break on all section read from file
        }
        
        static bool _inited;
        
    }
}
