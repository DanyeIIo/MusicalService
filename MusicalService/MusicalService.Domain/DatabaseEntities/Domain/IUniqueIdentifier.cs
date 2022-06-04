namespace MusicalService.Domain.DatabaseEntities.Domain;

public interface IUniqueIdentifier<TKey>
{
    TKey Id { get; set; }
}