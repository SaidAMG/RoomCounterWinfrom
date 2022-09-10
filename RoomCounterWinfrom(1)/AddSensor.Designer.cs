namespace RoomCounterWinfrom
{
    partial class Form_AddSensor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddSensor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Sensor = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SensorName = new System.Windows.Forms.TextBox();
            this.button_UpdateSensor = new System.Windows.Forms.Button();
            this.button_DeleteSensor = new System.Windows.Forms.Button();
            this.button_AddSensor = new System.Windows.Forms.Button();
            this.IDSensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sensor)).BeginInit();
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
            this.panel1.TabIndex = 2;
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
            this.panel2.Size = new System.Drawing.Size(504, 65);
            this.panel2.TabIndex = 13;
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
            this.label2.Size = new System.Drawing.Size(144, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = " Sensors";
            // 
            // dataGridView_Sensor
            // 
            this.dataGridView_Sensor.AllowUserToAddRows = false;
            this.dataGridView_Sensor.AllowUserToDeleteRows = false;
            this.dataGridView_Sensor.AllowUserToResizeColumns = false;
            this.dataGridView_Sensor.AllowUserToResizeRows = false;
            this.dataGridView_Sensor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sensor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSensor,
            this.NameSensor});
            this.dataGridView_Sensor.Location = new System.Drawing.Point(419, 98);
            this.dataGridView_Sensor.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Sensor.Name = "dataGridView_Sensor";
            this.dataGridView_Sensor.RowHeadersVisible = false;
            this.dataGridView_Sensor.RowHeadersWidth = 51;
            this.dataGridView_Sensor.RowTemplate.Height = 24;
            this.dataGridView_Sensor.Size = new System.Drawing.Size(180, 245);
            this.dataGridView_Sensor.TabIndex = 14;
            this.dataGridView_Sensor.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Sensor_CellMouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 41);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sensor naam:";
            // 
            // textBox_SensorName
            // 
            this.textBox_SensorName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_SensorName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SensorName.Location = new System.Drawing.Point(156, 181);
            this.textBox_SensorName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_SensorName.Name = "textBox_SensorName";
            this.textBox_SensorName.Size = new System.Drawing.Size(186, 26);
            this.textBox_SensorName.TabIndex = 19;
            // 
            // button_UpdateSensor
            // 
            this.button_UpdateSensor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_UpdateSensor.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UpdateSensor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.button_UpdateSensor.Location = new System.Drawing.Point(306, 299);
            this.button_UpdateSensor.Margin = new System.Windows.Forms.Padding(2);
            this.button_UpdateSensor.Name = "button_UpdateSensor";
            this.button_UpdateSensor.Size = new System.Drawing.Size(90, 44);
            this.button_UpdateSensor.TabIndex = 35;
            this.button_UpdateSensor.Text = "Update";
            this.button_UpdateSensor.UseVisualStyleBackColor = false;
            this.button_UpdateSensor.Click += new System.EventHandler(this.button_UpdateSensor_Click);
            // 
            // button_DeleteSensor
            // 
            this.button_DeleteSensor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_DeleteSensor.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteSensor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.button_DeleteSensor.Location = new System.Drawing.Point(211, 299);
            this.button_DeleteSensor.Margin = new System.Windows.Forms.Padding(2);
            this.button_DeleteSensor.Name = "button_DeleteSensor";
            this.button_DeleteSensor.Size = new System.Drawing.Size(90, 44);
            this.button_DeleteSensor.TabIndex = 34;
            this.button_DeleteSensor.Text = "Delete";
            this.button_DeleteSensor.UseVisualStyleBackColor = false;
            this.button_DeleteSensor.Click += new System.EventHandler(this.button_DeleteSensor_Click);
            // 
            // button_AddSensor
            // 
            this.button_AddSensor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_AddSensor.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddSensor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.button_AddSensor.Location = new System.Drawing.Point(117, 299);
            this.button_AddSensor.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddSensor.Name = "button_AddSensor";
            this.button_AddSensor.Size = new System.Drawing.Size(90, 44);
            this.button_AddSensor.TabIndex = 33;
            this.button_AddSensor.Text = "Add";
            this.button_AddSensor.UseVisualStyleBackColor = false;
            this.button_AddSensor.Click += new System.EventHandler(this.button_AddSensor_Click);
            // 
            // IDSensor
            // 
            this.IDSensor.HeaderText = "ID";
            this.IDSensor.Name = "IDSensor";
            this.IDSensor.Visible = false;
            // 
            // NameSensor
            // 
            this.NameSensor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameSensor.HeaderText = "Naam";
            this.NameSensor.Name = "NameSensor";
            // 
            // Form_AddSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 366);
            this.Controls.Add(this.button_UpdateSensor);
            this.Controls.Add(this.button_DeleteSensor);
            this.Controls.Add(this.button_AddSensor);
            this.Controls.Add(this.textBox_SensorName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_Sensor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_AddSensor";
            this.Text = "AddSensor";
            this.Load += new System.EventHandler(this.AddSensor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sensor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Sensor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SensorName;
        private System.Windows.Forms.Button button_UpdateSensor;
        private System.Windows.Forms.Button button_DeleteSensor;
        private System.Windows.Forms.Button button_AddSensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSensor;
    }
}