using AutoMapper;
using Newtonsoft.Json;
using Revisao.Data.Providers.MongoDb.Collections;
using Revisao.Data.Providers.MongoDb.Interfaces;
using Revisao.Domain.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Revisao.Domain.Interfaces;

namespace Revisao.Data.Repositories
{
    public class PapaiNoelRepository : IPapaiNoelRepository
    {
        private readonly IMongoRepository<PapaiNoelCollection> _papainoelRepository;
        private readonly IMapper _mapper;


        public PapaiNoelRepository(IMongoRepository<PapaiNoelCollection> papainoelRepository, IMapper mapper)
        {
            _papainoelRepository = papainoelRepository;
            _mapper = mapper;
        }

        #region - Funções


        public async Task<PapaiNoel> Autenticar(string login, string senha)
        {
            var papainoelCollection = await _papainoelRepository.FindOneAsync(filtro =>
                        filtro.Login == login && filtro.Senha == senha);
            return _mapper.Map<PapaiNoel>(papainoelCollection);


        }






        public async Task Adicionar(PapaiNoel  papainoel)
        {
            await  _papainoelRepository.InsertOneAsync(_mapper.Map<PapaiNoelCollection>(papainoel));
        }

        
        public void Atualizar(PapaiNoel papainoel)
        {
            throw new NotImplementedException();
        }



        public Task<IEnumerable<PapaiNoel>> ObterPorCategoria(int proximoCodigo)
        {
            throw new NotImplementedException();
        }



        public async Task<PapaiNoel> ObterPorId(Guid id)
        {
            var buscaCategoria = _papainoelRepository.FilterBy(filter => filter.CodigoId == id);

            return _mapper.Map<PapaiNoel>(buscaCategoria.FirstOrDefault());

        }



        public IEnumerable<PapaiNoel> ObterTodos()
        {
            var papainoelList = _papainoelRepository.FilterBy(filter => true);

            return _mapper.Map<IEnumerable<PapaiNoel>>(papainoelList);
        }
        #endregion




    }
}
