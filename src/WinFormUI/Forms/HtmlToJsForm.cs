using System;
using System.Windows.Forms;

namespace SocanCode
{
    public partial class HtmlToJsForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public HtmlToJsForm()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string str = txtHtml.Text;
            str = str.Replace("\"", "\\\"");
            str = str.Replace("\'", "\\\'");
            str = str.Replace("\\", "\\\\");

            txtJavascript.Text = "<script type=\"text/javascript\">\r\n\tdocument.write('" + str + "');\r\n</script>";
        }
    }
}