﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Delegates.Lib {
    class FotoProcessador {
        public static void Processador(Foto foto) {
            var filtros = new FotoFiltro();
            filtros.Colorir(foto);
            filtros.PretoBranco(foto);
            filtros.GerarThumb(foto);
            filtros.RedimensionarTamMedio(foto);
        }
    }
}
