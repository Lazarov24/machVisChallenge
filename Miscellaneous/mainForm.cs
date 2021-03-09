using System;
using System.Windows.Forms;


namespace machVisChallenge
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void sqrBtn_Click(object sender, EventArgs e)
        {
            ReadSpecificTxt("Square"); //filter only square shape
            Console.ReadLine();
            this.Hide(); //closes window before moving to next window
        }
        static void ReadSpecificTxt(string text)
        {
            squareForm1 sq1 = new squareForm1(); 
            sq1.Show(); //opens next window
        }

        private void ellipseButton_Click(object sender, EventArgs e)
        {
            ellipseForm1 el1 = new ellipseForm1();
            el1.Show(); //opens next window
            this.Hide(); //closes window before moving to next window
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            circleForm1 ci1 = new circleForm1();
            ci1.Show(); //opens next window
            this.Hide(); //closes window before moving to next window
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            triangleForm tri1 = new triangleForm();
            tri1.Show(); //opens next window
            this.Hide(); //closes window before moving to next window
        }

        private void polygonButton_Click(object sender, EventArgs e)
        {
            polygonForm pol1 = new polygonForm();
            pol1.Show(); //opens next window
            this.Hide(); //closes window before moving to next window
        }
    }
}
