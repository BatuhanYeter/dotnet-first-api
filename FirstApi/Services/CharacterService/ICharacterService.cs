using FirstApi.Dtos;
using FirstApi.Models;

namespace FirstApi.Services.CharacterService
{
    public interface ICharacterService
    {
        // older version => public Task<ServiceResponse<List<Character>>> GetAllCharacters();
        // Character class is replaced by Dto classes

        public Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();

        public Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);

        public Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);

        public Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
        public Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);  
    }
}
