using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] array = new string[6, 12];

            int row = 1;
            int col = 0;

            array[0, 0] = "불가";
            array[0, 1] = "불가";
            array[0, 2] = "불가";
            array[0, 3] = "불가";
            array[0, 4] = "불가";
            array[0, 5] = "불가";
            array[0, 6] = "불가";
            array[0, 7] = "불가";
            array[0, 8] = "가능";
            array[0, 9] = "가능";
            array[0, 10] = "가능";
            array[0, 11] = "불가";
            array[1, 0] = "가능";
            array[1, 1] = "불가";
            array[1, 2] = "가능";
            array[1, 3] = "가능";
            array[1, 4] = "가능";
            array[1, 5] = "불가";
            array[1, 6] = "가능";
            array[1, 7] = "불가";
            array[1, 8] = "가능";
            array[1, 9] = "불가";
            array[1, 10] = "가능";
            array[1, 11] = "불가";
            array[2, 0] = "가능";
            array[2, 1] = "가능";
            array[2, 2] = "가능";
            array[2, 3] = "불가";
            array[2, 4] = "가능";
            array[2, 5] = "불가";
            array[2, 6] = "가능";
            array[2, 7] = "불가";
            array[2, 8] = "가능";
            array[2, 9] = "불가";
            array[2, 10] = "가능";
            array[2, 11] = "가능";
            array[3, 0] = "불가";
            array[3, 1] = "불가";
            array[3, 2] = "가능";
            array[3, 3] = "불가";
            array[3, 4] = "가능";
            array[3, 5] = "불가";
            array[3, 6] = "가능";
            array[3, 7] = "가능";
            array[3, 8] = "가능";
            array[3, 9] = "불가";
            array[3, 10] = "가능";
            array[3, 11] = "불가";
            array[4, 0] = "불가";
            array[4, 1] = "불가";
            array[4, 2] = "불가";
            array[4, 3] = "가능";
            array[4, 4] = "가능";
            array[4, 5] = "불가";
            array[4, 6] = "가능";
            array[4, 7] = "불가";
            array[4, 8] = "가능";
            array[4, 9] = "불가";
            array[4, 10] = "가능";
            array[4, 11] = "불가";
            array[5, 0] = "불가";
            array[5, 1] = "불가";
            array[5, 2] = "불가";
            array[5, 3] = "불가";
            array[5, 4] = "가능";
            array[5, 5] = "가능";
            array[5, 6] = "가능";
            array[5, 7] = "불가";
            array[5, 8] = "불가";
            array[5, 9] = "불가";
            array[5, 10] = "가능";
            array[5, 11] = "종료";

            Console.WriteLine("현재좌표 위치 : {0},{1}", row, col);

            string input ="";

            while (true)
            {

                input = Console.ReadLine();
                    switch (input)
                    {
                        case "w":
                            Console.WriteLine("윗방향키가 눌렸습니다.");
                            row = row - 1;

                            if(row < 0 || row > 5)
                            {
                                Console.WriteLine("윗 방향키 누르면 row 인덱스가 0보다 작아져서 이동할수 없습니다. 실행을 취소합니다.");
                                Console.WriteLine("실패한 좌표 위치 : {0},{1}", row, col);
                                row = row + 1;
                                Console.WriteLine("현재 좌표 위치 : {0},{1}", row, col);
                            }
                            else if (array[row, col] == "가능")
                            {
                                Console.WriteLine("이동가능합니다.");
                                Console.WriteLine("이동한 현재 좌표 위치 : {0},{1}", row, col);
                            }
                            else if (array[row, col] == "불가")
                            {
                                Console.WriteLine("이동 불가합니다.");
                                Console.WriteLine("실패한 좌표 위치 : {0},{1}", row, col);
                                row = row + 1;
                                Console.WriteLine("현재 좌표 위치 : {0},{1}", row, col);
                            }
                            else if (array[row, col] == "종료")
                            {
                                Console.WriteLine("도착했습니다. 프로그램을 종료합니다.");
                                break;
                            }

                            break;
                        case "s":
                            Console.WriteLine("아랫방향키가 눌렸습니다.");
                            row = row + 1;

                            if (row < 0 || row > 5)
                            {
                                Console.WriteLine("아랫 방향키를 누르면 row 인덱스가 5보다 커지므로 이동할수 없습니다. 실행을 취소합니다.");
                                Console.WriteLine("실패한 좌표 위치 : {0},{1}", row, col);
                                row = row - 1;
                                Console.WriteLine("현재 좌표 위치 : {0},{1}", row, col);
                            }
                            else if (array[row, col] == "가능")
                            {
                                Console.WriteLine("이동가능합니다.");
                                Console.WriteLine("이동한 현재 좌표 위치 : {0},{1}", row, col);
                            }
                            else if (array[row, col] == "불가")
                            {
                                Console.WriteLine("이동 불가합니다.");
                                Console.WriteLine("실패한 좌표 위치 : {0},{1}", row, col);
                                row = row - 1;
                                Console.WriteLine("현재 좌표 위치 : {0},{1}", row, col);
                            }
                            else if (array[row, col] == "종료")
                            {
                                Console.WriteLine("도착했습니다. 프로그램을 종료합니다.");
                                break;
                            }

                            break;
                        case "a":
                            Console.WriteLine("왼쪽방향키가 눌렸습니다.");
                            col = col - 1;

                            if (col < 0 || col > 11)
                            {
                                Console.WriteLine("왼쪽 방향키를 누르면 col 인덱스가 0보다 작아지므로 이동할수 없습니다. 실행을 취소합니다.");
                                Console.WriteLine("실패한 좌표 위치 : {0},{1}", row, col);
                                col = col + 1;
                                Console.WriteLine("현재 좌표 위치 : {0},{1}", row, col);
                            }
                            else if  (array[row, col] == "가능")
                            {
                                Console.WriteLine("이동가능합니다.");
                                Console.WriteLine("이동한 현재 좌표 위치 : {0},{1}", row, col);
                            }
                            else if (array[row, col] == "불가")
                            {
                                Console.WriteLine("이동 불가합니다.");
                                Console.WriteLine("실패한 좌표 위치 : {0},{1}", row, col);
                                col = col + 1;
                                Console.WriteLine("현재 좌표 위치 : {0},{1}", row, col);
                            }
                            else if (array[row, col] == "종료")
                            {
                                Console.WriteLine("도착했습니다. 프로그램을 종료합니다.");
                                break;
                            }

                            break;
                        case "d":
                            Console.WriteLine("오른쪽 방향키가 눌렸습니다.");
                            col = col + 1;

                            if (col < 0 || col > 11)
                            {
                                Console.WriteLine("오른쪽 방향키를 누르면 col 인덱스가 11보다 커지므로 이동할수 없습니다. 실행을 취소합니다.");
                                Console.WriteLine("실패한 좌표 위치 : {0},{1}", row, col);
                                col = col - 1;
                                Console.WriteLine("현재 좌표 위치 : {0},{1}", row, col);
                            }
                            else if (array[row, col] == "가능")
                            {
                                Console.WriteLine("이동가능합니다.");
                                Console.WriteLine("이동한 현재 좌표 위치 : {0},{1}", row, col);
                            }
                            else if (array[row, col] == "불가")
                            {
                                Console.WriteLine("이동 불가합니다.");
                                Console.WriteLine("실패한 좌표 위치 : {0},{1}", row, col);
                                col = col - 1;
                                Console.WriteLine("현재 좌표 위치 : {0},{1}", row, col);
                            }
                            else if (array[row, col] == "종료")
                            {
                                Console.WriteLine("도착했습니다. 프로그램을 종료합니다.");
                                break;
                            }

                            break;

                    
                }
                Console.WriteLine();

            }
        }
    }
}
