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
    public partial class FormMenuProfessor : Form
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

        public FormMenuProfessor()
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

            pbFoto.Parent = pnlPerfil;
            btnCancelarImagem.Parent = pnlPerfil;

            chkID.Parent = pnlPerfil;
            lblID.Parent = pnlPerfil;
            txtID.Parent = pnlPerfil;

            chkAdmissao.Parent = pnlPerfil;
            lblAdmissao.Parent = pnlPerfil;
            dtpAdmissao.Parent = pnlPerfil;

            chkNomeProfessor.Parent = pnlPerfil;
            lblNomeProfessor.Parent = pnlPerfil;
            txtNomeProfessor.Parent = pnlPerfil;

            chkGraduacao.Parent = pnlPerfil;
            lblGraduacao.Parent = pnlPerfil;
            cmbGraduacao.Parent = pnlPerfil;

            chkAtivo.Parent = pnlPerfil;
            cmbAtivo.Parent = pnlPerfil;

            chkSexo.Parent = pnlPerfil;
            lblSexo.Parent = pnlPerfil;
            cmbSexo.Parent = pnlPerfil;

            chkDataNascimento.Parent = pnlPerfil;
            lblDataNascimento.Parent = pnlPerfil;
            dtpDataNascimento.Parent = pnlPerfil;

            chkFilhos.Parent = pnlPerfil;
            lblFilhos.Parent = pnlPerfil;
            cmbFilhos.Parent = pnlPerfil;

            chkRG.Parent = pnlPerfil;
            lblRG.Parent = pnlPerfil;
            mtxtRG.Parent = pnlPerfil;

            chkCPF.Parent = pnlPerfil;
            lblCPF.Parent = pnlPerfil;
            mtxtCPF.Parent = pnlPerfil;

            chkCTPS.Parent = pnlPerfil;
            lblCTPS.Parent = pnlPerfil;
            mtxtCTPS.Parent = pnlPerfil;

            chkEstadoCivil.Parent = pnlPerfil;
            lblEstadoCivil.Parent = pnlPerfil;
            cmbEstadoCivil.Parent = pnlPerfil;

            chkLogradouro.Parent = pnlPerfil;
            lblLogradouro.Parent = pnlPerfil;
            txtLogradouro.Parent = pnlPerfil;

            chkNumeroLogradouro.Parent = pnlPerfil;
            lblNumeroLogradouro.Parent = pnlPerfil;
            txtNumeroLogradouro.Parent = pnlPerfil;

            chkBairro.Parent = pnlPerfil;
            lblBairro.Parent = pnlPerfil;
            txtBairro.Parent = pnlPerfil;

            chkCEP.Parent = pnlPerfil;
            lblCEP.Parent = pnlPerfil;
            mtxtCEP.Parent = pnlPerfil;

            chkCidade.Parent = pnlPerfil;
            lblCidade.Parent = pnlPerfil;
            txtCidade.Parent = pnlPerfil;
            #endregion
        }

        void MudarEstadoDetalhes()
        {
            chkSelecionarTodos.Visible = false;

            btnSalvar.Visible = false;

            btnCancelar.Visible = true;
            btnCancelar.Text = "Editar";
        }

        void MudarEstadoCadastrar()
        {
            chkSelecionarTodos.Visible = false;

            btnSalvar.Visible = true;
            btnSalvar.Text = "Cadastrar";

            btnCancelar.Visible = true;
            btnCancelar.Text = "Cancelar";
        }

        void MudarEstadoEditar()
        {
            chkSelecionarTodos.Visible = false;

            btnSalvar.Visible = true;
            btnSalvar.Text = "Salvar";

            btnCancelar.Visible = true;
            btnCancelar.Text = "Cancelar";
        }

        void MudarEstadoFiltrar()
        {
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

            #region btnNovoAluno
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

            #region pbFoto
            pbFoto.Location = new Point(
                5, 0);
            pbFoto.Size = new Size(
                btnCancelarImagem.Width + 15,
                100);
            #endregion

            #region btnCancelarImagem
            btnCancelarImagem.Location = new Point(
                pbFoto.Location.X + pbFoto.Width / 2 - btnCancelarImagem.Width / 2,
                pbFoto.Location.Y + pbFoto.Height + 5);
            #endregion

            #region chkID
            chkID.Location = new Point(
                pbFoto.Location.X + pbFoto.Width + 5,
                pbFoto.Location.Y + 5);
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

            #region chkAdmissao
            chkAdmissao.Location = new Point(
                txtID.Location.X + txtID.Width + 5,
                txtID.Location.Y + 3);
            #endregion

            #region lblAdmissao
            lblAdmissao.Location = new Point(
                chkAdmissao.Location.X + chkAdmissao.Width,
                chkAdmissao.Location.Y);
            #endregion

            #region dtpAdmissao
            dtpAdmissao.Location = new Point(
                lblAdmissao.Location.X + lblAdmissao.Width,
                lblAdmissao.Location.Y - 3);
            #endregion

            #region chkNomeProfessor
            chkNomeProfessor.Location = new Point(
                chkID.Location.X,
                chkID.Location.Y + chkID.Height + 10);
            #endregion

            #region lblNomeProfessor
            lblNomeProfessor.Location = new Point(
                chkNomeProfessor.Location.X + chkNomeProfessor.Width,
                chkNomeProfessor.Location.Y);
            #endregion

            #region txtNomeProfessor
            txtNomeProfessor.Location = new Point(
                lblNomeProfessor.Location.X + lblNomeProfessor.Width,
                lblNomeProfessor.Location.Y - 3);
            #endregion

            #region chkGraduacao
            chkGraduacao.Location = new Point(
                chkNomeProfessor.Location.X,
                chkNomeProfessor.Location.Y + chkNomeProfessor.Height + 10);
            #endregion

            #region lblGraduacao
            lblGraduacao.Location = new Point(
                chkGraduacao.Location.X + chkGraduacao.Width,
                chkGraduacao.Location.Y);
            #endregion

            #region cmbGraduacao
            cmbGraduacao.Location = new Point(
                lblGraduacao.Location.X + lblGraduacao.Width,
                lblGraduacao.Location.Y - 3);
            #endregion

            #region chkAtivo
            chkAtivo.Location = new Point(
                cmbGraduacao.Location.X + cmbGraduacao.Width + 5,
                cmbGraduacao.Location.Y + 3);
            #endregion

            #region cmbAtivo
            cmbAtivo.Location = new Point(
                chkAtivo.Location.X + chkAtivo.Width,
                chkAtivo.Location.Y - 3);
            #endregion

            #region chkSexo
            chkSexo.Location = new Point(
                chkGraduacao.Location.X,
                chkGraduacao.Location.Y + chkGraduacao.Height + 10);
            #endregion

            #region lblSexo
            lblSexo.Location = new Point(
                chkSexo.Location.X + chkSexo.Width,
                chkSexo.Location.Y);
            #endregion

            #region cmbSexo
            cmbSexo.Location = new Point(
                lblSexo.Location.X + lblSexo.Width,
                lblSexo.Location.Y - 3);
            #endregion

            #region chkDataNascimento
            chkDataNascimento.Location = new Point(
                cmbSexo.Location.X + cmbSexo.Width + 5,
                cmbSexo.Location.Y + 3);
            #endregion

            #region lblDataNascimento
            lblDataNascimento.Location = new Point(
                chkDataNascimento.Location.X + chkDataNascimento.Width,
                chkDataNascimento.Location.Y);
            #endregion

            #region dtpDataNascimento
            dtpDataNascimento.Location = new Point(
                lblDataNascimento.Location.X + lblDataNascimento.Width,
                lblDataNascimento.Location.Y - 3);
            #endregion

            #region chkFilhos
            chkFilhos.Location = new Point(
                chkSexo.Location.X,
                chkSexo.Location.Y + chkSexo.Height + 10);
            #endregion

            #region lblFilhos
            lblFilhos.Location = new Point(
                chkFilhos.Location.X + chkFilhos.Width,
                chkFilhos.Location.Y);
            #endregion

            #region cmbFilhos
            cmbFilhos.Location = new Point(
                lblFilhos.Location.X + lblFilhos.Width,
                lblFilhos.Location.Y - 3);
            #endregion

            #region chkRG
            chkRG.Location = new Point(
                btnCancelarImagem.Location.X - 5,
                btnCancelarImagem.Location.Y + btnCancelarImagem.Height + 10);
            #endregion

            #region lblRG
            lblRG.Location = new Point(
                chkRG.Location.X + chkRG.Width,
                chkRG.Location.Y);
            #endregion

            #region mtxtRG
            mtxtRG.Location = new Point(
                lblRG.Location.X + lblRG.Width,
                lblRG.Location.Y - 3);
            #endregion

            #region chkCPF
            chkCPF.Location = new Point(
                mtxtRG.Location.X + mtxtRG.Width + 5,
                mtxtRG.Location.Y + 3);
            #endregion

            #region lblCPF
            lblCPF.Location = new Point(
                chkCPF.Location.X + chkCPF.Width,
                chkCPF.Location.Y);
            #endregion

            #region mtxtCPF
            mtxtCPF.Location = new Point(
                lblCPF.Location.X + lblCPF.Width,
                lblCPF.Location.Y - 3);
            #endregion

            #region chkCTPS
            chkCTPS.Location = new Point(
                mtxtCPF.Location.X + mtxtCPF.Width + 5,
                mtxtCPF.Location.Y + 3);
            #endregion

            #region lblCTPS
            lblCTPS.Location = new Point(
                chkCTPS.Location.X + chkCTPS.Width,
                chkCTPS.Location.Y);
            #endregion

            #region mtxtCTPS
            mtxtCTPS.Location = new Point(
                lblCTPS.Location.X + lblCTPS.Width,
                lblCTPS.Location.Y - 3);
            #endregion

            #region chkEstadoCivil
            chkEstadoCivil.Location = new Point(
                chkRG.Location.X,
                chkRG.Location.Y + chkRG.Height + 10);
            #endregion

            #region lblEstadoCivil
            lblEstadoCivil.Location = new Point(
                chkEstadoCivil.Location.X + chkEstadoCivil.Width,
                chkEstadoCivil.Location.Y);
            #endregion

            #region cmbEstadoCivil
            cmbEstadoCivil.Location = new Point(
                lblEstadoCivil.Location.X + lblEstadoCivil.Width,
                lblEstadoCivil.Location.Y - 3);
            #endregion

            #region chkLogradouro
            chkLogradouro.Location = new Point(
                chkEstadoCivil.Location.X,
                chkEstadoCivil.Location.Y + chkEstadoCivil.Height + 10);
            #endregion

            #region lblLogradouro
            lblLogradouro.Location = new Point(
                chkLogradouro.Location.X + chkLogradouro.Width,
                chkLogradouro.Location.Y);
            #endregion

            #region txtLogradouro
            txtLogradouro.Location = new Point(
                lblLogradouro.Location.X + lblLogradouro.Width,
                lblLogradouro.Location.Y - 3);
            #endregion

            #region chkNumeroLogradouro
            chkNumeroLogradouro.Location = new Point(
                txtLogradouro.Location.X + txtLogradouro.Width + 5,
                txtLogradouro.Location.Y + 3);
            #endregion

            #region lblNumeroLogradouro
            lblNumeroLogradouro.Location = new Point(
                chkNumeroLogradouro.Location.X + chkNumeroLogradouro.Width,
                chkNumeroLogradouro.Location.Y);
            #endregion

            #region txtNumeroLogradouro
            txtNumeroLogradouro.Location = new Point(
                lblNumeroLogradouro.Location.X + lblNumeroLogradouro.Width,
                lblNumeroLogradouro.Location.Y - 3);
            #endregion

            #region chkBairro
            chkBairro.Location = new Point(
                chkLogradouro.Location.X,
                chkLogradouro.Location.Y + chkLogradouro.Height + 10);
            #endregion

            #region lblBairro
            lblBairro.Location = new Point(
                chkBairro.Location.X + chkBairro.Width,
                chkBairro.Location.Y);
            #endregion

            #region txtBairro
            txtBairro.Location = new Point(
                lblBairro.Location.X + lblBairro.Width,
                lblBairro.Location.Y - 3);
            #endregion

            #region chkCEP
            chkCEP.Location = new Point(
                chkBairro.Location.X,
                chkBairro.Location.Y + chkBairro.Height + 10);
            #endregion

            #region lblCEP
            lblCEP.Location = new Point(
                chkCEP.Location.X + chkCEP.Width,
                chkCEP.Location.Y);
            #endregion

            #region mtxtCEP
            mtxtCEP.Location = new Point(
                lblCEP.Location.X + lblCEP.Width,
                lblCEP.Location.Y - 3);
            #endregion

            #region chkCidade
            chkCidade.Location = new Point(
                mtxtCEP.Location.X + mtxtCEP.Width + 5,
                mtxtCEP.Location.Y + 3);
            #endregion

            #region lblCidade
            lblCidade.Location = new Point(
                chkCidade.Location.X + chkCidade.Width,
                chkCidade.Location.Y);
            #endregion

            #region txtCidade
            txtCidade.Location = new Point(
                lblCidade.Location.X + lblCidade.Width,
                lblCidade.Location.Y - 3);
            #endregion
        }

        private void FormMenuProfessor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projetoEscolaIdiomaTesteDataSet1.TabProjetoProfessor' table. You can move, or remove it, as needed.
            this.tabProjetoProfessorTableAdapter.Fill(this.projetoEscolaIdiomaTesteDataSet1.TabProjetoProfessor);
            MdiParent.Text = "ProoGer - Professores";
        }

        private void FormMenuProfessor_Resize(object sender, EventArgs e)
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
                    ClasseBancoProfessor.CadastrarProfessor(txtNomeProfessor.Text,mtxtCPF.Text,mtxtRG.Text,mtxtCTPS.Text,cmbSexo.Text,
                        cmbEstadoCivil.Text,dtpDataNascimento.Text,cmbFilhos.Text,txtLogradouro.Text,txtBairro.Text,txtCidade.Text,
                        mtxtCEP.Text, txtNumeroLogradouro.Text,dtpAdmissao.Text,cmbGraduacao.Text,cmbAtivo.Text);
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
        }
    }
}

/*
 * ID
 * NOME
 * CPF
 * RG
 * CTPS
 * SEXO
 * ESTADO CIVIL
 * DATA NASCIMENTO
 * FILHOS
 * LOGRADOURO
 * NUMERO LOGRADOURO
 * BAIRRO
 * CIDADE
 * CEP
 * ADMISSAO
 * GRADUACAO
 * STATUS
 * FOTO
     */