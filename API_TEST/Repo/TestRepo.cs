using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static API_TEST.Models.TestModel;

namespace API_TEST.Repo
{
    public class TestRepo : BaseRepo
    {
        public Test GetTest(string type)
        {
            var result = conn.Query<Test>("").FirstOrDefault();
            return result;
        }
    }
}