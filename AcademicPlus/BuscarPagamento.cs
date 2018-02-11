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
    public partial class BuscarPagamento : MetroForm
    {
        QueryMysql Dados= new QueryMysql();
        public BuscarPagamento()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var DadosAlunos = Dados.BuscaPagamento(TextBuscar.Text);
            GridAluno.DataSource = DadosAlunos;
        }

        private void GridAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Dados.SetPagamento(GridAluno.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.Hide();
        }
        private void TextBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnBuscar_Click(sender, e);
            }
        }
    }
}
