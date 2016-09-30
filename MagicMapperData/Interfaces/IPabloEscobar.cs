namespace MagicMapperData.Interfaces
{
    using Models;
    using System.Collections.Generic;

    public interface IPabloEscobar
    {
        public List<ClassDetails> Return_FileClassInfo_ToList(string[] lines);
        public List<DataModelDetails> Return_FileDataModelInfo_ToList(string[] lines);
    }
}
