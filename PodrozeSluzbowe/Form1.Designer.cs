namespace PodrozeSluzbowe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxStartAddress = new System.Windows.Forms.TextBox();
            this.tbxDuration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDistance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxStartLocation = new System.Windows.Forms.TextBox();
            this.btnSearchTravels = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.tbxAppKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbxArrival = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxDeparture = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTolerance = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbCars = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aplikacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAdministracyjnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cel podróży";
            // 
            // tbxStartAddress
            // 
            this.tbxStartAddress.Location = new System.Drawing.Point(16, 87);
            this.tbxStartAddress.Name = "tbxStartAddress";
            this.tbxStartAddress.Size = new System.Drawing.Size(390, 20);
            this.tbxStartAddress.TabIndex = 1;
            this.tbxStartAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxStartAddress_KeyPress);
            // 
            // tbxDuration
            // 
            this.tbxDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxDuration.Location = new System.Drawing.Point(176, 797);
            this.tbxDuration.Name = "tbxDuration";
            this.tbxDuration.Size = new System.Drawing.Size(133, 20);
            this.tbxDuration.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 781);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Czas podróży";
            // 
            // tbxDistance
            // 
            this.tbxDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxDistance.Location = new System.Drawing.Point(15, 797);
            this.tbxDistance.Name = "tbxDistance";
            this.tbxDistance.Size = new System.Drawing.Size(133, 20);
            this.tbxDistance.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 781);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Odległość";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 664);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Współrzędne";
            // 
            // tbxStartLocation
            // 
            this.tbxStartLocation.Location = new System.Drawing.Point(15, 680);
            this.tbxStartLocation.Name = "tbxStartLocation";
            this.tbxStartLocation.Size = new System.Drawing.Size(294, 20);
            this.tbxStartLocation.TabIndex = 10;
            // 
            // btnSearchTravels
            // 
            this.btnSearchTravels.Location = new System.Drawing.Point(10, 162);
            this.btnSearchTravels.Name = "btnSearchTravels";
            this.btnSearchTravels.Size = new System.Drawing.Size(113, 24);
            this.btnSearchTravels.TabIndex = 13;
            this.btnSearchTravels.Text = "Wyszukaj podróż";
            this.btnSearchTravels.UseVisualStyleBackColor = true;
            this.btnSearchTravels.Click += new System.EventHandler(this.btnSearchTravels_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(663, 53);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(455, 782);
            this.webBrowser.TabIndex = 15;
            // 
            // tbxAppKey
            // 
            this.tbxAppKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxAppKey.Location = new System.Drawing.Point(15, 838);
            this.tbxAppKey.Name = "tbxAppKey";
            this.tbxAppKey.Size = new System.Drawing.Size(294, 20);
            this.tbxAppKey.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 822);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "AppKey";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(639, 553);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tbxArrival
            // 
            this.tbxArrival.BackColor = System.Drawing.Color.White;
            this.tbxArrival.Location = new System.Drawing.Point(139, 132);
            this.tbxArrival.Name = "tbxArrival";
            this.tbxArrival.ReadOnly = true;
            this.tbxArrival.Size = new System.Drawing.Size(105, 20);
            this.tbxArrival.TabIndex = 22;
            this.tbxArrival.Click += new System.EventHandler(this.calendar_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Data powrotu";
            // 
            // tbxDeparture
            // 
            this.tbxDeparture.BackColor = System.Drawing.Color.White;
            this.tbxDeparture.Location = new System.Drawing.Point(16, 131);
            this.tbxDeparture.Name = "tbxDeparture";
            this.tbxDeparture.ReadOnly = true;
            this.tbxDeparture.Size = new System.Drawing.Size(107, 20);
            this.tbxDeparture.TabIndex = 20;
            this.tbxDeparture.Click += new System.EventHandler(this.calendar_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Data wyjazdu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "+/- dni";
            // 
            // tbxTolerance
            // 
            this.tbxTolerance.Location = new System.Drawing.Point(262, 132);
            this.tbxTolerance.Name = "tbxTolerance";
            this.tbxTolerance.Size = new System.Drawing.Size(35, 20);
            this.tbxTolerance.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Dodaj podróż";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Samochód";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(10, 748);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 24);
            this.label10.TabIndex = 28;
            this.label10.Text = "Informacje o trasie";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Edytuj podróż";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(334, 797);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Usuń podróż";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cmbCars
            // 
            this.cmbCars.FormattingEnabled = true;
            this.cmbCars.Location = new System.Drawing.Point(426, 86);
            this.cmbCars.Name = "cmbCars";
            this.cmbCars.Size = new System.Drawing.Size(227, 21);
            this.cmbCars.TabIndex = 31;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aplikacjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1130, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // aplikacjaToolStripMenuItem
            // 
            this.aplikacjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelAdministracyjnyToolStripMenuItem});
            this.aplikacjaToolStripMenuItem.Name = "aplikacjaToolStripMenuItem";
            this.aplikacjaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aplikacjaToolStripMenuItem.Text = "Aplikacja";
            // 
            // panelAdministracyjnyToolStripMenuItem
            // 
            this.panelAdministracyjnyToolStripMenuItem.Name = "panelAdministracyjnyToolStripMenuItem";
            this.panelAdministracyjnyToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.panelAdministracyjnyToolStripMenuItem.Text = "Panel Administracyjny";
            this.panelAdministracyjnyToolStripMenuItem.Click += new System.EventHandler(this.panelAdministracyjnyToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 867);
            this.Controls.Add(this.cmbCars);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxTolerance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxArrival);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxDeparture);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbxAppKey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.btnSearchTravels);
            this.Controls.Add(this.tbxStartLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxDistance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxStartAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Go Our Car - Obliczanie dystansu i czasu podróży";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxStartAddress;
        private System.Windows.Forms.TextBox tbxDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDistance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxStartLocation;
        private System.Windows.Forms.Button btnSearchTravels;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TextBox tbxAppKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbxArrival;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxDeparture;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTolerance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbCars;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aplikacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelAdministracyjnyToolStripMenuItem;
    }
}

