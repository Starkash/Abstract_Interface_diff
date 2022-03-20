using System;

namespace Abstract_Interface_diff
{
    //    interface Program
    //    {
    //      void add();

    //    }
    //    class program2 : Program
    //    {
    //        public void add()
    //        {
    //            int x = 10;
    //            int y = 15;
    //            int z = x + y;
    //            Console.WriteLine("Sum"+" " + z);
    //        }
    //        public static void Main()
    //        {
    //            program2 interfacess = new program2();
    //            interfacess.add();

    //        }
    //    }
    //}


    abstract class Program1
    {
        public void add()
        {
            Console.WriteLine("NON - ABSTRACT METHOD IS CALLED");

        }
        public abstract void add1();
    }
    class Programm2 : Program1
    {
        public override void add1()
        {
            Console.WriteLine("ABSTRACT METHOD CALLED: CHILD CLASS");

        }

        static void Main(string[] args)
        {

            Programm2 objj = new Programm2();
            objj.add1();
            objj.add();
        }
    }
}


