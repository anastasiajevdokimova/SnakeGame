﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SnakeGame
{
    class Sounds
    {
        WindowsMediaPlayer Player = new WindowsMediaPlayer();
        private string pathToMedia;

        public Sounds(string pathToResources)
        {
            pathToMedia = pathToResources;
        }

        public void Play()
        {
            player.URL = pathToMedia + "gameover.mp3";
            player.settings.volume = 30;
            player.controls.play();
            player.settings.setMode("loop", true);
        }

        public void PlayEat()
        {
            player.URL = pathToMedia + "crunch.mp3";
            player.settings.volume = 100;
            player.controls.play();
        }
    }
}
