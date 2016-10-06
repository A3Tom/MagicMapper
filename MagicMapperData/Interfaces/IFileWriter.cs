namespace MagicMapperData.Interfaces
{
    using Models;
    using System.Collections.Generic;

    public interface IFileWriter
    {
        void WriteFiles_ToJSON(List<FileDetail> files);
    }
}
