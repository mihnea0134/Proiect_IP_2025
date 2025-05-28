using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MediaPlayer.Core.Interfaces;

namespace MediaPlayer.View
{
    public partial class FormAudioMediaPlayer : Form, IView
    {
        private IPresenter _presenter;
        private IModel _model;

        public FormAudioMediaPlayer()
        {
            InitializeComponent();
        }

        public void SetPresenter(IPresenter presenter)
        {
            _presenter = presenter;
        }

        public void SetModel(IModel model)
        {
            _model = model;
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCreatePlaylist_Click(object sender, EventArgs e)
        {

        }

        private void ButtonUploadDeleteOnlinePlaylist_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDownloadOnlinePlaylist_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDeletePlaylist_Click(object sender, EventArgs e)
        {

        }

        private void ButtonLoadMedia_Click(object sender, EventArgs e)
        {

        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPlayStop_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {

        }

        private void ListBoxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TrackBarTime_Scroll(object sender, EventArgs e)
        {

        }

        private void TrackBarVolume_Scroll(object sender, EventArgs e)
        {

        }

        private void ListBoxPlaylistAudioMediaAndListBoxRecents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonDeleteMedia_Click(object sender, EventArgs e)
        {

        }
    }
}
