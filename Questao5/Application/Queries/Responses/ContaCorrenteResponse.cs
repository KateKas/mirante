
using Questao5.Domain.Entities;

namespace Questao5.Application.Queries.Responses
{
    public class ContaCorrenteResponse
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string DataConsulta { get; set; }
        public decimal Saldo { get; set; }

        public static explicit operator ContaCorrenteResponse(SaldoContaCorrente contaCorrente)
        {
            return new ContaCorrenteResponse()
            {
                Numero = contaCorrente.Numero,
                Nome = contaCorrente.Nome,
                DataConsulta = DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                Saldo = contaCorrente.Saldo
            };
        }
    }
}
