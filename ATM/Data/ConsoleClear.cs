using System;

namespace ATM.Data
{
    public class ConsoleClear : IDataClear
    {
        public void Clear()
        {
            Console.Clear();
        }
    }
}
