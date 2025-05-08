using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilidades
{
    public partial class ckestado : System.Windows.Forms.CheckBox
    {
        public ckestado()
        {
            InitializeComponent();
        }

        public ckestado(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
