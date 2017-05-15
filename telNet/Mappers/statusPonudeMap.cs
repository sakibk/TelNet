using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using telNet.Models;

namespace telNet.Mappers
{
    public class statusPonudeMap : EntityTypeConfiguration<statusPonude>
    {
        public statusPonudeMap()
        {
            this.ToTable("statusPonude");
            this.HasKey(p => p.statusPonudeID);

            this.Property(k => k.statusPonudeID).HasColumnName("statusPonudeID").IsRequired();
            this.Property(k => k.nazivStatusa).HasColumnName("Naziv Statusa").IsRequired().HasMaxLength(40);
            this.Property(k => k.datumStatusa).HasColumnName("Datum Statusa").IsRequired();
            this.Property(k => k.uposlenikID).HasColumnName("UposlenikID").IsRequired();
        }
    }
}