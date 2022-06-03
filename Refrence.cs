using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordsHandsOn
{
     class Person
    {
            public int age;
    }
        class Programs
        {
            static void Square(Person a, Person b)
            {
                a.age = a.age * a.age;
                b.age = b.age * b.age;
                Console.WriteLine(a.age + " " + b.age);
            }
        }
   }

