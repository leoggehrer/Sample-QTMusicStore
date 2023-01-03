using System;
namespace QTMusicStore.AppLogic.Entities.App
{
#if SQLITE_ON
    [Table("Artists")]
#else
    [Table("Artists", Schema = "app")]
#endif
    public class Artist : VersionEntity
	{
        [MaxLength(128)]
        public string Name { get; set; } = String.Empty;

        #region Navigation properties
        public List<Album> Albums { get; set; } = new();
        #endregion Navigation properties
    }
}

