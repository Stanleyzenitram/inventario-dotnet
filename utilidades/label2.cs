using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilidades
{
    public partial class label2 : System.Windows.Forms.Label
    {

        public label2()
        {
            InitializeComponent();
        }

        public label2(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
