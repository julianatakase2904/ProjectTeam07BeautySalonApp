using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BeautySalonCodeFirstFromDB
{
    public partial class BeautySalonEntities : DbContext
    {
        public BeautySalonEntities()
            : base("name=BeautySalonConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<AppointmentsView> AppointmentsViews { get; set; }
        public virtual DbSet<ServicesView> ServicesViews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Appointment)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Appointments)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Appointments)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.ServicePrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.Appointments)
                .WithRequired(e => e.Service)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AppointmentsView>()
                .Property(e => e.ServicePrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ServicesView>();
        }
    }
}
