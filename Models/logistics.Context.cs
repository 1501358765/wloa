﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LogisticsEntities : DbContext
    {
        public LogisticsEntities()
            : base("name=LogisticsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActionInfo> ActionInfo { get; set; }
        public virtual DbSet<Bill> Bill { get; set; }
        public virtual DbSet<BillTypes> BillTypes { get; set; }
        public virtual DbSet<Bonus> Bonus { get; set; }
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Compensation> Compensation { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<HaulWay> HaulWay { get; set; }
        public virtual DbSet<MenuInfo> MenuInfo { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<PassByCity> PassByCity { get; set; }
        public virtual DbSet<Penalty> Penalty { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Salay> Salay { get; set; }
        public virtual DbSet<SizeCharge> SizeCharge { get; set; }
        public virtual DbSet<Station> Station { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<WeightCharge> WeightCharge { get; set; }
    }
}
