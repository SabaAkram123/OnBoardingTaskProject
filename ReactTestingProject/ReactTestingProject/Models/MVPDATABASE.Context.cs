﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReactTestingProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ONBORADING_TASK_DemoEntities : DbContext
    {
        public ONBORADING_TASK_DemoEntities()
            : base("name=ONBORADING_TASK_DemoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer_Table> Customer_Table { get; set; }
        public virtual DbSet<Product_Table> Product_Table { get; set; }
        public virtual DbSet<Sales_Table> Sales_Table { get; set; }
        public virtual DbSet<Store_Table> Store_Table { get; set; }
    }
}