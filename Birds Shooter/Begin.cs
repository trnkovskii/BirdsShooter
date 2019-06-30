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
    public partial class Begin : Form
    {
        public string nivo;
        public List<Player> niza;
        public Begin(List<Player> n)
        {
            InitializeComponent();
            nivo = "Easy";
            niza = n;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HighScores najnova = new HighScores(niza);

            najnova.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HowToPlay h = new HowToPlay();
            h.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                nivo = "Easy";
            else if (radioButton2.Checked)
                nivo = "Medium";
            else
                nivo = "Hard";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Sure s = new Sure();
            s.ShowDialog();
            if (s.close == true)
                Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Player POM = null;
            Form1 prvo = new Form1(nivo, POM, niza);

            prvo.ShowDialog();
        }
    }
}
