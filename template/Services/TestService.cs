using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lomo_Template.Dao;
using Lomo_Template.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Lomo_Template.Services
{
    public class TestService : BaseServices, ITestService
    {
        private readonly TestDao _dao;
        public TestService(IConfiguration config) : base(config)
        {
            _dao = new TestDao(GetConnectionString());
        }
        public List<object> GetPerson()
        {
            return _dao.GetPerson();
        }
        public int CreatePerson(object test)
        {
            return _dao.CreateTest(test);
        }
        public object GetPersonById(int id)
        {
            return _dao.GetTestById(id);
        }
    }
}
