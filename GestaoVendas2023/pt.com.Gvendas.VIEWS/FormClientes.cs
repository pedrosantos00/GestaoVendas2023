using GestaoVendas2023.pt.com.Gvendas.DAO;
using GestaoVendas2023.pt.com.Gvendas.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoVendas2023.pt.com.Gvendas.VIEWS
{
    public partial class FormClientes : Form
    {
        private readonly ClientesDAO clientesDAO;
        public FormClientes()
        {
            clientesDAO = new ClientesDAO();
            InitializeComponent();
        }

        #region Eventos
        private void FormClientes_Load(object sender, EventArgs e)
        {
            AtualizarListaClientes();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarListaClientes();
            txtPesquisa.Clear();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termoPesquisa = txtPesquisa.Text;
            AtualizarListaClientesComFiltro(termoPesquisa);
            txtPesquisa.Clear();
        }
        #endregion

        #region Consultar 
        private void AtualizarListaClientes()
        {
            try
            {
                List<Cliente> listaClientes = clientesDAO.GetClientes();
                datClientes.DataSource = listaClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao obter a lista de clientes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarListaClientesComFiltro(string termoPesquisa)
        {
            try
            {
                List<Cliente> listaClientes = clientesDAO.GetClientes(termoPesquisa);
                datClientes.DataSource = listaClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante a pesquisa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Create
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                Cliente novoCliente = new Cliente
                {
                    Nome = txtNome.Text,
                    NIF = int.Parse(txtNIF.Text),
                    Email = txtEmail.Text,
                    Profissao = txtProfissao.Text,
                    Telemovel = int.Parse(txtTelm.Text),
                    Endereco = txtEndereco.Text,
                    Postal = txtCod.Text,
                    Cidade = txtCidade.Text,
                    Pais = txtCidade.Text
                };

                clientesDAO.CadastrarCliente(novoCliente);
                MessageBox.Show("Cliente registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear();
                txtEndereco.Clear();
                txtCidade.Clear();
                txtPais.Clear();
                txtCod.Clear();
                txtNIF.Clear();
                txtEmail.Clear();
                txtTelm.Clear();
                txtProfissao.Clear();
                AtualizarListaClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao registrar o cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private bool ValidarCampos()
        {
            // Validação do nome e NIF
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtNIF.Text))
            {
                MessageBox.Show("Nome e NIF são campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validação da profissão
            if (string.IsNullOrWhiteSpace(txtProfissao.Text))
            {
                MessageBox.Show("Profissão é obrigatória.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validação do endereço, cidade e país
            if (string.IsNullOrWhiteSpace(txtEndereco.Text) || string.IsNullOrWhiteSpace(txtCidade.Text) || string.IsNullOrWhiteSpace(txtPais.Text))
            {
                MessageBox.Show("Endereço, Cidade e País são campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validação numérica do NIF
            if (!int.TryParse(txtNIF.Text, out int nifAsNumber))
            {
                MessageBox.Show("NIF deve ser numérico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validação do telemóvel
            if (!string.IsNullOrWhiteSpace(txtTelm.Text) && !int.TryParse(txtTelm.Text, out int telAsNumber))
            {
                MessageBox.Show("Número de telemóvel inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validação do email
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validação do código postal
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCod.Text, @"^\d{4}-\d{3}$"))
            {
                MessageBox.Show("Código-Postal inválido. O formato correto é 0000-000.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}

