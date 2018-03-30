using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _04_ThreadSafe {
    class Program {

        static int Rede = 0;
        static object variavelDeControle = 0;

        static void Main(string[] args) {
            Console.WriteLine("Dataini: " + DateTime.Now);
            for (int i = 0; i < 5; i++) {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.IsBackground = true;
                t1.Start();
            }
            Console.WriteLine("\nPrograma terminado.");
            Console.ReadKey();
        }

        static void ThreadRepeticao() {
            for (int i = 0; i < 1000; i++) {
                lock (variavelDeControle) {
                    Console.WriteLine("Numero: " + i);
                }
            }
            Console.WriteLine("DataTime: " + DateTime.Now);
        }
    }
}
