namespace GerenciadorMetasFinanceiras.Api.DTOs.Requests
{
    public class AtualizacaoParcialMetaFinanceiraRequest
    {
        public string? Nome { get; set; }

        public decimal? ValorObjetivo { get; set; }

        public decimal? ValorEconomizado { get; set; }
    }
}