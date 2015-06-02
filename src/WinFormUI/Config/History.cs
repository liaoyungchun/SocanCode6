using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace SocanCode.Config
{
    /// <summary>
    /// 系统配置
    /// </summary>
    public class History
    {
        public History()
        {
            this.DatabaseType = Model.DatabaseTypes.Sql2000;
            this.SqlServerConn = "Data Source=127.0.0.1;User ID=sa;Password=;Initial Catalog=;";
        }

        public Model.DatabaseTypes DatabaseType { get; set; }
        public string AccessConn { get; set; }
        public string SqlServerConn { get; set; }
        public string MySqlConn { get; set; }
        public string OracleConn { get; set; }
        public string SQLiteConn { get; set; }

        private static string xmlPath = Application.StartupPath + @"\Config\History.xml";

        public static History Load()
        {
            History sys = new History();
            XmlDocument xml = new XmlDocument();

            if (File.Exists(xmlPath))
            {
                try
                {
                    xml.Load(xmlPath);
                    XmlNode root = xml.SelectSingleNode("Config");

                    foreach (PropertyInfo item in sys.GetType().GetProperties())
                    {
                        string v = root.SelectSingleNode(item.Name).Attributes["value"].Value;
                        if (item.PropertyType.IsEnum)
                        {
                            item.SetValue(sys, Enum.Parse(item.PropertyType, v), null);
                        }
                        else
                        {
                            item.SetValue(sys, v, null);
                        }
                    }
                }
                catch (Exception)
                {
                    Save(sys);
                }
            }
            else
            {
                Save(sys);
            }

            return sys;
        }

        public static void Save(History sys)
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                XmlNode root = xml.CreateElement("Config");
                xml.AppendChild(root);

                foreach (PropertyInfo item in typeof(History).GetProperties())
                {
                    XmlNode node = xml.CreateElement(item.Name);
                    XmlAttribute attr = xml.CreateAttribute("value");
                    attr.Value = (item.GetValue(sys, null) ?? string.Empty).ToString();
                    node.Attributes.Append(attr);
                    root.AppendChild(node);
                }

                xml.Save(xmlPath);
            }
            catch (Exception)
            {
                //保存失败不处理
            }
        }
    }
}
