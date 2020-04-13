namespace ATM
{
    public class Constants
    {
        //welcome messages Main Menu
        public const string WELCOME_MESSAGE = "\t\tWelcome!\n";
        public const string MAIN_MENU_OPTION_ONE = "1. Withdrawal of amount.";
        public const string MAIN_MENU_OPTION_TWO = "2. Import of an amount.";
        public const string MAIN_MENU_OPTION_THREE = "3. Checking the amount available in account.";
        public const string MAIN_MENU_OPTION_FOUR = "4. Change PIN.";
        public const string MAIN_MENU_OPTION_FIVE = "5. Exit.\n";

        //amount
        public const string AMOUNT_AVAILABLE_MESSAGE = "Your account balance is ";

        //PIN
        public const string ENTER_CURRENT_PIN_MESSAGE = "Enter your current PIN:";
        public const string NOTE_PIN_MESSAGE = "Note: Your PIN must be exactly 4 digit length.";
        public const string ENTER_NEW_PIN_MESSAGE = "Enter new PIN:";

        //Digit
        public const char ZERO = '0';
        public const char NINE = '9';

        //amount available messages
        public const string OPTION_ONE_MESSAGE = "1. 20\t\t\t";
        public const string OPTION_TWO_MESSAGE = "2. 50\t\t\t";
        public const string OPTION_THREE_MESSAGE = "3. 100\t\t\t";
        public const string OPTION_FOUR_MESSAGE = "4. 150\t\t\t";
        public const string OPTION_FIVE_MESSAGE = "5. 200\t\t\t";
        public const string OPTION_SIX_MESSAGE = "6. Other";
        public const string OPTION_SEVEN_MESSAGE = "7. Return to main menu.";

        //general
        public const string ENTER_CHOICE_MESSAGE = "\nEnter your choice:";
        public const string ERROR_MESSAGE = "Error! Try again. ";
        public const string RETURN_MAIN_MENU_MESSAGE = "\r\n\nPress Enter to return to Main Menu: ";
        public const string SUCCESSFUL_MESSAGE = "Successful operation! ";
        public const string ENTER_START_SUM_MESSAGE = "Enter start sum:";
        public const string NOT_ENOUGH_MONEY_MESSAGE = "You do not have enough money! ";

        // money to import
        public const string MONEY_TO_IMPORT_QUESTION = "How much money do you want to import?\n";
        public const string MONEY_TO_IMPORT_MESSAGE = "Enter amount of sum you want to import:";

        // money to withdrawal
        public const string MONEY_TO_WITHDRAWAL_QUESTION = "How much money do you want to withdrawal?";
        public const string MONEY_TO_WITHDRAWAL_MESSAGE = "Enter amount of sum you want to withdrawal:";

        //money options
        public const int MONEY_OPTION_ONE = 20;
        public const int MONEY_OPTION_TWO = 50;
        public const int MONEY_OPTION_THREE = 100;
        public const int MONEY_OPTION_FOUR = 150;
        public const int MONEY_OPTION_FIVE = 200;
    }
}
