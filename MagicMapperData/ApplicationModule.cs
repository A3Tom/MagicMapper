namespace MagicMapperData
{
    using NLog;
    using Ninject.Modules;
    using Classes;
    using Interfaces;
    using Models;

    class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILog>().ToMethod(x =>
            {
                var scope = x.Request.ParentRequest.Service.FullName;
                var log = (ILog)LogManager.GetLogger(scope, typeof(Log));
                return log;
            });
            Bind<IApp>().To<App>();
            Bind<IFileReader>().To<FileReader>();
            Bind<IFileWriter>().To<FileWriter>();
            Bind<IFileHandler>().To<FileHandler>();
            Bind<IFileLocator>().To<FileLocator>();
            Bind<IPabloEscobar>().To<PabloEscobar>();
            Bind<IProcessHandler>().To<ProcessHandler>();
            Bind<IStringCleanser>().To<StringCleanser>();
            Bind<IValidationRules>().To<ValidationRules>();
            Bind<IModelColumnAggregator>().To<ModelColumnAggregator>();
        }
    }
}
