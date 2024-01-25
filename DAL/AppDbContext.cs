using Imtahanbilet9.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NuGet.Configuration;

namespace Imtahanbilet9.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>

    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        {


        }

        public DbSet<Service> Services { get; set; }


    }
}

