
using Revisao.Catalogo.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Infra.Autenticacao;
using AutoMapper;

namespace Revisao.Catalogo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PapaiNoelController : ControllerBase
    {

        private readonly ITokenService _tokenService;
        private readonly IPapaiNoelService _papainoelService;
        private readonly IMapper _mapper;

    

        public PapaiNoelController(IPapaiNoelService papainoelService, IMapper mapper,
              ITokenService tokenService)
        {
            _papainoelService = papainoelService;
            _mapper = mapper;
            _tokenService = tokenService;
        }


        [HttpPost]
        [Route("Adicionar")]
        public async Task<IActionResult> Post(NovoPapaiNoelViewModel novopapainoelViewModel)
        {
            await _papainoelService.Adicionar(novopapainoelViewModel);

            return Ok();
        }



        [HttpGet]
        [Route("ObterTodos")]
        public IActionResult Get()
        {
            return Ok(_papainoelService.ObterTodos());
        }


        //[HttpPost]
        //public async Task<IActionResult> Autenticar(AutenticacaoPapaiNoelViewModel autenticacaopapaioViewModel)
        //{
        //    var token = await _papainoelService.Autenticar(autenticacaopapaioViewModel);

        //    return Ok(token);
        //}





    }
}