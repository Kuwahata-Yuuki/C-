using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("文字列を入力してください。改行するときは半角スペースを入力してください");

            String ans = Console.ReadLine();

            String[] anss = ans.Split("　");

            foreach(String fans in anss){
                Console.WriteLine(fans);
            }



        }
    }
}
