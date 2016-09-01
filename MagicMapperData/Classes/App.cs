namespace MagicMapperData.Classes
{
    using Interfaces;
    using System;

    class App : IApp
    {
        private readonly ILog logger;
        private readonly IFileHandler fileHandler;

        public App(ILog logger, IFileHandler fileHandler)
        {
            this.logger = logger;
            this.fileHandler = fileHandler;
        }

        public void Run()
        {
            string filePath = @".\Tests\";

            try
            {
                fileHandler.GenerateAnalysisFile(filePath);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                logger.Error(ex.StackTrace);
            }
        }
    }
}
