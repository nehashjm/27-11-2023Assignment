using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Assignment
{
    internal delegate int arthematicOperration(int x , int y);
    public delegate T Operation<T>(T operand1, T operand2);
    internal class Program
    {
        static void Main(string[] args)
        {
            //  ArithematicOperation aop = new ArithematicOperation();
            //  arthematicOperration del = new arthematicOperration(aop.Add);

            //  Console.WriteLine("enter first number");
            //  int fnum = int.Parse(Console.ReadLine());
            //  Console.WriteLine("enter second number");
            //  int snum = int.Parse(Console.ReadLine());
            //  Console.WriteLine("enter your choice 1.Add 2.sub 3.Mul 4.Div");
            //  int choice = int.Parse(Console.ReadLine());
            //  if(choice == 1) 
            //  {
            //      Console.WriteLine("After adding {0} and {1} result = \t {2}", fnum, snum, del(fnum, snum));
            //  }
            //else if(choice == 2)
            //  {
            //      del += new arthematicOperration(aop.sub);
            //      Console.WriteLine("After sub {0} and {1} result = \t {2}", fnum, snum, del(fnum, snum));

            //  }
            //  else if(choice == 3) 
            //  {
            //      del += new arthematicOperration(aop.Mul);
            //      Console.WriteLine("After Mul {0} and {1} result = \t {2}", fnum, snum, del(fnum, snum));

            //  }
            //  else if (choice == 4)
            //  {
            //      del += new arthematicOperration(aop.Div);
            //      Console.WriteLine("After Mul {0} and {1} result = \t {2}", fnum, snum, del(fnum, snum));

            //  }

            
            Console.ReadKey();
        }
    }
}
