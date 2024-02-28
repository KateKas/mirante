
namespace Questao5.Application.Commands.Responses
{
    public class MovimentoResponse
    {
        public MovimentoResponse(string idMovimento)
        {
            IdMovimento = idMovimento;
        }

        public string IdMovimento { get; set; }
    }
}
