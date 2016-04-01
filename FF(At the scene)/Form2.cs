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


        List<Unit> _el = new List<Unit>();

        Unit _ce;
        Unit p = new Unit();



        bool playerTurn =false;
        int count = 0;
        static bool click = false;

        public Combot()
        {
            InitializeComponent();

        }

        public List<Unit> EnemyList()
        {
            List<Unit> en = new List<Unit>(); 

            Unit _ene_caius = new Unit("Enemy", "Caius", 1000, 300, 30);
            Unit _ene_Kafka = new Unit("Enemy", "Kafka", 2000, 650, 50);
            Unit _ene_Shelke = new Unit("Enemy", "Shelke", 3000, 1000, 70);
            Unit _ene_Weiss = new Unit("Enemy", "Weiss", 4000, 1250, 90);
            Unit _ene_Lumina = new Unit("Enemy", "Lumina", 6000, 2400, 120);
            Unit _ene_Sephiroth = new Unit("Boss", "Sephiroth", 8000, 3000, 160);
            Unit _ene_Suprise = new Unit("Suprise", "Mimic", 100000, 1000000, 1000000000);


            en.Add(_ene_caius);
            en.Add(_ene_Kafka);
            en.Add(_ene_Shelke);
            en.Add(_ene_Weiss);
            en.Add(_ene_Lumina);
            en.Add(_ene_Sephiroth);
            en.Add(_ene_Suprise);

            return en;

        }

        public List<Image> EnemyPic()
        {
            List<Image> ep = new List<Image>();

            ep.Add(Properties.Resources.Caius);
            ep.Add(Properties.Resources.Kefka      );
            ep.Add(Properties.Resources.Shelke     );
            ep.Add(Properties.Resources.Weiss      );
            ep.Add(Properties.Resources.Lumina     );
            ep.Add(Properties.Resources.Sephiroth1 );
            ep.Add(Properties.Resources.Mimic_death);

            return ep;
        }
           
        private void Form2_Load(object sender, EventArgs e)
        {
            //pgb_eh.Value = _ce._health;
            //pgb_ph.Value = p._health;

            p = FF_Console._playersChoose; // Player Choosen by user 

            List<Unit> el = EnemyList();
            List<Image> epl = EnemyPic();
           

            _ce = el[count];



            pgb_ph.Maximum = p._health;
            pgb_ph.Value = p._health;

            pgb_eh.Maximum = _ce._health;
            pgb_eh.Value = _ce._health;

            if (pgb_eh.Value < 0)
            {
                _ce._alive = false;
                pic_EneAtt.BackgroundImage = epl[1 + count];
                pgb_eh = new ProgressBar();
            }
            else
            pic_EneAtt.BackgroundImage = epl[count];

            this.BackgroundImage = Properties.Resources.Combat_Envierment;
            pic_ChrAtt.BackgroundImage = FF_Console._currentCharacter;

            
           
            Random rn = new Random();
           
            if (rn.Next(0, 20) == 10 || rn.Next(0, 20) == 19)
                count = 10;
               
            txt_pn.Text = p._chrID;
            txt_en.Text = _ce._chrID;
            

            // Locks in whose turn it is 
            if (!playerTurn)
            { txt_Turns.Text = p._chrID + " Turn"; pic_ChrAtt.Enabled = true; pic_EneAtt.Enabled = false;  }
            else if (playerTurn)
            { txt_Turns.Text = _ce._chrID + " Turn"; pic_EneAtt.Enabled = true; pic_ChrAtt.Enabled = false; pic_EneAtt_Click(this.pic_EneAtt, null); }
                txt_Turns.Text += " " + count.ToString(); 
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

            if (_ce._health > pgb_eh.Minimum)
            {
                _ce._health -= p._dmg;
                pgb_eh.Value = _ce._health;
                
                playerTurn = true;
            }

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
