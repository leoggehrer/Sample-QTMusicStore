﻿//@GeneratedCode
namespace QTMusicStore.AppLogic.Facades.App
{
    using TOutModel = Models.App.Track;
    ///
    /// Generated by the generator
    ///
    public sealed partial class TracksFacade : ControllerFacade<TOutModel>, Contracts.App.ITracksAccess<TOutModel>
    {
        ///
        /// Generated by the generator
        ///
        static TracksFacade()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public TracksFacade()
        : base(new QTMusicStore.AppLogic.Controllers.App.TracksController())
        {
            Constructing();
            
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        public TracksFacade(FacadeObject facadeObject)
        : base(new QTMusicStore.AppLogic.Controllers.App.TracksController(facadeObject.ControllerObject))
        {
            Constructing();
            
            Constructed();
        }
    }
}