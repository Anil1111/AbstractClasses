using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{

    public abstract class AbsClass1
    {
        public abstract int EmpId { get; set; }

        public void NonAbsMethod1()
        {
            Console.WriteLine("FYI Abstact classes can have NonAbstarct methods");
        }

        public abstract void AbsMethod1();
        //{   commented because keep in mind that abstract methods cant have body in abstract class
        //    Console.WriteLine("");
        //}

        //Abstract classes are basically used as BASE CLASS.
        //An Abstarct class can not be sealed.
    }

    public class AbsClass2 :AbsClass1
    {
        public override int EmpId { get; set; }
        public override void AbsMethod1() // to provide implementation of the abstarct class's abstract methods is mandatory.
            // the only time child class doesnt have to provide the implementation is when it itself is also a Abstact class.
        {
            Console.WriteLine("in the child class it can have a body, remember using 'override' for that");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          //  AbsClass1 obj = new AbsClass1();
          // abstract classes are basically incomplete , So it doesnt make sense to create their object
          // Abstract classes cant be instantiated.

            AbsClass2 obj = new AbsClass2();
            obj.NonAbsMethod1();
            obj.AbsMethod1();
            Console.ReadKey();

        }
    }
}
