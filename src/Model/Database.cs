using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// 数据库类型
    /// </summary>
    public enum DatabaseTypes
    {
        Access,
        Sql2000,
        Sql2005,
        MySql,
        Oracle,
        SQLite
    }

    /// <summary>
    /// 数据库
    /// </summary>
    public class Database
    {
        public string TypeDescription
        {
            get
            {
                switch (Type)
                {
                    case DatabaseTypes.Sql2005:
                        return "Sql2005或更高版本";
                    default:
                        return Type.ToString();
                }
            }
        }

        /// <summary>
        /// 构造一个空数据库
        /// </summary>
        public Database()
        {
            Tables = new List<Table>();
            Views = new List<Table>();
            StoreProcedures = new List<string>();
            SelectedTables = new List<Table>();
        }

        #region 属性
        /// <summary>
        /// 数据库连接参数
        /// </summary>
        public string ConnectionString { get; set; }

        private string name = null;

        /// <summary>
        /// 数据库名
        /// </summary>
        public string Name
        {
            get
            {
                if (name != null)
                {
                    return name;
                }
                else
                {
                    switch (Type)
                    {
                        case DatabaseTypes.Access:
                            using (OleDbConnection conn = new OleDbConnection(ConnectionString))
                            {
                                try
                                {
                                    FileInfo file = new FileInfo(conn.DataSource);
                                    return file.Name.Remove(file.Name.LastIndexOf("."));
                                }
                                catch (Exception)
                                {
                                    return conn.DataSource;
                                }
                            }
                        case DatabaseTypes.Sql2000:
                        case DatabaseTypes.Sql2005:
                            using (SqlConnection conn = new SqlConnection(ConnectionString))
                            {
                                try
                                {
                                    FileInfo file = new FileInfo(conn.Database);
                                    int start = file.Name.LastIndexOf(".");
                                    if (start > 0)
                                        return file.Name.Remove(start);

                                    return conn.Database;
                                }
                                catch (Exception)
                                {
                                    return conn.Database;
                                }
                            }
                        case DatabaseTypes.MySql:
                            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
                            {
                                try
                                {
                                    return conn.Database;
                                }
                                catch (Exception)
                                {
                                    return "MySqlDB";
                                }
                            }
                        case DatabaseTypes.Oracle:
                            using (OracleConnection conn = new OracleConnection(ConnectionString))
                            {
                                try
                                {
                                    return conn.DataSource;
                                }
                                catch (Exception)
                                {
                                    return "OracleDB";
                                }
                            }
                        case DatabaseTypes.SQLite:
                            using (System.Data.SQLite.SQLiteConnection conn = new System.Data.SQLite.SQLiteConnection(ConnectionString))
                            {
                                try
                                {
                                    Regex r = new Regex("Data Source=(?<source>[^;]+);");
                                    Match m = r.Match(conn.ConnectionString);
                                    if (m.Success)
                                    {
                                        string path = m.Groups["source"].Value;
                                        FileInfo fi = new FileInfo(path);
                                        return fi.Name.Substring(0, fi.Name.LastIndexOf('.'));
                                    }
                                    else
                                    {
                                        return "SQLiteDB";
                                    }
                                }
                                catch (Exception)
                                {
                                    return "SQLiteDB";
                                }
                            }
                        default:
                            return "UnKnownDB";
                    }
                }
            }
            set { name = value; }
        }

        /// <summary>
        /// 数据库类型
        /// </summary>
        public DatabaseTypes Type { get; set; }

        /// <summary>
        /// 所有表
        /// </summary>
        public List<Model.Table> Tables { get; set; }

        /// <summary>
        /// 所有视图名
        /// </summary>
        public List<Model.Table> Views { get; set; }

        /// <summary>
        /// 所有存储过程名
        /// </summary>
        public List<string> StoreProcedures { get; set; }

        /// <summary>
        /// 选中的表或视图
        /// </summary>
        public List<Model.Table> SelectedTables { get; set; }
        #endregion

        #region 方法
        /// <summary>
        /// 添加一个表
        /// </summary>
        public void AddTable(Model.Table table)
        {
            table.Database = this;
            Tables.Add(table);
        }

        /// <summary>
        /// 添加一个视图
        /// </summary>
        public void AddView(Model.Table view)
        {
            view.Database = this;
            Views.Add(view);
        }

        /// <summary>
        /// 转化为字符串
        /// </summary>
        /// <returns>返回表名</returns>
        public override string ToString()
        {
            return Name;
        }
        #endregion
    }
}
