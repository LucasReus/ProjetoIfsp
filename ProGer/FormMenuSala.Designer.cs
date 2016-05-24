namespace ProGer
{
    partial class FormMenuSala
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbPesquisa = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.btnFiltros = new System.Windows.Forms.Button();
            this.btnNovaSala = new System.Windows.Forms.Button();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.gbPerfil = new System.Windows.Forms.GroupBox();
            this.pnlPerfil = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbProjetor = new System.Windows.Forms.ComboBox();
            this.cmbLousa = new System.Windows.Forms.ComboBox();
            this.cmbCadeira = new System.Windows.Forms.ComboBox();
            this.cmbMesa = new System.Windows.Forms.ComboBox();
            this.cmbComputador = new System.Windows.Forms.ComboBox();
            this.cmbTelevisao = new System.Windows.Forms.ComboBox();
            this.cmbCapacidade = new System.Windows.Forms.ComboBox();
            this.lblMesa = new System.Windows.Forms.Label();
            this.lblProjetor = new System.Windows.Forms.Label();
            this.lblLousa = new System.Windows.Forms.Label();
            this.lblCadeira = new System.Windows.Forms.Label();
            this.lblTelevisao = new System.Windows.Forms.Label();
            this.lblComputador = new System.Windows.Forms.Label();
            this.lblCapacidade = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.chkProjetor = new System.Windows.Forms.CheckBox();
            this.chkComputador = new System.Windows.Forms.CheckBox();
            this.chkCadeira = new System.Windows.Forms.CheckBox();
            this.chkCapacidade = new System.Windows.Forms.CheckBox();
            this.chkLousa = new System.Windows.Forms.CheckBox();
            this.chkTelevisao = new System.Windows.Forms.CheckBox();
            this.chkMesa = new System.Windows.Forms.CheckBox();
            this.chkID = new System.Windows.Forms.CheckBox();
            this.chkSelecionarTodos = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pbFundo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.gbPerfil.SuspendLayout();
            this.pnlPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(100, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 9;
            this.pbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Script", 70F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitulo.Location = new System.Drawing.Point(137, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(413, 157);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "ProGer";
            // 
            // gbPesquisa
            // 
            this.gbPesquisa.Controls.Add(this.txtPesquisa);
            this.gbPesquisa.Controls.Add(this.dgvResultados);
            this.gbPesquisa.Location = new System.Drawing.Point(12, 172);
            this.gbPesquisa.Name = "gbPesquisa";
            this.gbPesquisa.Size = new System.Drawing.Size(91, 316);
            this.gbPesquisa.TabIndex = 15;
            this.gbPesquisa.TabStop = false;
            this.gbPesquisa.Text = "Pesq. Sala";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(7, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(74, 20);
            this.txtPesquisa.TabIndex = 9;
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(8, 45);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.Size = new System.Drawing.Size(73, 260);
            this.dgvResultados.TabIndex = 11;
            // 
            // btnFiltros
            // 
            this.btnFiltros.Location = new System.Drawing.Point(109, 230);
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(75, 23);
            this.btnFiltros.TabIndex = 18;
            this.btnFiltros.Text = "Filtros";
            this.btnFiltros.UseVisualStyleBackColor = true;
            this.btnFiltros.Click += new System.EventHandler(this.btnFiltros_Click);
            // 
            // btnNovaSala
            // 
            this.btnNovaSala.Location = new System.Drawing.Point(109, 201);
            this.btnNovaSala.Name = "btnNovaSala";
            this.btnNovaSala.Size = new System.Drawing.Size(75, 23);
            this.btnNovaSala.TabIndex = 17;
            this.btnNovaSala.Text = "Nova Sala";
            this.btnNovaSala.UseVisualStyleBackColor = true;
            this.btnNovaSala.Click += new System.EventHandler(this.btnNovaSala_Click);
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.Location = new System.Drawing.Point(109, 172);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnLimparPesquisa.TabIndex = 16;
            this.btnLimparPesquisa.Text = "Limpar Pesq";
            this.btnLimparPesquisa.UseVisualStyleBackColor = true;
            // 
            // gbPerfil
            // 
            this.gbPerfil.Controls.Add(this.pnlPerfil);
            this.gbPerfil.Controls.Add(this.chkSelecionarTodos);
            this.gbPerfil.Controls.Add(this.btnCancelar);
            this.gbPerfil.Controls.Add(this.btnSalvar);
            this.gbPerfil.Location = new System.Drawing.Point(190, 172);
            this.gbPerfil.Name = "gbPerfil";
            this.gbPerfil.Size = new System.Drawing.Size(389, 316);
            this.gbPerfil.TabIndex = 19;
            this.gbPerfil.TabStop = false;
            this.gbPerfil.Text = "Perfil Sala";
            // 
            // pnlPerfil
            // 
            this.pnlPerfil.AutoScroll = true;
            this.pnlPerfil.Controls.Add(this.txtID);
            this.pnlPerfil.Controls.Add(this.cmbProjetor);
            this.pnlPerfil.Controls.Add(this.cmbLousa);
            this.pnlPerfil.Controls.Add(this.cmbCadeira);
            this.pnlPerfil.Controls.Add(this.cmbMesa);
            this.pnlPerfil.Controls.Add(this.cmbComputador);
            this.pnlPerfil.Controls.Add(this.cmbTelevisao);
            this.pnlPerfil.Controls.Add(this.cmbCapacidade);
            this.pnlPerfil.Controls.Add(this.lblMesa);
            this.pnlPerfil.Controls.Add(this.lblProjetor);
            this.pnlPerfil.Controls.Add(this.lblLousa);
            this.pnlPerfil.Controls.Add(this.lblCadeira);
            this.pnlPerfil.Controls.Add(this.lblTelevisao);
            this.pnlPerfil.Controls.Add(this.lblComputador);
            this.pnlPerfil.Controls.Add(this.lblCapacidade);
            this.pnlPerfil.Controls.Add(this.lblID);
            this.pnlPerfil.Controls.Add(this.chkProjetor);
            this.pnlPerfil.Controls.Add(this.chkComputador);
            this.pnlPerfil.Controls.Add(this.chkCadeira);
            this.pnlPerfil.Controls.Add(this.chkCapacidade);
            this.pnlPerfil.Controls.Add(this.chkLousa);
            this.pnlPerfil.Controls.Add(this.chkTelevisao);
            this.pnlPerfil.Controls.Add(this.chkMesa);
            this.pnlPerfil.Controls.Add(this.chkID);
            this.pnlPerfil.Location = new System.Drawing.Point(6, 19);
            this.pnlPerfil.Name = "pnlPerfil";
            this.pnlPerfil.Size = new System.Drawing.Size(377, 266);
            this.pnlPerfil.TabIndex = 39;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(108, 7);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 3;
            // 
            // cmbProjetor
            // 
            this.cmbProjetor.FormattingEnabled = true;
            this.cmbProjetor.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.cmbProjetor.Location = new System.Drawing.Point(108, 232);
            this.cmbProjetor.Name = "cmbProjetor";
            this.cmbProjetor.Size = new System.Drawing.Size(37, 21);
            this.cmbProjetor.TabIndex = 2;
            this.cmbProjetor.Text = "00";
            // 
            // cmbLousa
            // 
            this.cmbLousa.FormattingEnabled = true;
            this.cmbLousa.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.cmbLousa.Location = new System.Drawing.Point(108, 198);
            this.cmbLousa.Name = "cmbLousa";
            this.cmbLousa.Size = new System.Drawing.Size(37, 21);
            this.cmbLousa.TabIndex = 2;
            this.cmbLousa.Text = "00";
            // 
            // cmbCadeira
            // 
            this.cmbCadeira.FormattingEnabled = true;
            this.cmbCadeira.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.cmbCadeira.Location = new System.Drawing.Point(108, 163);
            this.cmbCadeira.Name = "cmbCadeira";
            this.cmbCadeira.Size = new System.Drawing.Size(37, 21);
            this.cmbCadeira.TabIndex = 2;
            this.cmbCadeira.Text = "00";
            // 
            // cmbMesa
            // 
            this.cmbMesa.FormattingEnabled = true;
            this.cmbMesa.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.cmbMesa.Location = new System.Drawing.Point(108, 127);
            this.cmbMesa.Name = "cmbMesa";
            this.cmbMesa.Size = new System.Drawing.Size(37, 21);
            this.cmbMesa.TabIndex = 2;
            this.cmbMesa.Text = "00";
            // 
            // cmbComputador
            // 
            this.cmbComputador.FormattingEnabled = true;
            this.cmbComputador.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.cmbComputador.Location = new System.Drawing.Point(108, 94);
            this.cmbComputador.Name = "cmbComputador";
            this.cmbComputador.Size = new System.Drawing.Size(37, 21);
            this.cmbComputador.TabIndex = 2;
            this.cmbComputador.Text = "00";
            // 
            // cmbTelevisao
            // 
            this.cmbTelevisao.FormattingEnabled = true;
            this.cmbTelevisao.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.cmbTelevisao.Location = new System.Drawing.Point(108, 65);
            this.cmbTelevisao.Name = "cmbTelevisao";
            this.cmbTelevisao.Size = new System.Drawing.Size(37, 21);
            this.cmbTelevisao.TabIndex = 2;
            this.cmbTelevisao.Text = "00";
            // 
            // cmbCapacidade
            // 
            this.cmbCapacidade.FormattingEnabled = true;
            this.cmbCapacidade.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10"});
            this.cmbCapacidade.Location = new System.Drawing.Point(108, 37);
            this.cmbCapacidade.Name = "cmbCapacidade";
            this.cmbCapacidade.Size = new System.Drawing.Size(37, 21);
            this.cmbCapacidade.TabIndex = 2;
            this.cmbCapacidade.Text = "00";
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(34, 130);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(36, 13);
            this.lblMesa.TabIndex = 1;
            this.lblMesa.Text = "Mesa:";
            // 
            // lblProjetor
            // 
            this.lblProjetor.AutoSize = true;
            this.lblProjetor.Location = new System.Drawing.Point(34, 240);
            this.lblProjetor.Name = "lblProjetor";
            this.lblProjetor.Size = new System.Drawing.Size(46, 13);
            this.lblProjetor.TabIndex = 1;
            this.lblProjetor.Text = "Projetor:";
            // 
            // lblLousa
            // 
            this.lblLousa.AutoSize = true;
            this.lblLousa.Location = new System.Drawing.Point(34, 201);
            this.lblLousa.Name = "lblLousa";
            this.lblLousa.Size = new System.Drawing.Size(39, 13);
            this.lblLousa.TabIndex = 1;
            this.lblLousa.Text = "Lousa:";
            // 
            // lblCadeira
            // 
            this.lblCadeira.AutoSize = true;
            this.lblCadeira.Location = new System.Drawing.Point(34, 171);
            this.lblCadeira.Name = "lblCadeira";
            this.lblCadeira.Size = new System.Drawing.Size(46, 13);
            this.lblCadeira.TabIndex = 1;
            this.lblCadeira.Text = "Cadeira:";
            // 
            // lblTelevisao
            // 
            this.lblTelevisao.AutoSize = true;
            this.lblTelevisao.Location = new System.Drawing.Point(34, 68);
            this.lblTelevisao.Name = "lblTelevisao";
            this.lblTelevisao.Size = new System.Drawing.Size(56, 13);
            this.lblTelevisao.TabIndex = 1;
            this.lblTelevisao.Text = "Televisao:";
            // 
            // lblComputador
            // 
            this.lblComputador.AutoSize = true;
            this.lblComputador.Location = new System.Drawing.Point(34, 98);
            this.lblComputador.Name = "lblComputador";
            this.lblComputador.Size = new System.Drawing.Size(67, 13);
            this.lblComputador.TabIndex = 1;
            this.lblComputador.Text = "Computador:";
            // 
            // lblCapacidade
            // 
            this.lblCapacidade.AutoSize = true;
            this.lblCapacidade.Location = new System.Drawing.Point(34, 40);
            this.lblCapacidade.Name = "lblCapacidade";
            this.lblCapacidade.Size = new System.Drawing.Size(67, 13);
            this.lblCapacidade.TabIndex = 1;
            this.lblCapacidade.Text = "Capacidade:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(34, 11);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // chkProjetor
            // 
            this.chkProjetor.AutoSize = true;
            this.chkProjetor.Location = new System.Drawing.Point(13, 239);
            this.chkProjetor.Name = "chkProjetor";
            this.chkProjetor.Size = new System.Drawing.Size(15, 14);
            this.chkProjetor.TabIndex = 0;
            this.chkProjetor.UseVisualStyleBackColor = true;
            // 
            // chkComputador
            // 
            this.chkComputador.AutoSize = true;
            this.chkComputador.Location = new System.Drawing.Point(13, 97);
            this.chkComputador.Name = "chkComputador";
            this.chkComputador.Size = new System.Drawing.Size(15, 14);
            this.chkComputador.TabIndex = 0;
            this.chkComputador.UseVisualStyleBackColor = true;
            // 
            // chkCadeira
            // 
            this.chkCadeira.AutoSize = true;
            this.chkCadeira.Location = new System.Drawing.Point(13, 170);
            this.chkCadeira.Name = "chkCadeira";
            this.chkCadeira.Size = new System.Drawing.Size(15, 14);
            this.chkCadeira.TabIndex = 0;
            this.chkCadeira.UseVisualStyleBackColor = true;
            // 
            // chkCapacidade
            // 
            this.chkCapacidade.AutoSize = true;
            this.chkCapacidade.Location = new System.Drawing.Point(13, 39);
            this.chkCapacidade.Name = "chkCapacidade";
            this.chkCapacidade.Size = new System.Drawing.Size(15, 14);
            this.chkCapacidade.TabIndex = 0;
            this.chkCapacidade.UseVisualStyleBackColor = true;
            // 
            // chkLousa
            // 
            this.chkLousa.AutoSize = true;
            this.chkLousa.Location = new System.Drawing.Point(13, 201);
            this.chkLousa.Name = "chkLousa";
            this.chkLousa.Size = new System.Drawing.Size(15, 14);
            this.chkLousa.TabIndex = 0;
            this.chkLousa.UseVisualStyleBackColor = true;
            // 
            // chkTelevisao
            // 
            this.chkTelevisao.AutoSize = true;
            this.chkTelevisao.Location = new System.Drawing.Point(13, 68);
            this.chkTelevisao.Name = "chkTelevisao";
            this.chkTelevisao.Size = new System.Drawing.Size(15, 14);
            this.chkTelevisao.TabIndex = 0;
            this.chkTelevisao.UseVisualStyleBackColor = true;
            // 
            // chkMesa
            // 
            this.chkMesa.AutoSize = true;
            this.chkMesa.Location = new System.Drawing.Point(13, 130);
            this.chkMesa.Name = "chkMesa";
            this.chkMesa.Size = new System.Drawing.Size(15, 14);
            this.chkMesa.TabIndex = 0;
            this.chkMesa.UseVisualStyleBackColor = true;
            // 
            // chkID
            // 
            this.chkID.AutoSize = true;
            this.chkID.Location = new System.Drawing.Point(13, 10);
            this.chkID.Name = "chkID";
            this.chkID.Size = new System.Drawing.Size(15, 14);
            this.chkID.TabIndex = 0;
            this.chkID.UseVisualStyleBackColor = true;
            // 
            // chkSelecionarTodos
            // 
            this.chkSelecionarTodos.AutoSize = true;
            this.chkSelecionarTodos.Location = new System.Drawing.Point(114, 295);
            this.chkSelecionarTodos.Name = "chkSelecionarTodos";
            this.chkSelecionarTodos.Size = new System.Drawing.Size(109, 17);
            this.chkSelecionarTodos.TabIndex = 38;
            this.chkSelecionarTodos.Text = "Selecionar Todos";
            this.chkSelecionarTodos.UseVisualStyleBackColor = true;
            this.chkSelecionarTodos.CheckedChanged += new System.EventHandler(this.chkSelecionarTodos_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(311, 291);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(227, 291);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 37;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pbFundo
            // 
            this.pbFundo.BackColor = System.Drawing.Color.Brown;
            this.pbFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFundo.Location = new System.Drawing.Point(0, 0);
            this.pbFundo.Name = "pbFundo";
            this.pbFundo.Size = new System.Drawing.Size(600, 500);
            this.pbFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFundo.TabIndex = 20;
            this.pbFundo.TabStop = false;
            // 
            // FormMenuSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.gbPerfil);
            this.Controls.Add(this.btnFiltros);
            this.Controls.Add(this.btnNovaSala);
            this.Controls.Add(this.btnLimparPesquisa);
            this.Controls.Add(this.gbPesquisa);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuSala";
            this.Text = "FormMenuSala";
            this.Load += new System.EventHandler(this.FormMenuSala_Load);
            this.Resize += new System.EventHandler(this.FormMenuSala_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbPesquisa.ResumeLayout(false);
            this.gbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.gbPerfil.ResumeLayout(false);
            this.gbPerfil.PerformLayout();
            this.pnlPerfil.ResumeLayout(false);
            this.pnlPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnFiltros;
        private System.Windows.Forms.Button btnNovaSala;
        private System.Windows.Forms.Button btnLimparPesquisa;
        private System.Windows.Forms.GroupBox gbPerfil;
        private System.Windows.Forms.Panel pnlPerfil;
        private System.Windows.Forms.CheckBox chkSelecionarTodos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pbFundo;
        private System.Windows.Forms.CheckBox chkID;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblProjetor;
        private System.Windows.Forms.Label lblLousa;
        private System.Windows.Forms.Label lblCadeira;
        private System.Windows.Forms.Label lblTelevisao;
        private System.Windows.Forms.Label lblComputador;
        private System.Windows.Forms.Label lblCapacidade;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.CheckBox chkProjetor;
        private System.Windows.Forms.CheckBox chkComputador;
        private System.Windows.Forms.CheckBox chkCadeira;
        private System.Windows.Forms.CheckBox chkCapacidade;
        private System.Windows.Forms.CheckBox chkLousa;
        private System.Windows.Forms.CheckBox chkTelevisao;
        private System.Windows.Forms.CheckBox chkMesa;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbProjetor;
        private System.Windows.Forms.ComboBox cmbLousa;
        private System.Windows.Forms.ComboBox cmbCadeira;
        private System.Windows.Forms.ComboBox cmbMesa;
        private System.Windows.Forms.ComboBox cmbComputador;
        private System.Windows.Forms.ComboBox cmbTelevisao;
        private System.Windows.Forms.ComboBox cmbCapacidade;
    }
}