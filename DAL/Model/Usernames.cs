using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    internal class Usernames
    {
        public Usernames() { }
        public Usernames(string username)
        {
            Username = username;
        }

        public Usernames(int userId, string username)
        {
            UserId = userId;
            Username = username;
        }
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
    }
}
