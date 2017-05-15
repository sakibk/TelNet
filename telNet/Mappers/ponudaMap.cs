using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using telNet.Models;

namespace telNet.Mappers
{
    public class ponudaMap : EntityTypeConfiguration<ponuda>
    {
        public ponudaMap()
        {
            this.ToTable("ponuda");
            this.HasKey(p => p.ponudaID);

            this.Property(k => k.ponudaID).HasColumnName("ponudaID").IsRequired();
            this.Property(k => k.ponudaProizvoda).HasColumnName("Ponuda proizvoda").IsRequired();
            this.Property(k => k.ukupnaCijena).HasColumnName("Ukupna cijena").IsRequired();
            this.Property(k => k.datumIsporuke).HasColumnName("Datum Isporuke").IsRequired();

            this.Property(k => k.statusPonudeID).HasColumnName("StatusPonudeID").IsRequired();
            this.Property(k => k.dobavljacID).HasColumnName("dobavljacID").IsRequired();
        }
    }
}