namespace MagicMapperData.Classes
{
    using Interfaces;

    class FileHandler : IFileHandler
    {
        private readonly IFileLocator fileLocator;
        private readonly IFileReader fileReader;
        private readonly IFileParser fileParser;
        private readonly IFileSaver fileSaver;

        public FileHandler(IFileLocator fileLocator, IFileReader fileReader, IFileParser fileParser, IFileSaver fileSaver)
        {

        }
    }
}
