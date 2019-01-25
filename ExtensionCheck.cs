using System;
using System.Collections.Generic;
using System.Text;

namespace Opps
{
    // We will use this class to extend funcationalities of other type 
    // e:g will add a method to integer type to check greterthan 
    //extension methods are always static and the class where it defined as it should be available for type while implimenting other places 
    static class ExtensionCheck
    {
        public static bool isGreaterThan(this int a , int b)
        {
            return a > b;
        }

    }
}
