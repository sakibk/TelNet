using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using telNet.Models;

namespace telNetApi.Models
{
    public class Factory
    {
        public static dobavljacModel Create(dobavljac dobavljac,bool withPonude)
        {
            return new dobavljacModel()
            {
                dobavljacID = dobavljac.dobavljacID,
                adresa = dobavljac.adresa,
                naziv = dobavljac.naziv,
                ratingID = dobavljac.ratingID,
                dobavljacRate = dobavljac.rating.rate,
                dobavljacOverview = dobavljac.rating.overview,
                datumRatinga = dobavljac.rating.datumRatinga,
                datumIstekaRatinga = dobavljac.rating.datumIstekaRatinga,
                ponude =(withPonude)? dobavljac.ponude.ToList().Select(x => Factory.Create(x,false)).ToList() : new List<ponudaModel>()
            };
        }

        public dobavljac Parse(dobavljacModel dobavljac)
        {
            try
            {
                var _dobavljac = new dobavljac();

                return _dobavljac;

            }
            catch
            {
                return null;

            }
        }
        

        public static ratingModel Create(rating rate, bool withDobavljaci)
        {
            return new ratingModel()
            {
                ratingID = rate.ratingID,
                rate = rate.rate,
                datumRatinga = rate.datumRatinga,
                datumIstekaRatinga = rate.datumIstekaRatinga,
                overview = rate.overview,
                dobavljaci =(withDobavljaci) ? rate.dobavljaci.ToList().Select(x => Factory.Create(x,false)).ToList() : new List<dobavljacModel>()
            };
        }

        public rating Parse(ratingModel rate)
        {
            try
            {
                var _rate = new rating();

                return _rate;

            }
            catch
            {
                return null;

            }
        }

        public static katalogModel Create(katalog cat,bool withPaketi, bool withUsluge)
        {
            return new katalogModel()
            {
                katalogID = cat.katalogID,
                nazivKataloga = cat.nazivKataloga,
                opis = cat.opis,
                paketi =(withPaketi) ? cat.paketi.ToList().Select(x=>Factory.Create(x,false,false)).ToList() : new List<paketModel>(),
                usluge =(withUsluge) ? cat.usluge.ToList().Select(x=>Factory.Create(x,false,false)).ToList() : new List<uslugaModel>()
            };
        }
        public katalog Parse(katalogModel kat)
        {
            try
            {
                var _kat = new katalog();

                return _kat;

            }
            catch
            {
                return null;

            }
        }

        public static narudzbeUslugaModel Create(narudzbeUsluga nu)
        {
            return new narudzbeUslugaModel()
            {
                narudzbeUslugaID = nu.narudzbeUslugaID,
                periodUsluge = nu.periodUsluge,
                datumOdobrenja = nu.datumOdobrenja,
                datumPocetkaUsluge = nu.datumPocetkaUsluge,
                odobreno = nu.odobreno,
                kupacID = nu.kupacID,
                adresaKupca = nu.kupac.adresa,
                imeKupca = nu.kupac.ime,
                prezimeKupca = nu.kupac.prezime,
                telefonKupca = nu.kupac.telefon,
                statusUslugeID = nu.statusUslugeID,
                nazivStatusa = nu.statusUsluge.nazivStatusa,
                uposlenikID = nu.statusUsluge.uposlenikID,
                imeUposlenika = nu.statusUsluge.uposlenik.ime,
                prezimeUposlenika = nu.statusUsluge.uposlenik.prezime,
                UslugaID = nu.UslugaID,
                nazivUsluge = nu.usluga.nazivUsluge,
                tipUsluge = nu.usluga.tipUsluge,
                cijenaUsluge = nu.usluga.cijenaUsluge,
                opisUsluge = nu.usluga.opis,
                paketID = nu.paketID,
                nazivPaketa = nu.paket.nazivPaketa,
                cijenaPaketa = nu.paket.cijenaPaketa,
                opisPaketa = nu.paket.opis
            };
        }
        public narudzbeUsluga Parse(narudzbeUslugaModel nu)
        {
            try
            {
                var _nu = new narudzbeUsluga();

                return _nu;

            }
            catch
            {
                return null;

            }
        }

