namespace Proiect_IP_2025
{
    partial class Form2
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
            this.PlaylistName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreatePlaylist = new System.Windows.Forms.Button();
            this.SongsForPlaylistListBox = new System.Windows.Forms.ListBox();
            this.AddSongsPlaylist = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlaylistName
            // 
            this.PlaylistName.Location = new System.Drawing.Point(54, 54);
            this.PlaylistName.Name = "PlaylistName";
            this.PlaylistName.Size = new System.Drawing.Size(364, 22);
            this.PlaylistName.TabIndex = 0;
            this.PlaylistName.TextChanged += new System.EventHandler(this.PlaylistName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name for the new playlist:";
            // 
            // CreatePlaylist
            // 
            this.CreatePlaylist.Location = new System.Drawing.Point(54, 330);
            this.CreatePlaylist.Name = "CreatePlaylist";
            this.CreatePlaylist.Size = new System.Drawing.Size(99, 32);
            this.CreatePlaylist.TabIndex = 2;
            this.CreatePlaylist.Text = "Create";
            this.CreatePlaylist.UseVisualStyleBackColor = true;
            this.CreatePlaylist.Click += new System.EventHandler(this.CreatePlaylist_Click);
            // 
            // SongsForPlaylistListBox
            // 
            this.SongsForPlaylistListBox.FormattingEnabled = true;
            this.SongsForPlaylistListBox.ItemHeight = 16;
            this.SongsForPlaylistListBox.Location = new System.Drawing.Point(54, 147);
            this.SongsForPlaylistListBox.Name = "SongsForPlaylistListBox";
            this.SongsForPlaylistListBox.Size = new System.Drawing.Size(364, 148);
            this.SongsForPlaylistListBox.TabIndex = 3;
            // 
            // AddSongsPlaylist
            // 
            this.AddSongsPlaylist.Location = new System.Drawing.Point(179, 99);
            this.AddSongsPlaylist.Name = "AddSongsPlaylist";
            this.AddSongsPlaylist.Size = new System.Drawing.Size(106, 32);
            this.AddSongsPlaylist.TabIndex = 4;
            this.AddSongsPlaylist.Text = "Add Songs";
            this.AddSongsPlaylist.UseVisualStyleBackColor = true;
            this.AddSongsPlaylist.Click += new System.EventHandler(this.AddSongsPlaylist_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancelButton);
            this.groupBox1.Controls.Add(this.AddSongsPlaylist);
            this.groupBox1.Controls.Add(this.SongsForPlaylistListBox);
            this.groupBox1.Controls.Add(this.CreatePlaylist);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PlaylistName);
            this.groupBox1.Location = new System.Drawing.Point(34, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 377);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(322, 330);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(96, 32);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 428);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Create Playlist";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PlaylistName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreatePlaylist;
        private System.Windows.Forms.ListBox SongsForPlaylistListBox;
        private System.Windows.Forms.Button AddSongsPlaylist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelButton;
    }
}