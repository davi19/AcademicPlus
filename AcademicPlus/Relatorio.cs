using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Syncfusion.Windows.Forms;
using LocalReport = Microsoft.Reporting.WinForms.LocalReport;
using ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode;

namespace AcademicPlus
{
    public partial class Relatorio : MetroForm
    {
        private QueryMysql Dados = new QueryMysql();

        public Relatorio(string Relatorio)
        {
            
            InitializeComponent();
            if (Relatorio.Equals("Aluno"))
            {
                 reportViewer1.ProcessingMode = (ProcessingMode) Microsoft.Reporting.WebForms.ProcessingMode.Local;

                LocalReport localReport = reportViewer1.LocalReport;

                localReport.ReportPath = "alunos.rdlc";
                var Aluno =Dados.RetornaAlunos();
                var data = new ReportDataSource("alunos", Aluno);
                reportViewer1.LocalReport.DataSources.Add(data);

                reportViewer1.RefreshReport();
            }
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
