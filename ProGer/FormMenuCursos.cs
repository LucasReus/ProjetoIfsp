using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProGer
{
    public partial class FormMenuCursos : Form
    {
        enum EstadoGrupo { Detalhes, Cadastrar, Editar, Filtrar };
        EstadoGrupo _estadoatual;
        EstadoGrupo EstadoAtual
        {
            get { return _estadoatual; }
            set
            {
                _estadoatual = value;

                switch (value)
                {
                    case EstadoGrupo.Detalhes:
                        MudarEstadoDetalhes();
                        return;

                    case EstadoGrupo.Cadastrar:
                        MudarEstadoCadastrar();
                        return;

                    case EstadoGrupo.Editar:
                        MudarEstadoEditar();
                        return;

                    case EstadoGrupo.Filtrar:
                        MudarEstadoFiltrar();
                        return;
                }
            }
        }

        public FormMenuCursos()
        {
            InitializeComponent();

            EstadoAtual = EstadoGrupo.Detalhes;

            #region Parent's
            lblTitulo.Parent = pbFundo;
            pbLogo.Parent = pbFundo;
            gbPesquisa.Parent = pbFundo;
            btnLimparPesquisa.Parent = pbFundo;
            btnNovoCurso.Parent = pbFundo;
            btnFiltros.Parent = pbFundo;
            gbPerfil.Parent = pbFundo;

            txtPesquisa.Parent = gbPesquisa;
            dgvResultados.Parent = gbPesquisa;

            pnlPerfil.Parent = gbPerfil;
            btnSalvar.Parent = gbPerfil;
            btnCancelar.Parent = gbPerfil;

            chkID.Parent = pnlPerfil;
            lblID.Parent = pnlPerfil;
            txtID.Parent = pnlPerfil;

            chkNome.Parent = pnlPerfil;
            lblNome.Parent = pnlPerfil;
            txtNome.Parent = pnlPerfil;

            chkPreco.Parent = pnlPerfil;
            lblPreco.Parent = pnlPerfil;
            txtPreco.Parent = pnlPerfil;

            chkNivel.Parent = pnlPerfil;
            lblNivel.Parent = pnlPerfil;
            cmbNivel.Parent = pnlPerfil;

            chkDescricao.Parent = pnlPerfil;
            lblDescricao.Parent = pnlPerfil;
            txtDescricao.Parent = pnlPerfil;
            #endregion
        }

        void MudarEstadoDetalhes()
        {
            chkID.Visible = false;
            txtID.ReadOnly = true;

            chkNome.Visible = false;
            txtNome.ReadOnly = true;

            chkPreco.Visible = false;
            txtPreco.ReadOnly = true;

            chkNivel.Visible = false;
            cmbNivel.Enabled = false;

            chkDescricao.Visible = false;
            txtDescricao.ReadOnly = true;

            chkSelecionarTodos.Visible = false;

            btnSalvar.Visible = false;

            btnCancelar.Visible = true;
            btnCancelar.Text = "Editar";
        }

        void MudarEstadoCadastrar()
        {
            chkID.Visible = false;
            txtID.ReadOnly = false;

            chkNome.Visible = false;
            txtNome.ReadOnly = false;

            chkPreco.Visible = false;
            txtPreco.ReadOnly = false;

            chkNivel.Visible = false;
            cmbNivel.Enabled = true;

            chkDescricao.Visible = false;
            txtDescricao.ReadOnly = false;

            chkSelecionarTodos.Visible = false;

            btnSalvar.Visible = true;
            btnSalvar.Text = "Cadastrar";

            btnCancelar.Visible = true;
            btnCancelar.Text = "Cancelar";
        }

        void MudarEstadoEditar()
        {
            chkID.Visible = false;
            txtID.ReadOnly = true;

            chkNome.Visible = false;
            txtNome.ReadOnly = false;

            chkPreco.Visible = false;
            txtPreco.ReadOnly = false;

            chkNivel.Visible = false;
            cmbNivel.Enabled = true;

            chkDescricao.Visible = false;
            txtDescricao.ReadOnly = false;

            chkSelecionarTodos.Visible = false;

            btnSalvar.Visible = true;
            btnSalvar.Text = "Salvar";

            btnCancelar.Visible = true;
            btnCancelar.Text = "Cancelar";
        }

        void MudarEstadoFiltrar()
        {
            chkID.Visible = true;
            txtID.ReadOnly = false;

            chkNome.Visible = true;
            txtNome.ReadOnly = false;

            chkPreco.Visible = true;
            txtPreco.ReadOnly = false;

            chkNivel.Visible = true;
            cmbNivel.Enabled = true;

            chkDescricao.Visible = true;
            txtDescricao.ReadOnly = false;

            chkSelecionarTodos.Visible = true;

            btnSalvar.Visible = true;
            btnSalvar.Text = "Filtrar";

            btnCancelar.Visible = true;
            btnCancelar.Text = "Cancelar";
        }

        void RedimensionarControles()
        {
            #region pbLogo
            pbLogo.Location = new Point(
                0, 0);
            #endregion

            #region lblTitulo
            lblTitulo.Location = new Point(
                pbFundo.Width / 2 - lblTitulo.Width / 2,
                -15);
            #endregion

            #region gbPesquisa
            gbPesquisa.Location = new Point(
                5,
                lblTitulo.Location.Y + lblTitulo.Height + 5);
            gbPesquisa.Size = new Size(
                pbFundo.Width / 3,
                pbFundo.Height - gbPesquisa.Location.Y - 5);
            #endregion

            #region txtPesquisa
            txtPesquisa.Location = new Point(
                5,
                15);
            txtPesquisa.Width = gbPesquisa.Width - txtPesquisa.Location.X - 5;
            #endregion

            #region dgvResultados
            dgvResultados.Location = new Point(
                txtPesquisa.Location.X,
                txtPesquisa.Location.Y + txtPesquisa.Height + 5);
            dgvResultados.Size = new System.Drawing.Size(
                txtPesquisa.Width,
                gbPesquisa.Height - dgvResultados.Location.Y - 5);
            #endregion

            #region btnLimparPesquisa
            btnLimparPesquisa.Location = new Point(
                gbPesquisa.Location.X + gbPesquisa.Width + 5,
                gbPesquisa.Location.Y + 15);
            #endregion

            #region btnNovaSala
            btnNovoCurso.Location = new Point(
                btnLimparPesquisa.Location.X,
                btnLimparPesquisa.Location.Y + btnLimparPesquisa.Height + 5);
            #endregion

            #region btnFiltros
            btnFiltros.Location = new Point(
                btnNovoCurso.Location.X,
                btnNovoCurso.Location.Y + btnNovoCurso.Height + 5);
            #endregion

            #region gbPerfil
            gbPerfil.Location = new Point(
                btnLimparPesquisa.Location.X + btnLimparPesquisa.Width + 5,
                gbPesquisa.Location.Y);
            gbPerfil.Size = new Size(
                pbFundo.Width - gbPerfil.Location.X - 5,
                pbFundo.Height - gbPerfil.Location.Y - 5);
            #endregion

            #region btnCancelar
            btnCancelar.Location = new Point(
                gbPerfil.Width - btnCancelar.Width - 5,
                gbPerfil.Height - btnCancelar.Height - 5);
            #endregion

            #region btnSalvar
            btnSalvar.Location = new Point(
                btnCancelar.Location.X - btnSalvar.Width - 5,
                btnCancelar.Location.Y);
            #endregion

            #region chkSelecionarTodos
            chkSelecionarTodos.Location = new Point(
                btnSalvar.Location.X - chkSelecionarTodos.Width,
                btnSalvar.Location.Y + 3);
            #endregion

            #region pnlPerfil
            pnlPerfil.Location = new Point(
                3,
                16);
            pnlPerfil.Size = new Size(
                gbPerfil.Width - pnlPerfil.Location.X - 3,
                gbPerfil.Height - pnlPerfil.Location.Y - btnCancelar.Height - 5 - 3);
            #endregion

            #region chkID
            chkID.Location = new Point(
                5,
                5);
            #endregion

            #region lblID
            lblID.Location = new Point(
                chkID.Location.X + chkID.Width,
                chkID.Location.Y);
            #endregion

            #region txtID
            txtID.Location = new Point(
                lblID.Location.X + lblID.Width,
                lblID.Location.Y - 3);
            #endregion

            #region chkNome
            chkNome.Location = new Point(
                chkID.Location.X,
                pnlPerfil.Height / 5 * 1);
            #endregion

            #region lblNome
            lblNome.Location = new Point(
                chkNome.Location.X + chkNome.Width,
                chkNome.Location.Y);
            #endregion

            #region txtNome
            txtNome.Location = new Point(
                lblNome.Location.X + lblNome.Width,
                lblNome.Location.Y);
            #endregion

            #region chkPreco
            chkPreco.Location = new Point(
                chkNome.Location.X,
                pnlPerfil.Height / 5 * 2);
            #endregion

            #region lblPreco
            lblPreco.Location = new Point(
                chkPreco.Location.X + chkPreco.Width,
                chkPreco.Location.Y);
            #endregion

            #region txtPreco
            txtPreco.Location = new Point(
                lblPreco.Location.X + lblPreco.Width,
                lblPreco.Location.Y - 3);
            #endregion

            #region chkNivel
            chkNivel.Location = new Point(
                chkPreco.Location.X,
                pnlPerfil.Height / 5 * 3);
            #endregion

            #region lblNivel
            lblNivel.Location = new Point(
                chkNivel.Location.X + chkNivel.Width,
                chkNivel.Location.Y);
            #endregion

            #region cmbNivel
            cmbNivel.Location = new Point(
                lblNivel.Location.X + lblNivel.Width,
                lblNivel.Location.Y - 3);
            #endregion

            #region chkDescricao
            chkDescricao.Location = new Point(
                chkNivel.Location.X,
                pnlPerfil.Height / 5 * 4);
            #endregion

            #region lblDescricao
            lblDescricao.Location = new Point(
                chkDescricao.Location.X + chkDescricao.Width,
                chkDescricao.Location.Y);
            #endregion

            #region txtDescricao
            txtDescricao.Location = new Point(
                lblDescricao.Location.X + lblDescricao.Width,
                lblDescricao.Location.Y - 3);
            #endregion
        }

        private void FormMenuCursos_Resize(object sender, EventArgs e)
        {
            RedimensionarControles();
        }

        private void btnNovoCurso_Click(object sender, EventArgs e)
        {
           
            EstadoAtual = EstadoGrupo.Cadastrar;
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            EstadoAtual = EstadoGrupo.Filtrar;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            switch (EstadoAtual)
            {
                case EstadoGrupo.Detalhes:
                    MessageBox.Show("Botão inacessivel no estado atual!");
                    return;

                case EstadoGrupo.Cadastrar:
                    ClasseBancoCurso.CadastarCurso(int.Parse(txtID.Text), txtNome.Text, txtPreco.Text, cmbNivel.Text, txtDescricao.Text);
                    //MessageBox.Show("Cadastrando...?");
                    return;

                case EstadoGrupo.Editar:
                    MessageBox.Show("Salvando alterações...?");
                    return;

                case EstadoGrupo.Filtrar:
                    MessageBox.Show("Filtrando dados inseridos...?");
                    return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            switch (EstadoAtual)
            {
                case EstadoGrupo.Detalhes:
                    EstadoAtual = EstadoGrupo.Editar;
                    return;

                case EstadoGrupo.Cadastrar:
                    EstadoAtual = EstadoGrupo.Detalhes;
                    return;

                case EstadoGrupo.Editar:
                    EstadoAtual = EstadoGrupo.Detalhes;
                    return;

                case EstadoGrupo.Filtrar:
                    EstadoAtual = EstadoGrupo.Detalhes;
                    return;
            }
        }

        private void chkSelecionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            bool VF = chkSelecionarTodos.Checked;

            chkSelecionarTodos.Text = (VF) ? "Desmarcar Todos" : "Selecionar Todos";
            
            RedimensionarControles();

            chkID.Checked = VF;
            chkNome.Checked = VF;
            chkPreco.Checked = VF;
            chkNivel.Checked = VF;
            chkDescricao.Checked = VF;
        }
    }
}

/*
 * ID
 * Nome
 * Preço
 * Nivel
 * Descrição
     */