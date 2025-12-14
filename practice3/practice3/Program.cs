using System;

namespace practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // 단항 연산자
            int a = 5;
            a++; // 1을 더해줌
            Console.WriteLine(-a);
            // 이항 연산자
            int b = 3;
            int c = 0;

            //c = a - b;
            c = a + b;
            Console.WriteLine(c);
            */

            /*
            // 삼항 연산자
            int c = (5 > 3) ? 2 : 0;
            Console.WriteLine(c);
            */

            /*
            // 대입 연산자
            int a = 5;
            int b = 6;
            b = a; // b에도 5값이 저장
            string str = "b" + "sbsdb" + b;
            Console.WriteLine(str);
            */

            /*
            // 산술 연산자
            int a = 4;
            int b = 2;

            // 덧셈 연산자 +
            int c = a + b; //6
            Console.WriteLine(c);
            Console.WriteLine(a + b);

            // 뺄셈 연산자 -
            c = a - b; // 2
            Console.WriteLine(c);

            // 곱셈 연산자 *
            c = a * b; // 8
            Console.WriteLine(c);

            // 나눗셈 연산자 /
            c = a / b; // 2
            Console.WriteLine(c);

            // 나머지 연산자 %
            c = a % b; // 0
            Console.WriteLine(c);
            */

            /*
            // 증감 연산자
            int a = 5;
            a++;
            Console.WriteLine(a++); // 6
            Console.WriteLine(a);   // 7
            Console.WriteLine(++a); // 8

            // 대입 연산자
            int b = 3;
            b += 2; // b = b + 2;
            Console.WriteLine(b);
            b *= 3; // b = b * 3;
            Console.WriteLine(b);
            */

            /*
            // 비교 연산자
            int a = 5;
            int b = 3;
            bool result = (a == b);
            Console.WriteLine(result);
            result = (a != b);
            Console.WriteLine(result);
            result = (a >= b);
            Console.WriteLine(result);
            result = (a <= b);
            Console.WriteLine(result);
            */

            /*
            // 조건 연산자
            int a = 3;
            int b = 4;
            string c = (a > b) ? "참입니다." : "거짓입니다.";
            Console.WriteLine(c);
            // 잠깐 상식: 숫자 1은 TRUE의 의미로, 숫자 0은 FALSE의 의미로 사용, -1은 오류상태로 많이 사용
            */

            /*
            // 논리 연산자
            bool result1 = true;
            bool result2 = 5 < 3;

            // ! 연산자는 NOT의 의미
            Console.WriteLine(!result1);

            // && 연산자는 둘 다 참일 때 참
            Console.WriteLine(result1 && result2);

            // || 연산자는 둘 중 하나만 참이어도 참
            Console.WriteLine(result1 || result2);
            */

            // 비트 연산자
            // 비트 연산자는 2진수 단위로 연산을 수행
            int a = 1; // 0001
            int b = 5; // 0101
            int c = 0; // 0000
            Console.WriteLine(a & b); // AND 연산: 0001 => 1
            Console.WriteLine(a | b); // OR 연산: 0101 => 5
            Console.WriteLine(a ^ b); // XOR 연산: 0100 => 4 0, 1이 다를 때 1

            a = a << 2; // 왼쪽으로 2비트 시프트: 0100 => 4, 1*2*2
            Console.WriteLine(a);
            a = a >> 1; // 오른쪽으로 1비트 시프트: 0010 => 2 4/2
            Console.WriteLine(a);

            b <<= 1; // 왼쪽으로 1비트 시프트: 1010 => 10, 5*2
            Console.WriteLine(b);
            b >>= 2; // 오른쪽으로 2비트 시프트: 0010 => 2, 10/2/2
            Console.WriteLine(b);
        }
    }
}
