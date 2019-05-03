using GestorOrquidario.DAL;
using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestorOrquidario.App
{
    public partial class frmBackup : FormBase
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ClassStyle = param.ClassStyle | 0x200;
                return param;
            }
        }

        private bool IsCanceled { get; set; }

        public frmBackup()
        {
            InitializeComponent();
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {
            tmr.Enabled = true;
        }

        void InicializaBackup()
        {
            string dbFile = new FileInfo(new DBConnection().DatabasePath).Name;
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string dbPath = Path.Combine(appPath, "Data");
            string backupPath = Path.Combine(appPath, "Backup");

            string origem = Path.Combine(dbPath, dbFile);
            string destino = Path.Combine(backupPath, string.Format("backup_{0}.zip", DateTime.Now.ToString("yyyyMMddhhmmss")));

            if (File.Exists(origem))
            {
                FileInfo dirInfo = new FileInfo(destino);
                if (!dirInfo.Directory.Exists) Directory.CreateDirectory(dirInfo.Directory.FullName);

                Application.DoEvents();
                using (ZipFile zip = new ZipFile())
                {
                    zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Default;
                    zip.SaveProgress += zip_SaveProgress;

                    ZipEntry zipEntry = zip.AddFile(origem, "");

                    zip.Comment = "Backup realizado dia " + DateTime.Now.ToString("dd/MM/yyyy") + " as " + DateTime.Now.ToString("HH:mm:ss") + ".";
                    zip.Save(destino);
                }
            }
        }

        void zip_SaveProgress(object sender, SaveProgressEventArgs e)
        {
            Application.DoEvents();

            decimal perc = 0;

            if (e.EventType == ZipProgressEventType.Saving_Started)
            {
                label1.Text = "Iniciando...";
            }
            else if (e.EventType == ZipProgressEventType.Saving_BeforeWriteEntry)
            {
                label1.Text = "Compactando...";
                progressBar1.Maximum = ((int)e.TotalBytesToTransfer);
                progressBar1.Value = 0;
            }
            else if (e.EventType == ZipProgressEventType.Saving_EntryBytesRead)
            {
                if (progressBar1.Maximum == 0) progressBar1.Maximum = ((int)e.TotalBytesToTransfer);
                progressBar1.Value = ((int)e.BytesTransferred);

                perc = decimal.Multiply(decimal.Divide(e.BytesTransferred, e.TotalBytesToTransfer), 100);
            }
            else if (e.EventType == ZipProgressEventType.Saving_Completed)
            {
                label1.Text = "Concluido!";
                this.Close();
            }

            if (IsCanceled) e.Cancel = true;

            label2.Text = string.Format("{0}%", perc.ToString("F2"));
            this.Text = string.Format("Andamento {0}%", perc.ToString("F2"));
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            tmr.Enabled = false;

            InicializaBackup();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o backup?", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.IsCanceled = true;
            }
        }
    }
}
