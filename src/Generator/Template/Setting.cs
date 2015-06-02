using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Generator
{
    public class Setting
    {
        public Setting()
        {
            Options = new List<SettingOption>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public List<SettingOption> Options { get; set; }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Description))
            {
                return this.Name;
            }

            return this.Description;
        }

        public static List<Setting> GetSettings(string templateFolder)
        {
            Config.System syscfg = Config.System.Load();
            List<Setting> settings = new List<Setting>();

            string settingFilePath = templateFolder.EndsWith(@"\") ? templateFolder : templateFolder + @"\" + syscfg.SettingFile;
            if (File.Exists(settingFilePath))
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(settingFilePath);
                XmlNode root = xml.SelectSingleNode("settings");

                foreach (XmlNode settingNode in root.ChildNodes)
                {
                    if (settingNode.Name.Equals("setting", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Setting setting = new Setting();
                        setting.Name = settingNode.Attributes["name"].Value;
                        if (settingNode.Attributes["description"] != null)
                        {
                            setting.Description = settingNode.Attributes["description"].Value;
                        }

                        if (settingNode.ChildNodes.Count == 0) //不存在Option节点
                        {
                            setting.Value = settingNode.Attributes["value"].Value;
                        }
                        else
                        {
                            foreach (XmlNode optionNode in settingNode.ChildNodes)
                            {
                                string name = optionNode.Attributes["name"].Value;
                                string description = string.Empty;
                                if (optionNode.Attributes["description"] != null)
                                {
                                    description = optionNode.Attributes["description"].Value;
                                }
                                setting.Options.Add(new SettingOption() { Name = name, Description = description });
                                if (optionNode.Attributes["selected"] != null && optionNode.Attributes["selected"].Value.Equals("true", StringComparison.CurrentCultureIgnoreCase))
                                {
                                    setting.Value = name;
                                }
                            }
                        }
                        settings.Add(setting);
                    }
                }
            }

            return settings;
        }

        public static void SaveSettings(string templateFolder, List<Setting> settings)
        {
            Config.System syscfg = Config.System.Load();
            string settingFilePath = templateFolder.EndsWith(@"\") ? templateFolder : templateFolder + @"\" + syscfg.SettingFile;
            if (false == File.Exists(settingFilePath))
            {
                return; //文件不存在
            }

            XmlDocument xml = new XmlDocument();
            xml.Load(settingFilePath);
            XmlNode root = xml.SelectSingleNode("settings");
            if (root == null)
            {
                return;//根节点不是Settings
            }

            foreach (XmlNode settingNode in root.ChildNodes)
            {
                if (false == settingNode.Name.Equals("setting", StringComparison.CurrentCultureIgnoreCase))
                {
                    return; //节点名不是setting
                }

                foreach (Setting setting in settings)
                {
                    //找到对应的控件uc
                    if (setting.Name.Equals(settingNode.Attributes["name"].Value, StringComparison.CurrentCultureIgnoreCase))
                    {
                        if (setting.Options.Count == 0) //是文本框直接赋value值
                        {
                            settingNode.Attributes["value"].Value = setting.Value;
                        }
                        else //是下拉框
                        {
                            foreach (XmlNode optionNode in settingNode.ChildNodes)
                            {
                                if (optionNode.Attributes["name"].Value.Equals(setting.Value, StringComparison.CurrentCultureIgnoreCase))
                                {
                                    if (optionNode.Attributes["selected"] == null)
                                    {
                                        XmlAttribute attr = xml.CreateAttribute("selected");
                                        attr.Value = "true";
                                        optionNode.Attributes.Append(attr);
                                    }
                                    else
                                    {
                                        optionNode.Attributes["selected"].Value = "true";
                                    }
                                }
                                else
                                {
                                    if (optionNode.Attributes["selected"] != null)
                                    {
                                        optionNode.Attributes.Remove(optionNode.Attributes["selected"]);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            xml.Save(settingFilePath);
        }

        public static string GetValue(List<Setting> settings, string name)
        {
           Setting setting = settings.Find(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
           return setting == null ? null : setting.Value;
        }
    }

    public class SettingOption
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Description))
            {
                return this.Name;
            }

            return this.Description;
        }
    }
}
