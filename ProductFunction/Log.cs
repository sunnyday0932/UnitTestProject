using System;
using System.Collections.Generic;
using System.Text;

namespace ProductFunction
{
    public class Log : ILog
    {
        public void SaveLog(string message)
        {
            Console.WriteLine(message);
        }

        public void Loop(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write(i);
            }
        }
    }
}
