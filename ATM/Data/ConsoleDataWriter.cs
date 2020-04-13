using System;

namespace ATM.Data
{
    public class ConsoleDataWriter : IDataWriter
    {
        public void WriteLine(object obj)
        {
            Console.WriteLine(obj);
        }

        public void Write(object obj)
        {
            Console.Write(obj);
        }
    }
}
