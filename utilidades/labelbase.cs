using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilidades
{
    public partial class labelbase : System.Windows.Forms.Label
    {
        public labelbase()
        {
            InitializeComponent();
        }

        public labelbase(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void labelbase_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
