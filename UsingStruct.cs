using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordsHandsOn
{
    public struct Student
    {
        public string Name;
        public string lastname;
        public string Designation;
        public int Year;


    }
    public class UsingStruct
    {
        public void PerformStruct()
        {
            Student student = new Student();
            student.Name = "Dipakshi";
            student.lastname = "Saxena";
            student.Designation = "Developer";
            student.Year = 2022;
            Console.WriteLine("Print the Struct");
            Console.WriteLine("First Name=" + student.Name);
            Console.WriteLine("Last Nmae= " + student.lastname);
            Console.WriteLine("Designation = " + student.Designation);
            Console.WriteLine("Year= " + student.Year);
        }
        public void StructCanNotBeNullAssign()
        {
            Student student = new Student();
            //student = null;//it gives an error
            Console.WriteLine("it gives an error is (Cannot convert null to 'type' because it is a non-nullable value type)");

        }
    }
}
