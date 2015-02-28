using System.IO;
using System;

class Program
{
    static void Main()
    {
           string LICENSE_CONFIRM = "Согласны ли вы с условием лицензионного соглашения? (y/n)";
        
        string answ;
        
        Console.WriteLine(LICENSE_CONFIRM);
        answ = Console.ReadLine();
        answ = answ.ToLower();
        if (answ.IndexOf("y") != -1) {
            Console.WriteLine("Good!");
        } else {
            Console.WriteLine("Ok, it is your thoose");
        }
        
        Console.ReadLine();
    }
}
