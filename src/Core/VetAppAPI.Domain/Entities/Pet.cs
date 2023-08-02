using VetAppAPI.Domain.Enums;
using VetAppAPI.Domain.Entities.Identity;

namespace VetAppAPI.Domain.Entities;
public class Pet : BaseEntity<Guid>
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Age { get; set; }
    public AnimalType Type { get; set; }
    public Guid AppUserId { get; set; }
    public AppUser AppUser { get; set; }
}