using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using utilidades;

namespace inventario
{
    public partial class matenimientodepartamentos : mantenimientos
    {
        public matenimientodepartamentos()
        {
            InitializeComponent();
        }

        private void textbox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodigo.Text.Trim()))
                return;

            ds = utilidad.ejecuta("select * from departamentos where coddep='" + txtcodigo.Text.Trim() + "'");
            
            if (utilidad.dsTieneDatos(ds))
            {
                // llenar los textbox
                txtnombre.Text = ds.Tables[0].Rows[0]["desdep"].ToString().Trim();
                ckestado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["status"]);
                //otros campos
            }
            else
            {
                txtnombre.Text = "";
                ckestado.Checked = false;
            }

        }

        public override void Salvar()
        {
            if (utilidad.ValidaForm(this, errorProvider1))
            {
              
                return;
            }
            string cmd = string.Format("exec departamentosActualiza '{0}','{1}','{2}'",
                txtcodigo.Text.Trim(), txtnombre.Text.Trim(), ckestado.Checked);

            ds = utilidad.ejecuta(cmd);
            Limpiar();
            MessageBox.Show("Datos guardados correctamente");
        }

        public override void Limpiar()
        {

            base.Limpiar();
            txtcodigo.Text = "";
            txtnombre.Text = "";
            ckestado.Checked = false;
            txtcodigo.Focus();

        }

        public override void Eliminar()
        {
            ds = utilidad.ejecuta("exec departamentoselimina '" + txtcodigo.Text.Trim() + "'");
            Limpiar();

            MessageBox.Show("Datos eliminados correctamente");
        }

        public override void Consultar()
        {
            consultadepartamentos obj = new consultadepartamentos();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                //posicion del cursor o registro activo

                int pos = obj.dataGridView1.CurrentCell.RowIndex;

                txtcodigo.Text = obj.dataGridView1.Rows[pos].Cells[0].Value.ToString().Trim();
               
                txtcodigo.Focus();
                SendKeys.Send("{tab}");
            }
            obj.Dispose();
        }
    }
}
