
using System.ComponentModel;
using System.Windows.Forms;

namespace utilidades
{
    public partial class hsboton : Button
    {
        public hsboton()
        {
            InitializeComponent();
        }

        public hsboton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
