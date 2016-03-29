using System;
using System.Drawing;
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


            var a = Enum.GetValues(typeof(gameFSM));
            foreach (gameFSM f in a)
                _gameFSM.AddStat(f);

            _gameFSM.AddTransiton(gameFSM.Init, gameFSM.Start);
            _gameFSM.AddTransiton(gameFSM.Start, gameFSM.Combot);
            _gameFSM.AddTransiton(gameFSM.Start, gameFSM.IOsFile);
            _gameFSM.AddTransiton(gameFSM.Start, gameFSM.End);
            _gameFSM.AddTransiton(gameFSM.Combot, gameFSM.IOsFile);
            _gameFSM.AddTransiton(gameFSM.Combot, gameFSM.End);
            _gameFSM.AddTransiton(gameFSM.IOsFile, gameFSM.Combot);
        }


        public static Characters.Player _playersChoose;
        public static Image _currentCharacter;

        Button _btn_disabled;

        Combot _combot = new Combot();
        

        FinistateStatMachine<gameFSM> _gameFSM = new FinistateStatMachine<gameFSM>(gameFSM.Init);
        private void FF_Console_Load(object sender, EventArgs e)
        {
            pic_Chr.Enabled = false;
            txt_Introduction.Visible = false;

            btn_mage.Visible = false;
            btn_Warrior.Visible = false;

            btn_HelpCloseIntro.Visible = false;

            btn_Return.Visible = false;




            _gameFSM.ChangeState(gameFSM.Start);

            BackgroundImage = Properties.Resources.main_backGround;

        }
        /// <summary>
        ///
        /// </summary>
        public void btn_sentinalApp()
        {
            _btn_disabled = btn_sentinal;
            _currentCharacter = Properties.Resources.Snow;
            pic_Chr.Enabled = true; pic_Chr.BackgroundImage = _currentCharacter;

            btn_sentinal.Visible = false;
            btn_mage.Visible = true;
            btn_Warrior.Visible = false;
        }

        private void btn_sentinal_Click(object sender, EventArgs e)
        {
            
           
            Characters.Player _p_snow = new Characters.Player("Sentinal", "Snow", 1500, 200, 25);
         
            _playersChoose = _p_snow;
            txt_chrInfoDisplay.Text = _p_snow.PlayerInfo();

            btn_sentinalApp();
           
            _gameFSM.ChangeState(gameFSM.Start);
           



        }
        public void btn_mageApp()
        {
            _btn_disabled = btn_mage;
            _currentCharacter = Properties.Resources.Rikku;

            pic_Chr.Enabled = true;
            pic_Chr.BackgroundImage = _currentCharacter;

            btn_mage.Visible = false;
            btn_Warrior.Visible = true;
            btn_sentinal.Visible = false;

        }

        private void btn_mage_Click(object sender, EventArgs e)
        {
            
            
            Characters.Player _p_rikku = new Characters.Player("Mage", "Rikku", 880, 100, 30);
           
            _playersChoose = _p_rikku;
             txt_chrInfoDisplay.Text = _p_rikku.PlayerInfo();
            btn_mageApp();

            _gameFSM.ChangeState(gameFSM.Start);
           
        }

        public void btn_warriorApp()
        {
            _btn_disabled = btn_Warrior;
            _currentCharacter = Properties.Resources.Refia;

            pic_Chr.Enabled = true;
            pic_Chr.BackgroundImage = _currentCharacter;

            btn_sentinal.Visible = true;
            btn_mage.Visible = false;
            btn_Warrior.Visible = false;

        }

        private void btn_Warrior_Click(object sender, EventArgs e)
        {
          
           
            Characters.Player _p_refia = new Characters.Player("Warrior", "Refia", 1200, 130, 45);
           
            _playersChoose = _p_refia;
            txt_chrInfoDisplay.Text = _p_refia.PlayerInfo();

            btn_warriorApp();
           
            _gameFSM.ChangeState(gameFSM.Start);
          
        }

        private void pic_Chr_Click(object sender, EventArgs e)
        {
            pic_Chr.Enabled = false;

            _btn_disabled.Enabled = false;
           

            _combot.Show();
            _gameFSM.ChangeState(gameFSM.Combot);

        }

        private void btn_Help_Click(object sender, EventArgs e)
        {

            txt_Introduction.Visible = true;
            btn_Help.Visible = false;
            btn_HelpCloseIntro.Visible = true;

        }

        private void btn_HelpCloseIntro_Click(object sender, EventArgs e)
        {
            txt_Introduction.Visible = false;
            btn_HelpCloseIntro.Visible = false;
            btn_Help.Visible = true;
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void Return_Click(object sender, EventArgs e)
        {

            _combot.Show();

        }
    }

}