namespace MagicMapperData.Classes
{
    using Models;
    using Interfaces;
    using System.Collections.Generic;
    using System.Text;

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

            ExternalClassCall newExternalClassCall = new ExternalClassCall();
            List<ExternalClassCall> externalClassCalls = new List<ExternalClassCall>();

            List<string[]> columnsUsed = new List<string[]>();

            string formattedString;
            string[] formattedArray;

            bool readExternalParams = false;

            StringBuilder sb = new StringBuilder();

            foreach (string line in lines)
            {


                //New Class
                if (validateRule.Validate_NewClassHook_ToBool(line))
                {
                    //Sort cols into models
                    newClass.Models = modelColumnAggregator.Return_PopulatedModelDetails_ToList(modelsUsed, columnsUsed);

                    if (externalClassCalls.Count != 0)
                        newClass.ExternalCalls = externalClassCalls;

                    if (validateRule.Validate_AddNewClass_ToBool(newClass))
                        newClasses.Add(newClass);

                    newClass = new ClassDetails();
                    newClass.Name = stringCleanser.Return_ClassName_ToString(line);

                    externalClassCalls = new List<ExternalClassCall>();
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
                    formattedArray = stringCleanser.Return_AddedColumn_ToArray(line);
                    if (!columnsUsed.Contains(formattedArray))
                        columnsUsed.Add(formattedArray);
                }

                //New Model
                if (validateRule.Validate_NewModelHook_ToBool(line))
                {
                    newModel = new ModelDetails();
                    formattedString = stringCleanser.Return_ModelName_ToString(line);
                    newModel.ModelName = formattedString;

                    modelsUsed.Add(newModel);
                }

                //New External Call 
                if (validateRule.Validate_NewExternalCallHook_ToBool(line))
                {
                    newExternalClassCall = new ExternalClassCall();

                    formattedString = stringCleanser.Return_ExternalCallName_ToString(line);
                    newExternalClassCall.ClassName = formattedString;

                    if (validateRule.Validate_MultiParamatersReel_ToBool(line))
                    {
                        readExternalParams = true;
                    }
                    else
                    {
                        formattedArray = stringCleanser.Return_ExternalCallParams_ToArray(line);
                        newExternalClassCall.RunArguments = formattedArray;
                        externalClassCalls.Add(newExternalClassCall);
                    }


                }

                //Read parameters passed into external call
                if (readExternalParams)
                {
                    sb.Append(stringCleanser.Return_AddAdditionalParam_ToString(line));

                    if (!validateRule.Validate_MultiParamatersReel_ToBool(line))
                    {
                        readExternalParams = false;
                        formattedArray = stringCleanser.Return_ExternalCallParams_ToArray(sb.ToString());
                        newExternalClassCall.RunArguments = formattedArray;
                        externalClassCalls.Add(newExternalClassCall);
                        sb.Clear();
                    }
                }
            }
            return newClasses;
        }

        public DataModelDetails Return_FileDataModelInfo_ToModel(string[] lines)
        {
            DataModelDetails dataModelDetails = new DataModelDetails();

            foreach (string line in lines)
            {
                if (validateRule.Validate_ObtainDataModelInfoHook_ToBool(line))
                {
                    string[] formattedDetails = stringCleanser.Return_DataModelDetails_ToArray(line);

                    dataModelDetails.LiteralDatabaseName = formattedDetails[0];
                    dataModelDetails.ModelName = formattedDetails[1];
                    dataModelDetails.DataSource = formattedDetails[2];
                }
            }

            return dataModelDetails;
        }


    }
}
