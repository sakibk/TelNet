using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using telNet.Models;

namespace telNet.Mappers
{

    public class paketMap : EntityTypeConfiguration<paket>
    {
        public paketMap()
        {
            this.ToTable("paket");
            this.HasKey(p => p.paketID);

            this.Property(p => p.paketID).HasColumnName("PaketID").IsRequired();
            this.Property(p=>p.nazivPaketa).HasColumnName("Naziv Paketa").IsRequired().HasMaxLength(50);
            this.Property(p => p.cijenaPaketa).HasColumnName("cijena Paketa").IsRequired();
            this.Property(p => p.opis).HasColumnName("Opis").IsRequired().HasMaxLength(50);
        }
    }
}