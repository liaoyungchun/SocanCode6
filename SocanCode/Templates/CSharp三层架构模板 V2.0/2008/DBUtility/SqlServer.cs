using System.Data.Common;
using System.Data.SqlClient;

namespace DBUtility
{
    public class SqlServer : DbHelper
    {
        public override DbConnection CreateConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public override DbCommand CreateCommand()
        {
            return new SqlCommand();
        }

        public override DbDataAdapter CreateDataAdapter()
        {
            return new SqlDataAdapter();
        }

        public override DbParameter CreateDbParameter(string parameterName)
        {
            DbParameter parameter = new SqlParameter();
            parameter.ParameterName = parameterName.Replace("?", "@").Replace(":", "@");
            return parameter;
        }
    }
}
