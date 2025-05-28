namespace MediaPlayer.View
{
    partial class FormDownloadPlaylist
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
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.listBoxPlaylists = new System.Windows.Forms.ListBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listBoxMedia = new System.Windows.Forms.ListBox();
            this.labelPlaylists = new System.Windows.Forms.Label();
            this.labelAudioMediaList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPlaylistDownload = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxPlaylistDownload.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFilter.Location = new System.Drawing.Point(83, 46);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(312, 15);
            this.textBoxFilter.TabIndex = 0;
            // 
            // listBoxPlaylists
            // 
            this.listBoxPlaylists.BackColor = System.Drawing.Color.DarkGray;
            this.listBoxPlaylists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPlaylists.FormattingEnabled = true;
            this.listBoxPlaylists.ItemHeight = 16;
            this.listBoxPlaylists.Location = new System.Drawing.Point(28, 137);
            this.listBoxPlaylists.Name = "listBoxPlaylists";
            this.listBoxPlaylists.Size = new System.Drawing.Size(187, 208);
            this.listBoxPlaylists.TabIndex = 1;
            this.listBoxPlaylists.SelectedIndexChanged += new System.EventHandler(this.ListBoxPlaylists_SelectedIndexChanged);
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.Color.DarkGray;
            this.buttonDownload.Location = new System.Drawing.Point(83, 355);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(83, 27);
            this.buttonDownload.TabIndex = 2;
            this.buttonDownload.Text = "Descarca";
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.Location = new System.Drawing.Point(312, 355);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 27);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Anulare";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // listBoxMedia
            // 
            this.listBoxMedia.BackColor = System.Drawing.Color.DarkGray;
            this.listBoxMedia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxMedia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxMedia.FormattingEnabled = true;
            this.listBoxMedia.ItemHeight = 16;
            this.listBoxMedia.Location = new System.Drawing.Point(256, 137);
            this.listBoxMedia.Name = "listBoxMedia";
            this.listBoxMedia.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxMedia.Size = new System.Drawing.Size(186, 208);
            this.listBoxMedia.TabIndex = 4;
            // 
            // labelPlaylists
            // 
            this.labelPlaylists.AutoSize = true;
            this.labelPlaylists.ForeColor = System.Drawing.Color.White;
            this.labelPlaylists.Location = new System.Drawing.Point(25, 104);
            this.labelPlaylists.Name = "labelPlaylists";
            this.labelPlaylists.Size = new System.Drawing.Size(98, 16);
            this.labelPlaylists.TabIndex = 6;
            this.labelPlaylists.Text = "Lista playlist-uri";
            // 
            // labelAudioMediaList
            // 
            this.labelAudioMediaList.AutoSize = true;
            this.labelAudioMediaList.ForeColor = System.Drawing.Color.White;
            this.labelAudioMediaList.Location = new System.Drawing.Point(253, 104);
            this.labelAudioMediaList.Name = "labelAudioMediaList";
            this.labelAudioMediaList.Size = new System.Drawing.Size(142, 16);
            this.labelAudioMediaList.TabIndex = 7;
            this.labelAudioMediaList.Text = "Lista media din playlist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filtrare playlist-uri dupa nume";
            // 
            // groupBoxPlaylistDownload
            // 
            this.groupBoxPlaylistDownload.Controls.Add(this.buttonSearch);
            this.groupBoxPlaylistDownload.Controls.Add(this.label1);
            this.groupBoxPlaylistDownload.Controls.Add(this.textBoxFilter);
            this.groupBoxPlaylistDownload.Controls.Add(this.labelAudioMediaList);
            this.groupBoxPlaylistDownload.Controls.Add(this.listBoxPlaylists);
            this.groupBoxPlaylistDownload.Controls.Add(this.labelPlaylists);
            this.groupBoxPlaylistDownload.Controls.Add(this.buttonDownload);
            this.groupBoxPlaylistDownload.Controls.Add(this.listBoxMedia);
            this.groupBoxPlaylistDownload.Controls.Add(this.buttonCancel);
            this.groupBoxPlaylistDownload.Location = new System.Drawing.Point(20, 22);
            this.groupBoxPlaylistDownload.Name = "groupBoxPlaylistDownload";
            this.groupBoxPlaylistDownload.Size = new System.Drawing.Size(475, 397);
            this.groupBoxPlaylistDownload.TabIndex = 9;
            this.groupBoxPlaylistDownload.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.Location = new System.Drawing.Point(199, 67);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(85, 34);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Cauta";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // FormDownloadPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(522, 441);
            this.Controls.Add(this.groupBoxPlaylistDownload);
            this.Name = "FormDownloadPlaylist";
            this.Text = "Download Playlist";
            this.groupBoxPlaylistDownload.ResumeLayout(false);
            this.groupBoxPlaylistDownload.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.ListBox listBoxPlaylists;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListBox listBoxMedia;
        private System.Windows.Forms.Label labelPlaylists;
        private System.Windows.Forms.Label labelAudioMediaList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPlaylistDownload;
        private System.Windows.Forms.Button buttonSearch;
    }
}