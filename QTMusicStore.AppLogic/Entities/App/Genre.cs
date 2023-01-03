using System;
namespace QTMusicStore.AppLogic.Entities.App
{
#if SQLITE_ON
    [Table("Genres")]
#else
    [Table("Genres", Schema = "app")]
#endif
    public partial class Genre : VersionEntity
	{
        [MaxLength(128)]
        public string Name { get; set; } = String.Empty;

        #region Navigation properties
        public List<Track> Tracks { get; set; } = new();
        #endregion Navigation properties
    }
}

