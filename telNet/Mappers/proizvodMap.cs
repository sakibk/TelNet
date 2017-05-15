using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using telNet.Models;

namespace telNet.Mappers
{
    public class proizvodMap : EntityTypeConfiguration<proizvod>
    {
        public proizvodMap()
        {
            this.ToTable("proizvod");
            this.HasKey(p => p.proizvodID);

            this.Property(k => k.proizvodID).HasColumnName("proizvodID").IsRequired();
            this.Property(k => k.kvalitetaProizvoda).HasColumnName("Kvaliteta proizvoda").IsRequired();
            this.Property(k => k.cijenaProizvoda).HasColumnName("Cijena Proizvoda").IsRequired();
            this.Property(k => k.opisProizvoda).HasColumnName("Opis Proizvoda").IsRequired().HasMaxLength(255);
            this.Property(k => k.tipProizvodaID).HasColumnName("tipProizvodaID").IsRequired();
        }
    }
}