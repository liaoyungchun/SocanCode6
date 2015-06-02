using System;
using System.Reflection;
using System.Text;

namespace Generator.Config
{
    public class Comment
    {
        public string Ext { get; set; }
        public string Start { get; set; }
        public string Line { get; set; }
        public string LineStart { get; set; }
        public string End { get; set; }

        /// <summary>
        /// 备注代码
        /// </summary>
        public static string GetCommentCode(string ext)
        {
            Comment comment = new Comment();

            switch (ext.ToLower())
            {
                case "cs":
                case "java":
                case "sql":
                    comment.Line = "*";
                    comment.LineStart = "* ";
                    comment.Start = "/*";
                    comment.End = "*/";
                    return GetComment(comment);
                case "aspx":
                case "ascx":
                case "asmx":
                case "master":
                    comment.Line = "-";
                    comment.LineStart = "- ";
                    comment.Start = "<%";
                    comment.End = "%>";
                    return GetComment(comment);
                case "htm":
                case "html":
                    comment.Line = "-";
                    comment.LineStart = "- ";
                    comment.Start = "<!";
                    comment.End = "->";
                    return GetComment(comment);
                default:
                    return string.Empty;
            }
        }

        private static string GetComment(Comment comment)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(comment.Start);
            for (int i = 0; i < 78; i++)
            {
                sb.Append(comment.Line);
            }
            sb.Append("\r\n");
            sb.AppendLine(comment.LineStart + string.Format("创建标识: Copyright (C) 2007-{0} Socansoft.com 版权所有", DateTime.Today.Year));
            sb.AppendLine(comment.LineStart + string.Format("创建描述: SocanCode代码生成器 V{0} 自动创建于 {1}", Assembly.GetEntryAssembly().GetName().Version, DateTime.Now));
            sb.AppendLine(comment.LineStart);
            sb.AppendLine(comment.LineStart + "功能描述: ");
            sb.AppendLine(comment.LineStart);
            sb.AppendLine(comment.LineStart + "修改标识: ");
            sb.AppendLine(comment.LineStart + "修改描述: ");

            for (int i = 0; i < 78; i++)
            {
                sb.Append(comment.Line);
            }
            sb.AppendLine(comment.End);

            sb.AppendLine();
            return sb.ToString();
        }
    }
}
