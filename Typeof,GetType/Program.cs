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

            Sub s1 = new Sub();

            Console.WriteLine(typeof(Sub2)==s1.GetType());
            


        }
    }
    
}
