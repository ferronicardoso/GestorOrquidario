namespace GestorOrquidario.App
{
    partial class frmGestorOrquidario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestorOrquidario));
            this.tspGestorOrquidario = new System.Windows.Forms.ToolStrip();
            this.mnuMinhasFlores = new System.Windows.Forms.ToolStripButton();
            this.mnuRelatorio = new System.Windows.Forms.ToolStripButton();
            this.mnuMeusDados = new System.Windows.Forms.ToolStripButton();
            this.mnuSair = new System.Windows.Forms.ToolStripButton();
            this.mnuFornecedores = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.mnuBackup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sspGestorOrquidario = new System.Windows.Forms.StatusStrip();
            this.txtProduto = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtDatabasePath = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSistemaMinhasFlores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManutencao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManutencaoGenero = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManutencaoSubstrato = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManutencaoFertilizante = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManutencaoUmidade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManutencaoLuminosidade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManutencaoFloracao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManutencaoCrescimento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManutencaoOrigem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManutencaoTipo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManutencaoHabitat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManutencaoAdubacao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSistemaRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSistemaMeusDados = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSistemaFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSistemaConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSistemaBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSistemaSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGestorOrquidario = new System.Windows.Forms.MenuStrip();
            this.tspGestorOrquidario.SuspendLayout();
            this.sspGestorOrquidario.SuspendLayout();
            this.mnuGestorOrquidario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspGestorOrquidario
            // 
            this.tspGestorOrquidario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tspGestorOrquidario.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspGestorOrquidario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMinhasFlores,
            this.mnuRelatorio,
            this.mnuMeusDados,
            this.mnuSair,
            this.mnuFornecedores,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.mnuBackup,
            this.toolStripSeparator2});
            this.tspGestorOrquidario.Location = new System.Drawing.Point(0, 24);
            this.tspGestorOrquidario.Name = "tspGestorOrquidario";
            this.tspGestorOrquidario.Size = new System.Drawing.Size(1042, 131);
            this.tspGestorOrquidario.TabIndex = 1;
            this.tspGestorOrquidario.Text = "ToolStrip";
            // 
            // mnuMinhasFlores
            // 
            this.mnuMinhasFlores.AutoSize = false;
            this.mnuMinhasFlores.Image = global::GestorOrquidario.App.Properties.Resources.flower;
            this.mnuMinhasFlores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuMinhasFlores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuMinhasFlores.Name = "mnuMinhasFlores";
            this.mnuMinhasFlores.Size = new System.Drawing.Size(128, 128);
            this.mnuMinhasFlores.Text = "Minhas Flores";
            this.mnuMinhasFlores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuMinhasFlores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnuMinhasFlores.Click += new System.EventHandler(this.mnuSistemaMinhasFlores_Click);
            // 
            // mnuRelatorio
            // 
            this.mnuRelatorio.AutoSize = false;
            this.mnuRelatorio.Image = global::GestorOrquidario.App.Properties.Resources.report;
            this.mnuRelatorio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuRelatorio.Name = "mnuRelatorio";
            this.mnuRelatorio.Size = new System.Drawing.Size(128, 128);
            this.mnuRelatorio.Text = "Relatório";
            this.mnuRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnuRelatorio.Click += new System.EventHandler(this.mnuSistemaRelatorio_Click);
            // 
            // mnuMeusDados
            // 
            this.mnuMeusDados.AutoSize = false;
            this.mnuMeusDados.Image = global::GestorOrquidario.App.Properties.Resources.profile;
            this.mnuMeusDados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuMeusDados.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuMeusDados.Name = "mnuMeusDados";
            this.mnuMeusDados.Size = new System.Drawing.Size(128, 128);
            this.mnuMeusDados.Text = "Meus Dados";
            this.mnuMeusDados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuMeusDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnuMeusDados.Click += new System.EventHandler(this.mnuSistemaMeusDados_Click);
            // 
            // mnuSair
            // 
            this.mnuSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuSair.AutoSize = false;
            this.mnuSair.Image = global::GestorOrquidario.App.Properties.Resources.exit;
            this.mnuSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(128, 128);
            this.mnuSair.Text = "Sair";
            this.mnuSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnuSair.Click += new System.EventHandler(this.mnuSistemaSair_Click);
            // 
            // mnuFornecedores
            // 
            this.mnuFornecedores.AutoSize = false;
            this.mnuFornecedores.Image = global::GestorOrquidario.App.Properties.Resources.provider;
            this.mnuFornecedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuFornecedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuFornecedores.Name = "mnuFornecedores";
            this.mnuFornecedores.Size = new System.Drawing.Size(128, 128);
            this.mnuFornecedores.Text = "Fornecedores";
            this.mnuFornecedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuFornecedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnuFornecedores.Click += new System.EventHandler(this.mnuSistemaFornecedores_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 131);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Image = global::GestorOrquidario.App.Properties.Resources.settings;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(128, 128);
            this.toolStripButton1.Text = "Configurações";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.mnuSistemaConfiguracoes_Click);
            // 
            // mnuBackup
            // 
            this.mnuBackup.AutoSize = false;
            this.mnuBackup.Image = global::GestorOrquidario.App.Properties.Resources.backup;
            this.mnuBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuBackup.Name = "mnuBackup";
            this.mnuBackup.Size = new System.Drawing.Size(128, 128);
            this.mnuBackup.Text = "Backup";
            this.mnuBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnuBackup.Click += new System.EventHandler(this.mnuSistemaBackup_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 131);
            // 
            // sspGestorOrquidario
            // 
            this.sspGestorOrquidario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtProduto,
            this.toolStripStatusLabel,
            this.txtVersao,
            this.toolStripStatusLabel2,
            this.txtDatabasePath});
            this.sspGestorOrquidario.Location = new System.Drawing.Point(0, 652);
            this.sspGestorOrquidario.Name = "sspGestorOrquidario";
            this.sspGestorOrquidario.Size = new System.Drawing.Size(1042, 22);
            this.sspGestorOrquidario.TabIndex = 2;
            this.sspGestorOrquidario.Text = "StatusStrip";
            // 
            // txtProduto
            // 
            this.txtProduto.AutoSize = false;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(200, 17);
            this.txtProduto.Text = "-";
            this.txtProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.AutoSize = false;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel.Text = "Versão:";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVersao
            // 
            this.txtVersao.AutoSize = false;
            this.txtVersao.Name = "txtVersao";
            this.txtVersao.Size = new System.Drawing.Size(120, 17);
            this.txtVersao.Text = "0.0.0.0";
            this.txtVersao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(70, 17);
            this.toolStripStatusLabel2.Text = "Database:";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDatabasePath
            // 
            this.txtDatabasePath.AutoSize = false;
            this.txtDatabasePath.Name = "txtDatabasePath";
            this.txtDatabasePath.Size = new System.Drawing.Size(400, 17);
            this.txtDatabasePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuSistema
            // 
            this.mnuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSistemaMinhasFlores,
            this.mnuManutencao,
            this.mnuSistemaRelatorio,
            this.mnuSistemaMeusDados,
            this.mnuSistemaFornecedores,
            this.toolStripMenuItem1,
            this.mnuSistemaConfiguracoes,
            this.mnuSistemaBackup,
            this.toolStripMenuItem2,
            this.mnuSistemaSair});
            this.mnuSistema.Name = "mnuSistema";
            this.mnuSistema.Size = new System.Drawing.Size(60, 20);
            this.mnuSistema.Text = "&Sistema";
            // 
            // mnuSistemaMinhasFlores
            // 
            this.mnuSistemaMinhasFlores.Image = global::GestorOrquidario.App.Properties.Resources.flower;
            this.mnuSistemaMinhasFlores.Name = "mnuSistemaMinhasFlores";
            this.mnuSistemaMinhasFlores.Size = new System.Drawing.Size(180, 22);
            this.mnuSistemaMinhasFlores.Text = "&Minhas flores...";
            this.mnuSistemaMinhasFlores.Click += new System.EventHandler(this.mnuSistemaMinhasFlores_Click);
            // 
            // mnuManutencao
            // 
            this.mnuManutencao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManutencaoGenero,
            this.mnuManutencaoSubstrato,
            this.mnuManutencaoFertilizante,
            this.mnuManutencaoUmidade,
            this.mnuManutencaoLuminosidade,
            this.mnuManutencaoFloracao,
            this.mnuManutencaoCrescimento,
            this.mnuManutencaoOrigem,
            this.mnuManutencaoTipo,
            this.mnuManutencaoHabitat,
            this.mnuManutencaoAdubacao});
            this.mnuManutencao.Name = "mnuManutencao";
            this.mnuManutencao.Size = new System.Drawing.Size(180, 22);
            this.mnuManutencao.Text = "M&anutenção";
            // 
            // mnuManutencaoGenero
            // 
            this.mnuManutencaoGenero.Name = "mnuManutencaoGenero";
            this.mnuManutencaoGenero.Size = new System.Drawing.Size(149, 22);
            this.mnuManutencaoGenero.Text = "&Gênero";
            this.mnuManutencaoGenero.Click += new System.EventHandler(this.mnuManutencaoGenero_Click);
            // 
            // mnuManutencaoSubstrato
            // 
            this.mnuManutencaoSubstrato.Name = "mnuManutencaoSubstrato";
            this.mnuManutencaoSubstrato.Size = new System.Drawing.Size(149, 22);
            this.mnuManutencaoSubstrato.Text = "&Substrato";
            this.mnuManutencaoSubstrato.Click += new System.EventHandler(this.mnuManutencaoSubstrato_Click);
            // 
            // mnuManutencaoFertilizante
            // 
            this.mnuManutencaoFertilizante.Name = "mnuManutencaoFertilizante";
            this.mnuManutencaoFertilizante.Size = new System.Drawing.Size(149, 22);
            this.mnuManutencaoFertilizante.Text = "&Fertilizante";
            this.mnuManutencaoFertilizante.Click += new System.EventHandler(this.mnuManutencaoFertilizante_Click);
            // 
            // mnuManutencaoUmidade
            // 
            this.mnuManutencaoUmidade.Name = "mnuManutencaoUmidade";
            this.mnuManutencaoUmidade.Size = new System.Drawing.Size(149, 22);
            this.mnuManutencaoUmidade.Text = "&Umidade";
            this.mnuManutencaoUmidade.Click += new System.EventHandler(this.mnuManutencaoUmidade_Click);
            // 
            // mnuManutencaoLuminosidade
            // 
            this.mnuManutencaoLuminosidade.Name = "mnuManutencaoLuminosidade";
            this.mnuManutencaoLuminosidade.Size = new System.Drawing.Size(149, 22);
            this.mnuManutencaoLuminosidade.Text = "&Luminosidade";
            this.mnuManutencaoLuminosidade.Click += new System.EventHandler(this.mnuManutencaoLuminosidade_Click);
            // 
            // mnuManutencaoFloracao
            // 
            this.mnuManutencaoFloracao.Name = "mnuManutencaoFloracao";
            this.mnuManutencaoFloracao.Size = new System.Drawing.Size(149, 22);
            this.mnuManutencaoFloracao.Text = "Flo&ração";
            this.mnuManutencaoFloracao.Click += new System.EventHandler(this.mnuManutencaoFloracao_Click);
            // 
            // mnuManutencaoCrescimento
            // 
            this.mnuManutencaoCrescimento.Name = "mnuManutencaoCrescimento";
            this.mnuManutencaoCrescimento.Size = new System.Drawing.Size(149, 22);
            this.mnuManutencaoCrescimento.Text = "&Crescimento";
            this.mnuManutencaoCrescimento.Click += new System.EventHandler(this.mnuManutencaoCrescimento_Click);
            // 
            // mnuManutencaoOrigem
            // 
            this.mnuManutencaoOrigem.Name = "mnuManutencaoOrigem";
            this.mnuManutencaoOrigem.Size = new System.Drawing.Size(149, 22);
            this.mnuManutencaoOrigem.Text = "&Origem";
            this.mnuManutencaoOrigem.Click += new System.EventHandler(this.mnuManutencaoOrigem_Click);
            // 
            // mnuManutencaoTipo
            // 
            this.mnuManutencaoTipo.Name = "mnuManutencaoTipo";
            this.mnuManutencaoTipo.Size = new System.Drawing.Size(149, 22);
            this.mnuManutencaoTipo.Text = "&Tipo";
            this.mnuManutencaoTipo.Click += new System.EventHandler(this.mnuManutencaoTipo_Click);
            // 
            // mnuManutencaoHabitat
            // 
            this.mnuManutencaoHabitat.Name = "mnuManutencaoHabitat";
            this.mnuManutencaoHabitat.Size = new System.Drawing.Size(149, 22);
            this.mnuManutencaoHabitat.Text = "&Habitat";
            this.mnuManutencaoHabitat.Click += new System.EventHandler(this.mnuManutencaoHabitat_Click);
            // 
            // mnuManutencaoAdubacao
            // 
            this.mnuManutencaoAdubacao.Name = "mnuManutencaoAdubacao";
            this.mnuManutencaoAdubacao.Size = new System.Drawing.Size(149, 22);
            this.mnuManutencaoAdubacao.Text = "&Adubação";
            this.mnuManutencaoAdubacao.Click += new System.EventHandler(this.mnuManutencaoAdubacao_Click);
            // 
            // mnuSistemaRelatorio
            // 
            this.mnuSistemaRelatorio.Image = global::GestorOrquidario.App.Properties.Resources.report;
            this.mnuSistemaRelatorio.Name = "mnuSistemaRelatorio";
            this.mnuSistemaRelatorio.Size = new System.Drawing.Size(180, 22);
            this.mnuSistemaRelatorio.Text = "&Relatório...";
            this.mnuSistemaRelatorio.Click += new System.EventHandler(this.mnuSistemaRelatorio_Click);
            // 
            // mnuSistemaMeusDados
            // 
            this.mnuSistemaMeusDados.Image = global::GestorOrquidario.App.Properties.Resources.profile;
            this.mnuSistemaMeusDados.Name = "mnuSistemaMeusDados";
            this.mnuSistemaMeusDados.Size = new System.Drawing.Size(180, 22);
            this.mnuSistemaMeusDados.Text = "Meus &Dados...";
            this.mnuSistemaMeusDados.Click += new System.EventHandler(this.mnuSistemaMeusDados_Click);
            // 
            // mnuSistemaFornecedores
            // 
            this.mnuSistemaFornecedores.Image = global::GestorOrquidario.App.Properties.Resources.provider;
            this.mnuSistemaFornecedores.Name = "mnuSistemaFornecedores";
            this.mnuSistemaFornecedores.Size = new System.Drawing.Size(180, 22);
            this.mnuSistemaFornecedores.Text = "&Fornecedores...";
            this.mnuSistemaFornecedores.Click += new System.EventHandler(this.mnuSistemaFornecedores_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuSistemaConfiguracoes
            // 
            this.mnuSistemaConfiguracoes.Image = global::GestorOrquidario.App.Properties.Resources.settings;
            this.mnuSistemaConfiguracoes.Name = "mnuSistemaConfiguracoes";
            this.mnuSistemaConfiguracoes.Size = new System.Drawing.Size(180, 22);
            this.mnuSistemaConfiguracoes.Text = "&Configurações...";
            this.mnuSistemaConfiguracoes.Click += new System.EventHandler(this.mnuSistemaConfiguracoes_Click);
            // 
            // mnuSistemaBackup
            // 
            this.mnuSistemaBackup.Image = global::GestorOrquidario.App.Properties.Resources.backup;
            this.mnuSistemaBackup.Name = "mnuSistemaBackup";
            this.mnuSistemaBackup.Size = new System.Drawing.Size(180, 22);
            this.mnuSistemaBackup.Text = "&Backup...";
            this.mnuSistemaBackup.Click += new System.EventHandler(this.mnuSistemaBackup_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuSistemaSair
            // 
            this.mnuSistemaSair.Image = global::GestorOrquidario.App.Properties.Resources.exit;
            this.mnuSistemaSair.Name = "mnuSistemaSair";
            this.mnuSistemaSair.Size = new System.Drawing.Size(180, 22);
            this.mnuSistemaSair.Text = "Sai&r";
            this.mnuSistemaSair.Click += new System.EventHandler(this.mnuSistemaSair_Click);
            // 
            // mnuAjuda
            // 
            this.mnuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSobre});
            this.mnuAjuda.Name = "mnuAjuda";
            this.mnuAjuda.Size = new System.Drawing.Size(50, 20);
            this.mnuAjuda.Text = "&Ajuda";
            // 
            // mnuSobre
            // 
            this.mnuSobre.Image = global::GestorOrquidario.App.Properties.Resources.about;
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(180, 22);
            this.mnuSobre.Text = "&Sobre...";
            this.mnuSobre.Click += new System.EventHandler(this.mnuSobre_Click);
            // 
            // mnuGestorOrquidario
            // 
            this.mnuGestorOrquidario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuGestorOrquidario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSistema,
            this.mnuAjuda});
            this.mnuGestorOrquidario.Location = new System.Drawing.Point(0, 0);
            this.mnuGestorOrquidario.Name = "mnuGestorOrquidario";
            this.mnuGestorOrquidario.Size = new System.Drawing.Size(1042, 24);
            this.mnuGestorOrquidario.TabIndex = 0;
            this.mnuGestorOrquidario.Text = "MenuStrip";
            // 
            // frmGestorOrquidario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1042, 674);
            this.Controls.Add(this.sspGestorOrquidario);
            this.Controls.Add(this.tspGestorOrquidario);
            this.Controls.Add(this.mnuGestorOrquidario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuGestorOrquidario;
            this.Name = "frmGestorOrquidario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: Gestor de Orquidário ::.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGestorOrquidario_FormClosing);
            this.Load += new System.EventHandler(this.frmGestorOrquidario_Load);
            this.tspGestorOrquidario.ResumeLayout(false);
            this.tspGestorOrquidario.PerformLayout();
            this.sspGestorOrquidario.ResumeLayout(false);
            this.sspGestorOrquidario.PerformLayout();
            this.mnuGestorOrquidario.ResumeLayout(false);
            this.mnuGestorOrquidario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip tspGestorOrquidario;
        private System.Windows.Forms.StatusStrip sspGestorOrquidario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripButton mnuMinhasFlores;
        private System.Windows.Forms.ToolStripButton mnuRelatorio;
        private System.Windows.Forms.ToolStripButton mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuSistema;
        private System.Windows.Forms.ToolStripMenuItem mnuSistemaMinhasFlores;
        private System.Windows.Forms.ToolStripMenuItem mnuSistemaRelatorio;
        private System.Windows.Forms.ToolStripMenuItem mnuManutencao;
        private System.Windows.Forms.ToolStripMenuItem mnuManutencaoGenero;
        private System.Windows.Forms.ToolStripMenuItem mnuManutencaoSubstrato;
        private System.Windows.Forms.ToolStripMenuItem mnuManutencaoFertilizante;
        private System.Windows.Forms.ToolStripMenuItem mnuManutencaoUmidade;
        private System.Windows.Forms.ToolStripMenuItem mnuManutencaoLuminosidade;
        private System.Windows.Forms.ToolStripMenuItem mnuManutencaoFloracao;
        private System.Windows.Forms.ToolStripMenuItem mnuManutencaoCrescimento;
        private System.Windows.Forms.ToolStripMenuItem mnuManutencaoOrigem;
        private System.Windows.Forms.ToolStripMenuItem mnuManutencaoTipo;
        private System.Windows.Forms.ToolStripMenuItem mnuManutencaoHabitat;
        private System.Windows.Forms.ToolStripMenuItem mnuManutencaoAdubacao;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSistemaMeusDados;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuSistemaSair;
        private System.Windows.Forms.ToolStripMenuItem mnuAjuda;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
        private System.Windows.Forms.MenuStrip mnuGestorOrquidario;
        private System.Windows.Forms.ToolStripMenuItem mnuSistemaFornecedores;
        private System.Windows.Forms.ToolStripStatusLabel txtVersao;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel txtDatabasePath;
        private System.Windows.Forms.ToolStripStatusLabel txtProduto;
        private System.Windows.Forms.ToolStripButton mnuMeusDados;
        private System.Windows.Forms.ToolStripButton mnuFornecedores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem mnuSistemaConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem mnuSistemaBackup;
        private System.Windows.Forms.ToolStripButton mnuBackup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}



