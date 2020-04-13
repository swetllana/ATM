using ATM.Data;

namespace ATM.Services
{
    public class Amount : IAmountChecker
    {
        private readonly IDataWriter dataWriter;
        private readonly IDataClear dataClear;

        public Amount(
            IDataWriter dataWriter,
            IDataClear dataClear)
        {
            this.dataWriter = dataWriter;
            this.dataClear = dataClear;
        }

        public void AmountAvailable(int startSum)
        {
            dataClear.Clear();
            dataWriter.WriteLine(Constants.AMOUNT_AVAILABLE_MESSAGE + startSum);
        }
    }
}
