using GerenciadorMetasFinanceiras.Core;
using GerenciadorMetasFinanceiras.Core.Interfaces;

namespace GerenciadorMetasFinanceiras.Infra.Repositories
{
    public class MetaFinanceiraRepository : IMetaFinanceiraRepository
    {
        private readonly List<MetaFinanceira> metas = new List<MetaFinanceira>();
        private int proximoId = 1;

        public List<MetaFinanceira> ListarMetas()
        {
            return metas;
        }

        public MetaFinanceira? ConsultarMeta(int id)
        {
            return metas.Find(m => m.Id == id);
        }

        public void CadastrarMeta(MetaFinanceira meta)
        {
            meta.Id = proximoId++;
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

        public void ExcluirMeta(int id)
        {
            MetaFinanceira? meta = ConsultarMeta(id);

            if (meta != null)
            {
                metas.Remove(meta);
            }
        }
    }


}