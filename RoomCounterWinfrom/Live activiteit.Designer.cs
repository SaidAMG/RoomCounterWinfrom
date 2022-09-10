namespace RoomCounterWinfrom
{
    partial class Form_LiveActiviteit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LiveActiviteit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.aantal_mensen = new System.Windows.Forms.Label();
            this.max_aantal = new System.Windows.Forms.Label();
            this.mensen_in = new System.Windows.Forms.Label();
            this.mensen_uit = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.Aanmelden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Instelingen = new System.Windows.Forms.Button();
            this.button_Statistieken = new System.Windows.Forms.Button();
            this.button_Zones = new System.Windows.Forms.Button();
            this.button_Meldingen = new System.Windows.Forms.Button();
            this.button_LiveActiviteit = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(165, 366);
            this.panel1.TabIndex = 2;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(165, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 65);
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
            this.label2.Location = new System.Drawing.Point(128, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Live Activiteit";
            // 
            // aantal_mensen
            // 
            this.aantal_mensen.AutoSize = true;
            this.aantal_mensen.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aantal_mensen.Location = new System.Drawing.Point(187, 106);
            this.aantal_mensen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aantal_mensen.Name = "aantal_mensen";
            this.aantal_mensen.Size = new System.Drawing.Size(118, 20);
            this.aantal_mensen.TabIndex = 6;
            this.aantal_mensen.Text = "Aantal mensen:";
            // 
            // max_aantal
            // 
            this.max_aantal.AutoSize = true;
            this.max_aantal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_aantal.Location = new System.Drawing.Point(187, 147);
            this.max_aantal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.max_aantal.Name = "max_aantal";
            this.max_aantal.Size = new System.Drawing.Size(164, 20);
            this.max_aantal.TabIndex = 7;
            this.max_aantal.Text = "Max aantal bezoekers:";
            // 
            // mensen_in
            // 
            this.mensen_in.AutoSize = true;
            this.mensen_in.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensen_in.Location = new System.Drawing.Point(187, 188);
            this.mensen_in.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mensen_in.Name = "mensen_in";
            this.mensen_in.Size = new System.Drawing.Size(150, 20);
            this.mensen_in.TabIndex = 8;
            this.mensen_in.Text = "Laatse mensen (IN):";
            // 
            // mensen_uit
            // 
            this.mensen_uit.AutoSize = true;
            this.mensen_uit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensen_uit.Location = new System.Drawing.Point(187, 228);
            this.mensen_uit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mensen_uit.Name = "mensen_uit";
            this.mensen_uit.Size = new System.Drawing.Size(164, 20);
            this.mensen_uit.TabIndex = 9;
            this.mensen_uit.Text = "Laatste mensen (UIT):";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(400, 106);
            this.status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(57, 20);
            this.status.TabIndex = 10;
            this.status.Text = "Status:";
            // 
            // Aanmelden
            // 
            this.Aanmelden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(173)))), ((int)(((byte)(164)))));
            this.Aanmelden.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aanmelden.ForeColor = System.Drawing.Color.White;
            this.Aanmelden.Location = new System.Drawing.Point(333, 281);
            this.Aanmelden.Margin = new System.Windows.Forms.Padding(2);
            this.Aanmelden.Name = "Aanmelden";
            this.Aanmelden.Size = new System.Drawing.Size(141, 44);
            this.Aanmelden.TabIndex = 11;
            this.Aanmelden.Text = "RESET";
            this.Aanmelden.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(461, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "...";
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
            this.button_Instelingen.Click += new System.EventHandler(this.button_Instellingen_Click);
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
            this.button_LiveActiviteit.UseVisualStyleBackColor = true;
            this.button_LiveActiviteit.Click += new System.EventHandler(this.button_LiveActiviteit_Click);
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
            // Form_LiveActiviteit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aanmelden);
            this.Controls.Add(this.status);
            this.Controls.Add(this.mensen_uit);
            this.Controls.Add(this.mensen_in);
            this.Controls.Add(this.max_aantal);
            this.Controls.Add(this.aantal_mensen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_LiveActiviteit";
            this.Text = "Live_activiteit";
            this.Load += new System.EventHandler(this.Form_LiveActiviteit_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Label aantal_mensen;
        private System.Windows.Forms.Label max_aantal;
        private System.Windows.Forms.Label mensen_in;
        private System.Windows.Forms.Label mensen_uit;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button Aanmelden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}