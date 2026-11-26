namespace GerenciadorMetasFinanceiras.Api.Models
{
    public class AtualizacaoParcialMetaFinanceira
    {
        public string? Nome { get; set; }

        public decimal? ValorObjetivo { get; set; }

        public decimal? ValorEconomizado { get; set; }
    }
}