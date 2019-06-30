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
    public partial class HighScores : Form
    {
        public List<Player> players;
        public HighScores(List<Player> players)
        {
            InitializeComponent();
            this.players = players;
            najdobri();
        }

        private void najdobri()
        {
            players = players.OrderByDescending(x => x.points).ToList();
            for (int i = 0; i < players.Count; i++)
            {
                lbBestPlayers.Items.Add(players[i]);
            }

        }

        private void HighScores_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
