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
    public partial class PeriodoRelatorio : MetroForm
    {
        private QueryMysql Dados = new QueryMysql();
        public PeriodoRelatorio()
        {
            InitializeComponent();
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            Dados.SetDataInicial(DataInicial.Value.ToString("yyyy/MM/dd"));
            Dados.SetDataFinal(DataFinal.Value.ToString("yyyy/MM/dd"));
            this.Hide();
        }

        
    }
}
