using Microsoft.AspNetCore.Mvc;
using FirstApi.Models;
using FirstApi.Services.CharacterService;
using FirstApi.Dtos;

namespace FirstApi.Controllers
{
    // router and apicontroller attributes
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : Controller
    {
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;   
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get() 
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter(AddCharacterDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}
