using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace machVisChallenge
{
    public partial class circleForm1 : Form
    {
        static int circlei = 0; //initialize line counter
        public static void ReadSpecificTxt(string text)
        {
            StreamReader sr = new StreamReader(@"..\shapes.csv"); //read the original csv file
            string line = sr.ReadLine(); //turn each line into string

            while (line != null)
            {
                if (line.Contains(text)) //if this line contains this specific shape
                {
                    circlei++; //counts number of shape in file
                }
                line = sr.ReadLine(); //reads line from file
            }

            line = sr.ReadLine(); //reads line from file
            sr.Close(); //close the reader
        }
        public circleForm1()
        {
            ReadSpecificTxt("Circle"); //Will filter square values only
            Console.ReadLine();
            InitializeComponent();
            label2.Text = "There are " + circlei + " Total Circles"; //Display total number of chosen shape

            for (int n = 1; n <= circlei; n++)
            {
                circleComboBox1.Items.Add(n); //Adds all possible values 1 to n. N being the total number of a chosen shape

            }
            circleComboBox1.SelectedIndex = 0; //Sets Default to 1st value
            comboBox2.SelectedIndex = 0; //Sets Default to 1st Value
        }
        internal static string circleColor; //setting up string to be read accross other forms

        private void button1_Click(object sender, EventArgs e)
        {
            showCircle ci = new showCircle();
            circleColor = comboBox2.Text; //setting color to whatever user chooses in combobox
            ci.Show(); //opens the next form
            this.Hide(); //closes this form
        }
        internal static string ciNum; //setting up string to be read accross other forms

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ciNum = circleComboBox1.Text; //setting which number of square that user wants to see
        }
    }
}
