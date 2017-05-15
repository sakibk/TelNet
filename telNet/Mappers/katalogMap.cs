using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using telNet.Models;

namespace telNet.Mappers
{
    public class katalogMap : EntityTypeConfiguration<katalog>
    {
        public katalogMap()
        {
            this.ToTable("katalog");
            this.HasKey(k => k.katalogID);

            this.Property(k => k.katalogID).HasColumnName("katalogID").IsRequired();
            this.Property(k => k.nazivKataloga).HasColumnName("naziv kataloga").IsRequired().HasMaxLength(50);
            this.Property(k => k.opis).HasColumnName("opis").IsRequired().HasMaxLength(200);
        }
    }
}