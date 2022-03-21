using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Model
{
    public class EmployeeDetails : BaseEntity
    {
      
        public string FirstName { get; set; }
    
        public string LastName { get; set; }
        public string Education { get; set; }
        public double Experience { get; set; }
        public int AgeInYears { get; set; }
        public string Designation { get; set; }

      
    }
}
