using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Atributo {
    class MeuAtributo : Attribute {

        [MeuAtributo("Atributo Classe", Descricao = "Descrição do Atributo")]

        public string Nome { get; set; }
        public string Descricao { get; set; }

        public MeuAtributo(string nome) {
            Nome = nome;
        }
    }
}
