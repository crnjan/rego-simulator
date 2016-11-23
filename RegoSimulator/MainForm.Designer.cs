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
            ((System.ComponentModel.ISupportInitialize)(this.forwardNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiatorReturnNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outdoorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotWaterNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Radiator return:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Outdoor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hot water:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Forward:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(66, 164);
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
            this.forwardNumericUpDown.Location = new System.Drawing.Point(99, 90);
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
            this.forwardNumericUpDown.Size = new System.Drawing.Size(100, 20);
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
            this.radiatorReturnNumericUpDown.Location = new System.Drawing.Point(98, 12);
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
            this.radiatorReturnNumericUpDown.Size = new System.Drawing.Size(100, 20);
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
            this.outdoorNumericUpDown.Location = new System.Drawing.Point(99, 38);
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
            this.outdoorNumericUpDown.Size = new System.Drawing.Size(100, 20);
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
            this.hotWaterNumericUpDown.Location = new System.Drawing.Point(99, 64);
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
            this.hotWaterNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.hotWaterNumericUpDown.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 270);
            this.Controls.Add(this.hotWaterNumericUpDown);
            this.Controls.Add(this.outdoorNumericUpDown);
            this.Controls.Add(this.radiatorReturnNumericUpDown);
            this.Controls.Add(this.forwardNumericUpDown);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Rego Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.forwardNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiatorReturnNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outdoorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotWaterNumericUpDown)).EndInit();
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
    }
}

