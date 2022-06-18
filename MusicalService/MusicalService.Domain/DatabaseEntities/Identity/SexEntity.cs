using MusicalService.Domain.DatabaseEntities.Domain;

namespace MusicalService.Domain.DatabaseEntities.Identity;
public sealed class SexEntity : IEntity, IUniqueIdentifier<int>, IName
{
    public int Id { get; set; }

    public string Name { get; set; }

    public ICollection<UserEntity> UserEntities { get; set; }
}