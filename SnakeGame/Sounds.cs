using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WMPLib;

namespace SnakeGame
{
    class Sounds
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string pathToMedia;

        public Sounds(string pathToResources)
        {
            pathToMedia = pathToResources;
        }
        public void Play()
        {
            player.URL = pathToMedia + "main.mp3";
            player.settings.volume = 50;
            player.controls.play();
            player.settings.setMode("loop", true);
        }
        public void PlayEat()
        {
            player.URL = pathToMedia +"crunch.mp3";
            player.settings.volume = 50;
            player.controls.play();
        }

        public void PlayEnd()
        {
            player.URL = pathToMedia + "gameover.mp3";
            player.settings.volume = 80;
            player.controls.play();
        }
    }
}
