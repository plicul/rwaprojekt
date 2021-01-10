using System;
using System.Data.Entity;

namespace ProjektRWA.Models
{
    public class ArtikalContext : DbContext
    {
        public ArtikalContext() : base("ProjektRWA")
        {
        }
        public DbSet<Kategorija> Kategorije { get; set; }
        public DbSet<Artikal> Artikli { get; set; }
    }
}