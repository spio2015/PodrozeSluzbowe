﻿namespace PodrozeSluzbowe
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxStartAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxStartLocation = new System.Windows.Forms.TextBox();
            this.btnSearchTravels = new System.Windows.Forms.Button();
            this.tbxAppKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbxArrival = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxDeparture = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTolerance = new System.Windows.Forms.TextBox();
            this.btnAddTrip = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditTravels = new System.Windows.Forms.Button();
            this.btnRemoveTravels = new System.Windows.Forms.Button();
            this.cmbCars = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplikacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAdministracyjnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.wyjścieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnJoinToTravel = new System.Windows.Forms.Button();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxUsers = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cel podróży";
            // 
            // tbxStartAddress
            // 
            this.tbxStartAddress.Location = new System.Drawing.Point(16, 55);
            this.tbxStartAddress.Name = "tbxStartAddress";
            this.tbxStartAddress.Size = new System.Drawing.Size(390, 20);
            this.tbxStartAddress.TabIndex = 1;
            this.tbxStartAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxStartAddress_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 664);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Współrzędne";
            this.label5.Visible = false;
            // 
            // tbxStartLocation
            // 
            this.tbxStartLocation.Location = new System.Drawing.Point(15, 680);
            this.tbxStartLocation.Name = "tbxStartLocation";
            this.tbxStartLocation.Size = new System.Drawing.Size(294, 20);
            this.tbxStartLocation.TabIndex = 10;
            this.tbxStartLocation.Visible = false;
            // 
            // btnSearchTravels
            // 
            this.btnSearchTravels.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTravels.Image")));
            this.btnSearchTravels.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchTravels.Location = new System.Drawing.Point(333, 100);
            this.btnSearchTravels.Name = "btnSearchTravels";
            this.btnSearchTravels.Size = new System.Drawing.Size(113, 24);
            this.btnSearchTravels.TabIndex = 13;
            this.btnSearchTravels.Text = "Wyszukaj podróż";
            this.btnSearchTravels.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchTravels.UseVisualStyleBackColor = true;
            this.btnSearchTravels.Click += new System.EventHandler(this.btnSearchTravels_Click);
            // 
            // tbxAppKey
            // 
            this.tbxAppKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxAppKey.Location = new System.Drawing.Point(350, 673);
            this.tbxAppKey.Name = "tbxAppKey";
            this.tbxAppKey.Size = new System.Drawing.Size(294, 20);
            this.tbxAppKey.TabIndex = 17;
            this.tbxAppKey.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 657);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "AppKey";
            this.label7.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(14, 130);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(639, 491);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tbxArrival
            // 
            this.tbxArrival.BackColor = System.Drawing.Color.DarkGray;
            this.tbxArrival.Enabled = false;
            this.tbxArrival.Location = new System.Drawing.Point(139, 104);
            this.tbxArrival.Name = "tbxArrival";
            this.tbxArrival.ReadOnly = true;
            this.tbxArrival.Size = new System.Drawing.Size(105, 20);
            this.tbxArrival.TabIndex = 22;
            this.tbxArrival.Click += new System.EventHandler(this.tbxArrival_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Data powrotu";
            // 
            // tbxDeparture
            // 
            this.tbxDeparture.BackColor = System.Drawing.Color.White;
            this.tbxDeparture.Location = new System.Drawing.Point(16, 104);
            this.tbxDeparture.Name = "tbxDeparture";
            this.tbxDeparture.ReadOnly = true;
            this.tbxDeparture.Size = new System.Drawing.Size(107, 20);
            this.tbxDeparture.TabIndex = 20;
            this.tbxDeparture.Click += new System.EventHandler(this.tbxDeparture_Click);
            this.tbxDeparture.TextChanged += new System.EventHandler(this.tbxDeparture_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Data wyjazdu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "+/- dni";
            // 
            // tbxTolerance
            // 
            this.tbxTolerance.Location = new System.Drawing.Point(262, 104);
            this.tbxTolerance.Name = "tbxTolerance";
            this.tbxTolerance.Size = new System.Drawing.Size(35, 20);
            this.tbxTolerance.TabIndex = 24;
            this.tbxTolerance.Validating += new System.ComponentModel.CancelEventHandler(this.tbxTolerance_Validating);
            // 
            // btnAddTrip
            // 
            this.btnAddTrip.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTrip.Image")));
            this.btnAddTrip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTrip.Location = new System.Drawing.Point(547, 101);
            this.btnAddTrip.Name = "btnAddTrip";
            this.btnAddTrip.Size = new System.Drawing.Size(106, 23);
            this.btnAddTrip.TabIndex = 25;
            this.btnAddTrip.Text = "Dodaj podróż";
            this.btnAddTrip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTrip.UseVisualStyleBackColor = true;
            this.btnAddTrip.Click += new System.EventHandler(this.btnAddTrip_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Samochód";
            // 
            // btnEditTravels
            // 
            this.btnEditTravels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditTravels.Location = new System.Drawing.Point(273, 627);
            this.btnEditTravels.Name = "btnEditTravels";
            this.btnEditTravels.Size = new System.Drawing.Size(106, 23);
            this.btnEditTravels.TabIndex = 29;
            this.btnEditTravels.Text = "Edytuj podróż";
            this.btnEditTravels.UseVisualStyleBackColor = true;
            this.btnEditTravels.Visible = false;
            // 
            // btnRemoveTravels
            // 
            this.btnRemoveTravels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveTravels.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveTravels.Image")));
            this.btnRemoveTravels.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveTravels.Location = new System.Drawing.Point(15, 627);
            this.btnRemoveTravels.Name = "btnRemoveTravels";
            this.btnRemoveTravels.Size = new System.Drawing.Size(118, 23);
            this.btnRemoveTravels.TabIndex = 30;
            this.btnRemoveTravels.Text = "Usuń podróż";
            this.btnRemoveTravels.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveTravels.UseVisualStyleBackColor = true;
            this.btnRemoveTravels.Click += new System.EventHandler(this.btnRemoveTrip_Click);
            // 
            // cmbCars
            // 
            this.cmbCars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCars.FormattingEnabled = true;
            this.cmbCars.Location = new System.Drawing.Point(426, 54);
            this.cmbCars.Name = "cmbCars";
            this.cmbCars.Size = new System.Drawing.Size(227, 21);
            this.cmbCars.TabIndex = 31;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplikacjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1130, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplikacjaToolStripMenuItem
            // 
            this.aplikacjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelAdministracyjnyToolStripMenuItem,
            this.raportToolStripMenuItem,
            this.toolStripSeparator1,
            this.wyjścieToolStripMenuItem1});
            this.aplikacjaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aplikacjaToolStripMenuItem.Image")));
            this.aplikacjaToolStripMenuItem.Name = "aplikacjaToolStripMenuItem";
            this.aplikacjaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.aplikacjaToolStripMenuItem.Text = "Menu";
            // 
            // panelAdministracyjnyToolStripMenuItem
            // 
            this.panelAdministracyjnyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("panelAdministracyjnyToolStripMenuItem.Image")));
            this.panelAdministracyjnyToolStripMenuItem.Name = "panelAdministracyjnyToolStripMenuItem";
            this.panelAdministracyjnyToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.panelAdministracyjnyToolStripMenuItem.Text = "Panel Administracyjny";
            this.panelAdministracyjnyToolStripMenuItem.Click += new System.EventHandler(this.panelAdministracyjnyToolStripMenuItem_Click);
            // 
            // raportToolStripMenuItem
            // 
            this.raportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("raportToolStripMenuItem.Image")));
            this.raportToolStripMenuItem.Name = "raportToolStripMenuItem";
            this.raportToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.raportToolStripMenuItem.Text = "Raport";
            this.raportToolStripMenuItem.Click += new System.EventHandler(this.raportToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // wyjścieToolStripMenuItem1
            // 
            this.wyjścieToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("wyjścieToolStripMenuItem1.Image")));
            this.wyjścieToolStripMenuItem1.Name = "wyjścieToolStripMenuItem1";
            this.wyjścieToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.wyjścieToolStripMenuItem1.Text = "Wyjście";
            this.wyjścieToolStripMenuItem1.Click += new System.EventHandler(this.wyjścieToolStripMenuItem1_Click);
            // 
            // btnJoinToTravel
            // 
            this.btnJoinToTravel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnJoinToTravel.Image = ((System.Drawing.Image)(resources.GetObject("btnJoinToTravel.Image")));
            this.btnJoinToTravel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJoinToTravel.Location = new System.Drawing.Point(535, 627);
            this.btnJoinToTravel.Name = "btnJoinToTravel";
            this.btnJoinToTravel.Size = new System.Drawing.Size(118, 23);
            this.btnJoinToTravel.TabIndex = 33;
            this.btnJoinToTravel.Text = "Dołącz do podróży";
            this.btnJoinToTravel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJoinToTravel.UseVisualStyleBackColor = true;
            this.btnJoinToTravel.Click += new System.EventHandler(this.btnJoinToTravel_Click);
            // 
            // tbxLogin
            // 
            this.tbxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxLogin.Location = new System.Drawing.Point(1004, 40);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(100, 20);
            this.tbxLogin.TabIndex = 34;
            this.tbxLogin.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1001, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Login";
            this.label3.Visible = false;
            // 
            // cmbBoxUsers
            // 
            this.cmbBoxUsers.FormattingEnabled = true;
            this.cmbBoxUsers.Location = new System.Drawing.Point(874, 39);
            this.cmbBoxUsers.Name = "cmbBoxUsers";
            this.cmbBoxUsers.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxUsers.TabIndex = 36;
            this.cmbBoxUsers.Visible = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 743);
            this.Controls.Add(this.cmbBoxUsers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.btnJoinToTravel);
            this.Controls.Add(this.cmbCars);
            this.Controls.Add(this.btnRemoveTravels);
            this.Controls.Add(this.btnEditTravels);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddTrip);
            this.Controls.Add(this.tbxTolerance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxArrival);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxDeparture);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbxAppKey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSearchTravels);
            this.Controls.Add(this.tbxStartLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxStartAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainScreen";
            this.Text = "Go Our Car - Obliczanie dystansu i czasu podróży - Zalogowany użytkownik: ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxStartAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxStartLocation;
        private System.Windows.Forms.Button btnSearchTravels;
        private System.Windows.Forms.TextBox tbxAppKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbxArrival;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxDeparture;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTolerance;
        private System.Windows.Forms.Button btnAddTrip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditTravels;
        private System.Windows.Forms.Button btnRemoveTravels;
        private System.Windows.Forms.ComboBox cmbCars;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplikacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelAdministracyjnyToolStripMenuItem;
        private System.Windows.Forms.Button btnJoinToTravel;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem raportToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbBoxUsers;
        private System.Windows.Forms.ToolStripMenuItem wyjścieToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

