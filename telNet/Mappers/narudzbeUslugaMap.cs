using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using telNet.Models;

namespace telNet.Mappers
{
    public class narudzbeUslugaMap : EntityTypeConfiguration<narudzbeUsluga>
    {
        public narudzbeUslugaMap()
        {
            this.ToTable("Narudzbe Usluga");
            this.HasKey(n => n.narudzbeUslugaID);

            this.Property(n => n.narudzbeUslugaID).HasColumnName("narudzbeUslugaID").IsRequired();
            this.Property(n => n.periodUsluge).HasColumnName("periodUsluge").IsRequired();
            this.Property(n => n.datumPocetkaUsluge).HasColumnName("datumPocetkaUsluge").IsRequired();
            this.Property(n => n.odobreno).HasColumnName("odobreno").IsOptional();
            this.Property(n => n.datumOdobrenja).HasColumnName("datumOdobrenja").IsOptional();


        }
    }
}