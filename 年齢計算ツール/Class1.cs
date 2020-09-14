using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class Class1
    {

        private String name;
        private int age;

    public Class1(String name2,DateTime birthday2)
        {
            name = name2;

            age = DateTime.Today.Year - birthday2.Year;
            
        }

        public String getName()
        {
            return name;
        }

        public int getBirthday()
        {
            return age;
        }

    }
}
