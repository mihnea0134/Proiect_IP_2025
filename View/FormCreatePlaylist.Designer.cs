namespace MediaPlayer.View
{
    partial class FormCreatePlaylist
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
            this.textBoxPlaylistName = new System.Windows.Forms.TextBox();
            this.labelPlaylistName = new System.Windows.Forms.Label();
            this.buttonCreatePlaylist = new System.Windows.Forms.Button();
            this.listBoxSongsForPlaylist = new System.Windows.Forms.ListBox();
            this.buttonAddSongsPlaylist = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPlaylistName
            // 
            this.textBoxPlaylistName.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxPlaylistName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPlaylistName.Location = new System.Drawing.Point(39, 52);
            this.textBoxPlaylistName.Name = "textBoxPlaylistName";
            this.textBoxPlaylistName.Size = new System.Drawing.Size(364, 15);
            this.textBoxPlaylistName.TabIndex = 0;
            // 
            // labelPlaylistName
            // 
            this.labelPlaylistName.AutoSize = true;
            this.labelPlaylistName.ForeColor = System.Drawing.Color.White;
            this.labelPlaylistName.Location = new System.Drawing.Point(138, 18);
            this.labelPlaylistName.Name = "labelPlaylistName";
            this.labelPlaylistName.Size = new System.Drawing.Size(139, 16);
            this.labelPlaylistName.TabIndex = 1;
            this.labelPlaylistName.Text = "Numele pentru playlist";
            // 
            // buttonCreatePlaylist
            // 
            this.buttonCreatePlaylist.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCreatePlaylist.Location = new System.Drawing.Point(39, 328);
            this.buttonCreatePlaylist.Name = "buttonCreatePlaylist";
            this.buttonCreatePlaylist.Size = new System.Drawing.Size(99, 32);
            this.buttonCreatePlaylist.TabIndex = 2;
            this.buttonCreatePlaylist.Text = "Creeaza";
            this.buttonCreatePlaylist.UseVisualStyleBackColor = false;
            this.buttonCreatePlaylist.Click += new System.EventHandler(this.CreatePlaylist_Click);
            // 
            // listBoxSongsForPlaylist
            // 
            this.listBoxSongsForPlaylist.BackColor = System.Drawing.Color.DarkGray;
            this.listBoxSongsForPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSongsForPlaylist.FormattingEnabled = true;
            this.listBoxSongsForPlaylist.ItemHeight = 16;
            this.listBoxSongsForPlaylist.Location = new System.Drawing.Point(39, 145);
            this.listBoxSongsForPlaylist.Name = "listBoxSongsForPlaylist";
            this.listBoxSongsForPlaylist.Size = new System.Drawing.Size(364, 144);
            this.listBoxSongsForPlaylist.TabIndex = 3;
            // 
            // buttonAddSongsPlaylist
            // 
            this.buttonAddSongsPlaylist.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAddSongsPlaylist.Location = new System.Drawing.Point(141, 91);
            this.buttonAddSongsPlaylist.Name = "buttonAddSongsPlaylist";
            this.buttonAddSongsPlaylist.Size = new System.Drawing.Size(152, 32);
            this.buttonAddSongsPlaylist.TabIndex = 4;
            this.buttonAddSongsPlaylist.Text = "Adauga fisiere";
            this.buttonAddSongsPlaylist.UseVisualStyleBackColor = false;
            this.buttonAddSongsPlaylist.Click += new System.EventHandler(this.AddMediaToPlaylist_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.Location = new System.Drawing.Point(307, 328);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(96, 32);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Anuleaza";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonAddSongsPlaylist);
            this.groupBox1.Controls.Add(this.listBoxSongsForPlaylist);
            this.groupBox1.Controls.Add(this.buttonCreatePlaylist);
            this.groupBox1.Controls.Add(this.labelPlaylistName);
            this.groupBox1.Controls.Add(this.textBoxPlaylistName);
            this.groupBox1.Location = new System.Drawing.Point(26, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 377);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // FormCreatePlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(495, 418);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCreatePlaylist";
            this.Text = "Create Playlist";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPlaylistName;
        private System.Windows.Forms.Label labelPlaylistName;
        private System.Windows.Forms.Button buttonCreatePlaylist;
        private System.Windows.Forms.ListBox listBoxSongsForPlaylist;
        private System.Windows.Forms.Button buttonAddSongsPlaylist;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}