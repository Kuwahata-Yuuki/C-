using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Sub2 : Sub
    {

        private String name;
        private int age;
        
        public Sub2(String n,int a)
        {
            this.name = n;
            this.age = a;
        }

        public String Name
        {
            get
            {
                return this.name;
            }
        }


        public int Age
        {
            get
            {
                return this.age;
            }
        }


    


    }
}
