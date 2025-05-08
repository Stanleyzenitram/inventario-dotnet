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
    public partial class mantUsuarios : mantenimientos
    {
        public mantUsuarios()
        {
            InitializeComponent();
        }


        public override void Salvar()
        {
            if (utilidad.ValidaForm(this, errorProvider1))
            {
                return;
            }

            string clave;
            clave = utilidad.Encriptar(txtClave.Text.Trim());

            string cmd = string.Format("exec UsuariosActualiza  '{0}', '{1}', '{2}', '{3}', '{4}', '{5}' ",
              txtUser.Text.Trim(), txtCod.Text.Trim(), txtNom.Text.Trim(), clave, ckestado1.Checked, cmbNiv.Text.Trim());


            ds = utilidad.ejecuta(cmd);
            Limpiar();

            MessageBox.Show("¡Datos guardados correctamente!", "Guardado");
        }

        public override void Limpiar()
        {
            txtUser.Text = txtCod.Text = txtNom.Text = txtClave.Text = cmbNiv.Text = "";
            ckestado1.Checked = false;
        }

        public override void Eliminar()
        {
            ds = utilidad.ejecuta("exec UsuariosElimina '" + txtCod.Text.Trim() + "'");

            MessageBox.Show("¡Datos eliminados correctamente!", "Eliminado");
            Limpiar();
        }


        public override void Consultar()
        {
            consultaUsuarios obj = new consultaUsuarios();
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

            ds = utilidad.ejecuta("select * from Usuarios where coduser='" + txtCod.Text.Trim() + "'");

            if (utilidad.dsTieneDatos(ds))
            {
                // llenar los textbox
                txtUser.Text = ds.Tables[0].Rows[0]["usuario"].ToString().Trim();
                txtNom.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();
                txtClave.Text = ds.Tables[0].Rows[0]["clave"].ToString().Trim();
                ckestado1.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["estado"]);
                cmbNiv.Text = ds.Tables[0].Rows[0]["nivel"].ToString().Trim();

                //otros campos
            }
            else
            {
                txtUser.Text = txtNom.Text = txtClave.Text = cmbNiv.Text = "";
                ckestado1.Checked = false;
            }

           
            
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            int result = (int)Math.Pow(Convert.ToInt32(cmbNiv.Text), Convert.ToInt32(txtCod.Text));
            MessageBox.Show(utilidad.ConvierteLetras(result));
        }
    }
}
