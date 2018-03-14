using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Eventos.Lib.Mensageiro {
    public class Email {
        public void EnviarMensagem(Video video) {
            Console.WriteLine("Email enviado para o video: " + video.Nome);
        }
    }
}
