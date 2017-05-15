using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using telNet.Mappers;
using telNet.Models;

namespace telNet
{
    public class telNetContext :DbContext
    {
        public telNetContext(): base("name = telNetConnection")
        {
            Database.SetInitializer<telNetContext>(new CreateDatabaseIfNotExists<telNetContext>());
        }

        public DbSet<dobavljac> dobavljaci { get; set; }
        public DbSet<katalog> katalozi { get; set; }
        public DbSet<narudzbeUsluga> narudzbeUsluga { get; set; }
        public DbSet<osobe> osobe { get; set; }
        public DbSet<paket> paketi { get; set; }
        public DbSet<paketUsluge> paketUsluga { get; set; }
        public DbSet<ponuda> ponude { get; set; }
        public DbSet<ponudaProizvoda> ponudaProizvoda { get; set; }
        public DbSet<proizvod> proizvodi { get; set; }
        public DbSet<rating> rating { get; set; }
        public DbSet<statusPonude> statusiPonuda { get; set; }
        public DbSet<tip> tipovi { get; set; }
        public DbSet<tipProizvoda> tipoviProizvoda { get; set; }
        public DbSet<usluga> usluge { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new dobavljacMap());
            modelBuilder.Configurations.Add(new katalogMap());
            modelBuilder.Configurations.Add(new narudzbeUslugaMap());
            modelBuilder.Configurations.Add(new osobeMap());
            modelBuilder.Configurations.Add(new paketMap());
            modelBuilder.Configurations.Add(new paketUslugeMap());
            modelBuilder.Configurations.Add(new ponudaMap());
            modelBuilder.Configurations.Add(new ponudaProizvodaMap());
            modelBuilder.Configurations.Add(new proizvodMap());
            modelBuilder.Configurations.Add(new ratingMap());
            modelBuilder.Configurations.Add(new statusPonudeMap());
            modelBuilder.Configurations.Add(new tipMap());
            modelBuilder.Configurations.Add(new tipProizvodaMap());
            modelBuilder.Configurations.Add(new uslugaMap());

            modelBuilder.Entity<dobavljac>().HasRequired(p => p.rating).WithMany(x => x.dobavljaci).HasForeignKey(x => x.ratingID);
            modelBuilder.Entity<ponuda>().HasRequired(p => p.dobavljac).WithMany(x => x.ponude).HasForeignKey(x => x.dobavljacID);
            modelBuilder.Entity<ponudaProizvoda>().HasRequired(p => p.ponuda).WithMany(x => x.ponudeProizvoda).HasForeignKey(x => x.ponudaID);
            modelBuilder.Entity<ponudaProizvoda>().HasRequired(p => p.proizvod).WithMany(x => x.ponudeProizvoda).HasForeignKey(x => x.proizvodID);
            modelBuilder.Entity<proizvod>().HasRequired(p => p.tipProizvoda).WithMany(x => x.proizvodi).HasForeignKey(x => x.tipProizvodaID);
            modelBuilder.Entity<ponuda>().HasRequired(p => p.statusPonude).WithMany(x => x.ponude).HasForeignKey(x => x.statusPonudeID);
            modelBuilder.Entity<statusPonude>().HasRequired(p => p.uposlenik).WithMany(x => x.statusPonuda).HasForeignKey(x => x.uposlenikID);
            modelBuilder.Entity<osobe>().HasRequired(p => p.tip).WithMany(x => x.Osobe).HasForeignKey(x => x.tipID);
            modelBuilder.Entity<narudzbeUsluga>().HasRequired(p => p.statusUsluge).WithMany(x => x.narudzbeUsluga).HasForeignKey(x => x.statusUslugeID);
            modelBuilder.Entity<narudzbeUsluga>().HasRequired(p => p.kupac).WithMany(x => x.narudzbeUsluga).HasForeignKey(x => x.kupacID);
            modelBuilder.Entity<narudzbeUsluga>().HasRequired(p => p.usluga).WithMany(x => x.narudzbeUsluga).HasForeignKey(x => x.UslugaID);
            modelBuilder.Entity<narudzbeUsluga>().HasRequired(p => p.paket).WithMany(x => x.narudzbeUsluga).HasForeignKey(x => x.paketID);
            modelBuilder.Entity<paket>().HasRequired(p => p.katalog).WithMany(x => x.paketi).HasForeignKey(x => x.katalogID);
            modelBuilder.Entity<usluga>().HasRequired(p => p.katalog).WithMany(x => x.usluge).HasForeignKey(x => x.katalogID);
            modelBuilder.Entity<paketUsluge>().HasRequired(p => p.usluga).WithMany(x => x.paketiUsluga).HasForeignKey(x => x.uslugaID);
            modelBuilder.Entity<paketUsluge>().HasRequired(p => p.paket).WithMany(x => x.paketiUsluga).HasForeignKey(x => x.paketID);
        }
    }
}