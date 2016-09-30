namespace MagicMapperData.Classes
{
    using Models;
    using Interfaces;
    using System.Collections.Generic;

    class PabloEscobar : IPabloEscobar
    {
        private readonly ILog logger;
        private readonly IValidationRules validateRule;
        private readonly IModelColumnAggregator modelColumnAggregator;
        private readonly IStringCleanser stringCleanser;

        public PabloEscobar(ILog logger, IValidationRules validateRule, IModelColumnAggregator modelColumnAggregator, IStringCleanser stringCleanser)
        {
            this.logger = logger;
            this.validateRule = validateRule;
            this.modelColumnAggregator = modelColumnAggregator;
            this.stringCleanser = stringCleanser;
        }

        public List<ClassDetails> Return_FileClassInfo_ToList(string[] lines)
        {
            ClassDetails newClass = new ClassDetails();
            List<ClassDetails> newClasses = new List<ClassDetails>();
            ModelDetails newModel = new ModelDetails();
            List<ModelDetails> modelsUsed = new List<ModelDetails>();
            List<string[]> columnsUsed = new List<string[]>();

            string formattedLine;
            string[] formattedColumn;

            foreach (string line in lines)
            {
                //New Class
                if (validateRule.Validate_NewClassHook_ToBool(line))
                {
                    //Sort cols into models
                    newClass.Models = modelColumnAggregator.Return_PopulatedModelDetails_ToList(modelsUsed, columnsUsed);

                    if (validateRule.Validate_AddNewClass_ToBool(newClass))
                        newClasses.Add(newClass);

                    newClass = new ClassDetails();
                    newClass.Name = stringCleanser.Return_ClassName_ToString(line);

                    modelsUsed = new List<ModelDetails>();
                    columnsUsed = new List<string[]>();
                }

                //Declare Parent Class
                if (validateRule.Validate_ParentClassHook_ToBool(line))
                {
                    newClass.ParentClass = stringCleanser.Return_ParentClass_ToString(line);
                }

                //New Column
                if (validateRule.Validate_NewColumnHook_ToBool(line))
                {
                    formattedColumn = stringCleanser.Return_AddedColumn_ToArray(line);
                    if (!columnsUsed.Contains(formattedColumn))
                        columnsUsed.Add(formattedColumn);
                }

                //New Model
                if (validateRule.Validate_NewModelHook_ToBool(line))
                {
                    newModel = new ModelDetails();
                    formattedLine = stringCleanser.Return_ModelName_ToString(line);
                    newModel.ModelName = formattedLine;

                    modelsUsed.Add(newModel);
                }
            }
            return newClasses;
        }

        public List<DataModelDetails> Return_FileDataModelInfo_ToList(string[] lines)
        {
            List<DataModelDetails> dataModelDetails = new List<DataModelDetails>();



            return dataModelDetails;
        }


    }
}
