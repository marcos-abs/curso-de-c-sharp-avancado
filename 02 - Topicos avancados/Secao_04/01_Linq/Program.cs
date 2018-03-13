using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Linq {
    class Program {
        static void Main(string[] args) {
            // Linq e Lambda
            // Lambda = (entrada) => (expressão)
            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };
            // var listaFiltrada = lista.Where(a => a > 10).Select(a => a); // ordem natural
            //var listaFiltrada = lista.Where(a => a > 10).OrderBy(a=>a).Select(a => a); //ordem ascendente
            var listaFiltrada = lista.Where(a => a > 10).OrderByDescending(a => a).Select(a => a); //ordem decrescente
            foreach (var item in listaFiltrada) {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
