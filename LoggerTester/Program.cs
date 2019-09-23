using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Logger;

namespace LoggerTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new AppLogger(@"D:\test.txt");
            //logger.SaveDirectory(@"D:\Krzys");
            ////logger.Save(@"D:\test.txt");
            //string[] text = {"Anna","Roman"};
            //logger.Write(text);
            logger.Delete(@"D\Krzys\1.txt");
            Console.Read();
        }
    }
}
