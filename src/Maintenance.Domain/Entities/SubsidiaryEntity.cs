using Maintenance.Domain.Entities.EntitiesBase;

namespace Maintenance.Domain.Entities
{
    public class SubsidiaryEntity : EntityComplement
    {
        public virtual string? Name { get; private set; }

        /// <summary>
        /// Construtor de criação da entidade.
        /// </summary>
        /// <param name="deleted"></param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="publicId"></param>
        /// <param name="name"></param>
        public SubsidiaryEntity(
            bool deleted,
            DateTime createdAt,
            long createdBy,
            Guid publicId,
            string? name
        )
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Nome da subsidiaria é inválida.");

            if (publicId == default)
                throw new Exception("Identificador inválido.");

            this.Deleted = deleted;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.PublicId = publicId;
            this.Name = name;
        }
    }
}