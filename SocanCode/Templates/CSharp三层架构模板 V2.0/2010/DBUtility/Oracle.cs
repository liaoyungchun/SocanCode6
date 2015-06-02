using System.Data.Common;
using Oracle.DataAccess.Client;

namespace DBUtility
{
    public class Oracle : DbHelper
    {
        public override DbConnection CreateConnection()
        {
            return new OracleConnection(ConnectionString);
        }

        public override DbCommand CreateCommand()
        {
            return new OracleCommand();
        }

        public override DbDataAdapter CreateDataAdapter()
        {
            return new OracleDataAdapter();
        }

        public override DbParameter CreateDbParameter(string parameterName)
        {
            DbParameter parameter = new OracleParameter();
            parameter.ParameterName = parameterName.Replace("@", ":").Replace("?", ":");
            return parameter;
        }
    }
}
