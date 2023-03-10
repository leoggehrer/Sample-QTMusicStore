//@GeneratedCode
namespace QTMusicStore.WebApi.Controllers.App
{
    ///
    /// Generated by the generator
    ///
    public sealed partial class ArtistsController : Controllers.GenericController<QTMusicStore.AppLogic.Models.App.Artist, QTMusicStore.WebApi.Models.App.ArtistEdit, QTMusicStore.WebApi.Models.App.Artist>
    {
        ///
        /// Generated by the generator
        ///
        static ArtistsController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public ArtistsController(QTMusicStore.AppLogic.Contracts.App.IArtistsAccess<QTMusicStore.AppLogic.Models.App.Artist> other)
        : base(other)
        {
            Constructing();
            
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        protected override QTMusicStore.WebApi.Models.App.Artist ToOutModel(QTMusicStore.AppLogic.Models.App.Artist accessModel)
        {
            var handled = false;
            var result = default(QTMusicStore.WebApi.Models.App.Artist);
            BeforeToOutModel(accessModel, ref result, ref handled);
            if (handled == false || result == null)
            {
                result = QTMusicStore.WebApi.Models.App.Artist.Create(accessModel);
            }
            AfterToOutModel(result);
            return result;
        }
        partial void BeforeToOutModel(QTMusicStore.AppLogic.Models.App.Artist accessModel, ref QTMusicStore.WebApi.Models.App.Artist? outModel, ref bool handled);
        partial void AfterToOutModel(QTMusicStore.WebApi.Models.App.Artist outModel);
    }
}
