using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AADUsersViewModel

    {
        public List<User> Users { get; set; }
    }

    public static class APISimulator
    {
        public async static Task<List<User>> SimulateAPIUsersCall()
        {
            return new List<User>
        {
            new User { Name = "Chris", Email = "chris@ggg.com", Username = "chrisjjjj"},
            new User { Name = "Wayne", Email = "wayne@jjj.com", Username = "wayne"},
            new User { Name = "Greg", Email = "greg@ggg.com", Username = "gregg"},
        };
        }
    }
}