using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace vtimeline
{
    public class BaseController : Controller
    {
        // DEFINE: Variable
        private readonly configModel _applicationConfig;

        // CONSTRUCTOR
        public BaseController(IOptions<configModel> applicationConfig)
        {
            // 1. DEFINE: Global variable
            _applicationConfig = applicationConfig.Value;
        }

        /**
         * @Author  AJ
         * @Version 1.0
         * @Since   2019-03-16
         * @Description Overview of all versions and endpoints
         * @Route /api
         *
         * @Method GET
         */
        [HttpGet]
        [Route("api")]
        public IActionResult GetBase()
        {
            List<BaseModel> _data = new List<BaseModel>();
            _data.Add(new BaseModel()
            {
                Id = 1,
                SSN = 2,
                Message = "A Message"
            });

            return Ok(_data);
        }

        /**
        * @Author AJ
        * @Version 1.0
        * @Since 2019-03-16
        * @Description Endpoint to check if the api is up and running
        *
        * @Route /api
        *
        */
        [HttpGet]
        [Route("api/ping")]
        public IActionResult GetPing()
        {
            var env = _applicationConfig;
            return Ok();
        }

        [HttpGet]
        [Route("api/Environment")]
        public IActionResult GetEnvironment()
        {
            var Environment = _applicationConfig.Environment;
            return Ok(Environment);
        }
    }
}
