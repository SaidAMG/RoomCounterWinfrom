namespace RoomCounterWinfrom
{
    partial class Form_Statistieken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Statistieken));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Instelingen = new System.Windows.Forms.Button();
            this.button_Statistieken = new System.Windows.Forms.Button();
            this.button_Zones = new System.Windows.Forms.Button();
            this.button_Meldingen = new System.Windows.Forms.Button();
            this.button_LiveActiviteit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.chart_Drukte = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox_TimeIndicator = new System.Windows.Forms.ComboBox();
            this.comboBox_DayMounthYear = new System.Windows.Forms.ComboBox();
            this.label_TimeIndication = new System.Windows.Forms.Label();
            this.label_DayWeekMounthYear = new System.Windows.Forms.Label();
            this.label_DayWeekMounhtYear = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Drukte)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.button_Instelingen);
            this.panel1.Controls.Add(this.button_Statistieken);
            this.panel1.Controls.Add(this.button_Zones);
            this.panel1.Controls.Add(this.button_Meldingen);
            this.panel1.Controls.Add(this.button_LiveActiviteit);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 749);
            this.panel1.TabIndex = 2;
            // 
            // button_Instelingen
            // 
            this.button_Instelingen.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Instelingen.FlatAppearance.BorderSize = 0;
            this.button_Instelingen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Instelingen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Instelingen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Instelingen.Image = ((System.Drawing.Image)(resources.GetObject("button_Instelingen.Image")));
            this.button_Instelingen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Instelingen.Location = new System.Drawing.Point(0, 277);
            this.button_Instelingen.Margin = new System.Windows.Forms.Padding(2);
            this.button_Instelingen.Name = "button_Instelingen";
            this.button_Instelingen.Size = new System.Drawing.Size(165, 49);
            this.button_Instelingen.TabIndex = 10;
            this.button_Instelingen.Text = "Instellingen";
            this.button_Instelingen.UseVisualStyleBackColor = true;
            this.button_Instelingen.Click += new System.EventHandler(this.button_Instelingen_Click);
            // 
            // button_Statistieken
            // 
            this.button_Statistieken.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Statistieken.FlatAppearance.BorderSize = 0;
            this.button_Statistieken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Statistieken.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Statistieken.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Statistieken.Image = ((System.Drawing.Image)(resources.GetObject("button_Statistieken.Image")));
            this.button_Statistieken.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Statistieken.Location = new System.Drawing.Point(0, 228);
            this.button_Statistieken.Margin = new System.Windows.Forms.Padding(2);
            this.button_Statistieken.Name = "button_Statistieken";
            this.button_Statistieken.Size = new System.Drawing.Size(165, 49);
            this.button_Statistieken.TabIndex = 9;
            this.button_Statistieken.Text = "Statistieken";
            this.button_Statistieken.UseVisualStyleBackColor = true;
            this.button_Statistieken.Click += new System.EventHandler(this.button_Statistieken_Click);
            // 
            // button_Zones
            // 
            this.button_Zones.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Zones.FlatAppearance.BorderSize = 0;
            this.button_Zones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Zones.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Zones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Zones.Image = ((System.Drawing.Image)(resources.GetObject("button_Zones.Image")));
            this.button_Zones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Zones.Location = new System.Drawing.Point(0, 179);
            this.button_Zones.Margin = new System.Windows.Forms.Padding(2);
            this.button_Zones.Name = "button_Zones";
            this.button_Zones.Size = new System.Drawing.Size(165, 49);
            this.button_Zones.TabIndex = 8;
            this.button_Zones.Text = "Zones";
            this.button_Zones.UseVisualStyleBackColor = true;
            this.button_Zones.Click += new System.EventHandler(this.button_Zones_Click);
            // 
            // button_Meldingen
            // 
            this.button_Meldingen.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Meldingen.FlatAppearance.BorderSize = 0;
            this.button_Meldingen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Meldingen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Meldingen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Meldingen.Image = ((System.Drawing.Image)(resources.GetObject("button_Meldingen.Image")));
            this.button_Meldingen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Meldingen.Location = new System.Drawing.Point(0, 130);
            this.button_Meldingen.Margin = new System.Windows.Forms.Padding(2);
            this.button_Meldingen.Name = "button_Meldingen";
            this.button_Meldingen.Size = new System.Drawing.Size(165, 49);
            this.button_Meldingen.TabIndex = 6;
            this.button_Meldingen.Text = "Meldingen";
            this.button_Meldingen.UseVisualStyleBackColor = true;
            this.button_Meldingen.Click += new System.EventHandler(this.button_Meldingen_Click);
            // 
            // button_LiveActiviteit
            // 
            this.button_LiveActiviteit.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_LiveActiviteit.FlatAppearance.BorderSize = 0;
            this.button_LiveActiviteit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LiveActiviteit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LiveActiviteit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_LiveActiviteit.Image = ((System.Drawing.Image)(resources.GetObject("button_LiveActiviteit.Image")));
            this.button_LiveActiviteit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_LiveActiviteit.Location = new System.Drawing.Point(0, 81);
            this.button_LiveActiviteit.Margin = new System.Windows.Forms.Padding(2);
            this.button_LiveActiviteit.Name = "button_LiveActiviteit";
            this.button_LiveActiviteit.Size = new System.Drawing.Size(165, 49);
            this.button_LiveActiviteit.TabIndex = 2;
            this.button_LiveActiviteit.Text = "Live activiteit";
            this.button_LiveActiviteit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_LiveActiviteit.UseVisualStyleBackColor = true;
            this.button_LiveActiviteit.Click += new System.EventHandler(this.button_LiveActiviteit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(165, 81);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(2, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(165, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1146, 65);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(141, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Statistieken";
            // 
            // chart_Drukte
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            chartArea1.BorderColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.chart_Drukte.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Drukte.Legends.Add(legend1);
            this.chart_Drukte.Location = new System.Drawing.Point(206, 130);
            this.chart_Drukte.Name = "chart_Drukte";
            this.chart_Drukte.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_Drukte.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.LightSeaGreen};
            series1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            series1.BorderColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Drukte";
            this.chart_Drukte.Series.Add(series1);
            this.chart_Drukte.Size = new System.Drawing.Size(954, 554);
            this.chart_Drukte.TabIndex = 5;
            this.chart_Drukte.Text = "chart_Drukte";
            this.chart_Drukte.Click += new System.EventHandler(this.chart_Drukte_Click);
            // 
            // comboBox_TimeIndicator
            // 
            this.comboBox_TimeIndicator.FormattingEnabled = true;
            this.comboBox_TimeIndicator.Items.AddRange(new object[] {
            "Dag",
            "Maand",
            "Jaar"});
            this.comboBox_TimeIndicator.Location = new System.Drawing.Point(289, 91);
            this.comboBox_TimeIndicator.Name = "comboBox_TimeIndicator";
            this.comboBox_TimeIndicator.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TimeIndicator.TabIndex = 6;
            this.comboBox_TimeIndicator.SelectedIndexChanged += new System.EventHandler(this.comboBox_TimeIndicator_SelectedIndexChanged);
            // 
            // comboBox_DayMounthYear
            // 
            this.comboBox_DayMounthYear.FormattingEnabled = true;
            this.comboBox_DayMounthYear.Location = new System.Drawing.Point(553, 91);
            this.comboBox_DayMounthYear.Name = "comboBox_DayMounthYear";
            this.comboBox_DayMounthYear.Size = new System.Drawing.Size(121, 21);
            this.comboBox_DayMounthYear.TabIndex = 7;
            this.comboBox_DayMounthYear.SelectedIndexChanged += new System.EventHandler(this.comboBox_DayMounthYear_SelectedIndexChanged);
            // 
            // label_TimeIndication
            // 
            this.label_TimeIndication.AutoSize = true;
            this.label_TimeIndication.Location = new System.Drawing.Point(216, 94);
            this.label_TimeIndication.Name = "label_TimeIndication";
            this.label_TimeIndication.Size = new System.Drawing.Size(67, 13);
            this.label_TimeIndication.TabIndex = 8;
            this.label_TimeIndication.Text = "Tijd Indicatie";
            // 
            // label_DayWeekMounthYear
            // 
            this.label_DayWeekMounthYear.AutoSize = true;
            this.label_DayWeekMounthYear.Location = new System.Drawing.Point(506, 94);
            this.label_DayWeekMounthYear.Name = "label_DayWeekMounthYear";
            this.label_DayWeekMounthYear.Size = new System.Drawing.Size(0, 13);
            this.label_DayWeekMounthYear.TabIndex = 9;
            // 
            // label_DayWeekMounhtYear
            // 
            this.label_DayWeekMounhtYear.AutoSize = true;
            this.label_DayWeekMounhtYear.Location = new System.Drawing.Point(512, 94);
            this.label_DayWeekMounhtYear.Name = "label_DayWeekMounhtYear";
            this.label_DayWeekMounhtYear.Size = new System.Drawing.Size(22, 13);
            this.label_DayWeekMounhtYear.TabIndex = 10;
            this.label_DayWeekMounhtYear.Text = "[...]";
            // 
            // Form_Statistieken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 749);
            this.Controls.Add(this.label_DayWeekMounhtYear);
            this.Controls.Add(this.label_DayWeekMounthYear);
            this.Controls.Add(this.label_TimeIndication);
            this.Controls.Add(this.comboBox_DayMounthYear);
            this.Controls.Add(this.comboBox_TimeIndicator);
            this.Controls.Add(this.chart_Drukte);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Statistieken";
            this.Text = "Statistieken";
            this.Load += new System.EventHandler(this.Statistieken_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Drukte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Instelingen;
        private System.Windows.Forms.Button button_Statistieken;
        private System.Windows.Forms.Button button_Zones;
        private System.Windows.Forms.Button button_Meldingen;
        private System.Windows.Forms.Button button_LiveActiviteit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Drukte;
        private System.Windows.Forms.ComboBox comboBox_TimeIndicator;
        private System.Windows.Forms.ComboBox comboBox_DayMounthYear;
        private System.Windows.Forms.Label label_TimeIndication;
        private System.Windows.Forms.Label label_DayWeekMounthYear;
        private System.Windows.Forms.Label label_DayWeekMounhtYear;
    }
}