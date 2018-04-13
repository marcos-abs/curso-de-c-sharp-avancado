using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Reflection.Modelo;

namespace _04_Reflection {
    class Log {
        public static List<Usuario> usuarios = new List<Usuario>();

        public static void GravarUsuario(Usuario usuario) {
            usuarios.Add((Usuario)usuario.Clone());
        }

        public static List<Carro> carros = new List<Carro>();

        public static void Gravarcarro(Carro carro) {
            carros.Add(carro);
        }

        public static void ApresentarLog() {
            foreach(Usuario usuario in usuarios) {
                Console.WriteLine("Nome: {0}, Email: {1}, Senha: {2};", usuario.Nome, usuario.Email, usuario.Senha);
            }

            foreach (Carro carro in carros) {
                Console.WriteLine("Marca: {0}, Modelo: {1};", carro.Marca, carro.Modelo);
            }
        }
    }
}
