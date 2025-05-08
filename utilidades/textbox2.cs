using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace utilidades
{
    public partial class textbox2 : textbox
    {
    


        public textbox2()
        {
            InitializeComponent();
        }

        public textbox2(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void textbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textbox2_KeyPress_1(object sender, KeyPressEventArgs e)
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
