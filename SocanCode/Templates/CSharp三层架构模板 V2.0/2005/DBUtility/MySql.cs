using System.Data.Common;
using MySql.Data.MySqlClient;

namespace DBUtility
{
    public class MySql : DbHelper
    {
        public override DbConnection CreateConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public override DbCommand CreateCommand()
        {
            return new MySqlCommand();
        }

        public override DbDataAdapter CreateDataAdapter()
        {
            return new MySqlDataAdapter();
        }

        public override DbParameter CreateDbParameter(string parameterName)
        {
            DbParameter parameter = new MySqlParameter();
            parameter.ParameterName = parameterName.Replace("@", "?").Replace(":", "?");
            return parameter;
        }
    }
}
