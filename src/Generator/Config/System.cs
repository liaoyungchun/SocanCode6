using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace Generator.Config
{
    /// <summary>
    /// 系统配置
    /// </summary>
    public class System
    {
        public System()
        {
            this.DatabaseVariablePrefix = "Database.";
            this.TableVariablePrefix = "Table.";
            this.FieldVariablePrefix = "Field.";
            this.TemplateFolder = "templates";
            this.SettingFile = "TemplateSettings.xml";
        }

        public string DatabaseVariablePrefix { get; set; }
        public string TableVariablePrefix { get; set; }
        public string FieldVariablePrefix { get; set; }
        public string TemplateFolder { get; set; }
        public string SettingFile { get; set; }

        private static string xmlPath = Application.StartupPath + @"\Config\System.xml";

        public static System Load()
        {
            System sys = new System();
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

        public static void Save(System sys)
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                XmlNode root = xml.CreateElement("Config");
                xml.AppendChild(root);

                foreach (PropertyInfo item in typeof(System).GetProperties())
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
