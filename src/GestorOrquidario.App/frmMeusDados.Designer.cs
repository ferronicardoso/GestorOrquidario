namespace GestorOrquidario.App
{
    partial class frmMeusDados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeusDados));
            this.navigation = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAddNew = new System.Windows.Forms.ToolStripButton();
            this.source = new System.Windows.Forms.BindingSource(this.components);
            this.txtCount = new System.Windows.Forms.ToolStripLabel();
            this.btnMoveFirst = new System.Windows.Forms.ToolStripButton();
            this.btnMovePrevious = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.txtPosition = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMoveNext = new System.Windows.Forms.ToolStripButton();
            this.btnMoveLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.sourceUF = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMSN = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSkype = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gpbMeusDados = new System.Windows.Forms.GroupBox();
            this.imagemPictureBox = new System.Windows.Forms.PictureBox();
            this.picDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.navigation)).BeginInit();
            this.navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.source)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceUF)).BeginInit();
            this.gpbMeusDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // navigation
            // 
            this.navigation.AddNewItem = this.btnAddNew;
            this.navigation.BindingSource = this.source;
            this.navigation.CountItem = this.txtCount;
            this.navigation.CountItemFormat = "de {0}";
            this.navigation.DeleteItem = null;
            this.navigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMoveFirst,
            this.btnMovePrevious,
            this.bindingNavigatorSeparator,
            this.txtPosition,
            this.txtCount,
            this.bindingNavigatorSeparator1,
            this.btnMoveNext,
            this.btnMoveLast,
            this.bindingNavigatorSeparator2,
            this.btnAddNew,
            this.btnEdit,
            this.btnDelete,
            this.btnSave,
            this.btnCancel});
            this.navigation.Location = new System.Drawing.Point(0, 0);
            this.navigation.MoveFirstItem = this.btnMoveFirst;
            this.navigation.MoveLastItem = this.btnMoveLast;
            this.navigation.MoveNextItem = this.btnMoveNext;
            this.navigation.MovePreviousItem = this.btnMovePrevious;
            this.navigation.Name = "navigation";
            this.navigation.PositionItem = this.txtPosition;
            this.navigation.Size = new System.Drawing.Size(561, 25);
            this.navigation.TabIndex = 7;
            this.navigation.Text = "bindingNavigator1";
            // 
            // btnAddNew
            // 
            this.btnAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddNew.Image = global::GestorOrquidario.App.Properties.Resources.add;
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.RightToLeftAutoMirrorImage = true;
            this.btnAddNew.Size = new System.Drawing.Size(23, 22);
            this.btnAddNew.Text = "Novo";
            this.btnAddNew.ToolTipText = "Novo";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // source
            // 
            this.source.DataSource = typeof(GestorOrquidario.Entities.FlorMeusDados);
            // 
            // txtCount
            // 
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(37, 22);
            this.txtCount.Text = "de {0}";
            this.txtCount.ToolTipText = "Total de itens";
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMoveFirst.Image = global::GestorOrquidario.App.Properties.Resources.resultset_first;
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.RightToLeftAutoMirrorImage = true;
            this.btnMoveFirst.Size = new System.Drawing.Size(23, 22);
            this.btnMoveFirst.Text = "Início";
            // 
            // btnMovePrevious
            // 
            this.btnMovePrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMovePrevious.Image = global::GestorOrquidario.App.Properties.Resources.resultset_previous;
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.RightToLeftAutoMirrorImage = true;
            this.btnMovePrevious.Size = new System.Drawing.Size(23, 22);
            this.btnMovePrevious.Text = "Anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // txtPosition
            // 
            this.txtPosition.AccessibleName = "Position";
            this.txtPosition.AutoSize = false;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(50, 23);
            this.txtPosition.Text = "0";
            this.txtPosition.ToolTipText = "Posição Atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMoveNext.Image = global::GestorOrquidario.App.Properties.Resources.resultset_next;
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.RightToLeftAutoMirrorImage = true;
            this.btnMoveNext.Size = new System.Drawing.Size(23, 22);
            this.btnMoveNext.Text = "Próximo";
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMoveLast.Image = global::GestorOrquidario.App.Properties.Resources.resultset_last;
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.RightToLeftAutoMirrorImage = true;
            this.btnMoveLast.Size = new System.Drawing.Size(23, 22);
            this.btnMoveLast.Text = "Último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::GestorOrquidario.App.Properties.Resources.edit;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 22);
            this.btnEdit.Text = "Editar";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = global::GestorOrquidario.App.Properties.Resources.delete;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.Text = "Excluir";
            this.btnDelete.ToolTipText = "Excluir";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::GestorOrquidario.App.Properties.Resources.save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeftAutoMirrorImage = true;
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Salvar";
            this.btnSave.ToolTipText = "Salvar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancel.Image = global::GestorOrquidario.App.Properties.Resources.cancel;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(23, 22);
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.source, "Nome", true));
            this.txtNome.Location = new System.Drawing.Point(19, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(307, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.source, "Endereco", true));
            this.txtEndereco.Location = new System.Drawing.Point(19, 81);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(307, 20);
            this.txtEndereco.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.source, "Complemento", true));
            this.txtComplemento.Location = new System.Drawing.Point(19, 120);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(307, 20);
            this.txtComplemento.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.source, "Bairro", true));
            this.txtBairro.Location = new System.Drawing.Point(20, 159);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(209, 20);
            this.txtBairro.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "CEP";
            // 
            // txtCEP
            // 
            this.txtCEP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.source, "Cep", true));
            this.txtCEP.Location = new System.Drawing.Point(235, 159);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(91, 20);
            this.txtCEP.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.source, "Cidade", true));
            this.txtCidade.Location = new System.Drawing.Point(19, 198);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(247, 20);
            this.txtCidade.TabIndex = 5;
            // 
            // cboUF
            // 
            this.cboUF.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.source, "IdFlorUf", true));
            this.cboUF.DataSource = this.sourceUF;
            this.cboUF.DisplayMember = "Sigla";
            this.cboUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(272, 197);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(54, 21);
            this.cboUF.TabIndex = 6;
            this.cboUF.ValueMember = "IdFlorUf";
            // 
            // sourceUF
            // 
            this.sourceUF.DataSource = typeof(GestorOrquidario.Entities.FlorUf);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "UF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.source, "Telefone", true));
            this.txtTelefone.Location = new System.Drawing.Point(20, 237);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(120, 20);
            this.txtTelefone.TabIndex = 7;
            // 
            // txtCelular
            // 
            this.txtCelular.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.source, "Celular", true));
            this.txtCelular.Location = new System.Drawing.Point(146, 237);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(120, 20);
            this.txtCelular.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Celular";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.source, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(20, 276);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "E-mail";
            // 
            // txtSite
            // 
            this.txtSite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.source, "Site", true));
            this.txtSite.Location = new System.Drawing.Point(272, 276);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(246, 20);
            this.txtSite.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(269, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Site";
            // 
            // txtMSN
            // 
            this.txtMSN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.source, "MSN", true));
            this.txtMSN.Location = new System.Drawing.Point(272, 237);
            this.txtMSN.Name = "txtMSN";
            this.txtMSN.Size = new System.Drawing.Size(120, 20);
            this.txtMSN.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(269, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "MSN";
            // 
            // txtSkype
            // 
            this.txtSkype.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.source, "Skype", true));
            this.txtSkype.Location = new System.Drawing.Point(398, 237);
            this.txtSkype.Name = "txtSkype";
            this.txtSkype.Size = new System.Drawing.Size(120, 20);
            this.txtSkype.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(395, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Skype";
            // 
            // gpbMeusDados
            // 
            this.gpbMeusDados.Controls.Add(this.imagemPictureBox);
            this.gpbMeusDados.Controls.Add(this.label1);
            this.gpbMeusDados.Controls.Add(this.txtSkype);
            this.gpbMeusDados.Controls.Add(this.txtNome);
            this.gpbMeusDados.Controls.Add(this.label13);
            this.gpbMeusDados.Controls.Add(this.txtEndereco);
            this.gpbMeusDados.Controls.Add(this.txtMSN);
            this.gpbMeusDados.Controls.Add(this.label2);
            this.gpbMeusDados.Controls.Add(this.label12);
            this.gpbMeusDados.Controls.Add(this.txtComplemento);
            this.gpbMeusDados.Controls.Add(this.txtSite);
            this.gpbMeusDados.Controls.Add(this.label3);
            this.gpbMeusDados.Controls.Add(this.label11);
            this.gpbMeusDados.Controls.Add(this.txtBairro);
            this.gpbMeusDados.Controls.Add(this.txtEmail);
            this.gpbMeusDados.Controls.Add(this.label4);
            this.gpbMeusDados.Controls.Add(this.label10);
            this.gpbMeusDados.Controls.Add(this.txtCEP);
            this.gpbMeusDados.Controls.Add(this.txtCelular);
            this.gpbMeusDados.Controls.Add(this.label5);
            this.gpbMeusDados.Controls.Add(this.label9);
            this.gpbMeusDados.Controls.Add(this.label6);
            this.gpbMeusDados.Controls.Add(this.txtTelefone);
            this.gpbMeusDados.Controls.Add(this.txtCidade);
            this.gpbMeusDados.Controls.Add(this.label8);
            this.gpbMeusDados.Controls.Add(this.cboUF);
            this.gpbMeusDados.Controls.Add(this.label7);
            this.gpbMeusDados.Location = new System.Drawing.Point(12, 28);
            this.gpbMeusDados.Name = "gpbMeusDados";
            this.gpbMeusDados.Size = new System.Drawing.Size(537, 316);
            this.gpbMeusDados.TabIndex = 26;
            this.gpbMeusDados.TabStop = false;
            // 
            // imagemPictureBox
            // 
            this.imagemPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagemPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagemPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.source, "Imagem", true));
            this.imagemPictureBox.Location = new System.Drawing.Point(332, 42);
            this.imagemPictureBox.Name = "imagemPictureBox";
            this.imagemPictureBox.Size = new System.Drawing.Size(186, 176);
            this.imagemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemPictureBox.TabIndex = 27;
            this.imagemPictureBox.TabStop = false;
            this.imagemPictureBox.Click += new System.EventHandler(this.imagemPictureBox_Click);
            // 
            // frmMeusDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(561, 356);
            this.Controls.Add(this.gpbMeusDados);
            this.Controls.Add(this.navigation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(577, 395);
            this.MinimumSize = new System.Drawing.Size(577, 395);
            this.Name = "frmMeusDados";
            this.Text = "Meus Dados";
            this.Load += new System.EventHandler(this.frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigation)).EndInit();
            this.navigation.ResumeLayout(false);
            this.navigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.source)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceUF)).EndInit();
            this.gpbMeusDados.ResumeLayout(false);
            this.gpbMeusDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator navigation;
        private System.Windows.Forms.ToolStripButton btnAddNew;
        private System.Windows.Forms.ToolStripLabel txtCount;
        private System.Windows.Forms.ToolStripButton btnMoveFirst;
        private System.Windows.Forms.ToolStripButton btnMovePrevious;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox txtPosition;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton btnMoveNext;
        private System.Windows.Forms.ToolStripButton btnMoveLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.BindingSource source;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMSN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSkype;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource sourceUF;
        private System.Windows.Forms.GroupBox gpbMeusDados;
        private System.Windows.Forms.PictureBox imagemPictureBox;
        private System.Windows.Forms.OpenFileDialog picDialog;

    }
}