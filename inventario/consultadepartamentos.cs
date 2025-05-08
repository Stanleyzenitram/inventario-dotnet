using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace inventario
{
    public partial class consultadepartamentos : Consultas
    {
        public consultadepartamentos()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        public override void Consultar()
        {
            dataGridView1.DataSource = null;  // blanquear 

            string cmd = "select * from departamentos";
            //select * from departamentos where desdep like('%xx%')
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
                cmd += " where desdep like('%" + textBox1.Text.Trim() + "%')";

            ds = utilidades.utilidad.ejecuta(cmd);

            if (utilidades.utilidad.dsTieneDatos(ds))
                dataGridView1.DataSource = ds.Tables[0];  // lleno el datagridviw
            else
                MessageBox.Show("No hay datos");

        }

        public override void Imprimir()
        {
            reportviewer rp = new reportviewer();
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            rp.reportViewer1.LocalReport.ReportPath = "...\\...\\ReporteDeptos.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            rp.reportViewer1.LocalReport.DataSources.Clear();
            rp.reportViewer1.LocalReport.DataSources.Add(rds);
            rp.reportViewer1.RefreshReport();
            rp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (utilidades.utilidad.dsTieneDatos(ds))
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            MessageBox.Show("no hay datos para seleccionar");
        }

        
    }
}
