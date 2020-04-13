namespace ATM.Services
{
    public interface IImporter : IOptionsAvailable
    {
        void ImportMoney(ref int startSum);
    }
}
