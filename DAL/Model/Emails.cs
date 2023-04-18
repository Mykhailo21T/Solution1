using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    internal class Emails
    {
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }
    }
}
