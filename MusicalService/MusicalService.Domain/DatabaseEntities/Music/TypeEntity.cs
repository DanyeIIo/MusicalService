using MusicalService.Domain.DatabaseEntities.Domain;

namespace MusicalService.Domain.DatabaseEntities.Music;
public sealed class TypeEntity : IEntity, IUniqueIdentifier<long>, IName
{
    public long Id { get; set; }

    public string TypeName { get; set; }
    
    public string Name { get; set; }

    public ICollection<SongTypeEntity> SongTypeEntities { get; set; }
}
