using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using utilidades;

namespace inventario
{
    public partial class matenimientounidades : mantenimientos
    {
        public matenimientounidades()
        {
            InitializeComponent();
        }

        private void textbox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodigo.Text.Trim()))
                return;

            ds = utilidad.ejecuta("select * from unidades where coduni='" + txtcodigo.Text.Trim() + "'");
            
            if (utilidad.dsTieneDatos(ds))
            {
                // llenar los textbox
                txtnombre.Text = ds.Tables[0].Rows[0]["desuni"].ToString().Trim();
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
            if (utilidad.ValidaForm(this,errorProvider1))
                return;

            string cmd = string.Format("exec unidadesActualiza '{0}','{1}','{2}'",
                txtcodigo.Text.Trim(), txtnombre.Text.Trim(), ckestado.Checked);

            ds = utilidad.ejecuta(cmd);
            Limpiar();
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
            ds = utilidad.ejecuta("exec unidadeselimina '" + txtcodigo.Text.Trim() + "'");
        }

        public override void Consultar()
        {
            consultaunidades obj = new consultaunidades();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                int pos = obj.dataGridView1.CurrentCell.RowIndex;

                txtcodigo.Text = obj.dataGridView1.Rows[pos].Cells[0].Value.ToString().Trim();
                // primera forma
                txtcodigo.Focus();
                SendKeys.Send("{tab}");
            }
            obj.Dispose();
        }

    }
}
