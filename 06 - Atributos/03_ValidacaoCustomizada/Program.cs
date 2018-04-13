using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _03_ValidacaoCustomizada {
    class Program {
        static void Main(string[] args) {
            Usuario usuario = new Usuario() { Nome = "José", Email = "jose", Senha = "1234567" };

            ValidationContext contexto = new ValidationContext(usuario);
            List<ValidationResult> resultados = new List<ValidationResult>();

            if (Validator.TryValidateObject(usuario, contexto, resultados, true) == false) {

                foreach (var erro in resultados) {
                    Console.WriteLine(erro.ErrorMessage);
                }
            }
            Console.WriteLine("\nPrograma finalizado.");
            Console.ReadKey();
        }
    }
}
