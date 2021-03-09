
namespace machVisChallenge
{
    partial class mainForm
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
            this.sqrBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ellipseButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.polygonButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sqrBtn
            // 
            this.sqrBtn.Location = new System.Drawing.Point(12, 64);
            this.sqrBtn.Name = "sqrBtn";
            this.sqrBtn.Size = new System.Drawing.Size(152, 90);
            this.sqrBtn.TabIndex = 0;
            this.sqrBtn.Text = "Square";
            this.sqrBtn.UseVisualStyleBackColor = true;
            this.sqrBtn.Click += new System.EventHandler(this.sqrBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "What Kind of Shape Would You Like to See?";
            // 
            // ellipseButton
            // 
            this.ellipseButton.Location = new System.Drawing.Point(170, 64);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(152, 90);
            this.ellipseButton.TabIndex = 2;
            this.ellipseButton.Text = "Ellipse";
            this.ellipseButton.UseVisualStyleBackColor = true;
            this.ellipseButton.Click += new System.EventHandler(this.ellipseButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Location = new System.Drawing.Point(486, 64);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(152, 90);
            this.triangleButton.TabIndex = 4;
            this.triangleButton.Text = "Equillateral Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // polygonButton
            // 
            this.polygonButton.Location = new System.Drawing.Point(644, 64);
            this.polygonButton.Name = "polygonButton";
            this.polygonButton.Size = new System.Drawing.Size(152, 90);
            this.polygonButton.TabIndex = 5;
            this.polygonButton.Text = "Polygon";
            this.polygonButton.UseVisualStyleBackColor = true;
            this.polygonButton.Click += new System.EventHandler(this.polygonButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(328, 64);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(152, 90);
            this.circleButton.TabIndex = 6;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 204);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.polygonButton);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.ellipseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sqrBtn);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sqrBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ellipseButton;
        private System.Windows.Forms.Button triangleButton;
        private System.Windows.Forms.Button polygonButton;
        private System.Windows.Forms.Button circleButton;
    }
}

