using System.Data.Common;
using System.Data.OleDb;

namespace DBUtility
{
    public class OleDb : DbHelper
    {
        public override DbConnection CreateConnection()
        {
            return new OleDbConnection(ConnectionString);
        }

        public override DbCommand CreateCommand()
        {
            return new OleDbCommand();
        }

        public override DbDataAdapter CreateDataAdapter()
        {
            return new OleDbDataAdapter();
        }

        public override DbParameter CreateDbParameter(string parameterName)
        {
            DbParameter parameter = new OleDbParameter();
            parameter.ParameterName = parameterName.Replace("?", "@").Replace(":", "@");
            return parameter;
        }
    }
}
