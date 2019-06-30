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
    public partial class ExitGame : Form
    {
        public bool exit = false;
        public ExitGame()
        {
            InitializeComponent();
        }

        private void ExitGame_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            exit = true;
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
