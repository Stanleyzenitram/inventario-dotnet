
using System.ComponentModel;

using System.Windows.Forms;

namespace utilidades
{
    public partial class label : Label
    {
        public label()
        {
            InitializeComponent();
            //utilidad.utilidad.traduce(this);
        }

        public label(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
