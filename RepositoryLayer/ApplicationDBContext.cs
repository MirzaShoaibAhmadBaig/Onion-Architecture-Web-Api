using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Model;
using DomainLayer.EntityMapper;

namespace RepositoryLayer
{
   public class ApplicationDBContext : DbContext
    {


        public ApplicationDBContext(DbContextOptions options) : base(options) { 

        } 


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EmployeeMap());

            base.OnModelCreating(builder);
        }
    }
}
