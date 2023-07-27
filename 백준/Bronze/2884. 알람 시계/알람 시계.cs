using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int H = int.Parse(input[0]);
        int M = int.Parse(input[1]);

        // 45분을 뺄 때 음수가 되면 시간을 23으로 조정하고, 아니면 그대로 사용
        H -= (M < 45) ? 1 : 0;
        H = (H + 24) % 24; // 음수가 되는 경우를 처리하기 위해 24로 나눈 나머지를 구함
        M = (M + 60 - 45) % 60; // 음수가 되는 경우를 처리하기 위해 60으로 나눈 나머지를 구함

        Console.WriteLine($"{H} {M}");
    }
}
