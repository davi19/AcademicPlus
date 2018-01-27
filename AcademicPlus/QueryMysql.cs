using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace AcademicPlus
{
    class QueryMysql
    {
        MySqlConnection Conexao = new MySqlConnection("Server=localhost; Database=academicplus;Uid=root;Pwd=chinchila@acida12244819");

        public bool Login(string Usuario, string Senha)
        {
            Conexao.Open();
            var Query = new MySqlCommand("SELECT count(id) FROM usuarios WHERE usuario='"+Usuario+"' AND senha=MD5('"+Senha+"')",Conexao);
            var Leitor= new MySqlDataAdapter(Query);
            var Tabela = new DataTable();
            Leitor.Fill(Tabela);
            Conexao.Close();
            if (Convert.ToInt32(Tabela.Rows[0][0])> 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
