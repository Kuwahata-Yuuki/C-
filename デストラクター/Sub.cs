using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Sub
    {
     
        public Sub()
        {
            Console.WriteLine("Subクラスのコンストラクタ―が呼ばれました");
        }

        ~Sub()
        {
            Console.WriteLine("Subクラスのデストラクターが呼ばれました");
        }

    }
}
