namespace MagicMapperData.Interfaces
{
    using Models;

    public interface IValidationRules
    {
        bool Validate_ObtainNamespaceHook_ToBool(string line);
        bool Validate_NewClassHook_ToBool(string line);
        bool Validate_ParentClassHook_ToBool(string line);
        bool Validate_NewColumnHook_ToBool(string line);
        bool Validate_NewModelHook_ToBool(string line);
        bool Validate_NewExternalCallHook_ToBool(string line);
        bool Validate_MultiParamatersReel_ToBool(string line);
        bool Validate_AddNewClass_ToBool(ClassDetails newClass);
        bool Validate_ObtainDataModelInfoHook_ToBool(string line);
    }

}
