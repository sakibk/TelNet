using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using telNet.Models;

namespace telNet.Mappers
{
    public class dobavljacMap : EntityTypeConfiguration<dobavljac>
    {
        public dobavljacMap()
        {
            this.ToTable("Dobavljac");
            this.HasKey(d => d.dobavljacID);

            this.Property(d => d.dobavljacID).HasColumnName("dobavljacID").IsRequired();
            this.Property(d => d.naziv).HasColumnName("naziv").IsRequired().HasMaxLength(50);
            this.Property(d => d.adresa).HasColumnName("adresa").IsRequired().HasMaxLength(75);
        }
    }
}