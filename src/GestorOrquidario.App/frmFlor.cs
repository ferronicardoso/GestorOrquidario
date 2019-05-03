using GestorOrquidario.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GestorOrquidario.App
{
    public partial class frmFlor : FormBase, IForm
    {
        public frmFlor()
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
            // Flor
            IEnumerable<Flor> objFlor = new BLL.Flores().GetAll();
            sourceFlor.DataSource = objFlor;

            // Genero
            IEnumerable<FlorGenero> objGenero = new BLL.Generos().GetAll();
            sourceGenero.DataSource = objGenero;

            // Adubacao
            IEnumerable<FlorAdubacao> objAdubacao = new BLL.Adubacoes().GetAll();
            sourceAdubacao.DataSource = objAdubacao;

            // Crescimento
            IEnumerable<FlorCrescimento> objCrescimento = new BLL.Crescimentos().GetAll();
            sourceCrescimento.DataSource = objCrescimento;

            // Fertilizante
            IEnumerable<FlorFertilizante> objFertilizante = new BLL.Fertilizantes().GetAll();
            sourceFertilizante.DataSource = objFertilizante;

            // Floracao
            IEnumerable<FlorFloracao> objFloracao = new BLL.Floracoes().GetAll();
            sourceFloracao.DataSource = objFloracao;

            // Habitat
            IEnumerable<FlorHabitat> objHabitat = new BLL.Habitats().GetAll();
            sourceHabitat.DataSource = objHabitat;

            //Luminosidade
            IEnumerable<FlorLuminosidade> objLuminosidade = new BLL.Luminosidades().GetAll();
            sourceLuminosidade.DataSource = objLuminosidade;

            // Origem
            IEnumerable<FlorOrigem> objOrigem = new BLL.Origens().GetAll();
            sourceOrigem.DataSource = objOrigem;

            // Substrato
            IEnumerable<FlorSubstrato> objSubstrato = new BLL.Substrtatos().GetAll();
            sourceSubstrato.DataSource = objSubstrato;

            // Tipo
            IEnumerable<FlorTipo> objTipo = new BLL.Tipos().GetAll();
            sourceTipo.DataSource = objTipo;

            // Umidade
            IEnumerable<FlorUmidade> objUmidade = new BLL.Umidades().GetAll();
            sourceUmidade.DataSource = objUmidade;
        }

        public void Cancel()
        {
            sourceFlor.CancelEdit();
            EnableEdit(false);
            Bind();
        }

        public void Delete()
        {
            Flor obj = (sourceFlor.Current as Flor);

            if (MessageBox.Show("Deseja excluir o registro selecionado?", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (obj.IdFlorFoto.HasValue) new BLL.Fotos().Delete(obj.IdFlorFoto.Value);
                bool deleted = new BLL.Flores().Delete(obj);

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
            btnEdit.Enabled = sourceFlor.Count == 0 ? false : !value;
            btnDelete.Enabled = sourceFlor.Count == 0 ? false : !value;
            btnSave.Enabled = value;
            btnCancel.Enabled = value;

            gpbFlores.Controls.OfType<TextBox>().ToList().ForEach(f => f.Enabled = value);
            gpbFlores.Controls.OfType<ComboBox>().ToList().ForEach(f => f.Enabled = value);
            gpbFlores.Controls.OfType<DateTimePicker>().ToList().ForEach(f => f.Enabled = value);
            gpbFlores.Controls.OfType<NumericUpDown>().ToList().ForEach(f => f.Enabled = value);
            gpbFlores.Controls.OfType<CheckBox>().ToList().ForEach(f => f.Enabled = value);
            gpbFlores.Controls.OfType<PictureBox>().ToList().ForEach(f => f.Enabled = value);
        }

        public void New()
        {
            EnableEdit(true);

            gpbFlores.Controls.OfType<TextBox>().ToList().ForEach(f => f.Text = string.Empty);
            gpbFlores.Controls.OfType<ComboBox>().ToList().ForEach(f => f.SelectedIndex = -1);
            gpbFlores.Controls.OfType<DateTimePicker>().ToList().ForEach(f => f.Value = DateTime.Now);
            gpbFlores.Controls.OfType<NumericUpDown>().ToList().ForEach(f => f.Value = 0);
            gpbFlores.Controls.OfType<CheckBox>().ToList().ForEach(f => f.Checked = false);
        }

        public void Save()
        {
            sourceFlor.EndEdit();
            bool saved = new BLL.Flores().Set((sourceFlor.Current as Flor));
            
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

        private void pic_Click(object sender, EventArgs e)
        {
            if (picDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo info = new FileInfo(picDialog.FileName);

                if (Global.EXTENSIONS_LIST.Contains(info.Extension.Replace(".", "")))
                {
                    byte[] img = Global.OpenImageByte(picDialog.FileName);
                    MemoryStream ms = new MemoryStream();
                    ms.Write(img, 0, img.Length);
                    pic.Image = Image.FromStream(ms);
                }
                else
                {
                    MessageBox.Show("Formato de arquivo inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
