using PetFolio.Communication.Responses;

namespace PetFolio.Application.UseCases.Pet.GetAll;
public class GetAllPetsUseCase
{
    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson()
        {
            Pets = []
        };
    }
}
