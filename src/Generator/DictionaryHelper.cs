using System;
using System.Collections.Generic;

namespace Generator
{
    public class DictionaryHelper
    {
        /// <summary>
        /// 获取一个实体属性的值
        /// </summary>
        /// <param name="model">实体</param>
        /// <param name="property">属性名</param>
        /// <returns></returns>
        public static object GetValue(Dictionary<string, object> dic, string property)
        {
            foreach (KeyValuePair<string, object> item in dic)
            {
                if (item.Key.Equals(property, System.StringComparison.CurrentCultureIgnoreCase))
                {
                    return item.Value;
                }
            }
            return null;
        }

        /// <summary>
        /// 检查实例中是否存在指定的属性及其值对应的字符串（不区分大小写）
        /// </summary>
        /// <param name="model">实体的实例</param>
        /// <param name="property">属性名</param>
        /// <param name="value">属性值</param>
        /// <returns>是否存在</returns>
        public static bool CheckValue(Dictionary<string, object> dic, string property, string value)
        {
            string[] r = value.Split('|');
            foreach (KeyValuePair<string, object> kv in dic)
            {
                if (kv.Key.Equals(property, System.StringComparison.CurrentCultureIgnoreCase))
                {
                    foreach (string item in r)
                    {
                        string val = kv.Value == null ? string.Empty : kv.Value.ToString();
                        if (item.Equals(val, StringComparison.CurrentCultureIgnoreCase))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
