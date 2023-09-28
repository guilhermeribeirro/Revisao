
using Revisao.Catalogo.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;

namespace Revisao.Catalogo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PapaiNoelController : ControllerBase
    {
        private readonly IPapaiNoelService _papainoelService;

        public PapaiNoelController(IPapaiNoelService papainoelService)
        {
            _papainoelService = papainoelService;
        }

        [HttpPost(Name = "Adicionar")]
        public IActionResult Post(NovoPapaiNoelViewModel novopapainoelViewModel)
        {
            _papainoelService.Adicionar(novopapainoelViewModel);

            return Ok();
        }


        [HttpGet(Name = "ObterTodos")]
        public IActionResult Get()
        {
            return Ok(_papainoelService.ObterTodos());
        }
    }
}