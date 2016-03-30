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


        Characters.Enemy _Ene_caius = new Characters.Enemy("Caius", 1000, 300, 30);
        Characters.Enemy _Ene_Kafka = new Characters.Enemy("Kafka",2000, 650, 50);
        Characters.Enemy _Ene_Shelke = new Characters.Enemy("Shelke", 3000, 1000, 70);
        Characters.Enemy _Ene_Weiss = new Characters.Enemy("Weiss", 4000, 1250, 90);
        Characters.Enemy _Ene_Lumina = new Characters.Enemy("Lumina", 6000, 2400, 120);
        Characters.Enemy _Ene_Sephiroth = new Characters.Enemy("Sephiroth",8000, 3000, 160);
        Characters.Enemy _Ene_Suprise = new Characters.Enemy("Mimic", 100000, 1000000, 1000000000);

        Dictionary<Image, Characters.Enemy> ed = new Dictionary<Image, Characters.Enemy>();

        Characters.Player p = new Characters.Player();
        DateTime _dt = new DateTime();

        
        bool pt = true;
        public Combot()
        {
            InitializeComponent();


            p = FF_Console._playersChoose; // Player Choosen by user


            LevelingSystem.Enemy _LSe_Caius = new LevelingSystem.Enemy(_Ene_caius);
            LevelingSystem.Player _playerLevel = new LevelingSystem.Player(_Ene_caius);
        }

        public void pdg_PlayerHealth()
        {
            p = FF_Console._playersChoose;

            pgb_ph.BackColor = Color.PaleGreen;
            pgb_ph.Maximum = p._health;
            pgb_ph.Value = p._health;
        }


        public void ASortmentOfEnemies() {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            pdg_PlayerHealth();

            BackgroundImage = Properties.Resources.Combat_Envierment;

            pic_ChrAtt.BackgroundImage = FF_Console._currentCharacter;

            // Turns off the pictureboss 
            if (!pt)
                pic_ChrAtt.Enabled = false;
            else if (pt)
                pic_EneAtt.Enabled = false;


        }




        private void pic_ChrAtt_Click(object sender, EventArgs e)
        {

        }
            

        private void btn_Return_To_Start_Click(object sender, EventArgs e)
        {
            FF_Console._gameFSM.ChangeState(gameFSM.Start);
            this.Hide();
        }

        public void DeltaTime()
        {
            
        }
    

        private void pgb_Turn_Click(object sender, EventArgs e)
        {

        }

        private void pic_EneAtt_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
