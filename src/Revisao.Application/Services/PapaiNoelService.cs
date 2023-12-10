using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Catalogo.Application.ViewModels;
using Revisao.Data.Repositories;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using Revisao.Infra.Autenticacao;
using Revisao.Infra.Autenticacao.Models;
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
        private readonly ITokenService _tokenService;



        public PapaiNoelService(IPapaiNoelRepository cartaRepository, IMapper mapper, ITokenService tokenService)
        {
            _cartaRepository = cartaRepository;
            _mapper = mapper;
            _tokenService = tokenService;
        }
        #endregion

        #region - Funções

        public async Task<string> Autenticar(AutenticacaoPapaiNoelViewModel autenticarpapainoelViewModel)
        {
            var papainoel = await _cartaRepository
                .Autenticar(autenticarpapainoelViewModel.Login, autenticarpapainoelViewModel.Senha);

            if (papainoel == null)
                throw new ApplicationException("Login/Senha inválidos ou não existe");

            TokenRequest tokenRequest = new TokenRequest()
            {
                usuario = autenticarpapainoelViewModel.Login
            };

            string token = await _tokenService.GerarTokenJWT(tokenRequest);

            return token;

        }



        public async Task Adicionar(NovoPapaiNoelViewModel novopapainoelViewModel)
        {
            var novopapainoel = _mapper.Map<PapaiNoel>(novopapainoelViewModel);
            PapaiNoel p = new PapaiNoel(novopapainoelViewModel.EnderecoCompleto, novopapainoelViewModel.EnderecoCompleto, novopapainoelViewModel.Idade, novopapainoelViewModel.TextoCarta);

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
