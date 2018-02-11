using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace AcademicPlus
{
    public partial class Pagamentos : MetroForm
    {
        private string IdAluno = "";
        private string IdAlunoEditar = "";
        private string IdPagamento = "";
        private QueryMysql Pagamento = new QueryMysql();

        public Pagamentos()
        {
            InitializeComponent();
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            if (TextNome.Text.Length == 0)
            {
                MessageBox.Show("Busque um aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (IdAluno.Length == 0)
            {
                MessageBox.Show("Busque um aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Pagamento.CadastrarPagamento(IdAluno,DataPagamento.Value.ToString(),TextValor.DecimalValue.ToString());
                MessageBox.Show("Pagamento cadastrado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextNome.Text = "";
                IdAluno = "";
                TextValor.Text = "0";
            }


        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscaAluno Busca = new BuscaAluno();
            Busca.ShowDialog();
            IdAluno = Pagamento.GetAluno();
            try
            {
                var DadosAluno = Pagamento.RetornaDadosAluno(IdAluno);
                TextNome.Text = DadosAluno.Rows[0]["nome"].ToString();
                
            }
            catch
            {

            }
        }

        private void BtnBuscarPagamento_Click(object sender, EventArgs e)
        {
            BuscarPagamento Busca = new BuscarPagamento();
            Busca.ShowDialog();
            IdPagamento = Pagamento.GetPagamento();
            try
            {
                var DadosPagamento = Pagamento.RetornaDadosPagamento(IdPagamento);
                IdAlunoEditar = DadosPagamento.Rows[0]["ID ALUNO"].ToString();
                TextNomeEditar.Text = DadosPagamento.Rows[0]["NOME ALUNO"].ToString();
                TextValorPagamentoEditar.Text = DadosPagamento.Rows[0]["VALOR"].ToString();
                DataPagamentoEditar.Value = Convert.ToDateTime(DadosPagamento.Rows[0]["DATA PAGAMENTO"].ToString());
                
            }
            catch
            {

            }
        }

        private void BtnBuscarEditar_Click(object sender, EventArgs e)
        {
            BuscaAluno Busca = new BuscaAluno();
            Busca.ShowDialog();
            IdAlunoEditar = Pagamento.GetAluno();
            try
            {
                var DadosAluno = Pagamento.RetornaDadosAluno(IdAluno);
                TextNomeEditar.Text = DadosAluno.Rows[0]["nome"].ToString();

            }
            catch
            {

            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (TextNomeEditar.Text.Length == 0)
            {
                MessageBox.Show("Busque um aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (IdAlunoEditar.Length == 0)
            {
                MessageBox.Show("Busque um aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Pagamento.AtualizarPagamento(IdPagamento,IdAlunoEditar,DataPagamentoEditar.Value.ToString(),TextValorPagamentoEditar.DecimalValue.ToString());
                MessageBox.Show("Pagamento atualizado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IdPagamento = "";
                IdAlunoEditar = "";
                TextNomeEditar.Text = "";
                TextValorPagamentoEditar.Text = "0";
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (IdPagamento.Length > 0)
            {
                var Resultado = MessageBox.Show("Deseja excluir este pagamento ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resultado == DialogResult.Yes)
                {
                    Pagamento.ExcluirPagamento(IdPagamento);
                    MessageBox.Show("Pagamento excluido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextNomeEditar.Text = "";
                    IdAlunoEditar = "";
                    TextValorPagamentoEditar.Text = "0";
                    IdPagamento = "";
                }
            }
            else
            {
                MessageBox.Show("Faça uma busca de pagamento", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
