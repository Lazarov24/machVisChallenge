using System;
using System.Windows.Forms;
using System.IO;


namespace machVisChallenge
{
    
    public partial class squareForm1 : Form
    {
        
        static int squarei = 0; //initialize line counter

        public static void ReadSpecificTxt(string text)
        {
            StreamReader sr = new StreamReader(@"..\shapes.csv"); //read the original csv file
            string line = sr.ReadLine(); //turn each line into string
           
            while (line != null)
            {
                if (line.Contains(text)) //if this line contains this specific shape
                {
                    squarei++; //counts number of shape in file
                }
                line = sr.ReadLine(); //reads line from file
            }

            line = sr.ReadLine(); //reads line from file
            sr.Close(); //close the reader
        }

        public squareForm1()
        {
            ReadSpecificTxt("Square"); //Will filter square values only
            Console.ReadLine();
            InitializeComponent();
            label2.Text = "There are " + squarei + " Total Squares"; //Display total number of chosen shape
            
            for (int n = 1; n <= squarei; n++)
            {
                comboBox1.Items.Add(n); //Adds all possible values 1 to n. N being the total number of a chosen shape

            }
            comboBox1.SelectedIndex = 0; //Sets Default to 1st value
            comboBox2.SelectedIndex = 0; //Sets Default to 1st Value
        }


        internal static string squareColor; //setting up string to be read accross other forms

        private void button1_Click(object sender, EventArgs e)
        {
            showSquare sq = new showSquare();
            squareColor = comboBox2.Text; //setting color to whatever user chooses in combobox
            sq.Show(); //opens the next form
            this.Hide(); //closes this form
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        internal static string sqNum; //setting up string to be read accross other forms
        
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqNum = comboBox1.Text; //setting which number of square that user wants to see
        }
    }
}
