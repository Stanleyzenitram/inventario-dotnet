using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilidades
{
    public partial class combobox : System.Windows.Forms.ComboBox
    {
        public combobox()
        {
            InitializeComponent();
        }

        public combobox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
