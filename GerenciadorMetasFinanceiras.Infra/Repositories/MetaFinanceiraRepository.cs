using GerenciadorMetasFinanceiras.Core;
using GerenciadorMetasFinanceiras.Core.Interfaces;

namespace GerenciadorMetasFinanceiras.Infra.Repositories
{
    public class MetaFinanceiraRepository : IMetaFinanceiraRepository
    {
        private readonly List<MetaFinanceira> metas = new List<MetaFinanceira>();

        public List<MetaFinanceira> ListarMetas()
        {
            return metas;
        }

        public MetaFinanceira? ConsultarMeta(Guid id)
        {
            return metas.Find(m => m.Id == id);
        }

        public void CadastrarMeta(MetaFinanceira meta)
        {
            meta.Id = Guid.NewGuid();
            metas.Add(meta);
        }

        public void AtualizarMeta(MetaFinanceira meta)
        {
            int indice = metas.FindIndex(m => m.Id == meta.Id);

            if (indice != -1)
            {
                metas[indice] = meta;
            }
        }

        public void ExcluirMeta(Guid id)
        {
            MetaFinanceira? meta = ConsultarMeta(id);

            if (meta != null)
            {
                metas.Remove(meta);
            }
        }
    }


}