namespace MagicMapperData.Interfaces
{
    using Models;
    using System.Collections.Generic;

    public interface IFileReader
    {
        void ReadProgramFiles(List<FileDetail> fileList, string[] fileTypes);
    }
}
