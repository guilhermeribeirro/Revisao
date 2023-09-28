using Newtonsoft.Json;
using Revisao.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Revisao.Data.Repositories
{
    public class PapaiNoelRepository : IPapaiNoelRepository
    {
        private readonly string _cartaCaminhoArquivo;

        #region - Construtores
        public PapaiNoelRepository()
        {
            _cartaCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonData", "PapaiNoel.json");
        }

        #endregion

        #region - Funções
        public void Adicionar(PapaiNoel papainoel)
        {
            var papainoels = LerCartasDoArquivo();
            int proximoCodigo = ObterProximoCodigoDisponivel();
            papainoel.SetaCodigoPapaiNoel(proximoCodigo);
            papainoels.Add(papainoel);
            EscreverCartasNoArquivo(papainoels);
        }

        public void Atualizar(PapaiNoel papainoel)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PapaiNoel>> ObterPorCategoria(int proximoCodigo)
        {
            throw new NotImplementedException();
        }

        public Task<PapaiNoel> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PapaiNoel> ObterTodos()
        {
            return LerCartasDoArquivo();
        }
        #endregion

        #region - Métodos arquivo
        private List<PapaiNoel> LerCartasDoArquivo()
        {
            if (!System.IO.File.Exists(_cartaCaminhoArquivo))
                return new List<PapaiNoel>();
            string json = System.IO.File.ReadAllText(_cartaCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<PapaiNoel>>(json);
        }

        private int ObterProximoCodigoDisponivel()
        {
            List<PapaiNoel> papainoels = LerCartasDoArquivo();
            if (papainoels.Any())
                return papainoels.Max(p => p.Codigo) + 1;
            else
                return 1;
        }

        private void EscreverCartasNoArquivo(List<PapaiNoel> produtos)
        {
            string json = JsonConvert.SerializeObject(produtos);
            System.IO.File.WriteAllText(_cartaCaminhoArquivo, json);
        }
        #endregion


    }
}
