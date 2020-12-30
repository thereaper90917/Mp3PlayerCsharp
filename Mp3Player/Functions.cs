using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Mp3Player
{
    class Functions
    {

        public WindowsMediaPlayer _MediaPlayer { get; set; }
        public bool _Stop { get; set; }
        public Functions()
        {
            _MediaPlayer = new WindowsMediaPlayer();
            
        }
        public void Play()
        {
            _MediaPlayer.URL = @"C:\1.mp3";
            _MediaPlayer.controls.play();
            if (_Stop)
            {
                _MediaPlayer.controls.stop();
            }
        }

        public void Stop()
        {
            _MediaPlayer.controls.stop();
        }
    }
}
