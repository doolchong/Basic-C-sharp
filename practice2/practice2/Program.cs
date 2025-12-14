using System;

namespace practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비주얼스튜디오의 단축키(자주사용)
            // Ctrl + K + C : 주석처리
            // Ctrl + K + U : 주석해제
            // 코드찾기 : Ctrl + F
            // 저장 : Ctrl + S
            // 빌드 : Ctrl + Shift + B
            // 실행 : Ctrl + F5
            // 단어단위 커서 이동 : Ctrl + 화살표

            int a = 5;
            int b = 6;
            b = a; // b에 a의 값을 저장
            string c = "";
            // 형변환을 통해 문자타입에 숫자를 저장하는 방법.
            c = a.ToString(); // 함수를 통해서 결과를 얻기

            Console.WriteLine(a);

            // string 문자열 타입에 5 -> int num
            int num = Int32.Parse(c);
            // num에 숫자타입으로 변경해서 저장

            Console.WriteLine(num);
        }
    }
}
