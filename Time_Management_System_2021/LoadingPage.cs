using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Management_System_2021
{
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= 1000)
            {
                timer1.Stop();
                Generalpage gp = new Generalpage();
                gp.Show();
                this.Hide();
            }
        }
    }
}
