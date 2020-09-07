using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;


namespace ConsoleApp4


{


    partial class Program
    {

        static void Main(String[] args)
        {

            Console.WriteLine("整数を入力してください");

            int num = int.Parse(Console.ReadLine());

            Sub2 s2 = new Sub2(num);

          


        }
    }
    
}
