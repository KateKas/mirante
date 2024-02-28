using Questao5.Domain.Entities;

namespace Questao5.Domain.Repositories
{
    public interface IContaCorrenteRepository
    {
        Task<ContaCorrente> GetById(string idContaCorrente);
        Task<ContaCorrente> GetContaCorrenteAtiva(string idContaCorrente);
        Task<SaldoContaCorrente> GetSaldo(string idContaCorrente);
    }
}
