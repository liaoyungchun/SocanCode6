using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// 字段
    /// </summary>
    public class Field : IComparable
    {
        private string _descn;

        /// <summary>
        /// 所属的数据库表
        /// </summary>
        public Model.Table Table { get; set; }

        /// <summary>
        /// 字段序列
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// 字段名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否是标识
        /// </summary>
        public bool IsIdentifier { get; set; }

        /// <summary>
        /// 是否是主键
        /// </summary>
        public bool IsKeyField { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        public DbType DbType { get; set; }

        /// <summary>
        /// 占用字节数
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// 长度
        /// </summary>
        public long Length { get; set; }

        /// <summary>
        /// 是否允许空
        /// </summary>
        public bool AllowNull { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// 字段说明
        /// </summary>
        public string Descn
        {
            get
            {
                if (!string.IsNullOrEmpty(_descn))
                {
                    return _descn;
                }
                else
                {
                    return Name;
                }
            }
            set
            {
                _descn = Regex.Replace(value, @"\s*[\n]+\s*", ""); //过滤掉换行，及换行前后的空格
            }
        }

        /// <summary>
        /// 字段在所属数据库中的类型。在各种库中不相同。不需要为此属性直接赋值，要调用SetDbType方法来赋
        /// </summary>
        public string FieldType { get; private set; }

        /// <summary>
        /// 为字段赋DbType类型
        /// </summary>
        public void SetDbType(DatabaseTypes dbType, string fieldType)
        {
            this.FieldType = fieldType;
            string key;
            switch (dbType)
            {
                case DatabaseTypes.Access:
                    key = "OleDbType";
                    break;
                case DatabaseTypes.MySql:
                    key = "MySqlType";
                    break;
                case   DatabaseTypes.Oracle:
                    key = "OracleType";
                    break;
                case DatabaseTypes.SQLite:
                    key = "SQLiteType";
                    break;
                case DatabaseTypes.Sql2000:
                case DatabaseTypes.Sql2005:
                default:
                    key = "SqlType";
                    break;
            }

            FieldEx dataType = Model.FieldEx.All.Find(x =>
            {
                string[] sqlTypes = x.Properties[key].Split(',');
                foreach (string item in sqlTypes)
                {
                    if (item.Trim().Equals(fieldType.Trim(), StringComparison.CurrentCultureIgnoreCase))
                        return true;
                }
                return false;
            });

            if (dataType != null)
            {
                this.DbType = dataType.DbType;
            }
            else
            {
                this.DbType = Model.FieldEx.All.Find(x => x.Properties[key].Trim().Equals("*")).DbType;
            }
        }

        /// <summary>
        /// 所有类型
        /// </summary>
        public Dictionary<string, string> FieldEx
        {
            get
            {
                return Model.FieldEx.All.Find(x => x.DbType == this.DbType).Properties;
            }
        }

        #region 以下2个属性为兼容V6.0的模板而保留，如不需要兼容可直接删除
        /// <summary>
        /// SqlServer中的数据类型，已过时
        /// </summary>
        public string SqlTypeString
        {
            get { return FieldType; }
        }

        /// <summary>
        /// MySql中的数据类型，已过时
        /// </summary>
        public string MySqlTypeString
        {
            get { return FieldType; }
        }
        #endregion

        #region IComparable 成员

        public int CompareTo(object obj)
        {
            Field field = obj as Field;
            return this.Position.CompareTo(field.Position);
        }

        #endregion
    }
}
