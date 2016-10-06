namespace MagicMapperData.Interfaces
{
    using Models;
    using System.Collections.Generic;

    public interface IFileReader
    {
        List<FileDetail> ReadProgramFiles(List<FileDetail> fileList, string[] fileTypes);
    }
}
