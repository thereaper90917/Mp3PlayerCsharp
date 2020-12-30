
using MvvmCross.Platform;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Media;
using WMPLib;

namespace Mp3Player
{
    public partial class Form1 : Form
    {
        public WindowsMediaPlayer _MediaPlayer { get; set; }
        public Form1()
        {
            InitializeComponent();
            _MediaPlayer = new WindowsMediaPlayer();
            
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {




            if(_MediaPlayer.URL == "")
            {
                MessageBox.Show("Please Select a Song");
            }
            lbl_playing.Text = "No Song Playing";
            _MediaPlayer.settings.volume = (int)volume_track.Value;
            vlm_lbl.Text = $"Volume: {volume_track.Value.ToString()}";
            _MediaPlayer.controls.play();




        }

        private void btn_stop_Click(object sender, EventArgs e)
        {


            _MediaPlayer.controls.stop();

            

        }

        private void volume_track_Scroll(object sender, EventArgs e)
        {


            _MediaPlayer.settings.volume = (int)volume_track.Value;
            
            vlm_lbl.Text = $"Volume: {volume_track.Value.ToString()}";
        }

        private void vlm_lbl_Click(object sender, EventArgs e)
        {

        }

        private void browse_Click(object sender, EventArgs e)
        {

            var playList = new List<string>();

            openFileDialog1.DefaultExt = ".mp3";
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma";
            
            string filename = openFileDialog1.FileName;
            lbl_playing.Text = _MediaPlayer.URL;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                
                foreach (String file in openFileDialog1.FileNames)
                {
                    
                    playList.Add(file);
                }
            }
            
            foreach(var song in playList)
            {
                
                playListBox.Items.Add(song);
                songNumbers.Text = $"Total Songs: {playListBox.Items.Count.ToString()}";
            }


        }

        private void playListBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void playListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
 
            _MediaPlayer.URL = playListBox.SelectedItem.ToString();
            _MediaPlayer.settings.volume = (int)volume_track.Value;
            _MediaPlayer.controls.play();
            
            var timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(Timer);
            timer.Interval = 1000;
            timer.Start();
        }

        public void Timer(object Sender, EventArgs e)
        {
            string songName = $"Playing: {_MediaPlayer.currentMedia.name}";
            string durationTime = $"Duration: {_MediaPlayer.currentMedia.durationString}";
            lbl_playing.Text = songName;
            duration.Text = durationTime;
        }
    }

   

}
