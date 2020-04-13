using ATM.Data;

namespace ATM.Services
{
    public class PIN : IPINChanger
    {
        private readonly IDataReader dataReader;
        private readonly IDataWriter dataWriter;

        public PIN(
            IDataReader dataReader,
            IDataWriter dataWriter
           )
        {
            this.dataReader = dataReader;
            this.dataWriter = dataWriter;
        }

        public void ChangePIN()
        {
            dataWriter.Write(Constants.ENTER_CURRENT_PIN_MESSAGE);
            var currentPIN = dataReader.ReadLine();
            var newPIN = string.Empty;

            do
            {
                dataWriter.WriteLine(Constants.NOTE_PIN_MESSAGE);
                dataWriter.Write(Constants.ENTER_NEW_PIN_MESSAGE);
                newPIN = dataReader.ReadLine();
            } while (newPIN.Length != 4 || !IsDigitsOnly(newPIN));

        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < Constants.ZERO || c > Constants.NINE)
                    return false;
            }

            return true;
        }
    }
}
