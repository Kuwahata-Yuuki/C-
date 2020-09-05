using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Sub
    {
       private String name;
        private int age;

        public Sub()
        {
            name = "";
            age = 0;
        }

        public String getName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }

        public void setNameAge(String n,int a)
        {
            name = n;
            age = a;
        }





    }
}
