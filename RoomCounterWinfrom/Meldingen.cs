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
    public partial class Form_Meldingen : Form
    {
        public static Form_Meldingen instacne;
        public Form_Meldingen()
        {
            InitializeComponent();
            instacne = this;
        }

        private void button_LiveActiviteit_Click(object sender, EventArgs e)
        {
            Form_LiveActiviteit form_Zines = new Form_LiveActiviteit();
            Form_LiveActiviteit.instacne.Show();
            this.Close();
        }


        private void button_Meldingen_Click(object sender, EventArgs e)
        {

        }

        private void button_Zones_Click(object sender, EventArgs e)
        {
            Form_Zones1 form_Zines = new Form_Zones1();
            Form_Zones1.instance.Show();
            this.Close();
        }

        private void button_Statistieken_Click(object sender, EventArgs e)
        {
            Form_Statistieken form_Statistieken = new Form_Statistieken();
            Form_Statistieken.instance.Show();
            this.Close();
        }

        private void button_Instellingen_Click(object sender, EventArgs e)
        {
            Form_Instellingen form_Instelingen = new Form_Instellingen();
            Form_Instellingen.instance.Show();
            this.Close();
        }

        private void Form_Meldingen_Load(object sender, EventArgs e)
        {

        }
    }
}
