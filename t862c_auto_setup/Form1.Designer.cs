namespace Layout1
{
    partial class frmMain
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbLot = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cbCurrentFlow = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnCloseLog = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEndLot = new System.Windows.Forms.Button();
            this.btnLoadProd = new System.Windows.Forms.Button();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbHandlerID = new System.Windows.Forms.TextBox();
            this.tbHandler = new System.Windows.Forms.Label();
            this.tbTesterID = new System.Windows.Forms.TextBox();
            this.tbTester = new System.Windows.Forms.Label();
            this.tbHifix = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbCLotID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbTamperature = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbPgmPath = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbPgmName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbRecipeName = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbTestFlow = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbOperatorID = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tbLotID = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnStopTest = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tbLot,
            this.toolStripSeparator1,
            this.cbCurrentFlow,
            this.toolStripSeparator5,
            this.tsBtnStart,
            this.toolStripSeparator2,
            this.tsBtnCloseLog,
            this.toolStripSeparator4,
            this.toolStripButtonExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(860, 55);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(159, 52);
            this.toolStripLabel1.Text = "Select Lot Information -->";
            // 
            // tbLot
            // 
            this.tbLot.Name = "tbLot";
            this.tbLot.Size = new System.Drawing.Size(150, 55);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // cbCurrentFlow
            // 
            this.cbCurrentFlow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrentFlow.Items.AddRange(new object[] {
            "FT",
            "RT"});
            this.cbCurrentFlow.Name = "cbCurrentFlow";
            this.cbCurrentFlow.Size = new System.Drawing.Size(100, 55);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 55);
            // 
            // tsBtnStart
            // 
            this.tsBtnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnStart.Image = global::Layout1.Properties.Resources.disconnected_48;
            this.tsBtnStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnStart.Name = "tsBtnStart";
            this.tsBtnStart.Size = new System.Drawing.Size(52, 52);
            this.tsBtnStart.Text = "Start";
            this.tsBtnStart.ToolTipText = "Start Lot";
            this.tsBtnStart.Click += new System.EventHandler(this.tsBtnStart_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // tsBtnCloseLog
            // 
            this.tsBtnCloseLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCloseLog.Image = global::Layout1.Properties.Resources.Clear48;
            this.tsBtnCloseLog.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnCloseLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCloseLog.Name = "tsBtnCloseLog";
            this.tsBtnCloseLog.Size = new System.Drawing.Size(52, 52);
            this.tsBtnCloseLog.Text = "Close Log";
            this.tsBtnCloseLog.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = global::Layout1.Properties.Resources.exit48;
            this.toolStripButtonExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(52, 52);
            this.toolStripButtonExit.Text = "Exit";
            this.toolStripButtonExit.ToolTipText = "Exit";
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 626);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(860, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtInfo.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.txtInfo.ForeColor = System.Drawing.Color.LawnGreen;
            this.txtInfo.Location = new System.Drawing.Point(0, 405);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(2);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(860, 221);
            this.txtInfo.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnStopTest);
            this.tabPage1.Controls.Add(this.btnEndLot);
            this.tabPage1.Controls.Add(this.btnLoadProd);
            this.tabPage1.Controls.Add(this.btnStartTest);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(852, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Base Information";
            // 
            // btnEndLot
            // 
            this.btnEndLot.Location = new System.Drawing.Point(726, 205);
            this.btnEndLot.Margin = new System.Windows.Forms.Padding(2);
            this.btnEndLot.Name = "btnEndLot";
            this.btnEndLot.Size = new System.Drawing.Size(107, 31);
            this.btnEndLot.TabIndex = 20;
            this.btnEndLot.Text = "End Lot";
            this.btnEndLot.UseVisualStyleBackColor = true;
            this.btnEndLot.Click += new System.EventHandler(this.btnEndLot_Click);
            // 
            // btnLoadProd
            // 
            this.btnLoadProd.Location = new System.Drawing.Point(726, 26);
            this.btnLoadProd.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadProd.Name = "btnLoadProd";
            this.btnLoadProd.Size = new System.Drawing.Size(107, 31);
            this.btnLoadProd.TabIndex = 19;
            this.btnLoadProd.Text = "Load Prod";
            this.btnLoadProd.UseVisualStyleBackColor = true;
            this.btnLoadProd.Click += new System.EventHandler(this.btnLoadProd_Click);
            // 
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(726, 86);
            this.btnStartTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(107, 31);
            this.btnStartTest.TabIndex = 18;
            this.btnStartTest.Text = "Start Test";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.tbHandlerID);
            this.groupBox2.Controls.Add(this.tbHandler);
            this.groupBox2.Controls.Add(this.tbTesterID);
            this.groupBox2.Controls.Add(this.tbTester);
            this.groupBox2.Controls.Add(this.tbHifix);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.tbCLotID);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.tbTamperature);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.tbPgmPath);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.tbPgmName);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.tbRecipeName);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.tbTestFlow);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.tbOperatorID);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.tbProduct);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.tbLotID);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.tbCustomer);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(7, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(704, 309);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // tbHandlerID
            // 
            this.tbHandlerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbHandlerID.Location = new System.Drawing.Point(473, 144);
            this.tbHandlerID.Name = "tbHandlerID";
            this.tbHandlerID.ReadOnly = true;
            this.tbHandlerID.Size = new System.Drawing.Size(215, 23);
            this.tbHandlerID.TabIndex = 88;
            // 
            // tbHandler
            // 
            this.tbHandler.AutoSize = true;
            this.tbHandler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.tbHandler.Location = new System.Drawing.Point(364, 147);
            this.tbHandler.Name = "tbHandler";
            this.tbHandler.Size = new System.Drawing.Size(76, 15);
            this.tbHandler.TabIndex = 87;
            this.tbHandler.Text = "Handler ID";
            // 
            // tbTesterID
            // 
            this.tbTesterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbTesterID.Location = new System.Drawing.Point(473, 112);
            this.tbTesterID.Name = "tbTesterID";
            this.tbTesterID.ReadOnly = true;
            this.tbTesterID.Size = new System.Drawing.Size(215, 23);
            this.tbTesterID.TabIndex = 86;
            // 
            // tbTester
            // 
            this.tbTester.AutoSize = true;
            this.tbTester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.tbTester.Location = new System.Drawing.Point(364, 115);
            this.tbTester.Name = "tbTester";
            this.tbTester.Size = new System.Drawing.Size(65, 15);
            this.tbTester.TabIndex = 85;
            this.tbTester.Text = "Tester ID";
            // 
            // tbHifix
            // 
            this.tbHifix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbHifix.Location = new System.Drawing.Point(473, 80);
            this.tbHifix.Name = "tbHifix";
            this.tbHifix.ReadOnly = true;
            this.tbHifix.Size = new System.Drawing.Size(215, 23);
            this.tbHifix.TabIndex = 84;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(364, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 15);
            this.label18.TabIndex = 83;
            this.label18.Text = "HIFIX ID";
            // 
            // tbCLotID
            // 
            this.tbCLotID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbCLotID.Location = new System.Drawing.Point(473, 48);
            this.tbCLotID.Name = "tbCLotID";
            this.tbCLotID.ReadOnly = true;
            this.tbCLotID.Size = new System.Drawing.Size(215, 23);
            this.tbCLotID.TabIndex = 82;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(364, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 15);
            this.label19.TabIndex = 81;
            this.label19.Text = "CLot ID";
            // 
            // tbTamperature
            // 
            this.tbTamperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbTamperature.Location = new System.Drawing.Point(473, 16);
            this.tbTamperature.Name = "tbTamperature";
            this.tbTamperature.ReadOnly = true;
            this.tbTamperature.Size = new System.Drawing.Size(215, 23);
            this.tbTamperature.TabIndex = 80;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(364, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 15);
            this.label20.TabIndex = 79;
            this.label20.Text = "Tamperature";
            // 
            // tbPgmPath
            // 
            this.tbPgmPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbPgmPath.Location = new System.Drawing.Point(114, 240);
            this.tbPgmPath.Multiline = true;
            this.tbPgmPath.Name = "tbPgmPath";
            this.tbPgmPath.ReadOnly = true;
            this.tbPgmPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPgmPath.Size = new System.Drawing.Size(574, 55);
            this.tbPgmPath.TabIndex = 78;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(5, 243);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 15);
            this.label21.TabIndex = 77;
            this.label21.Text = "Program Path";
            // 
            // tbPgmName
            // 
            this.tbPgmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbPgmName.Location = new System.Drawing.Point(114, 208);
            this.tbPgmName.Name = "tbPgmName";
            this.tbPgmName.ReadOnly = true;
            this.tbPgmName.Size = new System.Drawing.Size(574, 23);
            this.tbPgmName.TabIndex = 76;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(5, 211);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(104, 15);
            this.label22.TabIndex = 75;
            this.label22.Text = "Program Name";
            // 
            // tbRecipeName
            // 
            this.tbRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbRecipeName.Location = new System.Drawing.Point(114, 176);
            this.tbRecipeName.Name = "tbRecipeName";
            this.tbRecipeName.ReadOnly = true;
            this.tbRecipeName.Size = new System.Drawing.Size(574, 23);
            this.tbRecipeName.TabIndex = 74;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(5, 179);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(94, 15);
            this.label23.TabIndex = 73;
            this.label23.Text = "Recipe Name";
            // 
            // tbTestFlow
            // 
            this.tbTestFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbTestFlow.Location = new System.Drawing.Point(114, 144);
            this.tbTestFlow.Name = "tbTestFlow";
            this.tbTestFlow.ReadOnly = true;
            this.tbTestFlow.Size = new System.Drawing.Size(236, 23);
            this.tbTestFlow.TabIndex = 72;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(5, 147);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 15);
            this.label24.TabIndex = 71;
            this.label24.Text = "Test Flow";
            // 
            // tbOperatorID
            // 
            this.tbOperatorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbOperatorID.Location = new System.Drawing.Point(114, 112);
            this.tbOperatorID.Name = "tbOperatorID";
            this.tbOperatorID.ReadOnly = true;
            this.tbOperatorID.Size = new System.Drawing.Size(236, 23);
            this.tbOperatorID.TabIndex = 70;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(5, 115);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(81, 15);
            this.label25.TabIndex = 69;
            this.label25.Text = "Operator ID";
            // 
            // tbProduct
            // 
            this.tbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbProduct.Location = new System.Drawing.Point(114, 80);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.ReadOnly = true;
            this.tbProduct.Size = new System.Drawing.Size(236, 23);
            this.tbProduct.TabIndex = 68;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label26.Location = new System.Drawing.Point(5, 83);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 15);
            this.label26.TabIndex = 67;
            this.label26.Text = "Product";
            // 
            // tbLotID
            // 
            this.tbLotID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbLotID.Location = new System.Drawing.Point(114, 48);
            this.tbLotID.Name = "tbLotID";
            this.tbLotID.ReadOnly = true;
            this.tbLotID.Size = new System.Drawing.Size(236, 23);
            this.tbLotID.TabIndex = 66;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(5, 51);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 15);
            this.label27.TabIndex = 65;
            this.label27.Text = "Lot ID";
            // 
            // tbCustomer
            // 
            this.tbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbCustomer.Location = new System.Drawing.Point(114, 16);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.ReadOnly = true;
            this.tbCustomer.Size = new System.Drawing.Size(236, 23);
            this.tbCustomer.TabIndex = 64;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label28.Location = new System.Drawing.Point(5, 19);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(68, 15);
            this.label28.TabIndex = 63;
            this.label28.Text = "Customer";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.tabControl1.ItemSize = new System.Drawing.Size(109, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 55);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 593);
            this.tabControl1.TabIndex = 2;
            // 
            // btnStopTest
            // 
            this.btnStopTest.Location = new System.Drawing.Point(726, 145);
            this.btnStopTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnStopTest.Name = "btnStopTest";
            this.btnStopTest.Size = new System.Drawing.Size(107, 31);
            this.btnStopTest.TabIndex = 21;
            this.btnStopTest.Text = "Stop Test";
            this.btnStopTest.UseVisualStyleBackColor = true;
            this.btnStopTest.Click += new System.EventHandler(this.btnStopTest_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 648);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "UNIMOS T862C";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbLot;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnStart;
        private System.Windows.Forms.ToolStripButton tsBtnCloseLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbHandlerID;
        private System.Windows.Forms.Label tbHandler;
        private System.Windows.Forms.TextBox tbTesterID;
        private System.Windows.Forms.Label tbTester;
        private System.Windows.Forms.TextBox tbCLotID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbPgmPath;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbPgmName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbTestFlow;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbOperatorID;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbLotID;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnEndLot;
        private System.Windows.Forms.Button btnLoadProd;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.TextBox tbHifix;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbRecipeName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbTamperature;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        protected System.Windows.Forms.ToolStripComboBox cbCurrentFlow;
        private System.Windows.Forms.Button btnStopTest;
    }
}

