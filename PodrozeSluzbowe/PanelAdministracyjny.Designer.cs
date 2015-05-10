﻿namespace PodrozeSluzbowe
{
    partial class PanelAdministracyjny
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.removeUser = new System.Windows.Forms.Button();
            this.gbAddUser = new System.Windows.Forms.GroupBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtDział = new System.Windows.Forms.TextBox();
            this.lblSurName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPasswordAgain = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oknoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.lblNumberOfSeats = new System.Windows.Forms.Label();
            this.lblRegistrationNumber = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtNumberOfSeats = new System.Windows.Forms.TextBox();
            this.txtRegistrationNumber = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.gbAddUser.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(6, 19);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(142, 23);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Dodaj użytkownika";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(331, 13);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 1;
            // 
            // removeUser
            // 
            this.removeUser.Enabled = false;
            this.removeUser.Location = new System.Drawing.Point(6, 48);
            this.removeUser.Name = "removeUser";
            this.removeUser.Size = new System.Drawing.Size(142, 23);
            this.removeUser.TabIndex = 2;
            this.removeUser.Text = "Usuń użytkownika";
            this.removeUser.UseVisualStyleBackColor = true;
            this.removeUser.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gbAddUser
            // 
            this.gbAddUser.Controls.Add(this.dataGridViewUsers);
            this.gbAddUser.Controls.Add(this.lblDepartment);
            this.gbAddUser.Controls.Add(this.removeUser);
            this.gbAddUser.Controls.Add(this.txtDział);
            this.gbAddUser.Controls.Add(this.btnAddUser);
            this.gbAddUser.Controls.Add(this.lblSurName);
            this.gbAddUser.Controls.Add(this.lblFirstName);
            this.gbAddUser.Controls.Add(this.lblPasswordAgain);
            this.gbAddUser.Controls.Add(this.lblPassword);
            this.gbAddUser.Controls.Add(this.txtNazwisko);
            this.gbAddUser.Controls.Add(this.txtImie);
            this.gbAddUser.Controls.Add(this.txtPassword2);
            this.gbAddUser.Controls.Add(this.txtPassword);
            this.gbAddUser.Controls.Add(this.lblLogin);
            this.gbAddUser.Controls.Add(this.txtLogin);
            this.gbAddUser.Location = new System.Drawing.Point(12, 27);
            this.gbAddUser.Name = "gbAddUser";
            this.gbAddUser.Size = new System.Drawing.Size(657, 465);
            this.gbAddUser.TabIndex = 3;
            this.gbAddUser.TabStop = false;
            this.gbAddUser.Text = "użytkownik";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(289, 146);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(32, 13);
            this.lblDepartment.TabIndex = 12;
            this.lblDepartment.Text = "Dział";
            // 
            // txtDział
            // 
            this.txtDział.Location = new System.Drawing.Point(331, 143);
            this.txtDział.Name = "txtDział";
            this.txtDział.Size = new System.Drawing.Size(100, 20);
            this.txtDział.TabIndex = 11;
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Location = new System.Drawing.Point(272, 120);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(53, 13);
            this.lblSurName.TabIndex = 10;
            this.lblSurName.Text = "Nazwisko";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(299, 94);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(26, 13);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "Imię";
            // 
            // lblPasswordAgain
            // 
            this.lblPasswordAgain.AutoSize = true;
            this.lblPasswordAgain.Location = new System.Drawing.Point(251, 68);
            this.lblPasswordAgain.Name = "lblPasswordAgain";
            this.lblPasswordAgain.Size = new System.Drawing.Size(74, 13);
            this.lblPasswordAgain.TabIndex = 8;
            this.lblPasswordAgain.Text = "PowtórzHasło";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(289, 42);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(36, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Hasło";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(331, 117);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(100, 20);
            this.txtNazwisko.TabIndex = 6;
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(331, 91);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(100, 20);
            this.txtImie.TabIndex = 5;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(331, 65);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(100, 20);
            this.txtPassword2.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(331, 39);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(292, 16);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oknoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1294, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oknoToolStripMenuItem
            // 
            this.oknoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakończToolStripMenuItem});
            this.oknoToolStripMenuItem.Name = "oknoToolStripMenuItem";
            this.oknoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.oknoToolStripMenuItem.Text = "Okno";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(6, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Usuń samochód";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Dodaj samochód";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewCars);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lblNumberOfSeats);
            this.groupBox1.Controls.Add(this.lblRegistrationNumber);
            this.groupBox1.Controls.Add(this.lblModel);
            this.groupBox1.Controls.Add(this.txtNumberOfSeats);
            this.groupBox1.Controls.Add(this.txtRegistrationNumber);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.lblBrand);
            this.groupBox1.Controls.Add(this.txtBrand);
            this.groupBox1.Location = new System.Drawing.Point(675, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 465);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flota samochodów";
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Location = new System.Drawing.Point(11, 194);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.Size = new System.Drawing.Size(590, 265);
            this.dataGridViewCars.TabIndex = 10;
            // 
            // lblNumberOfSeats
            // 
            this.lblNumberOfSeats.AutoSize = true;
            this.lblNumberOfSeats.Location = new System.Drawing.Point(181, 101);
            this.lblNumberOfSeats.Name = "lblNumberOfSeats";
            this.lblNumberOfSeats.Size = new System.Drawing.Size(70, 13);
            this.lblNumberOfSeats.TabIndex = 9;
            this.lblNumberOfSeats.Text = "Liczba miejsc";
            // 
            // lblRegistrationNumber
            // 
            this.lblRegistrationNumber.AutoSize = true;
            this.lblRegistrationNumber.Location = new System.Drawing.Point(168, 71);
            this.lblRegistrationNumber.Name = "lblRegistrationNumber";
            this.lblRegistrationNumber.Size = new System.Drawing.Size(99, 13);
            this.lblRegistrationNumber.TabIndex = 8;
            this.lblRegistrationNumber.Text = "Numer rejestracyjny";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(206, 45);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Model";
            // 
            // txtNumberOfSeats
            // 
            this.txtNumberOfSeats.Location = new System.Drawing.Point(269, 94);
            this.txtNumberOfSeats.Name = "txtNumberOfSeats";
            this.txtNumberOfSeats.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfSeats.TabIndex = 5;
            // 
            // txtRegistrationNumber
            // 
            this.txtRegistrationNumber.Location = new System.Drawing.Point(269, 68);
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRegistrationNumber.TabIndex = 4;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(269, 42);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 3;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(209, 19);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(37, 13);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Marka";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(269, 16);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBrand.TabIndex = 1;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(7, 194);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(644, 265);
            this.dataGridViewUsers.TabIndex = 13;
            // 
            // PanelAdministracyjny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 663);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAddUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PanelAdministracyjny";
            this.Text = "PanelAdministracyjny";
            this.gbAddUser.ResumeLayout(false);
            this.gbAddUser.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button removeUser;
        private System.Windows.Forms.GroupBox gbAddUser;
        private System.Windows.Forms.Label lblSurName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPasswordAgain;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtDział;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oknoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumberOfSeats;
        private System.Windows.Forms.Label lblRegistrationNumber;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtNumberOfSeats;
        private System.Windows.Forms.TextBox txtRegistrationNumber;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.DataGridView dataGridViewCars;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
    }
}