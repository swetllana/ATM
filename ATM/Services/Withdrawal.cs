using ATM.Data;
using ATM.Enums;

namespace ATM.Services
{
    public class Withdrawal : IWithdrawaler
    {
        private readonly IDataReader dataReader;
        private readonly IDataWriter dataWriter;
        private readonly IDataClear dataClear;

        public Withdrawal(
            IDataReader dataReader,
            IDataWriter dataWriter,
            IDataClear dataClear)
        {
            this.dataReader = dataReader;
            this.dataWriter = dataWriter;
            this.dataClear = dataClear;
        }

        public void WithdrawalAmount(ref int startSum)
        {
            WithdrawalHelper();
            WithdrawalMenu(ref startSum);
        }

        private void WithdrawalHelper()
        {
            dataClear.Clear();
            dataWriter.WriteLine(Constants.MONEY_TO_WITHDRAWAL_QUESTION);
        }

        //TODO
        private bool WithdrawalMenu(ref int startSum)
        {
            int choice = AmountAvailableOptions();

            switch (choice)
            {
                case (int)SwitchOptions.One:
                    return Validate(ref startSum, Constants.MONEY_OPTION_ONE);
                case (int)SwitchOptions.Two:
                    return Validate(ref startSum, Constants.MONEY_OPTION_TWO);
                case (int)SwitchOptions.Three:
                    return Validate(ref startSum, Constants.MONEY_OPTION_THREE);
                case (int)SwitchOptions.Four:
                    return Validate(ref startSum, Constants.MONEY_OPTION_FOUR);
                case (int)SwitchOptions.Five:
                    return Validate(ref startSum, Constants.MONEY_OPTION_FIVE);
                case (int)SwitchOptions.Six:
                    dataWriter.Write(Constants.MONEY_TO_WITHDRAWAL_MESSAGE);
                    var wanted = int.Parse(dataReader.ReadLine());
                    return Validate(ref startSum, wanted);
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

        private bool Validate(ref int startSum, int wanted)
        {
            if (WithdrawalCheck(startSum, wanted))
            {
                startSum -= wanted;
                return true;
            }
            else
            {
                NotEnoughMoneyMessage();
                return false;
            }
        }

        private bool WithdrawalCheck(int sum, int wanted)
        {
            if (wanted > sum) return false;
            return true;
        }

        private void NotEnoughMoneyMessage()
        {
            dataWriter.WriteLine(Constants.NOT_ENOUGH_MONEY_MESSAGE);
        }
    }
}