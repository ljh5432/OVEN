using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _1004
    {
        static string[] arry = { "가", "나", "다", "라", "마", "바", "사", "아" };
        static int i = 0;
        static Boolean change = false;

        void Main(string[] args)
        {
            Console.WriteLine("반복문!");

            /****************************************
             * 반복문 종류
             * for문 : for(;;) => (초기값 ; 조건식 ; 증감)
             * foreach문
             * while문
             ****************************************/

            Console.WriteLine("==================================");
            함수();
            Console.WriteLine("==================================");
            함수();

        }

        static void 함수()
        {
            for (; i == arry.Length - 9;)
            {              
                if (i == arry.Length)
                {
                    i = arry.Length - 1;
                    return;
                }

                if (i > arry.Length - 2)
                {
                    change = true;
                }

                Console.WriteLine("{0}번째 => {1}", i, arry[i]);

                if (!change)
                {
                    i = i + 2;
                }
                if (change)
                {
                    i = i - 2;
                }

            }
        }
        
    }
}
