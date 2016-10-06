namespace MagicMapperData.Interfaces
{
    using Models;
    using System.Collections.Generic;

    public interface IPabloEscobar
    {
        List<ClassDetails> Return_FileClassInfo_ToList(string[] lines);
        DataModelDetails Return_FileDataModelInfo_ToModel(string[] lines);
    }
}
