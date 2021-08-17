using MicroTensileTester.Controls;
using Pcomm32Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroTensileTester
{
    public partial class MainForm : Form
    {
        private UInt32 _device;
        private InitializeControl _initializeControl;

        private Stack<Control> _prevControls = new Stack<Control>();
        private Stack<Control> _nextControls = new Stack<Control>();

        public MainForm(UInt32 device)
        {
            InitializeComponent();

            _device = device;
            _initializeControl = new InitializeControl(device);
            //StringBuilder strResponse = new StringBuilder();
            //PMAC.PmacGetResponseA(_device, strResponse, 255, new StringBuilder(Convert.ToString("M8100->X:$000000,0,24,U")));

            _nextControls.Push(new TestControl(device));

            panelMain.Controls.Add(_initializeControl);
            CheckState();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            _prevControls.Push(panelMain.Controls[0]);

            panelMain.Controls.Clear();
            panelMain.Controls.Add(_nextControls.Pop());

            CheckState();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            _nextControls.Push(panelMain.Controls[0]);
            
            panelMain.Controls.Clear();
            panelMain.Controls.Add(_prevControls.Pop());

            CheckState();
        }

        private void CheckState()
        {
            buttonNext.Enabled = _nextControls.Count > 0;
            buttonPrev.Enabled = _prevControls.Count > 0;
        }
    }
}
