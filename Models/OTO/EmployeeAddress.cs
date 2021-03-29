using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseRelationshipTest.Models.OTO
{
    public class EmployeeAddress
    {
        public int AddressID { get; set; }
        public string Address { get; set; }
        public Employee Employee { get; set; }
    }
}
