namespace Mp3Player
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lbl_playing = new System.Windows.Forms.Label();
            this.volume_track = new System.Windows.Forms.TrackBar();
            this.vlm_lbl = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.playListBox = new System.Windows.Forms.ListBox();
            this.duration = new System.Windows.Forms.Label();
            this.songNumbers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volume_track)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(154, 351);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(310, 62);
            this.btn_Play.TabIndex = 0;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(525, 351);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(310, 62);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // lbl_playing
            // 
            this.lbl_playing.AutoSize = true;
            this.lbl_playing.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playing.Location = new System.Drawing.Point(36, 172);
            this.lbl_playing.Name = "lbl_playing";
            this.lbl_playing.Size = new System.Drawing.Size(149, 39);
            this.lbl_playing.TabIndex = 3;
            this.lbl_playing.Text = "Playing:";
            // 
            // volume_track
            // 
            this.volume_track.Location = new System.Drawing.Point(319, 470);
            this.volume_track.Maximum = 100;
            this.volume_track.Name = "volume_track";
            this.volume_track.Size = new System.Drawing.Size(374, 45);
            this.volume_track.TabIndex = 4;
            this.volume_track.TickFrequency = 100;
            this.volume_track.Value = 20;
            this.volume_track.Scroll += new System.EventHandler(this.volume_track_Scroll);
            // 
            // vlm_lbl
            // 
            this.vlm_lbl.AutoSize = true;
            this.vlm_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlm_lbl.Location = new System.Drawing.Point(429, 442);
            this.vlm_lbl.Name = "vlm_lbl";
            this.vlm_lbl.Size = new System.Drawing.Size(97, 25);
            this.vlm_lbl.TabIndex = 5;
            this.vlm_lbl.Text = "Volume:";
            this.vlm_lbl.Click += new System.EventHandler(this.vlm_lbl_Click);
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(319, 271);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(310, 62);
            this.browse.TabIndex = 6;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // playListBox
            // 
            this.playListBox.FormattingEnabled = true;
            this.playListBox.Location = new System.Drawing.Point(1008, 12);
            this.playListBox.Name = "playListBox";
            this.playListBox.Size = new System.Drawing.Size(359, 485);
            this.playListBox.TabIndex = 8;
            this.playListBox.SelectedIndexChanged += new System.EventHandler(this.playListBox_SelectedIndexChanged);
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration.Location = new System.Drawing.Point(458, 145);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(0, 25);
            this.duration.TabIndex = 9;
            // 
            // songNumbers
            // 
            this.songNumbers.AutoSize = true;
            this.songNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songNumbers.Location = new System.Drawing.Point(1152, 500);
            this.songNumbers.Name = "songNumbers";
            this.songNumbers.Size = new System.Drawing.Size(0, 25);
            this.songNumbers.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 611);
            this.Controls.Add(this.songNumbers);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.playListBox);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.vlm_lbl);
            this.Controls.Add(this.volume_track);
            this.Controls.Add(this.lbl_playing);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_Play);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.volume_track)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lbl_playing;
        private System.Windows.Forms.TrackBar volume_track;
        private System.Windows.Forms.Label vlm_lbl;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox playListBox;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.Label songNumbers;
    }
}

