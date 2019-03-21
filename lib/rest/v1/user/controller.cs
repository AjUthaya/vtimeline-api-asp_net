using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace vtimeline
{
    public class UsersController : Controller
    {
        private readonly configModel _applicationConfig;
        private DatabaseController _databaseContext;

        public UsersController(IOptions<configModel> applicationConfig)
        {
            _applicationConfig = applicationConfig.Value;
            _databaseContext = new DatabaseController();
        }

        [HttpGet]
        [Route("api/v1/users")]
        public IActionResult GetUsers()
        {
            var db = _databaseContext.Users.ToList();
            return Ok(db);
        }
    }
}
