using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Linq {
    class Program {
        static void Main(string[] args) {
            // Linq e Lambda
            // Lambda = (entrada) => (expressão)
            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };
            // var listaFiltrada = lista.Where(a => a > 10).Select(a => a); // ordem natural - exemplo com linq
            var listaFiltrada = from a in lista where a > 10 orderby a select a; // exemplo de linq diferente
            foreach (var item in listaFiltrada) {
                Console.WriteLine("- - " + item);
            }
            Console.ReadKey();
        }
    }
}
