using Maintenance.Domain.Entities.EntitiesBase;
using Maintenance.Domain.Enum;

namespace Maintenance.Domain.Entities
{
    public class MaintenanceSolicitationEntity : EntityComplement
    {
        /// <summary>
        /// Index do subsidiário.
        /// </summary>
        /// <value></value>
        public virtual long SubsidiaryId { get; set; }

        /// <summary>
        /// Index do solicitante.
        /// </summary>
        /// <value></value>
        public virtual long RequesterId { get; set; }

        /// <summary>
        /// Index do aprovador.
        /// </summary>
        /// <value></value>
        public virtual long ApproverId { get; set; }

        /// <summary>
        /// Tipo de solicitação de manutenção.
        /// </summary>
        /// <value></value>
        public virtual MaintenanceSolicitationTypeEnum MaintenanceSolicitationType { get; set; }
    }
}