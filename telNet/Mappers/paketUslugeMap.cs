using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using telNet.Models;

namespace telNet.Mappers
{
    public class paketUslugeMap : EntityTypeConfiguration<paketUsluge>
    {
        public paketUslugeMap()
        {
            this.ToTable("paketUsluge");
            this.HasKey(p => p.paketUslugeID);

            this.Property(k => k.paketUslugeID).HasColumnName("paketUslugeID").IsRequired();
            this.Property(k => k.paketID).HasColumnName("paketID").IsRequired();
            this.Property(k => k.uslugaID).HasColumnName("uslugaID").IsRequired();
            this.Property(k => k.opisPaketaUsluge).HasColumnName("opisPaketaUsluge").IsRequired().HasMaxLength(255);

        }
    }
}