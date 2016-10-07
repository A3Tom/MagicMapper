namespace MagicMapperData.Interfaces
{
    using Models;
    using System.Collections.Generic;

    public interface IProcessHandler
    {
        List<FileDetail> Return_CompleteModelDetailInfo_ToList(List<FileDetail> fileDetails);
    }
}
