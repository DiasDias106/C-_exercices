using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Media;

namespace musica.Controller
{
    internal class Controlo:UIElement
    {
        public Cmd cmdmusica { get; set; }

        public Controlo()
        {
            cmdmusica = new Cmd(Musica, Canmusica);
        }

        public bool Canmusica(object parameter)
        {
            return true;
        }
        public void Musica(object parameter)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            int inx = path.LastIndexOf("bin");
            path = path.Substring(0, inx) + @"\video\MONTAGEM-ASSOMBRA-MATRIX-2-_-ÁLBUM-BONES-_.wav";
            SoundPlayer player = new SoundPlayer(path);
            player.Load();
            player.Play();
        }
    }
}
