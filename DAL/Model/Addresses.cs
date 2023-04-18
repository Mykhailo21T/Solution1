using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    internal class Addresses
    {
        [Key]
        public int UserId { get; set; }
        public string Address { get; set; }
    }
}
