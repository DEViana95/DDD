using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maintenance.Domain.Entities.EntitiesBase
{
    public class EntityComplement : EntityBase
    {
        /// <summary>
        /// Criado em ...
        /// </summary>
        /// <value></value>
        public virtual DateTime CreatedAt { get; set; }

        /// <summary>
        /// Criado por ...
        /// </summary>
        /// <value></value>
        public virtual long CreatedBy { get; set; }

        /// <summary>
        /// Modificado em ...
        /// </summary>
        /// <value></value>
        public virtual DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Modificado por ...
        /// </summary>
        /// <value></value>
        public virtual long? ModifiedBy { get; set; }
    }
}