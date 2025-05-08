using System.ComponentModel;
using System.Windows.Forms;

namespace utilidades
{
    public partial class buton2 : Button
    {
        public buton2()
        {
            InitializeComponent();
        }

        public buton2(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
