﻿namespace myContact
{
    partial class Login
    {

        private System.ComponentModel.IContainer components = null;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label4 = new Label();
            passwordTb = new TextBox();
            label3 = new Label();
            userTb = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(285, 244);
            label4.Margin = new Padding(0, 10, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 16);
            label4.TabIndex = 12;
            label4.Text = "Password";
            // 
            // passwordTb
            // 
            passwordTb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTb.Location = new Point(285, 263);
            passwordTb.Margin = new Padding(0, 10, 0, 0);
            passwordTb.Name = "passwordTb";
            passwordTb.Size = new Size(247, 26);
            passwordTb.TabIndex = 11;
            passwordTb.UseSystemPasswordChar = true;
            passwordTb.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(285, 182);
            label3.Margin = new Padding(0, 10, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 16);
            label3.TabIndex = 10;
            label3.Text = "User";
            // 
            // userTb
            // 
            userTb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userTb.Location = new Point(285, 201);
            userTb.Margin = new Padding(0, 10, 0, 0);
            userTb.Name = "userTb";
            userTb.Size = new Size(247, 26);
            userTb.TabIndex = 9;
            userTb.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(673, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(127, 450);
            panel2.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(342, 315);
            button1.Name = "button1";
            button1.Size = new Size(131, 45);
            button1.TabIndex = 15;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(354, 140);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 16;
            label1.Text = "User Login";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(195, 219);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(127, 450);
            panel1.TabIndex = 18;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(passwordTb);
            Controls.Add(label3);
            Controls.Add(userTb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox passwordTb;
        private Label label3;
        private TextBox userTb;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}