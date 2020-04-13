using ATM.Data;
using ATM.Enums;

namespace ATM.Services
{
    public class Import : IImporter
    {
        private readonly IDataReader dataReader;
        private readonly IDataWriter dataWriter;
        private readonly IDataClear dataClear;

        public Import(
            IDataReader dataReader,
            IDataWriter dataWriter,
            IDataClear dataClear)
        {
            this.dataReader = dataReader;
            this.dataWriter = dataWriter;
            this.dataClear = dataClear;
        }

        public void ImportMoney(ref int startSum)
        {
            ImportHelper();
            ImportMenu(ref startSum);
        }

        private void ImportHelper()
        {
            dataClear.Clear();
            dataWriter.WriteLine(Constants.MONEY_TO_IMPORT_QUESTION);
        }

        private bool ImportMenu(ref int startSum)
        {
            int choice = AmountAvailableOptions();
            switch (choice)
            {
                case (int)SwitchOptions.One:
                    startSum += Constants.MONEY_OPTION_ONE;
                    return true;
                case (int)SwitchOptions.Two:
                    startSum += Constants.MONEY_OPTION_TWO;
                    return true;
                case (int)SwitchOptions.Three:
                    startSum += Constants.MONEY_OPTION_THREE;
                    return true;
                case (int)SwitchOptions.Four:
                    startSum += Constants.MONEY_OPTION_FOUR;
                    return true;
                case (int)SwitchOptions.Five:
                    startSum += Constants.MONEY_OPTION_FIVE;
                    return true;
                case (int)SwitchOptions.Six:
                    dataWriter.Write(Constants.MONEY_TO_IMPORT_MESSAGE);
                    var wanted = int.Parse(dataReader.ReadLine());
                    startSum += wanted;
                    return true;
                case (int)SwitchOptions.Seven:
                    return false;
                default:
                    dataWriter.WriteLine(Constants.ERROR_MESSAGE);
                    return false;
            }
        }

        public int AmountAvailableOptions()
        {
            dataWriter.Write(Constants.OPTION_ONE_MESSAGE);
            dataWriter.Write(Constants.OPTION_TWO_MESSAGE);
            dataWriter.WriteLine(Constants.OPTION_THREE_MESSAGE);
            dataWriter.Write(Constants.OPTION_FOUR_MESSAGE);
            dataWriter.Write(Constants.OPTION_FIVE_MESSAGE);
            dataWriter.WriteLine(Constants.OPTION_SIX_MESSAGE);
            dataWriter.WriteLine(Constants.OPTION_SEVEN_MESSAGE);
            dataWriter.Write(Constants.ENTER_CHOICE_MESSAGE);
            return int.Parse(dataReader.ReadLine());
        }
    }
}