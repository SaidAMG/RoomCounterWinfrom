namespace RoomCounterWinfrom
{
    partial class Form_Zones1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Zones1));
            this.dataGridView_Zones = new System.Windows.Forms.DataGridView();
            this.IDZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_NameZone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MaxPeople = new System.Windows.Forms.TextBox();
            this.button_AddZone = new System.Windows.Forms.Button();
            this.button_DeleteZone = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_instellingen = new System.Windows.Forms.Button();
            this.button_statistieken = new System.Windows.Forms.Button();
            this.button_Zones = new System.Windows.Forms.Button();
            this.button_Meldingen = new System.Windows.Forms.Button();
            this.button_LiveActiviteit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button_UpdateZone = new System.Windows.Forms.Button();
            this.button_LocatieVerwijzing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Zones)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Zones
            // 
            this.dataGridView_Zones.AllowUserToAddRows = false;
            this.dataGridView_Zones.AllowUserToDeleteRows = false;
            this.dataGridView_Zones.AllowUserToResizeColumns = false;
            this.dataGridView_Zones.AllowUserToResizeRows = false;
            this.dataGridView_Zones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Zones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDZone,
            this.NameZone});
            this.dataGridView_Zones.Location = new System.Drawing.Point(524, 99);
            this.dataGridView_Zones.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Zones.Name = "dataGridView_Zones";
            this.dataGridView_Zones.RowHeadersVisible = false;
            this.dataGridView_Zones.RowHeadersWidth = 51;
            this.dataGridView_Zones.RowTemplate.Height = 24;
            this.dataGridView_Zones.Size = new System.Drawing.Size(180, 258);
            this.dataGridView_Zones.TabIndex = 15;
            this.dataGridView_Zones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Zones_CellContentClick);
            this.dataGridView_Zones.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Zones_CellMouseDoubleClick);
            // 
            // IDZone
            // 
            this.IDZone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IDZone.HeaderText = "ID";
            this.IDZone.Name = "IDZone";
            this.IDZone.Visible = false;
            // 
            // NameZone
            // 
            this.NameZone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameZone.HeaderText = "Name";
            this.NameZone.Name = "NameZone";
            this.NameZone.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Naam:";
            // 
            // textBox_NameZone
            // 
            this.textBox_NameZone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_NameZone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NameZone.Location = new System.Drawing.Point(217, 132);
            this.textBox_NameZone.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_NameZone.Name = "textBox_NameZone";
            this.textBox_NameZone.Size = new System.Drawing.Size(186, 26);
            this.textBox_NameZone.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Maximaal aantal personen:";
            // 
            // textBox_MaxPeople
            // 
            this.textBox_MaxPeople.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_MaxPeople.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaxPeople.Location = new System.Drawing.Point(217, 211);
            this.textBox_MaxPeople.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_MaxPeople.Name = "textBox_MaxPeople";
            this.textBox_MaxPeople.Size = new System.Drawing.Size(186, 26);
            this.textBox_MaxPeople.TabIndex = 23;
            // 
            // button_AddZone
            // 
            this.button_AddZone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_AddZone.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddZone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.button_AddZone.Location = new System.Drawing.Point(217, 366);
            this.button_AddZone.Margin = new System.Windows.Forms.Padding(2);
            this.button_AddZone.Name = "button_AddZone";
            this.button_AddZone.Size = new System.Drawing.Size(90, 44);
            this.button_AddZone.TabIndex = 24;
            this.button_AddZone.Text = "Add";
            this.button_AddZone.UseVisualStyleBackColor = false;
            this.button_AddZone.Click += new System.EventHandler(this.button_AddZone_Click);
            // 
            // button_DeleteZone
            // 
            this.button_DeleteZone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_DeleteZone.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteZone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.button_DeleteZone.Location = new System.Drawing.Point(311, 366);
            this.button_DeleteZone.Margin = new System.Windows.Forms.Padding(2);
            this.button_DeleteZone.Name = "button_DeleteZone";
            this.button_DeleteZone.Size = new System.Drawing.Size(90, 44);
            this.button_DeleteZone.TabIndex = 25;
            this.button_DeleteZone.Text = "Delete";
            this.button_DeleteZone.UseVisualStyleBackColor = false;
            this.button_DeleteZone.Click += new System.EventHandler(this.button_DeleteZone_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.button_instellingen);
            this.panel1.Controls.Add(this.button_statistieken);
            this.panel1.Controls.Add(this.button_Zones);
            this.panel1.Controls.Add(this.button_Meldingen);
            this.panel1.Controls.Add(this.button_LiveActiviteit);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 421);
            this.panel1.TabIndex = 26;
            // 
            // button_instellingen
            // 
            this.button_instellingen.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_instellingen.FlatAppearance.BorderSize = 0;
            this.button_instellingen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_instellingen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_instellingen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_instellingen.Image = ((System.Drawing.Image)(resources.GetObject("button_instellingen.Image")));
            this.button_instellingen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_instellingen.Location = new System.Drawing.Point(0, 275);
            this.button_instellingen.Margin = new System.Windows.Forms.Padding(2);
            this.button_instellingen.Name = "button_instellingen";
            this.button_instellingen.Size = new System.Drawing.Size(178, 49);
            this.button_instellingen.TabIndex = 15;
            this.button_instellingen.Text = "Instellingen";
            this.button_instellingen.UseVisualStyleBackColor = true;
            this.button_instellingen.Click += new System.EventHandler(this.button_instellingen_Click);
            // 
            // button_statistieken
            // 
            this.button_statistieken.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_statistieken.FlatAppearance.BorderSize = 0;
            this.button_statistieken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_statistieken.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_statistieken.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_statistieken.Image = ((System.Drawing.Image)(resources.GetObject("button_statistieken.Image")));
            this.button_statistieken.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_statistieken.Location = new System.Drawing.Point(0, 226);
            this.button_statistieken.Margin = new System.Windows.Forms.Padding(2);
            this.button_statistieken.Name = "button_statistieken";
            this.button_statistieken.Size = new System.Drawing.Size(178, 49);
            this.button_statistieken.TabIndex = 14;
            this.button_statistieken.Text = "Statistieken";
            this.button_statistieken.UseVisualStyleBackColor = true;
            this.button_statistieken.Click += new System.EventHandler(this.button_statistieken_Click);
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
            this.button_Zones.Location = new System.Drawing.Point(0, 177);
            this.button_Zones.Margin = new System.Windows.Forms.Padding(2);
            this.button_Zones.Name = "button_Zones";
            this.button_Zones.Size = new System.Drawing.Size(178, 49);
            this.button_Zones.TabIndex = 13;
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
            this.button_Meldingen.Location = new System.Drawing.Point(0, 128);
            this.button_Meldingen.Margin = new System.Windows.Forms.Padding(2);
            this.button_Meldingen.Name = "button_Meldingen";
            this.button_Meldingen.Size = new System.Drawing.Size(178, 49);
            this.button_Meldingen.TabIndex = 12;
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
            this.button_LiveActiviteit.Location = new System.Drawing.Point(0, 79);
            this.button_LiveActiviteit.Margin = new System.Windows.Forms.Padding(2);
            this.button_LiveActiviteit.Name = "button_LiveActiviteit";
            this.button_LiveActiviteit.Size = new System.Drawing.Size(178, 49);
            this.button_LiveActiviteit.TabIndex = 11;
            this.button_LiveActiviteit.Text = "Live activiteit";
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(178, 79);
            this.flowLayoutPanel1.TabIndex = 3;
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
            this.panel2.Location = new System.Drawing.Point(178, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 65);
            this.panel2.TabIndex = 27;
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
            this.label2.Size = new System.Drawing.Size(109, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zones";
            // 
            // button_UpdateZone
            // 
            this.button_UpdateZone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_UpdateZone.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UpdateZone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.button_UpdateZone.Location = new System.Drawing.Point(406, 366);
            this.button_UpdateZone.Margin = new System.Windows.Forms.Padding(2);
            this.button_UpdateZone.Name = "button_UpdateZone";
            this.button_UpdateZone.Size = new System.Drawing.Size(90, 44);
            this.button_UpdateZone.TabIndex = 28;
            this.button_UpdateZone.Text = "Update";
            this.button_UpdateZone.UseVisualStyleBackColor = false;
            this.button_UpdateZone.Click += new System.EventHandler(this.button_UpdateZone_Click);
            // 
            // button_LocatieVerwijzing
            // 
            this.button_LocatieVerwijzing.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_LocatieVerwijzing.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LocatieVerwijzing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.button_LocatieVerwijzing.Location = new System.Drawing.Point(217, 275);
            this.button_LocatieVerwijzing.Margin = new System.Windows.Forms.Padding(2);
            this.button_LocatieVerwijzing.Name = "button_LocatieVerwijzing";
            this.button_LocatieVerwijzing.Size = new System.Drawing.Size(150, 44);
            this.button_LocatieVerwijzing.TabIndex = 29;
            this.button_LocatieVerwijzing.Text = "Locatie Verwijzing";
            this.button_LocatieVerwijzing.UseVisualStyleBackColor = false;
            this.button_LocatieVerwijzing.Click += new System.EventHandler(this.button_LocatieVerwijzing_Click);
            // 
            // Form_Zones1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 421);
            this.Controls.Add(this.button_LocatieVerwijzing);
            this.Controls.Add(this.button_UpdateZone);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_DeleteZone);
            this.Controls.Add(this.button_AddZone);
            this.Controls.Add(this.textBox_MaxPeople);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_NameZone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_Zones);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Zones1";
            this.Text = "Zones";
            this.Load += new System.EventHandler(this.Zones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Zones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Zones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_NameZone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MaxPeople;
        private System.Windows.Forms.Button button_AddZone;
        private System.Windows.Forms.Button button_DeleteZone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_UpdateZone;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button_instellingen;
        private System.Windows.Forms.Button button_statistieken;
        private System.Windows.Forms.Button button_Zones;
        private System.Windows.Forms.Button button_Meldingen;
        private System.Windows.Forms.Button button_LiveActiviteit;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDZone;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameZone;
        private System.Windows.Forms.Button button_LocatieVerwijzing;
    }
}