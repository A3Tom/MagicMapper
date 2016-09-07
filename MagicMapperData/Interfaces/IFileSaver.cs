namespace MagicMapperData.Interfaces
{
    using Models;

    public interface IFileSaver
    {
        void WriteFiles_ToTextFile(FileDetail file);
        void WriteFiles_ToJSON(FileDetail file);
    }
}
