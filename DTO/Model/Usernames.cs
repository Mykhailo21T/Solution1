using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class Usernames
    {
        public Usernames(int userId, string username)
        {
            UserId = userId;
            Username = username;
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public override string ToString()
        {
            return Username;
        }
    }
}
