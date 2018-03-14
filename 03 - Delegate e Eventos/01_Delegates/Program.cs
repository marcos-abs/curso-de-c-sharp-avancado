using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Delegates {
    class Program {
        static void Main(string[] args) {
            var so = Soma(10, 20);
            var su = Subtrai(20, 10);

            Console.WriteLine("Soma: " + so);
            Console.WriteLine("Sub: " + su);

            Console.ReadKey();
        }

        static int Soma(int a, int b) {
            return a + b;
        }

        static int Subtrai(int a, int b) {
            return a - b;
        }
    }
}
