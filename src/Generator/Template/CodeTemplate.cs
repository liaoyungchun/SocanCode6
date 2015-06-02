using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using Generator.Config;

namespace Generator
{
    /// <summary>
    /// 定义了代码生成引擎通用解析方法
    /// </summary>
    public abstract class CodeTemplate<TModel, TRepeaterModel> : Template
    {
        //template下的节点
        private const string ON_NODE_NAME = "on";
        private const string FOLDER_NODE_NAME = "folder";
        private const string NAME_NODE_NAME = "name";
        private const string EXT_NODE_NAME = "ext";
        private const string CODE_NODE_NAME = "code";
        private const string LINE_NODE_NAME = "line";
        private const string COUNT_ATTR_NAME = "count";

        private const string ATTACHS_NODE_NAME = "attachs";
        private const string ATTACH_NODE_NAME = "attach";
        private const string SOURCE_NODE_NAME = "source";
        private const string TARGET_NODE_NAME = "target";

        //通用属性及值
        private const string PREFIX_ATTR_NAME = "prefix";
        private const string SUFFIX_ATTR_NAME = "suffix";
        private const string TRIM_ATTR_NAME = "trim";
        private const string TRIM_START_ATTR_NAME = "trimStart";
        private const string TRIM_END_ATTR_NAME = "trimEnd";
        private const string REMOVE_START_ATTR_NAME = "removeStart";
        private const string REMOVE_END_ATTR_NAME = "removeEnd";
        private const string STYLE_ATTR_NAME = "style";

        private const string CAMEL_ATTR_VALUE = "camel";
        private const string PASCAL_ATTR_VALUE = "pascal";
        private const string UPPER_ATTR_VALUE = "upper";
        private const string LOWER_ATTR_VALUE = "lower";

        //循环节点及属性
        private const string FOREACH_NODE_NAME = "foreach";
        private const string FOR_NODE_NAME = "for";
        private const string START_ATTR_NAME = "start";
        private const string END_ATTR_NAME = "end";

        //判断节点及属性
        private const string IF_NODE_NAME = "if";
        private const string ELSE_NODE_NAME = "else";

        private const string SWITCH_NODE_NAME = "switch";
        private const string CASE_NODE_NAME = "case";
        private const string VALUE_ATTR_NAME = "value";
        private const string DEFAULT_NODE_NAME = "default";
        private const string PROPERTY_ATTR_NAME = "property";


        public TModel Entity { get; set; }
        protected List<Setting> settings { get; set; }

        /// <summary>
        /// 所有的变量
        /// </summary>
        public Dictionary<string, object> Variables { get; set; }

        public CodeTemplate(string templatePath, List<Setting> settings, TModel entity)
            : base(templatePath)
        {
            this.settings = settings;
            this.Entity = entity;

            Variables = new Dictionary<string, object>();
            foreach (Setting setting in settings)
            {
                Variables.Add("Setting." + setting.Name, setting.Value);
            }
        }

        /// <summary>
        /// 是否生成代码的开关
        /// </summary>
        public override bool On
        {
            get
            {
                XmlNode onNode = Root.SelectSingleNode(ON_NODE_NAME);
                if (onNode == null)
                {
                    return true;
                }
                else
                {
                    return GetConditionResult(onNode);
                }
            }
        }

        /// <summary>
        /// 生成文件的子文件夹
        /// </summary>
        public override string Folder
        {
            get
            {
                XmlNode folderNode = Root.SelectSingleNode(FOLDER_NODE_NAME);
                if (folderNode == null)
                    return string.Empty;
                else
                    return GenerateCodeNode(folderNode).Replace("\r", "").Replace("\n", "").Trim();
            }
        }

