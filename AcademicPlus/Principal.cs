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
    public partial class Principal : MetroForm
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alunos aluno = new Alunos();
            aluno.ShowDialog();
        }

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pagamentos Pagamento = new Pagamentos();
            Pagamento.ShowDialog();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios Usuario = new Usuarios();
            Usuario.ShowDialog();
        }

        private void relaçãoDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio("Aluno");
            relatorio.ShowDialog();
        }

        private void pagamentosPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeriodoRelatorio periodo= new PeriodoRelatorio();
            periodo.ShowDialog();
            Relatorio relatorio = new Relatorio("PagamentoTotal");
            relatorio.ShowDialog();
        }
    }
}
