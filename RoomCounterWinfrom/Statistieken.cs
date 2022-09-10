using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RoomCounterWinfrom
{
    public partial class Form_Statistieken : Form
    {
        public static Form_Statistieken instance;
        public ComboBox ComboBox_DayMounthYear;
        public DAL dal;
        public Chart chart;
        
        public Form_Statistieken()
        {
            InitializeComponent();
            instance = this;
            ComboBox_DayMounthYear = comboBox_DayMounthYear;
            dal = new DAL();
            chart = chart_Drukte;

        }

        private void Statistieken_Load(object sender, EventArgs e)
        {
            label_DayWeekMounhtYear.Text = "";
            comboBox_DayMounthYear.Hide();
            
        }

        private void comboBox_TimeIndicator_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_DayMounthYear.Show();
            if (comboBox_TimeIndicator.SelectedItem.ToString() == "Dag")
            {
                comboBox_DayMounthYear.Items.Clear();
                label_DayWeekMounhtYear.Text = comboBox_TimeIndicator.SelectedItem.ToString();
                dal.ReadDate(comboBox_TimeIndicator.SelectedItem.ToString());
                comboBox_DayMounthYear.Text = "";
            }

            if (comboBox_TimeIndicator.SelectedItem.ToString() == "Maand")
            {
                comboBox_DayMounthYear.Items.Clear();
                label_DayWeekMounhtYear.Text = comboBox_TimeIndicator.SelectedItem.ToString();
                dal.ReadDate(comboBox_TimeIndicator.SelectedItem.ToString());
                comboBox_DayMounthYear.Text = "";
            }

            if (comboBox_TimeIndicator.SelectedItem.ToString() == "Jaar")
            {
                comboBox_DayMounthYear.Items.Clear();
                label_DayWeekMounhtYear.Text = comboBox_TimeIndicator.SelectedItem.ToString();
                dal.ReadDate(comboBox_TimeIndicator.SelectedItem.ToString());
                comboBox_DayMounthYear.Text = "";
            }

            
        }

        private void chart_Drukte_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_DayMounthYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart_Drukte.Series["Drukte"].Points.Clear();
            dal.ReadChartData(comboBox_TimeIndicator.Text,comboBox_DayMounthYear.Text);
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
            
        }

        private void button_Instelingen_Click(object sender, EventArgs e)
        {
            Form_Instellingen form_Instellingen = new Form_Instellingen();
            Form_Instellingen.instance.Show();
            this.Close();
        }
    }
}
