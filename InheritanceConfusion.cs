using System;
using System.Collections.Generic;
using System.Text;

namespace Opps
{
    class InheritanceConfusion
    {

       public InheritanceConfusion()
        {
            A objA = new c();

            //objA.methodA();
            c objc =  new c();
            objc.methodA();
        }


    }

    class A
    {
        public virtual void methodA()
        {
            Console.WriteLine("from Class A ");
        }
    }

    class B : A
    {
      
        public override void methodA()
        {
           // base.methodA();
            Console.WriteLine("from Class B ");
        }

        public void methodB()
        {

        }
    }

    class c : B
    {

        //public override void methodA()
        //{
        //    //base.methodA();
        //    Console.WriteLine("from Class C ");
        //}

        public void methodC()
        {

        }

    }
}
