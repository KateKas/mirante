namespace Questao5.Domain.Repositories
{
    public interface IIdempotenciaRepository
    {
        Task CreateIdempotencia(object request, string resultado);
    }
}
