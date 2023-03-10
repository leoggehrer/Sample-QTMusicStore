//@GeneratedCode
namespace QTMusicStore.AppLogic.DataContext
{
    ///
    /// Generated by the generator
    ///
    partial class ProjectDbContext
    {
        ///
        /// Generated by the generator
        ///
        public DbSet<Entities.App.Album>? AlbumSet{ get; set; }
        ///
        /// Generated by the generator
        ///
        public DbSet<Entities.App.Artist>? ArtistSet{ get; set; }
        ///
        /// Generated by the generator
        ///
        public DbSet<Entities.App.Genre>? GenreSet{ get; set; }
        ///
        /// Generated by the generator
        ///
        public DbSet<Entities.App.Track>? TrackSet{ get; set; }
        
        ///
        /// Generated by the generator
        ///
        partial void GetGeneratorDbSet<E>(ref DbSet<E>? dbSet, ref bool handled) where E : Entities.EntityObject
        {
            if (typeof(E) == typeof(Entities.App.Album))
            {
                dbSet = AlbumSet as DbSet<E>;
                handled = true;
            }
            else if (typeof(E) == typeof(Entities.App.Artist))
            {
                dbSet = ArtistSet as DbSet<E>;
                handled = true;
            }
            else if (typeof(E) == typeof(Entities.App.Genre))
            {
                dbSet = GenreSet as DbSet<E>;
                handled = true;
            }
            else if (typeof(E) == typeof(Entities.App.Track))
            {
                dbSet = TrackSet as DbSet<E>;
                handled = true;
            }
        }
    }
}
