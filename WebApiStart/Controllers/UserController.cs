using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiStart.Models;

namespace WebApiStart.Controllers
{
    public class UserController : ApiController
    {
        List<User> userList = new List<User>();
        public UserController()
        {
            userList.Add(new User { Id = 1, Name = "Pratik", City = "Mumbai" });
            userList.Add(new User { Id = 2, Name = "Prabodh", City = "Navi Mumbai" });
            userList.Add(new User { Id = 3, Name = "Shruti", City = "Aplharhetta" });
        }

        public IHttpActionResult GetUsers()
        {
            return Ok(userList);
        }

        public IHttpActionResult GetUser(int ID)
        {
            User user = userList.Find(x => x.Id == ID);
            return Ok(user);
        }
    }
}
