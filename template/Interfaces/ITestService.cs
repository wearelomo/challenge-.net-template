using System.Collections.Generic;

namespace Lomo_Template.Interfaces
{
    public interface ITestService
    {
        int CreatePerson(object test);
        List<object> GetPerson();
        object GetPersonById(int id);
    }
}