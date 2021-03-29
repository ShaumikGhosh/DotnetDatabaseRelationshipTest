using DatabaseRelationshipTest.Models.MTM;
using DatabaseRelationshipTest.Models.OTM;
using DatabaseRelationshipTest.Models.OTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseRelationshipTest.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options) { }
        public DbSet<Employee> Employes { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<StaffAddress> StaffAddresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DatabaseContext.OneToOneRelation(modelBuilder);
            DatabaseContext.OneToManyRelation(modelBuilder);
            DatabaseContext.ManyToManyRelation(modelBuilder);
        }


        public static void OneToOneRelation(ModelBuilder modelBuilder)
        {
            // one to one relationship
            modelBuilder.Entity<EmployeeAddress>()
           .HasKey(s => s.AddressID);

            modelBuilder.Entity<Employee>()
                        .HasOne<EmployeeAddress>(p => p.EmployeeAddress)
                        .WithOne(s => s.Employee)
                        .HasForeignKey<EmployeeAddress>(s => s.AddressID)
                        .OnDelete(DeleteBehavior.Cascade);
        }


        public static void OneToManyRelation(ModelBuilder modelBuilder)
        {
            // one to many relationship
            modelBuilder.Entity<StudentAddress>()
           .HasKey(s => s.AddressID);
            modelBuilder.Entity<Student>()
            .HasOne<StudentAddress>(e => e.Address)
            .WithMany(d => d.Student)
            .HasForeignKey(e => e.StudentId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);
        }



        public static void ManyToManyRelation(ModelBuilder modelBuilder)
        {
            // many to many relationship
            modelBuilder.Entity<Connector>()
           .HasKey(e => new { e.StaffID, e.AddressID });

            modelBuilder.Entity<Connector>()
            .HasOne<Staff>(e => e.Staff)
            .WithMany(p => p.Connector);

            modelBuilder.Entity<Connector>()
           .HasOne<StaffAddress>(e => e.Address)
           .WithMany(p => p.Connector)
           .OnDelete(DeleteBehavior.Cascade);
        }


    }
}
