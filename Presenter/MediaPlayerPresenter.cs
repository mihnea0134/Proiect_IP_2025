using MediaPlayer.Core.Interfaces;

namespace MediaPlayer.Presenter
{
    public class MediaPlayerPresenter: IPresenter
    {
        private readonly IView _view;
        private readonly IModel _model;

        public MediaPlayerPresenter(IView view, IModel model)
        {
            _view = view;
            _model = model;
        }
    }
}
