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

    public partial class Combat : Form
    {

        // List of the Optional enemies
        List<Unit> _el = new List<Unit>();
        // Keeps tab of the current enemy
        Unit currentEnemy;
        // Keeps tab on the currnet enemy image
        Image currentEnemyImage;
       // keeps tab of the current player 


        // Keeps tab on current turn 
        bool playerTurn = false;
        
        public static int enemyCounter = 0;

        

        public Combat()
        {
            InitializeComponent();

        }

        //Cresats a list for all the possible enemies in game
        public static  List<Unit> EnemyList()
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
        public static List<Image> EnemyPic()
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
        public static List<Unit> enemeyList;
        public static List<Image> enemeyImageList;

        Form3 End;

        // Event runs at start of the Form
        private void Form2_Load(object sender, EventArgs e)
        {

            // Sets current palyer to to p

            // Set Current list of all the enemies in game outside of the heap
            enemeyList = EnemyList();
            // Set Curret list of all the enemy illostration outside of the Heap
            enemeyImageList = EnemyPic();

            // set current enemy outside of the heap
            currentEnemy = enemeyList[enemyCounter]; 
            //  Set current enemey illostration outside of the Heap
            currentEnemyImage = enemeyImageList[enemyCounter];

            // Sets Starting enemy ilosstration to the ENemy Picture box
            pic_EnemyAttack.BackgroundImage = currentEnemyImage;

            pic_PlayerAttack.BackgroundImage = FF_Console._currentCharacter;

            // Set Max value and the value that eill be decramented from on the Player side of the Health Bar 
            pgb_playerHealth.Maximum = FF_Console._playersChoose._health; 
            pgb_playerHealth.Value = FF_Console._playersChoose._health;


            // Set Max value and the value that eill be decramented from on the Enemy side of the Health Bar 
            expBar.Maximum = FF_Console._playersChoose._expCap;
            expBar.Value = FF_Console._playersChoose._exp;


            // Set Max value and the value that eill be decramented from on the Player side of the Health Bar 
            pgb_EnemyHealth.Maximum = currentEnemy._health;
            pgb_EnemyHealth.Value = currentEnemy._health;

            // Set the Forms Background illostration
            this.BackgroundImage = Properties.Resources.Combat_Envierment;
            
            // Display turnd to user
            txt_Turns.Text = FF_Console._playersChoose._chrID + " Turn";

            //Displays current player/Enemeys Name to the user
            txt_pn.Text = FF_Console._playersChoose._chrID;
            txt_en.Text = currentEnemy._chrID;

             End = new Form3();


            
        }
        // Updates the next state of the game
        private void gameUpdate()
        {
            Random rn = new Random();

            

            if (currentEnemy._health <= 0)
            {
                currentEnemy._alive = false;
                FF_Console._playersChoose._exp += currentEnemy._exp;
                FF_Console._playersChoose.Level();

                expBar.Maximum = FF_Console._playersChoose._expCap;
                expBar.Value = FF_Console._playersChoose._exp;
                if (rn.Next(0, 20) == 10 || rn.Next(0, 20) == 19)
                    enemyCounter = 6;
                else
                ++enemyCounter;


                pgb_EnemyHealth.Maximum = enemeyList[enemyCounter]._health;
                pgb_EnemyHealth.Value = enemeyList[enemyCounter]._health;
                txt_en.Text = enemeyList[enemyCounter]._chrID;


                if (pgb_EnemyHealth.Value <= 0)
                {
                    pgb_EnemyHealth = new ProgressBar();
                    pgb_EnemyHealth.Maximum = currentEnemy._health;
                }
                currentEnemy = enemeyList[enemyCounter];
                currentEnemyImage = enemeyImageList[enemyCounter];
                
               
            }

        }

        private void palyerTurn()
        {
            // Locks in whose turn it is 
            if (!playerTurn)
            { txt_Turns.Text = FF_Console._playersChoose._chrID + " Turn"; pic_PlayerAttack.Enabled = true; pic_EnemyAttack.Enabled = false; }
            else if (playerTurn)
            { txt_Turns.Text = currentEnemy._chrID + " Turn";  pic_EnemyAttack_Click(this.pic_EnemyAttack, null); }
            

        }
        
        public static void GameRest()
        {
            FF_Console._playersChoose = new Unit();
            enemeyImageList = EnemyPic();
            enemeyList = EnemyList();

            enemyCounter = 0;

        }

        private void pic_PlayerAttack_Click(object sender, EventArgs e)
        {
            currentEnemy.TakeDmg(FF_Console._playersChoose);

            
            expBar.Maximum = FF_Console._playersChoose._expCap;
            expBar.Value = FF_Console._playersChoose._exp;
            
            pgb_EnemyHealth.Value = currentEnemy._health;

            playerTurn = true;
            palyerTurn();


            if (FF_Console._playersChoose._health <= 0 || enemyCounter == 6)
            {

                End.Show();

                GameRest();

                pic_PlayerAttack.Enabled = false;
                pic_EnemyAttack.Enabled = false;

            }
            pgb_playerHealth.Value = FF_Console._playersChoose._health;


        }
        // Updates the game on player click 
        private void pic_EnemyAttack_Click(object sender, EventArgs e)
        {
            FF_Console._playersChoose.TakeDmg(currentEnemy);


            if (FF_Console._playersChoose._health <= 0)
            {
                End.Show();
                GameRest();
            }
            

            gameUpdate();
            pic_EnemyAttack.BackgroundImage = currentEnemyImage;
            playerTurn = false;


            if (currentEnemy._health <= 0)
            {
                pic_PlayerAttack.Enabled = false;
                pic_EnemyAttack.Enabled = false;
                FF_Console._playersChoose._exp += currentEnemy._exp;
                pgb_playerHealth.Value = 0;

            }
            else
            pgb_playerHealth.Value = FF_Console._playersChoose._health;
            
        }

        // Transitions back to the Starting state
        private void btn_Return_To_Start_Click(object sender, EventArgs e)
        {

            FF_Console._gameFSM.ChangeState(gameFSM.Start);

            this.Hide();
        }


        private void btn_SaveGame_Click(object sender, EventArgs e)
        {
            Utilities.SerializeXML<Unit>("PlayersChoose", FF_Console._playersChoose, @"C:\Users\william.montero\Desktop\FF-BehindTheScript-\FF(At the scene)\SaveLoad\");
        }
    }
}
