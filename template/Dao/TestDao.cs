using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lomo_Template.Dao
{
    public class TestDao : BaseDao
    {
        public TestDao(string connectionString) : base(connectionString) { }

        public List<object> GetPerson()
        {
            var res = new List<object>();
            try
            {
                DBContext.OpenConnection();
                // Commented for test
                //var sqlCommand = DBContext.CreateStoredProcedureCommand("dbo.GetPeople");
                //using (var reader = sqlCommand.ExecuteReader())
                //{
                //    while (reader.Read())
                //    {
                //        // TODO: assign object properties with reader results
                //        // ej: int id = ReadInt(reader, 0)
                //    }
                //}
                DBContext.CommitTransaction();
            }
            catch (Exception e)
            {
                DBContext.RollbackTransaction();
                throw e;
            }
            finally
            {
                DBContext.CloseConnection();
            }
            return res;
        }

        public int CreateTest(object test)
        {
            int res = 0;
            try
            {
                DBContext.OpenConnection();
                // Commented for test
                //var sqlCommand = DBContext.CreateStoredProcedureCommand("dbo.CreatePerson");
                //AddStringParameter(sqlCommand, "Name", "");
                //res = (int)sqlCommand.ExecuteScalar();
            }
            catch (Exception e)
            {
                DBContext.RollbackTransaction();
                throw e;
            }
            finally
            {
                DBContext.CloseConnection();
            }
            return res;
        }

        public object GetTestById(int id)
        {
            return "Falta implementar";
        }
    }
}
