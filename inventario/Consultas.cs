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
    public partial class Consultas : FormBase
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void cmdbuscar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void cmdimprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
    }
}
