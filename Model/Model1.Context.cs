﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLThuCung.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ThụCungEntities : DbContext
    {
        public ThụCungEntities()
            : base("name=ThụCungEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Contract_Sell> Contract_Sell { get; set; }
        public virtual DbSet<Contract_Ser> Contract_Ser { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DetailContractSer> DetailContractSers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<Servic> Servics { get; set; }
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WarrantyType> WarrantyTypes { get; set; }
        public virtual DbSet<Work> Works { get; set; }
    
        public virtual int usp_MuaDichVu(string idconser, string idemp, string idcus, Nullable<System.DateTime> datebuy, Nullable<int> price, string idser1, string idser2, string idser3, string idser4)
        {
            var idconserParameter = idconser != null ?
                new ObjectParameter("idconser", idconser) :
                new ObjectParameter("idconser", typeof(string));
    
            var idempParameter = idemp != null ?
                new ObjectParameter("idemp", idemp) :
                new ObjectParameter("idemp", typeof(string));
    
            var idcusParameter = idcus != null ?
                new ObjectParameter("idcus", idcus) :
                new ObjectParameter("idcus", typeof(string));
    
            var datebuyParameter = datebuy.HasValue ?
                new ObjectParameter("datebuy", datebuy) :
                new ObjectParameter("datebuy", typeof(System.DateTime));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(int));
    
            var idser1Parameter = idser1 != null ?
                new ObjectParameter("idser1", idser1) :
                new ObjectParameter("idser1", typeof(string));
    
            var idser2Parameter = idser2 != null ?
                new ObjectParameter("idser2", idser2) :
                new ObjectParameter("idser2", typeof(string));
    
            var idser3Parameter = idser3 != null ?
                new ObjectParameter("idser3", idser3) :
                new ObjectParameter("idser3", typeof(string));
    
            var idser4Parameter = idser4 != null ?
                new ObjectParameter("idser4", idser4) :
                new ObjectParameter("idser4", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_MuaDichVu", idconserParameter, idempParameter, idcusParameter, datebuyParameter, priceParameter, idser1Parameter, idser2Parameter, idser3Parameter, idser4Parameter);
        }
    }
}
