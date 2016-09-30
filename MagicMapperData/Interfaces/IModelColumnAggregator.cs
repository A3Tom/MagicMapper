namespace MagicMapperData.Interfaces
{
    using System.Collections.Generic;
    using Models;

    public interface IModelColumnAggregator
    {
        List<ModelDetails> Return_PopulatedModelDetails_ToList(List<ModelDetails> modelsUsed, List<string[]> columnsUsed);
    }
}
