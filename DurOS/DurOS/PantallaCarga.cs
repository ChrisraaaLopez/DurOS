using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DurOS
{
    public partial class PantallaCarga : Form
    {
        public PantallaCarga()
        {
            InitializeComponent();
        }

        int timer = 0;

        private void PantallaCarga_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            if (timer == 5) 
            {
                InicioDeSesion inicioDeSesion = new InicioDeSesion();
                inicioDeSesion.Show();
                this.Hide();
            }
        }
    }
}
