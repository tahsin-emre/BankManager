namespace BankManager
{
    partial class FormCustomer
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
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            amountBox = new NumericUpDown();
            button1 = new Button();
            accountListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            tabPage2 = new TabPage();
            transactionListView = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            groupBox1 = new GroupBox();
            button3 = new Button();
            label6 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            numericUpDown2 = new NumericUpDown();
            tabPage3 = new TabPage();
            groupBox2 = new GroupBox();
            button4 = new Button();
            label11 = new Label();
            limitBox = new NumericUpDown();
            cardListView = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            accountToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            label8 = new Label();
            label12 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountBox).BeginInit();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            tabPage3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)limitBox).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(171, 30);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 57);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(842, 449);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(accountListView);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(834, 421);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Accounts";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(amountBox);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(366, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 222);
            panel1.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 45);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 7;
            label10.Text = "Balance:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 20);
            label9.Name = "label9";
            label9.Size = new Size(102, 15);
            label9.TabIndex = 7;
            label9.Text = "Selected Account:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 134);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 6;
            label7.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(116, 42);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(117, 16);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(122, 160);
            button2.Name = "button2";
            button2.Size = new Size(89, 42);
            button2.TabIndex = 2;
            button2.Text = "Withdraw";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // amountBox
            // 
            amountBox.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            amountBox.Location = new Point(79, 131);
            amountBox.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            amountBox.Name = "amountBox";
            amountBox.Size = new Size(127, 23);
            amountBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(22, 161);
            button1.Name = "button1";
            button1.Size = new Size(89, 42);
            button1.TabIndex = 1;
            button1.Text = "Deposit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // accountListView
            // 
            accountListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            accountListView.FullRowSelect = true;
            accountListView.GridLines = true;
            accountListView.Location = new Point(6, 6);
            accountListView.MultiSelect = false;
            accountListView.Name = "accountListView";
            accountListView.Size = new Size(354, 409);
            accountListView.TabIndex = 0;
            accountListView.UseCompatibleStateImageBehavior = false;
            accountListView.View = View.Details;
            accountListView.MouseClick += accountListClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "AccountID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Balance";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Registration Date";
            columnHeader3.Width = 140;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(transactionListView);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(834, 421);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Money Transaction";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // transactionListView
            // 
            transactionListView.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            transactionListView.FullRowSelect = true;
            transactionListView.GridLines = true;
            transactionListView.Location = new Point(6, 6);
            transactionListView.MultiSelect = false;
            transactionListView.Name = "transactionListView";
            transactionListView.Size = new Size(536, 409);
            transactionListView.TabIndex = 8;
            transactionListView.UseCompatibleStateImageBehavior = false;
            transactionListView.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "ID";
            columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "SenderID";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "ReceiverID";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Amount";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Process Date";
            columnHeader8.Width = 140;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Location = new Point(616, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(155, 239);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Make Transaction";
            // 
            // button3
            // 
            button3.Location = new Point(64, 210);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Send";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 140);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 6;
            label6.Text = "Amount";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 23);
            textBox1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 90);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 5;
            label5.Text = "Receiver Account";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(18, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 36);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 4;
            label4.Text = "Sender Account";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown2.Location = new Point(19, 158);
            numericUpDown2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 3;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(cardListView);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(834, 421);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Credit Cards";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(limitBox);
            groupBox2.Location = new Point(533, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(285, 137);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "New Card Application";
            // 
            // button4
            // 
            button4.Location = new Point(129, 85);
            button4.Name = "button4";
            button4.Size = new Size(120, 29);
            button4.TabIndex = 2;
            button4.Text = "Send To Manager";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 40);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 1;
            label11.Text = "Card Limit";
            // 
            // limitBox
            // 
            limitBox.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            limitBox.Location = new Point(129, 38);
            limitBox.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            limitBox.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            limitBox.Name = "limitBox";
            limitBox.Size = new Size(120, 23);
            limitBox.TabIndex = 0;
            limitBox.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // cardListView
            // 
            cardListView.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            cardListView.FullRowSelect = true;
            cardListView.GridLines = true;
            cardListView.Location = new Point(12, 12);
            cardListView.MultiSelect = false;
            cardListView.Name = "cardListView";
            cardListView.Size = new Size(502, 395);
            cardListView.TabIndex = 0;
            cardListView.UseCompatibleStateImageBehavior = false;
            cardListView.View = View.Details;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Card Number";
            columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Card Limit";
            columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Verification";
            columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Registration Date";
            columnHeader12.Width = 120;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { accountToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(866, 24);
            menuStrip1.TabIndex = 3;
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
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refreshToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(80, 20);
            helpToolStripMenuItem.Text = "Application";
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            refreshToolStripMenuItem.Size = new Size(180, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(598, 24);
            label8.Name = "label8";
            label8.Size = new Size(164, 30);
            label8.TabIndex = 0;
            label8.Text = "Manager Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(510, 34);
            label12.Name = "label12";
            label12.Size = new Size(84, 15);
            label12.TabIndex = 4;
            label12.Text = "Your Manager:";
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 518);
            Controls.Add(label12);
            Controls.Add(menuStrip1);
            Controls.Add(tabControl1);
            Controls.Add(label8);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "FormCustomer";
            Text = "FormCustomer";
            Load += FormCustomer_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amountBox).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            tabPage3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)limitBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListView accountListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Panel panel1;
        private NumericUpDown amountBox;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Button button3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private Label label4;
        private Label label6;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ListView transactionListView;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label9;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ListView cardListView;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private GroupBox groupBox2;
        private Button button4;
        private Label label11;
        private NumericUpDown limitBox;
        private Label label12;
    }
}