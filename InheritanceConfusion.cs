using System;
using System.Collections.Generic;
using System.Text;

namespace Opps
{
    class InheritanceConfusion
    {

       public InheritanceConfusion()
        {

            A objOrA = new A();
            objOrA.methodA(); // will call its own method


            A objA = new c();

            objA.methodA();  // it will call c class methodA as its overrided
            c objc =  new c();
            objc.methodA();   // it will call its own ovverided method 
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

        public override void methodA()
        {
            base.methodA();  // will call Class B methodA
            Console.WriteLine("from Class C ");
        }
        public void methodC()
        {

        }

    }
}
