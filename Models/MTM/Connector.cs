using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseRelationshipTest.Models.MTM
{
    public class Connector
    {
        public int StaffID { get; set; }
        public Staff Staff { get; set; }

        public int AddressID { get; set; }
        public StaffAddress Address { get; set; }
    }
}
