namespace telNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.dobavljacs",
                c => new
                    {
                        dobavljacID = c.Int(nullable: false, identity: true),
                        naziv = c.String(),
                        adresa = c.String(),
                        ratingID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.dobavljacID)
                .ForeignKey("dbo.ratings", t => t.ratingID, cascadeDelete: true)
                .Index(t => t.ratingID);
            
            CreateTable(
                "dbo.ponudas",
                c => new
                    {
                        ponudaID = c.Int(nullable: false, identity: true),
                        ponudaProizvoda = c.Int(nullable: false),
                        ukupnaCijena = c.Single(nullable: false),
                        datumIsporuke = c.DateTime(nullable: false),
                        statusPonudeID = c.Int(nullable: false),
                        dobavljacID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ponudaID)
                .ForeignKey("dbo.dobavljacs", t => t.dobavljacID, cascadeDelete: true)
                .ForeignKey("dbo.statusPonudes", t => t.statusPonudeID, cascadeDelete: true)
                .Index(t => t.statusPonudeID)
                .Index(t => t.dobavljacID);
            
            CreateTable(
                "dbo.ponudaProizvodas",
                c => new
                    {
                        ponudaProizvodaID = c.Int(nullable: false, identity: true),
                        proizvodID = c.Int(nullable: false),
                        ponudaID = c.Int(nullable: false),
                        opis = c.String(),
                    })
                .PrimaryKey(t => t.ponudaProizvodaID)
                .ForeignKey("dbo.ponudas", t => t.ponudaID, cascadeDelete: true)
                .ForeignKey("dbo.proizvods", t => t.proizvodID, cascadeDelete: true)
                .Index(t => t.proizvodID)
                .Index(t => t.ponudaID);
            
            CreateTable(
                "dbo.proizvods",
                c => new
                    {
                        proizvodID = c.Int(nullable: false, identity: true),
                        kvalitetaProizvoda = c.Int(nullable: false),
                        cijenaProizvoda = c.Single(nullable: false),
                        opisProizvoda = c.String(),
                        tipProizvodaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.proizvodID)
                .ForeignKey("dbo.tipProizvodas", t => t.tipProizvodaID, cascadeDelete: true)
                .Index(t => t.tipProizvodaID);
            
            CreateTable(
                "dbo.tipProizvodas",
                c => new
                    {
                        tipProizvodaID = c.Int(nullable: false, identity: true),
                        nazivTipa = c.String(),
                        proizvodjac = c.String(),
                    })
                .PrimaryKey(t => t.tipProizvodaID);
            
            CreateTable(
                "dbo.statusPonudes",
                c => new
                    {
                        statusPonudeID = c.Int(nullable: false, identity: true),
                        nazivStatusa = c.String(),
                        datumStatusa = c.DateTime(nullable: false),
                        uposlenikID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.statusPonudeID)
                .ForeignKey("dbo.osobes", t => t.uposlenikID, cascadeDelete: true)
                .Index(t => t.uposlenikID);
            
            CreateTable(
                "dbo.narudzbeUslugas",
                c => new
                    {
                        narudzbeUslugaID = c.Int(nullable: false, identity: true),
                        periodUsluge = c.DateTime(nullable: false),
                        datumPocetkaUsluge = c.DateTime(nullable: false),
                        odobreno = c.Int(nullable: false),
                        datumOdobrenja = c.DateTime(nullable: false),
                        kupacID = c.Int(nullable: false),
                        statusUslugeID = c.Int(nullable: false),
                        UslugaID = c.Int(nullable: false),
                        paketID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.narudzbeUslugaID)
                .ForeignKey("dbo.osobes", t => t.kupacID, cascadeDelete: false)
                .ForeignKey("dbo.pakets", t => t.paketID, cascadeDelete: true)
                .ForeignKey("dbo.statusPonudes", t => t.statusUslugeID, cascadeDelete: true)
                .ForeignKey("dbo.uslugas", t => t.UslugaID, cascadeDelete: true)
                .Index(t => t.kupacID)
                .Index(t => t.statusUslugeID)
                .Index(t => t.UslugaID)
                .Index(t => t.paketID);
            
            CreateTable(
                "dbo.osobes",
                c => new
                    {
                        osobeID = c.Int(nullable: false, identity: true),
                        adresa = c.String(),
                        ime = c.String(),
                        prezime = c.String(),
                        username = c.String(),
                        password = c.String(),
                        datumRodjenja = c.DateTime(nullable: false),
                        telefon = c.String(),
                        tipID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.osobeID)
                .ForeignKey("dbo.tips", t => t.tipID, cascadeDelete: true)
                .Index(t => t.tipID);
            
            CreateTable(
                "dbo.tips",
                c => new
                    {
                        tipID = c.Int(nullable: false, identity: true),
                        nazivTipa = c.String(),
                    })
                .PrimaryKey(t => t.tipID);
            
            CreateTable(
                "dbo.pakets",
                c => new
                    {
                        paketID = c.Int(nullable: false, identity: true),
                        nazivPaketa = c.String(),
                        cijenaPaketa = c.Single(nullable: false),
                        opis = c.String(),
                        katalogID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.paketID)
                .ForeignKey("dbo.katalogs", t => t.katalogID, cascadeDelete: false)
                .Index(t => t.katalogID);
            
            CreateTable(
                "dbo.katalogs",
                c => new
                    {
                        katalogID = c.Int(nullable: false, identity: true),
                        nazivKataloga = c.String(),
                        opis = c.String(),
                    })
                .PrimaryKey(t => t.katalogID);
            
            CreateTable(
                "dbo.uslugas",
                c => new
                    {
                        uslugaID = c.Int(nullable: false, identity: true),
                        nazivUsluge = c.String(),
                        tipUsluge = c.String(),
                        cijenaUsluge = c.Single(nullable: false),
                        opis = c.String(),
                        katalogID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.uslugaID)
                .ForeignKey("dbo.katalogs", t => t.katalogID, cascadeDelete: false)
                .Index(t => t.katalogID);
            
            CreateTable(
                "dbo.paketUsluges",
                c => new
                    {
                        paketUslugeID = c.Int(nullable: false, identity: true),
                        paketID = c.Int(nullable: false),
                        uslugaID = c.Int(nullable: false),
                        opisPaketaUsluge = c.String(),
                    })
                .PrimaryKey(t => t.paketUslugeID)
                .ForeignKey("dbo.pakets", t => t.paketID, cascadeDelete: true)
                .ForeignKey("dbo.uslugas", t => t.uslugaID, cascadeDelete: true)
                .Index(t => t.paketID)
                .Index(t => t.uslugaID);
            
            CreateTable(
                "dbo.ratings",
                c => new
                    {
                        ratingID = c.Int(nullable: false, identity: true),
                        rate = c.Single(nullable: false),
                        overview = c.String(),
                        datumRatinga = c.DateTime(nullable: false),
                        datumIstekaRatinga = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ratingID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.dobavljacs", "ratingID", "dbo.ratings");
            DropForeignKey("dbo.ponudas", "statusPonudeID", "dbo.statusPonudes");
            DropForeignKey("dbo.statusPonudes", "uposlenikID", "dbo.osobes");
            DropForeignKey("dbo.narudzbeUslugas", "UslugaID", "dbo.uslugas");
            DropForeignKey("dbo.narudzbeUslugas", "statusUslugeID", "dbo.statusPonudes");
            DropForeignKey("dbo.narudzbeUslugas", "paketID", "dbo.pakets");
            DropForeignKey("dbo.pakets", "katalogID", "dbo.katalogs");
            DropForeignKey("dbo.paketUsluges", "uslugaID", "dbo.uslugas");
            DropForeignKey("dbo.paketUsluges", "paketID", "dbo.pakets");
            DropForeignKey("dbo.uslugas", "katalogID", "dbo.katalogs");
            DropForeignKey("dbo.narudzbeUslugas", "kupacID", "dbo.osobes");
            DropForeignKey("dbo.osobes", "tipID", "dbo.tips");
            DropForeignKey("dbo.ponudaProizvodas", "proizvodID", "dbo.proizvods");
            DropForeignKey("dbo.proizvods", "tipProizvodaID", "dbo.tipProizvodas");
            DropForeignKey("dbo.ponudaProizvodas", "ponudaID", "dbo.ponudas");
            DropForeignKey("dbo.ponudas", "dobavljacID", "dbo.dobavljacs");
            DropIndex("dbo.paketUsluges", new[] { "uslugaID" });
            DropIndex("dbo.paketUsluges", new[] { "paketID" });
            DropIndex("dbo.uslugas", new[] { "katalogID" });
            DropIndex("dbo.pakets", new[] { "katalogID" });
            DropIndex("dbo.osobes", new[] { "tipID" });
            DropIndex("dbo.narudzbeUslugas", new[] { "paketID" });
            DropIndex("dbo.narudzbeUslugas", new[] { "UslugaID" });
            DropIndex("dbo.narudzbeUslugas", new[] { "statusUslugeID" });
            DropIndex("dbo.narudzbeUslugas", new[] { "kupacID" });
            DropIndex("dbo.statusPonudes", new[] { "uposlenikID" });
            DropIndex("dbo.proizvods", new[] { "tipProizvodaID" });
            DropIndex("dbo.ponudaProizvodas", new[] { "ponudaID" });
            DropIndex("dbo.ponudaProizvodas", new[] { "proizvodID" });
            DropIndex("dbo.ponudas", new[] { "dobavljacID" });
            DropIndex("dbo.ponudas", new[] { "statusPonudeID" });
            DropIndex("dbo.dobavljacs", new[] { "ratingID" });
            DropTable("dbo.ratings");
            DropTable("dbo.paketUsluges");
            DropTable("dbo.uslugas");
            DropTable("dbo.katalogs");
            DropTable("dbo.pakets");
            DropTable("dbo.tips");
            DropTable("dbo.osobes");
            DropTable("dbo.narudzbeUslugas");
            DropTable("dbo.statusPonudes");
            DropTable("dbo.tipProizvodas");
            DropTable("dbo.proizvods");
            DropTable("dbo.ponudaProizvodas");
            DropTable("dbo.ponudas");
            DropTable("dbo.dobavljacs");
        }
    }
}
