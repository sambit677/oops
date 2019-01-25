using System;
using System.Collections.Generic;
using System.Text;

namespace Opps
{
     class singletoncheck
    {

        private static singletoncheck sinletonObj { get; set; }

        private singletoncheck() { }

        public static singletoncheck getInstance()
        {
            if (sinletonObj == null)
                return sinletonObj = new singletoncheck();
            else
                return sinletonObj;
        }

        public void printMessage()
        {
            Console.WriteLine("Printing from Singleton class method;");
            Console.ReadLine();
        }

       
        
        
        

    }
}
