namespace Race2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numUserAge = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRace = new System.Windows.Forms.TabPage();
            this.pnlSum = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvBestLaps = new System.Windows.Forms.DataGridView();
            this.lblPetrolCost = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblMoneyMade = new System.Windows.Forms.Label();
            this.lblBestUser = new System.Windows.Forms.Label();
            this.btnSummarise2 = new System.Windows.Forms.Button();
            this.pnlLaps = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clbLapsUser = new System.Windows.Forms.CheckedListBox();
            this.btnSummarise = new System.Windows.Forms.Button();
            this.lblRaceName = new System.Windows.Forms.Label();
            this.lblBestLap = new System.Windows.Forms.Label();
            this.btnAddLap = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numLapTimeMilli = new System.Windows.Forms.NumericUpDown();
            this.numLapTimeSec = new System.Windows.Forms.NumericUpDown();
            this.numLapTimeMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numLapNumber = new System.Windows.Forms.NumericUpDown();
            this.pnlRaceBasic = new System.Windows.Forms.Panel();
            this.btnModifyRace = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNewRace = new System.Windows.Forms.Button();
            this.numEstCostPerLaps = new System.Windows.Forms.NumericUpDown();
            this.numCostPerPerson = new System.Windows.Forms.NumericUpDown();
            this.numRaceDistance = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxRaceName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUserAge)).BeginInit();
            this.tabRace.SuspendLayout();
            this.pnlSum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestLaps)).BeginInit();
            this.pnlLaps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLapTimeMilli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLapTimeSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLapTimeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLapNumber)).BeginInit();
            this.pnlRaceBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEstCostPerLaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostPerPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRaceDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Controls.Add(this.tabRace);
            this.tabControl1.Location = new System.Drawing.Point(36, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 661);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.panel1);
            this.tabUsers.Location = new System.Drawing.Point(4, 29);
            this.tabUsers.Margin = new System.Windows.Forms.Padding(4);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(4);
            this.tabUsers.Size = new System.Drawing.Size(1034, 628);
            this.tabUsers.TabIndex = 2;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numUserAge);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.tbxUserName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 362);
            this.panel1.TabIndex = 0;
            // 
            // numUserAge
            // 
            this.numUserAge.Location = new System.Drawing.Point(32, 177);
            this.numUserAge.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numUserAge.Minimum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.numUserAge.Name = "numUserAge";
            this.numUserAge.Size = new System.Drawing.Size(108, 27);
            this.numUserAge.TabIndex = 7;
            this.numUserAge.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(257, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 244);
            this.listBox1.TabIndex = 6;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(32, 230);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(127, 53);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "Add user";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(32, 112);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(175, 27);
            this.tbxUserName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users";
            // 
            // tabRace
            // 
            this.tabRace.Controls.Add(this.pnlSum);
            this.tabRace.Controls.Add(this.pnlLaps);
            this.tabRace.Controls.Add(this.pnlRaceBasic);
            this.tabRace.Location = new System.Drawing.Point(4, 29);
            this.tabRace.Margin = new System.Windows.Forms.Padding(4);
            this.tabRace.Name = "tabRace";
            this.tabRace.Padding = new System.Windows.Forms.Padding(4);
            this.tabRace.Size = new System.Drawing.Size(1034, 628);
            this.tabRace.TabIndex = 3;
            this.tabRace.Text = "Race";
            this.tabRace.UseVisualStyleBackColor = true;
            // 
            // pnlSum
            // 
            this.pnlSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSum.Controls.Add(this.btnClose);
            this.pnlSum.Controls.Add(this.btnSave);
            this.pnlSum.Controls.Add(this.dgvBestLaps);
            this.pnlSum.Controls.Add(this.lblPetrolCost);
            this.pnlSum.Controls.Add(this.lblProfit);
            this.pnlSum.Controls.Add(this.lblMoneyMade);
            this.pnlSum.Controls.Add(this.lblBestUser);
            this.pnlSum.Controls.Add(this.btnSummarise2);
            this.pnlSum.Enabled = false;
            this.pnlSum.Location = new System.Drawing.Point(17, 357);
            this.pnlSum.Name = "pnlSum";
            this.pnlSum.Size = new System.Drawing.Size(988, 257);
            this.pnlSum.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(883, 111);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 55);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "button1";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(872, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 54);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvBestLaps
            // 
            this.dgvBestLaps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBestLaps.Location = new System.Drawing.Point(224, 15);
            this.dgvBestLaps.Name = "dgvBestLaps";
            this.dgvBestLaps.RowHeadersWidth = 51;
            this.dgvBestLaps.RowTemplate.Height = 24;
            this.dgvBestLaps.Size = new System.Drawing.Size(636, 221);
            this.dgvBestLaps.TabIndex = 5;
            // 
            // lblPetrolCost
            // 
            this.lblPetrolCost.AutoSize = true;
            this.lblPetrolCost.Location = new System.Drawing.Point(30, 170);
            this.lblPetrolCost.Name = "lblPetrolCost";
            this.lblPetrolCost.Size = new System.Drawing.Size(15, 20);
            this.lblPetrolCost.TabIndex = 4;
            this.lblPetrolCost.Text = "-";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Location = new System.Drawing.Point(30, 216);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(15, 20);
            this.lblProfit.TabIndex = 3;
            this.lblProfit.Text = "-";
            // 
            // lblMoneyMade
            // 
            this.lblMoneyMade.AutoSize = true;
            this.lblMoneyMade.Location = new System.Drawing.Point(30, 123);
            this.lblMoneyMade.Name = "lblMoneyMade";
            this.lblMoneyMade.Size = new System.Drawing.Size(15, 20);
            this.lblMoneyMade.TabIndex = 2;
            this.lblMoneyMade.Text = "-";
            // 
            // lblBestUser
            // 
            this.lblBestUser.AutoSize = true;
            this.lblBestUser.Location = new System.Drawing.Point(29, 77);
            this.lblBestUser.Name = "lblBestUser";
            this.lblBestUser.Size = new System.Drawing.Size(15, 20);
            this.lblBestUser.TabIndex = 1;
            this.lblBestUser.Text = "-";
            // 
            // btnSummarise2
            // 
            this.btnSummarise2.Location = new System.Drawing.Point(18, 3);
            this.btnSummarise2.Name = "btnSummarise2";
            this.btnSummarise2.Size = new System.Drawing.Size(149, 48);
            this.btnSummarise2.TabIndex = 0;
            this.btnSummarise2.Text = "Summarize";
            this.btnSummarise2.UseVisualStyleBackColor = true;
            this.btnSummarise2.Click += new System.EventHandler(this.btnSummarise2_Click);
            // 
            // pnlLaps
            // 
            this.pnlLaps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLaps.Controls.Add(this.textBox1);
            this.pnlLaps.Controls.Add(this.clbLapsUser);
            this.pnlLaps.Controls.Add(this.btnSummarise);
            this.pnlLaps.Controls.Add(this.lblRaceName);
            this.pnlLaps.Controls.Add(this.lblBestLap);
            this.pnlLaps.Controls.Add(this.btnAddLap);
            this.pnlLaps.Controls.Add(this.label7);
            this.pnlLaps.Controls.Add(this.label6);
            this.pnlLaps.Controls.Add(this.label5);
            this.pnlLaps.Controls.Add(this.numLapTimeMilli);
            this.pnlLaps.Controls.Add(this.numLapTimeSec);
            this.pnlLaps.Controls.Add(this.numLapTimeMin);
            this.pnlLaps.Controls.Add(this.label4);
            this.pnlLaps.Controls.Add(this.numLapNumber);
            this.pnlLaps.Enabled = false;
            this.pnlLaps.Location = new System.Drawing.Point(359, 11);
            this.pnlLaps.Name = "pnlLaps";
            this.pnlLaps.Size = new System.Drawing.Size(646, 340);
            this.pnlLaps.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 229);
            this.textBox1.TabIndex = 14;
            // 
            // clbLapsUser
            // 
            this.clbLapsUser.CheckOnClick = true;
            this.clbLapsUser.FormattingEnabled = true;
            this.clbLapsUser.Location = new System.Drawing.Point(28, 72);
            this.clbLapsUser.Name = "clbLapsUser";
            this.clbLapsUser.Size = new System.Drawing.Size(203, 136);
            this.clbLapsUser.TabIndex = 13;
            this.clbLapsUser.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbLapsUser_ItemCheck);
            // 
            // btnSummarise
            // 
            this.btnSummarise.Location = new System.Drawing.Point(488, 8);
            this.btnSummarise.Name = "btnSummarise";
            this.btnSummarise.Size = new System.Drawing.Size(128, 50);
            this.btnSummarise.TabIndex = 12;
            this.btnSummarise.Text = "Summarize";
            this.btnSummarise.UseVisualStyleBackColor = true;
            this.btnSummarise.Click += new System.EventHandler(this.btnSummarise_Click);
            // 
            // lblRaceName
            // 
            this.lblRaceName.AutoSize = true;
            this.lblRaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaceName.Location = new System.Drawing.Point(280, 12);
            this.lblRaceName.Name = "lblRaceName";
            this.lblRaceName.Size = new System.Drawing.Size(22, 29);
            this.lblRaceName.TabIndex = 11;
            this.lblRaceName.Text = "-";
            // 
            // lblBestLap
            // 
            this.lblBestLap.AutoSize = true;
            this.lblBestLap.Location = new System.Drawing.Point(280, 54);
            this.lblBestLap.Name = "lblBestLap";
            this.lblBestLap.Size = new System.Drawing.Size(15, 20);
            this.lblBestLap.TabIndex = 10;
            this.lblBestLap.Text = "-";
            // 
            // btnAddLap
            // 
            this.btnAddLap.Location = new System.Drawing.Point(28, 286);
            this.btnAddLap.Name = "btnAddLap";
            this.btnAddLap.Size = new System.Drawing.Size(114, 34);
            this.btnAddLap.TabIndex = 9;
            this.btnAddLap.Text = "Add Lap";
            this.btnAddLap.UseVisualStyleBackColor = true;
            this.btnAddLap.Click += new System.EventHandler(this.btnAddLap_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sec";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Min";
            // 
            // numLapTimeMilli
            // 
            this.numLapTimeMilli.Location = new System.Drawing.Point(195, 244);
            this.numLapTimeMilli.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numLapTimeMilli.Name = "numLapTimeMilli";
            this.numLapTimeMilli.Size = new System.Drawing.Size(63, 27);
            this.numLapTimeMilli.TabIndex = 5;
            // 
            // numLapTimeSec
            // 
            this.numLapTimeSec.Location = new System.Drawing.Point(118, 244);
            this.numLapTimeSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numLapTimeSec.Name = "numLapTimeSec";
            this.numLapTimeSec.Size = new System.Drawing.Size(62, 27);
            this.numLapTimeSec.TabIndex = 4;
            // 
            // numLapTimeMin
            // 
            this.numLapTimeMin.Location = new System.Drawing.Point(28, 242);
            this.numLapTimeMin.Name = "numLapTimeMin";
            this.numLapTimeMin.Size = new System.Drawing.Size(65, 27);
            this.numLapTimeMin.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lap number";
            // 
            // numLapNumber
            // 
            this.numLapNumber.Location = new System.Drawing.Point(28, 36);
            this.numLapNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLapNumber.Name = "numLapNumber";
            this.numLapNumber.Size = new System.Drawing.Size(97, 27);
            this.numLapNumber.TabIndex = 1;
            this.numLapNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnlRaceBasic
            // 
            this.pnlRaceBasic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRaceBasic.Controls.Add(this.btnModifyRace);
            this.pnlRaceBasic.Controls.Add(this.label12);
            this.pnlRaceBasic.Controls.Add(this.btnNewRace);
            this.pnlRaceBasic.Controls.Add(this.numEstCostPerLaps);
            this.pnlRaceBasic.Controls.Add(this.numCostPerPerson);
            this.pnlRaceBasic.Controls.Add(this.numRaceDistance);
            this.pnlRaceBasic.Controls.Add(this.label11);
            this.pnlRaceBasic.Controls.Add(this.label10);
            this.pnlRaceBasic.Controls.Add(this.label9);
            this.pnlRaceBasic.Controls.Add(this.label8);
            this.pnlRaceBasic.Controls.Add(this.tbxRaceName);
            this.pnlRaceBasic.Location = new System.Drawing.Point(17, 11);
            this.pnlRaceBasic.Name = "pnlRaceBasic";
            this.pnlRaceBasic.Size = new System.Drawing.Size(321, 340);
            this.pnlRaceBasic.TabIndex = 0;
            // 
            // btnModifyRace
            // 
            this.btnModifyRace.Location = new System.Drawing.Point(123, 283);
            this.btnModifyRace.Name = "btnModifyRace";
            this.btnModifyRace.Size = new System.Drawing.Size(76, 41);
            this.btnModifyRace.TabIndex = 10;
            this.btnModifyRace.Text = "Modify";
            this.btnModifyRace.UseVisualStyleBackColor = true;
            this.btnModifyRace.Visible = false;
            this.btnModifyRace.Click += new System.EventHandler(this.btnModifyRace_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(83, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 32);
            this.label12.TabIndex = 9;
            this.label12.Text = "Race";
            // 
            // btnNewRace
            // 
            this.btnNewRace.Location = new System.Drawing.Point(123, 282);
            this.btnNewRace.Name = "btnNewRace";
            this.btnNewRace.Size = new System.Drawing.Size(108, 41);
            this.btnNewRace.TabIndex = 8;
            this.btnNewRace.Text = "New Race";
            this.btnNewRace.UseVisualStyleBackColor = true;
            this.btnNewRace.Click += new System.EventHandler(this.btnNewRace_Click);
            // 
            // numEstCostPerLaps
            // 
            this.numEstCostPerLaps.DecimalPlaces = 2;
            this.numEstCostPerLaps.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numEstCostPerLaps.Location = new System.Drawing.Point(18, 280);
            this.numEstCostPerLaps.Name = "numEstCostPerLaps";
            this.numEstCostPerLaps.Size = new System.Drawing.Size(81, 27);
            this.numEstCostPerLaps.TabIndex = 7;
            this.numEstCostPerLaps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCostPerPerson
            // 
            this.numCostPerPerson.DecimalPlaces = 2;
            this.numCostPerPerson.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCostPerPerson.Location = new System.Drawing.Point(18, 211);
            this.numCostPerPerson.Name = "numCostPerPerson";
            this.numCostPerPerson.Size = new System.Drawing.Size(81, 27);
            this.numCostPerPerson.TabIndex = 6;
            this.numCostPerPerson.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numRaceDistance
            // 
            this.numRaceDistance.Location = new System.Drawing.Point(18, 140);
            this.numRaceDistance.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numRaceDistance.Name = "numRaceDistance";
            this.numRaceDistance.Size = new System.Drawing.Size(72, 27);
            this.numRaceDistance.TabIndex = 5;
            this.numRaceDistance.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Est. cost per lap";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Cost per person";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Distance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Race name";
            // 
            // tbxRaceName
            // 
            this.tbxRaceName.Location = new System.Drawing.Point(18, 66);
            this.tbxRaceName.Name = "tbxRaceName";
            this.tbxRaceName.Size = new System.Drawing.Size(178, 27);
            this.tbxRaceName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 682);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUserAge)).EndInit();
            this.tabRace.ResumeLayout(false);
            this.pnlSum.ResumeLayout(false);
            this.pnlSum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestLaps)).EndInit();
            this.pnlLaps.ResumeLayout(false);
            this.pnlLaps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLapTimeMilli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLapTimeSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLapTimeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLapNumber)).EndInit();
            this.pnlRaceBasic.ResumeLayout(false);
            this.pnlRaceBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEstCostPerLaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostPerPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRaceDistance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabRace;
        private System.Windows.Forms.Panel pnlSum;
        private System.Windows.Forms.Panel pnlLaps;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numLapTimeMilli;
        private System.Windows.Forms.NumericUpDown numLapTimeSec;
        private System.Windows.Forms.NumericUpDown numLapTimeMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numLapNumber;
        private System.Windows.Forms.Panel pnlRaceBasic;
        private System.Windows.Forms.Label lblRaceName;
        private System.Windows.Forms.Label lblBestLap;
        private System.Windows.Forms.Button btnAddLap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxRaceName;
        private System.Windows.Forms.NumericUpDown numEstCostPerLaps;
        private System.Windows.Forms.NumericUpDown numCostPerPerson;
        private System.Windows.Forms.NumericUpDown numRaceDistance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSummarise;
        private System.Windows.Forms.Button btnNewRace;
        private System.Windows.Forms.Button btnSummarise2;
        private System.Windows.Forms.DataGridView dgvBestLaps;
        private System.Windows.Forms.Label lblPetrolCost;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lblMoneyMade;
        private System.Windows.Forms.Label lblBestUser;
        private System.Windows.Forms.CheckedListBox clbLapsUser;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnModifyRace;
        private System.Windows.Forms.NumericUpDown numUserAge;
        private System.Windows.Forms.Button btnClose;
    }
}

