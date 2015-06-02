using System.Data;
using System.Text.RegularExpressions;

namespace Fabrics
{
    internal class MySqlSchema : ISchema
    {
        DBUtility.DBHelper dbHelper = null;

        public Model.Database GetSchema(string connectionString, Model.DatabaseTypes type)
        {
            Model.Database database = new Model.Database();
            database.ConnectionString = connectionString;
            database.Type = type;

            //得到获取MySql结构的语句
            string connStr = database.ConnectionString;
            Match mDatabase = Regex.Match(connStr, @"Database=(?<Database>[^\;]*);");
            if (mDatabase.Success)
            {

                database.Name = mDatabase.Groups["Database"].Value; //已赋数据库名
                connStr = connStr.Replace(string.Format("Database={0};", database.Name), "Database=information_schema;");
            }
            else
            {
                return null;
            }

            dbHelper = new DBUtility.DBHelper(DBUtility.DBHelper.DatabaseTypes.MySql, connStr);

            GetTables(database);
            GetViews(database);
            GetStoreProcedures(database);

            return database;
        }

        private void GetStoreProcedures(Model.Database database)
        {
            DataSet dsStoreProcedure = dbHelper.ExecuteQuery(CommandType.Text,
                string.Format("select distinct SPECIFIC_NAME from ROUTINES where ROUTINE_SCHEMA='{0}'", database.Name),
                null);
            foreach (DataRow r in dsStoreProcedure.Tables[0].Rows)
            {
                database.StoreProcedures.Add(r[0].ToString());
            }
        }

        private void GetViews(Model.Database database)
        {
            DataSet dsViews = dbHelper.ExecuteQuery(CommandType.Text,
                string.Format("select distinct TABLE_NAME from information_schema.TABLES where TABLE_SCHEMA='{0}' and TABLE_TYPE='VIEW'", database.Name),
                null);
            foreach (DataRow rView in dsViews.Tables[0].Rows)
            {
                Model.Table view = new Model.Table();
                view.Name = SchemaHelper.GetString(rView[0]);
                GetColumns(database, view);
                view.Fields.Sort();
                database.AddView(view);
            }
        }

        private void GetTables(Model.Database database)
        {
            DataSet dsTables = dbHelper.ExecuteQuery(CommandType.Text,
                string.Format("select distinct TABLE_NAME from information_schema.TABLES where TABLE_SCHEMA='{0}' and TABLE_TYPE='BASE TABLE'", database.Name),
                null);
            foreach (DataRow rTable in dsTables.Tables[0].Rows)
            {
                Model.Table table = new Model.Table();
                table.Name= SchemaHelper.GetString(rTable[0]); 
                GetColumns(database, table);
                table.Fields.Sort();
                database.AddTable(table);
            }
        }

        private void GetColumns(Model.Database db, Model.Table table)
        {
            // 对每个表取字段属性
            DataSet dsColumns = dbHelper.ExecuteQuery(CommandType.Text,
               string.Format("select * from COLUMNS where TABLE_SCHEMA='{0}' and TABLE_NAME='{1}'", db.Name, table.Name),
               null);

            foreach (DataRow rField in dsColumns.Tables[0].Rows)
            {
                Model.Field field = new Model.Field();
                field.IsIdentifier = rField["EXTRA"].ToString().ToLower() == "auto_increment";
                field.IsKeyField = rField["COLUMN_KEY"].ToString().ToLower() == "pri";
                field.AllowNull = rField["IS_NULLABLE"].ToString().ToLower() == "yes";
                field.SetDbType(Model.DatabaseTypes.MySql, SchemaHelper.GetString(rField["DATA_TYPE"]));
                field.DefaultValue = SchemaHelper.GetString(rField["COLUMN_DEFAULT"]);
                field.Descn = SchemaHelper.GetString(rField["COLUMN_COMMENT"]);
                field.Length = SchemaHelper.GetLong(rField["CHARACTER_MAXIMUM_LENGTH"]);
                field.Name = SchemaHelper.GetString(rField["COLUMN_NAME"]);
                field.Position = SchemaHelper.GetInt(rField["ORDINAL_POSITION"]);
                table.AddField(field);
            }
        }
    }
}
