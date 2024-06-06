using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management;
using Microsoft.SqlServer.Management.Common;
using System.Collections.Specialized;


namespace BackupRestoreSqlServer
{
    public partial class MainWin : Form
    {
        private string dbName = string.Empty;
        private SqlConnection sqlConn;
        private Server sqlServer;
        private List<Database> dbList;

        public MainWin()
        {
            InitializeComponent();
            openBakFile.InitialDirectory = Application.StartupPath;
            saveBakFile.InitialDirectory = Application.StartupPath;

            try
            {
                sqlConn = new SqlConnection(Properties.Settings.Default.masterConnectionString);
                sqlServer = new Server(new ServerConnection(sqlConn));

                dbList = new List<Database>();
                foreach (Database db in sqlServer.Databases)
                {
                    dbList.Add(db);
                }

                cmbBackupDb.DataSource = dbList;
                cmbRestoreDb.DataSource = dbList;

                cmbBackupMode.SelectedIndex = 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show(string.Format("Exception occured.\nMessage: {0}", exc.Message));
            }
        }

        private void MainWin_Load(object sender, EventArgs e)
        {

        }

        private void btnFileToBack_Click(object sender, EventArgs e)
        {
            saveBakFile.ShowDialog();
        }

        private void saveBakFile_FileOk(object sender, CancelEventArgs e)
        {
            txtFileToBack.Text = saveBakFile.FileName;
        }

        private void openBakFile_FileOk(object sender, CancelEventArgs e)
        {
            txtFileToRestore.Text = openBakFile.FileName;
        }

        private void btnFileToRestore_Click(object sender, EventArgs e)
        {
            openBakFile.ShowDialog();
        }

        private void btnBackupDb_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(saveBakFile.FileName))
            {
                MessageBox.Show("Select file first!");
            }
            else
            {
                BackupDb();
            }
        }

        private void BackupDb()
        {
            dbName = ((Database)cmbBackupDb.SelectedItem).Name;
            Backup dbBackup = new Backup();

            try
            {
                dbBackup.Action = BackupActionType.Database;
                dbBackup.Database = dbName;
                dbBackup.BackupSetName = string.Format("{0} backup set.", dbName);
                dbBackup.BackupSetDescription = string.Format("Database: {0}. Date: {1}.", dbName, DateTime.Now.ToString("dd.MM.yyyy hh:m"));
                dbBackup.MediaDescription = "Disk";

                BackupDeviceItem device = new BackupDeviceItem(saveBakFile.FileName, DeviceType.File);
                dbBackup.Devices.Add(device);

                txtBackupSql.Text = dbBackup.Script(sqlServer);

                progBar.Visible = true;
                progBar.Value = 0;

                dbBackup.Complete += new ServerMessageEventHandler(dbBackup_Complete);
                dbBackup.PercentCompleteNotification = 10;
                dbBackup.PercentComplete += new PercentCompleteEventHandler(PercentComplete);

                dbBackup.SqlBackup(sqlServer);
            }
            catch (Exception exc)
            {
                dbBackup.Abort();
                MessageBox.Show(string.Format("Exception occured.\nMessage: {0}", exc.Message));
            }
            finally
            {
                sqlConn.Close();
            }

            progBar.Visible = false;
        }

        void dbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            MessageBox.Show("Backup complete");
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(openBakFile.FileName))
            {
                MessageBox.Show("Select file first!");
            }
            else
            {
                txtBackupSql.Text = string.Empty;
                RestoreDb();
            }
        }

        private void RestoreDb()
        {
            Database restoreDb = (Database)cmbRestoreDb.SelectedItem;
            dbName = restoreDb.Name;

            Restore dbRestore = new Restore();
            dbRestore.Database = restoreDb.Name;
            dbRestore.Action = RestoreActionType.Database;
            dbRestore.ReplaceDatabase = true;
       
            string fileLocation = ConfigurationManager.AppSettings["SqlFileLocations"];

            try
            {
                BackupDeviceItem device = new BackupDeviceItem(openBakFile.FileName, DeviceType.File);
                dbRestore.Devices.Add(device);
                DataTable dtFiles = dbRestore.ReadFileList(sqlServer);
                string backupDbLogicalName = dtFiles.Rows[0]["LogicalName"].ToString();

                RelocateFile dbRf = new RelocateFile(backupDbLogicalName, string.Format("{0}\\{1}.mdf", fileLocation, dbName));
                RelocateFile logRf = new RelocateFile(string.Format("{0}_log", backupDbLogicalName), string.Format("{0}\\{1}_Log.ldf", fileLocation, dbName));
                dbRestore.RelocateFiles.Add(dbRf);
                dbRestore.RelocateFiles.Add(logRf);

                string sql = string.Empty;
                StringCollection scriptColl = dbRestore.Script(sqlServer);
                foreach (string str in scriptColl)
                {
                    sql += str;
                }
                txtBackupSql.Text = sql;

                progBar.Visible = true;
                progBar.Value = 0;

                dbRestore.Complete += new ServerMessageEventHandler(dbRestore_Complete);
                dbRestore.PercentComplete += new PercentCompleteEventHandler(PercentComplete);
                dbRestore.SqlRestore(sqlServer);
            }
            catch (Exception exc)
            {
                dbRestore.Abort();
                MessageBox.Show(string.Format("Exception occured.\nMessage: {0}", exc.Message));
            }
            finally
            {
                sqlConn.Close();
            }

            progBar.Visible = false;
        }

        void PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            if (progBar.Value < progBar.Maximum)
            {
                if ((progBar.Value + e.Percent) <= 100)
                {
                    progBar.Value += e.Percent;
                }
                else
                    progBar.Value = 100;
            }
        }

        void dbRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            MessageBox.Show("Restore complete");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
    }
}