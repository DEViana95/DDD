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
        /// Razão/Justificativa.
        /// </summary>
        /// <value></value>
        public virtual string? Reason { get; set; }

        /// <summary>
        /// Tipo de solicitação de manutenção.
        /// </summary>
        /// <value></value>
        public virtual MaintenanceSolicitationTypeEnum MaintenanceSolicitationType { get; set; }

        /// <summary>
        /// Data de ínicio desejada para a manutenção.
        /// </summary>
        /// <value></value>
        public virtual DateTime DesireBeginDateForMaintenance { get; set; }

        /// <summary>
        /// Data da solicitação.
        /// </summary>
        /// <value></value>
        public virtual DateTime SolicitationDate { get; set; }

        /// <summary>
        /// Status da solicitação.
        /// </summary>
        /// <value></value>
        public virtual SolicitationStateEnum SolicitationState { get; set; }

        #region Relacionamentos.
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
        /// Index do contrato.
        /// </summary>
        /// <value></value>
        public virtual long ContractId { get; set; }
        #endregion Relacionamentos.
    }
}