using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MusicalService.Domain.DatabaseEntities.Identity;
using MusicalService.Domain.DatabaseEntities.Music;

namespace MusicalService.Application.Ports.DataAccess.PostgreSql;

public interface IMusicalServiceDbContext : IDisposable
{
    #region Identity

    DbSet<RoleEntity> IdentityRoles { get; set; }

    DbSet<SexEntity> IdentitySexs { get; set; }

    DbSet<UserEntity> IdentityUsers { get; set; }

    DbSet<UserRoleEntity> IdentityUserRoles { get; set; }

    #endregion

    #region Music

    DbSet<GenreEntity> GenreEntities { get; set; }

    DbSet<SongEntity> MusicSongs { get; set; }

    DbSet<SongGenreEntity> MusicSongGenres { get; set; }

    DbSet<SongTypeEntity> MusicSongTypes { get; set; }

    DbSet<TypeEntity> MusicTypes { get; set; }

    DbSet<UserSongEntity> MusicUserSongs { get; set; }

    #endregion

    DatabaseFacade Database { get; }

    int SaveChanges();

    int SaveChanges(bool acceptAllChangesOnSuccess);

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
}