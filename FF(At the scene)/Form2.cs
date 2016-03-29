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
        

        Characters.Enemy _Chre_caius = new Characters.Enemy("Caius", 1000, 400, 200, 30);
        Characters.Player p = new Characters.Player();

        public Combot()
        {
            InitializeComponent();
            p = FF_Console._playersChoose;

            LevelingSystem.Enemy _LSe_Caius = new LevelingSystem.Enemy(_Chre_caius);
            LevelingSystem.Player _playerLevel = new LevelingSystem.Player(_Chre_caius);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Combat_Envierment;

            pic_Chr.BackgroundImage = FF_Console._currentCharacter;

            pgb_Turn.BackColor = Color.Gold;

            while(pgb_Turn.Value <= pgb_Turn.Maximum)
                pgb_Turn.Value += timer_Player.Interval;
            //_playerLevel.Level();

        }

 
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pic_Chr_Click(object sender, EventArgs e)
        {

        }
    }
}
