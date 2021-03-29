using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseRelationshipTest.Models.OTM
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public StudentAddress Address { get; set; }
    }
}
