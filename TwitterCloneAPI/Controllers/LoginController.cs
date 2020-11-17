using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterCloneAPI.Models;
using Microsoft.AspNetCore.Mvc;
using TwitterCloneAPI.Misc;

namespace TwitterCloneAPI.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {

        // POST api/values
        [HttpPost]
        public clientUser Post([FromBody]clientLoginModel value)
        {
            LoginCheck checkLogin = new LoginCheck();
            return checkLogin.Check(value);
        }

    }
}
