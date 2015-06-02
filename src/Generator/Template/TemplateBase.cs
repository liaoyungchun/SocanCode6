using System;
using System.IO;
using System.Xml;

namespace Generator
{
    public class TemplateBase : IComparable
    {
        private const string TEMPLATE_NODE_NAME = "template";
        private const string FOR_NODE_ATTR = "for";
        private const string SORT_NODE_ATTR = "sort";

        public TemplateBase(string templatePath)
        {
            this.TemplatePath = templatePath;

            string fileName = new FileInfo(templatePath).Name;
            TemplateName = fileName.Remove(fileName.LastIndexOf("."));

            this.Xml = new XmlDocument();
            Xml.Load(templatePath);
        }

        /// <summary>
        /// 模板路径
        /// </summary>
        public string TemplatePath { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板对象类型
        /// </summary>
        public string For
        {
            get
            {
                if (Root.Attributes == null || Root.Attributes[FOR_NODE_ATTR] == null)
                {
                    throw new Exception(string.Format("代码模板的根节点{0}必须含有{1}属性。", TEMPLATE_NODE_NAME, FOR_NODE_ATTR));
                }

                return Root.Attributes[FOR_NODE_ATTR].Value;
            }
        }

        /// <summary>
        /// 排序号
        /// </summary>
        public int Sort
        {
            get
            {
                if (Root.Attributes == null || Root.Attributes[SORT_NODE_ATTR] == null) { return 0; }
                return int.Parse(Root.Attributes[SORT_NODE_ATTR].Value);
            }
        }

        protected XmlDocument Xml { get; set; }

        protected XmlNode Root
        {
            get
            {
                XmlNode root = Xml.SelectSingleNode(TEMPLATE_NODE_NAME);
                if (root == null)
                {
                    throw new Exception(string.Format("代码模板的根节点必须是{0}。", TEMPLATE_NODE_NAME));
                }

                return root;
            }
        }

        public int CompareTo(object obj)
        {
            TemplateBase t = obj as TemplateBase;
            return this.Sort.CompareTo(t.Sort);
        }
    }
}
