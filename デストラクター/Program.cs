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

            Console.WriteLine("1");

            Sub s1 = new Sub(); //ここでSubクラスのコンストラクタ―が呼ばれる

            Console.WriteLine("2");

            s1 = null; //生成したインスタンスはもう利用されなくなるが
                       //デストラクターはまだ呼ばれない

            Console.WriteLine("3\n");


        }
    }
}
