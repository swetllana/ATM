using ATM.Data;
using ATM.Models;
using ATM.Services;
using System;

namespace ATM
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var atm = new Atm();

            var dataReader = new ConsoleDataReader();
            var dataWriter = new ConsoleDataWriter();
            var dataClear = new ConsoleClear();
            var options = new Options();
            var menu = new Menu(dataReader, dataWriter, dataClear);

            Console.Write(Constants.ENTER_START_SUM_MESSAGE);
            var startSum = int.Parse(Console.ReadLine());

            atm.StartSum = startSum;
            atm.Menu = menu;
            atm.Menu.Options = options;

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = atm.Menu.MainMenu(ref startSum);
            }
        }
    }
}
