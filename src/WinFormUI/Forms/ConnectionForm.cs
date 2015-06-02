using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SocanCode
{
    public partial class ConnectionForm : Form
    {
        /// <summary>
        /// 要返回的数据库
        /// </summary>
        public Model.Database database;

        public ConnectionForm()
        {
            InitializeComponent();
            LoadConnectionFromFile();
        }

        /// <summary>
        /// 获取当前要连接的数据库类型和连接语句
        /// </summary>
        private Fabrics.Schema GetSchema()
        {
            Fabrics.Schema schema = null;
            switch (tcDatabase.SelectedIndex)
            {
                case 0:
                    schema = new Fabrics.Schema(accessConn1.ConnectionString, Model.DatabaseTypes.Access);
                    break;
                case 2:
                    schema = new Fabrics.Schema(mySqlConn1.ConnectionString, Model.DatabaseTypes.MySql);
                    break;
                case 3:
                    schema = new Fabrics.Schema(oracleConn1.ConnectionString, Model.DatabaseTypes.Oracle);
                    break;
                case 4:
                    schema = new Fabrics.Schema(sqLiteConn1.ConnectionString, Model.DatabaseTypes.SQLite);
                    break;
                case 1:
                default:
                    schema = new Fabrics.Schema();
                    schema.ConnectionString = sqlConn1.ConnectionString;

                    if (sqlConn1.IsSql2005)
                        schema.Type = Model.DatabaseTypes.Sql2005;
                    else
                        schema.Type = Model.DatabaseTypes.Sql2000;
                    break;
            }
            return schema;
        }

        /// <summary>
        /// 从设置文件中加载数据库连接
        /// </summary>
        private void LoadConnectionFromFile()
        {
            try
            {
                Config.History history = Config.History.Load();
                if (!string.IsNullOrEmpty(history.AccessConn))
                {
                    accessConn1.ConnectionString = history.AccessConn;
                }
                if (!string.IsNullOrEmpty(history.SqlServerConn))
                {
                    sqlConn1.ConnectionString = history.SqlServerConn;
                    sqlConn1.IsSql2005 = history.DatabaseType == Model.DatabaseTypes.Sql2005;
                }
                if (!string.IsNullOrEmpty(history.MySqlConn))
                {
                    mySqlConn1.ConnectionString = history.MySqlConn;
                }
                if (!string.IsNullOrEmpty(history.OracleConn))
                {
                    oracleConn1.ConnectionString = history.OracleConn;
                }
                if (!string.IsNullOrEmpty(history.SQLiteConn))
                {
                    sqLiteConn1.ConnectionString = history.SQLiteConn;
                }

                switch (history.DatabaseType)
                {
                    case Model.DatabaseTypes.Access:
                        tcDatabase.SelectedIndex = 0;
                        break;
                    case Model.DatabaseTypes.MySql:
                        tcDatabase.SelectedIndex = 2;
                        break;
                    case Model.DatabaseTypes.Oracle:
                        tcDatabase.SelectedIndex = 3;
                        break;
                    case Model.DatabaseTypes.SQLite:
                        tcDatabase.SelectedIndex = 4;
                        break;
                    case Model.DatabaseTypes.Sql2000:
                    case Model.DatabaseTypes.Sql2005:
                    default:
                        tcDatabase.SelectedIndex = 1;
                        break;
                }
            }
            catch
            {
                // 加载失败无需操作
            }
        }

        /// <summary>
        /// 保存数据库连接到用户设置
        /// </summary>
        private void SaveConnectionToFile()
        {
            Config.History history = Config.History.Load();
            switch (tcDatabase.SelectedIndex)
            {
                case 0:
                    history.DatabaseType = Model.DatabaseTypes.Access;
                    history.AccessConn = accessConn1.ConnectionString;
                    break;
                case 2:
                    history.DatabaseType = Model.DatabaseTypes.MySql;
                    history.MySqlConn = mySqlConn1.ConnectionString;
                    break;
                case 3:
                    history.DatabaseType = Model.DatabaseTypes.Oracle;
                    history.OracleConn = oracleConn1.ConnectionString;
                    break;
                case 4:
                    history.DatabaseType = Model.DatabaseTypes.SQLite;
                    history.SQLiteConn = sqLiteConn1.ConnectionString;
                    break;
                case 1:
                default:
                    history.DatabaseType = sqlConn1.IsSql2005 ? Model.DatabaseTypes.Sql2005 : Model.DatabaseTypes.Sql2000;
                    history.SqlServerConn = sqlConn1.ConnectionString;
                    break;
            }
            Config.History.Save(history);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();
            else
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            btnConnect.Enabled = false;
            Fabrics.Schema schema = GetSchema();
            backgroundWorker1.RunWorkerAsync(schema);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Fabrics.Schema schema = e.Argument as Fabrics.Schema;
            Model.Database database = schema.GetSchema();

            if (backgroundWorker1.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                e.Result = database;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
            btnConnect.Enabled = true;

            if (e.Cancelled)
            {
                return;
            }

            if (e.Error != null)
            {
                ShowMessage.Error("连接失败！错误：" + e.Error.Message);
                return;
            }

            if (e.Result == null)
            {
                ShowMessage.Error("连接失败！");
                return;
            }

            database = e.Result as Model.Database;
            SaveConnectionToFile();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}