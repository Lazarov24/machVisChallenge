
namespace machVisChallenge
{
    partial class showSquare
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.perimeterLabel = new System.Windows.Forms.Label();
            this.xUpDown = new System.Windows.Forms.NumericUpDown();
            this.yUpDown = new System.Windows.Forms.NumericUpDown();
            this.lengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.orientionUpDown = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientionUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Square";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "X Coordinates:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y Coordinates:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Side Length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Orientation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(681, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Area:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(647, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Perimeter:";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(734, 9);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(60, 20);
            this.areaLabel.TabIndex = 11;
            this.areaLabel.Text = "label11";
            // 
            // perimeterLabel
            // 
            this.perimeterLabel.AutoSize = true;
            this.perimeterLabel.Location = new System.Drawing.Point(734, 41);
            this.perimeterLabel.Name = "perimeterLabel";
            this.perimeterLabel.Size = new System.Drawing.Size(60, 20);
            this.perimeterLabel.TabIndex = 12;
            this.perimeterLabel.Text = "label12";
            // 
            // xUpDown
            // 
            this.xUpDown.DecimalPlaces = 5;
            this.xUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.xUpDown.Location = new System.Drawing.Point(273, 7);
            this.xUpDown.Maximum = new decimal(new int[] {
            1190,
            0,
            0,
            0});
            this.xUpDown.Name = "xUpDown";
            this.xUpDown.Size = new System.Drawing.Size(120, 26);
            this.xUpDown.TabIndex = 14;
            // 
            // yUpDown
            // 
            this.yUpDown.DecimalPlaces = 5;
            this.yUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.yUpDown.Location = new System.Drawing.Point(273, 39);
            this.yUpDown.Maximum = new decimal(new int[] {
            585,
            0,
            0,
            0});
            this.yUpDown.Name = "yUpDown";
            this.yUpDown.Size = new System.Drawing.Size(120, 26);
            this.yUpDown.TabIndex = 15;
            // 
            // lengthUpDown
            // 
            this.lengthUpDown.DecimalPlaces = 5;
            this.lengthUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.lengthUpDown.Location = new System.Drawing.Point(515, 9);
            this.lengthUpDown.Maximum = new decimal(new int[] {
            1190,
            0,
            0,
            0});
            this.lengthUpDown.Name = "lengthUpDown";
            this.lengthUpDown.Size = new System.Drawing.Size(120, 26);
            this.lengthUpDown.TabIndex = 16;
            // 
            // orientionUpDown
            // 
            this.orientionUpDown.DecimalPlaces = 5;
            this.orientionUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.orientionUpDown.Location = new System.Drawing.Point(515, 41);
            this.orientionUpDown.Maximum = new decimal(new int[] {
            1190,
            0,
            0,
            0});
            this.orientionUpDown.Name = "orientionUpDown";
            this.orientionUpDown.Size = new System.Drawing.Size(120, 26);
            this.orientionUpDown.TabIndex = 17;
            this.orientionUpDown.ValueChanged += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(846, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 54);
            this.button2.TabIndex = 18;
            this.button2.Text = "Save New Values";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // showSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1170);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.orientionUpDown);
            this.Controls.Add(this.lengthUpDown);
            this.Controls.Add(this.yUpDown);
            this.Controls.Add(this.xUpDown);
            this.Controls.Add(this.perimeterLabel);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "showSquare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "showSquare";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.xUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orientionUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label perimeterLabel;
        public System.Windows.Forms.NumericUpDown xUpDown;
        public System.Windows.Forms.NumericUpDown yUpDown;
        public System.Windows.Forms.NumericUpDown lengthUpDown;
        public System.Windows.Forms.NumericUpDown orientionUpDown;
        private System.Windows.Forms.Button button2;
    }
}