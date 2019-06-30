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
    public partial class Sure : Form
    {
        public bool close;
        public Sure()
        {
            InitializeComponent();
            close = false;
        }

        private void Sure_Load(object sender, EventArgs e)
        {

        }

        private void lblYes_Click(object sender, EventArgs e)
        {
            close = true;
            Close();
        }

        private void lblNo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
