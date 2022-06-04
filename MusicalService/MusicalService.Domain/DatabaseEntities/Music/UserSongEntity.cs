using MusicalService.Domain.DatabaseEntities.Domain;
using MusicalService.Domain.DatabaseEntities.Identity;

namespace MusicalService.Domain.DatabaseEntities.Music;
public sealed class UserSongEntity : IEntity
{
    public long UserId { get; set; }

    public long SongId { get; set; }

    public UserEntity UserEntity{ get; set; }
    
    public SongEntity SongEntity{ get; set; }
}
