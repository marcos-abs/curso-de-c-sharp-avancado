using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _03_Eventos.Lib {
    public class VideoEncode {

        //public delegate void VideoEncodedHandler(Video video);
        //public event VideoEncodedHandler Encoded;

        public event EventHandler<VideoEventArgs> Encoded;

        public void Encode(Video video) {
            Console.Write("\nConvertendo o video...");
            Thread.Sleep(2000);
            Console.WriteLine("Ok.\nConvertido.");

            //Encoded(this, new VideoEventArgs() { Video = video });
            Encoded(null, new VideoEventArgs() { Video = video }); //pog
        }
    }

    public class VideoEventArgs : EventArgs {
        public Video Video { get; set; }
    }
}
