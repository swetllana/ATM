using System;

namespace ATM.Data
{
    public class ConsoleDataReader : IDataReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
