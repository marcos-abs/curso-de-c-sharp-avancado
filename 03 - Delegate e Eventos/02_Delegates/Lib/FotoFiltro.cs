using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Delegates.Lib {
    class FotoFiltro {
        public void Colorir(Foto foto) {
            // algoritmo q faz colorimento
            Console.WriteLine("FotoFiltro > Colorir: " + foto.Nome);
        }

        public void GerarThumb(Foto foto) {
            // algoritmo do metodo
            Console.WriteLine("FotoFiltro > GerarThumb: " + foto.Nome);
        }

        public void PretoBranco(Foto foto) {
            // algoritmo do metodo 
            Console.WriteLine("FotoFiltro > PretoBranco: " + foto.Nome);
        }

        public void RedimensionarTamMedio(Foto foto) {
            // algoritmo do metodo 
            Console.WriteLine("FotoFiltro > RedimensionarTamMedio: " + foto.Nome);
        }
    }
}
