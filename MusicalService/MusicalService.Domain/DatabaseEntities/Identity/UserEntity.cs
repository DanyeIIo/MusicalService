using MusicalService.Domain.DatabaseEntities.Domain;
using MusicalService.Domain.DatabaseEntities.Music;

namespace MusicalService.Domain.DatabaseEntities.Identity;
public sealed class UserEntity : IEntity, IUniqueIdentifier<long>
{
    public long Id { get; set; }

    public string Email { get; set; }

    public string NickName { get; set; }

    public DateOnly? Birthdate { get; set; }

    public string? Avatar { get; set; }

    public string PasswordHash { get; set; }

    public byte? SexId { get; set; }

    public SexEntity SexEntity { get; set; }

    public ICollection<UserRoleEntity> UserRoleEntities { get; set; }
    
    public ICollection<UserSongEntity> UserSongEntities { get; set; }
}