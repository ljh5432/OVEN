using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HomeWork
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            int minus = 0;
            Boolean value = false;
            int[] array = new int[31];

            for (int i=0; i<array.Length; i++)
            {
                array[i] = i+1;  // 배열에 값을 순차적으로 증가시켜 대입

                if (value == false) // 배열 끝까지 값이 대입될때까지 Boolean 상태를 false로 지정.
                { 
                    if (array[i]<10)  // 1~9까지 숫자가 입력될때 칸의 간격을 맞추기 위해 사용.
                    { 
                        Console.Write(" " + array[i] + " ");
                    }
                    else
                    {
                        Console.Write(array[i] + " ");
                    }
                }
                else
                {
                    Console.Write(" X" + " "); // 배열 끝까지 값이 대입된 경우 나머지는 " X" 칸으로 대입함.
                }

                cnt = cnt + 1;  // 현재 진행되는 ROW에서 몇번째 COL까지 진행되었는지 체크하는 cnt
                if (value != true && (i+1)%7 == 0) // 7로 나누어 나머지 0일 경우 다음줄로 출력하도록 라인을 바꿈.
                {
                    Console.WriteLine();
                    cnt = 0;
                }

                if(value != true && i == array.Length - 1) // array 배열에 끝까지 i값이 채워지면
                {
                    if(cnt != 0) { 
                        minus = 7 - cnt;  // 한줄에 7 COL으로 되어있으므로 나머지 채워야 하는 빈칸을 확인함.
                        i = i - minus;   // 현재의 for 루프가 빈칸 수만큼 추가로 돌수 있도록 i값을 빈칸 수만큼 감소시킴.
                        value = true;
                    }
                }

                
            }
            Console.WriteLine();
            Console.WriteLine();

            int[,] array2 = new int[5, 7];  // 5 x 7 의 2차원 배열을 생성.
            int cnt2 = 0;  // 순차적으로 증가하는 값을 대입하기 위한 int형 변수
            int row = 5;   // 행
            int col = 7;   // 열 

            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {

                    if (cnt2 < 31)  // 0~31까지만 값을 대입하도록 최대 범위를 제한함
                    {
                        array2[i, j] = cnt2 + 1;   // 배열에 값을 순차적으로 증가시켜 대입
                    }                    

                    if(array2[i, j] < 10)  // 1~9까지 숫자가 입력될때 칸의 간격을 맞추기 위해 사용.
                    { 
                        Console.Write(" " + array2[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(array2[i, j] + " ");
                    }

                    cnt2 = cnt2 + 1;

                    if (cnt2 % 7 == 0)  // 7로 나누어 나머지 0일 경우 다음줄로 출력하도록 라인을 바꿈.
                    {
                        Console.WriteLine();
                        //cnt2 = 0;
                    }

                }
            }
            Console.WriteLine();


        }
    }

}