        public static osobeModel Create(osobe o, bool withStatusPonuda, bool withNarudzbeUsluga)
        {
            return new osobeModel()
            {
                osobeID = o.osobeID,
                adresa = o.adresa,
                ime = o.ime,
                prezime = o.prezime,
                datumRodjenja = o.datumRodjenja,
                telefon = o.telefon,
                tipID = o.tipID,
                nazivTipa = o.tip.nazivTipa,
                statusPonuda = (withStatusPonuda) ? o.statusPonuda.ToList().Select(x => Factory.Create(x,false,false)).ToList() : new List<statusPonudeModel>(),
                narudzbeUsluga = (withNarudzbeUsluga) ? o.narudzbeUsluga.ToList().Select(x => Factory.Create(x)).ToList() : new List<narudzbeUslugaModel>()
            };
        }

        public osobe Parse(osobeModel osobe)
        {
            try
            {
                var _osobe = new osobe();

                return _osobe;

            }
            catch
            {
                return null;

            }
        }

        public static paketModel Create(paket p, bool withPaketi, bool withNarudzbe)
        {
            return new paketModel()
            {
                 paketID = p.paketID,
                 nazivPaketa = p.nazivPaketa,
                 cijenaPaketa = p.cijenaPaketa,
                 opis = p.opis,
                 katalogID = p.katalogID,
                 nazivKataloga = p.katalog.nazivKataloga,
                 opisKataloga = p.katalog.opis,
                 paketiUsluga =(withPaketi) ? p.paketiUsluga.ToList().Select(x=>Factory.Create(x)).ToList() : new List<paketUslugeModel>(),
                 narudzbeUsluga =(withNarudzbe) ? p.narudzbeUsluga.ToList().Select(x=>Factory.Create(x)).ToList() : new List<narudzbeUslugaModel>()
            };
        }

        public paket Parse(paketModel pack)
        {
            try
            {
                var _pack = new paket();

                return _pack;

            }
            catch
            {
                return null;

            }
        }

        public static paketUslugeModel Create(paketUsluge pu)
        {
            return new paketUslugeModel()
            {
                paketUslugeID = pu.paketUslugeID,
                paketID = pu.paketID,
                nazivPaketa = pu.paket.nazivPaketa,
                cijenaPaketa = pu.paket.cijenaPaketa,
                opisPaketa = pu.paket.opis,
                uslugaID = pu.uslugaID,
                nazivUsluge = pu.usluga.nazivUsluge,
                cijenaUsluge = pu.usluga.cijenaUsluge,
                opisUsluge = pu.usluga.opis,
                opisPaketaUsluge = pu.opisPaketaUsluge
            };
        }

        public paketUsluge Parse(paketUslugeModel pu)
        {
            try
            {
                var _pu = new paketUsluge();

                return _pu;

            }
            catch
            {
                return null;

            }
        }

        public static ponudaModel Create(ponuda p, bool withPonudaProizvoda)
        {
            return new ponudaModel()
            {
                ponudaID = p.ponudaID,
                ponudaProizvoda = p.ponudaProizvoda,
                ukupnaCijena = p.ukupnaCijena,
                datumIsporuke = p.datumIsporuke,
                statusPonudeID = p.statusPonudeID,
                nazivStatusa = p.statusPonude.nazivStatusa,
                datumStatusa = p.statusPonude.datumStatusa,
                uposlenikID = p.statusPonude.uposlenikID,
                imeUposlenika = p.statusPonude.uposlenik.ime,
                prezimeUposlenika = p.statusPonude.uposlenik.prezime,
                dobavljacID = p.dobavljacID,
                imeDobavljaca = p.dobavljac.naziv,
                adresaDobavljaca = p.dobavljac.adresa,
                ratingID = p.dobavljac.ratingID,
                rate = p.dobavljac.rating.rate,
                ponudeProizvoda =(withPonudaProizvoda) ? p.ponudeProizvoda .ToList().Select(x=>Factory.Create(x)).ToList() : new List<ponudaProizvodaModel>()
            };
        }

        public ponuda Parse(ponudaModel ponuda)
        {
            try
            {
                var _ponuda = new ponuda();

                return _ponuda;

            }
            catch
            {
                return null;

            }
        }

        public static ponudaProizvodaModel Create(ponudaProizvoda pp)
        {
            return new ponudaProizvodaModel()
            {
                ponudaProizvodaID = pp.ponudaProizvodaID,
                proizvodID = pp.proizvodID,
                kvalitetaProizvoda = pp.proizvod.kvalitetaProizvoda,
                cijenaProizvoda = pp.proizvod.cijenaProizvoda,
                opisProizvoda = pp.proizvod.opisProizvoda,
                tipProizvodaID = pp.proizvod.tipProizvodaID,
                ponudaID = pp.ponudaID,
                ponudaProizvoda = pp.ponuda.ponudaProizvoda,
                ukupnaCijena = pp.ponuda.ukupnaCijena,
                datumIsporuke = pp.ponuda.datumIsporuke,
                statusPonudeID = pp.ponuda.statusPonudeID,
                dobavljacID = pp.ponuda.dobavljacID,
                opis = pp.opis
            };
        }

