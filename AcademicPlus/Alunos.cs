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
    public partial class Alunos : MetroForm
    {
        private QueryMysql Aluno = new QueryMysql();
        private string IdAluno = "";
        public Alunos()
        {
            InitializeComponent();
            
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            if (TextNome.Text.Length == 0)
            {
                MessageBox.Show("Preencha o nome do aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else if (!TextDataNascimento.MaskFull)
            {
                MessageBox.Show("Preencha a data de nascimento do aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!TextTelefone.MaskFull)
            {
                MessageBox.Show("Preencha o telefone do aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!TextCpf.MaskFull)
            {
                MessageBox.Show("Preencha o nome do aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextRua.Text.Length == 0)
            {
                MessageBox.Show("Preencha a rua do aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextNumero.Text.Length == 0)
            {
                MessageBox.Show("Preencha o numero do aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextBairro.Text.Length == 0)
            {
                MessageBox.Show("Preencha o bairro do aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextCidade.Text.Length == 0)
            {
                MessageBox.Show("Preencha a cidade do aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextHistorico.Text.Length == 0)
            {
                MessageBox.Show("Preencha o histórico do aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Aluno.CadastrarAluno(TextNome.Text,TextDataNascimento.Text,TextTelefone.Text,TextCpf.Text,TextRua.Text,TextNumero.Text,TextBairro.Text,TextCidade.Text,TextHistorico.Text.ToUpper());
                MessageBox.Show("Aluno cadastrado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextNome.Text = "";
                TextDataNascimento.Text = "";
                TextTelefone.Text = "";
                TextCpf.Text = "";
                TextRua.Text = "";
                TextNumero.Text = "";
                TextBairro.Text = "";
                TextCidade.Text = "";
                TextHistorico.Text = "";
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscaAluno Busca = new BuscaAluno();
            Busca.ShowDialog();
            IdAluno=Aluno.GetAluno();
            try
            {
                var DadosAluno = Aluno.RetornaDadosAluno(IdAluno);
                TextNomeEditar.Text = DadosAluno.Rows[0]["nome"].ToString();
                TextDataNascimentoEditar.Text = DadosAluno.Rows[0]["datanascimento"].ToString();
                TextTelefoneEditar.Text = DadosAluno.Rows[0]["telefone"].ToString();
                TextCpfEditar.Text = DadosAluno.Rows[0]["cpf"].ToString();
                TextRuaEditar.Text = DadosAluno.Rows[0]["rua"].ToString();
                TextNumeroEditar.Text = DadosAluno.Rows[0]["numero"].ToString();
                TextBairroEditar.Text = DadosAluno.Rows[0]["bairro"].ToString();
                TextCidadeEditar.Text = DadosAluno.Rows[0]["cidade"].ToString();
                TextHistoricoEditar.Text = DadosAluno.Rows[0]["historico"].ToString();
            }
            catch
            {
                
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (TextNomeEditar.Text.Length == 0)
            {
                MessageBox.Show("Preencha o nome do aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!TextDataNascimentoEditar.MaskFull)
            {
                MessageBox.Show("Preencha a data de nascimento do aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!TextTelefoneEditar.MaskFull)
            {
                MessageBox.Show("Preencha o telefone do aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!TextCpfEditar.MaskFull)
            {
                MessageBox.Show("Preencha o nome do aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextRuaEditar.Text.Length == 0)
            {
                MessageBox.Show("Preencha a rua do aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextNumeroEditar.Text.Length == 0)
            {
                MessageBox.Show("Preencha o numero do aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextBairroEditar.Text.Length == 0)
            {
                MessageBox.Show("Preencha o bairro do aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextCidadeEditar.Text.Length == 0)
            {
                MessageBox.Show("Preencha a cidade do aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextHistoricoEditar.Text.Length == 0)
            {
                MessageBox.Show("Preencha o histórico do aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (IdAluno.Length > 0)
            {
                Aluno.AtualizarAluno(IdAluno, TextNomeEditar.Text, TextDataNascimentoEditar.Text, TextTelefoneEditar.Text, TextCpfEditar.Text,
                    TextRuaEditar.Text, TextNumeroEditar.Text, TextBairroEditar.Text, TextCidadeEditar.Text, TextHistoricoEditar.Text.ToUpper());
                MessageBox.Show("Aluno atualizado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextNomeEditar.Text = "";
                TextDataNascimentoEditar.Text = "";
                TextTelefoneEditar.Text = "";
                TextCpfEditar.Text = "";
                TextRuaEditar.Text = "";
                TextNumeroEditar.Text = "";
                TextBairroEditar.Text = "";
                TextCidadeEditar.Text = "";
                TextHistoricoEditar.Text = "";
                IdAluno = "";
            }
            else
            {
                MessageBox.Show("Faça uma busca de aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
             if (IdAluno.Length > 0)
            {
                var Resultado = MessageBox.Show("Deseja excluir este aluno ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resultado == DialogResult.Yes)
                {
                    Aluno.ExcluirAluno(IdAluno);
                    MessageBox.Show("Aluno excluido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextNomeEditar.Text = "";
                    TextDataNascimentoEditar.Text = "";
                    TextTelefoneEditar.Text = "";
                    TextCpfEditar.Text = "";
                    TextRuaEditar.Text = "";
                    TextNumeroEditar.Text = "";
                    TextBairroEditar.Text = "";
                    TextCidadeEditar.Text = "";
                    TextHistoricoEditar.Text = "";
                    IdAluno = "";
                }
            }
             else
             {
                 MessageBox.Show("Faça uma busca de aluno", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }
    }
}
