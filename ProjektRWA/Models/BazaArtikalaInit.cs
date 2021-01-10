using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace ProjektRWA.Models
{
    public class BazaArtikalaInit : DropCreateDatabaseIfModelChanges<ArtikalContext>
    {
        protected override void Seed(ArtikalContext context)
        {
            GetKategorije().ForEach(c => context.Kategorije.Add(c));
            GetArtikli().ForEach(a => context.Artikli.Add(a));
        }

        private static List<Kategorija> GetKategorije()
        {
            var kategorije = new List<Kategorija>
            {
                new Kategorija
                {
                    KategorijaID = 1,
                    KategorijaIme = "Kat1"
                },
                new Kategorija
                {
                    KategorijaID = 2,
                    KategorijaIme = "Kat2"
                },
                new Kategorija
                {
                    KategorijaID = 3,
                    KategorijaIme = "Kat3"
                }
            };

            return kategorije;
        }

        private static List<Artikal> GetArtikli()
        {
            var artikli = new List<Artikal>
            {
                new Artikal
                {
                    ArtikalID = 1,
                    ArtikalIme = "Art1",
                    Opis = "Opis art1",
                    ArtikalCijena = 19.99,
                    KategorijaID = 1
                },
                new Artikal
                {
                    ArtikalID = 2,
                    ArtikalIme = "Art2",
                    Opis = "Opis art2",
                    ArtikalCijena = 5.99,
                    KategorijaID = 1
                },
                new Artikal
                {
                    ArtikalID = 3,
                    ArtikalIme = "Art3",
                    Opis = "Opis art3",
                    ArtikalCijena = 14.99,
                    KategorijaID = 2
                },
                new Artikal
                {
                    ArtikalID = 4,
                    ArtikalIme = "Art4",
                    Opis = "Opis art4",
                    ArtikalCijena = 49.99,
                    KategorijaID = 3
                }
            };

            return artikli;
        }
    }
}