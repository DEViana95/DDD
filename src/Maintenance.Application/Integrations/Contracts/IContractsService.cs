using Maintenance.Application.Integrations.Contracts.ResponseDTO;

namespace Maintenance.Application.Integrations.Contracts
{
    public interface IContractsService
    {
        /// <summary>
        /// Busca um contrato pelo número do mesmo.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        Task<ContractDTO> GetContract(string number);
    }
}