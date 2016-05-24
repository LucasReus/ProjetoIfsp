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
    public partial class FormMenuAluno : Form
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

        public FormMenuAluno()
        {
            InitializeComponent();

            EstadoAtual = EstadoGrupo.Detalhes;

            #region Parent's
            lblTitulo.Parent = pbFundo;
            pbLogo.Parent = pbFundo;
            gbPesquisa.Parent = pbFundo;
            btnLimparPesquisa.Parent = pbFundo;
            btnNovoAluno.Parent = pbFundo;
            btnFiltros.Parent = pbFundo;
            gbPerfil.Parent = pbFundo;

            txtPesquisa.Parent = gbPesquisa;
            dgvResultados.Parent = gbPesquisa;

            pnlPerfil.Parent = gbPerfil;
            btnSalvar.Parent = gbPerfil;
            btnCancelar.Parent = gbPerfil;

            lblMatricula.Parent = pnlPerfil;
            txtMatricula.Parent = pnlPerfil;
            lblInicio.Parent = pnlPerfil;
            dtpMatriculaInicio.Parent = pnlPerfil;
            lblFim.Parent = pnlPerfil;
            lblNomeAluno.Parent = pnlPerfil;
            lblNomePai.Parent = pnlPerfil;
            lblNomeMae.Parent = pnlPerfil;
            lblRG.Parent = pnlPerfil;
            mtxtRG.Parent = pnlPerfil;
            lblCPF.Parent = pnlPerfil;
            mtxtCPF.Parent = pnlPerfil;
            lblSexo.Parent = pnlPerfil;
            lblDataNascimento.Parent = pnlPerfil;
            dtpDataNascimento.Parent = pnlPerfil;
            lblLogradouro.Parent = pnlPerfil;
            txtLogradouro.Parent = pnlPerfil;
            lblNumeroLogradouro.Parent = pnlPerfil;
            txtNumeroLogradouro.Parent = pnlPerfil;
            lblBairro.Parent = pnlPerfil;
            txtBairro.Parent = pnlPerfil;
            lblCidade.Parent = pnlPerfil;
            txtCidade.Parent = pnlPerfil;
            lblCEP.Parent = pnlPerfil;
            mtxtCEP.Parent = pnlPerfil;
            lblTurma.Parent = pnlPerfil;
            cmbTurma.Parent = pnlPerfil;
            lblEmail.Parent = pnlPerfil;
            txtEmail.Parent = pnlPerfil;
            pbFoto.Parent = pnlPerfil;
            btnCancelarImagem.Parent = pnlPerfil;
            #endregion

            #region TabIndex's
            txtMatricula.TabIndex = 0;
            dtpMatriculaInicio.TabIndex = 1;
            dtpMatriculaFim.TabIndex = 2;
            txtNomeAluno.TabIndex = 3;
            cmbTurma.TabIndex = 4;
            cmbAtivo.TabIndex = 5;
            txtEmail.TabIndex = 6;
            cmbSexo.TabIndex = 7;
            dtpDataNascimento.TabIndex = 8;
            mtxtRG.TabIndex = 9;
            mtxtCPF.TabIndex = 10;
            txtLogradouro.TabIndex = 11;
            txtNumeroLogradouro.TabIndex = 12;
            txtBairro.TabIndex = 13;
            mtxtCEP.TabIndex = 14;
            txtCidade.TabIndex = 15;
            txtNomePai.TabIndex = 16;
            txtNomeMae.TabIndex = 17;
            #endregion
        }

        void MudarEstadoDetalhes()
        {
            pbFoto.Image = null;
            pbFoto.Enabled = false;

            btnCancelarImagem.Enabled = false;

            chkMatricula.Visible = false;
            txtMatricula.ReadOnly = true;

            chkInicio.Visible = false;
            dtpMatriculaInicio.Enabled = false;

            chkFim.Visible = false;
            dtpMatriculaFim.Enabled = false;

            chkNomeAluno.Visible = false;
            txtNomeAluno.ReadOnly = true;

            chkTurma.Visible = false;
            cmbTurma.Enabled = false;

            chkAtivo.Visible = false;
            cmbAtivo.Enabled = false;

            chkEmail.Visible = false;
            txtEmail.ReadOnly = true;

            chkSexo.Visible = false;
            cmbSexo.Enabled = false;

            chkDataNascimento.Visible = false;
            dtpDataNascimento.Enabled = false;

            chkRG.Visible = false;
            mtxtRG.ReadOnly = true;

            chkCPF.Visible = false;
            mtxtCPF.ReadOnly = true;

            chkLogradouro.Visible = false;
            txtLogradouro.ReadOnly = true;

            chkNumeroLogradouro.Visible = false;
            txtNumeroLogradouro.ReadOnly = true;

            chkBairro.Visible = false;
            txtBairro.ReadOnly = true;

            chkCEP.Visible = false;
            mtxtCEP.ReadOnly = true;

            chkCidade.Visible = false;
            txtCidade.ReadOnly = true;

            chkNomePai.Visible = false;
            txtNomePai.ReadOnly = true;

            chkNomeMae.Visible = false;
            txtNomeMae.ReadOnly = true;

            chkSelecionarTodos.Visible = false;

            btnSalvar.Visible = false;

            btnCancelar.Visible = true;
            btnCancelar.Text = "Editar";
        }

        void MudarEstadoCadastrar()
        {
            pbFoto.Image = null;
            pbFoto.Enabled = true;

            btnCancelarImagem.Enabled = true;

            chkMatricula.Visible = false;
            txtMatricula.ReadOnly = false;

            chkInicio.Visible = false;
            dtpMatriculaInicio.Enabled = true;

            chkFim.Visible = false;
            dtpMatriculaFim.Enabled = true;

            chkNomeAluno.Visible = false;
            txtNomeAluno.ReadOnly = false;

            chkTurma.Visible = false;
            cmbTurma.Enabled = true;

            chkAtivo.Visible = false;
            cmbAtivo.Enabled = true;

            chkEmail.Visible = false;
            txtEmail.ReadOnly = false;

            chkSexo.Visible = false;
            cmbSexo.Enabled = true;

            chkDataNascimento.Visible = false;
            dtpDataNascimento.Enabled = true;

            chkRG.Visible = false;
            mtxtRG.ReadOnly = false;

            chkCPF.Visible = false;
            mtxtCPF.ReadOnly = false;

            chkLogradouro.Visible = false;
            txtLogradouro.ReadOnly = false;

            chkNumeroLogradouro.Visible = false;
            txtNumeroLogradouro.ReadOnly = false;

            chkBairro.Visible = false;
            txtBairro.ReadOnly = false;

            chkCEP.Visible = false;
            mtxtCEP.ReadOnly = false;

            chkCidade.Visible = false;
            txtCidade.ReadOnly = false;

            chkNomePai.Visible = false;
            txtNomePai.ReadOnly = false;

            chkNomeMae.Visible = false;
            txtNomeMae.ReadOnly = false;

            chkSelecionarTodos.Visible = false;
            
            btnSalvar.Visible = true;
            btnSalvar.Text = "Cadastrar";

            btnCancelar.Visible = true;
            btnCancelar.Text = "Cancelar";
        }

        void MudarEstadoEditar()
        {
            pbFoto.Enabled = true;

            btnCancelarImagem.Enabled = true;

            chkMatricula.Visible = false;
            txtMatricula.ReadOnly = false;

            chkInicio.Visible = false;
            dtpMatriculaInicio.Enabled = false;

            chkFim.Visible = false;
            dtpMatriculaFim.Enabled = true;

            chkNomeAluno.Visible = false;
            txtNomeAluno.ReadOnly = false;

            chkTurma.Visible = false;
            cmbTurma.Enabled = true;

            chkAtivo.Visible = false;
            cmbAtivo.Enabled = true;

            chkEmail.Visible = false;
            txtEmail.ReadOnly = false;

            chkSexo.Visible = false;
            cmbSexo.Enabled = true;

            chkDataNascimento.Visible = false;
            dtpDataNascimento.Enabled = true;

            chkRG.Visible = false;
            mtxtRG.ReadOnly = false;

            chkCPF.Visible = false;
            mtxtCPF.ReadOnly = false;

            chkLogradouro.Visible = false;
            txtLogradouro.ReadOnly = false;

            chkNumeroLogradouro.Visible = false;
            txtNumeroLogradouro.ReadOnly = false;

            chkBairro.Visible = false;
            txtBairro.ReadOnly = false;

            chkCEP.Visible = false;
            mtxtCEP.ReadOnly = false;

            chkCidade.Visible = false;
            txtCidade.ReadOnly = false;

            chkNomePai.Visible = false;
            txtNomePai.ReadOnly = false;

            chkNomeMae.Visible = false;
            txtNomeMae.ReadOnly = false;

            chkSelecionarTodos.Visible = false;
            
            btnSalvar.Visible = true;
            btnSalvar.Text = "Salvar";

            btnCancelar.Visible = true;
            btnCancelar.Text = "Cancelar";
        }

        void MudarEstadoFiltrar()
        {
            pbFoto.Image = null;
            pbFoto.Enabled = false;

            btnCancelarImagem.Enabled = false;

            chkMatricula.Visible = true;
            txtMatricula.ReadOnly = false;

            chkInicio.Visible = true;
            dtpMatriculaInicio.Enabled = true;

            chkFim.Visible = true;
            dtpMatriculaFim.Enabled = true;

            chkNomeAluno.Visible = true;
            txtNomeAluno.ReadOnly = false;

            chkTurma.Visible = true;
            cmbTurma.Enabled = true;

            chkAtivo.Visible = true;
            cmbAtivo.Enabled = true;

            chkEmail.Visible = true;
            txtEmail.ReadOnly = false;

            chkSexo.Visible = true;
            cmbSexo.Enabled = true;

            chkDataNascimento.Visible = true;
            dtpDataNascimento.Enabled = true;

            chkRG.Visible = true;
            mtxtRG.ReadOnly = false;

            chkCPF.Visible = true;
            mtxtCPF.ReadOnly = false;

            chkLogradouro.Visible = true;
            txtLogradouro.ReadOnly = false;

            chkNumeroLogradouro.Visible = true;
            txtNumeroLogradouro.ReadOnly = false;

            chkBairro.Visible = true;
            txtBairro.ReadOnly = false;

            chkCEP.Visible = true;
            mtxtCEP.ReadOnly = false;

            chkCidade.Visible = true;
            txtCidade.ReadOnly = false;

            chkNomePai.Visible = true;
            txtNomePai.ReadOnly = false;

            chkNomeMae.Visible = true;
            txtNomeMae.ReadOnly = false;

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
            btnNovoAluno.Location = new Point(
                btnLimparPesquisa.Location.X,
                btnLimparPesquisa.Location.Y + btnLimparPesquisa.Height + 5);
            #endregion

            #region btnFiltros
            btnFiltros.Location = new Point(
                btnNovoAluno.Location.X,
                btnNovoAluno.Location.Y + btnNovoAluno.Height + 5);
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

            #region chkMatricula
            chkMatricula.Location = new Point(
                pbFoto.Location.X + pbFoto.Width + 5,
                pbFoto.Location.Y + 5);
            #endregion

            #region lblMatricula
            lblMatricula.Location = new Point(
                chkMatricula.Location.X + chkMatricula.Width,
                chkMatricula.Location.Y);
            #endregion

            #region txtMatricula
            txtMatricula.Location = new Point(
                lblMatricula.Location.X + lblMatricula.Width + 5,
                lblMatricula.Location.Y - 3);
            #endregion

            #region chkInicio
            chkInicio.Location = new Point(
                txtMatricula.Location.X + txtMatricula.Width + 5,
                txtMatricula.Location.Y + 3);
            #endregion

            #region lblInicio
            lblInicio.Location = new Point(
                chkInicio.Location.X + chkInicio.Width,
                chkInicio.Location.Y);
            #endregion

            #region dtpMatriculaInicio
            dtpMatriculaInicio.Location = new Point(
                lblInicio.Location.X + lblInicio.Width + 5,
                lblInicio.Location.Y - 3);
            #endregion

            #region chkFim
            chkFim.Location = new Point(
                dtpMatriculaInicio.Location.X + dtpMatriculaInicio.Width + 5,
                dtpMatriculaInicio.Location.Y + 3);
            #endregion

            #region lblFim
            lblFim.Location = new Point(
                chkFim.Location.X + chkFim.Width,
                chkFim.Location.Y);
            #endregion

            #region dtpMatriculaFim
            dtpMatriculaFim.Location = new Point(
                lblFim.Location.X + lblFim.Width + 5,
                lblFim.Location.Y - 3);
            #endregion

            #region chkNomeAluno
            chkNomeAluno.Location = new Point(
                chkMatricula.Location.X,
                chkMatricula.Location.Y + chkMatricula.Height + 10);
            #endregion

            #region lblNomeAluno
            lblNomeAluno.Location = new Point(
                chkNomeAluno.Location.X + chkNomeAluno.Width,
                chkNomeAluno.Location.Y);
            #endregion

            #region txtNomeAluno
            txtNomeAluno.Location = new Point(
                lblNomeAluno.Location.X + lblNomeAluno.Width + 5,
                lblNomeAluno.Location.Y - 3);
            txtNomeAluno.Width = pnlPerfil.Width - txtNomeAluno.Location.X - 25;
            #endregion

            #region chkTurma
            chkTurma.Location = new Point(
                chkNomeAluno.Location.X,
                chkNomeAluno.Location.Y + chkNomeAluno.Height + 10);
            #endregion

            #region lblTurma
            lblTurma.Location = new Point(
                chkTurma.Location.X + chkTurma.Width,
                chkTurma.Location.Y);
            #endregion

            #region cmbTurma
            cmbTurma.Location = new Point(
                lblTurma.Location.X + lblTurma.Width + 5,
                lblTurma.Location.Y - 3);
            #endregion

            #region chkAtivo
            chkAtivo.Location = new Point(
                cmbTurma.Location.X + cmbTurma.Width + 5,
                cmbTurma.Location.Y + 3);
            #endregion

            #region cmbAtivo
            cmbAtivo.Location = new Point(
                chkAtivo.Location.X + chkAtivo.Width,
                chkAtivo.Location.Y - 3);
            #endregion

            #region chkEmail
            chkEmail.Location = new Point(
                chkTurma.Location.X,
                chkTurma.Location.Y + chkTurma.Height + 10);
            #endregion

            #region lblEmail
            lblEmail.Location = new Point(
                chkEmail.Location.X + chkEmail.Width + 5,
                chkEmail.Location.Y);
            #endregion

            #region txtEmail
            txtEmail.Location = new Point(
                lblEmail.Location.X + lblEmail.Width + 5,
                lblEmail.Location.Y - 3);
            txtEmail.Width = pnlPerfil.Width - txtEmail.Location.X - 25;
            #endregion

            #region chkSexo
            chkSexo.Location = new Point(
                chkEmail.Location.X,
                chkEmail.Location.Y + chkEmail.Height + 10);
            #endregion

            #region lblSexo
            lblSexo.Location = new Point(
                chkSexo.Location.X + chkSexo.Width + 5,
                chkSexo.Location.Y);
            #endregion

            #region cmbSexo
            cmbSexo.Location = new Point(
                lblSexo.Location.X + lblSexo.Width + 5,
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
                lblDataNascimento.Location.X + lblDataNascimento.Width + 5,
                lblDataNascimento.Location.Y - 3);
            #endregion

            #region chkRG
            chkRG.Location = new Point(
                btnCancelarImagem.Location.X,
                btnCancelarImagem.Location.Y + btnCancelarImagem.Height + 10);
            #endregion

            #region lblRG
            lblRG.Location = new Point(
                chkRG.Location.X + chkRG.Width,
                chkRG.Location.Y);
            #endregion

            #region mtxtRG
            mtxtRG.Location = new Point(
                lblRG.Location.X + lblRG.Width + 5,
                lblRG.Location.Y - 3);
            #endregion

            #region chkCPF
            chkCPF.Location = new Point(
                mtxtRG.Location.X + mtxtRG.Width + 5,
                mtxtRG.Location.Y + 3);
            #endregion

            #region lblCPF
            lblCPF.Location = new Point(
                chkCPF.Location.X + chkCPF.Width + 5,
                chkCPF.Location.Y);
            #endregion

            #region mtxtCPF
            mtxtCPF.Location = new Point(
                lblCPF.Location.X + lblCPF.Width + 5,
                lblCPF.Location.Y - 3);
            #endregion

            #region chkLogradouro
            chkLogradouro.Location = new Point(
                chkRG.Location.X,
                chkRG.Location.Y + chkRG.Height + 10);
            #endregion

            #region lblLogradouro
            lblLogradouro.Location = new Point(
                chkLogradouro.Location.X + chkLogradouro.Width,
                chkLogradouro.Location.Y);
            #endregion

            #region txtLogradouro
            txtLogradouro.Location = new Point(
                lblLogradouro.Location.X + lblLogradouro.Width + 5,
                lblLogradouro.Location.Y - 3);
            txtLogradouro.Width = pnlPerfil.Width - txtLogradouro.Location.X - lblNumeroLogradouro.Width - txtNumeroLogradouro.Width - chkNumeroLogradouro.Width - 30;
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
                lblNumeroLogradouro.Location.X + lblNumeroLogradouro.Width + 5,
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
                lblBairro.Location.X + lblBairro.Width + 5,
                lblBairro.Location.Y - 3);
            txtBairro.Width = pnlPerfil.Width - txtBairro.Location.X - 25;
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
                lblCEP.Location.X + lblCEP.Width + 5,
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
                lblCidade.Location.X + lblCidade.Width + 5,
                lblCidade.Location.Y - 3);
            txtCidade.Width = pnlPerfil.Width - txtCidade.Location.X - 25;
            #endregion

            #region chkNomePai
            chkNomePai.Location = new Point(
                chkCEP.Location.X,
                chkCEP.Location.Y + chkCEP.Height + 10);
            #endregion

            #region lblNomePai
            lblNomePai.Location = new Point(
                chkNomePai.Location.X + chkNomePai.Width,
                chkNomePai.Location.Y);
            #endregion

            #region txtNomePai
            txtNomePai.Location = new Point(
                lblNomePai.Location.X + lblNomePai.Width + 5,
                lblNomePai.Location.Y - 3);
            txtNomePai.Width = pnlPerfil.Width - txtNomePai.Location.X - 25;
            #endregion

            #region chkNomeMae
            chkNomeMae.Location = new Point(
                chkNomePai.Location.X,
                chkNomePai.Location.Y + chkNomePai.Height + 10);
            #endregion

            #region lblNomeMae
            lblNomeMae.Location = new Point(
                chkNomeMae.Location.X + chkNomeMae.Width,
                chkNomeMae.Location.Y);
            #endregion

            #region txtNomeMae
            txtNomeMae.Location = new Point(
                lblNomeMae.Location.X + lblNomeMae.Width + 5,
                lblNomeMae.Location.Y - 3);
            txtNomeMae.Width = pnlPerfil.Width - txtNomeMae.Location.X - 25;
            #endregion
        }

        private void FormMenuAluno_Load(object sender, EventArgs e)
        {
            MdiParent.Text = "ProGer - Alunos";
        }

        private void FormMenuAluno_Resize(object sender, EventArgs e)
        {
            RedimensionarControles();
        }

        private void btnNovoAluno_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Cadastrando...?");
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

            chkMatricula.Checked = VF;
            chkInicio.Checked = VF;
            chkFim.Checked = VF;
            chkNomeAluno.Checked = VF;
            chkTurma.Checked = VF;
            chkAtivo.Checked = VF;
            chkEmail.Checked = VF;
            chkSexo.Checked = VF;
            chkDataNascimento.Checked = VF;
            chkRG.Checked = VF;
            chkCPF.Checked = VF;
            chkLogradouro.Checked = VF;
            chkNumeroLogradouro.Checked = VF;
            chkBairro.Checked = VF;
            chkCEP.Checked = VF;
            chkCidade.Checked = VF;
            chkNomePai.Checked = VF;
            chkNomeMae.Checked = VF;
        }
    }
}

/*
 * nome aluno -
 * inicio mat -
 * fim mat -
 * mat -
 * nome pai -
 * nome mae -
 * rg -
 * cpf -
 * campo ativo/inativo -
 * data nascimento -
 * sexo -
 * logradouro, numero 
 * bairro
 * cep
 * cidade
 */