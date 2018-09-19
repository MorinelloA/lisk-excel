namespace LiskExcel
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
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransactions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataFieldSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.grpTransactions = new System.Windows.Forms.GroupBox();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdMax = new System.Windows.Forms.Button();
            this.cmdZero = new System.Windows.Forms.Button();
            this.txtBothAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRecipientAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSenderAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdNow = new System.Windows.Forms.Button();
            this.cmdEpoch = new System.Windows.Forms.Button();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchString = new System.Windows.Forms.TextBox();
            this.radContain = new System.Windows.Forms.RadioButton();
            this.radExact = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.grpDataFieldSearch = new System.Windows.Forms.GroupBox();
            this.radNo2 = new System.Windows.Forms.RadioButton();
            this.radYes2 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSenderAddress2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtReceiverAddress2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            this.grpDataFieldSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSubmit.Location = new System.Drawing.Point(25, 300);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(431, 75);
            this.cmdSubmit.TabIndex = 15;
            this.cmdSubmit.Text = "Submit";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.cmdSubmit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTransactions,
            this.mnuDataFieldSearch,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 28);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout,
            this.mnuHelp,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.fileToolStripMenuItem.Text = "About";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(216, 26);
            this.mnuAbout.Text = "Contact";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(216, 26);
            this.mnuHelp.Text = "Help";
            this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(216, 26);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuTransactions
            // 
            this.mnuTransactions.Name = "mnuTransactions";
            this.mnuTransactions.Size = new System.Drawing.Size(102, 24);
            this.mnuTransactions.Text = "Transactions";
            this.mnuTransactions.Click += new System.EventHandler(this.mnuTransactions_Click);
            // 
            // mnuDataFieldSearch
            // 
            this.mnuDataFieldSearch.Name = "mnuDataFieldSearch";
            this.mnuDataFieldSearch.Size = new System.Drawing.Size(137, 24);
            this.mnuDataFieldSearch.Text = "Data Field Search";
            this.mnuDataFieldSearch.Click += new System.EventHandler(this.mnuDataFieldSearch_Click);
            // 
            // grpTransactions
            // 
            this.grpTransactions.Controls.Add(this.radNo);
            this.grpTransactions.Controls.Add(this.radYes);
            this.grpTransactions.Controls.Add(this.label5);
            this.grpTransactions.Controls.Add(this.cmdMax);
            this.grpTransactions.Controls.Add(this.cmdZero);
            this.grpTransactions.Controls.Add(this.txtBothAddress);
            this.grpTransactions.Controls.Add(this.label9);
            this.grpTransactions.Controls.Add(this.txtRecipientAddress);
            this.grpTransactions.Controls.Add(this.label8);
            this.grpTransactions.Controls.Add(this.txtSenderAddress);
            this.grpTransactions.Controls.Add(this.label1);
            this.grpTransactions.Controls.Add(this.cmdNow);
            this.grpTransactions.Controls.Add(this.cmdEpoch);
            this.grpTransactions.Controls.Add(this.nudMax);
            this.grpTransactions.Controls.Add(this.nudMin);
            this.grpTransactions.Controls.Add(this.label7);
            this.grpTransactions.Controls.Add(this.label6);
            this.grpTransactions.Controls.Add(this.cboType);
            this.grpTransactions.Controls.Add(this.label4);
            this.grpTransactions.Controls.Add(this.dtpEnd);
            this.grpTransactions.Controls.Add(this.dtpStart);
            this.grpTransactions.Controls.Add(this.label3);
            this.grpTransactions.Controls.Add(this.label2);
            this.grpTransactions.Location = new System.Drawing.Point(25, 42);
            this.grpTransactions.Name = "grpTransactions";
            this.grpTransactions.Size = new System.Drawing.Size(431, 252);
            this.grpTransactions.TabIndex = 39;
            this.grpTransactions.TabStop = false;
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Location = new System.Drawing.Point(281, 222);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(47, 21);
            this.radNo.TabIndex = 54;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Checked = true;
            this.radYes.Location = new System.Drawing.Point(206, 222);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(53, 21);
            this.radYes.TabIndex = 52;
            this.radYes.TabStop = true;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            this.radYes.CheckedChanged += new System.EventHandler(this.radYes_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Add Links to Explorer?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmdMax
            // 
            this.cmdMax.Location = new System.Drawing.Point(106, 197);
            this.cmdMax.Name = "cmdMax";
            this.cmdMax.Size = new System.Drawing.Size(75, 23);
            this.cmdMax.TabIndex = 49;
            this.cmdMax.Text = "Max";
            this.cmdMax.UseVisualStyleBackColor = true;
            // 
            // cmdZero
            // 
            this.cmdZero.Location = new System.Drawing.Point(106, 172);
            this.cmdZero.Name = "cmdZero";
            this.cmdZero.Size = new System.Drawing.Size(75, 23);
            this.cmdZero.TabIndex = 46;
            this.cmdZero.Text = "Zero";
            this.cmdZero.UseVisualStyleBackColor = true;
            // 
            // txtBothAddress
            // 
            this.txtBothAddress.Location = new System.Drawing.Point(206, 72);
            this.txtBothAddress.Name = "txtBothAddress";
            this.txtBothAddress.Size = new System.Drawing.Size(209, 22);
            this.txtBothAddress.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 17);
            this.label9.TabIndex = 57;
            this.label9.Text = "Sender Or Recipient Address";
            // 
            // txtRecipientAddress
            // 
            this.txtRecipientAddress.Location = new System.Drawing.Point(206, 47);
            this.txtRecipientAddress.Name = "txtRecipientAddress";
            this.txtRecipientAddress.Size = new System.Drawing.Size(209, 22);
            this.txtRecipientAddress.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 56;
            this.label8.Text = "Recipient Address";
            // 
            // txtSenderAddress
            // 
            this.txtSenderAddress.Location = new System.Drawing.Point(206, 22);
            this.txtSenderAddress.Name = "txtSenderAddress";
            this.txtSenderAddress.Size = new System.Drawing.Size(209, 22);
            this.txtSenderAddress.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Sender Address";
            // 
            // cmdNow
            // 
            this.cmdNow.Location = new System.Drawing.Point(106, 122);
            this.cmdNow.Name = "cmdNow";
            this.cmdNow.Size = new System.Drawing.Size(75, 23);
            this.cmdNow.TabIndex = 43;
            this.cmdNow.Text = "Now";
            this.cmdNow.UseVisualStyleBackColor = true;
            // 
            // cmdEpoch
            // 
            this.cmdEpoch.Location = new System.Drawing.Point(106, 97);
            this.cmdEpoch.Name = "cmdEpoch";
            this.cmdEpoch.Size = new System.Drawing.Size(75, 23);
            this.cmdEpoch.TabIndex = 41;
            this.cmdEpoch.Text = "Epoch";
            this.cmdEpoch.UseVisualStyleBackColor = true;
            // 
            // nudMax
            // 
            this.nudMax.DecimalPlaces = 8;
            this.nudMax.Location = new System.Drawing.Point(206, 197);
            this.nudMax.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(209, 22);
            this.nudMax.TabIndex = 50;
            // 
            // nudMin
            // 
            this.nudMin.DecimalPlaces = 8;
            this.nudMin.Location = new System.Drawing.Point(206, 172);
            this.nudMin.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(209, 22);
            this.nudMin.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Max Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Min Amount";
            // 
            // cboType
            // 
            this.cboType.DisplayMember = "1";
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "All",
            "Transfer (Type 0)",
            "Vote (Type 3)"});
            this.cboType.Location = new System.Drawing.Point(206, 147);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(209, 24);
            this.cboType.TabIndex = 45;
            this.cboType.ValueMember = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Trans Type";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(206, 122);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(209, 22);
            this.dtpEnd.TabIndex = 44;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(206, 97);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(209, 22);
            this.dtpStart.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "End Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Start Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "Search String";
            // 
            // txtSearchString
            // 
            this.txtSearchString.Location = new System.Drawing.Point(165, 33);
            this.txtSearchString.Name = "txtSearchString";
            this.txtSearchString.Size = new System.Drawing.Size(209, 22);
            this.txtSearchString.TabIndex = 30;
            // 
            // radContain
            // 
            this.radContain.AutoSize = true;
            this.radContain.Location = new System.Drawing.Point(262, 124);
            this.radContain.Name = "radContain";
            this.radContain.Size = new System.Drawing.Size(77, 21);
            this.radContain.TabIndex = 34;
            this.radContain.Text = "Contain";
            this.radContain.UseVisualStyleBackColor = true;
            // 
            // radExact
            // 
            this.radExact.AutoSize = true;
            this.radExact.Checked = true;
            this.radExact.Location = new System.Drawing.Point(187, 124);
            this.radExact.Name = "radExact";
            this.radExact.Size = new System.Drawing.Size(63, 21);
            this.radExact.TabIndex = 33;
            this.radExact.TabStop = true;
            this.radExact.Text = "Exact";
            this.radExact.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 17);
            this.label11.TabIndex = 61;
            this.label11.Text = "Exact or Contain?";
            // 
            // grpDataFieldSearch
            // 
            this.grpDataFieldSearch.Controls.Add(this.txtReceiverAddress2);
            this.grpDataFieldSearch.Controls.Add(this.label14);
            this.grpDataFieldSearch.Controls.Add(this.txtSenderAddress2);
            this.grpDataFieldSearch.Controls.Add(this.label13);
            this.grpDataFieldSearch.Controls.Add(this.panel1);
            this.grpDataFieldSearch.Controls.Add(this.label12);
            this.grpDataFieldSearch.Controls.Add(this.txtSearchString);
            this.grpDataFieldSearch.Controls.Add(this.radContain);
            this.grpDataFieldSearch.Controls.Add(this.label10);
            this.grpDataFieldSearch.Controls.Add(this.radExact);
            this.grpDataFieldSearch.Controls.Add(this.label11);
            this.grpDataFieldSearch.Location = new System.Drawing.Point(25, 42);
            this.grpDataFieldSearch.Name = "grpDataFieldSearch";
            this.grpDataFieldSearch.Size = new System.Drawing.Size(431, 252);
            this.grpDataFieldSearch.TabIndex = 62;
            this.grpDataFieldSearch.TabStop = false;
            this.grpDataFieldSearch.Visible = false;
            // 
            // radNo2
            // 
            this.radNo2.AutoSize = true;
            this.radNo2.Location = new System.Drawing.Point(97, 3);
            this.radNo2.Name = "radNo2";
            this.radNo2.Size = new System.Drawing.Size(47, 21);
            this.radNo2.TabIndex = 36;
            this.radNo2.Text = "No";
            this.radNo2.UseVisualStyleBackColor = true;
            // 
            // radYes2
            // 
            this.radYes2.AutoSize = true;
            this.radYes2.Checked = true;
            this.radYes2.Location = new System.Drawing.Point(22, 3);
            this.radYes2.Name = "radYes2";
            this.radYes2.Size = new System.Drawing.Size(53, 21);
            this.radYes2.TabIndex = 35;
            this.radYes2.TabStop = true;
            this.radYes2.Text = "Yes";
            this.radYes2.UseVisualStyleBackColor = true;
            this.radYes2.CheckedChanged += new System.EventHandler(this.radYes2_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 17);
            this.label12.TabIndex = 64;
            this.label12.Text = "Add Links to Explorer?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radNo2);
            this.panel1.Controls.Add(this.radYes2);
            this.panel1.Location = new System.Drawing.Point(165, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 47);
            this.panel1.TabIndex = 63;
            // 
            // txtSenderAddress2
            // 
            this.txtSenderAddress2.Location = new System.Drawing.Point(165, 57);
            this.txtSenderAddress2.Name = "txtSenderAddress2";
            this.txtSenderAddress2.Size = new System.Drawing.Size(209, 22);
            this.txtSenderAddress2.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 17);
            this.label13.TabIndex = 65;
            this.label13.Text = "Sender Address";
            // 
            // txtReceiverAddress2
            // 
            this.txtReceiverAddress2.Location = new System.Drawing.Point(165, 82);
            this.txtReceiverAddress2.Name = "txtReceiverAddress2";
            this.txtReceiverAddress2.Size = new System.Drawing.Size(209, 22);
            this.txtReceiverAddress2.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 17);
            this.label14.TabIndex = 67;
            this.label14.Text = "Receiver Address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 385);
            this.Controls.Add(this.grpDataFieldSearch);
            this.Controls.Add(this.grpTransactions);
            this.Controls.Add(this.cmdSubmit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lisk Excel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpTransactions.ResumeLayout(false);
            this.grpTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            this.grpDataFieldSearch.ResumeLayout(false);
            this.grpDataFieldSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSubmit;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuTransactions;
        private System.Windows.Forms.ToolStripMenuItem mnuDataFieldSearch;
        private System.Windows.Forms.GroupBox grpTransactions;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdMax;
        private System.Windows.Forms.Button cmdZero;
        private System.Windows.Forms.TextBox txtBothAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRecipientAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSenderAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdNow;
        private System.Windows.Forms.Button cmdEpoch;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchString;
        private System.Windows.Forms.RadioButton radContain;
        private System.Windows.Forms.RadioButton radExact;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpDataFieldSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radNo2;
        private System.Windows.Forms.RadioButton radYes2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtReceiverAddress2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSenderAddress2;
        private System.Windows.Forms.Label label13;
    }
}

