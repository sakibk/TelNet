using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using telNet.Models;

namespace telNet.Mappers
{
    public class tipProizvodaMap : EntityTypeConfiguration<tipProizvoda>
    {
        public tipProizvodaMap()
        {
            this.ToTable("tipProizvoda");
            this.HasKey(p => p.tipProizvodaID);

            this.Property(k => k.tipProizvodaID).HasColumnName("tipProizvodaID").IsRequired();
            this.Property(k => k.nazivTipa).HasColumnName("naziv Tipa").IsRequired().HasMaxLength(40);
            this.Property(k => k.proizvodjac).HasColumnName("proizvodzac").IsRequired().HasMaxLength(50);
        }
    }
}