using System.Collections.Generic;
using System.Xml;

namespace Generator
{
    /// <summary>
    /// 针对表的代码生成引擎
    /// </summary>
    /// <typeparam name="TStyle">样式类型（用于替换属性，如无特别需求可以填写Model.BasicStyle）</typeparam>
    public class TableTemplate : CodeTemplate<Model.Table, Model.Field>
    {
        public TableTemplate(string templatePath, List<Setting> properties, Model.Table table)
            : base(templatePath, properties, table)
        {
            Config.System syscfg = Config.System.Load();
            foreach (KeyValuePair<string, object> item in ModelProperties<Model.Table>.GetPropertyValues(table))
            {
                Variables.Add(syscfg.TableVariablePrefix + item.Key, item.Value);
            }

            foreach (KeyValuePair<string, object> item in ModelProperties<Model.Database>.GetPropertyValues(table.Database))
            {
                Variables.Add(syscfg.DatabaseVariablePrefix + item.Key, item.Value);
            }
        }

        protected override string GenerateRepeaterNode(Model.Field field, XmlNode node)
        {
            return new FieldTemplate(this.TemplatePath, this.settings, field).GenerateCommonCode(node);
        }
    }
}
