using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EF.Models;
using System.Collections.Generic;

namespace EF.Configurations
{
    public class DoctorConfig : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(e => e.IdDoctor).HasName("Doctor_PK");
            builder.Property(e => e.IdDoctor).UseIdentityColumn();

            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Email).HasMaxLength(100).IsRequired();
            builder.HasIndex(e => e.Email).IsUnique();
            
            var doctors = new List<Doctor>
            {
                new Doctor
                {
                    IdDoctor = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com"
                },
                new Doctor
                {
                    IdDoctor = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com"
                },
                new Doctor
                {
                    IdDoctor = 3,
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Email = "alice.johnson@example.com"
                },
                new Doctor
                {
                    IdDoctor = 4,
                    FirstName = "Robert",
                    LastName = "Brown",
                    Email = "robert.brown@example.com"
                },
                new Doctor
                {
                    IdDoctor = 5,
                    FirstName = "Emily",
                    LastName = "Davis",
                    Email = "emily.davis@example.com"
                },
                new Doctor
                {
                    IdDoctor = 6,
                    FirstName = "Michael",
                    LastName = "Wilson",
                    Email = "michael.wilson@example.com"
                }
            };

            builder.HasData(doctors);
        }
    }
}
