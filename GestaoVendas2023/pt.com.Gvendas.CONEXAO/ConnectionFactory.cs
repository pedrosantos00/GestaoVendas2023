using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoVendas2023.pt.com.Gvendas.CONEXAO
{
    public class ConnectionFactory
    {
        public MySqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["DBISTEC"].ConnectionString;
            return new MySqlConnection(conexao);
        }
    }
}
