namespace ATM.Data
{
    public interface IDataWriter
    {
        void Write(object obj);

        void WriteLine(object obj);
    }
}
