// 1부터 100까지 3의 배수 또는 4의 배수의 합: 2551
using System;

namespace 제어문_배수의합
{
    class 제어문_배수의합
    {
        static void Main(string[] args)
        {
            //[1] 입력
            int sum = 0;

            //[2] 처리: 주어진 범위 + 주어진 조건
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) || (i % 4 == 0))
                {
                    sum += i;
                }
            }

            //[3] 출력
            Console.WriteLine("배수의 합 : {0}", sum);
        }
    }
}
