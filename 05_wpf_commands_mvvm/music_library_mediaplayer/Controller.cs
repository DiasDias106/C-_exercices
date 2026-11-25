using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Media;

namespace biblioteca_musicas
{
    internal class Controller :UIElement
    {
        public Cmd cmdmusica {  get; set; }


        public Controller()
        {
            cmdmusica = new Cmd(Musica, Canmusica);
        }

        public bool Canmusica(object parameter)
        {
            return true;
        }
        public void Musica(object parameter)
        {
            MediaTimeline mTimeline =
    new MediaTimeline(new Uri(@"sampleMedia\xbox.wmv", UriKind.Relative));

            mTimeline.RepeatBehavior = RepeatBehavior.Forever;

            MediaClock mClock = mTimeline.CreateClock();

            MediaPlayer repeatingVideoDrawingPlayer = new MediaPlayer();
            repeatingVideoDrawingPlayer.Clock = mClock;

            VideoDrawing repeatingVideoDrawing = new VideoDrawing();
            repeatingVideoDrawing.Rect = new Rect(150, 0, 100, 100);
            repeatingVideoDrawing.Player = repeatingVideoDrawingPlayer;
        }
    }
}
