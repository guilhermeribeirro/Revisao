using AutoMapper;
using Revisao.Catalogo.Application.ViewModels;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.AutoMapper
{
	public class ApplicationToDomain : Profile
	{
		public ApplicationToDomain()
		{
            

            CreateMap<PapaiNoelViewModel, PapaiNoel>()
               .ConstructUsing(q => new PapaiNoel( q.Nome, q.EnderecoCompleto, q.Idade, q.TextoCarta));

            CreateMap<NovoPapaiNoelViewModel, PapaiNoel>()
               .ConstructUsing(q => new PapaiNoel( q.Nome, q.EnderecoCompleto, q.Idade, q.TextoCarta));

        }
    }
}
