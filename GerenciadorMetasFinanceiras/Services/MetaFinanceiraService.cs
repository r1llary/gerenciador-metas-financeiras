using GerenciadorMetasFinanceiras.Core.Interfaces;

namespace GerenciadorMetasFinanceiras.Core.Services
{
    public class MetaFinanceiraService
    {
        private readonly IMetaFinanceiraRepository repository;

        public MetaFinanceiraService(IMetaFinanceiraRepository repository)
        {
            this.repository = repository;
        }

        public List<MetaFinanceira> ListarMetas()
        {
            return repository.ListarMetas();
        }

        public MetaFinanceira? ConsultarMeta(int id)
        {
            return repository.ConsultarMeta(id);
        }

        public MetaFinanceira CadastrarMeta(
    string nome, decimal valorObjetivo, decimal valorEconomizado)
        {
            MetaFinanceira meta = new MetaFinanceira(
                nome,
                valorObjetivo,
                valorEconomizado
            );

            repository.CadastrarMeta(meta);

            return meta;
        }

        public MetaFinanceira? AtualizarMeta(
    int id, string nome, decimal valorObjetivo, decimal valorEconomizado)
        {
            MetaFinanceira? metaExistente = repository.ConsultarMeta(id);

            if (metaExistente == null)
            {
                return null;
            }

            MetaFinanceira meta = new MetaFinanceira(
                nome,
                valorObjetivo,
                valorEconomizado
            );

            meta.Id = id;

            repository.AtualizarMeta(meta);

            return meta;
        }

        public MetaFinanceira? AtualizarMetaParcial(
    int id,
    string? nome,
    decimal? valorObjetivo,
    decimal? valorEconomizado)
        {
            MetaFinanceira? metaExistente = repository.ConsultarMeta(id);

            if (metaExistente == null)
            {
                return null;
            }

            MetaFinanceira meta = new MetaFinanceira(
                nome ?? metaExistente.Nome,
                valorObjetivo ?? metaExistente.ValorObjetivo,
                valorEconomizado ?? metaExistente.ValorEconomizado
            );

            meta.Id = id;

            repository.AtualizarMeta(meta);

            return meta;
        }

        public bool ExcluirMeta(int id)
        {
            MetaFinanceira? meta = repository.ConsultarMeta(id);

            if (meta == null)
            {
                return false;
            }

            repository.ExcluirMeta(id);

            return true;
        }
    }
}