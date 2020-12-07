using Microsoft.EntityFrameworkCore;

namespace CashflowApi.Models
{
    public class LoanContext : DbContext
    {
        public LoanContext(DbContextOptions<LoanContext> options)
            : base(options)
        {
        }

        public DbSet<LoanItem> LoanItems { get; set; }
    }
}