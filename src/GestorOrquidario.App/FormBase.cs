using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestorOrquidario.App
{
    public class FormBase : Form
    {
        public bool EditMode { get; set; }

        public FormBase()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.ShowInTaskbar = false;
        
            this.FormClosing += frm_FormClosing;

        }

        void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.EditMode)
            {
                MessageBox.Show("Não é possível fechar a janela atual. Cancele a edição para prosseguir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }
    }
}