        /// <summary>
        /// 生成文件的文件名
        /// </summary>
        public override string Name
        {
            get
            {
                XmlNode nameNode = Root.SelectSingleNode(NAME_NODE_NAME);
                if (nameNode == null)
                    return typeof(TModel).GetProperty("Name").GetValue(Entity, null) + this.TemplateName;
                else
                    return GenerateCodeNode(nameNode).Replace("\r", "").Replace("\n", "").Trim();
            }
        }

        /// <summary>
        /// 生成文件的后缀
        /// </summary>
        public override string Ext
        {
            get
            {
                XmlNode extNode = Root.SelectSingleNode(EXT_NODE_NAME);
                if (extNode == null)
                    return "txt";
                else
                    return GenerateCodeNode(extNode).Replace("\r", "").Replace("\n", "").Trim();
            }
        }

        /// <summary>
        /// 获取生成的代码
        /// </summary>
        public override string Code
        {
            get
            {
                XmlNode codeNode = Root.SelectSingleNode(CODE_NODE_NAME);
                if (codeNode == null)
                {
                    return string.Empty;
                }
                else
                {
                    return Comment.GetCommentCode(Ext) + GenerateCodeNode(codeNode).Trim('\r', '\n');
                }
            }
        }

        /// <summary>
        /// 要附加的文件目录
        /// </summary>
        public override Dictionary<string, string> Attachs
        {
            get
            {
                Dictionary<string, string> attachs = new Dictionary<string, string>();
                XmlNode node = Root.SelectSingleNode(ATTACHS_NODE_NAME);
                if (node != null)
                {
                    foreach (XmlNode item in node.ChildNodes)
                    {
                        if (item.Name.Equals(ATTACH_NODE_NAME, StringComparison.CurrentCultureIgnoreCase))
                        {
                            string source = GenerateCodeNode(item.SelectSingleNode(SOURCE_NODE_NAME));
                            string target = string.Empty;
                            if (item.SelectSingleNode(TARGET_NODE_NAME) != null)
                            {
                                target = GenerateCodeNode(item.SelectSingleNode(TARGET_NODE_NAME));
                            }

                            attachs.Add(source, target);
                        }
                    }
                }
                return attachs;
            }
        }

        /// <summary>
        /// 生成节点代码
        /// </summary>
        internal string GenerateCommonCode(XmlNode node)
        {
            StringBuilder sb = new StringBuilder();

            if (node.NodeType == XmlNodeType.CDATA
                || node.NodeType == XmlNodeType.Text)
            {
                sb.Append(GenerateCDataAndTextNode(node));
            }
            else if (node.NodeType == XmlNodeType.Element)
            {
                #region 处理各种标签
                if (node.Name.Equals(LINE_NODE_NAME, StringComparison.CurrentCultureIgnoreCase))
                {
                    sb.Append(GenerateLineNode(node));
                }
                else if (node.Name.Equals(CODE_NODE_NAME, StringComparison.CurrentCultureIgnoreCase))
                {
                    sb.Append(GenerateCodeNode(node));
                }
                else if (node.Name.Equals(FOREACH_NODE_NAME, StringComparison.CurrentCultureIgnoreCase))
                {
                    sb.Append(GenerateForeachNode(node));
                }
                else if (node.Name.Equals(FOR_NODE_NAME, StringComparison.CurrentCultureIgnoreCase))
                {
                    sb.Append(GenerateForNode(node));
                }
                else if (node.Name.Equals(IF_NODE_NAME, StringComparison.CurrentCultureIgnoreCase))
                {
                    sb.Append(GenerateIfNode(node));
                }
                else if (node.Name.Equals(SWITCH_NODE_NAME, StringComparison.CurrentCultureIgnoreCase))
                {
                    sb.Append(GenerateSwitchNode(node));
                }
                #endregion
            }

            return sb.ToString();
        }

