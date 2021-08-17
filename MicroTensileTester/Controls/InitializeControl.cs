using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroTensileTester.Controls
{
    public partial class InitializeControl : UserControl
    {
        UInt32 _device;

        public InitializeControl(UInt32 device)
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
            _device = device;
        }
    }
}
