using MusicalService.Domain.DatabaseEntities.Domain;

namespace MusicalService.Domain.DatabaseEntities.Music;
public sealed class SongEntity : IEntity, IUniqueIdentifier<long>, IName
{
    public long Id { get; set; }
    
    public string Name { get; set; }
    
    public string Content { get; set; }

    public ICollection<UserSongEntity> UserSongEntities { get; set; }

    public ICollection<SongGenreEntity> SongGenreEntities{ get; set; }

    public ICollection<SongTypeEntity> SongTypeEntities { get; set; }
}