using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Generator;

namespace SocanCode
{
    public partial class CreateCodeForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private Model.Table _table;
        public event Action<string> ShowReadmeOfTemplate;

        public CreateCodeForm(Model.Table table)
        {
            InitializeComponent();
            this.TabText = "生成代码 " + table.Name;
            _table = table;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            selectTemplateUserControl1.SaveSetting();
            tcCodes.Controls.Clear();

            this._table.Database.SelectedTables = new List<Model.Table>() { _table };
            List<Template> templates = Template.CreateTemplates(selectTemplateUserControl1.TemplateFolderPath, this._table.Database, selectTemplateUserControl1.Settings);
            foreach (Template item in templates)
            {
                AddCodeTabPage(item);
            }

            if (tcCodes.TabPages.Count > 0)
            {
                btnSaveAll.Enabled = true;
                btnSaveCurrentTab.Enabled = true;
            }
        }

        private void btnSaveCurrentTab_Click(object sender, EventArgs e)
        {
            if (tcCodes.SelectedTab == null)
            {
                ShowMessage.Confirm("请先生成代码！");
                return;
            }

            Generator.Template generator = tcCodes.SelectedTab.Tag as Generator.Template;

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.AddExtension = true;
            dlg.FileName = generator.Name;
            dlg.Filter = string.Format(".{0}|*.{0}", generator.Ext);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Generator.IOHelper.WriteFile(dlg.FileName, generator.Code);
            }
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            if (tcCodes.TabPages == null)
            {
                ShowMessage.Confirm("请先生成代码！");
                return;
            }

            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (TabPage page in tcCodes.TabPages)
                {
                    Generator.Template generator = page.Tag as Generator.Template;
                    generator.GenerateFile(dlg.SelectedPath);
                }
            }
        }

        /// <summary>
        /// 生成一个代码页
        /// </summary>
        public void AddCodeTabPage(Generator.Template template)
        {
            try
            {
                ICSharpCode.TextEditor.TextEditorControl txt = new ICSharpCode.TextEditor.TextEditorControl();
                txt.Dock = DockStyle.Fill;
                txt.ShowInvalidLines = false;
                TextEditor.SetStyleByExt(txt, template.Ext);
                txt.Text = template.Code;

                TabPage page = new TabPage();
                page.Tag = template;
                page.Text = template.TemplateName;

                page.Controls.Add(txt);
                tcCodes.TabPages.Add(page);
            }
            catch (Exception ex)
            {
                ShowMessage.Error(string.Format("使用代码模板{0}生成代码文件失败。{1}", template.TemplateName, ex.Message));
                throw;
            }
        }

        private void selectTemplateUserControl1_ShowReadmeOfTemplate(string obj)
        {
            if (ShowReadmeOfTemplate != null)
            {
                ShowReadmeOfTemplate(obj);
            }
        }
    }
}
