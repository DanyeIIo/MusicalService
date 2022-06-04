using MusicalService.Domain.DatabaseEntities.Domain;

namespace MusicalService.Domain.DatabaseEntities.Music;
public sealed class GenreEntity : IEntity, IUniqueIdentifier<long>, IName
{
    public long Id { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }

    public ICollection<SongGenreEntity> SongGenreEntities { get; set; }
}
