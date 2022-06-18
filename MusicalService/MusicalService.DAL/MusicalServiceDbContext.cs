using System.Reflection;
using Microsoft.EntityFrameworkCore;
using MusicalService.Application.Ports.DataAccess.PostgreSql;
using MusicalService.Domain.DatabaseEntities.Identity;
using MusicalService.Domain.DatabaseEntities.Music;

namespace MusicalService.Infrastructure.Adapters.DAL.PostgreSQL;

public sealed class MusicalServiceDbContext : DbContext, IMusicalServiceDbContext
{
    public MusicalServiceDbContext()
    {
    }

    public MusicalServiceDbContext(DbContextOptions<MusicalServiceDbContext> options) : base(options)
    {
    }

    #region Identity

    public DbSet<RoleEntity> IdentityRoles { get; set; }

    public DbSet<SexEntity> IdentitySexs { get; set; }

    public DbSet<UserEntity> IdentityUsers { get; set; }

    public DbSet<UserRoleEntity> IdentityUserRoles { get; set; }

    #endregion

    #region Music

    public DbSet<GenreEntity> GenreEntities { get; set; }

    public DbSet<SongEntity> MusicSongs { get; set; }

    public DbSet<SongGenreEntity> MusicSongGenres { get; set; }

    public DbSet<SongTypeEntity> MusicSongTypes { get; set; }

    public DbSet<TypeEntity> MusicTypes { get; set; }

    public DbSet<UserSongEntity> MusicUserSongs { get; set; }

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            //TODO
            optionsBuilder.UseNpgsql("");
        }
        
        base.OnConfiguring(optionsBuilder);
    }
}