using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADGP_125;

namespace FF_At_the_scene_
{
    public partial class Combot : Form
    {
        LevelingSystem.Player _playerLevel = new LevelingSystem.Player(100);

        public Combot()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _playerLevel.Level();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_playerStats.Text = _playerLevel.PlayerStatInfo();
 
        }
    }
}
