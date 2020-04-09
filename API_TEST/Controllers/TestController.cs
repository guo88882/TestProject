using API_TEST.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static API_TEST.Models.TestModel;

namespace API_TEST.Controllers
{
    public class TestController : ApiController
    {
        TestService TS = new TestService();
        [HttpGet]
        public Test TestGet([FromUri]string type)
        {
            var result = TS.TestGetService(type);
            return result;
        }
    }
}