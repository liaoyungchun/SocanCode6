using System.Windows.Forms;

namespace SocanCode
{
    public partial class ViewCodeForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="caption">标题</param>
        /// <param name="text">内容</param>
        /// <param name="lang">语言:"ASP3/XHTML","BAT","Boo","Coco","C++.NET","C#","HTML",
        /// "Java","JavaScript","PHP","TeX","VBNET","XML","TSQL"</param>
        public ViewCodeForm(string caption, string text, string language)
        {
            InitializeComponent();
            this.TabText = caption;
            TextEditor.SetStyle(txtCode, language);
            txtCode.Text = text;
        }
    }
}