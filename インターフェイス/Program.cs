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

            Console.WriteLine("名前と年齢を答えてください");

            String ansName = Console.ReadLine();

            int ansAge = int.Parse(Console.ReadLine());

            Sub2 s2 = new Sub2(ansName,ansAge);

            String name = s2.Name;

            int age = s2.Age;

            Console.WriteLine("名前は" + name + "年齢は" + age);
            


        }

        
    }
    
}
