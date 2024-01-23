using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Example_19_Class_Methods_ConsoleApp
{

    internal class  Student
    {
        public double weight;
        public string name;
        public int age;

        public Student(double aWeight, string aName, int aAge)
        {
          this .weight = aWeight;
          this .name = aName;
          this .age = aAge;
        } 

        public bool IsObese()
        {
            if (weight > 60)
            {
                return true;
            }
            else
                return false;
        }
        static void Main(string[] args)
        {
            Student student1 = new Student(70, "John", 15);
            Student student2 = new Student(40, "Tim", 10);

            Console.WriteLine(student1.IsObese() );
            Console.WriteLine(student2.IsObese());

            Console.ReadLine();
        }
    }
}
