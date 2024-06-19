using Maintenance.Domain.Entities.EntitiesBase;

namespace Maintenance.Domain.Entities
{
    public class SubsidiaryEntity : EntityComplement
    {
        public virtual string? Name { get; set; }
    }
}