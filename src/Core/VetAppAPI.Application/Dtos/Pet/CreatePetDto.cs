using VetAppAPI.Domain.Entities.Identity;
using VetAppAPI.Domain.Enums;

namespace VetAppAPI.Application.Dtos.Pet;

public class CreatePetDto
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Age { get; set; }
    public AnimalType Type { get; set; }
    public Guid AppUserId { get; set; }
    public AppUser AppUser { get; set; }
}