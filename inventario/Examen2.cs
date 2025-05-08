using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utilidades;

namespace inventario
{
    public partial class Examen2 : mantenimientos
    {
        public Examen2()
        {
            InitializeComponent();
            txtCod.Focus();

        }

        private void txtCod_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtCod.Text.Trim()))
                return;

            ds = utilidad.ejecuta("select * from productos where codprod='" + txtCod.Text.Trim() + "'");

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                txtDesc.Text = ds.Tables[0].Rows[0]["desprod"].ToString().Trim();
                ckestado1.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["status"]);
          


            }
            else
            {
                txtDesc.Text = "";
                ckestado1.Checked = false;
           
            }




        }

        public override void Eliminar()
        {
            
            ds = utilidad.ejecuta("exec productoElimina '" + txtCod.Text.Trim() + "'");

            MessageBox.Show("¡Datos eliminados correctamente!", "Eliminado");
            Limpiar();
        }

        public override void Salvar()
        {
            if (utilidad.ValidaForm(this, errorProvider1))
                return;

            if (!utilidad.Primo(txtCod.Text))
            {
                MessageBox.Show("El codigo debe ser un numero primo");
                return;
            }

            string cmd = string.Format("exec productoActualiza '{0}','{1}','{2}'",
                txtCod.Text.Trim(), txtDesc.Text.Trim(), ckestado1.Checked);

            ds = utilidad.ejecuta(cmd);
            Limpiar();
            MessageBox.Show("Datos guardados correctamente");
        }


        public override void Limpiar()
        {
            txtCod.Text = txtDesc.Text = "";
            ckestado1.Checked = false;
        }

        public override void Consultar()
        {
            consultaExamen obj = new consultaExamen();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                //posicion del cursor o registro activo

                int pos = obj.dataGridView1.CurrentCell.RowIndex;

                txtCod.Text = obj.dataGridView1.Rows[pos].Cells[0].Value.ToString().Trim();

                txtCod.Focus();
                SendKeys.Send("{tab}");
            }
            obj.Dispose();
        }
    }
}
