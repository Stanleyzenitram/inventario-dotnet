using System.ComponentModel;

namespace utilidades
{
    public partial class daagridviw : System.Windows.Forms.DataGridView
    {
        public daagridviw()
        {
            InitializeComponent();
        }

        public daagridviw(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
