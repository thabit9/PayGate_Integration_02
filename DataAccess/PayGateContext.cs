using PayGate_Integration_02.Models;
using PayGate_Integration_02.PayGate;
using Microsoft.EntityFrameworkCore;

namespace PayGate_Integration_02.DataAccess
{
    public class PayGateContext : DbContext
    {
        public PayGateContext()
        {            
        }
        public PayGateContext(DbContextOptions<PayGateContext> options) 
            : base(options)
        {
        } 
        public virtual DbSet<Transaction> Transactions { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            //code here...             
        }
    }
}