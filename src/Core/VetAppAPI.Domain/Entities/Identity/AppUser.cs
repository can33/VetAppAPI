using Microsoft.AspNetCore.Identity;

namespace VetAppAPI.Domain.Entities.Identity;
public class AppUser : IdentityUser
{
    public string FullName { get; set; }
    public string Experience { get; set; }
    public string Location { get; set; }
    public string Biography { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenEndDate { get; set; }
    public ICollection<Pet> Pets { get; set; }
}