using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseRelationshipTest.Models.OTO
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public EmployeeAddress EmployeeAddress { get; set; }
    }
}
