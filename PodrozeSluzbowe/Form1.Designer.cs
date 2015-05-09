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
            this.tbxEndAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateRoute = new System.Windows.Forms.Button();
            this.tbxDuration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDistance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxStartLocation = new System.Windows.Forms.TextBox();
            this.tbxEndLocation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOpenStartLocation = new System.Windows.Forms.Button();
            this.btnOpenEndLocation = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.tbxAppKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbxArrival = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxDeparture = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miejsce początkowe";
            // 
            // tbxStartAddress
            // 
            this.tbxStartAddress.Location = new System.Drawing.Point(15, 25);
            this.tbxStartAddress.Name = "tbxStartAddress";
            this.tbxStartAddress.Size = new System.Drawing.Size(509, 20);
            this.tbxStartAddress.TabIndex = 1;
            // 
            // tbxEndAddress
            // 
            this.tbxEndAddress.Location = new System.Drawing.Point(15, 346);
            this.tbxEndAddress.Name = "tbxEndAddress";
            this.tbxEndAddress.Size = new System.Drawing.Size(509, 20);
            this.tbxEndAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Miejsce docelowe";
            // 
            // btnGenerateRoute
            // 
            this.btnGenerateRoute.Location = new System.Drawing.Point(407, 453);
            this.btnGenerateRoute.Name = "btnGenerateRoute";
            this.btnGenerateRoute.Size = new System.Drawing.Size(117, 36);
            this.btnGenerateRoute.TabIndex = 4;
            this.btnGenerateRoute.Text = "Oblicz";
            this.btnGenerateRoute.UseVisualStyleBackColor = true;
            this.btnGenerateRoute.Click += new System.EventHandler(this.btnGenerateRoute_Click);
            // 
            // tbxDuration
            // 
            this.tbxDuration.Location = new System.Drawing.Point(176, 469);
            this.tbxDuration.Name = "tbxDuration";
            this.tbxDuration.Size = new System.Drawing.Size(133, 20);
            this.tbxDuration.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Czas podróży";
            // 
            // tbxDistance
            // 
            this.tbxDistance.Location = new System.Drawing.Point(15, 469);
            this.tbxDistance.Name = "tbxDistance";
            this.tbxDistance.Size = new System.Drawing.Size(133, 20);
            this.tbxDistance.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Odległość";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Współrzędne";
            // 
            // tbxStartLocation
            // 
            this.tbxStartLocation.Location = new System.Drawing.Point(15, 64);
            this.tbxStartLocation.Name = "tbxStartLocation";
            this.tbxStartLocation.Size = new System.Drawing.Size(294, 20);
            this.tbxStartLocation.TabIndex = 10;
            // 
            // tbxEndLocation
            // 
            this.tbxEndLocation.Location = new System.Drawing.Point(15, 385);
            this.tbxEndLocation.Name = "tbxEndLocation";
            this.tbxEndLocation.Size = new System.Drawing.Size(294, 20);
            this.tbxEndLocation.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Współrzędne";
            // 
            // btnOpenStartLocation
            // 
            this.btnOpenStartLocation.Location = new System.Drawing.Point(324, 51);
            this.btnOpenStartLocation.Name = "btnOpenStartLocation";
            this.btnOpenStartLocation.Size = new System.Drawing.Size(200, 44);
            this.btnOpenStartLocation.TabIndex = 13;
            this.btnOpenStartLocation.Text = "Otwórz lokalizację w przeglądarce";
            this.btnOpenStartLocation.UseVisualStyleBackColor = true;
            this.btnOpenStartLocation.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpenEndLocation
            // 
            this.btnOpenEndLocation.Location = new System.Drawing.Point(324, 369);
            this.btnOpenEndLocation.Name = "btnOpenEndLocation";
            this.btnOpenEndLocation.Size = new System.Drawing.Size(200, 44);
            this.btnOpenEndLocation.TabIndex = 14;
            this.btnOpenEndLocation.Text = "Otwórz lokalizację w przeglądarce";
            this.btnOpenEndLocation.UseVisualStyleBackColor = true;
            this.btnOpenEndLocation.Click += new System.EventHandler(this.btnOpenEndLocation_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(540, 25);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(587, 764);
            this.webBrowser.TabIndex = 15;
            // 
            // tbxAppKey
            // 
            this.tbxAppKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxAppKey.Location = new System.Drawing.Point(15, 772);
            this.tbxAppKey.Name = "tbxAppKey";
            this.tbxAppKey.Size = new System.Drawing.Size(294, 20);
            this.tbxAppKey.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 756);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "AppKey";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 509);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 230);
            this.dataGridView1.TabIndex = 18;
            // 
            // tbxArrival
            // 
            this.tbxArrival.Location = new System.Drawing.Point(176, 103);
            this.tbxArrival.Name = "tbxArrival";
            this.tbxArrival.ReadOnly = true;
            this.tbxArrival.Size = new System.Drawing.Size(133, 20);
            this.tbxArrival.TabIndex = 22;
            this.tbxArrival.Click += new System.EventHandler(this.calendar_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Data powrotu";
            // 
            // tbxDeparture
            // 
            this.tbxDeparture.Location = new System.Drawing.Point(15, 103);
            this.tbxDeparture.Name = "tbxDeparture";
            this.tbxDeparture.ReadOnly = true;
            this.tbxDeparture.Size = new System.Drawing.Size(133, 20);
            this.tbxDeparture.TabIndex = 20;
            this.tbxDeparture.Click += new System.EventHandler(this.calendar_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Data wyjazdu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 801);
            this.Controls.Add(this.tbxArrival);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxDeparture);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbxAppKey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.btnOpenEndLocation);
            this.Controls.Add(this.btnOpenStartLocation);
            this.Controls.Add(this.tbxEndLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxStartLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxDistance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGenerateRoute);
            this.Controls.Add(this.tbxEndAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxStartAddress);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Go Our Car - Obliczanie dystansu i czasu podróży";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxStartAddress;
        private System.Windows.Forms.TextBox tbxEndAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerateRoute;
        private System.Windows.Forms.TextBox tbxDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDistance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxStartLocation;
        private System.Windows.Forms.TextBox tbxEndLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOpenStartLocation;
        private System.Windows.Forms.Button btnOpenEndLocation;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TextBox tbxAppKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbxArrival;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxDeparture;
        private System.Windows.Forms.Label label9;
    }
}

