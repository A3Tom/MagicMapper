namespace MagicMapperData.Classes
{
    using Interfaces;

    class App : IApp
    {
        private readonly IFileHandler fileHandler;

        public App(IFileHandler fileHandler)
        {
            this.fileHandler = fileHandler;
        }

        public void Run()
        {

        }
    }
}
