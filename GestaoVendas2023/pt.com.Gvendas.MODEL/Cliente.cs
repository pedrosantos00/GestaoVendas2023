using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoVendas2023.pt.com.Gvendas.MODEL
{
    public class Cliente
    {
        public int Id { get; set; }
        public int NIF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Telemovel { get; set; }
        public string Profissao { get; set; }
        public string Endereco { get; set; }
        public string Postal { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
    }
}
