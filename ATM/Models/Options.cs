using ATM.Services;

namespace ATM.Models
{
    public class Options
    {
        public Withdrawal Withdrawal { get; set; }

        public Import Import { get; set; }

        public Amount Amount { get; set; }

        public PIN PIN { get; set; }
    }
}
