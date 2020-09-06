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

            Console.WriteLine("名前、年齢を入力してください");

            String ansName = Console.ReadLine();
            int ansAge = int.Parse(Console.ReadLine());

            s2.Name = ansName ;

            s2.Age = ansAge;

            int age = s2.Age;
            String name = s2.Name;

            Console.WriteLine("あなたの名前は" + name + "あなたの年齢は" + age);

            


        }
    }
    
}
