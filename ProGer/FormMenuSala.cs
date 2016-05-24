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
    public partial class FormMenuSala : Form
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

        public FormMenuSala()
        {
            InitializeComponent();

            EstadoAtual = EstadoGrupo.Detalhes;

            #region Parent's
            lblTitulo.Parent = pbFundo;
            pbLogo.Parent = pbFundo;
            gbPesquisa.Parent = pbFundo;
            btnLimparPesquisa.Parent = pbFundo;
            btnNovaSala.Parent = pbFundo;
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

            chkCapacidade.Parent = pnlPerfil;
            lblCapacidade.Parent = pnlPerfil;
            cmbCapacidade.Parent = pnlPerfil;

            chkTelevisao.Parent = pnlPerfil;
            lblTelevisao.Parent = pnlPerfil;
            cmbTelevisao.Parent = pnlPerfil;

            chkComputador.Parent = pnlPerfil;
            lblComputador.Parent = pnlPerfil;
            cmbComputador.Parent = pnlPerfil;

            chkMesa.Parent = pnlPerfil;
            lblMesa.Parent = pnlPerfil;
            cmbMesa.Parent = pnlPerfil;

            chkCadeira.Parent = pnlPerfil;
            lblCadeira.Parent = pnlPerfil;
            cmbCadeira.Parent = pnlPerfil;

            chkLousa.Parent = pnlPerfil;
            lblLousa.Parent = pnlPerfil;
            cmbLousa.Parent = pnlPerfil;

            chkProjetor.Parent = pnlPerfil;
            lblProjetor.Parent = pnlPerfil;
            cmbProjetor.Parent = pnlPerfil;
            #endregion
        }

        void MudarEstadoDetalhes()
        {
            chkID.Visible = false;
            txtID.ReadOnly = true;

            chkCapacidade.Visible = false;
            cmbCapacidade.Enabled = false;

            chkTelevisao.Visible = false;
            cmbTelevisao.Enabled = false;

            chkComputador.Visible = false;
            cmbComputador.Enabled = false;

            chkMesa.Visible = false;
            cmbMesa.Enabled = false;

            chkCadeira.Visible = false;
            cmbCadeira.Enabled = false;

            chkLousa.Visible = false;
            cmbLousa.Enabled = false;

            chkProjetor.Visible = false;
            cmbProjetor.Enabled = false;

            chkSelecionarTodos.Visible = false;

            btnSalvar.Visible = false;

            btnCancelar.Visible = true;
            btnCancelar.Text = "Editar";
        }

        void MudarEstadoCadastrar()
        {
            chkID.Visible = false;
            txtID.ReadOnly = false;

            chkCapacidade.Visible = false;
            cmbCapacidade.Enabled = true;

            chkTelevisao.Visible = false;
            cmbTelevisao.Enabled = true;

            chkComputador.Visible = false;
            cmbComputador.Enabled = true;

            chkMesa.Visible = false;
            cmbMesa.Enabled = true;

            chkCadeira.Visible = false;
            cmbCadeira.Enabled = true;

            chkLousa.Visible = false;
            cmbLousa.Enabled = true;

            chkProjetor.Visible = false;
            cmbProjetor.Enabled = true;

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

            chkCapacidade.Visible = false;
            cmbCapacidade.Enabled = true;

            chkTelevisao.Visible = false;
            cmbTelevisao.Enabled = true;

            chkComputador.Visible = false;
            cmbComputador.Enabled = true;

            chkMesa.Visible = false;
            cmbMesa.Enabled = true;

            chkCadeira.Visible = false;
            cmbCadeira.Enabled = true;

            chkLousa.Visible = false;
            cmbLousa.Enabled = true;

            chkProjetor.Visible = false;
            cmbProjetor.Enabled = true;

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

            chkCapacidade.Visible = true;
            cmbCapacidade.Enabled = true;

            chkTelevisao.Visible = true;
            cmbTelevisao.Enabled = true;

            chkComputador.Visible = true;
            cmbComputador.Enabled = true;

            chkMesa.Visible = true;
            cmbMesa.Enabled = true;

            chkCadeira.Visible = true;
            cmbCadeira.Enabled = true;

            chkLousa.Visible = true;
            cmbLousa.Enabled = true;

            chkProjetor.Visible = true;
            cmbProjetor.Enabled = true;

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
            btnNovaSala.Location = new Point(
                btnLimparPesquisa.Location.X,
                btnLimparPesquisa.Location.Y + btnLimparPesquisa.Height + 5);
            #endregion

            #region btnFiltros
            btnFiltros.Location = new Point(
                btnNovaSala.Location.X,
                btnNovaSala.Location.Y + btnNovaSala.Height + 5);
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
                0);
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

            #region chkCapacidade
            chkCapacidade.Location = new Point(
                5,
                pnlPerfil.Height / 9 * 1);
            #endregion

            #region lblCapacidade
            lblCapacidade.Location = new Point(
                chkCapacidade.Location.X + chkCapacidade.Width,
                chkCapacidade.Location.Y);
            #endregion

            #region cmbCapacidade
            cmbCapacidade.Location = new Point(
                lblCapacidade.Location.X + lblCapacidade.Width,
                lblCapacidade.Location.Y - 3);
            #endregion

            #region chkTelevisao
            chkTelevisao.Location = new Point(
                5,
                pnlPerfil.Height / 9 * 2);
            #endregion

            #region lblTelevisao
            lblTelevisao.Location = new Point(
                chkTelevisao.Location.X + chkTelevisao.Width,
                chkTelevisao.Location.Y);
            #endregion

            #region cmbTelevisao
            cmbTelevisao.Location = new Point(
                lblTelevisao.Location.X + lblTelevisao.Width,
                lblTelevisao.Location.Y - 3);
            #endregion

            #region chkComputador
            chkComputador.Location = new Point(
                5,
                pnlPerfil.Height / 9 * 3);
            #endregion

            #region lblComputador
            lblComputador.Location = new Point(
                chkComputador.Location.X + chkComputador.Width,
                chkComputador.Location.Y);
            #endregion

            #region cmbComputador
            cmbComputador.Location = new Point(
                lblComputador.Location.X + lblComputador.Width,
                lblComputador.Location.Y - 3);
            #endregion

            #region chkMesa
            chkMesa.Location = new Point(
                5,
                pnlPerfil.Height / 9 * 4);
            #endregion

            #region lblMesa
            lblMesa.Location = new Point(
                chkMesa.Location.X + chkMesa.Width,
                chkMesa.Location.Y);
            #endregion

            #region cmbMesa
            cmbMesa.Location = new Point(
                lblMesa.Location.X + lblMesa.Width,
                lblMesa.Location.Y - 3);
            #endregion

            #region chkCadeira
            chkCadeira.Location = new Point(
                5,
                pnlPerfil.Height / 9 * 5);
            #endregion

            #region lblCadeira
            lblCadeira.Location = new Point(
                chkCadeira.Location.X + chkCadeira.Width,
                chkCadeira.Location.Y);
            #endregion

            #region cmbCadeira
            cmbCadeira.Location = new Point(
                lblCadeira.Location.X + lblCadeira.Width,
                lblCadeira.Location.Y - 3);
            #endregion

            #region chkLousa
            chkLousa.Location = new Point(
                5,
                pnlPerfil.Height / 9 * 6);
            #endregion

            #region lblLousa
            lblLousa.Location = new Point(
                chkLousa.Location.X + chkLousa.Width,
                chkLousa.Location.Y);
            #endregion

            #region cmbLousa
            cmbLousa.Location = new Point(
                lblLousa.Location.X + lblLousa.Width,
                lblLousa.Location.Y - 3);
            #endregion

            #region chkProjetor
            chkProjetor.Location = new Point(
                5,
                pnlPerfil.Height / 9 * 7);
            #endregion

            #region lblProjetor
            lblProjetor.Location = new Point(
                chkProjetor.Location.X + chkProjetor.Width,
                chkProjetor.Location.Y);
            #endregion

            #region cmbProjetor
            cmbProjetor.Location = new Point(
                lblProjetor.Location.X + lblProjetor.Width,
                lblProjetor.Location.Y - 3);
            #endregion
        }

        private void FormMenuSala_Load(object sender, EventArgs e)
        {
            MdiParent.Text = "ProGer - Salas";
        }

        private void FormMenuSala_Resize(object sender, EventArgs e)
        {
            RedimensionarControles();
        }

        private void btnNovaSala_Click(object sender, EventArgs e)
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
                    ClasseBancoSala.CadastrarSala(/*int.Parse(txtID.Text),*/ cmbCapacidade.Text, cmbTelevisao.Text, cmbComputador.Text, cmbMesa.Text, cmbCadeira.Text, cmbLousa.Text, cmbProjetor.Text);
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
            chkCapacidade.Checked = VF;
            chkTelevisao.Checked = VF;
            chkComputador.Checked = VF;
            chkMesa.Checked = VF;
            chkCadeira.Checked = VF;
            chkLousa.Checked = VF;
            chkProjetor.Checked = VF;
        }
    }
}

/*
 * ID INT
 * CAPACIDADE INT
 * TV INT
 * PC INT
 * MESA INT
 * CADEIRA INT
 * LOUSA INT
 * PROJETOR INT
     */
