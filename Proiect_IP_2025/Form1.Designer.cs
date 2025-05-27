namespace Proiect_IP_2025
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
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.QueueList = new System.Windows.Forms.ListBox();
            this.AddMusicButton = new System.Windows.Forms.Button();
            this.Play_StopButton = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SongLabelTitle = new System.Windows.Forms.Label();
            this.ArtistLabel = new System.Windows.Forms.Label();
            this.PositionBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionBar)).BeginInit();
            this.SuspendLayout();
            // 
            // VolumeBar
            // 
            this.VolumeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VolumeBar.Location = new System.Drawing.Point(542, 577);
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.VolumeBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VolumeBar.Size = new System.Drawing.Size(56, 84);
            this.VolumeBar.TabIndex = 5;
            this.VolumeBar.TickFrequency = 0;
            this.VolumeBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // QueueList
            // 
            this.QueueList.FormattingEnabled = true;
            this.QueueList.ItemHeight = 16;
            this.QueueList.Location = new System.Drawing.Point(12, 69);
            this.QueueList.Name = "QueueList";
            this.QueueList.Size = new System.Drawing.Size(252, 276);
            this.QueueList.TabIndex = 7;
            this.QueueList.SelectedIndexChanged += new System.EventHandler(this.QueueList_SelectedIndexChanged);
            // 
            // AddMusicButton
            // 
            this.AddMusicButton.Location = new System.Drawing.Point(12, 27);
            this.AddMusicButton.Name = "AddMusicButton";
            this.AddMusicButton.Size = new System.Drawing.Size(120, 23);
            this.AddMusicButton.TabIndex = 8;
            this.AddMusicButton.Text = "Add Music...";
            this.AddMusicButton.UseVisualStyleBackColor = true;
            this.AddMusicButton.Click += new System.EventHandler(this.AddMusicButton_Click);
            // 
            // Play_StopButton
            // 
            this.Play_StopButton.Location = new System.Drawing.Point(505, 530);
            this.Play_StopButton.Name = "Play_StopButton";
            this.Play_StopButton.Size = new System.Drawing.Size(126, 32);
            this.Play_StopButton.TabIndex = 0;
            this.Play_StopButton.Text = "Play";
            this.Play_StopButton.UseVisualStyleBackColor = true;
            this.Play_StopButton.Click += new System.EventHandler(this.Play_StopButton_Click);
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(388, 530);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(81, 32);
            this.Previous.TabIndex = 1;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(663, 530);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(78, 32);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Proiect_IP_2025.Properties.Resources.no_album_art__no_cover___placeholder_picture_by_cmdrobot_d7kpm65_fullview;
            this.pictureBox1.Location = new System.Drawing.Point(343, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SongLabelTitle
            // 
            this.SongLabelTitle.AutoEllipsis = true;
            this.SongLabelTitle.AutoSize = true;
            this.SongLabelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SongLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongLabelTitle.Location = new System.Drawing.Point(473, 366);
            this.SongLabelTitle.Name = "SongLabelTitle";
            this.SongLabelTitle.Size = new System.Drawing.Size(185, 42);
            this.SongLabelTitle.TabIndex = 4;
            this.SongLabelTitle.Text = "TitleSong";
            this.SongLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SongLabelTitle.Click += new System.EventHandler(this.SongLabelTitle_Click);
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.AutoSize = true;
            this.ArtistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistLabel.Location = new System.Drawing.Point(500, 419);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Size = new System.Drawing.Size(131, 29);
            this.ArtistLabel.TabIndex = 6;
            this.ArtistLabel.Text = "ArtistName";
            this.ArtistLabel.Click += new System.EventHandler(this.ArtistLabel_Click);
            // 
            // PositionBar
            // 
            this.PositionBar.Location = new System.Drawing.Point(388, 460);
            this.PositionBar.Maximum = 100;
            this.PositionBar.Name = "PositionBar";
            this.PositionBar.Size = new System.Drawing.Size(396, 56);
            this.PositionBar.TabIndex = 9;
            this.PositionBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.PositionBar.Scroll += new System.EventHandler(this.PositionBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Volume:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.IndianRed;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(510, 496);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 20);
            this.TimeLabel.TabIndex = 11;
            this.TimeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Queued Songs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Playlists";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(802, 673);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PositionBar);
            this.Controls.Add(this.AddMusicButton);
            this.Controls.Add(this.QueueList);
            this.Controls.Add(this.ArtistLabel);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.SongLabelTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Play_StopButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PositionBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.ListBox QueueList;
        private System.Windows.Forms.Button AddMusicButton;
        private System.Windows.Forms.Button Play_StopButton;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SongLabelTitle;
        private System.Windows.Forms.Label ArtistLabel;
        private System.Windows.Forms.TrackBar PositionBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

