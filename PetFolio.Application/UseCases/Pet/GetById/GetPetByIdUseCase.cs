using PetFolio.Communication.Responses;

namespace PetFolio.Application.UseCases.Pet;
public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson() 
        {
            Id = id,
            Birthday = DateTime.Now,
            Name = "Pet",
            Type = Communication.Enums.PetType.Dog,
        };
    }
}
