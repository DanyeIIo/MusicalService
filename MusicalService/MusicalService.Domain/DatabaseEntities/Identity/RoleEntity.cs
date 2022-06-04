using MusicalService.Domain.DatabaseEntities.Domain;

namespace MusicalService.Domain.DatabaseEntities.Identity;
public sealed class RoleEntity : IEntity, IUniqueIdentifier<long>, IName
{
    public long Id { get; set; }

    public string Name { get; set; }
    
    public ICollection<UserRoleEntity> UserRoleEntities { get; set; }
}
