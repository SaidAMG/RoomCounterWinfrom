using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCounterWinfrom
{
    public class DAL
    {
        string connectionString = "Data Source=.;Initial Catalog=SensorData;Integrated Security=True";
        public List<Sensor> sensorList = new List<Sensor>();
        public List<Location> locationList = new List<Location>();
        public List<Zone> zoneList = new List<Zone>();
        public DAL()
        {
            FillSensorListFromDataBase();
            FillLocationListFromDataBase();
            FillZoneListFromDataBase();
            ConnectSensorToLocation_List();
            AddLocationToZone_List();
        }
        // CRUD Sensor
        public void FillSensorListFromDataBase()
        {
            sensorList.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT id,SensorName FROM Sensor";
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            string sensorName = dataReader[1].ToString();
                            int sensorID = Int32.Parse(dataReader[0].ToString());

                            sensorList.Add(new Sensor(sensorID, sensorName));
                        }
                    }
                }

            }
        }
        public void CreateSensor(Sensor _sensor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Sensor (SensorName) VALUES(@SensorName)";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@SensorName", _sensor.Name);
                    command.ExecuteNonQuery();

                }
            }
            FillSensorListFromDataBase();
        }
        public void DeleteSensor(Sensor _sensor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "UPDATE Location SET SensorID = NULL WHERE SensorID = @SensorID";
                connection.Open();
                using (SqlCommand command =new SqlCommand(sql,connection))
                {
                    command.Parameters.AddWithValue("@SensorID", _sensor.ID);
                    command.ExecuteNonQuery();
                }

                sql = "DELETE Sensor WHERE id = @id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", _sensor.ID);
                    command.ExecuteNonQuery();
                }
            }
            FillSensorListFromDataBase();
            FillLocationListFromDataBase();
            FillZoneListFromDataBase();
            ConnectSensorToLocation_List();
            AddLocationToZone_List();
        }
        public void UpdateSensor(Sensor _sensor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String sql = "UPDATE Sensor SET SensorName = @SensorName WHERE id = @id";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", _sensor.ID);
                    command.Parameters.AddWithValue("@SensorName", _sensor.Name);
                    command.ExecuteNonQuery();
                }
            }
            FillSensorListFromDataBase();
            ConnectSensorToLocation_List();
            FillZoneListFromDataBase();
            AddLocationToZone_List();
        }

        // CRUD Zone
        public void FillZoneListFromDataBase()
        {
            zoneList.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT id,ZoneName,MaxPersons FROM Zone";
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            int id = Int32.Parse(dataReader[0].ToString());
                            string name = dataReader[1].ToString();
                            int MaxPersons = Int32.Parse(dataReader[2].ToString());

                            Zone ToAddzone = new Zone(id, name, MaxPersons);

                            zoneList.Add(ToAddzone);
                        }
                    }
                }
            }
        }
        public void CreateZone(Zone _zone)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Zone (ZoneName,MaxPersons) VALUES(@ZoneName,@MaxPersons)";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ZoneName", _zone.Name);
                    command.Parameters.AddWithValue("@MaxPersons", _zone.MaxPeople);
                    command.ExecuteNonQuery();
                }
            }
            FillZoneListFromDataBase();
            AddLocationToZone_List();
        }
        public void DeleteZone(Zone _zone)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "UPDATE Location SET ZoneID = NULL WHERE ZoneID = @ZoneID";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql,connection))
                {
                    command.Parameters.AddWithValue("@ZoneID", _zone.ID);
                    command.ExecuteNonQuery();
                }
                
                sql = "DELETE Zone WHERE id = @id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", _zone.ID);
                    command.ExecuteNonQuery();
                }
            }
            FillZoneListFromDataBase();
            AddLocationToZone_List();
        }
        public void UpdateZone(Zone _zone)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String sql = "UPDATE Zone SET ZoneName = @ZoneName, MaxPersons = @MaxPersons WHERE id = @id";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", _zone.ID);
                    command.Parameters.AddWithValue("@ZoneName", _zone.Name);
                    command.Parameters.AddWithValue("@MaxPersons", _zone.MaxPeople);
                    command.ExecuteNonQuery();

                }
            }
            FillZoneListFromDataBase();
            AddLocationToZone_List();
        }

        // CRUD Location
        public void FillLocationListFromDataBase()
        {
            locationList.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT id,LocationName FROM Location";
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            int LocationID = Int32.Parse(dataReader[0].ToString());
                            string LocationName = dataReader[1].ToString();

                            locationList.Add(new Location(LocationID, LocationName));
                        }
                    }
                }

            }
        }
        public void CreateLocation(Location _location)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO Location (LocationName) VALUES(@locationName)";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@LocationName", _location.Name);
                    command.ExecuteNonQuery();
                }
            }
            
        }
        public void DeleteLocation(Location _location)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "DELETE Location WHERE id = @id";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", _location.ID);
                    command.ExecuteNonQuery();
                }
            }
            FillLocationListFromDataBase();
            ConnectSensorToLocation_List();
            FillZoneListFromDataBase();
            AddLocationToZone_List();

        }
        public void UpdateLocation(Location _location)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String sql = "UPDATE Location SET LocationName = @LocationName WHERE id = @id";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", _location.ID);
                    command.Parameters.AddWithValue("@LocationName", _location.Name);
                    command.ExecuteNonQuery();

                }
            }

        }

        // CRUD Connect data
        public void ConnectSensorToLocation_DAL(int _IDLocation, int _IDSensor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "UPDATE Location SET SensorID = @SensorID WHERE id = @id";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", _IDLocation);
                    command.Parameters.AddWithValue("@SensorID", _IDSensor);
                    command.ExecuteNonQuery();
                }
            }
            ConnectSensorToLocation_List();
        }
        public void AddLocationToZone_DAL(int _IDLocation, int _IDZone)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "UPDATE Location SET ZoneID = @ZoneID WHERE id = @id";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", _IDLocation);
                    command.Parameters.AddWithValue("@ZoneID", _IDZone);
                    command.ExecuteNonQuery();
                }
            }
            FillZoneListFromDataBase();
            AddLocationToZone_List();
        }
        public void ConnectSensorToLocation_List()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT id,SensorID FROM Location";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            foreach (Location l in locationList)
                            {
                                if (l.ID == Int32.Parse(dataReader[0].ToString()))
                                {
                                    foreach (Sensor s in sensorList)
                                    {
                                        if (dataReader[1] != DBNull.Value)
                                        {
                                            if (s.ID == Int32.Parse(dataReader[1].ToString()))
                                            {
                                                l.SetSensor(s);
                                            }
                                        }
                                        else
                                        {
                                            Sensor sDummy = new Sensor(0, "");
                                            l.SetSensor(sDummy);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public void AddLocationToZone_List()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT id,ZoneID FROM Location";
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            foreach (Zone z in zoneList)
                            {
                                if(dataReader[1] != DBNull.Value)
                                {
                                    if (z.ID == Int32.Parse(dataReader[1].ToString()))
                                    {
                                        foreach (Location l in locationList)
                                        {
                                            if (l.ID == Int32.Parse(dataReader[0].ToString()))
                                            {
                                                z.AddLocation(l);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        // Read For Statistics
        public void ReadDate(string _TimeIndicator)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT TimeStamp FROM SensorReading";
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        string TimeCount = "";
                        while (dataReader.Read())
                        {
                            if (_TimeIndicator == "Jaar")
                            {
                                DateTime date = DateTime.Parse(dataReader[0].ToString());
                                
                                if (date.Year.ToString() != TimeCount)
                                {
                                    TimeCount = date.Year.ToString();
                                    Form_Statistieken.instance.ComboBox_DayMounthYear.Items.Add(date.Year.ToString());
                                }
                            }

                            else if (_TimeIndicator == "Maand")
                            {
                                DateTime yearcheck = DateTime.Now;
                                DateTime date = DateTime.Parse(dataReader[0].ToString());

                                if (yearcheck.Year == date.Year)
                                {
                                    if (date.Month.ToString() != TimeCount)
                                    {
                                        TimeCount = date.Month.ToString();
                                        Form_Statistieken.instance.ComboBox_DayMounthYear.Items.Add(date.ToString("MMMM"));
                                    }
                                }
                            }

                            else if (_TimeIndicator == "Dag")
                            {
                                DateTime date = DateTime.Parse(dataReader[0].ToString());

                                if (date.ToString("dd-MM-yyyy") != TimeCount)
                                {
                                    TimeCount = date.ToString("dd-MM-yyyy");
                                    Form_Statistieken.instance.ComboBox_DayMounthYear.Items.Add(date.ToString("dd-MM-yyyy"));
                                }
                            }
                        }
                    }
                }
            }
        }
        public void ReadChartData(string _TimeIndicator,string _dateSelect)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT People_in, People_out, TimeStamp FROM SensorReading";
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        int Max = 0;
                        int PeopleAmount = 0;
                        string TimeCount = _dateSelect;
                        string Current = "";
                        while (dataReader.Read())// terwijl lezen
                        {
                            if (_TimeIndicator == "Jaar")// als het tijdsindicatie is ingesteld op jaar
                            {
                                DateTime year = DateTime.Parse(dataReader[2].ToString()); // na jaar bevestiging wordt datum en tijd van dataread opgeslagen.

                                if (year.Year.ToString() == TimeCount)// als het jaar van de dataread het zelfde is als dat van het geselecteerde jaar.
                                {
                                    if(Current == year.ToString("MMM"))// als recente maand het zelde is als de maand uit de dataread.
                                    {
                                        PeopleAmount = PeopleAmount + Int32.Parse(dataReader[0].ToString());
                                        PeopleAmount = PeopleAmount - Int32.Parse(dataReader[1].ToString());
                                        if (PeopleAmount > Max)
                                        {
                                            Max = PeopleAmount;
                                        }
                                    }
                                    else// als recente maand NIET het zelde is als de maand uit de dataread.
                                    {
                                        
                                        if (Current != "") // als het max aantal mensen groter is dan 0.
                                        {
                                            Form_Statistieken.instance.chart.Series["Drukte"].Points.AddXY(Current,Max); // de maand met de hoogste aantal bezoekers wordt weergegeven.
                                            Max = 0;
                                            PeopleAmount = 0;
                                        }
                                        
                                        PeopleAmount = PeopleAmount + Int32.Parse(dataReader[0].ToString());
                                        PeopleAmount = PeopleAmount - Int32.Parse(dataReader[1].ToString());
                                        if (PeopleAmount > Max)
                                        {
                                            Max = PeopleAmount;
                                        }
                                        Current = year.ToString("MMM"); 
                                    }
                                }
                            }
                            if (_TimeIndicator == "Maand")
                            {
                                DateTime now = DateTime.Now;
                                DateTime month = DateTime.Parse(dataReader[2].ToString());

                                if (now.Year == month.Year)
                                {
                                    if (month.ToString("MMMM") == TimeCount)
                                    {
                                        if (Current == month.ToString("dd"))
                                        {
                                            PeopleAmount = PeopleAmount + Int32.Parse(dataReader[0].ToString());
                                            PeopleAmount = PeopleAmount - Int32.Parse(dataReader[1].ToString());
                                            if (PeopleAmount > Max)
                                            {
                                                Max = PeopleAmount;
                                            }
                                        }
                                        else
                                        {
                                            if (Current != "")
                                            {
                                                Form_Statistieken.instance.chart.Series["Drukte"].Points.AddXY(Current, Max);
                                                Max = 0;
                                                PeopleAmount = 0;
                                            }

                                            PeopleAmount = PeopleAmount + Int32.Parse(dataReader[0].ToString());
                                            PeopleAmount = PeopleAmount - Int32.Parse(dataReader[1].ToString());
                                            if (PeopleAmount > Max)
                                            {
                                                Max = PeopleAmount;
                                            }
                                            Current = month.ToString("dd");
                                        }
                                    }
                                }
                            }
                            if (_TimeIndicator == "Dag")
                            {
                                DateTime day = DateTime.Parse(dataReader[2].ToString());

                                if (day.ToString("dd-MM-yyyy") == TimeCount)
                                {
                                    if (Current == day.ToString("HH"))
                                    {
                                        PeopleAmount = PeopleAmount + Int32.Parse(dataReader[0].ToString());
                                        PeopleAmount = PeopleAmount - Int32.Parse(dataReader[1].ToString());
                                        if (PeopleAmount > Max)
                                        {
                                            Max = PeopleAmount;
                                        }
                                    }
                                    else
                                    {
                                        if (Current != "")
                                        {
                                            Form_Statistieken.instance.chart.Series["Drukte"].Points.AddXY($"{Current}:00", Max);
                                            Max = 0;
                                            PeopleAmount = 0;
                                        }

                                        PeopleAmount = PeopleAmount + Int32.Parse(dataReader[0].ToString());
                                        PeopleAmount = PeopleAmount - Int32.Parse(dataReader[1].ToString());
                                        if (PeopleAmount > Max)
                                        {
                                            Max = PeopleAmount;
                                        }
                                        Current = day.ToString("HH");
                                    }
                                }
                            }
                        }
                        if (!dataReader.Read())// Als er geen data meer is om te lezen, wordt het overgebleven aantal mensen aan de recente maand doorgegeven.
                        {
                            if(_TimeIndicator == "Dag")
                            {
                                Form_Statistieken.instance.chart.Series["Drukte"].Points.AddXY($"{Current}:00", Max);
                                Max = 0;
                                PeopleAmount = 0;
                            }
                            else
                            {
                                Form_Statistieken.instance.chart.Series["Drukte"].Points.AddXY(Current, Max);
                                Max = 0;
                                PeopleAmount = 0;
                            }
                            
                        }
                    }
                }
            }    
        }

    }
}
