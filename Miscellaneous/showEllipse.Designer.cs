﻿
namespace machVisChallenge
{
    partial class showEllipse
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
            this.button2 = new System.Windows.Forms.Button();
            this.orientionUpDown = new System.Windows.Forms.NumericUpDown();
            this.R1UpDown = new System.Windows.Forms.NumericUpDown();
            this.yUpDown = new System.Windows.Forms.NumericUpDown();
            this.xUpDown = new System.Windows.Forms.NumericUpDown();
            this.circumferenceLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.R2UpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orientionUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R1UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R2UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(899, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 54);
            this.button2.TabIndex = 32;
            this.button2.Text = "Save New Values";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // orientionUpDown
            // 
            this.orientionUpDown.DecimalPlaces = 5;
            this.orientionUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.orientionUpDown.Location = new System.Drawing.Point(752, 10);
            this.orientionUpDown.Maximum = new decimal(new int[] {
            1190,
            0,
            0,
            0});
            this.orientionUpDown.Name = "orientionUpDown";
            this.orientionUpDown.Size = new System.Drawing.Size(120, 26);
            this.orientionUpDown.TabIndex = 31;
            this.orientionUpDown.ValueChanged += new System.EventHandler(this.button1_Click);

            // 
            // R1UpDown
            // 
            this.R1UpDown.DecimalPlaces = 5;
            this.R1UpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.R1UpDown.Location = new System.Drawing.Point(515, 12);
            this.R1UpDown.Maximum = new decimal(new int[] {
            1190,
            0,
            0,
            0});
            this.R1UpDown.Name = "R1UpDown";
            this.R1UpDown.Size = new System.Drawing.Size(120, 26);
            this.R1UpDown.TabIndex = 30;
            // 
            // yUpDown
            // 
            this.yUpDown.DecimalPlaces = 5;
            this.yUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.yUpDown.Location = new System.Drawing.Point(273, 42);
            this.yUpDown.Maximum = new decimal(new int[] {
            585,
            0,
            0,
            0});
            this.yUpDown.Name = "yUpDown";
            this.yUpDown.Size = new System.Drawing.Size(120, 26);
            this.yUpDown.TabIndex = 29;
            // 
            // xUpDown
            // 
            this.xUpDown.DecimalPlaces = 5;
            this.xUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.xUpDown.Location = new System.Drawing.Point(273, 10);
            this.xUpDown.Maximum = new decimal(new int[] {
            1190,
            0,
            0,
            0});
            this.xUpDown.Name = "xUpDown";
            this.xUpDown.Size = new System.Drawing.Size(120, 26);
            this.xUpDown.TabIndex = 28;
            // 
            // circumferenceLabel
            // 
            this.circumferenceLabel.AutoSize = true;
            this.circumferenceLabel.Location = new System.Drawing.Point(742, 71);
            this.circumferenceLabel.Name = "circumferenceLabel";
            this.circumferenceLabel.Size = new System.Drawing.Size(60, 20);
            this.circumferenceLabel.TabIndex = 27;
            this.circumferenceLabel.Text = "label12";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(742, 44);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(60, 20);
            this.areaLabel.TabIndex = 26;
            this.areaLabel.Text = "label11";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Circumference:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(689, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Area:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Orientation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Radius 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Y Coordinates:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "X Coordinates:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 46);
            this.button1.TabIndex = 19;
            this.button1.Text = "Show Ellipse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // R2UpDown
            // 
            this.R2UpDown.DecimalPlaces = 5;
            this.R2UpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.R2UpDown.Location = new System.Drawing.Point(515, 42);
            this.R2UpDown.Maximum = new decimal(new int[] {
            1190,
            0,
            0,
            0});
            this.R2UpDown.Name = "R2UpDown";
            this.R2UpDown.Size = new System.Drawing.Size(120, 26);
            this.R2UpDown.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Radius 2:";
            // 
            // showEllipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 661);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.R2UpDown);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.orientionUpDown);
            this.Controls.Add(this.R1UpDown);
            this.Controls.Add(this.yUpDown);
            this.Controls.Add(this.xUpDown);
            this.Controls.Add(this.circumferenceLabel);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "showEllipse";
            this.Text = "showEllipse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.orientionUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R1UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R2UpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.NumericUpDown orientionUpDown;
        public System.Windows.Forms.NumericUpDown R1UpDown;
        public System.Windows.Forms.NumericUpDown yUpDown;
        public System.Windows.Forms.NumericUpDown xUpDown;
        private System.Windows.Forms.Label circumferenceLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.NumericUpDown R2UpDown;
        private System.Windows.Forms.Label label7;
    }
}