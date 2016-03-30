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


        Characters.Enemy _ene_caius = new Characters.Enemy("Caius", 800, 300, 30);
        Characters.Enemy _ene_Kafka = new Characters.Enemy("Kafka",1700, 650, 50);
        Characters.Enemy _ene_Shelke = new Characters.Enemy("Shelke", 3000, 1000, 70);
        Characters.Enemy _ene_Weiss = new Characters.Enemy("Weiss", 4000, 1250, 90);
        Characters.Enemy _ene_Lumina = new Characters.Enemy("Lumina", 6000, 2400, 120);
        Characters.Enemy _ene_Sephiroth = new Characters.Enemy("Sephiroth",8000, 3000, 160);
        Characters.Enemy _ene_Suprise = new Characters.Enemy("Mimic", 100000, 1000000, 1000000000);

        Characters.Enemy _ce;

        Dictionary<Image, Characters.Enemy> ed = new Dictionary<Image, Characters.Enemy>();

        Characters.Player p = new Characters.Player();
        DateTime _dt = new DateTime();

        bool playerTurn =false;
        int count = 0;
        static bool click = false;

        public Combot()
        {
            InitializeComponent();

            ed.Add(Properties.Resources.Caius, _ene_caius);
            ed.Add(Properties.Resources.Kefka, _ene_Kafka);
            ed.Add(Properties.Resources.Shelke, _ene_Shelke);
            ed.Add(Properties.Resources.Weiss, _ene_Weiss);
            ed.Add(Properties.Resources.Lumina, _ene_Lumina);
            ed.Add(Properties.Resources.Sephiroth1, _ene_Sephiroth);
            ed.Add(Properties.Resources.Mimic_death, _ene_Suprise);

           


            p = FF_Console._playersChoose; // Player Choosen by user


            LevelingSystem.Enemy _LSe_Caius = new LevelingSystem.Enemy(_ene_caius);
            LevelingSystem.Player _playerLevel = new LevelingSystem.Player(_ene_caius);
        }

 
        private void Form2_Load(object sender, EventArgs e)
        {
            _ce = _ene_caius;


            Random rn = new Random();
           
            if (rn.Next(0, 20) == 10 || rn.Next(0, 20) == 19)
                count = 10;

        


            p = FF_Console._playersChoose;

            

            this.BackgroundImage = Properties.Resources.Combat_Envierment;
            pic_ChrAtt.BackgroundImage = FF_Console._currentCharacter;
          

            
           
           
            switch (count)
            {
                case 0: _ce = _ene_caius; pic_EneAtt.BackgroundImage = Properties.Resources.Caius;

                    break;
                case 1:
                    _ce = _ene_Kafka; pic_EneAtt.BackgroundImage = Properties.Resources.Kefka;

                    break;
                case 2:
                    _ce = _ene_Shelke; pic_EneAtt.BackgroundImage = Properties.Resources.Shelke;
   
                    break;
                case 3:
                    _ce = _ene_Weiss; pic_EneAtt.BackgroundImage = Properties.Resources.Weiss;
  
                    break;
                case 4:
                    _ce = _ene_Lumina; pic_EneAtt.BackgroundImage = Properties.Resources.Lumina;
   
                    break;
                case 5:
                    _ce = _ene_Sephiroth;  pic_EneAtt.BackgroundImage = Properties.Resources.Sephiroth1;
                    break;
                case 10:
                    _ce = _ene_Suprise; pic_EneAtt.BackgroundImage = Properties.Resources.Mimic_death;
 
                    break; 
            }
             
               if (_ce._health <= 0)
                ++count;
            txt_pn.Text = p._chrID;
            txt_en.Text = _ce._chrID;
            
           
            pgb_ph.Maximum = p._health;
            pgb_ph.Value = p._health;

            pgb_eh.Maximum = _ce._health;
            pgb_eh.Value = _ce._health;



            // Locks in whose turn it is 
            if (!playerTurn)
            { txt_Turns.Text = p._chrID + " Turn"; pic_ChrAtt.Enabled = true; pic_EneAtt.Enabled = false;  }
            else if (playerTurn)
            { txt_Turns.Text = _ce._chrID + " Turn"; pic_EneAtt.Enabled = true; pic_ChrAtt.Enabled = false; pic_EneAtt_Click(this.pic_EneAtt, null); }

        }

   private void ResolveTurn(bool turn)
     {

         // Locks in whose turn it is 
         if (!playerTurn)
         {
             txt_Turns.Text = p._chrID + " Turn";
             pic_ChrAtt.Enabled = true;
             pic_EneAtt.Enabled = false;
             return;
         }
         
          txt_Turns.Text = _ce._chrID + " Turn";
         pic_EneAtt.Enabled = true;
         pic_ChrAtt.Enabled = false;
         pic_EneAtt_Click(this.pic_EneAtt, null); 
         playerTurn = !turn;
     }

private void pic_ChrAtt_Click(object sender, EventArgs e)
        {
            if (_ce._health >= 0)
                
            _ce._health -= p._dmg;
            pgb_eh.Value = _ce._health;
            playerTurn = true;


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
            p._health -= _ce._dmg;
            pgb_ph.Value = p._health;
            playerTurn = false;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
