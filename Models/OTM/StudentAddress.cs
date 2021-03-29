using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseRelationshipTest.Models.OTM
{
    public class StudentAddress
    {
        public int AddressID { get; set; }
        public string Address { get; set; }

        public int StudentId { get; set; }
        public ICollection<Student> Student { get; set; }
    }
}
