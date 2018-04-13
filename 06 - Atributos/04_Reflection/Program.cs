using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Reflection.Modelo;

namespace _04_Reflection {
    class Program {
        static void Main(string[] args) {
            Usuario usuario = new Usuario() {
                Nome = "José",
                Email = "jose.costa@gmail.com",
                Senha = "123456ab"
            };
            //Log.GravarUsuario(usuario);
            Log.Gravar(usuario.Clone());
            usuario.Nome = "José Costa";
            //Log.GravarUsuario(usuario);
            Log.Gravar(usuario.Clone());

            Carro carro = new Carro() { Marca = "Fiat", Modelo = "Uno" };
            Log.Gravar(carro);

            Console.WriteLine("\nLog gravado.");
            Console.ReadKey();

            Log.ApresentarLog();

            Console.WriteLine("\n\nPrograma finalizado.");
            Console.ReadKey();
        }
    }
}
