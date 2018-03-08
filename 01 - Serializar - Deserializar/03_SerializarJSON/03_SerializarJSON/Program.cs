using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using _00_Biblioteca;
using System.IO;

namespace _03_SerializarJSON {
    class Program {
        static void Main(string[] args) {
            Usuario usuario = new Usuario() { Nome = "Maria Costa Silva", CPF = "333.333.333-00", Email = "maria@gmail.com" };
            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string stringObjSerializado = serializador.Serialize(usuario);

            StreamWriter sw = new StreamWriter(@"C:\Users\Marcos Antônio\Documents\Curso de C# Avançado\01 - Serializar - Deserializar\02_SerializarJSON.json");
            sw.WriteLine(stringObjSerializado);
            sw.Close();
        }
    }
}
