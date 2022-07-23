using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    public class DelegateClass
    {
        // declare a delegate method
        public delegate void Calculate(int n,int k);
        
        public static void AddNumbers(int n,int k)
        {
            Console.WriteLine(n + k);
        }
        
        public static void Substract(int n,int k)
        {
            Console.WriteLine(n - k);
        }

        public static void Multiply(int n, int k)
        {
            Console.WriteLine(n * k);
        }

        public static void Divide(int n, int k)
        {
            Console.WriteLine(n / k);
        }
    }
}
