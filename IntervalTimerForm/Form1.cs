using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool IsSettings = false;
        public Form1()
        {
            InitializeComponent();
            mtbTransitTimer.Enabled = cbTransit.Checked;
            this.Size = new Size(this.Size.Width, 200);
        }

        private void cbTransit_CheckStateChanged(object sender, EventArgs e)
        {
            mtbTransitTimer.Enabled = cbTransit.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IsSettings = !IsSettings;
            if (IsSettings)
            {
                this.Size = new Size(this.Size.Width, 311);
            }
            else
            {
                this.Size = new Size(this.Size.Width, 200);
            }
        }
    }
}