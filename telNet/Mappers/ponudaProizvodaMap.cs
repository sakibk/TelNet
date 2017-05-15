using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using telNet.Models;

namespace telNet.Mappers
{
    public class ponudaProizvodaMap : EntityTypeConfiguration<ponudaProizvoda>
    {
        public ponudaProizvodaMap()
        {
            this.ToTable("ponudaProizvoda");
            this.HasKey(p => p.ponudaProizvodaID);

            this.Property(k => k.ponudaProizvodaID).HasColumnName("ponudaProizvodaID").IsRequired();
            this.Property(k => k.ponudaID).HasColumnName("ponudaID").IsRequired();
            this.Property(k => k.proizvodID).HasColumnName("proizvodID").IsRequired();
            this.Property(k => k.opis).HasColumnName("opis Ponude Proizvoda").IsRequired().HasMaxLength(255);
        }
    }
}