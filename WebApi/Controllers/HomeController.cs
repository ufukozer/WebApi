using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class Index
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
    }
    public class HomeController : Controller
    {

        public IActionResult Index([FromQuery]string username)
        {
            return new JsonResult(username);
        }
        [HttpPost]
        public IActionResult About([FromBody]Index index)
        {
            return new JsonResult(index);
        }
    }
}
