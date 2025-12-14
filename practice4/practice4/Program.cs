using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            string[] vars = { "파인애플", "사과", "바나나" };
            //string ba = "파인애플";
            //string ba2 = "사과";

            Console.WriteLine(vars[1]);
            Console.WriteLine(vars[vars.Length - 1]);

            // 2차원 배열 -> 1차원 배열을 여러개 가질 수 있다. 3차원 배열 -> 2차원 배열을 여러개 가질 수 있다.
            int[,] abc = { { 1, 2, 3 }, { 4, 5, 6 } }; // 배열의 크기가 일치해야함 { 1, 2, 3 }, { 4, 5 } -> 오류
            Console.WriteLine(abc[0, 0]); // 1
            Console.WriteLine(abc[1, 0]); // 4

            // 가변배열
            int[][] ab = new int[3][];
            ab[0] = new int[4];
            ab[1] = new int[4];
            ab[2] = new int[3];
            // int[,] abc = { { 1, 2, 3, 5 }, {4, 5, 6, 7}, { , , 4} }; 오류
            ab[2][2] = 4;

            Console.WriteLine(ab[2][2]);

            Console.WriteLine(ab[0][0]); // 0
            ab[0][0] = 4;
            Console.WriteLine(ab[0][0]); // 4

            Console.WriteLine("길이는?" + ab.Length);
        }
    }
}
