using ATM.Data;
using ATM.Enums;
using ATM.Models;

namespace ATM.Services
{
    public class Menu : IMenuOption
    {
        public Options Options { get; set; }

        private readonly IDataReader dataReader;
        private readonly IDataWriter dataWriter;
        private readonly IDataClear dataClear;


        public Menu(
            IDataReader dataReader,
            IDataWriter dataWriter,
            IDataClear dataClear)
        {
            this.dataReader = dataReader;
            this.dataWriter = dataWriter;
            this.dataClear = dataClear;
        }

        private Options Initialize()
        {
            var options = new Options();

            var withdrawal = new Withdrawal(dataReader, dataWriter, dataClear);
            var import = new Import(dataReader, dataWriter, dataClear);
            var amount = new Amount(dataWriter, dataClear);
            var pin = new PIN(dataReader, dataWriter);

            options.Withdrawal = withdrawal;
            options.Import = import;
            options.Amount = amount;
            options.PIN = pin;

            return options;
        }

        //TODO
        public bool MainMenu(ref int startSum)
        {
            var options = Initialize();

            dataClear.Clear();
            int choice = WelcomeNotes();

            switch (choice)
            {
                case (int)Choice.Withdrawal:
                    options.Withdrawal.WithdrawalAmount(ref startSum);
                    SuccessAndReturn();
                    return true;
                case (int)Choice.Import:
                    options.Import.ImportMoney(ref startSum);
                    SuccessAndReturn();
                    return true;
                case (int)Choice.Amount:
                    options.Amount.AmountAvailable(startSum);
                    SuccessAndReturn();
                    return true;
                case (int)Choice.PIN:
                    options.PIN.ChangePIN();
                    SuccessAndReturn();
                    return true;
                case (int)Choice.Exit:
                    return false;
                default:
                    dataWriter.WriteLine(Constants.ERROR_MESSAGE);
                    ReturnMainMenu();
                    return true;
            }
        }

        private void SuccessAndReturn()
        {
            SuccessfulOperationMessage();
            ReturnMainMenu();
        }

        private void ReturnMainMenu()
        {
            dataWriter.Write(Constants.RETURN_MAIN_MENU_MESSAGE);
            dataReader.ReadLine();
        }

        private int WelcomeNotes()
        {
            dataWriter.WriteLine(Constants.WELCOME_MESSAGE);
            dataWriter.WriteLine(Constants.MAIN_MENU_OPTION_ONE);
            dataWriter.WriteLine(Constants.MAIN_MENU_OPTION_TWO);
            dataWriter.WriteLine(Constants.MAIN_MENU_OPTION_THREE);
            dataWriter.WriteLine(Constants.MAIN_MENU_OPTION_FOUR);
            dataWriter.WriteLine(Constants.MAIN_MENU_OPTION_FIVE);
            dataWriter.Write(Constants.ENTER_CHOICE_MESSAGE);

            return int.Parse(dataReader.ReadLine());
        }

        private void SuccessfulOperationMessage()
        {
            dataWriter.WriteLine(Constants.SUCCESSFUL_MESSAGE);
        }
    }
}
