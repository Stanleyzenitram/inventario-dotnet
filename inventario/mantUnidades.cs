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
    public partial class mantUnidades : mantenimientos
    {
        public mantUnidades()
        {
            InitializeComponent();
        }

        private void textbox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textbox1.Text.Trim()))
                return;

            ds = utilidad.ejecuta("select * from unidades where coduni='" + textbox1.Text.Trim() + "'");

            if (utilidad.dsTieneDatos(ds))
            {
                //llenar los textbox
                textbox2.Text = ds.Tables[0].Rows[0]["desuni"].ToString().Trim();
                ckestado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["status"]);
            }
            else
            {
                textbox2.Text = "";
                ckestado.Checked = false;
            }
        }


        //Funcion para guardar
        public override void Salvar()
        {
            if (utilidad.ValidaForm(this, errorProvider1))
            {
                return;
            }
            string cmd = string.Format("exec unidadesActualiza '{0}', '{1}', '{2}' ",
              textbox1.Text.Trim(), textbox2.Text.Trim(), ckestado.Checked);

            ds = utilidad.ejecuta(cmd);
            Limpiar();

            MessageBox.Show("¡Datos guardados correctamente!", "Guardado");
        }

        //Funcion para limpiar campos
        public override void Limpiar()
        {
            base.Limpiar();
            textbox1.Text = "";
            textbox2.Text = "";
            ckestado.Checked = false;
            textbox1.Focus();

        }

        public override void Eliminar()
        {
            ds = utilidad.ejecuta("exec unidadeselimina '" + textbox1.Text.Trim() + "'");

            MessageBox.Show("¡Datos eliminados correctamente!", "Eliminado");
            Limpiar();
        }

        public override void Consultar()
        {
            consultaunidades obj = new consultaunidades();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                //posicion del cursor o registro activo

                int pos = obj.dataGridView1.CurrentCell.RowIndex;

                textbox1.Text = obj.dataGridView1.Rows[pos].Cells[0].Value.ToString().Trim();

                textbox1.Focus();
                SendKeys.Send("{tab}");
            }
            obj.Dispose();
        }
    }
}
