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
    public partial class triangleForm : Form
    {
        static int trianglei = 0; //initialize line counter
        public static void ReadSpecificTxt(string text)
        {
            StreamReader sr = new StreamReader(@"..\shapes.csv"); //read the original csv file
            string line = sr.ReadLine(); //turn each line into string

            while (line != null)
            {
                if (line.Contains(text)) //if this line contains this specific shape
                {
                    trianglei++; //counts number of shape in file
                }
                line = sr.ReadLine(); //reads line from file
            }

            line = sr.ReadLine(); //reads line from file
            sr.Close(); //close the reader
        }
        public triangleForm()
        {
            ReadSpecificTxt("Equilateral Triangle"); //Will filter square values only
            Console.ReadLine();
            InitializeComponent();
            label2.Text = "There are " + trianglei + " Total Triangles"; //Display total number of chosen shape

            for (int n = 1; n <= trianglei; n++)
            {
                comboBox1.Items.Add(n); //Adds all possible values 1 to n. N being the total number of a chosen shape

            }
            comboBox1.SelectedIndex = 0; //Sets Default to 1st value
            comboBox2.SelectedIndex = 0; //Sets Default to 1st Value
        }

        internal static string triangleColor; //setting up string to be read accross other forms

        private void button1_Click(object sender, EventArgs e)
        {
            showTriangle tri = new showTriangle();
            triangleColor = comboBox2.Text; //setting color to whatever user chooses in combobox
            tri.Show(); //opens the next form
            this.Hide(); //closes this form
        }

        internal static string triNum; //setting up string to be read accross other forms

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            triNum = comboBox1.Text; //setting which number of square that user wants to see
        }
    }
}
