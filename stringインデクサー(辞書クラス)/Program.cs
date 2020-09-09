using System;

namespace Dictionary
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionarys d1 = new Dictionarys();
            

            d1["ハァ"] = "( ﾟДﾟ)?";
            d1["ハァハァ"] = "(*´Д`)";
            d1["ポカーン"] = "(　ﾟдﾟ)";

            Console.WriteLine("今の感情を選んで入力してください" +
                "ハァ、ハァハァ、ポカーン");

            string ans = Console.ReadLine();



            Console.WriteLine(d1[ans]);
        }
    }
}
