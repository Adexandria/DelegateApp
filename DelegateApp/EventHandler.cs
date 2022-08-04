using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    public class EventHandler
    {
        public void AddOperation(object obj, NumberEventArgs args)
        {
            Console.WriteLine($"Adding {args.N} and {args.K}");
        }
        public void SubstractOperation(object obj, NumberEventArgs args)
        {
            Console.WriteLine($"substracting {args.K} from {args.N}");
        }
        public void MultiplyOperation(object obj, NumberEventArgs args)
        {
            Console.WriteLine($"Multiplying {args.N} and {args.K}");
        }
        public void DivideOperation(object obj, NumberEventArgs args)
        {
            Console.WriteLine($"Dividing {args.K} from {args.N}");
        }
    }
}
