using GestorOrquidario.Entities;
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
    public partial class frmConfiguracoes : FormBase, IForm
    {
        public frmConfiguracoes()
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
            IEnumerable<FlorConfiguracao> obj = new BLL.Configuracoes().GetAll();
            sourceConfiguracao.DataSource = obj;
        }

        public void Cancel()
        {
            sourceConfiguracao.CancelEdit();
            EnableEdit(false);
            Bind();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            EnableEdit(true);
        }

        public void EnableEdit(bool value)
        {
            this.EditMode = value;
        }

        public void New()
        {
            EnableEdit(true);
        }

        public void Save()
        {
            sourceConfiguracao.EndEdit();
            bool saved = new BLL.Configuracoes().Set((sourceConfiguracao.Current as FlorConfiguracao));

            if (saved)
            {
                EnableEdit(false);
                Bind();
            }
            else
            {
                MessageBox.Show("Não foi possível salvar as configurações", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {
            if (picDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo info = new FileInfo(picDialog.FileName);

                if (Global.EXTENSIONS_LIST.Contains(info.Extension.Replace(".", "")))
                {
                    byte[] imgByte = Global.OpenImageByte(picDialog.FileName);
                    MemoryStream ms = new MemoryStream();
                    ms.Write(imgByte, 0, imgByte.Length);

                    Image image = Image.FromStream(ms);

                    Graphics g = Graphics.FromImage(image);
                    g.DrawImage(image, 0, 0);

                    pic.Image = image;
                }
                else
                {
                    MessageBox.Show("Formato de arquivo inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancel();
            this.Close();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            Init();

            if (sourceConfiguracao.Count == 0)
            {
                New();
            }
            else
            {
                Edit();
            }
        }
    }
}
