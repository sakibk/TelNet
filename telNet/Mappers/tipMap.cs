using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using telNet.Models;

namespace telNet.Mappers
{
    public class tipMap : EntityTypeConfiguration<tip>
    {
        public tipMap()
        {
            this.ToTable("tip");
            this.HasKey(p => p.tipID);

            this.Property(k => k.tipID).HasColumnName("tipID").IsRequired();
            this.Property(k => k.nazivTipa).HasColumnName("Naziv Tipa").IsRequired().HasMaxLength(40);
        }
    }
}