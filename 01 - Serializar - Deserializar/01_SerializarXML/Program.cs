using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Serialização para arquivos
using _00_Biblioteca;
using System.Xml.Serialization; // Serialização em XML

namespace _01_SerializarXML {
    class Program {
        static void Main(string[] args) {
            Usuario usuario = new Usuario() { Nome = "José Costa Silva", CPF = "222.222.222-22", Email = "jose@gmail.com" };
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario)); // uma das formas possíveis
            // XmlSerializer serializador = new XmlSerializer(usuario.GetType()); // outra forma possível

            StreamWriter stream = new StreamWriter(@"C:\Users\Marcos Antônio\Documents\Curso de C# Avançado\01 - Serializar - Deserializar\01_SerializarXML.xml");

            serializador.Serialize(stream, usuario);
        }
    }
}
