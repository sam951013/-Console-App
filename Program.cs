// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("請輸入您的名字：");
        string userName = Console.ReadLine();

        if (!string.IsNullOrEmpty(userName))
        {
            Console.WriteLine($"歡迎, {userName}!");
        }
        else
        {
            Console.WriteLine("您未輸入名字。");
        }
    }
}
