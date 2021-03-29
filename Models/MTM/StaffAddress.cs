using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseRelationshipTest.Models.MTM
{
    public class StaffAddress
    {
        [Key]
        public int AddressID { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Connector> Connector { get; set; }
    }
}
