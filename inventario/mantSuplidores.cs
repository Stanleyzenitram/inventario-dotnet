using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using utilidades;

namespace inventario
{
    public partial class mantSuplidores : mantenimientos
    {
        public mantSuplidores()
        {
            InitializeComponent();
        }

     
        

        public override void Salvar()
        {
            if (utilidad.ValidaForm(this, errorProvider1))
            {
                return;
            }

            string cmd = string.Format("exec suplidorActualiza  '{0}', '{1}', '{2}', '{3}', '{4}' ",
                txtCod.Text.Trim(), txtNom.Text.Trim(), txtEmail.Text.Trim(), ckestado.Checked, txtDireccion.Text.Trim());


            ds = utilidad.ejecuta(cmd);
            
            Limpiar();

            MessageBox.Show("¡Datos guardados correctamente!", "Guardado");
        }

        public override void Limpiar()
        {
            base.Limpiar();
            txtCod.Text = "";
            txtNom.Text = "";
            ckestado.Checked = false;
            txtEmail.Text = "";
            txtDireccion.Text = "";

            txtCod.Focus();

        }

        public override void Eliminar()
        {
            ds = utilidad.ejecuta("exec suplidorelimina '" + txtCod.Text.Trim() + "'");

            MessageBox.Show("¡Datos eliminados correctamente!", "Eliminado");
            Limpiar();
        }

        public override void Consultar()
        {
            consultaSuplidores obj = new consultaSuplidores();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                int pos = obj.dataGridView1.CurrentCell.RowIndex;

                txtCod.Text = obj.dataGridView1.Rows[pos].Cells[0].Value.ToString().Trim();
                // primera forma
                txtCod.Focus();
                SendKeys.Send("{tab}");
            }
            obj.Dispose();
        }

        private void txtCod_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCod.Text.Trim()))
                return;

            ds = utilidad.ejecuta("select * from suplidor where codsup='" + txtCod.Text.Trim() + "'");

            if (utilidad.dsTieneDatos(ds))
            {
                // llenar los textbox
                txtNom.Text = ds.Tables[0].Rows[0]["nomsup"].ToString().Trim();
                txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString().Trim();
                ckestado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["status"]);
                txtDireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString().Trim();
                //otros campos
            }
            else
            {
                txtNom.Text = "";
                txtEmail.Text = "";
                ckestado.Checked = false;
                txtDireccion.Text = "";
            }
        }
    }
}
