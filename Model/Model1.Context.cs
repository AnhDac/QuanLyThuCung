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
    
    public partial class ThuCungEntities : DbContext
    {
        public ThuCungEntities()
            : base("name=ThuCungEntities")
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
    
        public virtual ObjectResult<usp_GetContractSellTheoThangVaNam_Result> usp_GetContractSellTheoThangVaNam(Nullable<int> month, Nullable<int> year)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetContractSellTheoThangVaNam_Result>("usp_GetContractSellTheoThangVaNam", monthParameter, yearParameter);
        }
    
        public virtual ObjectResult<usp_GetContractSerTheoThangVaNam_Result> usp_GetContractSerTheoThangVaNam(Nullable<int> month, Nullable<int> year)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_GetContractSerTheoThangVaNam_Result>("usp_GetContractSerTheoThangVaNam", monthParameter, yearParameter);
        }
    
        public virtual int usp_GetProfitContractSellTheoThangVaNam(Nullable<int> month, Nullable<int> year, ObjectParameter total)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_GetProfitContractSellTheoThangVaNam", monthParameter, yearParameter, total);
        }
    
        public virtual int usp_GetSumSalaryOfEmp(ObjectParameter total)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_GetSumSalaryOfEmp", total);
        }
    
        public virtual int usp_GetTotalMoneyTransactionContractSellTheoThangVaNam(Nullable<int> month, Nullable<int> year, ObjectParameter total)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_GetTotalMoneyTransactionContractSellTheoThangVaNam", monthParameter, yearParameter, total);
        }
    
        public virtual int usp_GetTotalMoneyTransactionContractSerTheoThangVaNam(Nullable<int> month, Nullable<int> year, ObjectParameter total)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("month", month) :
                new ObjectParameter("month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_GetTotalMoneyTransactionContractSerTheoThangVaNam", monthParameter, yearParameter, total);
        }
    
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
    
        public virtual ObjectResult<view_Contract_Result> view_Contract(string iD_emp)
        {
            var iD_empParameter = iD_emp != null ?
                new ObjectParameter("ID_emp", iD_emp) :
                new ObjectParameter("ID_emp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<view_Contract_Result>("view_Contract", iD_empParameter);
        }
    
        public virtual ObjectResult<view_DetaiContracser_Result> view_DetaiContracser(string iD_Conser)
        {
            var iD_ConserParameter = iD_Conser != null ?
                new ObjectParameter("ID_Conser", iD_Conser) :
                new ObjectParameter("ID_Conser", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<view_DetaiContracser_Result>("view_DetaiContracser", iD_ConserParameter);
        }
    }
}
