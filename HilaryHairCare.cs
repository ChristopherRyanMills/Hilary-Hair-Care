using Microsoft.EntityFrameworkCore;
using HilaryHairCare.Models;

public class HilaryHairCareDbContext : DbContext
{
    
    public DbSet<Appointment> Appointments {get; set; }
    public DbSet<AppointmentServices> AppointmentServices {get; set; }
    public DbSet<Customer> Customers {get; set; }
    public DbSet<Service> Services {get; set; }
    public DbSet<Stylist> Stylists {get; set; }

    public HilaryHairCareDbContext(DbContextOptions<HilaryHairCareDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Customer>().HasData(new Customer[]
        {
            new Customer {Id = 1, Name = "Calliope Mori"},
            new Customer {Id = 2, Name = "Nanashi Mumei"},
            new Customer {Id = 3, Name = "Takanashi Kiara"}
        });

        modelBuilder.Entity<Stylist>().HasData(new Stylist[]
        {
            new Stylist {Id = 1, Name = "Gawr Gura", IsActive = true},
            new Stylist {Id = 2, Name = "Bae", IsActive = true},
            new Stylist {Id = 3, Name = "Kronii", IsActive = true}
        });

        modelBuilder.Entity<Service>().HasData(new Service[]
        {
            new Service {Id = 1, Name = "Haircut", Price = 20.99},
            new Service {Id = 2, Name = "Coloring", Price = 15.99},
            new Service {Id = 3, Name = "Beard Trim", Price = 5.50}
        });

        modelBuilder.Entity<Appointment>().HasData(new Appointment[]
        {
            new Appointment {Id = 1, CustomerId =2, StylistId = 1, StartTime = new DateTime(2023, 10, 23, 01, 0, 0)}
        });

        modelBuilder.Entity<AppointmentServices>().HasData(new AppointmentServices[]
        {
            new AppointmentServices {Id = 1, AppointmentId = 1, ServiceId = 2},
            new AppointmentServices {Id = 2, AppointmentId = 1, ServiceId = 3}
        });
    }
}