using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;


namespace ConsoleApp4


{ 

   
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("年齢を入力してください");

            int ansAge = int.Parse(Console.ReadLine());

           

           Sub.age = ansAge;

            int age2 = Sub.age;


            Console.WriteLine("あなたの年齢は" + age2 + "です。");


        }
    }
}