        /// <summary>
        /// 处理通用属性，把之前生成的代码，在此处根据Node属性做处理
        /// </summary>
        private string DisposeCommonAttribute(XmlNode node, StringBuilder sb)
        {
            foreach (XmlAttribute attr in node.Attributes)
            {
                string value = attr.Value.Replace(@"\r", "\r").Replace(@"\n", "\n").Replace(@"\t", "\t");

                if (attr.Name.Equals(PREFIX_ATTR_NAME, StringComparison.CurrentCultureIgnoreCase))
                {
                    sb.Insert(0, value);
                }

                if (attr.Name.Equals(SUFFIX_ATTR_NAME, StringComparison.CurrentCultureIgnoreCase))
                {
                    sb.Append(value);
                }

                if (attr.Name.Equals(TRIM_ATTR_NAME, StringComparison.CurrentCultureIgnoreCase))
                {
                    sb = new StringBuilder(sb.ToString().Trim(value.ToCharArray()));
                }

                if (attr.Name.Equals(TRIM_START_ATTR_NAME, StringComparison.CurrentCultureIgnoreCase))
                {
                    sb = new StringBuilder(sb.ToString().TrimStart(value.ToCharArray()));
                }

                if (attr.Name.Equals(TRIM_END_ATTR_NAME, StringComparison.CurrentCultureIgnoreCase))
                {
                    sb = new StringBuilder(sb.ToString().TrimEnd(value.ToCharArray()));
                }

                if (attr.Name.Equals(REMOVE_START_ATTR_NAME, StringComparison.CurrentCultureIgnoreCase))
                {
                    if (sb.ToString().StartsWith(value))
                        sb.Remove(0, value.Length);
                }

                if (attr.Name.Equals(REMOVE_END_ATTR_NAME, StringComparison.CurrentCultureIgnoreCase))
                {
                    if (sb.ToString().EndsWith(value))
                        sb.Remove(sb.Length - value.Length, value.Length);
                }

                if (attr.Name.Equals(STYLE_ATTR_NAME, StringComparison.CurrentCultureIgnoreCase))
                {
                    if (value.Equals(CAMEL_ATTR_VALUE, StringComparison.CurrentCultureIgnoreCase))
                    {
                        StringBuilder tmp = new StringBuilder();
                        tmp.Append(sb[0].ToString().ToLower());
                        tmp.Append(sb.Remove(0, 1));
                        sb = new StringBuilder(tmp.ToString());
                    }
                    else if (value.Equals(PASCAL_ATTR_VALUE, StringComparison.CurrentCultureIgnoreCase))
                    {
                        StringBuilder tmp = new StringBuilder();
                        tmp.Append(sb[0].ToString().ToUpper());
                        tmp.Append(sb.Remove(0, 1));
                        sb = new StringBuilder(tmp.ToString());
                    }
                    else if (value.Equals(UPPER_ATTR_VALUE, StringComparison.CurrentCultureIgnoreCase))
                    {
                        sb = new StringBuilder(sb.ToString().ToUpper());
                    }
                    else if (value.Equals(LOWER_ATTR_VALUE, StringComparison.CurrentCultureIgnoreCase))
                    {
                        sb = new StringBuilder(sb.ToString().ToLower());
                    }
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 替换字符串
        /// </summary>
        protected string ReplaceSource(string source)
        {
            foreach (KeyValuePair<string, object> item in Variables)
            {
                string pattern = string.Format(@"\${0}\$", item.Key);
                string target = item.Value == null ? string.Empty : item.Value.ToString();
                source = Regex.Replace(source, pattern, target, RegexOptions.IgnoreCase);
            }
            return source;
        }

        /// <summary>
        /// 获取一个实体属性的值
        /// </summary>
        /// <param name="model">实体</param>
        /// <param name="property">属性名</param>
        /// <returns></returns>
        protected object GetVariableValue(string property)
        {
            return DictionaryHelper.GetValue(Variables, property);
        }

        /// <summary>
        /// 检查实例中是否存在指定的属性及其值对应的字符串（不区分大小写）
        /// </summary>
        /// <param name="model">实体的实例</param>
        /// <param name="property">属性名</param>
        /// <param name="value">属性值</param>
        /// <returns>是否存在</returns>
        protected bool CheckVariableValue(string property, string value)
        {
            return DictionaryHelper.CheckValue(Variables, property, value);
        }

        #region 通用的节点类型实现
        /// <summary>
        /// 生成code标签代码
        /// </summary>
        private string GenerateCodeNode(XmlNode node)
        {
            StringBuilder sb = new StringBuilder();

            foreach (XmlNode child in node)
            {
                sb.Append(GenerateCommonCode(child));
            }

            return DisposeCommonAttribute(node, sb);
        }

        /// <summary>
        /// 生成line标签代码
        /// </summary>
        protected string GenerateLineNode(XmlNode node)
        {
            StringBuilder sb = new StringBuilder();

            if (node.Attributes == null || node.Attributes[COUNT_ATTR_NAME] == null)
            {
                sb.Append("\r\n");
            }
            else
            {
                int count = int.Parse(node.Attributes[COUNT_ATTR_NAME].Value);
                for (int i = 0; i < count; i++)
                {
                    sb.Append("\r\n");
                }
            }

            return DisposeCommonAttribute(node, sb);
        }

        /// <summary>
        /// 生成cdata及文本节点的代码
        /// </summary>
        protected string GenerateCDataAndTextNode(XmlNode node)
        {
            return ReplaceSource(node.InnerText);
        }

        /// <summary>
        /// 生成Switch标签代码
        /// </summary>
        private string GenerateSwitchNode(XmlNode node)
        {
            if (node.Attributes == null || node.Attributes[PROPERTY_ATTR_NAME] == null)
            {
                throw new Exception(string.Format("{0}节点必须包含{1}属性。", node.Name, PROPERTY_ATTR_NAME));
            }

            StringBuilder sb = new StringBuilder();

            object realValue = GetVariableValue(node.Attributes[PROPERTY_ATTR_NAME].Value);
            string strRealValue = realValue == null ? string.Empty : realValue.ToString();
            foreach (XmlNode caseNode in node.ChildNodes)
            {
                if (caseNode.Name.Equals(CASE_NODE_NAME, StringComparison.CurrentCultureIgnoreCase))
                {
                    if (caseNode.Attributes[VALUE_ATTR_NAME].Value.Equals(strRealValue, StringComparison.CurrentCultureIgnoreCase))
                    {
                        foreach (XmlNode item in caseNode.ChildNodes)
                        {
                            sb.Append(GenerateCommonCode(item));
                        }
                        break;
                    }
                }
                if (caseNode.Name.Equals(DEFAULT_NODE_NAME, StringComparison.CurrentCultureIgnoreCase))
                {
                    foreach (XmlNode item in caseNode.ChildNodes)
                    {
                        sb.Append(GenerateCommonCode(item));
                    }
                    break;
                }
            }

            return DisposeCommonAttribute(node, sb);
        }

        /// <summary>
        /// 生成if标签代码
        /// </summary>
        protected string GenerateIfNode(XmlNode node)
        {
            bool conditionResult = GetConditionResult(node);

            StringBuilder sb = new StringBuilder();

            if (conditionResult) //条件成立时，开始生成代码
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    if (child.NodeType != XmlNodeType.Element
                        || !child.Name.Equals(ELSE_NODE_NAME, StringComparison.CurrentCultureIgnoreCase))
                    {
                        sb.Append(GenerateCommonCode(child));
                    }
                }
            }
            else //条件不成立时，生成else节点下的内容
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    if (child.NodeType == XmlNodeType.Element
                        && child.Name.Equals(ELSE_NODE_NAME, StringComparison.CurrentCultureIgnoreCase))
                    {
                        foreach (XmlNode elseChild in child.ChildNodes)
                        {
                            sb.Append(GenerateCommonCode(elseChild));
                        }
                    }
                }
            }

