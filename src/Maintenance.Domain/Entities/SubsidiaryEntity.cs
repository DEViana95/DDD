using Maintenance.Domain.Entities.EntitiesBase;
using System.ComponentModel.DataAnnotations;

namespace Maintenance.Domain.Entities
{
    public class SubsidiaryEntity : EntityComplement
    {
        public virtual string? Name { get; private set; }

        /// <summary>
        /// Construtor de criação da entidade.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="deleted"></param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="name"></param>
        public SubsidiaryEntity(
            long id,
            bool deleted,
            DateTime createdAt,
            long createdBy,
            string name
        )
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Nome da subsidiaria é invalida.");

            this.Id = id;
            this.Deleted = deleted;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Name = name;
        }
    }
}