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
using Firefly.Box;
using ENV.Data;
using ENV;
namespace MandCo.SystemAccess
{
    
    /// <summary>Main Program(P#1)</summary>
    // Last change before Migration: 28/10/2013 16:48:12
    public class Application : ApplicationControllerBase 
    {
        Views.ApplicationMdi _mdi;
        
        
        /// <summary>Main Program(P#1)</summary>
        public Application()
        {
            #region Initialize CachedControllers
            
            #endregion
            Title = "Main Program";
            _applicationPrograms = _staticPrograms;
            _applicationEntities = _staticEntities;
        }
        protected override void OnStart()
        {
            new AccessControl().Run();
        }
        protected override void OnEnd()
        {
            Invoke(Command.ExitApplication);
        }
        
        #region Run Methods
        public static void Run()
        {
            while(RunApplication)
            {
                RunApplication = false;
                Instance._mdi = new Views.ApplicationMdi();
                Instance.Run(Instance._mdi, ()=>Instance);
                Context.Current[typeof(Application)] = null;
            }
        }
        protected override void Execute()
        {
            ENV.Security.UserManager.Load();
            if(!ENV.Security.UserManager.ShowLoginDialog(false))
            {
                return;
            }
            if(Roles.Administrator.Allowed && UserSettings.EditSecuredValues)
            {
                ENV.Security.UserManager.ManageSecuredValues();
            }
            #if DEBUG
            Common.EnableDeveloperTools = Roles.Administrator.Allowed;
            #endif
            ;
            Common.BindStatusBar(_mdi.mainStatusLabel, _mdi.userStatusLabel, _mdi.activityStatusLabel, _mdi.expandStatusLabel, _mdi.expandTextBoxStatusLabel, _mdi.insertOverrideStatusLabel, _mdi.versionStatusLabel);
            _mdi.InitUserBasedMenus();
            base.Execute();
        }
        #endregion
        
        #region Instance Management
        
        /// <summary>Main Program(P#1)</summary>
        static Application()
        {
            DebugHelper.Init();
        }
        #endregion
        
        #region Init Programs and Entities Collection
        protected override ProgramCollection LoadAllProgramsCollection()
        {
            if(_staticPrograms==null)
            {
                _staticPrograms = new ApplicationPrograms();
            }
            return _staticPrograms;
        }
        protected override ApplicationEntityCollection LoadAllEntitiesCollection()
        {
            if(_staticEntities==null)
            {
                _staticEntities = new ApplicationEntities();
            }
            return _staticEntities;
        }
        #endregion
        
        
        #region Instance Management
        public static Application Instance 
        {
            get
            {
                var result = Context.Current[typeof(Application)] as Application;
                if(result == null)
                {
                    result = new Application();
                    Context.Current[typeof(Application)] = result;
                }
                return result;
            }
        }
        static ApplicationPrograms _staticPrograms;
        static ApplicationEntities _staticEntities;
        #endregion
        
    }
}
