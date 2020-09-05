using System;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;


namespace ConsoleApp4


{ 

   
    class Program
    {

        static Sub s1;
        static String name;
        static int age;

        static void Main(string[] args)
        {
            s1 = new Sub();

            Console.WriteLine("名前と年齢を入力してください");

            String ansName = Console.ReadLine();
            int ansAge = int.Parse(Console.ReadLine());

            s1.setNameAge(ansName, ansAge);

            name = s1.getName();
            age = s1.getAge();

            Console.WriteLine("あなたの名前は:" + name + "年齢は" + age);




        }
    }
}
