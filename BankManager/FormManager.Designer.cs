namespace BankManager
{
    partial class FormManager
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
            label6 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            panel1 = new Panel();
            textBox5 = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            btnDelAcc = new Button();
            btnUpdAcc = new Button();
            btnNewAcc = new Button();
            label8 = new Label();
            comboBox1 = new ComboBox();
            textBox6 = new TextBox();
            label7 = new Label();
            listView2 = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            tabPage3 = new TabPage();
            btnClose = new Button();
            btnRefresh = new Button();
            tabPage4 = new TabPage();
            listView3 = new ListView();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader23 = new ColumnHeader();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(118, 21);
            label6.TabIndex = 5;
            label6.Text = "Manager Name";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 48);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 487);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 459);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Customers";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.AllowColumnReorder = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(6, 6);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(756, 254);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.MouseClick += listView1_MouseClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "CitizenshipID";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "First Name";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Last Name";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "E-Mail";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Phone";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Registration Date";
            columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "ManagerID";
            columnHeader8.Width = 100;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 266);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 187);
            panel1.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(90, 136);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(135, 23);
            textBox5.TabIndex = 9;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(255, 121);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Customer";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(255, 69);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(146, 38);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update Customer";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(255, 20);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(146, 38);
            btnNew.TabIndex = 2;
            btnNew.Text = "New Customer";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 139);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(41, 15);
            label5.TabIndex = 8;
            label5.Text = "Phone";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(90, 107);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(135, 23);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 110);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "E-Mail";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(90, 78);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(135, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 81);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(90, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 52);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "CitizenID";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(listView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 459);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Accounts";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDelAcc);
            panel2.Controls.Add(btnUpdAcc);
            panel2.Controls.Add(btnNewAcc);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(6, 266);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 187);
            panel2.TabIndex = 5;
            // 
            // btnDelAcc
            // 
            btnDelAcc.Location = new Point(237, 134);
            btnDelAcc.Name = "btnDelAcc";
            btnDelAcc.Size = new Size(105, 39);
            btnDelAcc.TabIndex = 4;
            btnDelAcc.Text = "Delete Account";
            btnDelAcc.UseVisualStyleBackColor = true;
            btnDelAcc.Click += btnDelAcc_Click;
            // 
            // btnUpdAcc
            // 
            btnUpdAcc.Location = new Point(126, 134);
            btnUpdAcc.Name = "btnUpdAcc";
            btnUpdAcc.Size = new Size(105, 39);
            btnUpdAcc.TabIndex = 4;
            btnUpdAcc.Text = "Update Account";
            btnUpdAcc.UseVisualStyleBackColor = true;
            btnUpdAcc.Click += btnUpdAcc_Click;
            // 
            // btnNewAcc
            // 
            btnNewAcc.Location = new Point(15, 134);
            btnNewAcc.Name = "btnNewAcc";
            btnNewAcc.Size = new Size(105, 39);
            btnNewAcc.TabIndex = 4;
            btnNewAcc.Text = "New Account";
            btnNewAcc.UseVisualStyleBackColor = true;
            btnNewAcc.Click += btnNewAcc_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 49);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 3;
            label8.Text = "Customer";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(94, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 23);
            comboBox1.TabIndex = 2;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(94, 17);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(241, 23);
            textBox6.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 20);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 0;
            label7.Text = "Account ID";
            // 
            // listView2
            // 
            listView2.AllowColumnReorder = true;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader17, columnHeader18, columnHeader19, columnHeader10, columnHeader11, columnHeader12 });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(6, 6);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(756, 254);
            listView2.TabIndex = 4;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.MouseClick += listView2_MouseClick;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "ID";
            columnHeader9.Width = 100;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "CustomerID";
            columnHeader17.Width = 100;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Balance";
            columnHeader18.Width = 100;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Registration Date";
            columnHeader19.Width = 130;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "First Name";
            columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Last Name";
            columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "CitizenID";
            columnHeader12.Width = 100;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 459);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(694, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(87, 33);
            btnClose.TabIndex = 7;
            btnClose.Text = "Sign Out";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(602, 9);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(86, 33);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(listView3);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(768, 459);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Transactions";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            listView3.AllowColumnReorder = true;
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader14, columnHeader15, columnHeader23, columnHeader16 });
            listView3.FullRowSelect = true;
            listView3.GridLines = true;
            listView3.Location = new Point(6, 6);
            listView3.MultiSelect = false;
            listView3.Name = "listView3";
            listView3.Size = new Size(756, 447);
            listView3.TabIndex = 5;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "ID";
            columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "SenderID";
            columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "ReceiverID";
            columnHeader15.Width = 100;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Date";
            columnHeader16.Width = 130;
            // 
            // columnHeader23
            // 
            columnHeader23.Text = "Price";
            columnHeader23.Width = 100;
            // 
            // FormManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 547);
            Controls.Add(btnRefresh);
            Controls.Add(btnClose);
            Controls.Add(tabControl1);
            Controls.Add(label6);
            Name = "FormManager";
            Text = "FormManager";
            Load += FormManager_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnClose;
        private Panel panel1;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button btnRefresh;
        private Button btnNew;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Button btnDelete;
        private Button btnUpdate;
        private ListView listView2;
        private ColumnHeader columnHeader9;
        private Panel panel2;
        private Label label8;
        private ComboBox comboBox1;
        private TextBox textBox6;
        private Label label7;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private Button btnNewAcc;
        private Button btnDelAcc;
        private Button btnUpdAcc;
        private ColumnHeader columnHeader12;
        private TabPage tabPage4;
        private ListView listView3;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader23;
    }
}