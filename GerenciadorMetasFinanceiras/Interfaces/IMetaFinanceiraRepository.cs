using GerenciadorMetasFinanceiras.Core.Entities;

namespace GerenciadorMetasFinanceiras.Core.Interfaces
{
    public interface IMetaFinanceiraRepository
    {
        List<MetaFinanceira> ListarMetas();

        MetaFinanceira? ConsultarMeta(Guid id);

        void CadastrarMeta(MetaFinanceira meta);

        void AtualizarMeta(MetaFinanceira meta);

        void ExcluirMeta(Guid id);
    }
}