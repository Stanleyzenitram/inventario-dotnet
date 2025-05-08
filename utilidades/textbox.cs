using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace utilidades
{
    public partial class textbox : TextBox
    {
        public bool Validar
        {
            set;
            get;
        }

        public bool Solonumero
        {
            set;
            get;
        }

        public textbox()
        {
            InitializeComponent();
        }

        public textbox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return) // si la tecla es enter
                SendKeys.Send("{tab}");

        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Solonumero == false)
                return;

            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
