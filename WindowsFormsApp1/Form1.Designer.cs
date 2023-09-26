namespace WindowsFormsApp1
{
    partial class Kutyaszar
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_color = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dogCount = new System.Windows.Forms.Label();
            this.readLabel = new System.Windows.Forms.Label();
            this.addJson = new System.Windows.Forms.GroupBox();
            this.jsonButton = new System.Windows.Forms.Button();
            this.jsonBox = new System.Windows.Forms.TextBox();
            this.button69 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.addJson.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Location = new System.Drawing.Point(14, 27);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(262, 206);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(14, 268);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kutyák lekérése";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_name.Location = new System.Drawing.Point(13, 63);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(293, 30);
            this.textBox_name.TabIndex = 2;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(14, 242);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Kutya hozzáadása";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(8, 91);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(273, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Kutya törlése";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "anyadxd",
            "dog",
            "xdddd"});
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(8, 42);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 41);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(343, 366);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(306, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 7;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vesszővel elválasztva több kutya törölhető egyszerre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kutya neve:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kutya kora:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox_age
            // 
            this.textBox_age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_age.Location = new System.Drawing.Point(14, 119);
            this.textBox_age.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_age.Multiline = true;
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(293, 30);
            this.textBox_age.TabIndex = 11;
            this.textBox_age.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kutya színe:";
            // 
            // textBox_color
            // 
            this.textBox_color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_color.Location = new System.Drawing.Point(14, 179);
            this.textBox_color.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_color.Multiline = true;
            this.textBox_color.Name = "textBox_color";
            this.textBox_color.Size = new System.Drawing.Size(293, 30);
            this.textBox_color.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Törölni kívánt kutyák nevei:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_color);
            this.groupBox1.Controls.Add(this.textBox_age);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(308, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(315, 288);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kutya hozzáadása";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(631, 94);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(289, 174);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kutya törlése";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dogCount);
            this.groupBox3.Controls.Add(this.textBox);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(13, 94);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(287, 315);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kutyák lekérése";
            // 
            // dogCount
            // 
            this.dogCount.AutoSize = true;
            this.dogCount.Location = new System.Drawing.Point(14, 247);
            this.dogCount.Name = "dogCount";
            this.dogCount.Size = new System.Drawing.Size(0, 16);
            this.dogCount.TabIndex = 2;
            // 
            // readLabel
            // 
            this.readLabel.AutoSize = true;
            this.readLabel.BackColor = System.Drawing.Color.Red;
            this.readLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.readLabel.Location = new System.Drawing.Point(11, 375);
            this.readLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readLabel.Name = "readLabel";
            this.readLabel.Size = new System.Drawing.Size(0, 16);
            this.readLabel.TabIndex = 19;
            // 
            // addJson
            // 
            this.addJson.Controls.Add(this.jsonButton);
            this.addJson.Controls.Add(this.jsonBox);
            this.addJson.ForeColor = System.Drawing.SystemColors.Control;
            this.addJson.Location = new System.Drawing.Point(631, 276);
            this.addJson.Name = "addJson";
            this.addJson.Size = new System.Drawing.Size(290, 188);
            this.addJson.TabIndex = 20;
            this.addJson.TabStop = false;
            this.addJson.Text = "JSON adat hozzáadása";
            // 
            // jsonButton
            // 
            this.jsonButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.jsonButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jsonButton.Location = new System.Drawing.Point(12, 127);
            this.jsonButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jsonButton.Name = "jsonButton";
            this.jsonButton.Size = new System.Drawing.Size(273, 37);
            this.jsonButton.TabIndex = 6;
            this.jsonButton.Text = "Kutya hozzáadása";
            this.jsonButton.UseVisualStyleBackColor = false;
            this.jsonButton.Click += new System.EventHandler(this.jsonButton_Click);
            // 
            // jsonBox
            // 
            this.jsonBox.AutoCompleteCustomSource.AddRange(new string[] {
            "anyadxd",
            "dog",
            "xdddd"});
            this.jsonBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jsonBox.Location = new System.Drawing.Point(12, 24);
            this.jsonBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jsonBox.Multiline = true;
            this.jsonBox.Name = "jsonBox";
            this.jsonBox.Size = new System.Drawing.Size(270, 93);
            this.jsonBox.TabIndex = 5;
            // 
            // button69
            // 
            this.button69.BackColor = System.Drawing.Color.Transparent;
            this.button69.Dock = System.Windows.Forms.DockStyle.Right;
            this.button69.FlatAppearance.BorderSize = 0;
            this.button69.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button69.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button69.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button69.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.button69.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button69.Location = new System.Drawing.Point(841, 0);
            this.button69.Name = "button69";
            this.button69.Padding = new System.Windows.Forms.Padding(2);
            this.button69.Size = new System.Drawing.Size(43, 34);
            this.button69.TabIndex = 21;
            this.button69.Text = "X";
            this.button69.UseVisualStyleBackColor = false;
            this.button69.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(884, 0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(2);
            this.button5.Size = new System.Drawing.Size(49, 34);
            this.button5.TabIndex = 22;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(792, 0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(2);
            this.button6.Size = new System.Drawing.Size(49, 34);
            this.button6.TabIndex = 23;
            this.button6.Text = "□";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button69);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 34);
            this.panel1.TabIndex = 24;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.egerle);
            // 
            // Kutyaszar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(933, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addJson);
            this.Controls.Add(this.readLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Kutyaszar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Kutya nyílvántartás";
            this.TransparencyKey = System.Drawing.Color.Wheat;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.addJson.ResumeLayout(false);
            this.addJson.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_color;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label readLabel;
        private System.Windows.Forms.GroupBox addJson;
        private System.Windows.Forms.Button jsonButton;
        private System.Windows.Forms.TextBox jsonBox;
        private System.Windows.Forms.Label dogCount;
        private System.Windows.Forms.Button button69;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
    }
}

