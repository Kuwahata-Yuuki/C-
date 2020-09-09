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

            Sub2 s2 = new Sub2();

            Console.WriteLine("年齢を入力してください");

            int ansAge = int.Parse(Console.ReadLine());

            s2.setAge(ansAge);

            int age = s2.Age;

            Console.WriteLine("あなたの年齢は" + age + "です");


        }

        
    }
    
}
