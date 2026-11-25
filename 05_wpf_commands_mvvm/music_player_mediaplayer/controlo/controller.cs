using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace musica2.controlo
{
    internal class controller:UIElement
    {
            public Cmd cmdmusica { get; set; }

            public controller()
            {
                cmdmusica = new Cmd(Musica, Canmusica);
            }

            public bool Canmusica(object parameter)
            {
                return true;
            }
            public void Musica(object parameter)
            {
                MediaPlayer player = new MediaPlayer();

                player.Open(new Uri(@"musica\MONTAGEM - ASSOMBRA MATRIX 2 [ ÁLBUM BONES ].mp4", UriKind.Relative));

                VideoDrawing aVideoDrawing = new VideoDrawing();

                aVideoDrawing.Rect = new Rect(0, 0, 300, 300);

                aVideoDrawing.Player = player;
                player.Play();
            }
        }
    }
