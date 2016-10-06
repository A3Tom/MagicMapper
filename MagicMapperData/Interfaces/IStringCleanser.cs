namespace MagicMapperData.Interfaces
{
    public interface IStringCleanser
    {
        string Return_ClassName_ToString(string line);
        string Return_ModelName_ToString(string line);
        string Return_RegionName_ToString(string line);
        string Return_ProgramName_ToString(string line);
        string Return_ParentClass_ToString(string line);
        string Return_NamespaceName_ToString(string line);
        string Return_ExternalCallName_ToString(string line);
        string Return_AddAdditionalParam_ToString(string line);

        string[] Return_AddedColumn_ToArray(string line);
        string[] Return_DataModelDetails_ToArray(string line);
        string[] Return_ExternalCallParams_ToArray(string line);
    }
}
