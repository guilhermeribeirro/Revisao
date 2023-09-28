using Revisao.Catalogo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Interfaces
{
    public interface IPapaiNoelService


    {
        IEnumerable<PapaiNoelViewModel> ObterTodos();
        Task<PapaiNoelViewModel> ObterPorId(Guid id);
        Task<IEnumerable<PapaiNoelViewModel>> ObterPorCategoria(int proximoCodigo);

        void Adicionar(NovoPapaiNoelViewModel papainoel);
        void Atualizar(PapaiNoelViewModel papainoel);




    }
}
