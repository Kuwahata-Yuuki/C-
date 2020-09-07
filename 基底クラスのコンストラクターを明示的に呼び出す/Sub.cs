using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace ConsoleApp4
{

    class Sub
    {
        private string name;
        private int age;
        public Sub()
        {
            this.name = "";
            this.age = 0;
        }

        public Sub(int n)
        {
            Console.WriteLine("引数ありのコンストラクタ―が呼ばれました");
        }

        public string Name
        {
            set
            {
                this.name = value;
            }

            get
            {
                return name;
            }

        }

        public int Age
        {
            set
            {
                this.age = value;
            }

            get
            {
                return age;
            }
        }

    }


       

    }





    