            return DisposeCommonAttribute(node, sb);
        }

        /// <summary>
        /// 判断Node上的条件属性是否成立
        /// </summary>
        protected bool GetConditionResult(XmlNode node)
        {
            if (node.Attributes == null)
                return true;

            bool conditionValue = true;
            foreach (XmlAttribute attr in node.Attributes)
            {
                if (false == CheckVariableValue(attr.Name, attr.Value))
                {
                    conditionValue = false;
                    break;
                }
            }
            return conditionValue;
        }

        /// <summary>
        /// 生成for标签代码
        /// </summary>
        protected string GenerateForNode(XmlNode node)
        {
            #region 获取要循环的对象及起始位置和结束位置
            if (node.Attributes == null || node.Attributes[PROPERTY_ATTR_NAME] == null)
            {
                throw new Exception(string.Format("{0}节点必须包含{1}属性。", node.Name, PROPERTY_ATTR_NAME));
            }

            string property = node.Attributes[PROPERTY_ATTR_NAME].Value; //属性名
            object value = GetVariableValue(property); //属性值
            if (value == null)
            {
                throw new Exception(string.Format("{0}节点的{1}属性{2}不存在。", node.Name, PROPERTY_ATTR_NAME, property));
            }

            List<TRepeaterModel> fields = value as List<TRepeaterModel>;
            if (fields == null)
            {
                throw new Exception(string.Format("{0}节点的{1}属性必须是List<{2}>类型，且不能为null值。", node.Name, PROPERTY_ATTR_NAME, typeof(TRepeaterModel).Name));
            }

            int start = 0;
            int end = fields.Count - 1;
            if (node.Attributes[START_ATTR_NAME] != null)
            {
                start = int.Parse(node.Attributes[START_ATTR_NAME].Value);
            }
            if (node.Attributes[END_ATTR_NAME] != null)
            {
                end = int.Parse(node.Attributes[END_ATTR_NAME].Value);
            }
            #endregion

            #region 生成代码
            StringBuilder sb = new StringBuilder();

            if (start <= end && end < fields.Count)
            {
                for (int i = start; i <= end; i++)
                {
                    TRepeaterModel field = fields[i];
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        sb.Append(GenerateRepeaterNode(field, child));
                    }
                }
            }

