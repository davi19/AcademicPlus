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
    public partial class Usuarios : MetroForm
    {
        private QueryMysql Usuario = new QueryMysql();
        private string IdUsuario = "";
        public Usuarios()
        {
            InitializeComponent();
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            if (TextUsuario.Text.Length == 0)
            {
                MessageBox.Show("Preencha o nome de usuário", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextSenha.Text.Length == 0)
            {
                MessageBox.Show("Preencha a senha do usuário", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Usuario.CadastrarUsuario(TextUsuario.Text,TextSenha.Text);
                MessageBox.Show("Usuario cadastrado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextUsuario.Text = "";
                TextSenha.Text = "";
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (TextUsuarioEditar.Text.Length == 0)
            {
                MessageBox.Show("Preencha o nome de usuário", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextSenhaEditar.Text.Length == 0)
            {
                MessageBox.Show("Preencha a senha do usuário", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (IdUsuario.Length == 0)
            {
                MessageBox.Show("Faça uma busca de usuário", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Usuario.AtualizarUsuario(IdUsuario,TextUsuarioEditar.Text, TextSenhaEditar.Text);
                MessageBox.Show("Usuario atualizado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextUsuarioEditar.Text = "";
                TextSenhaEditar.Text = "";
                IdUsuario = "";
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (IdUsuario.Length > 0)
            {
                var Resultado = MessageBox.Show("Deseja excluir este usuario ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resultado == DialogResult.Yes)
                {
                    Usuario.ExcluirUsuario(IdUsuario);
                    MessageBox.Show("Usuário excluido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TextUsuarioEditar.Text = "";
                    TextSenhaEditar.Text = "";
                    IdUsuario = "";
                }
            }
            else
            {
                MessageBox.Show("Faça uma busca de usuário", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscaUsuario_Click(object sender, EventArgs e)
        {
            BuscarUsuario Busca = new BuscarUsuario();
            Busca.ShowDialog();
            IdUsuario = Usuario.GetUsuario();
            try
            {
                var DadosUsuario = Usuario.RetornaDadosUsuario(IdUsuario);
                TextUsuarioEditar.Text = DadosUsuario.Rows[0]["usuario"].ToString();
            
            }

            catch
            {

            }
        }
    }
}
