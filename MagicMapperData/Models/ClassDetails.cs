namespace MagicMapperData.Models
{
    using System.Collections.Generic;

    public class ClassDetails
    {
        public string Name;
        public string ParentClass;

        public List<ModelDetails> Models;
        public List<ExternalClassCall> ProgramCalls;
    }
}
