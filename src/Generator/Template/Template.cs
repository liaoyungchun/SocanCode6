using System;
using System.Collections.Generic;
using System.IO;

namespace Generator
{
    public delegate void ProcessChanged(int processValue);

    /// <summary>
    /// 代码生成引擎的基类
    /// </summary>
    public abstract class Template : TemplateBase
    {
        public Template(string templatePath) : base(templatePath) { }

        /// <summary>
        /// 是否生成代码的开关
        /// </summary>
        public abstract bool On { get; }

        /// <summary>
        /// 生成文件的子文件夹
        /// </summary>
        public abstract string Folder { get; }

        /// <summary>
        /// 生成文件的文件名
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// 生成文件的后缀
        /// </summary>
        public abstract string Ext { get; }

        /// <summary>
        /// 获取生成的代码
        /// </summary>
        public abstract string Code { get; }

        /// <summary>
        /// 要附加的文件
        /// </summary>
        public abstract Dictionary<string, string> Attachs { get; }

        /// <summary>
        /// 附加文件目录
        /// </summary>
        public void AttachFiles(string basePath)
        {
            foreach (KeyValuePair<string, string> item in Attachs)
            {
                string source = TemplatePath.Remove(TemplatePath.LastIndexOf(@"\")) + @"\" + item.Key;
                string target = basePath.EndsWith(@"\") ? basePath : (basePath + @"\") + item.Value;
                IOHelper.CopyDir(source, target);
            }
        }

        /// <summary>
        /// 生成文件到文件夹（会根据模板来决定是否有子文件夹）
        /// </summary>
        /// <param name="basePath">文件基础路径</param>
        public void GenerateFile(string basePath)
        {
            string path = basePath;
            if (false == basePath.EndsWith(@"\"))
                path += @"\";

            path = path + Folder + (Folder.EndsWith(@"\") ? "" : @"\") + Name + "." + Ext; ;
            IOHelper.WriteFile(path, Code);
        }

        public static List<Template> CreateTemplates(string templateFolder, Model.Database database, List<Setting> settings)
        {
            Config.System syscfg = Config.System.Load();
            List<string> xmlFiles = new List<string>();
            foreach (string item in Directory.GetFiles(templateFolder, "*.xml"))
            {
                if (false == item.EndsWith(syscfg.SettingFile, StringComparison.CurrentCultureIgnoreCase))
                {
                    xmlFiles.Add(item);
                }
            }

            List<Template> templates = new List<Template>();
            foreach (string xmlFile in xmlFiles)
            {
                string forAttr = new TemplateBase(xmlFile).For;

                if (forAttr.Equals(typeof(Model.Database).Name, StringComparison.CurrentCultureIgnoreCase))
                {
                    Template generator = new DatabaseTemplate(xmlFile, settings, database);
                    if (generator.On)
                    {
                        templates.Add(generator);
                    }
                }
                else if (forAttr.Equals(typeof(Model.Table).Name, StringComparison.CurrentCultureIgnoreCase))
                {
                    foreach (Model.Table item in database.SelectedTables)
                    {
                        Template generator = new TableTemplate(xmlFile, settings, item);
                        if (generator.On)
                        {
                            templates.Add(generator);
                        }
                    }
                }
            }

            templates.Sort();
            return templates;
        }

        public static void GenerateFiles(string templateFolder, Model.Database database, List<Setting> settings, string basePath, ProcessChanged onProcessChanged)
        {
            List<Template> templates = CreateTemplates(templateFolder, database, settings);

            if (templates.Count > 0)
            {
                int process = 0;
                int step = 100 / templates.Count;
                if (step < 1) { step = 1; }

                foreach (Template item in templates)
                {
                    try
                    {
                        item.AttachFiles(basePath);
                        item.GenerateFile(basePath);
                        process = AddProcess(onProcessChanged, process, step);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(string.Format("生成代码文件{0}失败：{1}", item.TemplateName, ex.Message));
                    }
                }

                ChangeProcess(onProcessChanged, 100);
            }
        }

        private static int AddProcess(ProcessChanged onProcessChanged, int currValue, int addValue)
        {
            currValue += addValue;
            if (currValue > 99)
            {
                currValue = 99;
            }
            else if (currValue < 0)
            {
                currValue = 0;
            }
            ChangeProcess(onProcessChanged, currValue);

            return currValue;
        }

        private static void ChangeProcess(ProcessChanged onProcessChanged, int currValue)
        {
            if (onProcessChanged != null)
            {
                onProcessChanged(currValue);
            }
        }
    }
}
