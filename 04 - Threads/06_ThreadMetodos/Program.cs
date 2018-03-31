using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _06_ThreadMetodos {
    class Program {
        static void Main(string[] args) {
            // thread sleep
            Console.WriteLine("\nPrograma iniciado.");
            Thread.Sleep(3000);
            Console.WriteLine("\nRotina terminada.");
            Thread t1 = new Thread(ThreadRepeticao);
            Thread t2 = new Thread(ThreadRepeticao);
            Thread t3 = new Thread(ThreadRepeticao);
            Thread t4 = new Thread(ThreadRepeticao);

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t1.Join();

            Console.WriteLine("\nPrograma finalizado.");
            Console.ReadKey();
        }

        static void ThreadRepeticao(object Id) {
            for (int i = 0; i < 1000; i++) {
                Console.WriteLine("Thread" + Id + " Numero: " + i + " Id:" + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
