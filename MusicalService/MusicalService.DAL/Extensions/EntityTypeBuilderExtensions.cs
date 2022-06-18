using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicalService.Domain.DatabaseEntities.Domain;

namespace MusicalService.Infrastructure.Adapters.DAL.PostgreSQL.Extensions;

internal static class EntityTypeBuilderExtensions
{
    internal static PropertyBuilder HasUniqueIdentifier<TEntity, TKey>(this EntityTypeBuilder<TEntity> builder)
        where TEntity : class, IUniqueIdentifier<TKey>
    {
        var propertyBuilder = builder
            .Property(e => e.Id)
            .HasColumnName("Id")
            .IsRequired();

        builder.HasKey(e => e.Id);

        return propertyBuilder;
    }

    internal static PropertyBuilder HasName<TEntity>(this EntityTypeBuilder<TEntity> builder, int maxLength)
        where TEntity : class, IName
    {
        return builder
            .Property(e => e.Name)
            .HasColumnName("Name")
            .HasMaxLength(maxLength)
            .IsRequired();
    }
}