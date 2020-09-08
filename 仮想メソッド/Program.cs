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

            Sub s1 = new Sub();

            s1.Test();

            Sub s2 = new Sub2();

            s2.Test();


        }

        
    }
    
}
