using DAL.Repositories;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL_.BLL
{
    public class UsernamesBLL
    {
        public Usernames getUsername(int id)
        {
            if(id <= 0) throw new IndexOutOfRangeException();
            return UsernamesRepository.getUsername(id);
        }

        public List<Usernames> getUsernames(string a)
        {
            var temp = UsernamesRepository.getUsernames(a);
            return temp;
        }

        public List<Usernames> AllUsernames()
        {
            var temp = UsernamesRepository.AllUsernames();
            return temp;
        }

        public List<string> getInfo(string id)
        {
            var temp = UsernamesRepository.getInfo(Int32.Parse(id));
            return temp;
        }
    }
}
