using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EF.Models;
using System;
using System.Collections.Generic;

namespace EF.Configurations
{
    public class PatientConfig : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(e => e.IdPatient).HasName("IdPatient_PK");
            builder.Property(e => e.IdPatient).ValueGeneratedOnAdd();

            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.BirthDate).IsRequired();
            
            var patients = new List<Patient>
            {
                new Patient
                {
                    IdPatient = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    BirthDate = new DateTime(1990, 5, 15)
                },
                new Patient
                {
                    IdPatient = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    BirthDate = new DateTime(1995, 8, 25)
                },
                new Patient
                {
                    IdPatient = 3,
                    FirstName = "Alice",
                    LastName = "Johnson",
                    BirthDate = new DateTime(1987, 3, 30)
                },
                new Patient
                {
                    IdPatient = 4,
                    FirstName = "Robert",
                    LastName = "Brown",
                    BirthDate = new DateTime(2000, 7, 12)
                },
                new Patient
                {
                    IdPatient = 5,
                    FirstName = "Emily",
                    LastName = "Davis",
                    BirthDate = new DateTime(1970, 11, 5)
                },
                new Patient
                {
                    IdPatient = 6,
                    FirstName = "Michael",
                    LastName = "Wilson",
                    BirthDate = new DateTime(1985, 2, 20)
                }
            };

            builder.HasData(patients);
        }
    }
}
