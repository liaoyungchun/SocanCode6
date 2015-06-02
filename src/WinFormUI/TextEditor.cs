using ICSharpCode.TextEditor.Document;
using SocanCode.Config;

namespace SocanCode
{
    public class TextEditor
    {
        /// <summary>
        /// 设置文本框样式
        /// </summary>
        /// <param name="textbox">文本框名称</param>
        /// <param name="language">语言:"ASP3/XHTML","BAT","Boo","Coco","C++.NET","C#","HTML",
        /// "Java","JavaScript","PHP","TeX","VBNET","XML","TSQL"</param>
        public static void SetStyle(ICSharpCode.TextEditor.TextEditorControl textbox, string language)
        {
            textbox.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy(language);
            textbox.Encoding = System.Text.Encoding.Default;
        }

        /// <summary>
        /// 设置文本框样式
        /// </summary>
        /// <param name="textbox">文本框名称</param>
        /// <param name="ext">后缀</param>
        public static void SetStyleByExt(ICSharpCode.TextEditor.TextEditorControl textbox, string ext)
        {
            Language lang = Language.GetLanguageByExt(ext);
            if (lang != null)
            {
                textbox.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy(lang.Name);
                textbox.Encoding = System.Text.Encoding.Default;
            }
        }
    }
}
