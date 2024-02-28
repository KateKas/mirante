using System.Threading.Tasks;

namespace Questao5.Domain.Repositories
{
    public interface IMovimentoRepository
    {
        Task<string> CreateMovimento(string idContaCorrente, string tipoMovimento, decimal valor);
    }
}
