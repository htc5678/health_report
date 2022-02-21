
namespace Assignment2
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
            this.labelMain = new System.Windows.Forms.Label();
            this.fname_tb = new System.Windows.Forms.TextBox();
            this.lname_tb = new System.Windows.Forms.TextBox();
            this.m_tb = new System.Windows.Forms.TextBox();
            this.g_tb = new System.Windows.Forms.TextBox();
            this.w_tb = new System.Windows.Forms.TextBox();
            this.h_tb = new System.Windows.Forms.TextBox();
            this.y_tb = new System.Windows.Forms.TextBox();
            this.d_tb = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.bmi_b = new System.Windows.Forms.Button();
            this.bmichart_b = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.labelMain.Location = new System.Drawing.Point(268, 38);
            this.labelMain.MinimumSize = new System.Drawing.Size(140, 26);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(249, 44);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Health Profile";
            this.labelMain.Click += new System.EventHandler(this.label1_Click);
            // 
            // fname_tb
            // 
            this.fname_tb.Location = new System.Drawing.Point(165, 127);
            this.fname_tb.Name = "fname_tb";
            this.fname_tb.Size = new System.Drawing.Size(100, 20);
            this.fname_tb.TabIndex = 1;
            // 
            // lname_tb
            // 
            this.lname_tb.Location = new System.Drawing.Point(165, 153);
            this.lname_tb.Name = "lname_tb";
            this.lname_tb.Size = new System.Drawing.Size(100, 20);
            this.lname_tb.TabIndex = 2;
            // 
            // m_tb
            // 
            this.m_tb.Location = new System.Drawing.Point(165, 205);
            this.m_tb.Name = "m_tb";
            this.m_tb.Size = new System.Drawing.Size(100, 20);
            this.m_tb.TabIndex = 4;
            // 
            // g_tb
            // 
            this.g_tb.Location = new System.Drawing.Point(165, 179);
            this.g_tb.Name = "g_tb";
            this.g_tb.Size = new System.Drawing.Size(100, 20);
            this.g_tb.TabIndex = 3;
            // 
            // w_tb
            // 
            this.w_tb.Location = new System.Drawing.Point(165, 308);
            this.w_tb.Name = "w_tb";
            this.w_tb.Size = new System.Drawing.Size(100, 20);
            this.w_tb.TabIndex = 8;
            // 
            // h_tb
            // 
            this.h_tb.Location = new System.Drawing.Point(165, 282);
            this.h_tb.Name = "h_tb";
            this.h_tb.Size = new System.Drawing.Size(100, 20);
            this.h_tb.TabIndex = 7;
            // 
            // y_tb
            // 
            this.y_tb.Location = new System.Drawing.Point(165, 256);
            this.y_tb.Name = "y_tb";
            this.y_tb.Size = new System.Drawing.Size(100, 20);
            this.y_tb.TabIndex = 6;
            // 
            // d_tb
            // 
            this.d_tb.Location = new System.Drawing.Point(165, 230);
            this.d_tb.Name = "d_tb";
            this.d_tb.Size = new System.Drawing.Size(100, 20);
            this.d_tb.TabIndex = 5;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(76, 132);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(57, 13);
            this.firstName.TabIndex = 9;
            this.firstName.Text = "First Name";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(76, 156);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(58, 13);
            this.lastName.TabIndex = 10;
            this.lastName.Text = "Last Name";
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Location = new System.Drawing.Point(76, 206);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(69, 13);
            this.month.TabIndex = 12;
            this.month.Text = "DOB - Month";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(76, 182);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(42, 13);
            this.gender.TabIndex = 11;
            this.gender.Text = "Gender";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(76, 307);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(41, 13);
            this.weight.TabIndex = 16;
            this.weight.Text = "Weight";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(76, 283);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(38, 13);
            this.height.TabIndex = 15;
            this.height.Text = "Height";
            this.height.Click += new System.EventHandler(this.label6_Click);
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(76, 257);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(61, 13);
            this.year.TabIndex = 14;
            this.year.Text = "DOB - Year";
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Location = new System.Drawing.Point(76, 233);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(58, 13);
            this.day.TabIndex = 13;
            this.day.Text = "DOB - Day";
            // 
            // bmi_b
            // 
            this.bmi_b.Location = new System.Drawing.Point(428, 153);
            this.bmi_b.Name = "bmi_b";
            this.bmi_b.Size = new System.Drawing.Size(193, 44);
            this.bmi_b.TabIndex = 17;
            this.bmi_b.Text = "Calculate BMI";
            this.bmi_b.UseVisualStyleBackColor = true;
            this.bmi_b.Click += new System.EventHandler(this.bmi_b_Click);
            // 
            // bmichart_b
            // 
            this.bmichart_b.Location = new System.Drawing.Point(428, 258);
            this.bmichart_b.Name = "bmichart_b";
            this.bmichart_b.Size = new System.Drawing.Size(193, 44);
            this.bmichart_b.TabIndex = 18;
            this.bmichart_b.Text = "Show me the BMI chart!";
            this.bmichart_b.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(182, 27);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(64, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bmichart_b);
            this.Controls.Add(this.bmi_b);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.year);
            this.Controls.Add(this.day);
            this.Controls.Add(this.month);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.w_tb);
            this.Controls.Add(this.h_tb);
            this.Controls.Add(this.y_tb);
            this.Controls.Add(this.d_tb);
            this.Controls.Add(this.m_tb);
            this.Controls.Add(this.g_tb);
            this.Controls.Add(this.lname_tb);
            this.Controls.Add(this.fname_tb);
            this.Controls.Add(this.labelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.TextBox fname_tb;
        private System.Windows.Forms.TextBox lname_tb;
        private System.Windows.Forms.TextBox m_tb;
        private System.Windows.Forms.TextBox g_tb;
        private System.Windows.Forms.TextBox w_tb;
        private System.Windows.Forms.TextBox h_tb;
        private System.Windows.Forms.TextBox y_tb;
        private System.Windows.Forms.TextBox d_tb;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Button bmi_b;
        private System.Windows.Forms.Button bmichart_b;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

