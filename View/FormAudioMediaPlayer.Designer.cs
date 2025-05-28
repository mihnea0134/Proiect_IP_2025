namespace MediaPlayer.View
{
    partial class FormAudioMediaPlayer
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
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.listBoxPlaylistAudioMedia = new System.Windows.Forms.ListBox();
            this.buttonPlayPause = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.pictureBoxAudioMedia = new System.Windows.Forms.PictureBox();
            this.labelAudioMediaTitle = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.trackBarTime = new System.Windows.Forms.TrackBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.labelPlaylistAudioMedia = new System.Windows.Forms.Label();
            this.labelPlaylists = new System.Windows.Forms.Label();
            this.listBoxPlaylist = new System.Windows.Forms.ListBox();
            this.buttonCreatePlaylist = new System.Windows.Forms.Button();
            this.buttonDeleteMedia = new System.Windows.Forms.Button();
            this.buttonUploadDeleteOnlinePlaylist = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonLoadMedia = new System.Windows.Forms.Button();
            this.buttonDeletePlaylist = new System.Windows.Forms.Button();
            this.radioButtonRepeatPlayback = new System.Windows.Forms.RadioButton();
            this.radioButtonSequentialPlayback = new System.Windows.Forms.RadioButton();
            this.radioButtonShufflePlayback = new System.Windows.Forms.RadioButton();
            this.groupBoxPlabackMethods = new System.Windows.Forms.GroupBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.buttonDownloadOnlinePlaylist = new System.Windows.Forms.Button();
            this.listBoxRecents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAudioMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).BeginInit();
            this.groupBoxPlabackMethods.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.BackColor = System.Drawing.Color.Black;
            this.trackBarVolume.Enabled = false;
            this.trackBarVolume.Location = new System.Drawing.Point(702, 648);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarVolume.Size = new System.Drawing.Size(286, 56);
            this.trackBarVolume.TabIndex = 5;
            this.trackBarVolume.TickFrequency = 0;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVolume.Value = 50;
            this.trackBarVolume.Scroll += new System.EventHandler(this.TrackBarVolume_Scroll);
            // 
            // listBoxPlaylistAudioMedia
            // 
            this.listBoxPlaylistAudioMedia.BackColor = System.Drawing.Color.DarkGray;
            this.listBoxPlaylistAudioMedia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPlaylistAudioMedia.FormattingEnabled = true;
            this.listBoxPlaylistAudioMedia.ItemHeight = 16;
            this.listBoxPlaylistAudioMedia.Location = new System.Drawing.Point(12, 376);
            this.listBoxPlaylistAudioMedia.Name = "listBoxPlaylistAudioMedia";
            this.listBoxPlaylistAudioMedia.Size = new System.Drawing.Size(285, 224);
            this.listBoxPlaylistAudioMedia.TabIndex = 7;
            this.listBoxPlaylistAudioMedia.SelectedIndexChanged += new System.EventHandler(this.ListBoxPlaylistAudioMediaAndListBoxRecents_SelectedIndexChanged);
            // 
            // buttonPlayPause
            // 
            this.buttonPlayPause.BackColor = System.Drawing.Color.DarkGray;
            this.buttonPlayPause.Enabled = false;
            this.buttonPlayPause.Location = new System.Drawing.Point(735, 596);
            this.buttonPlayPause.Name = "buttonPlayPause";
            this.buttonPlayPause.Size = new System.Drawing.Size(157, 32);
            this.buttonPlayPause.TabIndex = 0;
            this.buttonPlayPause.Text = "Porneste redarea";
            this.buttonPlayPause.UseVisualStyleBackColor = false;
            this.buttonPlayPause.Click += new System.EventHandler(this.ButtonPlayStop_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.DarkGray;
            this.buttonPrevious.Enabled = false;
            this.buttonPrevious.Location = new System.Drawing.Point(632, 596);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(81, 32);
            this.buttonPrevious.TabIndex = 1;
            this.buttonPrevious.Text = "Anterior";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.DarkGray;
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(910, 596);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(78, 32);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Urmator";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // pictureBoxAudioMedia
            // 
            this.pictureBoxAudioMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxAudioMedia.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxAudioMedia.Image = global::View.Properties.Resources.no_album_art__no_cover___placeholder_picture_by_cmdrobot_d7kpm65_fullview;
            this.pictureBoxAudioMedia.Location = new System.Drawing.Point(581, 64);
            this.pictureBoxAudioMedia.Name = "pictureBoxAudioMedia";
            this.pictureBoxAudioMedia.Size = new System.Drawing.Size(441, 336);
            this.pictureBoxAudioMedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAudioMedia.TabIndex = 3;
            this.pictureBoxAudioMedia.TabStop = false;
            // 
            // labelAudioMediaTitle
            // 
            this.labelAudioMediaTitle.AutoEllipsis = true;
            this.labelAudioMediaTitle.AutoSize = true;
            this.labelAudioMediaTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelAudioMediaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAudioMediaTitle.Location = new System.Drawing.Point(708, 406);
            this.labelAudioMediaTitle.Name = "labelAudioMediaTitle";
            this.labelAudioMediaTitle.Size = new System.Drawing.Size(0, 42);
            this.labelAudioMediaTitle.TabIndex = 4;
            this.labelAudioMediaTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtist.Location = new System.Drawing.Point(735, 459);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(0, 29);
            this.labelArtist.TabIndex = 6;
            // 
            // trackBarTime
            // 
            this.trackBarTime.Enabled = false;
            this.trackBarTime.Location = new System.Drawing.Point(619, 489);
            this.trackBarTime.Maximum = 100;
            this.trackBarTime.Name = "trackBarTime";
            this.trackBarTime.Size = new System.Drawing.Size(396, 56);
            this.trackBarTime.TabIndex = 9;
            this.trackBarTime.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarTime.Scroll += new System.EventHandler(this.TrackBarTime_Scroll);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolume.ForeColor = System.Drawing.Color.White;
            this.labelVolume.Location = new System.Drawing.Point(628, 648);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(68, 25);
            this.labelVolume.TabIndex = 10;
            this.labelVolume.Text = "Volum";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.White;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(789, 558);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 20);
            this.TimeLabel.TabIndex = 11;
            // 
            // labelPlaylistAudioMedia
            // 
            this.labelPlaylistAudioMedia.AutoSize = true;
            this.labelPlaylistAudioMedia.ForeColor = System.Drawing.Color.White;
            this.labelPlaylistAudioMedia.Location = new System.Drawing.Point(9, 346);
            this.labelPlaylistAudioMedia.Name = "labelPlaylistAudioMedia";
            this.labelPlaylistAudioMedia.Size = new System.Drawing.Size(142, 16);
            this.labelPlaylistAudioMedia.TabIndex = 12;
            this.labelPlaylistAudioMedia.Text = "Lista media din playlist";
            // 
            // labelPlaylists
            // 
            this.labelPlaylists.AutoSize = true;
            this.labelPlaylists.ForeColor = System.Drawing.Color.White;
            this.labelPlaylists.Location = new System.Drawing.Point(9, 64);
            this.labelPlaylists.Name = "labelPlaylists";
            this.labelPlaylists.Size = new System.Drawing.Size(68, 16);
            this.labelPlaylists.TabIndex = 13;
            this.labelPlaylists.Text = "Playlist-uri";
            // 
            // listBoxPlaylist
            // 
            this.listBoxPlaylist.BackColor = System.Drawing.Color.DarkGray;
            this.listBoxPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPlaylist.FormattingEnabled = true;
            this.listBoxPlaylist.ItemHeight = 16;
            this.listBoxPlaylist.Location = new System.Drawing.Point(12, 94);
            this.listBoxPlaylist.Name = "listBoxPlaylist";
            this.listBoxPlaylist.Size = new System.Drawing.Size(285, 224);
            this.listBoxPlaylist.TabIndex = 14;
            this.listBoxPlaylist.SelectedIndexChanged += new System.EventHandler(this.ListBoxPlaylist_SelectedIndexChanged);
            // 
            // buttonCreatePlaylist
            // 
            this.buttonCreatePlaylist.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCreatePlaylist.Location = new System.Drawing.Point(51, 12);
            this.buttonCreatePlaylist.Name = "buttonCreatePlaylist";
            this.buttonCreatePlaylist.Size = new System.Drawing.Size(150, 32);
            this.buttonCreatePlaylist.TabIndex = 15;
            this.buttonCreatePlaylist.Text = "Creeaza Playlist";
            this.buttonCreatePlaylist.UseVisualStyleBackColor = false;
            this.buttonCreatePlaylist.Click += new System.EventHandler(this.ButtonCreatePlaylist_Click);
            // 
            // buttonDeleteMedia
            // 
            this.buttonDeleteMedia.BackColor = System.Drawing.Color.DarkGray;
            this.buttonDeleteMedia.Location = new System.Drawing.Point(813, 12);
            this.buttonDeleteMedia.Name = "buttonDeleteMedia";
            this.buttonDeleteMedia.Size = new System.Drawing.Size(194, 32);
            this.buttonDeleteMedia.TabIndex = 16;
            this.buttonDeleteMedia.Text = "Sterge Media";
            this.buttonDeleteMedia.UseVisualStyleBackColor = false;
            this.buttonDeleteMedia.Click += new System.EventHandler(this.ButtonDeleteMedia_Click);
            // 
            // buttonUploadDeleteOnlinePlaylist
            // 
            this.buttonUploadDeleteOnlinePlaylist.BackColor = System.Drawing.Color.DarkGray;
            this.buttonUploadDeleteOnlinePlaylist.Location = new System.Drawing.Point(220, 12);
            this.buttonUploadDeleteOnlinePlaylist.Name = "buttonUploadDeleteOnlinePlaylist";
            this.buttonUploadDeleteOnlinePlaylist.Size = new System.Drawing.Size(180, 32);
            this.buttonUploadDeleteOnlinePlaylist.TabIndex = 17;
            this.buttonUploadDeleteOnlinePlaylist.Text = "Incarca Playlist Online";
            this.buttonUploadDeleteOnlinePlaylist.UseVisualStyleBackColor = false;
            this.buttonUploadDeleteOnlinePlaylist.Click += new System.EventHandler(this.ButtonUploadDeleteOnlinePlaylist_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.DarkGray;
            this.buttonHelp.Location = new System.Drawing.Point(84, 637);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(117, 43);
            this.buttonHelp.TabIndex = 18;
            this.buttonHelp.Text = "Ajutor";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // buttonLoadMedia
            // 
            this.buttonLoadMedia.BackColor = System.Drawing.Color.DarkGray;
            this.buttonLoadMedia.Location = new System.Drawing.Point(356, 435);
            this.buttonLoadMedia.Name = "buttonLoadMedia";
            this.buttonLoadMedia.Size = new System.Drawing.Size(150, 34);
            this.buttonLoadMedia.TabIndex = 19;
            this.buttonLoadMedia.Text = "Incarca Media";
            this.buttonLoadMedia.UseVisualStyleBackColor = false;
            this.buttonLoadMedia.Click += new System.EventHandler(this.ButtonLoadMedia_Click);
            // 
            // buttonDeletePlaylist
            // 
            this.buttonDeletePlaylist.BackColor = System.Drawing.Color.DarkGray;
            this.buttonDeletePlaylist.Location = new System.Drawing.Point(648, 12);
            this.buttonDeletePlaylist.Name = "buttonDeletePlaylist";
            this.buttonDeletePlaylist.Size = new System.Drawing.Size(150, 32);
            this.buttonDeletePlaylist.TabIndex = 20;
            this.buttonDeletePlaylist.Text = "Sterge Playlist";
            this.buttonDeletePlaylist.UseVisualStyleBackColor = false;
            this.buttonDeletePlaylist.Click += new System.EventHandler(this.ButtonDeletePlaylist_Click);
            // 
            // radioButtonRepeatPlayback
            // 
            this.radioButtonRepeatPlayback.AutoSize = true;
            this.radioButtonRepeatPlayback.Location = new System.Drawing.Point(29, 53);
            this.radioButtonRepeatPlayback.Name = "radioButtonRepeatPlayback";
            this.radioButtonRepeatPlayback.Size = new System.Drawing.Size(126, 20);
            this.radioButtonRepeatPlayback.TabIndex = 21;
            this.radioButtonRepeatPlayback.Text = "Repetare media";
            this.radioButtonRepeatPlayback.UseVisualStyleBackColor = true;
            // 
            // radioButtonSequentialPlayback
            // 
            this.radioButtonSequentialPlayback.AutoSize = true;
            this.radioButtonSequentialPlayback.Checked = true;
            this.radioButtonSequentialPlayback.Location = new System.Drawing.Point(29, 27);
            this.radioButtonSequentialPlayback.Name = "radioButtonSequentialPlayback";
            this.radioButtonSequentialPlayback.Size = new System.Drawing.Size(91, 20);
            this.radioButtonSequentialPlayback.TabIndex = 22;
            this.radioButtonSequentialPlayback.TabStop = true;
            this.radioButtonSequentialPlayback.Text = "Secvential";
            this.radioButtonSequentialPlayback.UseVisualStyleBackColor = true;
            // 
            // radioButtonShufflePlayback
            // 
            this.radioButtonShufflePlayback.AutoSize = true;
            this.radioButtonShufflePlayback.Location = new System.Drawing.Point(29, 79);
            this.radioButtonShufflePlayback.Name = "radioButtonShufflePlayback";
            this.radioButtonShufflePlayback.Size = new System.Drawing.Size(101, 20);
            this.radioButtonShufflePlayback.TabIndex = 23;
            this.radioButtonShufflePlayback.Text = "Amestecare";
            this.radioButtonShufflePlayback.UseVisualStyleBackColor = true;
            // 
            // groupBoxPlabackMethods
            // 
            this.groupBoxPlabackMethods.Controls.Add(this.radioButtonShufflePlayback);
            this.groupBoxPlabackMethods.Controls.Add(this.radioButtonSequentialPlayback);
            this.groupBoxPlabackMethods.Controls.Add(this.radioButtonRepeatPlayback);
            this.groupBoxPlabackMethods.Enabled = false;
            this.groupBoxPlabackMethods.ForeColor = System.Drawing.Color.White;
            this.groupBoxPlabackMethods.Location = new System.Drawing.Point(327, 581);
            this.groupBoxPlabackMethods.Name = "groupBoxPlabackMethods";
            this.groupBoxPlabackMethods.Size = new System.Drawing.Size(256, 126);
            this.groupBoxPlabackMethods.TabIndex = 24;
            this.groupBoxPlabackMethods.TabStop = false;
            this.groupBoxPlabackMethods.Text = "Metoda de redare a playlist-ului";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.ForeColor = System.Drawing.Color.White;
            this.labelDuration.Location = new System.Drawing.Point(535, 491);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(70, 25);
            this.labelDuration.TabIndex = 25;
            this.labelDuration.Text = "Durata";
            // 
            // buttonDownloadOnlinePlaylist
            // 
            this.buttonDownloadOnlinePlaylist.BackColor = System.Drawing.Color.DarkGray;
            this.buttonDownloadOnlinePlaylist.Location = new System.Drawing.Point(415, 12);
            this.buttonDownloadOnlinePlaylist.Name = "buttonDownloadOnlinePlaylist";
            this.buttonDownloadOnlinePlaylist.Size = new System.Drawing.Size(208, 32);
            this.buttonDownloadOnlinePlaylist.TabIndex = 26;
            this.buttonDownloadOnlinePlaylist.Text = "Descarca Playlist Online";
            this.buttonDownloadOnlinePlaylist.UseVisualStyleBackColor = false;
            this.buttonDownloadOnlinePlaylist.Click += new System.EventHandler(this.ButtonDownloadOnlinePlaylist_Click);
            // 
            // listBoxRecents
            // 
            this.listBoxRecents.BackColor = System.Drawing.Color.DarkGray;
            this.listBoxRecents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxRecents.FormattingEnabled = true;
            this.listBoxRecents.ItemHeight = 16;
            this.listBoxRecents.Location = new System.Drawing.Point(327, 94);
            this.listBoxRecents.Name = "listBoxRecents";
            this.listBoxRecents.Size = new System.Drawing.Size(229, 272);
            this.listBoxRecents.TabIndex = 27;
            this.listBoxRecents.SelectedIndexChanged += new System.EventHandler(this.ListBoxPlaylistAudioMediaAndListBoxRecents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(324, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Media recent";
            // 
            // FormAudioMediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1049, 719);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxRecents);
            this.Controls.Add(this.buttonDownloadOnlinePlaylist);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.groupBoxPlabackMethods);
            this.Controls.Add(this.buttonDeletePlaylist);
            this.Controls.Add(this.buttonLoadMedia);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonUploadDeleteOnlinePlaylist);
            this.Controls.Add(this.buttonDeleteMedia);
            this.Controls.Add(this.buttonCreatePlaylist);
            this.Controls.Add(this.listBoxPlaylist);
            this.Controls.Add(this.labelPlaylists);
            this.Controls.Add(this.labelPlaylistAudioMedia);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.listBoxPlaylistAudioMedia);
            this.Controls.Add(this.labelArtist);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.labelAudioMediaTitle);
            this.Controls.Add(this.pictureBoxAudioMedia);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonPlayPause);
            this.Controls.Add(this.trackBarTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAudioMediaPlayer";
            this.Text = "Audio Media Player";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAudioMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).EndInit();
            this.groupBoxPlabackMethods.ResumeLayout(false);
            this.groupBoxPlabackMethods.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.ListBox listBoxPlaylistAudioMedia;
        private System.Windows.Forms.Button buttonPlayPause;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.PictureBox pictureBoxAudioMedia;
        private System.Windows.Forms.Label labelAudioMediaTitle;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.TrackBar trackBarTime;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label labelPlaylistAudioMedia;
        private System.Windows.Forms.Label labelPlaylists;
        private System.Windows.Forms.ListBox listBoxPlaylist;
        private System.Windows.Forms.Button buttonCreatePlaylist;
        private System.Windows.Forms.Button buttonDeleteMedia;
        private System.Windows.Forms.Button buttonUploadDeleteOnlinePlaylist;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonLoadMedia;
        private System.Windows.Forms.Button buttonDeletePlaylist;
        private System.Windows.Forms.RadioButton radioButtonRepeatPlayback;
        private System.Windows.Forms.RadioButton radioButtonSequentialPlayback;
        private System.Windows.Forms.RadioButton radioButtonShufflePlayback;
        private System.Windows.Forms.GroupBox groupBoxPlabackMethods;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Button buttonDownloadOnlinePlaylist;
        private System.Windows.Forms.ListBox listBoxRecents;
        private System.Windows.Forms.Label label1;
    }
}

