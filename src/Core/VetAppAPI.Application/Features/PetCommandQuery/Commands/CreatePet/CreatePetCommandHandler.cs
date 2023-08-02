using MediatR;
using VetAppAPI.Application.Dtos.Pet;
using VetAppAPI.Application.Repositories;
using VetAppAPI.Domain.Entities;

namespace VetAppAPI.Application.Features.PetCommandQuery.Commands.CreatePet;

public class CreatePetCommandHandler : IRequestHandler<CreatePetCommandRequest, CreatePetDto>
{
    private readonly IPetRepository _petRepository;

    public CreatePetCommandHandler(IPetRepository petRepository)
    {
        _petRepository = petRepository;
    }

    public async Task<CreatePetDto> Handle(CreatePetCommandRequest request, CancellationToken cancellationToken)
    {
        var createPet = await _petRepository.CreateAsync(new Pet
        {
            AppUserId = request.AppUserId,
            Gender = request.Gender,
            Age = request.Age,
            Name = request.Name,
            Type = request.Type
        });

        var createPetDto = new CreatePetDto
        {
            Age = createPet.Age,
            Gender = createPet.Gender,
            AppUserId = createPet.AppUserId,
            Name = createPet.Name,
            Type = createPet.Type
        };

        return createPetDto;
    }
}