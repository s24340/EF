﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EF.Models;

namespace EF.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.IdUser).HasName("User_PK");
            builder.Property(e => e.IdUser).UseIdentityColumn();

            builder.Property(e => e.Login).HasMaxLength(32).IsRequired();
            builder.HasIndex(e => e.Login).IsUnique();

            builder.Property(e => e.Password).HasMaxLength(128).IsRequired();
            builder.Property(e => e.Salt).HasMaxLength(64).IsRequired();
            builder.Property(e => e.RefreshToken).HasMaxLength(64).IsRequired();
            builder.Property(e => e.RerfreshTokenExpiration);
        }
    }
}