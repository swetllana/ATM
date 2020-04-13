namespace ATM.Services
{
    public interface IWithdrawaler : IOptionsAvailable
    {
        void WithdrawalAmount(ref int startSum);
    }
}
