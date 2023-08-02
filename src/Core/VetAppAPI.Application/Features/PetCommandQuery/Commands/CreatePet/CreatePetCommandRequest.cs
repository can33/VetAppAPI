using MediatR;
using VetAppAPI.Application.Dtos.Pet;
using VetAppAPI.Domain.Entities.Identity;
using VetAppAPI.Domain.Enums;

namespace VetAppAPI.Application.Features.PetCommandQuery.Commands.CreatePet;

public class CreatePetCommandRequest : IRequest<CreatePetDto>
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Age { get; set; }
    public AnimalType Type { get; set; }
    public Guid AppUserId { get; set; }
    public AppUser AppUser { get; set; }
}