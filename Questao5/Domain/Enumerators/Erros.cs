using System.ComponentModel;

namespace Questao5.Domain.Enumerators
{
    public enum Erros
    {
        [Description("Conta inválida")]
        INVALID_ACCOUNT = 1,

        [Description("Conta inativa")]
        INACTIVE_ACCOUNT = 2,

        [Description("Valor inválido")]
        INVALID_VALUE = 3,

        [Description("Tipo invalido")]
        INVALID_TYPE = 4
    }
}
