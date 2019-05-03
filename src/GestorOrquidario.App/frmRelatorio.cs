using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace GestorOrquidario.App
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            IEnumerable<RelatorioFlores> objFlor = new BLL.Relatorios().GetRelatorioFlores();

            if (objFlor.Count() > 0)
            {
                this.RelatorioFloresBindingSource.DataSource = objFlor;
                this.rptMaster.RefreshReport();
            }
            this.rptMaster.RefreshReport();
        }
    }
}
