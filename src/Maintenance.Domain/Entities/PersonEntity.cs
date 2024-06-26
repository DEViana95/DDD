using Maintenance.Domain.Entities.EntitiesBase;

namespace Maintenance.Domain.Entities
{
    public class PersonEntity : EntityComplement
    {   
        /// <summary>
        /// Nome da pessoa.
        /// </summary>
        /// <value></value>
        public virtual string? Name { get; set; }

        /// <summary>
        /// Construtor de criação da entidade.
        /// </summary>
        /// <param name="deleted"></param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="publicId"></param>
        /// <param name="name"></param>
        public PersonEntity(
            bool deleted,
            DateTime createdAt,
            long createdBy,
            Guid publicId,
            string? name
        )
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Nome da pessoa é inválido.");

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