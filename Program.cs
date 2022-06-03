using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordsHandsOn
{
    public class Program
    {
        static void Main(string[] args)
        {
            //nullableExample
            // Nullable nullablePractice = new Nullable();
            //nullablePractice.NullablePractice();

            //Checked and unchecked example
            //CheckedAndUnchecked checkedAndunchecked = new CheckedAndUnchecked();
            //checkedAndunchecked.Checked();
            //checkedAndunchecked.UnChecked();
            //Console.ReadLine();

            //Jagged Array
            //Console.WriteLine("Jagged Array:-");
            //JaggedArray jaggedArray = new JaggedArray();
            //jaggedArray.jagged_Array();


            //Nested example
            // NestedCars sportsCar = new NestedCars();
            //sportsCar.displayCar();
            //NestedCars.Engines PetrolEngine = new NestedCars.Engines();
            //Console.ReadLine();


            //Refrence type example
            //Person p1 = new Person();
            //Person p2 = new Person();
            //p1.age = 5;
            //p2.age = 10;
            //Console.WriteLine(p1.age + " " + p2.age);
            //Square(p1, p2);
            //Console.WriteLine(p1.age + " " + p2.age);
            //Console.WriteLine("Press Any Key to Exit..");
            //Console.ReadLine();


            //StructExample
            Console.WriteLine("Struct And Classes:-");
            UsingStruct usingStruct = new UsingStruct();
            usingStruct.PerformStruct();
            usingStruct.StructCanNotBeNullAssign();
            Console.WriteLine();


        }

       
    }
}
    