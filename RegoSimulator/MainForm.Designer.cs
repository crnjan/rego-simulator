namespace RegoSimulator
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.forwardNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.radiatorReturnNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.outdoorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hotWaterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.frontPanelPowerCheckBox = new System.Windows.Forms.CheckBox();
            this.frontPanelPumpCheckBox = new System.Windows.Forms.CheckBox();
            this.frontPanelAddHeatCheckBox = new System.Windows.Forms.CheckBox();
            this.frontPanelWaterHeatCheckBox = new System.Windows.Forms.CheckBox();
            this.frontPanelAlarmCheckBox = new System.Windows.Forms.CheckBox();
            this.externalHotWaterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.coldFluidOutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.coldFluidInNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heatFluidInNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heatFluidOutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.compressorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.roomNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lastErrorDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lastErrorCheckBox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lastErrorErrorCodeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.portNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.forwardNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiatorReturnNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outdoorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotWaterNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalHotWaterNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coldFluidOutNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coldFluidInNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatFluidInNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatFluidOutNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compressorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastErrorErrorCodeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Radiator return:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Outdoor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hot water:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Forward:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(248, 325);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // forwardNumericUpDown
            // 
            this.forwardNumericUpDown.DecimalPlaces = 1;
            this.forwardNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.forwardNumericUpDown.Location = new System.Drawing.Point(117, 90);
            this.forwardNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.forwardNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.forwardNumericUpDown.Name = "forwardNumericUpDown";
            this.forwardNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.forwardNumericUpDown.TabIndex = 9;
            // 
            // radiatorReturnNumericUpDown
            // 
            this.radiatorReturnNumericUpDown.DecimalPlaces = 1;
            this.radiatorReturnNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.radiatorReturnNumericUpDown.Location = new System.Drawing.Point(117, 12);
            this.radiatorReturnNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.radiatorReturnNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.radiatorReturnNumericUpDown.Name = "radiatorReturnNumericUpDown";
            this.radiatorReturnNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.radiatorReturnNumericUpDown.TabIndex = 10;
            // 
            // outdoorNumericUpDown
            // 
            this.outdoorNumericUpDown.DecimalPlaces = 1;
            this.outdoorNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.outdoorNumericUpDown.Location = new System.Drawing.Point(117, 38);
            this.outdoorNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.outdoorNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.outdoorNumericUpDown.Name = "outdoorNumericUpDown";
            this.outdoorNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.outdoorNumericUpDown.TabIndex = 11;
            // 
            // hotWaterNumericUpDown
            // 
            this.hotWaterNumericUpDown.DecimalPlaces = 1;
            this.hotWaterNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.hotWaterNumericUpDown.Location = new System.Drawing.Point(117, 64);
            this.hotWaterNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.hotWaterNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.hotWaterNumericUpDown.Name = "hotWaterNumericUpDown";
            this.hotWaterNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.hotWaterNumericUpDown.TabIndex = 12;
            // 
            // frontPanelPowerCheckBox
            // 
            this.frontPanelPowerCheckBox.AutoSize = true;
            this.frontPanelPowerCheckBox.Location = new System.Drawing.Point(6, 19);
            this.frontPanelPowerCheckBox.Name = "frontPanelPowerCheckBox";
            this.frontPanelPowerCheckBox.Size = new System.Drawing.Size(95, 17);
            this.frontPanelPowerCheckBox.TabIndex = 15;
            this.frontPanelPowerCheckBox.Text = "LED 1 - Power";
            this.frontPanelPowerCheckBox.UseVisualStyleBackColor = true;
            // 
            // frontPanelPumpCheckBox
            // 
            this.frontPanelPumpCheckBox.AutoSize = true;
            this.frontPanelPumpCheckBox.Location = new System.Drawing.Point(6, 42);
            this.frontPanelPumpCheckBox.Name = "frontPanelPumpCheckBox";
            this.frontPanelPumpCheckBox.Size = new System.Drawing.Size(92, 17);
            this.frontPanelPumpCheckBox.TabIndex = 16;
            this.frontPanelPumpCheckBox.Text = "LED 2 - Pump";
            this.frontPanelPumpCheckBox.UseVisualStyleBackColor = true;
            // 
            // frontPanelAddHeatCheckBox
            // 
            this.frontPanelAddHeatCheckBox.AutoSize = true;
            this.frontPanelAddHeatCheckBox.Location = new System.Drawing.Point(6, 65);
            this.frontPanelAddHeatCheckBox.Name = "frontPanelAddHeatCheckBox";
            this.frontPanelAddHeatCheckBox.Size = new System.Drawing.Size(151, 17);
            this.frontPanelAddHeatCheckBox.TabIndex = 17;
            this.frontPanelAddHeatCheckBox.Text = "LED 3 - Additional Heating";
            this.frontPanelAddHeatCheckBox.UseVisualStyleBackColor = true;
            // 
            // frontPanelWaterHeatCheckBox
            // 
            this.frontPanelWaterHeatCheckBox.AutoSize = true;
            this.frontPanelWaterHeatCheckBox.Location = new System.Drawing.Point(6, 88);
            this.frontPanelWaterHeatCheckBox.Name = "frontPanelWaterHeatCheckBox";
            this.frontPanelWaterHeatCheckBox.Size = new System.Drawing.Size(134, 17);
            this.frontPanelWaterHeatCheckBox.TabIndex = 18;
            this.frontPanelWaterHeatCheckBox.Text = "LED 4 - Water Heating";
            this.frontPanelWaterHeatCheckBox.UseVisualStyleBackColor = true;
            // 
            // frontPanelAlarmCheckBox
            // 
            this.frontPanelAlarmCheckBox.AutoSize = true;
            this.frontPanelAlarmCheckBox.Location = new System.Drawing.Point(6, 111);
            this.frontPanelAlarmCheckBox.Name = "frontPanelAlarmCheckBox";
            this.frontPanelAlarmCheckBox.Size = new System.Drawing.Size(91, 17);
            this.frontPanelAlarmCheckBox.TabIndex = 19;
            this.frontPanelAlarmCheckBox.Text = "LED 5 - Alarm";
            this.frontPanelAlarmCheckBox.UseVisualStyleBackColor = true;
            // 
            // externalHotWaterNumericUpDown
            // 
            this.externalHotWaterNumericUpDown.DecimalPlaces = 1;
            this.externalHotWaterNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.externalHotWaterNumericUpDown.Location = new System.Drawing.Point(117, 272);
            this.externalHotWaterNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.externalHotWaterNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.externalHotWaterNumericUpDown.Name = "externalHotWaterNumericUpDown";
            this.externalHotWaterNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.externalHotWaterNumericUpDown.TabIndex = 20;
            // 
            // coldFluidOutNumericUpDown
            // 
            this.coldFluidOutNumericUpDown.DecimalPlaces = 1;
            this.coldFluidOutNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.coldFluidOutNumericUpDown.Location = new System.Drawing.Point(117, 246);
            this.coldFluidOutNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.coldFluidOutNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.coldFluidOutNumericUpDown.Name = "coldFluidOutNumericUpDown";
            this.coldFluidOutNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.coldFluidOutNumericUpDown.TabIndex = 21;
            // 
            // coldFluidInNumericUpDown
            // 
            this.coldFluidInNumericUpDown.DecimalPlaces = 1;
            this.coldFluidInNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.coldFluidInNumericUpDown.Location = new System.Drawing.Point(117, 220);
            this.coldFluidInNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.coldFluidInNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.coldFluidInNumericUpDown.Name = "coldFluidInNumericUpDown";
            this.coldFluidInNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.coldFluidInNumericUpDown.TabIndex = 22;
            // 
            // heatFluidInNumericUpDown
            // 
            this.heatFluidInNumericUpDown.DecimalPlaces = 1;
            this.heatFluidInNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.heatFluidInNumericUpDown.Location = new System.Drawing.Point(117, 194);
            this.heatFluidInNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.heatFluidInNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.heatFluidInNumericUpDown.Name = "heatFluidInNumericUpDown";
            this.heatFluidInNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.heatFluidInNumericUpDown.TabIndex = 23;
            // 
            // heatFluidOutNumericUpDown
            // 
            this.heatFluidOutNumericUpDown.DecimalPlaces = 1;
            this.heatFluidOutNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.heatFluidOutNumericUpDown.Location = new System.Drawing.Point(117, 168);
            this.heatFluidOutNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.heatFluidOutNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.heatFluidOutNumericUpDown.Name = "heatFluidOutNumericUpDown";
            this.heatFluidOutNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.heatFluidOutNumericUpDown.TabIndex = 24;
            // 
            // compressorNumericUpDown
            // 
            this.compressorNumericUpDown.DecimalPlaces = 1;
            this.compressorNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.compressorNumericUpDown.Location = new System.Drawing.Point(117, 142);
            this.compressorNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.compressorNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.compressorNumericUpDown.Name = "compressorNumericUpDown";
            this.compressorNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.compressorNumericUpDown.TabIndex = 25;
            // 
            // roomNumericUpDown
            // 
            this.roomNumericUpDown.DecimalPlaces = 1;
            this.roomNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.roomNumericUpDown.Location = new System.Drawing.Point(117, 116);
            this.roomNumericUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.roomNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.roomNumericUpDown.Name = "roomNumericUpDown";
            this.roomNumericUpDown.Size = new System.Drawing.Size(85, 20);
            this.roomNumericUpDown.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Room:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "External hot water:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Cold fluid out:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Cold fluid in:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Heat fluid in:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Heat fluid out:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Compressor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.coldFluidOutNumericUpDown);
            this.groupBox1.Controls.Add(this.externalHotWaterNumericUpDown);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.heatFluidOutNumericUpDown);
            this.groupBox1.Controls.Add(this.forwardNumericUpDown);
            this.groupBox1.Controls.Add(this.heatFluidInNumericUpDown);
            this.groupBox1.Controls.Add(this.radiatorReturnNumericUpDown);
            this.groupBox1.Controls.Add(this.coldFluidInNumericUpDown);
            this.groupBox1.Controls.Add(this.outdoorNumericUpDown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.hotWaterNumericUpDown);
            this.groupBox1.Controls.Add(this.roomNumericUpDown);
            this.groupBox1.Controls.Add(this.compressorNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 299);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensors";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.frontPanelPowerCheckBox);
            this.groupBox2.Controls.Add(this.frontPanelPumpCheckBox);
            this.groupBox2.Controls.Add(this.frontPanelAlarmCheckBox);
            this.groupBox2.Controls.Add(this.frontPanelAddHeatCheckBox);
            this.groupBox2.Controls.Add(this.frontPanelWaterHeatCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(226, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 134);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Front Panel";
            // 
            // lastErrorDateTimePicker
            // 
            this.lastErrorDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.lastErrorDateTimePicker.Location = new System.Drawing.Point(77, 68);
            this.lastErrorDateTimePicker.Name = "lastErrorDateTimePicker";
            this.lastErrorDateTimePicker.Size = new System.Drawing.Size(110, 20);
            this.lastErrorDateTimePicker.TabIndex = 36;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.lastErrorErrorCodeNumericUpDown);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lastErrorCheckBox);
            this.groupBox3.Controls.Add(this.lastErrorDateTimePicker);
            this.groupBox3.Location = new System.Drawing.Point(226, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 97);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Error Log";
            // 
            // lastErrorCheckBox
            // 
            this.lastErrorCheckBox.AutoSize = true;
            this.lastErrorCheckBox.Location = new System.Drawing.Point(6, 19);
            this.lastErrorCheckBox.Name = "lastErrorCheckBox";
            this.lastErrorCheckBox.Size = new System.Drawing.Size(65, 17);
            this.lastErrorCheckBox.TabIndex = 37;
            this.lastErrorCheckBox.Text = "Enabled";
            this.lastErrorCheckBox.UseVisualStyleBackColor = true;
            this.lastErrorCheckBox.CheckedChanged += new System.EventHandler(this.lastErrorCheckBox_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Timestamp:";
            // 
            // lastErrorErrorCodeNumericUpDown
            // 
            this.lastErrorErrorCodeNumericUpDown.Location = new System.Drawing.Point(77, 42);
            this.lastErrorErrorCodeNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.lastErrorErrorCodeNumericUpDown.Name = "lastErrorErrorCodeNumericUpDown";
            this.lastErrorErrorCodeNumericUpDown.Size = new System.Drawing.Size(110, 20);
            this.lastErrorErrorCodeNumericUpDown.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Error code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Port:";
            // 
            // portNumericUpDown
            // 
            this.portNumericUpDown.Location = new System.Drawing.Point(58, 325);
            this.portNumericUpDown.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.portNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.portNumericUpDown.Name = "portNumericUpDown";
            this.portNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.portNumericUpDown.TabIndex = 39;
            this.portNumericUpDown.Value = new decimal(new int[] {
            9265,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 365);
            this.Controls.Add(this.portNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startButton);
            this.Name = "MainForm";
            this.Text = "Rego Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.forwardNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiatorReturnNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outdoorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotWaterNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalHotWaterNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coldFluidOutNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coldFluidInNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatFluidInNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatFluidOutNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compressorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastErrorErrorCodeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown forwardNumericUpDown;
        private System.Windows.Forms.NumericUpDown radiatorReturnNumericUpDown;
        private System.Windows.Forms.NumericUpDown outdoorNumericUpDown;
        private System.Windows.Forms.NumericUpDown hotWaterNumericUpDown;
        private System.Windows.Forms.CheckBox frontPanelPowerCheckBox;
        private System.Windows.Forms.CheckBox frontPanelPumpCheckBox;
        private System.Windows.Forms.CheckBox frontPanelAddHeatCheckBox;
        private System.Windows.Forms.CheckBox frontPanelWaterHeatCheckBox;
        private System.Windows.Forms.CheckBox frontPanelAlarmCheckBox;
        private System.Windows.Forms.NumericUpDown externalHotWaterNumericUpDown;
        private System.Windows.Forms.NumericUpDown coldFluidOutNumericUpDown;
        private System.Windows.Forms.NumericUpDown coldFluidInNumericUpDown;
        private System.Windows.Forms.NumericUpDown heatFluidInNumericUpDown;
        private System.Windows.Forms.NumericUpDown heatFluidOutNumericUpDown;
        private System.Windows.Forms.NumericUpDown compressorNumericUpDown;
        private System.Windows.Forms.NumericUpDown roomNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker lastErrorDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown lastErrorErrorCodeNumericUpDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox lastErrorCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown portNumericUpDown;
    }
}

