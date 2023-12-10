using Revisao.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Interfaces
{
    public interface IPapaiNoelRepository
    {
        public Task<PapaiNoel> Autenticar(string login, string senha);
        IEnumerable<PapaiNoel> ObterTodos();
        Task<PapaiNoel> ObterPorId(Guid id);
       
        Task Adicionar(PapaiNoel papainoel);
        
        void Atualizar(PapaiNoel papainoel);


    }
}