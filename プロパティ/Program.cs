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

            Sub s1 = new Sub();

            s1.Age = ansAge;

            int age = s1.Age;


            Console.WriteLine("あなたの年齢は" + age + "です。");


        }
    }
}
