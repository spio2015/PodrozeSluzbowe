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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbAddUser = new System.Windows.Forms.GroupBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPasswordAgain = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSurName = new System.Windows.Forms.Label();
            this.txtDział = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.gbAddUser.SuspendLayout();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gbAddUser
            // 
            this.gbAddUser.Controls.Add(this.lblDepartment);
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
            this.gbAddUser.Location = new System.Drawing.Point(249, 66);
            this.gbAddUser.Name = "gbAddUser";
            this.gbAddUser.Size = new System.Drawing.Size(440, 292);
            this.gbAddUser.TabIndex = 3;
            this.gbAddUser.TabStop = false;
            this.gbAddUser.Text = "użytkownik";
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
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(331, 39);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(331, 65);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(100, 20);
            this.txtPassword2.TabIndex = 4;
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(331, 91);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(100, 20);
            this.txtImie.TabIndex = 5;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(331, 117);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(100, 20);
            this.txtNazwisko.TabIndex = 6;
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
            // lblPasswordAgain
            // 
            this.lblPasswordAgain.AutoSize = true;
            this.lblPasswordAgain.Location = new System.Drawing.Point(251, 68);
            this.lblPasswordAgain.Name = "lblPasswordAgain";
            this.lblPasswordAgain.Size = new System.Drawing.Size(74, 13);
            this.lblPasswordAgain.TabIndex = 8;
            this.lblPasswordAgain.Text = "PowtórzHasło";
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
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Location = new System.Drawing.Point(272, 120);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(53, 13);
            this.lblSurName.TabIndex = 10;
            this.lblSurName.Text = "Nazwisko";
            // 
            // txtDział
            // 
            this.txtDział.Location = new System.Drawing.Point(331, 143);
            this.txtDział.Name = "txtDział";
            this.txtDział.Size = new System.Drawing.Size(100, 20);
            this.txtDział.TabIndex = 11;
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
            // PanelAdministracyjny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 523);
            this.Controls.Add(this.gbAddUser);
            this.Controls.Add(this.button1);
            this.Name = "PanelAdministracyjny";
            this.Text = "PanelAdministracyjny";
            this.gbAddUser.ResumeLayout(false);
            this.gbAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button button1;
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
    }
}