        public ponudaProizvoda Parse(ponudaProizvodaModel pp)
        {
            try
            {
                var _pp = new ponudaProizvoda();

                return _pp;

            }
            catch
            {
                return null;

            }
        }

        public static proizvodModel Create(proizvod p, bool withPonudeProizvoda)
        {
            return new proizvodModel()
            {
                proizvodID = p.proizvodID,
                kvalitetaProizvoda = p.kvalitetaProizvoda,
                cijenaProizvoda = p.cijenaProizvoda,
                opisProizvoda = p.opisProizvoda,
                tipProizvodaID = p.tipProizvodaID,
                nazivTipa = p.tipProizvoda.nazivTipa,
                proizvodjac = p.tipProizvoda.proizvodjac,
                ponudeProizvoda= (withPonudeProizvoda) ? p.ponudeProizvoda.ToList().Select(x=>Factory.Create(x)).ToList() : new List<ponudaProizvodaModel>()
            };
        }

        public proizvod Parse(proizvodModel proizvodd)
        {
            try
            {
                var _proizvod = new proizvod();

                return _proizvod;

            }
            catch
            {
                return null;

            }
        }

        public static statusPonudeModel Create(statusPonude sp, bool withPonude, bool withNarudzbeUsluga)
        {
            return new statusPonudeModel()
            {
                statusPonudeID = sp.statusPonudeID,
                nazivStatusa = sp.nazivStatusa,
                datumStatusa = sp.datumStatusa,
                uposlenikID = sp.uposlenikID,
                imeUposlenika = sp.uposlenik.ime,
                prezimeUposlenika = sp.uposlenik.prezime,
                ponude = (withPonude) ? sp.ponude.ToList().Select(x => Factory.Create(x,false)).ToList() : new List<ponudaModel>(),
                narudzbeUsluga =(withNarudzbeUsluga) ? sp.narudzbeUsluga.ToList().Select(x=>Factory.Create(x)).ToList() : new List<narudzbeUslugaModel>()
            };
        }

        public statusPonude Parse(statusPonudeModel statp)
        {
            try
            {
                var _statp = new statusPonude();

                return _statp;

            }
            catch
            {
                return null;

            }
        }

        public static tipModel Create(tip t, bool withOsobe)
        {
            return new tipModel()
            {
                tipID = t.tipID,
                nazivTipa = t.nazivTipa,
                Osobe =(withOsobe) ? t.Osobe.ToList().Select(x => Factory.Create(x,false,false)).ToList() : new List<osobeModel>()
            };
        }

        public tip Parse(tipModel t)
        {
            try
            {
                var _t = new tip();

                return _t;

            }
            catch
            {
                return null;

            }
        }

        public static tipProizvodaModel Create(tipProizvoda tp, bool withProizvodi)
        {
            return new tipProizvodaModel()
            {
                tipProizvodaID = tp.tipProizvodaID,
                nazivTipa = tp.nazivTipa,
                proizvodjac = tp.proizvodjac,
                proizvodi =(withProizvodi) ? tp.proizvodi.ToList().Select(x=>Factory.Create(x,false)).ToList(): new List<proizvodModel>()
            };
        }

        public tipProizvoda Parse(tipProizvodaModel tp)
        {
            try
            {
                var _tp = new tipProizvoda();

                return _tp;

            }
            catch
            {
                return null;

            }
        }

        public static uslugaModel Create(usluga u, bool withPaketiUsluga, bool withNarudzbeUsluga)
        {
            return new uslugaModel()
            {
                uslugaID = u.uslugaID,
                nazivUsluge = u.nazivUsluge,
                tipUsluge = u.tipUsluge,
                cijenaUsluge = u.cijenaUsluge,
                opis = u.opis,
                katalogID = u.katalogID,
                paketiUsluga =(withPaketiUsluga) ? u.paketiUsluga.ToList().Select(x=>Factory.Create(x)).ToList(): new List<paketUslugeModel>(),
                narudzbeUsluga =(withNarudzbeUsluga) ? u.narudzbeUsluga.ToList().Select(x=>Factory.Create(x)).ToList(): new List<narudzbeUslugaModel>()
            };
        }

        public usluga Parse(uslugaModel uslugam)
        {
            try
            {
                var _usluga = new usluga();

                return _usluga;

            }
            catch
            {
                return null;

            }
        }

    }
}