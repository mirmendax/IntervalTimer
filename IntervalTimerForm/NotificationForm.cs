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
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();
            var size = Screen.PrimaryScreen.Bounds.Size;
            Location = new Point(size.Width-Size.Width-10,size.Height-Size.Height-40);

        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.02;
        }
    }
}
