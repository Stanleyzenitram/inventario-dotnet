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
    public partial class reportviewer : Reportes
    {


        public reportviewer()
        {
            InitializeComponent();
        }

        public override void Imprimir()
        {
            reportViewer1.PrintDialog();
        }

        private void reportviewer_Load(object sender, EventArgs e)
        {
          /*  // TODO: esta línea de código carga datos en la tabla 'inventarioDataSet.departamentos1' Puede moverla o quitarla según sea necesario.
            this.departamentos1TableAdapter.Fill(this.inventarioDataSet.departamentos1);


            */
            this.reportViewer1.RefreshReport();
          

        }
    }
}
