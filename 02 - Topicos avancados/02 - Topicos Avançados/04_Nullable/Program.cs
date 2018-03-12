using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Nullable {
    class Program {
        static void Main(string[] args) {

            //Struct - Por Valor
            int i = null;

            //class - por referencia
            object o = null;

            //MySQL - Oracle - PostgreSQL... NoSQL - Informações opcionais
            Nullable<int> Idade = null;
            int? Idade2 = null;
            //ERRO: int Idade3 = null;
        }
    }
}
