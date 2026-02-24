using Microsoft.EntityFrameworkCore;
using Projektuppgift.Models;

namespace Projektuppgift.Data;

public class ApplicationDbContext : DbContext 
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {

    }

    public DbSet<FacilityModel> Facilities { get; set; } = null!;
    public DbSet<AssociationModel> Associations { get; set; } = null!;
    public DbSet<BookingModel> Bookings { get; set; } = null!;
}