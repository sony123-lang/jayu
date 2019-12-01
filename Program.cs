using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deligate_prac
{
    class Program
    {
        public delegate void del();
        public delegate int newdel(int a, int b);
        public delegate int callingm(int a, int b); 

        static void Main()
        {
            Console.WriteLine(callingmethod(add,2,4));
            Console.WriteLine(callingmethod(div, 48, 4));





            Console.ReadLine();
        }

        static int callingmethod(callingm callo,int a,int b) {

            return callo(a, b);

        }

        static void display()
        {
            Console.WriteLine("sufiyan");
        }

        public void show()
        {
            Console.WriteLine("malek");
        }

        static int add(int a, int b)
        {
            return a + b;
        }
        static int sub(int a, int b)
        {
            return a - b;
        }
        static int mul(int a, int b)
        {
            return a * b;
        }
        static int div(int a, int b)
        {
            return a / b;
        }
    }
}
