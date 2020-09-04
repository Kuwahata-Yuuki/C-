using System;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;


namespace ConsoleApp4


{ 

   
    class Program
    {

        static Sub s1;


        static void Main(string[] args)
        {
            s1 = new Sub();

            s1.Set(10, 20);

            int x = s1.GetX();
            int y = s1.GetY();

            Console.WriteLine(x+","+y);
        }
    }
}
