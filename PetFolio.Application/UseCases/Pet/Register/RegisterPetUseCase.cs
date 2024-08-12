using PetFolio.Communication.Requests;
using PetFolio.Communication.Responses;

namespace PetFolio.Application.UseCases.Pet.Register;
public class RegisterPetUseCase
{
    public ResponseRegisterPetJson Execute(RequestPetJson request)
    {
        return new ResponseRegisterPetJson()
        {
            Id = 1,
            Name = request.Name,
        };
    }
}
