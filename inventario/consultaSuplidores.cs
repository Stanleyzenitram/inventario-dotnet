using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventario
{
    public partial class consultaSuplidores : Consultas
    {
        public consultaSuplidores()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }


        public override void Consultar()
        {
            dataGridView1.DataSource = null;

            string cmd = "select * from suplidor";

            if (string.IsNullOrEmpty(txtNom.Text.Trim()) == false)
                cmd += " where nomsup like ('%" + txtNom.Text.Trim() + "%')";

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

            rp.reportViewer1.LocalReport.ReportPath = "...\\...\\ReportSuplidor.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            rp.reportViewer1.LocalReport.DataSources.Clear();
            rp.reportViewer1.LocalReport.DataSources.Add(rds);
            rp.reportViewer1.RefreshReport();
            rp.ShowDialog();
        }

        private void btnSelect_Click(object sender, EventArgs e)
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
