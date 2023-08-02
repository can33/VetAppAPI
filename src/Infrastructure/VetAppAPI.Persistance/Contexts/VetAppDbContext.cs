using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using VetAppAPI.Domain.Entities;
using VetAppAPI.Domain.Entities.Identity;

namespace VetAppAPI.Persistance.Contexts;
public class VetAppDbContext : IdentityDbContext<AppUser,AppRole,string>
{
    public VetAppDbContext(DbContextOptions<VetAppDbContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Pet> Pets { get; set; }
}