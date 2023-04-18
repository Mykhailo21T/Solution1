using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    internal class Addresses
    {
        public int UserId { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return Address;
        }
    }
}
