using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    internal class UsernamesMapper
    {
        public static DTO.Model.Usernames Map(Usernames usernames)
        {
            return new DTO.Model.Usernames(usernames.UserId, usernames.Username);
        }

        public static Usernames Map(DTO.Model.Usernames usernames)
        {
            return new Usernames(usernames.UserId,usernames.Username); 
        }


        public static List<Usernames> MapUnAll(List<DTO.Model.Usernames> usernames)
        {
            List<Usernames> temp = new List<Usernames>();
            foreach(var user in usernames)
            {
                temp.Add(Map(user));
            }
            return temp;
        }

        internal static List<DTO.Model.Usernames> MapUnAll(List<Usernames> usernames)
        {
            List<DTO.Model.Usernames> temp = new List<DTO.Model.Usernames>();
            foreach(var u in usernames)
            {
                temp.Add(Map(u));   
            }
            return temp;
        }
    }
}
