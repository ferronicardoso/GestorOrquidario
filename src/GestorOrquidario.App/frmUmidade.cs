using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestorOrquidario.App
{
    public partial class frmUmidade :  FormBase, IForm
    {
        public frmUmidade()
        {
            InitializeComponent();
        }

        public void Init()
        {
            Bind();
            EnableEdit(false);
        }

        public void Bind()
        {
            IEnumerable<FlorUmidade> obj = new BLL.Umidades().GetAll();
            source.DataSource = obj;
        }

        public void New()
        {
            EnableEdit(true);
            grid.BeginEdit(true);
        }

        public void Edit()
        {
            EnableEdit(true);
            grid.BeginEdit(true);
        }

        public void Delete()
        {
            FlorUmidade obj = (source.Current as FlorUmidade);

            if (MessageBox.Show("Deseja excluir o registro selecionado?", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool deleted = new BLL.Umidades().Delete(obj);

                if (deleted)
                {
                    source.RemoveAt(this.grid.SelectedRows[0].Index);
                    EnableEdit(false);
                    Bind();
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o registro selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Save()
        {
            grid.EndEdit();
            bool saved = new BLL.Umidades().Set((source.Current as FlorUmidade));

            if (saved)
            {
                EnableEdit(false);
                Bind();
            }
            else
            {
                MessageBox.Show("Não foi possível salvar o registro atual", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Cancel()
        {
            grid.CancelEdit();
            EnableEdit(false);
            Bind();
        }

        public void EnableEdit(bool value)
        {
            this.EditMode = value;

            btnMoveFirst.Enabled = !value;
            btnMovePrevious.Enabled = !value;
            btnMoveNext.Enabled = !value;
            btnMoveLast.Enabled = !value;

            txtPosition.Enabled = !value;

            btnAddNew.Enabled = !value;
            btnEdit.Enabled = grid.Rows.Count == 0 ? false : !value;
            btnDelete.Enabled = grid.Rows.Count == 0 ? false : !value;
            btnSave.Enabled = value;
            btnCancel.Enabled = value;

            grid.AllowUserToResizeColumns = !value;
            grid.AllowUserToResizeRows = !value;

            if (grid.CurrentCell != null)
            {
                grid.CurrentCell = grid.Rows[grid.CurrentRow.Index].Cells[1];
            }
        }

        private void frm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Save();
        }
    }
}
