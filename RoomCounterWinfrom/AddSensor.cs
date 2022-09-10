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
    public partial class Form_AddSensor : Form
    {
        public static Form_AddSensor instance;
        DAL dal;
        int sensorID;
        public Form_AddSensor()
        {
            InitializeComponent();
            instance = this;
            dal = new DAL();
            sensorID = 0;
        }

        private void AddSensor_Load(object sender, EventArgs e)
        {
            foreach(Sensor s in dal.sensorList)
            {
                dataGridView_Sensor.Rows.Add(s.ID,s.Name);
            }
        }

        private void button_AddSensor_Click(object sender, EventArgs e)
        {
            Sensor toAddSensor = new Sensor(0, textBox_SensorName.Text);
            dal.CreateSensor(toAddSensor);
            dataGridView_Sensor.Rows.Clear();
            foreach (Sensor s in dal.sensorList)
            {
                dataGridView_Sensor.Rows.Add(s.ID, s.Name);
            }

            textBox_SensorName.Text = "";

            Form_AddLocation.instance.ComboBox_Sensor.Items.Clear();
            foreach (Sensor s in dal.sensorList)
            {
                Form_AddLocation.instance.ComboBox_Sensor.Items.Add(s.Name);
            }

            Form_AddLocation.instance.dal = dal;
        }

        private void button_DeleteSensor_Click(object sender, EventArgs e)
        {

            Sensor toDeleteSensor = new Sensor(sensorID, textBox_SensorName.Text);
            dal.DeleteSensor(toDeleteSensor);

            dataGridView_Sensor.Rows.Clear();
            foreach (Sensor s in dal.sensorList)
            {
                dataGridView_Sensor.Rows.Add(s.ID, s.Name);
            }
            
            textBox_SensorName.Text = "";

            Form_AddLocation.instance.ComboBox_Sensor.Items.Clear();
            foreach (Sensor s in dal.sensorList)
            {
                Form_AddLocation.instance.ComboBox_Sensor.Items.Add(s.Name);
            }

            Form_AddLocation.instance.dal = dal;

            Form_AddLocation.instance.ComboBox_Sensor.Text = "";
        }

        private void button_UpdateSensor_Click(object sender, EventArgs e)
        {
            Sensor toUpdateSensor = new Sensor(sensorID, textBox_SensorName.Text);
            dal.UpdateSensor(toUpdateSensor);

            dataGridView_Sensor.Rows.Clear();
            foreach (Sensor s in dal.sensorList)
            {
                dataGridView_Sensor.Rows.Add(s.ID, s.Name);
            }

            textBox_SensorName.Text = "";

            Form_AddLocation.instance.ComboBox_Sensor.Items.Clear();
            foreach (Sensor s in dal.sensorList)
            {
                Form_AddLocation.instance.ComboBox_Sensor.Items.Add(s.Name);
            }

            Form_AddLocation.instance.dal = dal;
        }

        private void dataGridView_Sensor_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach(Sensor s in dal.sensorList)
            {
                if (!(e.RowIndex < 0))
                {
                    if (s.ID == Int32.Parse(dataGridView_Sensor.Rows[e.RowIndex].Cells[0].Value.ToString()))
                    {
                        sensorID = s.ID;
                        textBox_SensorName.Text = s.Name;
                    }
                }
            }
        }
    }
}
