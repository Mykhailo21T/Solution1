using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using DTO.Model;

namespace DAL.Repositories
{
    public class UsernamesRepository
    {
        public static Usernames getUsername(int id)
        {
            using(UsernamesContext context = new UsernamesContext())
            {
                return UsernamesMapper.Map(context.Usernames.Find(id));
            }
        }

        public static void AddUsername (Usernames username)
        { 
            using(UsernamesContext context = new UsernamesContext())
            {
                context.Usernames.Add(UsernamesMapper.Map(username));
                context.SaveChanges();
            }
        }

        public static List<Usernames> getUsernames(string firstLetter)
        {
            using (UsernamesContext context = new UsernamesContext())
            {
                var temp = context.Usernames.Where(e => e.Username.StartsWith(firstLetter));
                List<Usernames> list = UsernamesMapper.MapUnAll(temp.ToList());
                return list;
            }
        }

        public static List<Usernames> AllUsernames()
        {
            using (UsernamesContext context = new UsernamesContext())
            {
                var temp = context.Usernames;
                List<Usernames> list = UsernamesMapper.MapUnAll(temp.ToList());
                return list;
            }
        }

        public static List<string> getInfo(int id)
        {
            using(UsernamesContext context = new UsernamesContext())
            {
                List<string> list = new List<string>();
                string username = context.Usernames.Where(e => e.UserId == id).First().Username;
                string email = context.Emails.Where(e => e.UserId == id).FirstOrDefault().Email;
                Console.WriteLine(email);
                string address = context.Addresses.Where(e => e.UserId == id).First().Address;
                list.Add(username);
                list.Add(email);
                list.Add(address);
                return list;
            }
        }
    }
}
