using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using telNet.Models;

namespace telNet.Mappers
{
    public class ratingMap : EntityTypeConfiguration<rating>
    {
        public ratingMap()
        {
            this.ToTable("rating");
            this.HasKey(p => p.ratingID);

            this.Property(k => k.ratingID).HasColumnName("ratingID").IsRequired();
            this.Property(k => k.rate).HasColumnName("rate").IsRequired();
            this.Property(k => k.overview).HasColumnName("overview").IsRequired().HasMaxLength(255);
            this.Property(k => k.datumRatinga).HasColumnName("Datum Ratinga").IsRequired();
            this.Property(k => k.datumIstekaRatinga).HasColumnName("Datum Isteka Ratinga").IsRequired();
        }
    }
}