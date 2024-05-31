using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EF.Models;
using System.Collections.Generic;

namespace EF.Configurations
{
    public class MedicamentConfig : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.HasKey(e => e.IdMedicament).HasName("IdMedicament_PK");
            builder.Property(e => e.IdMedicament).UseIdentityColumn();

            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Description).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Type).HasMaxLength(100).IsRequired();
            
            var medicaments = new List<Medicament>
            {
                new Medicament
                {
                    IdMedicament = 1,
                    Name = "Paracetamol",
                    Description = "Used to treat mild to moderate pain and fever.",
                    Type = "Analgesic"
                },
                new Medicament
                {
                    IdMedicament = 2,
                    Name = "Amoxicillin",
                    Description = "Antibiotic used to treat various bacterial infections.",
                    Type = "Antibiotic"
                },
                new Medicament
                {
                    IdMedicament = 3,
                    Name = "Metformin",
                    Description = "Used to treat type 2 diabetes.",
                    Type = "Antidiabetic"
                },
                new Medicament
                {
                    IdMedicament = 4,
                    Name = "Lisinopril",
                    Description = "Used to treat high blood pressure and heart failure.",
                    Type = "ACE Inhibitor"
                },
                new Medicament
                {
                    IdMedicament = 5,
                    Name = "Atorvastatin",
                    Description = "Used to lower cholesterol and triglyceride levels.",
                    Type = "Statin"
                },
                new Medicament
                {
                    IdMedicament = 6,
                    Name = "Albuterol",
                    Description = "Used to treat or prevent bronchospasm.",
                    Type = "Bronchodilator"
                }
            };

            builder.HasData(medicaments);
        }
    }
}
