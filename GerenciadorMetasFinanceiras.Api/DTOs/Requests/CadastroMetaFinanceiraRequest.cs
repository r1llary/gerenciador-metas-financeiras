namespace GerenciadorMetasFinanceiras.Api.DTOs.Requests
{
    public class CadastroMetaFinanceiraRequest
    {
        public string Nome { get; set; } = string.Empty;
        public decimal ValorObjetivo { get; set; }
        public decimal ValorEconomizado { get; set; }
    }
}