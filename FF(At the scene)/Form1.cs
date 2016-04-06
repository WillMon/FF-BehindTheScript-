using System;
using System.Drawing;
using System.Windows.Forms;
using ADGP_125;

namespace FF_At_the_scene_
{

    public enum gameFSM {Init, Start, Combot, IOsFile, End, }

    public partial class FF_Console : Form
    {
        //set Console set the FiniteStateMachine at the start of the game 
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
        // Player choosen by user
        public static Unit _playersChoose;
        // Current player Imgae on Display
        public static Image _currentCharacter;
        // Ketp tabs on the buttons br used in the player
        Button _btn_disabled;
        // refuers to the combat form
        Combat _combat = new Combat();
        // creats a nnew object 
        public static FinistateStatMachine<gameFSM> _gameFSM = new FinistateStatMachine<gameFSM>(gameFSM.Init);
        private void FF_Console_Load(object sender, EventArgs e)
        {
            pic_Chr.Enabled = false;
            txt_Introduction.Visible = false;

            btn_mage.Visible = false;
            btn_Warrior.Visible = false;

            btn_HelpCloseIntro.Visible = false;

            btn_Return.Visible = false;


            Utilities.SerializeXML<Unit>("PlayersChoose", _playersChoose, @"C:\Users\william.montero\Desktop\FF-BehindTheScript-\FF(At the scene)\SaveLoad\");
            _gameFSM.ChangeState(gameFSM.Start);

            BackgroundImage = Properties.Resources.main_backGround;

        }
        /// <summary>
        ///
        /// </summary>
       //What makes up a Sentinel
        public void btn_sentinelApp()
        {
            _btn_disabled = btn_sentinal;
            _currentCharacter = Properties.Resources.Snow;
            pic_Chr.Enabled = true; pic_Chr.BackgroundImage = _currentCharacter;

            btn_sentinal.Visible = false;
            btn_mage.Visible = true;
            btn_Warrior.Visible = false;
        }
        // Places the information for what a sentinel in game
        private void btn_sentinal_Click(object sender, EventArgs e)
        {


            _playersChoose = new Unit("Sentinal", "Snow", 1500, 0, 250);
         
            txt_chrInfoDisplay.Text = _playersChoose.PlayerInfo;

            btn_sentinelApp();
           
            _gameFSM.ChangeState(gameFSM.Start);




        }
        //What makes up a Mage
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
        // Places the information for what a Mage in game
        private void btn_mage_Click(object sender, EventArgs e)
        {


            _playersChoose = new Unit("Mage", "Rikku", 880,0, 435);
           
             txt_chrInfoDisplay.Text = _playersChoose.PlayerInfo;
            btn_mageApp();

            _gameFSM.ChangeState(gameFSM.Start);
           
        }
        //What makes up a Warrior 
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
        // Places the information for what a Warrior in game
        private void btn_Warrior_Click(object sender, EventArgs e)
        {


            _playersChoose = new Unit("Warrior", "Refia", 1200,0, 305);
           
            txt_chrInfoDisplay.Text = _playersChoose.PlayerInfo;

            btn_warriorApp();
           
            _gameFSM.ChangeState(gameFSM.Start);
          
        }
        /// <summary>
        ///  Disables all posibale out comes when the Picture box has been clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pic_Player_Click(object sender, EventArgs e)
        {
            pic_Chr.Enabled = false;

            _btn_disabled.Enabled = false;

            btn_sentinal.Visible = false;
            btn_mage.Visible = false;
            btn_Warrior.Visible = false;

            btn_Return.Visible = true;

            _combat.Show();
            _gameFSM.ChangeState(gameFSM.Combot);

        }

        private void btn_Help_Click(object sender, EventArgs e)
        {

            txt_Introduction.Visible = true;
            btn_Help.Visible = false;
            btn_HelpCloseIntro.Visible = true;

        }
        // Displayes to the user how to play the game
        private void btn_HelpCloseIntro_Click(object sender, EventArgs e)
        {
            txt_Introduction.Visible = false;
            btn_HelpCloseIntro.Visible = false;
            btn_Help.Visible = true;
        }
        // Closes the game
        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       // Returns back to the combot From
        private void Return_Click(object sender, EventArgs e)
        {
            _combat.Show();
            

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
           _playersChoose = Utilities.DeserializeXML<Unit>(@"C:\Users\william.montero\Desktop\FF-BehindTheScript-\FF(At the scene)\SaveLoad\PlayersChoose");

        }

        
    }

}
