﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _02_MultiThread {
    class Program {
        static void Main(string[] args) {
            for(int i = 0; i < 5; i++) {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.Start();
            }
            Console.WriteLine("\nPrograma terminado.");
            Console.ReadKey();
        }

        static void ThreadRepeticao() {
            for (int i = 0; i < 1000; i++) {
                Console.WriteLine("Numero: " + i);
            }
        }

    }
}
