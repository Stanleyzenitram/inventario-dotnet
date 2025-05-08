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
    public partial class mantenimientos : FormBase
    {
        public mantenimientos()
        {
            InitializeComponent();
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
