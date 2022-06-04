using MusicalService.Domain.DatabaseEntities.Domain;

namespace MusicalService.Domain.DatabaseEntities.Music;
public sealed class SongTypeEntity : IEntity
{
    public long SongId { get; set; }
    
    public long TypeId { get; set; }

    public SongEntity SongEntity { get; set; }
    
    public TypeEntity TypeEntity { get; set; }
}
