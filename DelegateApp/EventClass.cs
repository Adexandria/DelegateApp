using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegateApp.DelegateClass;

namespace DelegateApp
{
    public class EventClass
    {
        public event Notify NotifyEvent;
        public event Notify EndEvent;
        
        public void StartCalculation(int n, int k)
        {
            Console.WriteLine("Calculation Started");
            OnStartCalculation(n,k);  
        }

        public void EndCalculation(int n)
        {
            Console.WriteLine($"The result is {n}");
            Console.WriteLine("Calculation ended");         
            OnEndCalculation();
        }
        
        protected virtual void OnEndCalculation()
        {
            EndEvent?.Invoke(this.OnEndCalculation, null);
        }
        
        protected virtual void OnStartCalculation(int n, int k)
        {
            NotifyEvent?.Invoke(this.StartCalculation, new NumberEventArgs {N = n, K = k } );
        }

        
    }
}
