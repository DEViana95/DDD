using System.ComponentModel;

namespace Maintenance.Domain.Enum
{
    public enum SolicitationStateEnum
    {
        /// <summary>
        /// Pendente.
        /// </summary>
        [Description("Pendente")]
        Pending = 1,

        /// <summary>
        /// Cancelada.
        /// </summary>
        [Description("Cancelada")]
        Cancelled = 2,

        /// <summary>
        /// Reprovada.
        /// </summary>
        [Description("Reprovada")]
        Failed = 3,

        /// <summary>
        /// Aprovada.
        /// </summary>
        [Description("Aprovada")]
        Approved = 4
    }
}