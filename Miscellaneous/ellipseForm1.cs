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
    public partial class ellipseForm1 : Form
    {
        static int ellipsei = 0; //initialize line counter
        public static void ReadSpecificTxt(string text)
        {
            StreamReader sr = new StreamReader(@"..\shapes.csv"); //read the original csv file
            string line = sr.ReadLine(); //turn each line into string

            while (line != null)
            {
                if (line.Contains(text)) //if this line contains this specific shape
                {
                    ellipsei++; //counts number of shape in file
                }
                line = sr.ReadLine(); //reads line from file
            }

            line = sr.ReadLine(); //reads line from file
            sr.Close(); //close the reader
        }
        public ellipseForm1()
        {
            ReadSpecificTxt("Ellipse"); //Will filter square values only
            Console.ReadLine();
            InitializeComponent();
            label2.Text = "There are " + ellipsei + " Total Ellipses"; //Display total number of chosen shape

            for (int n = 1; n <= ellipsei; n++)
            {
                ellipseComboBox1.Items.Add(n); //Adds all possible values 1 to n. N being the total number of a chosen shape

            }
            ellipseComboBox1.SelectedIndex = 0; //Sets Default to 1st value
            comboBox2.SelectedIndex = 0; //Sets Default to 1st Value
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        internal static string ellipseColor; //setting up string to be read accross other forms

        private void button1_Click(object sender, EventArgs e)
        {
            showEllipse el = new showEllipse();
            ellipseColor = comboBox2.Text; //setting color to whatever user chooses in combobox
            el.Show(); //opens the next form
            this.Hide(); //closes this form
        }
        internal static string elNum; //setting up string to be read accross other forms

        private void ellipseComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            elNum = ellipseComboBox1.Text; //setting which number of square that user wants to see
        }
    }
}
