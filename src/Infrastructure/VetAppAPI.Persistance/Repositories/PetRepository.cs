using VetAppAPI.Application.Repositories;
using VetAppAPI.Domain.Entities;
using VetAppAPI.Persistance.Contexts;

namespace VetAppAPI.Persistance.Repositories;

public class PetRepository : GenericRepository<Pet>, IPetRepository
{
    public PetRepository(VetAppDbContext context) : base(context)
    {
    }
}
