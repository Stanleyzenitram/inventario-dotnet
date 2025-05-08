using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventario
{
    public partial class consultaExamen : Consultas
    {
        public consultaExamen()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }


        public override void Consultar()
        {
            dataGridView1.DataSource = null;  // blanquear 

            string cmd = "select * from productos";
           
            if (string.IsNullOrEmpty(txtDesc.Text.Trim()) == false)
                cmd += " where desprod like('%" + txtDesc.Text.Trim() + "%')";

            ds = utilidades.utilidad.ejecuta(cmd);

            if (utilidades.utilidad.dsTieneDatos(ds))
                dataGridView1.DataSource = ds.Tables[0];  // lleno el datagridviw
            else
                MessageBox.Show("No hay datos");

        }

        private void boton1_Click(object sender, EventArgs e)
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
