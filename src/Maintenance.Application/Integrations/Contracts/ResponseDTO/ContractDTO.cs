namespace Maintenance.Application.Integrations.Contracts.ResponseDTO
{
    public class ContractDTO
    {
        /// <summary>
        /// Número do contrato.
        /// </summary>
        /// <value></value>
        public string? Number { get; set; }

        /// <summary>
        /// Nome da terceirizada.
        /// </summary>
        /// <value></value>
        public string? OutsourcedName { get; set; }

        /// <summary>
        /// Identificador único da terceirizada.
        /// </summary>
        /// <value></value>
        public string? OutsourcedTxId { get; set; }

        /// <summary>
        /// Gestor do contrato.
        /// </summary>
        /// <value></value>
        public string? ContractManager { get; set; }

        /// <summary>
        /// Data final da vigência.
        /// </summary>
        /// <value></value>
        public DateTime EffectiveEndDate { get; set; }
    }
}