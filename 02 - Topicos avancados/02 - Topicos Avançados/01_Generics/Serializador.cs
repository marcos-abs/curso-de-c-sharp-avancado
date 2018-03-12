using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace _01_Generics {
    public class Serializador {
        /* Serializador sem Generics */
        public static void Serializar(Object obj) {
            StreamWriter sw = new StreamWriter(@"C:\Users\Marcos Antônio\Documents\Curso de C# Avançado\02 - Topicos avancados\03_" + obj.GetType().Name + ".txt");

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string objSerializado = serializador.Serialize(obj);

            sw.Write(objSerializado);
            sw.Close();
        }

        /* Deserializador com Generics */
        public static T Deserializar <T>() {
            StreamReader sr = new StreamReader(@"C:\Users\Marcos Antônio\Documents\Curso de C# Avançado\02 - Topicos avancados\03_" + typeof(T).Name + ".txt");
            string conteudo = sr.ReadToEnd();
            JavaScriptSerializer serializador = new JavaScriptSerializer();
            T obj = (T) serializador.Deserialize(conteudo, typeof(T));
            return obj;
        }
    }
}
