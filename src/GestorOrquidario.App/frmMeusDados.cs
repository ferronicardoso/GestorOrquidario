using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GestorOrquidario.App
{
    public partial class frmMeusDados : FormBase, IForm
    {
        public frmMeusDados()
        {
            InitializeComponent();
        }

        public void Init()
        {
            picDialog.Filter = Global.FILTER_EXTENSION;

            Bind();
            EnableEdit(false);
        }

        public void Bind()
        {
            IEnumerable<FlorMeusDados> obj = new BLL.MeusDados().GetAll();
            source.DataSource = obj;

            IEnumerable<FlorUf> objUf = new BLL.MeusDados().GetAllUf();
            sourceUF.DataSource = objUf;
        }

        public void Cancel()
        {
            source.CancelEdit();
            EnableEdit(false);
            Bind();
        }

        public void Delete()
        {
            FlorMeusDados obj = (source.Current as FlorMeusDados);

            if (MessageBox.Show("Deseja excluir o registro selecionado?", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool deleted = new BLL.MeusDados().Delete(obj);

                if (deleted)
                {
                    Bind();
                    EnableEdit(false);
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o registro selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Edit()
        {
            EnableEdit(true);
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
            btnEdit.Enabled = source.Count == 0 ? false : !value;
            btnDelete.Enabled = source.Count == 0 ? false : !value;
            btnSave.Enabled = value;
            btnCancel.Enabled = value;

            gpbMeusDados.Controls.OfType<TextBox>().ToList().ForEach(f => f.ReadOnly = !value);
            gpbMeusDados.Controls.OfType<ComboBox>().ToList().ForEach(f => f.Enabled = value);
            gpbMeusDados.Controls.OfType<PictureBox>().ToList().ForEach(f => f.Enabled = value);
        }

        public void New()
        {
            EnableEdit(true);
        }

        public void Save()
        {
            source.EndEdit();
            bool saved = new BLL.MeusDados().Set((source.Current as FlorMeusDados));

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

        private void imagemPictureBox_Click(object sender, EventArgs e)
        {
            if (picDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo info = new FileInfo(picDialog.FileName);

                if (Global.EXTENSIONS_LIST.Contains(info.Extension.Replace(".","")))
                {
                    byte[] img = Global.OpenImageByte(picDialog.FileName);
                    MemoryStream ms = new MemoryStream();
                    ms.Write(img, 0, img.Length);
                    imagemPictureBox.Image = Image.FromStream(ms);
                }
                else
                {
                    MessageBox.Show("Formato de arquivo inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
