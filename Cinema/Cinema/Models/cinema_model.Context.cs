﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cinema.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Cinema5927Entities : DbContext
    {
        public Cinema5927Entities()
            : base("name=Cinema5927Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Table_Chair> Table_Chair { get; set; }
        public virtual DbSet<Table_Cinema> Table_Cinema { get; set; }
        public virtual DbSet<Table_DetailOder> Table_DetailOder { get; set; }
        public virtual DbSet<Table_Movie> Table_Movie { get; set; }
        public virtual DbSet<Table_Order> Table_Order { get; set; }
        public virtual DbSet<Table_Screen> Table_Screen { get; set; }
        public virtual DbSet<Table_StatusBay> Table_StatusBay { get; set; }
        public virtual DbSet<Table_StatusChire> Table_StatusChire { get; set; }
        public virtual DbSet<Table_StatusMovie> Table_StatusMovie { get; set; }
        public virtual DbSet<Table_Type> Table_Type { get; set; }
        public virtual DbSet<Table_User> Table_User { get; set; }
        public virtual DbSet<View_SumOder> View_SumOder { get; set; }
        public virtual DbSet<ViewMovies> ViewMovies { get; set; }
        public virtual DbSet<ViewOders> ViewOders { get; set; }
    }
}
