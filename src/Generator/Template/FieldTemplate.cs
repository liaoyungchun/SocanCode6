using System;
using System.Collections.Generic;
using System.Xml;

namespace Generator
{
    /// <summary>
    /// 针对字段的代码生成引擎
    /// </summary>
    /// <typeparam name="TStyle">样式类型（用于替换属性，如无特别需求可以填写Model.BasicStyle）</typeparam>
    public class FieldTemplate : CodeTemplate<Model.Field, string>
    {
        public FieldTemplate(string templatePath, List<Setting> settings, Model.Field field)
            : base(templatePath, settings, field)
        {
            Config.System syscfg = Config.System.Load();
            foreach (KeyValuePair<string, object> item in ModelProperties<Model.Field>.GetPropertyValues(field))
            {
                Variables.Add(syscfg.FieldVariablePrefix + item.Key, item.Value);
            }

            foreach (KeyValuePair<string, object> item in ModelProperties<Model.Table>.GetPropertyValues(field.Table))
            {
                Variables.Add(syscfg.TableVariablePrefix + item.Key, item.Value);
            }

            foreach (KeyValuePair<string, object> item in ModelProperties<Model.Database>.GetPropertyValues(field.Table.Database))
            {
                Variables.Add(syscfg.DatabaseVariablePrefix + item.Key, item.Value);
            }
        }

        protected override string GenerateRepeaterNode(string model, XmlNode node)
        {
            throw new Exception("针对字段的节点下不能包含for/foreach节点。");
        }
    }
}
