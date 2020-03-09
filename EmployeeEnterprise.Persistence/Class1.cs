using Microsoft.EntityFrameworkCore;
using Microsoft.AspNet.Identity.EntityFramework;
using EmployeeEnterprise.Entity;

namespace EmployeeEnterprise.Persistence
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<PaymentRecord> PaymentRecords { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TaxYear> TaxYears { get; set; }
    }
}
