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

        // List of the Optional enemies
        List<Unit> _el = new List<Unit>();
        // Keeps tab of the current enemy
        Unit currentEnemy;
        // Keeps tab on the currnet enemy image
        Image currentEnemyImage;
       // keeps tab of the current player 
        Unit Player = new Unit();

        // Keeps tab on current turn 
        bool playerTurn = false;
        
        int enemyCounter = 0;

        

        public Combot()
        {
            InitializeComponent();

        }

        //Cresats a list for all the possible enemies in game
        public List<Unit> EnemyList()
        {
            List<Unit> Enemy = new List<Unit>();

            Unit _ene_caius = new Unit("Enemy", "Caius", 1000, 300, 30);
            Unit _ene_Kafka = new Unit("Enemy", "Kafka", 2000, 650, 50);
            Unit _ene_Shelke = new Unit("Enemy", "Shelke", 3000, 1000, 70);
            Unit _ene_Weiss = new Unit("Enemy", "Weiss", 4000, 1250, 90);
            Unit _ene_Lumina = new Unit("Enemy", "Lumina", 6000, 2400, 120);
            Unit _ene_Sephiroth = new Unit("Boss", "Sephiroth", 8000, 3000, 160);
            Unit _ene_Suprise = new Unit("Suprise", "Mimic", 100000, 1000000, 1000000000);


            Enemy.Add(_ene_caius);
            Enemy.Add(_ene_Kafka);
            Enemy.Add(_ene_Shelke);
            Enemy.Add(_ene_Weiss);
            Enemy.Add(_ene_Lumina);
            Enemy.Add(_ene_Sephiroth);
            Enemy.Add(_ene_Suprise);

            return Enemy;

        }

        // creats a list for the enemy illustration 
        public List<Image> EnemyPic()
        {
            List<Image> ep = new List<Image>();

            ep.Add(Properties.Resources.Caius);
            ep.Add(Properties.Resources.Kefka);
            ep.Add(Properties.Resources.Shelke);
            ep.Add(Properties.Resources.Weiss);
            ep.Add(Properties.Resources.Lumina);
            ep.Add(Properties.Resources.Sephiroth1);
            ep.Add(Properties.Resources.Mimic_death);

            return ep;
        }
        //Temp variables for the (EnemyList, EnemyPic)

        // el well holr 
        List<Unit> enmeyList;
        List<Image> enmeyImageList;

        // Event runs at start of the Form
        private void Form2_Load(object sender, EventArgs e)
        {

            // Sets current palyer to to p
            Player = FF_Console._playersChoose; // Player Choosen by user 

            // Set Current list of all the enemies in game outside of the heap
            enmeyList = EnemyList();
            // Set Curret list of all the enemy illostration outside of the Heap
            enmeyImageList = EnemyPic();

            // set current enemy outside of the heap
            currentEnemy = enmeyList[enemyCounter]; 
            //  Set current enemey illostration outside of the Heap
            currentEnemyImage = enmeyImageList[enemyCounter];

            // Sets Starting enemy ilosstration to the ENemy Picture box
            pic_EneAtt.BackgroundImage = currentEnemyImage;

            pic_ChrAtt.BackgroundImage = FF_Console._currentCharacter;

            // Set Max value and the value that eill be decramented from on the Player side of the Health Bar 
            pgb_ph.Maximum = Player._health; 
            pgb_ph.Value = Player._health;


            // Set Max value and the value that eill be decramented from on the Enemy side of the Health Bar 
            expBar.Maximum = Player._expCap;
            expBar.Value = Player._exp;


            // Set Max value and the value that eill be decramented from on the Player side of the Health Bar 
            pgb_eh.Maximum = currentEnemy._health;
            pgb_eh.Value = currentEnemy._health;

            // Set the Forms Background illostration
            this.BackgroundImage = Properties.Resources.Combat_Envierment;
            
            // Display turnd to user
            txt_Turns.Text = Player._chrID + " Turn";

            //Displays current player/Enemeys Name to the user
            txt_pn.Text = Player._chrID;
            txt_en.Text = currentEnemy._chrID;


            
        }
        // Updates the next state of the game
        private void gameUpdate()
        {
            Random rn = new Random();

            

            if (currentEnemy._health <= 0)
            {
                currentEnemy._alive = false;
                Player._exp += currentEnemy._exp;
                Player.Level();

                expBar.Maximum = Player._expCap;
                expBar.Value = Player._exp;
                ++enemyCounter;



                pgb_eh.Maximum = enmeyList[enemyCounter]._health;
                pgb_eh.Value = enmeyList[enemyCounter]._health;
                txt_en.Text = enmeyList[enemyCounter]._chrID;


                if (pgb_eh.Value <= 0)
                {
                    pgb_eh = new ProgressBar();
                    pgb_eh.Maximum = currentEnemy._health;
                }
                currentEnemy = enmeyList[enemyCounter];
                currentEnemyImage = enmeyImageList[enemyCounter];
                
                //if (rn.Next(0, 20) == 10 || rn.Next(0, 20) == 19)
                //    count = 10;
            }

        }

        private void palyerTurn()
        {
            // Locks in whose turn it is 
            if (!playerTurn)
            { txt_Turns.Text = Player._chrID + " Turn"; pic_ChrAtt.Enabled = true; pic_EneAtt.Enabled = false; }
            else if (playerTurn)
            { txt_Turns.Text = currentEnemy._chrID + " Turn";  pic_EneAtt_Click(this.pic_EneAtt, null); }
            txt_Turns.Text += " " + enemyCounter.ToString();

        }
 

        private void pic_ChrAtt_Click(object sender, EventArgs e)
        {
            currentEnemy.TakeDmg(Player);

            
            expBar.Maximum = Player._expCap;
            expBar.Value = Player._exp;
            
            pgb_eh.Value = currentEnemy._health;

            playerTurn = true;
            palyerTurn();


        }
        // Updates the game on player click 
        private void pic_EneAtt_Click(object sender, EventArgs e)
        {
            Player.TakeDmg(currentEnemy);

            pgb_ph.Value = Player._health;

            gameUpdate();
            pic_EneAtt.BackgroundImage = currentEnemyImage;
            playerTurn = false;


            if(currentEnemy._health <= 0)
                Player._exp += currentEnemy._exp;



            txt_Turns.Text += Player.PlayerInfo;
        }

        // Transitions back to the Starting state
        private void btn_Return_To_Start_Click(object sender, EventArgs e)
        {
            FF_Console._gameFSM.ChangeState(gameFSM.Start);
            this.Hide();
        }

        public void DeltaTime()
        {
            
        }

      
            
        

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pn_TextChanged(object sender, EventArgs e)
        {

        }

        private void CombatQuitButton_Click(object sender, EventArgs e)
        {
           
  
        }

       
    }
}
