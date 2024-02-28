using MediatR;
using Questao5.Application.ApiResult;
using Questao5.Application.Commands.Responses;

namespace Questao5.Application.Commands.Requests
{
    public class MovimentoRequest : IRequest<ApiResult<MovimentoResponse>>
    {        
        public string IdContaCorrente { get; set; }
        public decimal ValorMovimentado { get; set; }
        public string TipoMovimento { get; set; }
        
    }
}
