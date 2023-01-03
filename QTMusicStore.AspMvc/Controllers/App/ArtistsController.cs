﻿//@GeneratedCode
namespace QTMusicStore.AspMvc.Controllers.App
{
    using Microsoft.AspNetCore.Mvc;
    using TAccessModel = QTMusicStore.AppLogic.Models.App.Artist;
    using TViewModel = QTMusicStore.AspMvc.Models.App.Artist;
    using TFilterModel = QTMusicStore.AspMvc.Models.App.ArtistFilter;
    using TAccessContract = QTMusicStore.AppLogic.Contracts.App.IArtistsAccess<QTMusicStore.AppLogic.Models.App.Artist>;
    ///
    /// Generated by the generator
    ///
    public sealed partial class ArtistsController : Controllers.FilterGenericController<TAccessModel, TViewModel, TFilterModel, TAccessContract>
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
        
        protected override string ControllerName => "Artists";
        ///
        /// Generated by the generator
        ///
        public ArtistsController(QTMusicStore.AppLogic.Contracts.App.IArtistsAccess<TAccessModel> other)
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
        protected override TViewModel ToViewModel(TAccessModel accessModel, ActionMode actionMode)
        {
            var handled = false;
            var result = default(TViewModel);
            BeforeToViewModel(accessModel, actionMode, ref result, ref handled);
            if (handled == false || result == null)
            {
                result = TViewModel.Create(accessModel);
            }
            AfterToViewModel(result, actionMode);
            return BeforeView(result, actionMode);
        }
        partial void BeforeToViewModel(TAccessModel accessModel, ActionMode actionMode, ref TViewModel? viewModel, ref bool handled);
        partial void AfterToViewModel(TViewModel viewModel, ActionMode actionMode);
    }
}
