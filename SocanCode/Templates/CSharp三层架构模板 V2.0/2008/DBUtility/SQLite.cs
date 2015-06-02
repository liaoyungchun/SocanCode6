using System.Data.Common;
using System.Data.SQLite;

namespace DBUtility
{
    public class SQLite : DbHelper
    {
        public override DbConnection CreateConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }

        public override DbCommand CreateCommand()
        {
            return new SQLiteCommand();
        }

        public override DbDataAdapter CreateDataAdapter()
        {
            return new SQLiteDataAdapter();
        }

        public override DbParameter CreateDbParameter(string parameterName)
        {
            DbParameter parameter = new SQLiteParameter();
            parameter.ParameterName = parameterName.Replace("?", "@").Replace(":", "@");
            return parameter;
        }
    }
}
