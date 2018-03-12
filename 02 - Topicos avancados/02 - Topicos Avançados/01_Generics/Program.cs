using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Generics.Modelo;

namespace _01_Generics {
    class Program {
        static void Main(string[] args) {
            Carro carro = new Carro() { Marca = "Fiat", Modelo = "Uno" };
            Casa casa = new Casa() { Cidade = "Brasilia", Endereco = "QSQ 400" };
            Usuario usuario = new Usuario() { Nome = "Maria", Email = "maria@gmail.com", Senha = "123456" };

            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);

            Carro carro2 = Serializador.Deserializar<Carro>();
            Casa casa2 = Serializador.Deserializar<Casa>();
            Usuario usuario2 = Serializador.Deserializar<Usuario>();

            Console.WriteLine("\nCarro2: " + carro2.Marca + " - " + carro2.Modelo);
            Console.WriteLine("\nCasa2: " + casa2.Endereco + " - " + casa2.Cidade);
            Console.WriteLine("\nUsuario2: " + usuario2.Nome + " - " + usuario2.Email);

            Console.ReadKey();
        }
    }
}
