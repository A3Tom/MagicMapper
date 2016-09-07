namespace MagicMapperData.Models
{
    using System.Collections.Generic;

    public class ClassDetails
    {
        public string Name;
        public string ProgramName;
        public string ParentClass;

        public List<string> ModelsUsed;
        public List<string[]> ColumnsUsed;
    }
}
