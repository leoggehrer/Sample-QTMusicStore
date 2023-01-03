using System;
namespace QTMusicStore.AppLogic.Entities.App
{
#if SQLITE_ON
    [Table("Tracks")]
#else
    [Table("Tracks", Schema = "app")]
#endif
    public partial class Track : VersionEntity
    {
        public int AlbumId { get; set; }
        public int GenreId { get; set; }

        [MaxLength(1024)]
        public string Title { get; set; } = string.Empty;
        [MaxLength(512)]
        public string? Composer { get; set; }
        public long Millisconds { get; set; }
        public long Bytes { get; set; }
        public decimal UnitPrice { get; set; }

        #region Navigation properties
        public Album? Album { get; set; }
        public Genre? Genre { get; set; }
        #endregion Navigation properties
    }
}

