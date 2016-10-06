namespace MagicMapperData.Interfaces
{
    using Models;
    using System.Collections.Generic;

    public interface IFileReader
    {
<<<<<<< HEAD
<<<<<<< HEAD
        void ReadProgramFiles_ToList(List<FileDetail> fileList, string[] fileTypes);
=======
        List<FileDetail> ReadProgramFiles(List<FileDetail> fileList, string[] fileTypes);
>>>>>>> overhaul
=======
        List<FileDetail> ReadProgramFiles(List<FileDetail> fileList, string[] fileTypes);
>>>>>>> OverhaulConflictMerge
    }
}
