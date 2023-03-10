//@GeneratedCode
namespace QTMusicStore.AppLogic.Models.App
{
    ///
    /// Generated by the generator
    ///
    public partial class Genre
    {
        ///
        /// Generated by the generator
        ///
        static Genre()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public Genre()
        {
            Constructing();
            
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        
        new internal Entities.App.Genre Source
        {
            get => (Entities.App.Genre)(_source ??= new Entities.App.Genre());
            set => _source = value;
        }
        
        public System.String Name
        {
            get => Source.Name;
            set => Source.Name = value;
        }
        
        public System.Collections.Generic.List<QTMusicStore.AppLogic.Models.App.Track> Tracks
        {
            get => Source.Tracks.Select(e => QTMusicStore.AppLogic.Models.App.Track.Create(e)).ToList();
            set => Source.Tracks = value.Select(e => e.Source).ToList();
        }
        ///
        /// Generated by the generator
        ///
        internal void CopyProperties(Entities.App.Genre other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                Name = other.Name;
                Tracks = other.Tracks.Select(e => QTMusicStore.AppLogic.Models.App.Track.Create((object)e)).ToList();
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(Entities.App.Genre other, ref bool handled);
        partial void AfterCopyProperties(Entities.App.Genre other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTMusicStore.AppLogic.Models.App.Genre other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                Name = other.Name;
                Tracks = other.Tracks.Select(e => QTMusicStore.AppLogic.Models.App.Track.Create((object)e)).ToList();
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTMusicStore.AppLogic.Models.App.Genre other, ref bool handled);
        partial void AfterCopyProperties(QTMusicStore.AppLogic.Models.App.Genre other);
        ///
        /// Generated by the generator
        ///
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.App.Genre other)
            {
                result = Id == other.Id;
            }
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Tracks, Id);
        }
        ///
        /// Generated by the generator
        ///
        public static QTMusicStore.AppLogic.Models.App.Genre Create()
        {
            BeforeCreate();
            var result = new QTMusicStore.AppLogic.Models.App.Genre();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTMusicStore.AppLogic.Models.App.Genre Create(object other)
        {
            BeforeCreate(other);
            var result = new QTMusicStore.AppLogic.Models.App.Genre();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTMusicStore.AppLogic.Models.App.Genre Create(QTMusicStore.AppLogic.Models.App.Genre other)
        {
            BeforeCreate(other);
            var result = new QTMusicStore.AppLogic.Models.App.Genre();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTMusicStore.AppLogic.Models.App.Genre Create(Entities.App.Genre other)
        {
            BeforeCreate(other);
            var result = new QTMusicStore.AppLogic.Models.App.Genre();
            result.Source = other;
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTMusicStore.AppLogic.Models.App.Genre instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTMusicStore.AppLogic.Models.App.Genre instance, object other);
        static partial void BeforeCreate(QTMusicStore.AppLogic.Models.App.Genre other);
        static partial void AfterCreate(QTMusicStore.AppLogic.Models.App.Genre instance, QTMusicStore.AppLogic.Models.App.Genre other);
        static partial void BeforeCreate(Entities.App.Genre other);
        static partial void AfterCreate(QTMusicStore.AppLogic.Models.App.Genre instance, Entities.App.Genre other);
    }
}
