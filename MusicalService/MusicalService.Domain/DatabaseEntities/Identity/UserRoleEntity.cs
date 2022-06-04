using MusicalService.Domain.DatabaseEntities.Domain;

namespace MusicalService.Domain.DatabaseEntities.Identity;
public sealed class UserRoleEntity : IEntity
{
    public long UserId { get; set; }
    
    public long RoleId { get; set; }

    public UserEntity User { get; set; }

    public RoleEntity Role { get; set; }
}