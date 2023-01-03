namespace QTMusicStore.ConApp
{
    partial class Program
    {
        static partial void AfterRun()
        {
            var csvGenres = File.ReadAllLines("Data/Genre.csv")
                            .Skip(1)
                            .Select(l => l.Split(";"))
                            .Select(d => new
                            {
                                id = d[0],
                                Entity = new AppLogic.Models.App.Genre
                                {
                                    Name = d[1]
                                }
                            }).ToArray();
            var csvArtists = File.ReadAllLines("Data/Artist.csv")
                             .Skip(1)
                             .Select(l => l.Split(";"))
                             .Select(d => new
                             {
                                 id = d[0],
                                 Entity = new AppLogic.Models.App.Artist
                                 {
                                     Name = d[1],
                                 }
                             }).ToArray();
            var csvAlbums = File.ReadAllLines("Data/Album.csv")
                             .Skip(1)
                             .Select(l => l.Split(";"))
                             .Select(d => new
                             {
                                 id = d[0],
                                 artistId = d[2],
                                 Entity = new AppLogic.Models.App.Album
                                 {
                                     Title = d[1],
                                 }
                             }).ToArray();
            var csvTracks = File.ReadAllLines("Data/Track.csv")
                             .Skip(1)
                             .Select(l => l.Split(";"))
                             .Select(d => new
                             {
                                 id = d[0],
                                 albumId = d[2],
                                 genreId = d[3],
                                 Entity = new AppLogic.Models.App.Track
                                 {
                                     Title = d[1],
                                     Composer = d[4],
                                     Millisconds = Convert.ToInt64(d[5]),
                                     Bytes = Convert.ToInt64(d[6]),
                                     UnitPrice = Convert.ToDecimal(d[7]),
                                 }
                             }).ToArray();
            var artists = csvArtists.Select(e => e.Entity).ToArray();
            var genres = csvGenres.Select(e => e.Entity).ToArray();
            var albums = new List<AppLogic.Entities.App.Album>();

            foreach (var item in csvAlbums)
            {
                item.Entity.Artist = csvArtists.FirstOrDefault(e => e.id == item.artistId)?.Entity;
            }

            foreach (var item in csvTracks)
            {
                item.Entity.Album = csvAlbums.FirstOrDefault(e => e.id == item.albumId)?.Entity;
                item.Entity.Genre = csvGenres.FirstOrDefault(e => e.id == item.genreId)?.Entity;
            }

            Task.Run(async () =>
            {
                using var ctrl = new AppLogic.Controllers.App.TracksController();

                await ctrl.InsertAsync(csvTracks.Select(e => e.Entity));
                await ctrl.SaveChangesAsync();
            }).Wait();
        }
    }
}
