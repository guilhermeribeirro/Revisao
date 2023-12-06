using AutoMapper;

using MongoDB.Bson;
using Revisao.Data.Providers.MongoDb.Collections;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Data.AutoMapper
{
    public class DomainToCollection : Profile
    {
        public DomainToCollection()
        {
            CreateMap<PapaiNoel, PapaiNoelCollection>();
           
        }
    }
}