using System.Collections.Generic;
using System.Reflection;

namespace Generator
{
    /// <summary>
    /// 实体属性的辅助操作类
    /// </summary>
    /// <typeparam name="T">实体类型</typeparam>
    internal class ModelProperties<T>
    {
        /// <summary>
        /// 获取要替换的所有的属性及值，例如Database.Name，Settings.SlnFrame等
        /// 注意：如果属性为Dictionary&lt;string,string&gt;类型，则会把里面的键值对均作为属性对待
        /// </summary>
        /// <param name="model">实体的实例</param>
        /// <returns>属性及值的键值对</returns>
        public static Dictionary<string, object> GetPropertyValues(T model)
        {
            Dictionary<string, object> pv = new Dictionary<string, object>();

            foreach (PropertyInfo item in typeof(T).GetProperties())
            {
                MethodInfo mi = item.GetGetMethod(false);
                if (mi != null)
                {
                    string key = item.Name;
                    if (model == null)
                    {
                        pv.Add(key, null);
                    }
                    else
                    {
                        object value = item.GetValue(model, null);
                        if (value.GetType() != typeof(Dictionary<string, string>))
                        {
                            pv.Add(key, value);
                        }
                        else
                        {
                            Dictionary<string, string> dic = value as Dictionary<string, string>;
                            if (dic != null && dic.Count > 0)
                            {
                                foreach (KeyValuePair<string, string> kv in dic)
                                {
                                    pv.Add(kv.Key, kv.Value);
                                }
                            }
                        }
                    }
                }
            }

            return pv;
        }
    }
}
