using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordsHandsOn
{
    internal class Nullable
    {
        public void NullablePractice()
        {
            string name = null;
            int? number = null;
            Nullable<int> number2 = null;
            Console.WriteLine("String name  null " + name);
            Console.WriteLine(" int Number  null " + number);
            Console.WriteLine(" int Number 2 null " + number2);
            number = 20;
            Console.WriteLine("now assign some value to the int variable=" + number);
        }
    }

}
