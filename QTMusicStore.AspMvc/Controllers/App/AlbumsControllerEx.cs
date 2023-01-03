#if GENERATEDCODE_ON
using System;
namespace QTMusicStore.AspMvc.Controllers.App
{
	partial class AlbumsController
	{
        private AppLogic.Models.App.Artist[] _artists;

        private AppLogic.Models.App.Artist[] Artists
        {
            get
            {
                if (_artists == null)
                {
                    using var ctrl = new AppLogic.Controllers.App.ArtistsController();

                    _artists = Task.Run(async () => await ctrl.GetAllAsync()).Result;
                }
                return _artists ?? Array.Empty<AppLogic.Models.App.Artist>();
            }
        }

        protected override IEnumerable<Models.App.Album> BeforeView(IEnumerable<Models.App.Album> viewModels, ActionMode actionMode)
        {
            var models = viewModels.ToArray();

            foreach (var item in models)
            {
                item.ArtistName = Artists.FirstOrDefault(e => e.Id == item.ArtistId)?.Name;
            }
            return base.BeforeView(models, actionMode);
        }
    }
}
#endif