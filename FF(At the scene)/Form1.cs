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
     
    public partial class FF_Console : Form
    {
        public FF_Console()
        {
            
            InitializeComponent();
        }
        public static string _intiString = "This is whats needed to be displayed";
        string _button1 = "Transition";
        string _button2 = "Next Transition";
        FinistateStatMachine<string> GAMEFSM = new FinistateStatMachine<string>(_intiString);
        

        public static  Image snow = Properties.Resources.Snow;
        public Image m_snow = Properties.Resources.Snow;
        public Image m_rikku = Properties.Resources.Rikku;

        FinistateStatMachine<Image> chrSelect = new FinistateStatMachine<Image>(snow);
        int count = 0 ;
        private void FF_Console_Load(object sender, EventArgs e)
        {

            txt_Display.Text = GAMEFSM.CurrentStat();

            GAMEFSM.AddStat(_button1);
            GAMEFSM.AddStat(_button2);

            GAMEFSM.AddTransiton(_intiString, _button1);
            GAMEFSM.AddTransiton(_button1, _button2);




            //chrSelect.AddStat(snow);
            //chrSelect.AddStat(m_rikku);

            //chrSelect.AddTransiton(snow, m_snow);
            //chrSelect.AddTransiton(m_snow, m_rikku);
            //chrSelect.AddTransiton(m_rikku, m_snow);
            // The Image placed on the Main Screen

            BackgroundImage = Properties.Resources.main_backGround;
        }
        
       

        private void pic_Chr_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Press_Click_1(object sender, EventArgs e)
        {
            
            pic_Chr.BackgroundImage = chrSelect.CurrentStat();
            

            
            
            
            //MessageBox.Show(lvl.m_level.ToString());
        }

        private void pic_Chr_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_StatsCheck_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Init_Click(object sender, EventArgs e)
        {
            GAMEFSM.ChangeState(_button1);
           txt_Display.Text = GAMEFSM.CurrentStat();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            GAMEFSM.ChangeState(_button2);
            txt_Display.Text = GAMEFSM.CurrentStat();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
   //MessageBox.Show(lvl.Level().ToString());
           
            //var snow = Properties.Resources.Leon;

            //pic_Chr.BackgroundImage = snow; 