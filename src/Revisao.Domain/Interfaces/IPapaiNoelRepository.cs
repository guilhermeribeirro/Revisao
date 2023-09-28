using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Repositories
{
    public interface IPapaiNoelRepository
    {

        IEnumerable<PapaiNoel> ObterTodos();
        Task<PapaiNoel> ObterPorId(Guid id);
        Task<IEnumerable<PapaiNoel>> ObterPorCategoria(int proximoCodigo);

        void Adicionar(PapaiNoel papainoel);
        void Atualizar(PapaiNoel papainoel);


    }
}