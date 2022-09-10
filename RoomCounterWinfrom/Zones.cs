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
    public partial class Form_Zones1 : Form
    {
        public static Form_Zones1 instance;
        public DAL dal;
        int zoneID;

        public Form_Zones1()
        {
            InitializeComponent();
            instance = this;
            dal = new DAL();
            zoneID = 0;
        }

        private void Zones_Load(object sender, EventArgs e)
        {
            foreach( Zone z in dal.zoneList)
            {
                dataGridView_Zones.Rows.Add(z.ID,z.Name);
            }
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

        }

        private void button_statistieken_Click(object sender, EventArgs e)
        {
            Form_Statistieken form_Statistieken = new Form_Statistieken();
            Form_Statistieken.instance.Show();
            this.Close();
        }

        private void button_instellingen_Click(object sender, EventArgs e)
        {
            Form_Instellingen form_Instellingen = new Form_Instellingen();
            Form_Instellingen.instance.Show();
            this.Show();
        }

        private void dataGridView_Zones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_AddZone_Click(object sender, EventArgs e)
        {
            
            Zone toAddZone = new Zone(0,textBox_NameZone.Text,Int32.Parse(textBox_MaxPeople.Text));
            dal.CreateZone(toAddZone);

            dataGridView_Zones.Rows.Clear();
            foreach (Zone z in dal.zoneList)
            {
                dataGridView_Zones.Rows.Add(z.ID, z.Name);
            }
        }

        private void button_DeleteZone_Click(object sender, EventArgs e)
        {
            Zone toDeleteZone = new Zone(zoneID, textBox_NameZone.Text, Int32.Parse(textBox_MaxPeople.Text));
            dal.DeleteZone(toDeleteZone);
            
            dataGridView_Zones.Rows.Clear();
            foreach (Zone z in dal.zoneList)
            {
                dataGridView_Zones.Rows.Add(z.ID, z.Name);
            }

            textBox_NameZone.Text = "";
            textBox_MaxPeople.Text = "";
        }

        private void button_UpdateZone_Click(object sender, EventArgs e)
        {
            Zone toDeleteZone = new Zone(zoneID, textBox_NameZone.Text, Int32.Parse(textBox_MaxPeople.Text));
            dal.UpdateZone(toDeleteZone);

            dataGridView_Zones.Rows.Clear();
            foreach (Zone z in dal.zoneList)
            {
                dataGridView_Zones.Rows.Add(z.ID, z.Name);
            }

            textBox_NameZone.Text = "";
            textBox_MaxPeople.Text = "";
        }

        private void dataGridView_Zones_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach(Zone z in dal.zoneList)
            {
                if (!(e.RowIndex < 0))
                {
                    if (z.ID == Int32.Parse(dataGridView_Zones.Rows[e.RowIndex].Cells[0].Value.ToString()))
                    {
                        zoneID = z.ID;
                        textBox_NameZone.Text = z.Name;
                        textBox_MaxPeople.Text = z.MaxPeople.ToString();
                    }
                }
                
            }
        }

        private void button_LocatieVerwijzing_Click(object sender, EventArgs e)
        {
            Form_AddLocation form_AddLocation = new Form_AddLocation();
            Form_AddLocation.instance.Show();
        }
    }
}
