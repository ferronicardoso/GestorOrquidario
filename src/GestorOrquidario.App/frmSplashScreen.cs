using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace GestorOrquidario.App
{
    public partial class frmSplashScreen : Form
    {
        private delegate void ProgressDelegate(int progress);
        private ProgressDelegate del;

        public frmSplashScreen()
        {
            InitializeComponent();

            lblVersion.Text = string.Format("Versão: {0}", Application.ProductVersion);

            this.progressBar1.Maximum = 100;
            del = this.UpdateProgressInternal;
        }

        private void UpdateProgressInternal(int progress)
        {
            if (this.Handle == null)
            {
                return;
            }

            this.progressBar1.Value = progress;
        }

        public void UpdateProgress(int progress)
        {
            this.Invoke(del, progress);
        }
    }
}
