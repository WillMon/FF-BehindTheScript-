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
    enum ChrSelect { SENTINAL, MAGE, COMMANDER}
    public partial class FF_Console : Form
    {
        int count = 0 ;
        private void FF_Console_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.bg_Screen;
        }
        
        public FF_Console()
        {
            
            InitializeComponent();
        }

        private void pic_Chr_Click(object sender, EventArgs e)
        {

        }

        private void btn_Press_Click_1(object sender, EventArgs e)
        {
            FinistateStatMachine chrSelect = new FinistateStatMachine(ChrSelect.SENTINAL);

            
            switch (count)
            {
                case 0:
                    Charecters.Sentinel _sent = new Charecters.Sentinel(500, 75);
                    var snow = Properties.Resources.Snow;
                    txt_StatDispaly.Show();
                    pic_Chr.BackgroundImage = snow;
                    break;
                case 1:
                    Charecters.Mage _mage = new Charecters.Mage(255, 100);
                    var leon = Properties.Resources.Rikku;
                    txt_StatDispaly.Show();
                    pic_Chr.BackgroundImage = leon;
                    break;
            }
            ++count;
            if (count >= 2)
                count = 0;
                    LevelingSystem lvl = new LevelingSystem(190);
   
            lvl.Level();
            //MessageBox.Show(lvl.m_level.ToString());
        }

        private void pic_Chr_Click_1(object sender, EventArgs e)
        {

        }
    }
}
   //MessageBox.Show(lvl.Level().ToString());
           
            //var snow = Properties.Resources.Leon;

            //pic_Chr.BackgroundImage = snow;