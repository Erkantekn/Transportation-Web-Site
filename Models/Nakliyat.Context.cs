﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nakliyat.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class nakliyatEntities : DbContext
    {
        public nakliyatEntities()
            : base("name=nakliyatEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<depolama> depolama { get; set; }
        public virtual DbSet<iletisimFormu> iletisimFormu { get; set; }
        public virtual DbSet<pagesHizmetEkleme> pagesHizmetEkleme { get; set; }
        public virtual DbSet<sirketBilgileri> sirketBilgileri { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<pageIletisim> pageIletisim { get; set; }
        public virtual DbSet<pageHakkimizdaa> pageHakkimizdaa { get; set; }
        public virtual DbSet<defaultHizmetSayfasiBilgileri> defaultHizmetSayfasiBilgileri { get; set; }
        public virtual DbSet<ResimKategorileri> ResimKategorileri { get; set; }
        public virtual DbSet<Resimler> Resimler { get; set; }
        public virtual DbSet<sitemapUrl> sitemapUrl { get; set; }
    }
}
