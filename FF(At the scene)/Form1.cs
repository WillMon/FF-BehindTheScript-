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

    enum gameFSM {Init, Start, Combot, IOsFile, End, }
     
    public partial class FF_Console : Form
    {
        public FF_Console()
        {
            
            InitializeComponent();
        }

        public Image _snow = Properties.Resources.Snow;
        public Image _rikku = Properties.Resources.Rikku;
        Charecters.Player _p_snow = new Charecters.Player("Sentinal","Snow", 1200, 100);
        Charecters.Player _p_rikku = new Charecters.Player("Mage", "Rikku", 880, 200 );
        FinistateStatMachine<gameFSM> _gameFSM = new FinistateStatMachine<gameFSM>(gameFSM.Init);
        int count = 0 ;
        private void FF_Console_Load(object sender, EventArgs e)
        {
            btn_mage.Visible = false;

            _gameFSM.AddStat(gameFSM.Init);
            _gameFSM.AddStat(gameFSM.Start);
            _gameFSM.AddStat(gameFSM.Combot);
            _gameFSM.AddStat(gameFSM.IOsFile);
            _gameFSM.AddStat(gameFSM.End);

            _gameFSM.AddTransiton(gameFSM.Init, gameFSM.Start);
            _gameFSM.AddTransiton(gameFSM.Start, gameFSM.Combot);
            _gameFSM.AddTransiton(gameFSM.Start, gameFSM.IOsFile);
            _gameFSM.AddTransiton(gameFSM.Start, gameFSM.End);
            _gameFSM.AddTransiton(gameFSM.Combot, gameFSM.IOsFile);
            _gameFSM.AddTransiton(gameFSM.Combot, gameFSM.End);
            _gameFSM.AddTransiton(gameFSM.IOsFile, gameFSM.Combot);

            _gameFSM.ChangeState(gameFSM.Start);

            BackgroundImage = Properties.Resources.main_backGround;
        }

        private void btn_sentinal_Click(object sender, EventArgs e)
        {
            txt_chrInfoDisplay.Text = "Class: " + _p_snow._chrClass + "\n                 " + "Name: " + _p_snow._chrID +  "\n                       " + "Health: " + _p_snow._health ;
            pic_Chr.BackgroundImage = _snow;
            _gameFSM.ChangeState(gameFSM.Start);
            btn_sentinal.Visible = false;
            btn_mage.Visible = true;

            
        }

        private void btn_mage_Click(object sender, EventArgs e)
        {
            txt_chrInfoDisplay.Text = "Class: " + _p_rikku._chrClass + "\n                 " + "Name: " + _p_rikku._chrID + "\n                       " + "Health: " + _p_rikku._health;
            pic_Chr.BackgroundImage = _rikku;
            _gameFSM.ChangeState(gameFSM.Start);
            btn_mage.Visible = false;
            btn_sentinal.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }

}
   //MessageBox.Show(lvl.Level().ToString());
           
            //var snow = Properties.Resources.Leon;

            //pic_Chr.BackgroundImage = snow; 