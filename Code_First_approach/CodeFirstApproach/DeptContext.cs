using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproach
{
    public class DeptContext : DbContext
    {
        public DbSet<Dept> departments { set; get; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dept>().Property(u => u.Name).HasColumnName("DeptName");
        }
    }
    
}
