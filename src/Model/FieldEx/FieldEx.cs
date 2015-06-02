using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Model
{
    /// <summary>
    /// 字段扩展属性
    /// </summary>
    public class FieldEx
    {
        public FieldEx()
        {
            this.Properties = new Dictionary<string, string>();
        }

        public DbType DbType { get; set; }
        public Dictionary<string, string> Properties { get; set; }

        private static List<FieldEx> _all = null;
        public static List<FieldEx> All
        {
            get
            {
                if (_all == null)
                {
                    _all = new List<FieldEx>();
                    foreach (string xmlPath in Directory.GetFiles(Application.StartupPath + @"\\FieldEx", "*.xml"))
                    {
                        FileInfo fi = new FileInfo(xmlPath);
                        XmlDocument xml = new XmlDocument();
                        xml.Load(xmlPath);
                        XmlNode root = xml.SelectSingleNode("items");
                        foreach (XmlNode node in root.SelectNodes("item"))
                        {
                            DbType dbType = (DbType)Enum.Parse(typeof(DbType), node.Attributes["DbType"].Value.Trim(), true);
                            string value = node.Attributes["Value"].Value.Trim();

                            FieldEx type = _all.Find(x => x.DbType == dbType);
                            if (type == null)
                            {
                                type = new FieldEx();
                                _all.Add(type);
                            }

                            type.DbType = dbType;
                            type.Properties.Add(fi.Name.Remove(fi.Name.LastIndexOf(".")), value);
                        }
                    }
                }
                return _all;
            }
        }
    }
}
