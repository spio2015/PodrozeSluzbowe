namespace PodrozeSluzbowe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelAdministracyjny));
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.gbAddUser = new System.Windows.Forms.GroupBox();
            this.cmbBoxUsersDepartment = new System.Windows.Forms.ComboBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.lblDepartment = new System.Windows.Forms.Label();
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
            this.btnRemoveCar = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.gbAddCar = new System.Windows.Forms.GroupBox();
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblNumberOfSeats = new System.Windows.Forms.Label();
            this.lblRegistrationNumber = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtNumberOfSeats = new System.Windows.Forms.TextBox();
            this.txtRegistrationNumber = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.errorProvAdm = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbAddCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvAdm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(6, 19);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(142, 23);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "Dodaj użytkownika";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(240, 13);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(121, 20);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveUser.Image")));
            this.btnRemoveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveUser.Location = new System.Drawing.Point(6, 48);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(142, 23);
            this.btnRemoveUser.TabIndex = 8;
            this.btnRemoveUser.Text = "Usuń użytkownika";
            this.btnRemoveUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gbAddUser
            // 
            this.gbAddUser.Controls.Add(this.cmbBoxUsersDepartment);
            this.gbAddUser.Controls.Add(this.dataGridViewUsers);
            this.gbAddUser.Controls.Add(this.lblDepartment);
            this.gbAddUser.Controls.Add(this.btnRemoveUser);
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
            this.gbAddUser.Size = new System.Drawing.Size(655, 465);
            this.gbAddUser.TabIndex = 3;
            this.gbAddUser.TabStop = false;
            this.gbAddUser.Text = "Użytkownik";
            // 
            // cmbBoxUsersDepartment
            // 
            this.cmbBoxUsersDepartment.FormattingEnabled = true;
            this.cmbBoxUsersDepartment.Location = new System.Drawing.Point(240, 143);
            this.cmbBoxUsersDepartment.Name = "cmbBoxUsersDepartment";
            this.cmbBoxUsersDepartment.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxUsersDepartment.TabIndex = 6;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(7, 194);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(635, 265);
            this.dataGridViewUsers.TabIndex = 13;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(198, 146);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(32, 13);
            this.lblDepartment.TabIndex = 12;
            this.lblDepartment.Text = "Dział";
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Location = new System.Drawing.Point(181, 120);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(53, 13);
            this.lblSurName.TabIndex = 10;
            this.lblSurName.Text = "Nazwisko";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(208, 94);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(26, 13);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "Imię";
            // 
            // lblPasswordAgain
            // 
            this.lblPasswordAgain.AutoSize = true;
            this.lblPasswordAgain.Location = new System.Drawing.Point(160, 68);
            this.lblPasswordAgain.Name = "lblPasswordAgain";
            this.lblPasswordAgain.Size = new System.Drawing.Size(74, 13);
            this.lblPasswordAgain.TabIndex = 8;
            this.lblPasswordAgain.Text = "PowtórzHasło";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(198, 42);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(36, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Hasło";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(240, 117);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(121, 20);
            this.txtNazwisko.TabIndex = 5;
            this.txtNazwisko.TextChanged += new System.EventHandler(this.txtNazwisko_TextChanged);
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(240, 91);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(121, 20);
            this.txtImie.TabIndex = 4;
            this.txtImie.TextChanged += new System.EventHandler(this.txtImie_TextChanged);
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(240, 65);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(121, 20);
            this.txtPassword2.TabIndex = 3;
            this.txtPassword2.TextChanged += new System.EventHandler(this.txtPassword2_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(240, 39);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(121, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(201, 16);
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
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oknoToolStripMenuItem
            // 
            this.oknoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakończToolStripMenuItem});
            this.oknoToolStripMenuItem.Name = "oknoToolStripMenuItem";
            this.oknoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.oknoToolStripMenuItem.Text = "Menu";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zakończToolStripMenuItem.Image")));
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // btnRemoveCar
            // 
            this.btnRemoveCar.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveCar.Image")));
            this.btnRemoveCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveCar.Location = new System.Drawing.Point(6, 48);
            this.btnRemoveCar.Name = "btnRemoveCar";
            this.btnRemoveCar.Size = new System.Drawing.Size(142, 23);
            this.btnRemoveCar.TabIndex = 6;
            this.btnRemoveCar.Text = "Usuń samochód";
            this.btnRemoveCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveCar.UseVisualStyleBackColor = true;
            this.btnRemoveCar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCar.Image")));
            this.btnAddCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCar.Location = new System.Drawing.Point(6, 19);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(142, 23);
            this.btnAddCar.TabIndex = 5;
            this.btnAddCar.Text = "Dodaj samochód";
            this.btnAddCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbAddCar
            // 
            this.gbAddCar.Controls.Add(this.dataGridViewCars);
            this.gbAddCar.Controls.Add(this.txtBrand);
            this.gbAddCar.Controls.Add(this.btnRemoveCar);
            this.gbAddCar.Controls.Add(this.btnAddCar);
            this.gbAddCar.Controls.Add(this.lblNumberOfSeats);
            this.gbAddCar.Controls.Add(this.lblRegistrationNumber);
            this.gbAddCar.Controls.Add(this.lblModel);
            this.gbAddCar.Controls.Add(this.txtNumberOfSeats);
            this.gbAddCar.Controls.Add(this.txtRegistrationNumber);
            this.gbAddCar.Controls.Add(this.txtModel);
            this.gbAddCar.Controls.Add(this.lblBrand);
            this.gbAddCar.Location = new System.Drawing.Point(680, 27);
            this.gbAddCar.Name = "gbAddCar";
            this.gbAddCar.Size = new System.Drawing.Size(678, 465);
            this.gbAddCar.TabIndex = 13;
            this.gbAddCar.TabStop = false;
            this.gbAddCar.Text = "Flota samochodów";
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Location = new System.Drawing.Point(11, 194);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCars.Size = new System.Drawing.Size(650, 265);
            this.dataGridViewCars.TabIndex = 10;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(269, 13);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBrand.TabIndex = 1;
            this.txtBrand.TextChanged += new System.EventHandler(this.txtBrand_TextChanged);
            // 
            // lblNumberOfSeats
            // 
            this.lblNumberOfSeats.AutoSize = true;
            this.lblNumberOfSeats.Location = new System.Drawing.Point(193, 97);
            this.lblNumberOfSeats.Name = "lblNumberOfSeats";
            this.lblNumberOfSeats.Size = new System.Drawing.Size(70, 13);
            this.lblNumberOfSeats.TabIndex = 9;
            this.lblNumberOfSeats.Text = "Liczba miejsc";
            // 
            // lblRegistrationNumber
            // 
            this.lblRegistrationNumber.AutoSize = true;
            this.lblRegistrationNumber.Location = new System.Drawing.Point(164, 71);
            this.lblRegistrationNumber.Name = "lblRegistrationNumber";
            this.lblRegistrationNumber.Size = new System.Drawing.Size(99, 13);
            this.lblRegistrationNumber.TabIndex = 8;
            this.lblRegistrationNumber.Text = "Numer rejestracyjny";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(227, 45);
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
            this.txtNumberOfSeats.Text = "5";
            this.txtNumberOfSeats.TextChanged += new System.EventHandler(this.txtNumberOfSeats_TextChanged);
            // 
            // txtRegistrationNumber
            // 
            this.txtRegistrationNumber.Location = new System.Drawing.Point(269, 68);
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRegistrationNumber.TabIndex = 4;
            this.txtRegistrationNumber.TextChanged += new System.EventHandler(this.txtRegistrationNumber_TextChanged);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(269, 42);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 2;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(226, 19);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(37, 13);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Marka";
            // 
            // errorProvAdm
            // 
            this.errorProvAdm.ContainerControl = this;
            // 
            // PanelAdministracyjny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 663);
            this.Controls.Add(this.gbAddCar);
            this.Controls.Add(this.gbAddUser);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PanelAdministracyjny";
            this.Text = "Panel Administracyjny";
            this.gbAddUser.ResumeLayout(false);
            this.gbAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbAddCar.ResumeLayout(false);
            this.gbAddCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvAdm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnRemoveUser;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oknoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.Button btnRemoveCar;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.GroupBox gbAddCar;
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
        private System.Windows.Forms.ComboBox cmbBoxUsersDepartment;
        private System.Windows.Forms.ErrorProvider errorProvAdm;
    }
}