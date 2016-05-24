namespace ProGer
{
    partial class FormPai
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnusMenu = new System.Windows.Forms.MenuStrip();
            this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telaCheiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnusMenu
            // 
            this.mnusMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarToolStripMenuItem,
            this.janelaToolStripMenuItem});
            this.mnusMenu.Location = new System.Drawing.Point(0, 0);
            this.mnusMenu.Name = "mnusMenu";
            this.mnusMenu.Size = new System.Drawing.Size(592, 24);
            this.mnusMenu.TabIndex = 1;
            this.mnusMenu.Text = "menuStrip1";
            // 
            // gerenciarToolStripMenuItem
            // 
            this.gerenciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.professoresToolStripMenuItem,
            this.salasToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.turmasToolStripMenuItem});
            this.gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            this.gerenciarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.gerenciarToolStripMenuItem.Text = "Gerenciar";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alunosToolStripMenuItem.Text = "Alunos...";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.professoresToolStripMenuItem.Text = "Professores...";
            this.professoresToolStripMenuItem.Click += new System.EventHandler(this.professoresToolStripMenuItem_Click);
            // 
            // salasToolStripMenuItem
            // 
            this.salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            this.salasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salasToolStripMenuItem.Text = "Salas...";
            this.salasToolStripMenuItem.Click += new System.EventHandler(this.salasToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cursosToolStripMenuItem.Text = "Cursos...";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // janelaToolStripMenuItem
            // 
            this.janelaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telaCheiaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            this.janelaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.janelaToolStripMenuItem.Text = "Janela";
            // 
            // telaCheiaToolStripMenuItem
            // 
            this.telaCheiaToolStripMenuItem.Name = "telaCheiaToolStripMenuItem";
            this.telaCheiaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.telaCheiaToolStripMenuItem.Text = "Tela Cheia";
            this.telaCheiaToolStripMenuItem.Click += new System.EventHandler(this.telaCheiaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.turmasToolStripMenuItem.Text = "Turmas...";
            this.turmasToolStripMenuItem.Click += new System.EventHandler(this.turmasToolStripMenuItem_Click);
            // 
            // FormPai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 473);
            this.Controls.Add(this.mnusMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnusMenu;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "FormPai";
            this.Text = "ProGer";
            this.mnusMenu.ResumeLayout(false);
            this.mnusMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnusMenu;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telaCheiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
    }
}

