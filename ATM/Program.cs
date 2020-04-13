using System;

namespace ATM
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //Console.Write("Enter start sum:");
        //    //int startSum = int.Parse(Console.ReadLine());

        //    //bool showMenu = true;
        //    //while (showMenu)
        //    //{
        //    //    showMenu = Menu(ref startSum);
        //    //}
        //}

        //done
        public static int WelcomeNotes()
        {
            Console.WriteLine("\t\tWelcome!\n");
            Console.WriteLine("1. Withdrawal of amount.");
            Console.WriteLine("2. Import of an amount.");
            Console.WriteLine("3. Checking the amount available in account.");
            Console.WriteLine("4. Change PIN.");
            Console.WriteLine("5. Exit.\n");
            Console.Write("Enter your choice:");

            return int.Parse(Console.ReadLine());
        }

        //done this 
        public static bool Menu(ref int startSum)
        {
            Console.Clear();

            int choice = WelcomeNotes();

            switch (choice)
            {
                case 1:
                    WithdrawalAmount(ref startSum);//done
                    SuccessfulOperationMessage();
                    ReturnMainMenu();
                    return true;
                case 2:
                    ImportMoney(ref startSum);
                    SuccessfulOperationMessage();
                    ReturnMainMenu();
                    return true;
                case 3:
                    AmountAvailable(startSum);
                    ReturnMainMenu();
                    return true;
                case 4:
                    ChangePIN();
                    SuccessfulOperationMessage();
                    ReturnMainMenu();
                    return true;
                case 5:
                    return false;
                default:
                    Console.WriteLine("Error! Try again.");
                    ReturnMainMenu();
                    return true;
            }
        }

        private static void ReturnMainMenu()
        {
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }

        //done
        public static void WithdrawalHelper()
        {
            Console.Clear();
            Console.WriteLine("Withdrawal Amount!\n");
            Console.WriteLine("How much money do you want to withdrawal?");
        }

        //done
        public static bool Validate(ref int startSum, int wanted)
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

        //done
        public static bool WithdrawalMenu(ref int startSum)
        {

            int choice = AmountAvailableMessage();

            switch (choice)
            {
                case 1:
                    return Validate(ref startSum, 20);
                case 2:
                    return Validate(ref startSum, 50);
                case 3:
                    return Validate(ref startSum, 100);
                case 4:
                    return Validate(ref startSum, 150);
                case 5:
                    return Validate(ref startSum, 200);
                case 6:
                    Console.Write("Enter amount of sum you want to withdrawal:");
                    var wanted = int.Parse(Console.ReadLine());
                    return Validate(ref startSum, wanted);
                case 7:
                    return false;
                default:
                    Console.WriteLine("Error! Try again. ");
                    WithdrawalAmount(ref startSum); // not sure rec
                    return false;
            }
        }

        // done
        public static void WithdrawalAmount(ref int startSum)
        {
            WithdrawalHelper();
            WithdrawalMenu(ref startSum);
        }

        // done
        public static int AmountAvailableMessage()
        {
            Console.Write("1. 20\t\t\t");
            Console.Write("2. 50\t\t\t");
            Console.WriteLine("3. 100\t\t\t");
            Console.Write("4. 150\t\t\t");
            Console.Write("5. 200\t\t\t");
            Console.WriteLine("6. Other");
            Console.WriteLine("7. Return to main menu.");
            Console.Write("Enter your choice:");
            return int.Parse(Console.ReadLine());
        }

        //done
        public static bool WithdrawalCheck(int sum, int wanted)
        {
            if (wanted > sum) return false;
            return true;
        }

        //done
        public static void NotEnoughMoneyMessage()
        {
            Console.WriteLine("You do not have enough money! ");
        }

        //done
        public static void SuccessfulOperationMessage()
        {
            Console.WriteLine("Successful operation! ");
        }

        //done
        public static void ImportMoney(ref int startSum)
        {
            ImportHelper();
            ImportMenu(ref startSum);
        }

        //done
        public static void ImportHelper()
        {
            Console.Clear();
            Console.WriteLine("How much money do you want to import?");
        }

        //done
        public static bool ImportMenu(ref int startSum)
        {
            int choice = AmountAvailableMessage();
            switch (choice)
            {
                case 1:
                    startSum += 20;
                    return true;
                case 2:
                    startSum += 50;
                    return true;
                case 3:
                    startSum += 100;
                    return true;
                case 4:
                    startSum += 150;
                    return true;
                case 5:
                    startSum += 200;
                    return true;
                case 6:
                    Console.Write("Enter amount of sum you want to import:");
                    var wanted = int.Parse(Console.ReadLine());
                    startSum += wanted;
                    return true;
                case 7:
                    //  Menu(ref startSum);
                    return false;
                default:
                    Console.WriteLine("Error! Try again. ");
                    //    startSum = ImportMoney(startSum);
                    return false;
            }
        }

        //done
        public static void AmountAvailable(int startSum)
        {
            Console.Clear();
            Console.WriteLine("Your account balance is " + startSum);
            //Console.WriteLine("Press 0 to return.");
            //int choice = int.Parse(Console.ReadLine());
            //if (choice == 0) Menu(ref startSum);
        }

        //done
        public static void ChangePIN()
        {
            Console.Write("Enter your current PIN:");
            var currentPIN = Console.ReadLine();
            var newPIN = string.Empty;

            do
            {
                Console.WriteLine("Note: Your PIN must be exactly 4 digit length.");
                Console.Write("Enter new PIN:");
                newPIN = Console.ReadLine();

            } while (newPIN.Length != 4 || !IsDigitsOnly(newPIN));

        }

        //done
        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
