﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kursovaya
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Branch_pharmacy_KorolevEntities : DbContext
    {
        public Branch_pharmacy_KorolevEntities()
            : base("name=Branch_pharmacy_KorolevEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Application_Product> Application_Product { get; set; }
        public virtual DbSet<Category_Product> Category_Product { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Home> Home { get; set; }
        public virtual DbSet<Pharmcy> Pharmcy { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Strit> Strit { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Warning> Warning { get; set; }
        public virtual DbSet<Recucle_bin> Recucle_bin { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
