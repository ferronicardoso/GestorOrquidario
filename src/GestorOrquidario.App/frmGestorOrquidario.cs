using GestorOrquidario.DAL;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Linq;
using GestorOrquidario.Entities;
using System.Windows.Media.Imaging;

namespace GestorOrquidario.App
{
    public partial class frmGestorOrquidario : Form
    {
        private frmSplashScreen splashScreen;
        private bool done = false;

        public frmGestorOrquidario()
        {
            InitializeComponent();

            LoadSettings();

            FlorConfiguracao config = new BLL.Configuracoes().GetAll().FirstOrDefault();

            this.BackgroundImageLayout = ImageLayout.Center;

            if (config != null && config.Background.Length > 0)
            {
                this.BackgroundImage = Global.ConvertByteToImage(config.Background);
            }

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.ResizeRedraw = true;

            this.Load += new EventHandler(HandleFormLoad);
            this.splashScreen = new frmSplashScreen();
        }

        private void HandleFormLoad(object sender, EventArgs e)
        {
            this.Hide();

            Thread thread = new Thread(new ThreadStart(this.ShowSplashScreen));
            thread.Start();

            Hardworker worker = new Hardworker();
            worker.ProgressChanged += (o, ex) =>
            {
                this.splashScreen.UpdateProgress(ex.Progress);
            };

            worker.HardWorkDone += (o, ex) =>
            {
                done = true;
                this.Show();
            };

            worker.DoHardWork();
        }

        private void ShowSplashScreen()
        {
            splashScreen.Show();
            while (!done)
            {
                Application.DoEvents();
            }
            splashScreen.Close();
            this.splashScreen.Dispose();
        }

        private void ShowForm(Form frm, bool showDialog = false)
        {
            if (showDialog)
            {
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        private void LoadSettings()
        {
            this.Size = Properties.Settings.Default.WindowSize;
            this.WindowState = Properties.Settings.Default.WindowState;
            this.Location = Properties.Settings.Default.WindowLocation;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.WindowSize = this.Size;
            Properties.Settings.Default.WindowState = this.WindowState;
            Properties.Settings.Default.WindowLocation = this.Location;
            Properties.Settings.Default.Save();
        }

        private void frmGestorOrquidario_Load(object sender, EventArgs e)
        {
            string path = new DBConnection().DatabasePath;
            string fileName = new FileInfo(path).Name;

            txtProduto.Text = string.Format("{0} {1}", Application.CompanyName, Application.ProductName);
            txtVersao.Text = Application.ProductVersion;
            txtDatabasePath.Text = fileName;
        }

        private void frmGestorOrquidario_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja fechar o GestorOrquidario?", "Encerrar GestorOrquidario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                SaveSettings();
            }
        }

        #region Menu Sistema

        private void mnuSistemaMinhasFlores_Click(object sender, EventArgs e)
        {
            ShowForm(new frmFlor());
        }

        #region Submenu Manutenção

        private void mnuManutencaoGenero_Click(object sender, EventArgs e)
        {
            ShowForm(new frmGenero());
        }

        private void mnuManutencaoSubstrato_Click(object sender, EventArgs e)
        {
            ShowForm(new frmSubstrato());
        }

        private void mnuManutencaoFertilizante_Click(object sender, EventArgs e)
        {
            ShowForm(new frmFertilizante());
        }

        private void mnuManutencaoAdubacao_Click(object sender, EventArgs e)
        {
            ShowForm(new frmAdubacao());
        }

        private void mnuManutencaoUmidade_Click(object sender, EventArgs e)
        {
            ShowForm(new frmUmidade());
        }

        private void mnuManutencaoLuminosidade_Click(object sender, EventArgs e)
        {
            ShowForm(new frmLuminosidade());
        }

        private void mnuManutencaoFloracao_Click(object sender, EventArgs e)
        {
            ShowForm(new frmFloracao());
        }

        private void mnuManutencaoCrescimento_Click(object sender, EventArgs e)
        {
            ShowForm(new frmCrescimento());
        }

        private void mnuManutencaoOrigem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmOrigem());
        }

        private void mnuManutencaoHabitat_Click(object sender, EventArgs e)
        {
            ShowForm(new frmHabitat());
        }

        private void mnuManutencaoTipo_Click(object sender, EventArgs e)
        {
            ShowForm(new frmTipo());
        }

        #endregion

        private void mnuSistemaRelatorio_Click(object sender, EventArgs e)
        {
            ShowForm(new frmRelatorio());
        }

        private void mnuSistemaMeusDados_Click(object sender, EventArgs e)
        {
            ShowForm(new frmMeusDados());
        }

        private void mnuSistemaFornecedores_Click(object sender, EventArgs e)
        {
            ShowForm(new frmFornecedor());
        }

        private void mnuSistemaConfiguracoes_Click(object sender, EventArgs e)
        {
            ShowForm(new frmConfiguracoes());
        }

        private void mnuSistemaBackup_Click(object sender, EventArgs e)
        {
            ShowForm(new frmBackup(), true);
        }

        private void mnuSistemaSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Menu Ajuda

        private void mnuSobre_Click(object sender, EventArgs e)
        {
            ShowForm(new frmSobre(), true);
        }

        #endregion
    }
}
