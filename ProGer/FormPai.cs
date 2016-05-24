using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProGer
{
    public partial class FormPai : Form
    {
        static bool TelaCheia = false;
        int Altura, Largura;
        Point Localizacao;

        public FormPai()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void telaCheiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCheia = !TelaCheia;

            if (TelaCheia)
            {
                Altura = this.Height;
                Largura = this.Width;
                Localizacao = this.Location;

                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }

            else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;

                this.Height = Altura;
                this.Width = Largura;
                this.Location = Localizacao;
            }
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormMenuAluno)
                return;

            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            FormMenuAluno Formulario = new FormMenuAluno();
            Formulario.MdiParent = this;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            Formulario.Show();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormMenuProfessor)
                return;

            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            FormMenuProfessor Formulario = new FormMenuProfessor();
            Formulario.MdiParent = this;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            Formulario.Show();
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormMenuSala)
                return;

            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            FormMenuSala Formulario = new FormMenuSala();
            Formulario.MdiParent = this;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            Formulario.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormMenuCursos)
                return;

            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            FormMenuCursos Formulario = new FormMenuCursos();
            Formulario.MdiParent = this;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            Formulario.Show();
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormMenuTurmas)
                return;

            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            FormMenuTurmas Formulario = new FormMenuTurmas();
            Formulario.MdiParent = this;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            Formulario.Show();
        }
    }
}
