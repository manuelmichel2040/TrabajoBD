using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente frmclientes = new cliente();
            frmclientes.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            auto frmauto = new auto();
            frmauto.Show();
        }
    }
}
