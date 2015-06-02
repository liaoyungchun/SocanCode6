using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// 数据库表
    /// </summary>
    public class Table
    {
        /// <summary>
        /// 构造一个空数据库表
        /// </summary>
        public Table()
        {
            this.Fields = new List<Field>();
        }

        #region 属性
        /// <summary>
        /// 表所属的库
        /// </summary>
        public Database Database { get; set; }

        /// <summary>
        /// 表的名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 表中的所有列
        /// </summary>
        public List<Model.Field> Fields { get; set; }
        #endregion

        /// <summary>
        /// 所有主键
        /// </summary>
        public List<Model.Field> KeyFields
        {
            get
            {
                List<Model.Field> conditionRows = new List<Field>();
                foreach (Model.Field model in Fields)
                {
                    if (model.IsKeyField)
                    {
                        conditionRows.Add(model);
                    }
                }
                return conditionRows;
            }
        }

        /// <summary>
        /// 主键的个数
        /// </summary>
        public int KeyFieldsCount
        {
            get { return this.KeyFields.Count; }
        }

        /// <summary>
        /// 所有非主键
        /// </summary>
        public List<Model.Field> UnKeyFields
        {
            get
            {
                List<Model.Field> unkeyFields = new List<Field>();
                List<Model.Field> keyFields = this.KeyFields;
                foreach (Model.Field item in Fields)
                {
                    if (false == keyFields.Contains(item))
                    {
                        unkeyFields.Add(item);
                    }
                }
                return unkeyFields;
            }
        }

        /// <summary>
        /// 非主键的个数
        /// </summary>
        public int UnKeyFieldsCount
        {
            get { return this.UnKeyFields.Count; }
        }

        /// <summary>
        /// 取得条件字段（首选标识列，然后是主键）
        /// </summary>
        public List<Model.Field> CondFields
        {
            get
            {
                List<Model.Field> conditionRows = new List<Field>();

                //查看是否有标识，有标识则返回所有标识
                foreach (Model.Field model in Fields)
                {
                    if (model.IsIdentifier)
                    {
                        conditionRows.Add(model);
                    }
                }
                if (conditionRows.Count > 0) { return conditionRows; }

                //查看是否有主键，有主键则返回主键
                if (KeyFields.Count > 0) { return KeyFields; }

                //既无标识也无主键，则返回第一个列
                if (Fields.Count > 0)
                {
                    Fields[0].IsKeyField = true;
                    conditionRows.Add(Fields[0]);
                }

                return conditionRows;
            }
        }

        /// <summary>
        /// 取得条件字段的个数
        /// </summary>
        public int CondFieldsCount
        {
            get { return this.CondFields.Count; }
        }

        /// <summary>
        /// 取得非条件字段
        /// </summary>
        public List<Model.Field> UnCondFields
        {
            get
            {
                List<Model.Field> updateRows = new List<Field>();
                List<Model.Field> conditionRows = this.CondFields;
                foreach (Model.Field item in Fields)
                {
                    if (false == conditionRows.Contains(item))
                    {
                        updateRows.Add(item);
                    }
                }
                return updateRows;
            }
        }

        /// <summary>
        /// 非条件字段的个数
        /// </summary>
        public int UnCondFieldsCount
        {
            get { return this.UnCondFields.Count; }
        }

        #region 方法
        /// <summary>
        /// 添加一个字段
        /// </summary>
        public void AddField(Model.Field field)
        {
            field.Table = this;
            Fields.Add(field);
        }

        /// <summary>
        /// 转化为字符串
        /// </summary>
        /// <returns>返回表名</returns>
        public override string ToString()
        {
            return this.Name;
        }
        #endregion
    }
}
