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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            customerListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            panel1 = new Panel();
            phoneBox = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            label5 = new Label();
            emailBox = new TextBox();
            label4 = new Label();
            lNameBox = new TextBox();
            label3 = new Label();
            fNameBox = new TextBox();
            label2 = new Label();
            cidBox = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            btnDelAcc = new Button();
            btnUpdAcc = new Button();
            btnNewAcc = new Button();
            label8 = new Label();
            comboBox1 = new ComboBox();
            aidBox = new TextBox();
            label7 = new Label();
            accountListView = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            tabPage4 = new TabPage();
            transactionListView = new ListView();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader23 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            tabPage3 = new TabPage();
            panel3 = new Panel();
            button1 = new Button();
            limitBox = new TextBox();
            cardidBox = new TextBox();
            label10 = new Label();
            label9 = new Label();
            cardListView = new ListView();
            columnHeader20 = new ColumnHeader();
            columnHeader21 = new ColumnHeader();
            columnHeader22 = new ColumnHeader();
            columnHeader27 = new ColumnHeader();
            columnHeader24 = new ColumnHeader();
            columnHeader25 = new ColumnHeader();
            columnHeader26 = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            accountToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem1 = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            dayToolStripMenuItem = new ToolStripMenuItem();
            nightToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage3.SuspendLayout();
            panel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(5, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(779, 432);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(customerListView);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(771, 404);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Customers";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // customerListView
            // 
            customerListView.AllowColumnReorder = true;
            customerListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            customerListView.FullRowSelect = true;
            customerListView.GridLines = true;
            customerListView.Location = new Point(6, 3);
            customerListView.MultiSelect = false;
            customerListView.Name = "customerListView";
            customerListView.Size = new Size(756, 218);
            customerListView.TabIndex = 3;
            customerListView.UseCompatibleStateImageBehavior = false;
            customerListView.View = View.Details;
            customerListView.MouseClick += customerListClick;
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
            panel1.Controls.Add(phoneBox);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnNew);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(emailBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lNameBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(fNameBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cidBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 227);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 174);
            panel1.TabIndex = 0;
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(90, 136);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(135, 23);
            phoneBox.TabIndex = 9;
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
            // emailBox
            // 
            emailBox.Location = new Point(90, 107);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(135, 23);
            emailBox.TabIndex = 7;
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
            // lNameBox
            // 
            lNameBox.Location = new Point(90, 78);
            lNameBox.Name = "lNameBox";
            lNameBox.Size = new Size(135, 23);
            lNameBox.TabIndex = 5;
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
            // fNameBox
            // 
            fNameBox.Location = new Point(90, 49);
            fNameBox.Name = "fNameBox";
            fNameBox.Size = new Size(135, 23);
            fNameBox.TabIndex = 3;
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
            // cidBox
            // 
            cidBox.Location = new Point(90, 20);
            cidBox.Name = "cidBox";
            cidBox.Size = new Size(135, 23);
            cidBox.TabIndex = 1;
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
            tabPage2.Controls.Add(accountListView);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(771, 404);
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
            panel2.Controls.Add(aidBox);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(6, 259);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 142);
            panel2.TabIndex = 5;
            // 
            // btnDelAcc
            // 
            btnDelAcc.Location = new Point(233, 88);
            btnDelAcc.Name = "btnDelAcc";
            btnDelAcc.Size = new Size(105, 39);
            btnDelAcc.TabIndex = 4;
            btnDelAcc.Text = "Delete Account";
            btnDelAcc.UseVisualStyleBackColor = true;
            btnDelAcc.Click += btnDelAcc_Click;
            // 
            // btnUpdAcc
            // 
            btnUpdAcc.Location = new Point(122, 88);
            btnUpdAcc.Name = "btnUpdAcc";
            btnUpdAcc.Size = new Size(105, 39);
            btnUpdAcc.TabIndex = 4;
            btnUpdAcc.Text = "Update Account";
            btnUpdAcc.UseVisualStyleBackColor = true;
            btnUpdAcc.Click += btnUpdAcc_Click;
            // 
            // btnNewAcc
            // 
            btnNewAcc.Location = new Point(11, 88);
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
            // aidBox
            // 
            aidBox.Location = new Point(94, 17);
            aidBox.Name = "aidBox";
            aidBox.Size = new Size(241, 23);
            aidBox.TabIndex = 1;
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
            // accountListView
            // 
            accountListView.AllowColumnReorder = true;
            accountListView.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader18, columnHeader19, columnHeader17, columnHeader10, columnHeader11, columnHeader12 });
            accountListView.FullRowSelect = true;
            accountListView.GridLines = true;
            accountListView.Location = new Point(6, 6);
            accountListView.MultiSelect = false;
            accountListView.Name = "accountListView";
            accountListView.Size = new Size(756, 247);
            accountListView.TabIndex = 4;
            accountListView.UseCompatibleStateImageBehavior = false;
            accountListView.View = View.Details;
            accountListView.MouseClick += accountListClick;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "ID";
            columnHeader9.Width = 100;
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
            // columnHeader17
            // 
            columnHeader17.Text = "CustomerID";
            columnHeader17.Width = 100;
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
            // tabPage4
            // 
            tabPage4.Controls.Add(transactionListView);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(771, 404);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Transactions";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // transactionListView
            // 
            transactionListView.AllowColumnReorder = true;
            transactionListView.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader14, columnHeader15, columnHeader23, columnHeader16 });
            transactionListView.FullRowSelect = true;
            transactionListView.GridLines = true;
            transactionListView.Location = new Point(6, 6);
            transactionListView.MultiSelect = false;
            transactionListView.Name = "transactionListView";
            transactionListView.Size = new Size(756, 392);
            transactionListView.TabIndex = 5;
            transactionListView.UseCompatibleStateImageBehavior = false;
            transactionListView.View = View.Details;
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
            // columnHeader23
            // 
            columnHeader23.Text = "Price";
            columnHeader23.Width = 100;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Date";
            columnHeader16.Width = 130;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel3);
            tabPage3.Controls.Add(cardListView);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(771, 404);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Credit Cards";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(limitBox);
            panel3.Controls.Add(cardidBox);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(6, 285);
            panel3.Name = "panel3";
            panel3.Size = new Size(299, 113);
            panel3.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(208, 76);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Verify";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCardUpdate;
            // 
            // limitBox
            // 
            limitBox.Location = new Point(107, 47);
            limitBox.Name = "limitBox";
            limitBox.Size = new Size(176, 23);
            limitBox.TabIndex = 3;
            // 
            // cardidBox
            // 
            cardidBox.Location = new Point(107, 18);
            cardidBox.Name = "cardidBox";
            cardidBox.ReadOnly = true;
            cardidBox.Size = new Size(176, 23);
            cardidBox.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 50);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 1;
            label10.Text = "Limit";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 21);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 0;
            label9.Text = "Card Number";
            // 
            // cardListView
            // 
            cardListView.Columns.AddRange(new ColumnHeader[] { columnHeader20, columnHeader21, columnHeader22, columnHeader27, columnHeader24, columnHeader25, columnHeader26 });
            cardListView.FullRowSelect = true;
            cardListView.GridLines = true;
            cardListView.Location = new Point(6, 6);
            cardListView.Name = "cardListView";
            cardListView.Size = new Size(756, 273);
            cardListView.TabIndex = 0;
            cardListView.UseCompatibleStateImageBehavior = false;
            cardListView.View = View.Details;
            cardListView.MouseClick += cardListClick;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "Card Number";
            columnHeader20.Width = 150;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Limit";
            columnHeader21.Width = 100;
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Verification";
            columnHeader22.Width = 100;
            // 
            // columnHeader27
            // 
            columnHeader27.Text = "Registration Date";
            columnHeader27.Width = 100;
            // 
            // columnHeader24
            // 
            columnHeader24.Text = "First Name";
            columnHeader24.Width = 100;
            // 
            // columnHeader25
            // 
            columnHeader25.Text = "Last Name";
            columnHeader25.Width = 100;
            // 
            // columnHeader26
            // 
            columnHeader26.Text = "Citizen ID";
            columnHeader26.Width = 100;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { accountToolStripMenuItem, refreshToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changePasswordToolStripMenuItem, signOutToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(42, 20);
            accountToolStripMenuItem.Text = "User";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            changePasswordToolStripMenuItem.Size = new Size(209, 22);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            signOutToolStripMenuItem.Size = new Size(209, 22);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refreshToolStripMenuItem1, themeToolStripMenuItem });
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(80, 20);
            refreshToolStripMenuItem.Text = "Application";
            // 
            // refreshToolStripMenuItem1
            // 
            refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            refreshToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.R;
            refreshToolStripMenuItem1.Size = new Size(180, 22);
            refreshToolStripMenuItem1.Text = "Refresh";
            refreshToolStripMenuItem1.Click += refreshToolStripMenuItem1_Click;
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dayToolStripMenuItem, nightToolStripMenuItem });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(180, 22);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // dayToolStripMenuItem
            // 
            dayToolStripMenuItem.Name = "dayToolStripMenuItem";
            dayToolStripMenuItem.Size = new Size(104, 22);
            dayToolStripMenuItem.Text = "Day";
            dayToolStripMenuItem.Click += dayToolStripMenuItem_Click;
            // 
            // nightToolStripMenuItem
            // 
            nightToolStripMenuItem.Name = "nightToolStripMenuItem";
            nightToolStripMenuItem.Size = new Size(104, 22);
            nightToolStripMenuItem.Text = "Night";
            nightToolStripMenuItem.Click += nightToolStripMenuItem_Click;
            // 
            // FormManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
            tabPage3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnClose;
        private Panel panel1;
        private TextBox phoneBox;
        private Label label5;
        private TextBox emailBox;
        private Label label4;
        private TextBox lNameBox;
        private Label label3;
        private TextBox fNameBox;
        private Label label2;
        private TextBox cidBox;
        private Label label1;
        private Button btnRefresh;
        private Button btnNew;
        private ListView customerListView;
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
        private ListView accountListView;
        private ColumnHeader columnHeader9;
        private Panel panel2;
        private Label label8;
        private ComboBox comboBox1;
        private TextBox aidBox;
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
        private ListView transactionListView;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader23;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ListView cardListView;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader24;
        private ColumnHeader columnHeader27;
        private ColumnHeader columnHeader25;
        private ColumnHeader columnHeader26;
        private Panel panel3;
        private TextBox cardidBox;
        private Label label10;
        private Label label9;
        private Button button1;
        private TextBox limitBox;
        private ToolStripMenuItem refreshToolStripMenuItem1;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem dayToolStripMenuItem;
        private ToolStripMenuItem nightToolStripMenuItem;
    }
}