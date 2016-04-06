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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            FF_Console._playersChoose = Utilities.DeserializeXML<Unit>(@"C:\Users\william.montero\Desktop\FF-BehindTheScript-\FF(At the scene)\SaveLoad\PlayersChoose");
        }

        // Resets the game stat
        private void button2_Click(object sender, EventArgs e)
        {
           

            Combat.GameRest();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
    }
}
