﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoDealer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AutoDealerEntities1 : DbContext
    {
        private static AutoDealerEntities1 _context;
        public AutoDealerEntities1()
            : base("name=AutoDealerEntities1")
        {
        }

        public static AutoDealerEntities1 GetContext()
        {
            if (_context == null) _context = new AutoDealerEntities1();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AddService> AddService { get; set; }
        public virtual DbSet<BlackList> BlackList { get; set; }
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<DriverLicense> DriverLicense { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<LogUser> LogUser { get; set; }
        public virtual DbSet<Passport> Passport { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tariff> Tariff { get; set; }
    }
}
