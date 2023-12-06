using AutoMapper;

using Revisao.Data.Providers.MongoDb.Collections;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Data.AutoMapper
{
    public class CollectionToDomain : Profile
    {
        public CollectionToDomain()
        {

            CreateMap<PapaiNoelCollection, PapaiNoel>()
               .ConstructUsing(q => new PapaiNoel(q.CodigoId, q.Nome, q.EnderecoCompleto, q.Idade, q.TextoCarta));


        }
    }
}

