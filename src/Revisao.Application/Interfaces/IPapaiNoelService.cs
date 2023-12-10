using Revisao.Application.ViewModels;
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


        public Task<string> Autenticar(AutenticacaoPapaiNoelViewModel autenticarpapainoelViewModel);
        IEnumerable<PapaiNoelViewModel> ObterTodos();
        Task<PapaiNoelViewModel> ObterPorId(Guid id);
        Task<IEnumerable<PapaiNoelViewModel>> ObterPorCategoria(int proximoCodigo);

       Task Adicionar(NovoPapaiNoelViewModel papainoel);
        void Atualizar(PapaiNoelViewModel papainoel);




    }
}
