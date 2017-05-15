using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using telNet.Models;

namespace telNet.Mappers
{
    public class osobeMap : EntityTypeConfiguration<osobe>
    {
        public osobeMap()
    {
            this.ToTable("osobe");
            this.HasKey(o => o.osobeID);

            this.Property(o => o.osobeID).HasColumnName("osobeID").IsRequired();
            this.Property(o => o.adresa).HasColumnName("adresa").IsRequired().HasMaxLength(75);
            this.Property(o => o.ime).HasColumnName("ime").IsRequired().HasMaxLength(75);
            this.Property(o => o.prezime).HasColumnName("prezime").IsRequired().HasMaxLength(75);
            this.Property(o => o.username).HasColumnName("username").IsRequired().HasMaxLength(50);
            this.Property(o => o.password).HasColumnName("password").IsRequired().HasMaxLength(50);
            this.Property(o => o.datumRodjenja).HasColumnName("datumRodjenja").IsRequired();
            this.Property(o => o.telefon).HasColumnName("telefon").IsRequired().HasMaxLength(13);

        }
    }
}