using API_TEST.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static API_TEST.Models.TestModel;

namespace API_TEST.Service
{
    public class TestService : BaseRepo
    {
        TestRepo TR = new TestRepo();
        public Test TestGetService(string type)
        {
            //開連線
            open();

            //邏輯處理
            type = "AA";
            //邏輯處理

            //呼叫SQL
            var result = TR.GetTest(type);

            //關閉連線
            close();
            return result;
        }
    }
}