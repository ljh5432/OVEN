using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        void Main(string[] args)
        {
            Console.WriteLine("배열!");
            string a = "가";
            string b = "나";
            string c = "다";
            string d = "라";
            string e = "마";
            string f = "바";
            string g = "사";
            string h = "아";
            Console.WriteLine(d);

            string[] arry = {"가", "나", "다", "라", "마", "바", "사", "아"};
            Console.WriteLine(arry[4 - 1]);
            Console.WriteLine(arry[7]);
            arry[7] = "자";
            Console.WriteLine(arry[7]);

            string aa; // 선언
            aa = "가";  // 할당

            string[] arry2 = new string[1];
            arry2[0] = "가"; // 할당
            // arry2[1] = "나";

            string result = arry[2] + arry2[0];
            Console.WriteLine(result);

            Console.WriteLine(arry); // 데이터 타입 출력됨.

            
        }
    }
}
