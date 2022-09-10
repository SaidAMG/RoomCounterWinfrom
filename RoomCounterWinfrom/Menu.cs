using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomCounterWinfrom
{
    public partial class Form_Menu : Form
    {
        public static Form_Menu instacne;
        public Form_Menu()
        {
            InitializeComponent();
            instacne = this;
        }

        private void button_instellingen_Click(object sender, EventArgs e)
        {
            //Label_page.Text = "Instellingen";
            //pictureBox_logo.Hide();
            Form_Instellingen f1 = new Form_Instellingen();
            f1 .Show();
        }

        private void button_statistieken_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Statistieken f1 = new Form_Statistieken();
            f1.Show();
        }

        private void button_Zones_Click(object sender, EventArgs e)
        {
            
            Form_Zones1 f1 = new Form_Zones1();
            Form_Zones1.instance.Show();
        }

        private void button_Meldingen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Meldingen f1 = new Form_Meldingen();
            f1.Show();
        }

        private void button_LiveActiviteit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_LiveActiviteit f1 = new Form_LiveActiviteit();
            f1.Show();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
