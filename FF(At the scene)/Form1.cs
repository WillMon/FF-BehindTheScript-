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
        public static  Image snow = Properties.Resources.Snow;
        public Image rikku = Properties.Resources.Rikku;

        FinistateStatMachine<Image> chrSelect = new FinistateStatMachine<Image>(snow);
        int count = 0 ;
        private void FF_Console_Load(object sender, EventArgs e)
        {
            pic_Chr.BackgroundImage =  chrSelect.m_currentState;
            

           

            

            
            
            // The Image placed on the MAin Screen
            BackgroundImage = Properties.Resources.main_backGround;
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
            chrSelect.AddTransiton(snow, rikku);
            chrSelect.AddTransiton(rikku, snow);

            chrSelect.AddStat(snow);
            chrSelect.AddStat(rikku);

            chrSelect.ChangeState(rikku);
            //MessageBox.Show(lvl.m_level.ToString());
        }

        private void pic_Chr_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_StatsCheck_Click(object sender, EventArgs e)
        {
           
        }
    }

}
   //MessageBox.Show(lvl.Level().ToString());
           
            //var snow = Properties.Resources.Leon;

            //pic_Chr.BackgroundImage = snow;