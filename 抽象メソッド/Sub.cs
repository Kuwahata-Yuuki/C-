using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp4
{

    abstract class Sub
    {

        protected int age;

        //抽象クラスなので、コンストラクターがpublicであってもインスタンスは生成できない

        public Sub()
        {
            this.age = 0;
        }

        public abstract int Age


        {

            get;



        }


    }




}





    

