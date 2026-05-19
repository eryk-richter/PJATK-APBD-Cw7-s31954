using Cw7.Models;
using Microsoft.EntityFrameworkCore;
namespace Cw7.Infrastructure;

public class DatabaseContext(DbContextOptions opt) : DbContext(opt)
{
    public DbSet<Pc> Pcs { get; set; }
    public DbSet<PCComponent> PcComponents { get; set; }
    public DbSet<Component> Components { get; set; }
    public DbSet<ComponentType> ComponentTypes { get; set; }
    public DbSet<ComponentManufacturer> ComponentManufacturers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Pc>().HasData([
            new Pc
            {
                Id = 1,
                Name = "Gaming Beast X",
                Weight = 12.5f,
                Warranty = 36,
                CreatedAt = new DateTime(2026, 5, 8),
                Stock = 5
            },
            new Pc
            {
                Id = 2,
                Name = "Office Mini Pro",
                Weight = 4.2f,
                Warranty = 24,
                CreatedAt = new DateTime(2026, 4, 15),
                Stock = 12
            },
            new Pc
            {
                Id = 3,
                Name = "Macbook pro",
                Weight = 1.55f,
                Warranty = 12,
                CreatedAt = new DateTime(2025, 9, 1),
                Stock = 1
            }
        ]);
        
        modelBuilder.Entity<ComponentManufacturer>().HasData([
            new ComponentManufacturer
            {
                Id = 1,
                Abbreviation = "MSI",
                FullName = "Micro-Star-International",
                FoundationDate = new DateTime(1986, 8, 4)
            },
            new ComponentManufacturer
            {
                Id = 2,
                Abbreviation = "Apple",
                FullName = "Apple Inc.",
                FoundationDate = new DateTime(1976, 4, 1)
            },
            new ComponentManufacturer
            {
                Id = 3,
                Abbreviation = "Asus",
                FullName = "Asus Inc.",
                FoundationDate = new DateTime(1989, 4, 2)
            },
            new ComponentManufacturer
            {
                Id = 4,
                Abbreviation = "Intel",
                FullName = "Intel Inc.",
                FoundationDate = new DateTime(1968, 7, 18)
            },
            new ComponentManufacturer
            {
                Id = 5,
                Abbreviation = "Nvidia",
                FullName = "Nvidia Inc.",
                FoundationDate = new DateTime(1993, 4, 5)
            }
        
        ]);

        modelBuilder.Entity<ComponentType>().HasData([
            new ComponentType
            {
                Id = 1,
                Abbreviation = "cpu",
                Name = "Central processing unit"
            },
            new ComponentType
            {
                Id = 2,
                Abbreviation = "gpu",
                Name = "Graphics processing unit"
            },
            new ComponentType
            {
                Id = 3,
                Abbreviation = "mobo",
                Name = "Mother Board"
            }
        ]);

        modelBuilder.Entity<Component>().HasData([
            new Component
            {
                Code = "abc1",
                Name = "RTX4090",
                Description = "flagship gpu",
                ComponentManufacturersId = 5,
                ComponentTypesId = 2,
            },
            new Component
            {
                Code = "abc2",
                Name = "ArcB580",
                Description = "dedicated intel gpu",
                ComponentManufacturersId = 4,
                ComponentTypesId = 2,
            },
            new Component
            {
                Code = "abc3",
                Name = "ultra 9",
                Description = "flagship intel consumer cpu",
                ComponentManufacturersId = 5,
                ComponentTypesId = 1,
            },
            new Component
            {
                Code = "abc4",
                Name = "M5",
                Description = "Apple silicon cpu",
                ComponentManufacturersId = 2,
                ComponentTypesId = 1,
            },
            new Component
            {
                Code = "abc5",
                Name = "super gaming mobo",
                Description = "Great gaming motherboard",
                ComponentManufacturersId = 1,
                ComponentTypesId = 3
            },
            new Component
            {
                Code = "abc6",
                Name = "epic shadow mobo",
                Description = "budget motherboard",
                ComponentManufacturersId = 1,
                ComponentTypesId = 3
            }
        ]);

        modelBuilder.Entity<PCComponent>().HasData([
            new PCComponent
            {
                PcId = 1,
                ComponentCode = "abc5",
                Amount = 1
            },
            new PCComponent
            {
                PcId = 1,
                ComponentCode = "abc3",
                Amount = 1
            },
            new PCComponent
            {
                PcId = 1,
                ComponentCode = "abc1",
                Amount = 1
            },


            new PCComponent
            {
                PcId = 2,
                ComponentCode = "abc6",
                Amount = 1
            },
            new PCComponent
            {
                PcId = 2,
                ComponentCode = "abc2",
            },
            new PCComponent
            {
                PcId = 2,
                ComponentCode = "abc3",
            },



            new PCComponent
            {
                PcId = 3,
                ComponentCode = "abc4",
            }
        ]);
    }
}