using System;

namespace Opps
{
    class Program
    {
        static void Main(string[] args)
        {
            InheritanceConfusion objInheritanceConfusion = new InheritanceConfusion();

             singletoncheck objSingletonCheck= singletoncheck.getInstance();
            int a = 10, b = 30;
            Console.WriteLine(a.isGreaterThan(b));

            objSingletonCheck.printMessage();
            
        }
    }
}


