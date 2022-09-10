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
    public partial class Form_AddLocation : Form
    {
        public static Form_AddLocation instance;
        public DAL dal;
        int locationID;
        public ComboBox ComboBox_Sensor;
        public Form_AddLocation()
        {
            InitializeComponent();
            instance = this;
            dal = new DAL();
            locationID = 0;
            ComboBox_Sensor = comboBox_SensorName;
        }

        private void AddLocation_Load(object sender, EventArgs e)
        {
            foreach (Location l in dal.locationList)
            {
                dataGridView_Locations.Rows.Add(l.ID,l.Name);
            }

            foreach (Zone z in dal.zoneList)
            {
                comboBox_ZoneName.Items.Add(z.Name);
            }

            foreach (Sensor s in dal.sensorList)
            {
                comboBox_SensorName.Items.Add(s.Name);
            }
        }

        private void button_AddSensor_Click(object sender, EventArgs e)
        {
            Form_AddSensor form_AddSensor = new Form_AddSensor();
            Form_AddSensor.instance.Show();
        }

        private void button_AddLocation_Click(object sender, EventArgs e)
        {
            Location toAddLocation = new Location(0, textBox_LocationName.Text);
            int toAddID = 0;
            dal.CreateLocation(toAddLocation);
            dal.FillLocationListFromDataBase();
            foreach (Location l in dal.locationList)
            {
                if (l.Name == textBox_LocationName.Text)
                {
                    toAddID = l.ID;
                }
            }
            int toAddIDZone = 0;
            foreach(Zone z in dal.zoneList)
            {
                if (z.Name == comboBox_ZoneName.Text)
                {
                    toAddIDZone = z.ID;
                }
            }
            dal.AddLocationToZone_DAL(toAddID, toAddIDZone);
            
            int toAddSensorID = 0;
            foreach (Sensor s in dal.sensorList)
            {
                if (s.Name == comboBox_SensorName.Text)
                {
                    toAddSensorID = s.ID;
                }
            }

            dal.ConnectSensorToLocation_DAL(toAddID, toAddSensorID);

            dal.ConnectSensorToLocation_List();
            dal.FillZoneListFromDataBase();
            dal.AddLocationToZone_List();
            
            dataGridView_Locations.Rows.Clear();
            foreach (Location l in dal.locationList)
            {
                dataGridView_Locations.Rows.Add(l.ID, l.Name);
            }

        }

        private void button_DeleteLocation_Click(object sender, EventArgs e)
        {
            Location toDeleteLocation = null;
            foreach(Location l in dal.locationList)
            {
                if(l.ID == locationID)
                {
                    toDeleteLocation = l;
                }
            }
            dal.DeleteLocation(toDeleteLocation);

            dataGridView_Locations.Rows.Clear();
            foreach (Location l in dal.locationList)
            {
                dataGridView_Locations.Rows.Add(l.ID, l.Name);
            }

            comboBox_SensorName.Text = "";
            textBox_LocationName.Text = "";
            comboBox_ZoneName.Text = "";

        }

        private void button_UpdateLocation_Click(object sender, EventArgs e)
        {
            Location toUpdateLocation = new Location(locationID, textBox_LocationName.Text);
            dal.UpdateLocation(toUpdateLocation);

            int toUpdateZoneID = 0;
            foreach(Zone z in dal.zoneList)
            {
                if(z.Name == comboBox_ZoneName.Text)
                {
                    toUpdateZoneID = z.ID;
                }
            }
            dal.AddLocationToZone_DAL(locationID,toUpdateZoneID);
            
            int toUpdateSensorID = 0;
            foreach(Sensor s in dal.sensorList)
            {
                if(s.Name == comboBox_SensorName.Text)
                {
                    toUpdateSensorID = s.ID;
                }
            }
            dal.ConnectSensorToLocation_DAL(locationID, toUpdateSensorID);

            dal.FillLocationListFromDataBase();
            dal.FillZoneListFromDataBase();
            dal.ConnectSensorToLocation_List();
            dal.AddLocationToZone_List();

            dataGridView_Locations.Rows.Clear();
            foreach (Location l in dal.locationList)
            {
                dataGridView_Locations.Rows.Add(l.ID, l.Name);
            }
        }

        private void dataGridView_Locations_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comboBox_ZoneName.Text = "";

            foreach (Location l in dal.locationList)
            {
                if (!(e.RowIndex < 0))
                {
                    if (l.ID == Int32.Parse(dataGridView_Locations.Rows[e.RowIndex].Cells[0].Value.ToString()))
                    {
                        locationID = l.ID;
                        textBox_LocationName.Text = l.Name;
                        comboBox_SensorName.Text = l.sensor.Name;
                    }
                }
            }

            foreach (Zone z in dal.zoneList)
            {
                foreach (Location l in z.locations)
                {
                    if (locationID == l.ID)
                    {
                        comboBox_ZoneName.Text = z.Name;
                    }
                }
            }
        }
    }
}
