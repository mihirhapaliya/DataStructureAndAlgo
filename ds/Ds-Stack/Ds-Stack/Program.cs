using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ds_Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<string> s = new Stack<string>(5);
            s.push("here");
            s.push("begins");
            s.push("Progrmmimg");
            s.push("jungle");
            s.push("Welcome to ");



            s.displayStack();
            Console.ReadLine();

            s.pop();
            s.displayStack();
            Console.ReadLine();

            s.pop();
            s.displayStack();
            Console.ReadLine();

            s.pop();
            s.displayStack();
            Console.ReadLine();

            s.pop();
            s.displayStack();
            Console.ReadLine();

            s.pop();
            s.displayStack();
            Console.ReadLine();

            s.pop();
            s.displayStack();
            Console.ReadLine();
        }
    }
}
