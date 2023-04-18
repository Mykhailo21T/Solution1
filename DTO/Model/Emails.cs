using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    internal class Emails
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return Email;
        }
    }
}
