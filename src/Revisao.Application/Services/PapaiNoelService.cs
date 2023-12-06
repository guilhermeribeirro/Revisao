using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Catalogo.Application.ViewModels;
using Revisao.Data.Repositories;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
    public class PapaiNoelService : IPapaiNoelService
    {
        #region - Construtores
        private readonly IPapaiNoelRepository _cartaRepository;
        private IMapper _mapper;

        public PapaiNoelService(IPapaiNoelRepository cartaRepository, IMapper mapper)
        {
            _cartaRepository = cartaRepository;
            _mapper = mapper;
        }
        #endregion

        #region - Funções
        public async void Adicionar(NovoPapaiNoelViewModel novopapainoelViewModel)
        {
            var novopapainoel = _mapper.Map<PapaiNoel>(novopapainoelViewModel);
           await _cartaRepository.Adicionar(novopapainoel);

        }

        public void Atualizar(PapaiNoelViewModel papainoel)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PapaiNoelViewModel>> ObterPorCategoria(int proximoCodigo)
        {
            throw new NotImplementedException();
        }

        public Task<PapaiNoelViewModel> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<PapaiNoelViewModel> ObterTodos()
        {
            return _mapper.Map<IEnumerable<PapaiNoelViewModel>>(_cartaRepository.ObterTodos());

        }
        #endregion
    }
}
