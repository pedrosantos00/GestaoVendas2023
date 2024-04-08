using GestaoVendas2023.pt.com.Gvendas.CONEXAO;
using GestaoVendas2023.pt.com.Gvendas.MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoVendas2023.pt.com.Gvendas.DAO
{
    public class ClientesDAO
    {
        private readonly MySqlConnection _conexao;

        public ClientesDAO()
        {
            _conexao = new ConnectionFactory().GetConnection();
        }

        public void CadastrarCliente(Cliente obj)
        {
            try
            {
                _conexao.Open();
                string sql = @"INSERT INTO tb_clientes (nif, nome, email, profissao, telemovel, endereco, postal, cidade, pais) VALUES (@Nif, @Nome, @Email, @Profissao, @Telemovel, @Endereco, @Postal, @Cidade, @Pais)";
                MySqlCommand executacmd = new MySqlCommand(sql, _conexao);

                executacmd.Parameters.AddWithValue("@Nif", obj.NIF);
                executacmd.Parameters.AddWithValue("@Nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@Email", obj.Email);
                executacmd.Parameters.AddWithValue("@Profissao", obj.Profissao);
                executacmd.Parameters.AddWithValue("@Telemovel", obj.Telemovel);
                executacmd.Parameters.AddWithValue("@Endereco", obj.Endereco);
                executacmd.Parameters.AddWithValue("@Postal", obj.Postal);
                executacmd.Parameters.AddWithValue("@Cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@Pais", obj.Pais);

                executacmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar cliente: " + ex.Message);
            }
            finally
            {
                if (_conexao.State == System.Data.ConnectionState.Open)
                    _conexao.Close();
            }
        }

        public List<Cliente> GetClientes(string searchTerm = null)
        {
            List<Cliente> listaClientes = new List<Cliente>();

            try
            {
                _conexao.Open();
                StringBuilder sqlBuilder = new StringBuilder("SELECT * FROM tb_clientes");

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    sqlBuilder.Append(" WHERE");
                    sqlBuilder.Append(" nome LIKE @SearchTerm");
                    sqlBuilder.Append(" OR nif LIKE @SearchTerm");
                    sqlBuilder.Append(" OR email LIKE @SearchTerm");
                    sqlBuilder.Append(" OR profissao LIKE @SearchTerm");
                    sqlBuilder.Append(" OR telemovel LIKE @SearchTerm");
                    sqlBuilder.Append(" OR endereco LIKE @SearchTerm");
                    sqlBuilder.Append(" OR postal LIKE @SearchTerm");
                    sqlBuilder.Append(" OR cidade LIKE @SearchTerm");
                    sqlBuilder.Append(" OR pais LIKE @SearchTerm");
                }

                MySqlCommand cmd = new MySqlCommand(sqlBuilder.ToString(), _conexao);

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");
                }

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente()
                    {
                        Id = reader.GetInt32("id"),
                        NIF = reader.GetInt32("nif"),
                        Nome = reader.GetString("nome"),
                        Email = reader.GetString("email"),
                        Profissao = reader.GetString("profissao"),
                        Telemovel = reader.GetInt32("telemovel"),
                        Endereco = reader.GetString("endereco"),
                        Postal = reader.GetString("postal"),
                        Cidade = reader.GetString("cidade"),
                        Pais = reader.GetString("pais")
                    };

                    listaClientes.Add(cliente);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter clientes: " + ex.Message);
            }
            finally
            {
                if (_conexao.State == System.Data.ConnectionState.Open)
                    _conexao.Close();
            }

            return listaClientes;
        }
    }
}
