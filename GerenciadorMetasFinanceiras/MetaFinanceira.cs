namespace GerenciadorMetasFinanceiras.Core
{
    public class MetaFinanceira
    {
        public Guid Id { get; set; }
        public string Nome { get; private set; }
        public decimal ValorObjetivo { get; private set; }
        public decimal ValorEconomizado { get; private set; }

        public MetaFinanceira(string nome, decimal valorObjetivo, decimal valorEconomizado = 0m)
        {
            if (valorObjetivo <= 0)
            {
                throw new ArgumentException("O valor da meta deve ser maior que zero.");
            }
            if (valorEconomizado < 0)
            {
                throw new ArgumentException("O valor economizado não pode ser negativo.");
            }
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("A meta precisa ter um nome e não pode conter apenas espaços.");
            }

            this.Nome = nome;
            this.ValorObjetivo = valorObjetivo;
            this.ValorEconomizado = valorEconomizado;

        }

        public void AtualizarValorObjetivo(decimal novoValor)
        {
            if (novoValor <= 0)
            {
                throw new ArgumentException("O valor atualizado deve ser maior que zero.");
            }

            ValorObjetivo = novoValor;

        }

        public void AtualizarValorEconomizado(decimal novoValorEconomizado)
        {
            if(novoValorEconomizado < 0)
            {
                throw new ArgumentException("O valor economizado não pode ser negativo.");
            }
            ValorEconomizado = novoValorEconomizado;
        }

        public void AtualizarNome(string novoNome)
        {
            if (string.IsNullOrWhiteSpace(novoNome))
            {
                throw new ArgumentException("A meta precisa ter um nome e não pode conter apenas espaços.");
            }
            Nome = novoNome;
        }
        

    }
}
