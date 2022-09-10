namespace RoomCounterWinfrom
{
    partial class Form_AddLocation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddLocation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Locations = new System.Windows.Forms.DataGridView();
            this.IDLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_LocationName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_SensorName = new System.Windows.Forms.ComboBox();
            this.button_AddSensor = new System.Windows.Forms.Button();
            this.button_UpdateLocation = new System.Windows.Forms.Button();
            this.button_DeleteLocation = new System.Windows.Forms.Button();
            this.button_AddLocation = new System.Windows.Forms.Button();
            this.comboBox_ZoneName = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Locations)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 366);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(104, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 65);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(146, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Locations";
            // 
            // dataGridView_Locations
            // 
            this.dataGridView_Locations.AllowUserToAddRows = false;
            this.dataGridView_Locations.AllowUserToDeleteRows = false;
            this.dataGridView_Locations.AllowUserToResizeColumns = false;
            this.dataGridView_Locations.AllowUserToResizeRows = false;
            this.dataGridView_Locations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Locations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDLocation,
            this.NameLocation});
            this.dataGridView_Locations.Location = new System.Drawing.Point(411, 102);
            this.dataGridView_Locations.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Locations.Name = "dataGridView_Locations";
            this.dataGridView_Locations.RowHeadersVisible = false;
            this.dataGridView_Locations.RowHeadersWidth = 51;
            this.dataGridView_Locations.RowTemplate.Height = 24;
            this.dataGridView_Locations.Size = new System.Drawing.Size(180, 245);
            this.dataGridView_Locations.TabIndex = 15;
 //           this.dataGridView_Locations.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Locations_CellContentDoubleClick);
            this.dataGridView_Locations.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Locations_CellMouseDoubleClick);
            // 
            // IDLocation
            // 
            this.IDLocation.HeaderText = "ID";
            this.IDLocation.Name = "IDLocation";
            this.IDLocation.Visible = false;
            // 
            // NameLocation
            // 
            this.NameLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameLocation.HeaderText = "Naam";
            this.NameLocation.Name = "NameLocation";
            this.NameLocation.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Zone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Locatie naam:";
            // 
            // textBox_LocationName
            // 
            this.textBox_LocationName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_LocationName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LocationName.Location = new System.Drawing.Point(123, 184);
            this.textBox_LocationName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_LocationName.Name = "textBox_LocationName";
            this.textBox_LocationName.Size = new System.Drawing.Size(186, 26);
            this.textBox_LocationName.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sensor:";
            // 
            // comboBox_SensorName
            // 
            this.comboBox_SensorName.FormattingEnabled = true;
            this.comboBox_SensorName.Location = new System.Drawing.Point(125, 255);
            this.comboBox_SensorName.Name = "comboBox_SensorName";
            this.comboBox_SensorName.Size = new System.Drawing.Size(184, 21);
            this.comboBox_SensorName.TabIndex = 28;
            // 
            // button_AddSensor
            // 
            this.button_AddSensor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_AddSensor.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddSensor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.button_AddSensor.Location = new System.Drawing.Point(314, 246);
            this.button_AddSensor.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddSensor.Name = "button_AddSensor";
            this.button_AddSensor.Size = new System.Drawing.Size(35, 32);
            this.button_AddSensor.TabIndex = 29;
            this.button_AddSensor.Text = " + ";
            this.button_AddSensor.UseVisualStyleBackColor = false;
            this.button_AddSensor.Click += new System.EventHandler(this.button_AddSensor_Click);
            // 
            // button_UpdateLocation
            // 
            this.button_UpdateLocation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_UpdateLocation.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UpdateLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.button_UpdateLocation.Location = new System.Drawing.Point(314, 303);
            this.button_UpdateLocation.Margin = new System.Windows.Forms.Padding(2);
            this.button_UpdateLocation.Name = "button_UpdateLocation";
            this.button_UpdateLocation.Size = new System.Drawing.Size(90, 44);
            this.button_UpdateLocation.TabIndex = 32;
            this.button_UpdateLocation.Text = "Update";
            this.button_UpdateLocation.UseVisualStyleBackColor = false;
            this.button_UpdateLocation.Click += new System.EventHandler(this.button_UpdateLocation_Click);
            // 
            // button_DeleteLocation
            // 
            this.button_DeleteLocation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_DeleteLocation.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.button_DeleteLocation.Location = new System.Drawing.Point(219, 303);
            this.button_DeleteLocation.Margin = new System.Windows.Forms.Padding(2);
            this.button_DeleteLocation.Name = "button_DeleteLocation";
            this.button_DeleteLocation.Size = new System.Drawing.Size(90, 44);
            this.button_DeleteLocation.TabIndex = 31;
            this.button_DeleteLocation.Text = "Delete";
            this.button_DeleteLocation.UseVisualStyleBackColor = false;
            this.button_DeleteLocation.Click += new System.EventHandler(this.button_DeleteLocation_Click);
            // 
            // button_AddLocation
            // 
            this.button_AddLocation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_AddLocation.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.button_AddLocation.Location = new System.Drawing.Point(125, 303);
            this.button_AddLocation.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddLocation.Name = "button_AddLocation";
            this.button_AddLocation.Size = new System.Drawing.Size(90, 44);
            this.button_AddLocation.TabIndex = 30;
            this.button_AddLocation.Text = "Add";
            this.button_AddLocation.UseVisualStyleBackColor = false;
            this.button_AddLocation.Click += new System.EventHandler(this.button_AddLocation_Click);
            // 
            // comboBox_ZoneName
            // 
            this.comboBox_ZoneName.FormattingEnabled = true;
            this.comboBox_ZoneName.Location = new System.Drawing.Point(123, 115);
            this.comboBox_ZoneName.Name = "comboBox_ZoneName";
            this.comboBox_ZoneName.Size = new System.Drawing.Size(186, 21);
            this.comboBox_ZoneName.TabIndex = 33;
            // 
            // Form_AddLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.comboBox_ZoneName);
            this.Controls.Add(this.button_UpdateLocation);
            this.Controls.Add(this.button_DeleteLocation);
            this.Controls.Add(this.button_AddLocation);
            this.Controls.Add(this.button_AddSensor);
            this.Controls.Add(this.comboBox_SensorName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_LocationName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_Locations);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_AddLocation";
            this.Text = "AddLocation";
            this.Load += new System.EventHandler(this.AddLocation_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Locations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Locations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_LocationName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_SensorName;
        private System.Windows.Forms.Button button_AddSensor;
        private System.Windows.Forms.Button button_UpdateLocation;
        private System.Windows.Forms.Button button_DeleteLocation;
        private System.Windows.Forms.Button button_AddLocation;
        private System.Windows.Forms.ComboBox comboBox_ZoneName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameLocation;
    }
}