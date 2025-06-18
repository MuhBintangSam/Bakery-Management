using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            new Form3().Show(); this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ButtonStaff_Click(object sender, EventArgs e)
        {
            new Form2().Show(); this.Hide();

        }

        private void guna2PanelWhite_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
