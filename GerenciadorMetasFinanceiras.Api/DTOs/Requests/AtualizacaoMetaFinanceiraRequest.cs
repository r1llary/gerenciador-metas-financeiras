namespace GerenciadorMetasFinanceiras.Api.DTOs.Requests
{
    public class AtualizacaoMetaFinanceiraRequest
    {
        public string Nome { get; set; } = string.Empty;
        public decimal ValorObjetivo { get; set; }
        public decimal ValorEconomizado { get; set; }
    }
}