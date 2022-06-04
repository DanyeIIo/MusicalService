using MusicalService.Domain.DatabaseEntities.Domain;

namespace MusicalService.Domain.DatabaseEntities.Music;
public sealed class SongGenreEntity : IEntity
{
    public long SongId { get; set; }

    public long GenreId { get; set; }

    public SongEntity SongEntity{ get; set; }
    
    public GenreEntity GenreEntity{ get; set; }
}
