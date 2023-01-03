#if GENERATEDCODE_ON
using System;
namespace QTMusicStore.AspMvc.Controllers.App
{
    partial class TracksController
    {
        private AppLogic.Models.App.Genre[] _genres;

        private AppLogic.Models.App.Genre[] Genres
        {
            get
            {
                if (_genres == null)
                {
                    using var ctrl = new AppLogic.Controllers.App.GenresController();

                    _genres = Task.Run(async () => await ctrl.GetAllAsync()).Result;
                }
                return _genres ?? Array.Empty<AppLogic.Models.App.Genre>();
            }
        }
        private AppLogic.Models.App.Album[] _albums;

        private AppLogic.Models.App.Album[] Albums
        {
            get
            {
                if (_albums == null)
                {
                    using var ctrl = new AppLogic.Controllers.App.AlbumsController();

                    _albums = Task.Run(async () => await ctrl.GetAllAsync()).Result;
                }
                return _albums ?? Array.Empty<AppLogic.Models.App.Album>();
            }
        }

        protected override IEnumerable<Models.App.Track> BeforeView(IEnumerable<Models.App.Track> viewModels, ActionMode actionMode)
        {
            var models = viewModels.ToArray();

            foreach (var viewModel in models)
            {
                viewModel.GenreName = Genres.FirstOrDefault(e => e.Id == viewModel.GenerId)?.Name;
                viewModel.AlbumTitle = Albums.FirstOrDefault(e => e.Id == viewModel.AlbumId)?.Title;
            }
            return base.BeforeView(models, actionMode);
        }
    }
}
#endif
