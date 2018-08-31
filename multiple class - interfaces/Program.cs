using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_class___interfaces
{
    class Program
    {
        public static void Main()
        {
            ab callingabClass = new ab();
            callingabClass.methodPrintA();
            callingabClass.methodPrintB();
            Console.WriteLine("Please press ENTER to terminate");
            Console.Read();
        }
    }

    /*methods are here - interfaces*/
    interface Ia
    {
        void methodPrintA();
    }
    interface Ib
    {
        void methodPrintB();
    }

    /*methods are implemented here - classes*/
    class a : Ia
    {
        public void methodPrintA()
        {
            Console.WriteLine("PrintA");
        }
    }
    class b : Ib
    {
        public void methodPrintB()
        {
            Console.WriteLine("PrintB");
        }
    }

    /*instead of inhertitance from classes, we can inherit from interfaces
     This is like using multiple classes*/
    class ab : Ia, Ib
    {
        a aaaa = new a();
        b bbbb = new b();
        public void methodPrintA()
        {
            aaaa.methodPrintA();
        }
        public void methodPrintB()
        {
            bbbb.methodPrintB();
        }
    }
}
