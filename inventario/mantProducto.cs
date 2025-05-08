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
    public partial class mantProducto : mantenimientos
    {
        public mantProducto()
        {
            InitializeComponent();
        }

        private void txtCod_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCod.Text.Trim()))
                return;

            ds = utilidad.ejecuta("select * from productos where codpro='" + txtCod.Text.Trim() + "'");

            if (utilidad.dsTieneDatos(ds))
            {
                // llenar los textbox
                txtnomProd.Text = ds.Tables[0].Rows[0]["nompro"].ToString().Trim();
                txtpreVen.Text = ds.Tables[0].Rows[0]["preven"].ToString().Trim();
                txtpreCompra.Text = ds.Tables[0].Rows[0]["precom"].ToString().Trim();
                txtexiPro.Text = ds.Tables[0].Rows[0]["exipro"].ToString().Trim();
                txtpunReo.Text = ds.Tables[0].Rows[0]["punreo"].ToString().Trim();
                ckestado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["status"]);
                txtcodDep.Text = ds.Tables[0].Rows[0]["coddep"].ToString().Trim();
                //otros campos
            }
            else
            {
                txtnomProd.Text = "";
                txtpreVen.Text = "";
                txtpreCompra.Text = "";
                txtexiPro.Text = "";
                txtpunReo.Text = "";
                txtcodDep.Text = "";
                ckestado.Checked = false;
            }
        }


        public override void Salvar()
        {
            if (utilidad.ValidaForm(this, errorProvider1))
            {

                return;
            }
            string cmd = string.Format("exec productosactualiza '{0}','{1}','{2}', '{3}'," +
                " '{4}', '{5}', '{6}', '{7}'",
                txtCod.Text.Trim(), txtnomProd.Text.Trim(), txtpreVen.Text.Trim(), txtpreCompra.Text.Trim(),
                txtexiPro.Text.Trim(), txtpunReo.Text.Trim(), ckestado.Checked, txtcodDep.Text.Trim());

            ds = utilidad.ejecuta(cmd);
            Limpiar();
            MessageBox.Show("Datos guardados correctamente");
        }


        public override void Limpiar()
        {

            base.Limpiar();
            txtCod.Text = "";
            txtnomProd.Text = "";
            ckestado.Checked = false;
            txtpreVen.Text="";
            txtpreCompra.Text = "";
            txtexiPro.Text = "";
            txtpunReo.Text = "";
            txtcodDep.Text = "";

            txtnomProd.Focus();

        }

        public override void Eliminar()
        {
            ds = utilidad.ejecuta("exec productosElimina '" + txtCod.Text.Trim() + "'");
            Limpiar();

            MessageBox.Show("Datos eliminados correctamente");
        }

        public override void Consultar()
        {
            consultaProductos obj = new consultaProductos();
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


        private void linkLabel1_Click(object sender, EventArgs e)
        {
            consultadepartamentos obj = new consultadepartamentos();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                //posicion del cursor o registro activo

                int pos = obj.dataGridView1.CurrentCell.RowIndex;

                txtcodDep.Text = obj.dataGridView1.Rows[pos].Cells[0].Value.ToString().Trim();

                txtcodDep.Focus();
                SendKeys.Send("{tab}");
            }
            obj.Dispose();
        }

        private void txtcodDep_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodDep.Text.Trim()))
                return;

            ds = utilidad.ejecuta("select * from departamentos where coddep='" + txtcodDep.Text.Trim() + "'");

            if (!utilidad.dsTieneDatos(ds))
            {
                 
                MessageBox.Show("Departamento invalido");
                txtcodDep.Focus();
                return;
            }
            else
            {
               
            }
        }
    }
}
