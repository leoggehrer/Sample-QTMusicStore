using System;
namespace QTMusicStore.AppLogic.Entities.App
{
#if SQLITE_ON
    [Table("Albums")]
#else
    [Table("Albums", Schema = "app")]
#endif
    public partial class Album : VersionEntity
	{
        public int ArtistId { get; set; }
        [MaxLength(256)]
        public string Title { get; set; } = String.Empty;

        #region Navigation properties
        public Artist? Artist { get; set; }
        #endregion Navigation properties
    }
}

