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
    public partial class Form_Instellingen : Form
    {
        public static Form_Instellingen instance;
        public Form_Instellingen()
        {
            InitializeComponent();
            instance = this;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Instellingen_Load(object sender, EventArgs e)
        {

        }

        private void button_LiveActiviteit_Click(object sender, EventArgs e)
        {
            Form_LiveActiviteit form_LiveActiviteit = new Form_LiveActiviteit();
            Form_LiveActiviteit.instacne.Show();
            this.Close();
        }

        private void button_Meldingen_Click(object sender, EventArgs e)
        {
            Form_Meldingen form_Meldingen = new Form_Meldingen();
            Form_Meldingen.instacne.Show();
            this.Close();
        }

        private void button_Zones_Click(object sender, EventArgs e)
        {
            Form_Zones1 form_Zones1 = new Form_Zones1();
            Form_Zones1.instance.Show();
            this.Close();
        }

        private void button_Statistieken_Click(object sender, EventArgs e)
        {
            Form_Statistieken form_Statistieken = new Form_Statistieken();
            Form_Statistieken.instance.Show();
            this.Close();
        }

        private void button_Instelingen_Click(object sender, EventArgs e)
        {

        }
    }
}
