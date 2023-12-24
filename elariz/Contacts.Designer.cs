namespace myContact
{
    partial class Contacts
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contacts));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ContactName = new TextBox();
            label4 = new Label();
            ContactSurname = new TextBox();
            label5 = new Label();
            ContactPhoneNumber = new TextBox();
            label6 = new Label();
            ContactEmail = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            AddBtn = new Button();
            ContactList = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            DeleteBtn = new Button();
            tb_search = new TextBox();
            search_button = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ContactList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)search_button).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-50, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 75);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(524, 25);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Contact";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(424, 87);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(47, 190);
            label3.Margin = new Padding(0, 10, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 16);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // ContactName
            // 
            ContactName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContactName.Location = new Point(47, 209);
            ContactName.Margin = new Padding(0, 10, 0, 0);
            ContactName.Name = "ContactName";
            ContactName.Size = new Size(167, 26);
            ContactName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(230, 190);
            label4.Margin = new Padding(0, 10, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 16);
            label4.TabIndex = 8;
            label4.Text = "Surname";
            // 
            // ContactSurname
            // 
            ContactSurname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContactSurname.Location = new Point(230, 209);
            ContactSurname.Margin = new Padding(0, 10, 0, 0);
            ContactSurname.Name = "ContactSurname";
            ContactSurname.Size = new Size(156, 26);
            ContactSurname.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(406, 190);
            label5.Margin = new Padding(0, 10, 0, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 16);
            label5.TabIndex = 10;
            label5.Text = "Phone Number";
            // 
            // ContactPhoneNumber
            // 
            ContactPhoneNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContactPhoneNumber.Location = new Point(406, 209);
            ContactPhoneNumber.Margin = new Padding(0, 10, 0, 0);
            ContactPhoneNumber.Name = "ContactPhoneNumber";
            ContactPhoneNumber.Size = new Size(183, 26);
            ContactPhoneNumber.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(607, 190);
            label6.Margin = new Padding(0, 10, 0, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 16);
            label6.TabIndex = 12;
            label6.Text = "Email";
            // 
            // ContactEmail
            // 
            ContactEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContactEmail.Location = new Point(605, 209);
            ContactEmail.Margin = new Padding(0, 10, 0, 0);
            ContactEmail.Name = "ContactEmail";
            ContactEmail.Size = new Size(198, 26);
            ContactEmail.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 576);
            panel2.Name = "panel2";
            panel2.Size = new Size(1029, 24);
            panel2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.DimGray;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(817, 205);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(101, 37);
            AddBtn.TabIndex = 16;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // ContactList
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            ContactList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            ContactList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            ContactList.ColumnHeadersHeight = 4;
            ContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            ContactList.DefaultCellStyle = dataGridViewCellStyle6;
            ContactList.GridColor = Color.FromArgb(231, 229, 255);
            ContactList.Location = new Point(47, 347);
            ContactList.Name = "ContactList";
            ContactList.RowHeadersVisible = false;
            ContactList.RowTemplate.Height = 25;
            ContactList.Size = new Size(970, 223);
            ContactList.TabIndex = 18;
            ContactList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ContactList.ThemeStyle.AlternatingRowsStyle.Font = null;
            ContactList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ContactList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ContactList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ContactList.ThemeStyle.BackColor = Color.White;
            ContactList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ContactList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ContactList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ContactList.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContactList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ContactList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ContactList.ThemeStyle.HeaderStyle.Height = 4;
            ContactList.ThemeStyle.ReadOnly = false;
            ContactList.ThemeStyle.RowsStyle.BackColor = Color.White;
            ContactList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ContactList.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContactList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ContactList.ThemeStyle.RowsStyle.Height = 25;
            ContactList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ContactList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ContactList.CellContentClick += ContactList_CellContentClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(911, 87);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(956, 97);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 20;
            label7.Text = "Logout";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(47, 288);
            label8.Margin = new Padding(0, 10, 0, 0);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 21;
            label8.Text = "Contact List";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.DimGray;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(922, 205);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(92, 37);
            DeleteBtn.TabIndex = 22;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // tb_search
            // 
            tb_search.Location = new Point(789, 282);
            tb_search.Name = "tb_search";
            tb_search.Size = new Size(215, 26);
            tb_search.TabIndex = 23;
            tb_search.TextChanged += tb_search_TextChanged;
            // 
            // search_button
            // 
            search_button.Image = (Image)resources.GetObject("search_button.Image");
            search_button.Location = new Point(745, 282);
            search_button.Name = "search_button";
            search_button.Size = new Size(26, 26);
            search_button.SizeMode = PictureBoxSizeMode.StretchImage;
            search_button.TabIndex = 24;
            search_button.TabStop = false;
            search_button.Click += search_button_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(49, 318);
            label9.Margin = new Padding(0, 10, 0, 0);
            label9.Name = "label9";
            label9.Size = new Size(48, 16);
            label9.TabIndex = 25;
            label9.Text = "Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(293, 318);
            label10.Margin = new Padding(0, 10, 0, 0);
            label10.Name = "label10";
            label10.Size = new Size(68, 16);
            label10.TabIndex = 26;
            label10.Text = "Surname";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(511, 318);
            label11.Margin = new Padding(0, 10, 0, 0);
            label11.Name = "label11";
            label11.Size = new Size(109, 16);
            label11.TabIndex = 27;
            label11.Text = "Phone Number";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(776, 318);
            label12.Margin = new Padding(0, 10, 0, 0);
            label12.Name = "label12";
            label12.Size = new Size(46, 16);
            label12.TabIndex = 28;
            label12.Text = "Email";
            // 
            // Contacts
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 600);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(search_button);
            Controls.Add(tb_search);
            Controls.Add(DeleteBtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(ContactList);
            Controls.Add(AddBtn);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(ContactEmail);
            Controls.Add(label5);
            Controls.Add(ContactPhoneNumber);
            Controls.Add(label4);
            Controls.Add(ContactSurname);
            Controls.Add(label3);
            Controls.Add(ContactName);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Contacts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contacts";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ContactList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)search_button).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox ContactName;
        private Label label4;
        private TextBox ContactSurname;
        private Label label5;
        private TextBox ContactPhoneNumber;
        private Label label6;
        private TextBox ContactEmail;
        private Panel panel2;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button AddBtn;
        private Guna.UI2.WinForms.Guna2DataGridView ContactList;
        private PictureBox pictureBox2;
        private Label label7;
        private Label label8;
        private Button DeleteBtn;
        private TextBox textBox1;
        private PictureBox pictureBox3;
        private TextBox tb_search;
        private PictureBox search_button;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}