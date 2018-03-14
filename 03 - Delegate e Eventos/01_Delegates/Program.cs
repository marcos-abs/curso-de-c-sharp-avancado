using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Delegates {
    class Program {

        delegate int Calcula(int a, int b);

        static void Main(string[] args) {

            /* 
             * +===== SEM DELEGATE =====+
             * 
             * var so = Soma(10, 20);
             * var su = Subtrai(20, 10);
             * 
            */

            // +===== COM DELEGATE =====+
            Calcula calc1 = new Calcula(Soma);
            int so = calc1(10, 20);
            Calcula calc2 = new Calcula(Subtrai);
            int su = calc2(30, 15);

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
