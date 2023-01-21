using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacyyyyyyyy.Models
{
    public class PharmacyDBContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=ISMAILKHAN;Initial Catalog=PharmacyDBnew;Trusted_Connection=true;TrustServerCertificate=true");




 


     public DbSet<Medicine> Medicines { get; set; }
     public DbSet<Firm> Firms { get; set; }
     public DbSet<Category> Categories { get; set; }
     public DbSet<MedicineToFirm> MedicineToFirms { get; set; }
     public DbSet<MedicineToCategory> MedicineToCategories { get; set; }


    }
}
