using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example.Cmd
{
    internal class Util
    {
        public static int ReadInt(string i)
        {
            int value;
            while (true)
            {
                Console.WriteLine(i);
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }

                Console.WriteLine("Invalid input"); // 无效输入提示
            }
        }

    }
}
