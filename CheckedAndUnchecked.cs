using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordsHandsOn
{
    public class CheckedAndUnchecked
    {
            public void Checked()
            {
                checked
                {
                    Console.WriteLine("Value of 2+2 is ");

                    Console.WriteLine(2+2 );

                }

            }
            public void UnChecked()
            {
                unchecked
                {
                    Console.WriteLine("Value of 2-2 is ");

                    Console.WriteLine(2-2 );

                }

            }
        }
    }
