using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicPlus
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (TextUsuario.Text.Length == 0)
            {
                MessageBox.Show("Favor informar um usuário!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TextSenha.Text.Length == 0)
            {
                MessageBox.Show("Favor informar uma senha!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                var Query = new QueryMysql();
                var Resultado = Query.Login(TextUsuario.Text, TextSenha.Text);
                if (Resultado)
                {
                    Principal Cadastro = new Principal();
                    Cadastro.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TextSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnEntrar_Click(sender,e);
            }
        }
    }
}
