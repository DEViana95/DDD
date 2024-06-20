using System.ComponentModel;

namespace Maintenance.Domain.Enum
{
    public enum MaintenanceSolicitationTypeEnum
    {
        /// <summary>
        /// Jardinagem.
        /// </summary>
        [Description("Jardinagem")]
        Gardening = 1,

        /// <summary>
        /// Pintura.
        /// </summary>
        [Description("Pintura")]
        Painting = 2,

        /// <summary>
        /// Elétrica.
        /// </summary>
        [Description("Elétrica")]
        Electrical = 3,

        /// <summary>
        /// Construção.
        /// </summary>
        [Description("Construção")]
        Building = 4
    }
}