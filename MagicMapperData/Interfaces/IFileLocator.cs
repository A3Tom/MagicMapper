namespace MagicMapperData.Interfaces
{
    using System.Collections.Generic;
    using Models;

    public interface IFileLocator
    {
        List<FileDetail> LocateAllFiles(string filePath);
    }
}
