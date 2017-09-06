using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Example.Models;

namespace WebAPI_Example.Controllers
{
    public class UserController : ApiController
    {
        static List<User> list = new List<User> {
        new User {Id = 1, Name= "Mary"},
        new User {Id= 2, Name="Mike" },
        new User {Id=3, Name= "John" },
        };
        public List<User> Get()
        {
            return list;
        }
        public User Get(int id)
        {
            return list[id];
        }
        public void Post([FromBody]User value)
        {
            list.Add(value);
        }
        public void Put(int id, [FromBody]User value)
        {
            list.Insert(id, value);
        }
        public void Delete(int id)
        {
            list.RemoveAt(id);
        }
    }
}
