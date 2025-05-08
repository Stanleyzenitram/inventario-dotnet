using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilidades
{
    public partial class botonvictor : System.Windows.Forms.Button
    {
        public botonvictor()
        {
            InitializeComponent();
        }

        public botonvictor(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
