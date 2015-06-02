using System.Collections.Generic;
using System.Xml;

namespace Generator
{
    /// <summary>
    /// 针对库的代码生成引擎
    /// </summary>
    /// <typeparam name="TStyle">样式类型（用于替换属性，如无特别需求可以填写Model.BasicStyle）</typeparam>
    public class DatabaseTemplate : CodeTemplate<Model.Database, Model.Table>
    {
        public DatabaseTemplate(string templatePath, List<Setting> properties, Model.Database database)
            : base(templatePath, properties, database)
        {
            Config.System syscfg = Config.System.Load();
            foreach (KeyValuePair<string, object> item in ModelProperties<Model.Database>.GetPropertyValues(database))
            {
                Variables.Add(syscfg.DatabaseVariablePrefix + item.Key, item.Value);
            }
        }

        protected override string GenerateRepeaterNode(Model.Table table, XmlNode node)
        {
            return new TableTemplate(this.TemplatePath, this.settings, table).GenerateCommonCode(node);
        }
    }
}
