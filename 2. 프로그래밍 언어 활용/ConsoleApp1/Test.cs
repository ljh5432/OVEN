using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Test
    {
        static string[] arry = { "가", "나", "다", "라", "마", "바", "사", "아" };

        void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Print(true);
            Console.WriteLine("==================================");
            Print(false);
        }

        void Print(bool type)
        {
            int i = 0;
            int start = 0;
            int end = (arry.Length - 1);
            if (!type)
            {
                i = end;
            }
            for (; start <= end;)
            {
                Console.WriteLine("{0}번째 => {1}", i, arry[i]);
                if (type)
                {
                    start = start + 2;
                    i = start;
                }
                else
                {
                    end = end - 2;
                    i = end;
                }
            }
        }

    }
}
