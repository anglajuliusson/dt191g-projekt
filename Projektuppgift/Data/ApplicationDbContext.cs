using Microsoft.EntityFrameworkCore;
using Projektuppgift.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Projektuppgift.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {

    }

    public DbSet<Facility> Facilities { get; set; } = null!;
    public DbSet<Association> Associations { get; set; } = null!;
    public DbSet<Booking> Bookings { get; set; } = null!;
}