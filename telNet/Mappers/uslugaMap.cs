using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using telNet.Models;

namespace telNet.Mappers
{
    public class uslugaMap : EntityTypeConfiguration<usluga>
    {
        public uslugaMap()
        {
            this.ToTable("usluga");
            this.HasKey(p => p.uslugaID);

            this.Property(k => k.uslugaID).HasColumnName("uslugaID").IsRequired();
            this.Property(k => k.nazivUsluge).HasColumnName("Naziv Usluge").IsRequired().HasMaxLength(40);
            this.Property(k => k.tipUsluge).HasColumnName("Tip Usluge").IsRequired().HasMaxLength(40);
            this.Property(k => k.cijenaUsluge).HasColumnName("Cijena Usluge").IsRequired();
            this.Property(k => k.opis).HasColumnName("Opis Usluge").IsRequired().HasMaxLength(255);
            this.Property(k => k.katalogID).HasColumnName("Katalog Usluge").IsRequired();
        }
    }
}