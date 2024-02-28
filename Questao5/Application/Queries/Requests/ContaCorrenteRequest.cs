using MediatR;
using Questao5.Application.ApiResult;
using Questao5.Application.Queries.Responses;

namespace Questao5.Application.Queries.Requests
{
    public class ContaCorrenteRequest : IRequest<ApiResult<ContaCorrenteResponse>>
    {
        public ContaCorrenteRequest()
        {
            
        }
        public ContaCorrenteRequest(string idContaCorrente)
        {
            IdContaCorrente = idContaCorrente;
        }

        public string IdContaCorrente { get; set; }
    }
}
