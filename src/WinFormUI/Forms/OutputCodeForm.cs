using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Generator;

namespace SocanCode
{
    public partial class OutputCodeForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        private Model.Database db;
        public event Action<string> ShowReadmeOfTemplate;

        public OutputCodeForm(Model.Database db)
        {
            InitializeComponent();
            selectTableUserControl1.DB = db;

            this.db = db;
            this.TabText = string.Format("输出代码 {0}", db.Name);
        }

        /// <summary>
        /// 生成的路径位置
        /// </summary>
        private string CreateFilePath
        {
            get { return txtPath.Text.TrimEnd(' ', '\\') + @"\SocanCode输出的代码"; }
        }

        private void btnOutputCode_Click(object sender, EventArgs e)
        {
            foreach (Model.Table table in selectTableUserControl1.SelectedTables)
            {
                if (table.Fields.Count == 0)
                {
                    ShowMessage.Alert(string.Format("表{0}不存在任何字段，无法生成！", table.Name));
                    return;
                }
            }

            if (false == ShowMessage.Confirm("确定要输出代码吗?"))
            {
                return;
            }

            if (Directory.Exists(CreateFilePath))
            {
                if (ShowMessage.Confirm("该目录已存在，是否删除?"))
                {
                    try
                    {
                        Directory.Delete(CreateFilePath, true);
                    }
                    catch (Exception ex)
                    {
                        ShowMessage.Error(ex.ToString());
                    }
                }
            }

            selectTemplateUserControl1.SaveSetting();
            db.SelectedTables = selectTableUserControl1.SelectedTables;

            //在Settings中额外地增加一项设定，值为当前选中的所有表
            List<Setting> settings = selectTemplateUserControl1.Settings;

            //目录有可能不存在，如果没有生成任何代码则打开目录会出错，故先创建目录
            if (false == Directory.Exists(CreateFilePath))
            {
                Directory.CreateDirectory(CreateFilePath);
            }

            try
            {
                //开始生成
                Template.GenerateFiles(selectTemplateUserControl1.TemplateFolderPath, db, settings, CreateFilePath,
                    new ProcessChanged(i => { progressBar1.Value = i; }));
            }
            catch (Exception ex)
            {
                ShowMessage.Error(ex.Message);
            }

            progressBar1.Value = 0;
            if (ShowMessage.Confirm("成功生成,是否打开目录?"))
            {
                Process.Start(CreateFilePath);
            }
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.SelectedPath = txtPath.Text.Trim();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dlg.SelectedPath;
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