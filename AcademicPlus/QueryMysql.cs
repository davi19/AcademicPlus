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
        private static string IdAluno = "";
        private static string IdUsuario = "";
        private static string IdPagamento = "";
        private static string DataInicial ="";
        private static string DataFinal = "";

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


        public void CadastrarAluno(string Nome,string DataNascimento,string Telefone,string Cpf,string Rua,string Numero,string Bairro,string Cidade,string Historico)
        {
            Conexao.Open();
            var Comando = new MySqlCommand("INSERT INTO alunos (nome,datanascimento,telefone,cpf,rua,numero,bairro,cidade,historico) VALUES('"+Nome+"','"+Convert.ToDateTime(DataNascimento).ToString("yyyy/MM/dd")+"','"+Telefone+"','"+Cpf+"','"+Rua+"',"+Numero+",'"+Bairro+"','"+Cidade+"','"+Historico+"')",Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public DataTable BuscaAluno(string Nome)
        {
            Conexao.Open();
            var Comando = new MySqlCommand("SELECT id,nome FROM alunos WHERE nome like'%" + Nome + "%' and excluido='N'", Conexao);
            var Adapter = new MySqlDataAdapter(Comando);
            var Tabela = new DataTable();
            Adapter.Fill(Tabela);
            Conexao.Close();
            return Tabela;
        }
        public DataTable RetornaDadosAluno(string Id)
        {
            Conexao.Open();
            var Comando = new MySqlCommand("SELECT * FROM alunos WHERE id=" +Id + "", Conexao);
            var Adapter = new MySqlDataAdapter(Comando);
            var Tabela = new DataTable();
            Adapter.Fill(Tabela);
            Conexao.Close();
            return Tabela;
        }
        public void AtualizarAluno(string Id,string Nome, string DataNascimento, string Telefone, string Cpf, string Rua, string Numero, string Bairro, string Cidade, string Historico)
        {
            Conexao.Open();
            var Comando = new MySqlCommand("UPDATE alunos SET nome='"+Nome+"',datanascimento='"+Convert.ToDateTime(DataNascimento).ToString("yyyy/MM/dd")+"',telefone='"+Telefone+"',cpf='"+Cpf+"',rua='"+Rua+"',numero="+Numero+",bairro='"+Bairro+"',cidade='"+Cidade+"',historico='"+Historico+"' WHERE id="+Id+";", Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public void ExcluirAluno(string Id)
        {
            Conexao.Open();
            var Comando = new MySqlCommand("UPDATE alunos SET excluido='S' WHERE id="+Id+"", Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public string GetAluno()
        {
            return IdAluno;
        }
        public void SetAluno(string Id)
        {
             IdAluno =Id;
        }


        public void CadastrarPagamento(string IdAluno, string DataPagamento, string ValorPagamento)
        {
            Conexao.Open();
            var Comando = new MySqlCommand("INSERT INTO pagamentos (idaluno,datapagamento,valorpagamento) VALUES('" + IdAluno + "','" + Convert.ToDateTime(DataPagamento).ToString("yyyy/MM/dd") + "','" + ValorPagamento.Replace(',','.')+ "')", Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public DataTable BuscaPagamento(string Nome)
        {
            Conexao.Open();
            var Comando = new MySqlCommand("SELECT  a.id as ID,b.nome as 'NOME ALUNO',a.valorpagamento as VALOR,a.datapagamento as 'DATA PAGAMENTO' FROM pagamentos a, alunos b WHERE a.idaluno=b.id AND  b.nome like'%" + Nome + "%' and a.excluido='N'", Conexao);
            var Adapter = new MySqlDataAdapter(Comando);
            var Tabela = new DataTable();
            Adapter.Fill(Tabela);
            Conexao.Close();
            return Tabela;
        }
        public DataTable RetornaDadosPagamento(string Id)
        {
            try
            {
                Conexao.Open();
            }
            catch { }

            var Comando = new MySqlCommand("SELECT b.id as 'ID ALUNO',a.id as ID,b.nome as 'NOME ALUNO',a.valorpagamento as VALOR,a.datapagamento as 'DATA PAGAMENTO' FROM pagamentos a, alunos b WHERE a.idaluno=b.id AND a.id=" + Id + "", Conexao);
            var Adapter = new MySqlDataAdapter(Comando);
            var Tabela = new DataTable();
            Adapter.Fill(Tabela);
            Conexao.Close();
            return Tabela;
        }
        public void AtualizarPagamento(string Id, string IdAluno, string DataPagamento, string ValorPagamento)
        {
            Conexao.Open();
            var Comando = new MySqlCommand("UPDATE pagamentos SET idaluno='" + IdAluno + "',datapagamento='" + Convert.ToDateTime(DataPagamento).ToString("yyyy/MM/dd") + "',valorpagamento='" + ValorPagamento.Replace(',', '.') + "' WHERE id=" + Id + ";", Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public void ExcluirPagamento(string Id)
        {
            Conexao.Open();
            var Comando = new MySqlCommand("UPDATE pagamentos SET excluido='S' WHERE id=" + Id + "", Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public string GetPagamento()
        {
            return IdPagamento;
        }
        public void SetPagamento(string Id)
        {
            IdPagamento = Id;
        }







        public void CadastrarUsuario(string Usuario,string Senha)
        {
            Conexao.Open();
            var Comando = new MySqlCommand("INSERT INTO usuarios (usuario,senha) VALUES('" + Usuario + "',MD5('" +Senha+ "'))", Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public DataTable BuscaUsuario(string Nome)
        {
            Conexao.Open();
            var Comando = new MySqlCommand("SELECT  id as ID,usuario as 'NOME USUARIO'FROM usuarios WHERE usuario like'%" + Nome + "%' and excluido='N'", Conexao);
            var Adapter = new MySqlDataAdapter(Comando);
            var Tabela = new DataTable();
            Adapter.Fill(Tabela);
            Conexao.Close();
            return Tabela;
        }
        public DataTable RetornaDadosUsuario(string Id)
        {
            try
            {
                Conexao.Open();
            }
            catch { }

            var Comando = new MySqlCommand("SELECT * FROM usuarios WHERE id=" + Id + "", Conexao);
            var Adapter = new MySqlDataAdapter(Comando);
            var Tabela = new DataTable();
            Adapter.Fill(Tabela);
            Conexao.Close();
            return Tabela;
        }
        public void AtualizarUsuario(string Id, string usuario, string senha)
        {
            Conexao.Open();
            var Comando = new MySqlCommand("UPDATE usuarios SET usuario='" + usuario + "',senha=MD5('" + senha + "') WHERE id=" + Id + ";", Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public void ExcluirUsuario(string Id)
        {
            Conexao.Open();
            var Comando = new MySqlCommand("UPDATE usuarios SET excluido='S' WHERE id=" + Id + "", Conexao);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public string GetUsuario()
        {
            return IdUsuario;
        }
        public void SetUsuario(string Id)
        {
            IdUsuario = Id;
        }
        public DataTable RetornaAlunos()
        {
            try
            {
                Conexao.Open();
            }
            catch { }

            var Comando = new MySqlCommand("SELECT nome,datanascimento,rua,numero,bairro,cidade,cpf FROM alunos WHERE excluido='N'", Conexao);
            var Adapter = new MySqlDataAdapter(Comando);
            var Tabela = new DataTable();
            Adapter.Fill(Tabela);
            Conexao.Close();
            return Tabela;
        }
        public string GetDataInicial()
        {
            return DataInicial;
        }
        public void SetDataInicial(string Data)
        {
            DataInicial = Data;
        }
        public string GetDataFinal()
        {
            return DataFinal;
        }
        public void SetDataFinal(string Data)
        {
            DataFinal = Data;
        }


        public DataTable RetornaPagamentoTotal(string DataIncial,string DataFinal)
        {
            try
            {
                Conexao.Open();
            }
            catch { }

            var Comando = new MySqlCommand("SELECT a.nome as nomealuno,replace(a.cpf,',','.') as cpf,DATE_FORMAT(b.datapagamento, '%d/%m/%y')as datapagamento,b.valorpagamento FROM alunos a, pagamentos b WHERE a.id=b.idaluno and b.excluido='N' and b.datapagamento between '" + DataInicial+"' AND '"+DataFinal+"'", Conexao);
            var Adapter = new MySqlDataAdapter(Comando);
            var Tabela = new DataTable();
            Adapter.Fill(Tabela);
            Conexao.Close();
            return Tabela;
        }
    }
}
