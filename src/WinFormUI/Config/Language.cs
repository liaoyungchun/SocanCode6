using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace SocanCode.Config
{
    public class Language
    {
        public Language()
        {
            Exts = new List<string>();
        }

        public string Name { get; set; }
        public List<string> Exts { get; set; }

        private static List<Language> _all = null;
        public static List<Language> All
        {
            get
            {
                if (_all == null)
                {
                    _all = new List<Language>();
                    XmlDocument xml = new XmlDocument();
                    xml.Load(Application.StartupPath + @"\Config\Language.xml");
                    XmlNode root = xml.SelectSingleNode("Languages");
                    foreach (XmlNode child in root.ChildNodes)
                    {
                        Language language = new Language();
                        language.Name = child.Attributes["Name"].Value.Trim();
                        foreach (string ext in child.Attributes["Ext"].Value.Split(','))
                        {
                            language.Exts.Add(ext.Trim());
                        }
                        _all.Add(language);
                    }
                }

                return _all;
            }
        }

        public static Language GetLanguageByExt(string ext)
        {
            List<Language> langs = Language.All.FindAll(m => m.Exts.Contains(ext));
            if (langs.Count > 0)
                return langs[0];

            return null;
        }
    }
}
