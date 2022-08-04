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
        public delegate void Notify(object obj,NumberEventArgs args);

        //Instanting Event class objects
        static EventClass additionEvent = new();
        static EventClass substractionEvent = new();
        static EventClass multiplicationEvent = new();
        static EventClass divisionEvent = new();
        static EventHandler eventHandler = new();
        
        public static void AddNumbers(int n,int k)
        {
            additionEvent.NotifyEvent += eventHandler.AddOperation;
            additionEvent.StartCalculation(n, k);
            int result = n + k;
            additionEvent.EndCalculation(result);
            
        }


        public static void Substract(int n,int k)
        {
            substractionEvent.NotifyEvent += eventHandler.SubstractOperation;
            substractionEvent.StartCalculation(n, k);
            int result  = n - k;
            additionEvent.EndCalculation(result);
        }

        public static void Multiply(int n, int k)
        {
            multiplicationEvent.NotifyEvent += eventHandler.MultiplyOperation;
            multiplicationEvent.StartCalculation(n, k);
            int result = n * k;
            additionEvent.EndCalculation(result);
        }

        public static void Divide(int n, int k)
        {
            divisionEvent.NotifyEvent += eventHandler.DivideOperation;
            divisionEvent.StartCalculation(n, k);
            int result = n / k;
            additionEvent.EndCalculation(result);
        }
    }
}
