namespace GerenciadorMetasFinanceiras.Core.Interfaces
{
    public interface IMetaFinanceiraRepository
    {
        List<MetaFinanceira> ListarMetas();

        MetaFinanceira? ConsultarMeta(int id);

        void CadastrarMeta(MetaFinanceira meta);

        void AtualizarMeta(MetaFinanceira meta);

        void ExcluirMeta(int id);
    }
}