            return DisposeCommonAttribute(node, sb);
            #endregion
        }

        /// <summary>
        /// 生成foreach标签代码
        /// </summary>
        protected string GenerateForeachNode(XmlNode node)
        {
            #region 获取要循环的对象
            if (node.Attributes == null || node.Attributes[PROPERTY_ATTR_NAME] == null)
            {
                throw new Exception(string.Format("{0}节点必须包含{1}属性。", node.Name, PROPERTY_ATTR_NAME));
            }

            string property = node.Attributes[PROPERTY_ATTR_NAME].Value; //属性名
            object value = GetVariableValue(property); //属性值
            if (value == null)
            {
                throw new Exception(string.Format("{0}节点的{1}属性{2}不存在。", node.Name, PROPERTY_ATTR_NAME, property));
            }

            List<TRepeaterModel> repeats = value as List<TRepeaterModel>;
            if (repeats == null)
            {
                throw new Exception(string.Format("{0}节点的{1}属性必须是List<{2}>类型，且不能为null值。", node.Name, PROPERTY_ATTR_NAME, typeof(TRepeaterModel).Name));
            }
            #endregion

            #region 生成代码
            StringBuilder sb = new StringBuilder();

            foreach (TRepeaterModel r in repeats)
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    sb.Append(GenerateRepeaterNode(r, child));
                }
            }

            return DisposeCommonAttribute(node, sb);
            #endregion
        }
        #endregion

        #region 抽象方法，由子类去实现
        /// <summary>
        /// 生成循环的子节点代码
        /// </summary>
        protected abstract string GenerateRepeaterNode(TRepeaterModel model, XmlNode node);
        #endregion
    }
}
