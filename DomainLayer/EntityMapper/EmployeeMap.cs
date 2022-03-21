using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.EntityMapper
{
  public  class EmployeeMap : IEntityTypeConfiguration<EmployeeDetails>
    {
        public void Configure(EntityTypeBuilder<EmployeeDetails> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_empId");
            builder.Property(x => x.Id).ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");

            builder.Property(x => x.FirstName).HasColumnName("First_Name").HasColumnType("VARCHAR(100)").IsRequired();
            builder.Property(x => x.LastName).HasColumnName("Last_Name").HasColumnType("VARCHAR(100)").IsRequired();
            builder.Property(x => x.AgeInYears).HasColumnName("Employee_Age").HasColumnType("INT").IsRequired();
            builder.Property(x => x.Designation).HasColumnName("Employee_Designation").HasColumnType("VARCHAR(100)").IsRequired();
            builder.Property(x => x.Education).HasColumnName("Employee_Education").HasColumnType("VARCHAR(100)").IsRequired();

            builder.Property(x => x.Experience).HasColumnName("Employee_Experience").HasColumnType("INT").IsRequired();
            builder.Property(x => x.IsDeleted).HasColumnName("IsDeleted").HasColumnType("bit");
            builder.Property(x => x.CreatedBy).HasColumnName("CreatedBy").HasColumnType("VARCHAR(250)");
            builder.Property(x => x.ModifiedBy).HasColumnName("ModifiedBy").HasColumnType("VARCHAR(250)");
            builder.Property(x => x.CreatedDate).HasColumnName("CreatedDate").HasColumnType("DateTime");
            builder.Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").HasColumnType("DateTime");


        }
    }
}
