namespace ProGer
{
    partial class FormMenuCursos
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
            this.pbFundo = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbPesquisa = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.btnFiltros = new System.Windows.Forms.Button();
            this.btnNovoCurso = new System.Windows.Forms.Button();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.gbPerfil = new System.Windows.Forms.GroupBox();
            this.pnlPerfil = new System.Windows.Forms.Panel();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.chkDescricao = new System.Windows.Forms.CheckBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.chkNivel = new System.Windows.Forms.CheckBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.chkPreco = new System.Windows.Forms.CheckBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.chkNome = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.chkID = new System.Windows.Forms.CheckBox();
            this.chkSelecionarTodos = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.gbPerfil.SuspendLayout();
            this.pnlPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFundo
            // 
            this.pbFundo.BackColor = System.Drawing.Color.Goldenrod;
            this.pbFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFundo.Location = new System.Drawing.Point(0, 0);
            this.pbFundo.Name = "pbFundo";
            this.pbFundo.Size = new System.Drawing.Size(600, 500);
            this.pbFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFundo.TabIndex = 21;
            this.pbFundo.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(100, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 22;
            this.pbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Script", 70F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitulo.Location = new System.Drawing.Point(128, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(413, 157);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "ProGer";
            // 
            // gbPesquisa
            // 
            this.gbPesquisa.Controls.Add(this.txtPesquisa);
            this.gbPesquisa.Controls.Add(this.dgvResultados);
            this.gbPesquisa.Location = new System.Drawing.Point(12, 172);
            this.gbPesquisa.Name = "gbPesquisa";
            this.gbPesquisa.Size = new System.Drawing.Size(91, 316);
            this.gbPesquisa.TabIndex = 24;
            this.gbPesquisa.TabStop = false;
            this.gbPesquisa.Text = "Pesq. Curso";
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
            this.btnFiltros.TabIndex = 27;
            this.btnFiltros.Text = "Filtros";
            this.btnFiltros.UseVisualStyleBackColor = true;
            this.btnFiltros.Click += new System.EventHandler(this.btnFiltros_Click);
            // 
            // btnNovoCurso
            // 
            this.btnNovoCurso.Location = new System.Drawing.Point(109, 201);
            this.btnNovoCurso.Name = "btnNovoCurso";
            this.btnNovoCurso.Size = new System.Drawing.Size(75, 23);
            this.btnNovoCurso.TabIndex = 26;
            this.btnNovoCurso.Text = "Novo Curso";
            this.btnNovoCurso.UseVisualStyleBackColor = true;
            this.btnNovoCurso.Click += new System.EventHandler(this.btnNovoCurso_Click);
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.Location = new System.Drawing.Point(109, 172);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnLimparPesquisa.TabIndex = 25;
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
            this.gbPerfil.TabIndex = 28;
            this.gbPerfil.TabStop = false;
            this.gbPerfil.Text = "Perfil Curso";
            // 
            // pnlPerfil
            // 
            this.pnlPerfil.Controls.Add(this.cmbNivel);
            this.pnlPerfil.Controls.Add(this.txtDescricao);
            this.pnlPerfil.Controls.Add(this.lblDescricao);
            this.pnlPerfil.Controls.Add(this.chkDescricao);
            this.pnlPerfil.Controls.Add(this.lblNivel);
            this.pnlPerfil.Controls.Add(this.chkNivel);
            this.pnlPerfil.Controls.Add(this.txtPreco);
            this.pnlPerfil.Controls.Add(this.lblPreco);
            this.pnlPerfil.Controls.Add(this.chkPreco);
            this.pnlPerfil.Controls.Add(this.txtNome);
            this.pnlPerfil.Controls.Add(this.lblNome);
            this.pnlPerfil.Controls.Add(this.chkNome);
            this.pnlPerfil.Controls.Add(this.txtID);
            this.pnlPerfil.Controls.Add(this.lblID);
            this.pnlPerfil.Controls.Add(this.chkID);
            this.pnlPerfil.Location = new System.Drawing.Point(6, 19);
            this.pnlPerfil.Name = "pnlPerfil";
            this.pnlPerfil.Size = new System.Drawing.Size(377, 266);
            this.pnlPerfil.TabIndex = 39;
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Items.AddRange(new object[] {
            "Inicio",
            "Médio",
            "Avançado"});
            this.cmbNivel.Location = new System.Drawing.Point(74, 94);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(74, 21);
            this.cmbNivel.TabIndex = 23;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(97, 127);
            this.txtDescricao.MaxLength = 60;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(143, 45);
            this.txtDescricao.TabIndex = 22;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(33, 130);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 21;
            this.lblDescricao.Text = "Descrição:";
            // 
            // chkDescricao
            // 
            this.chkDescricao.AutoSize = true;
            this.chkDescricao.Location = new System.Drawing.Point(12, 130);
            this.chkDescricao.Name = "chkDescricao";
            this.chkDescricao.Size = new System.Drawing.Size(15, 14);
            this.chkDescricao.TabIndex = 20;
            this.chkDescricao.UseVisualStyleBackColor = true;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(33, 97);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(34, 13);
            this.lblNivel.TabIndex = 18;
            this.lblNivel.Text = "Nivel:";
            // 
            // chkNivel
            // 
            this.chkNivel.AutoSize = true;
            this.chkNivel.Location = new System.Drawing.Point(12, 97);
            this.chkNivel.Name = "chkNivel";
            this.chkNivel.Size = new System.Drawing.Size(15, 14);
            this.chkNivel.TabIndex = 17;
            this.chkNivel.UseVisualStyleBackColor = true;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(74, 65);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(74, 20);
            this.txtPreco.TabIndex = 16;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(33, 68);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 15;
            this.lblPreco.Text = "Preço:";
            // 
            // chkPreco
            // 
            this.chkPreco.AutoSize = true;
            this.chkPreco.Location = new System.Drawing.Point(12, 68);
            this.chkPreco.Name = "chkPreco";
            this.chkPreco.Size = new System.Drawing.Size(15, 14);
            this.chkPreco.TabIndex = 14;
            this.chkPreco.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(74, 20);
            this.txtNome.TabIndex = 13;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(33, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome:";
            // 
            // chkNome
            // 
            this.chkNome.AutoSize = true;
            this.chkNome.Location = new System.Drawing.Point(12, 39);
            this.chkNome.Name = "chkNome";
            this.chkNome.Size = new System.Drawing.Size(15, 14);
            this.chkNome.TabIndex = 11;
            this.chkNome.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(74, 7);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(74, 20);
            this.txtID.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(33, 10);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // chkID
            // 
            this.chkID.AutoSize = true;
            this.chkID.Location = new System.Drawing.Point(12, 10);
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
            // FormMenuCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.gbPerfil);
            this.Controls.Add(this.btnFiltros);
            this.Controls.Add(this.btnNovoCurso);
            this.Controls.Add(this.btnLimparPesquisa);
            this.Controls.Add(this.gbPesquisa);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuCursos";
            this.Text = "FormMenuCursos";
            this.Resize += new System.EventHandler(this.FormMenuCursos_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbPesquisa.ResumeLayout(false);
            this.gbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.gbPerfil.ResumeLayout(false);
            this.gbPerfil.PerformLayout();
            this.pnlPerfil.ResumeLayout(false);
            this.pnlPerfil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFundo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnFiltros;
        private System.Windows.Forms.Button btnNovoCurso;
        private System.Windows.Forms.Button btnLimparPesquisa;
        private System.Windows.Forms.GroupBox gbPerfil;
        private System.Windows.Forms.Panel pnlPerfil;
        private System.Windows.Forms.CheckBox chkSelecionarTodos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.CheckBox chkID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.CheckBox chkNome;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.CheckBox chkNivel;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.CheckBox chkPreco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.CheckBox chkDescricao;
        private System.Windows.Forms.ComboBox cmbNivel;
    }
}