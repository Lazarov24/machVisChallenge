using System;
using System.Windows.Forms;
using System.IO;

namespace machVisChallenge
{
    public partial class saveSquare : Form
    {
        static int i = 0;
        static string a;
        static int z;
        public saveSquare()
        {
            InitializeComponent();
            ReadSpecificTxt("Square"); //read specific shape only
        }
        static StreamWriter sw = new StreamWriter(@"..\newShapes.csv"); //write to new file

        public static void ReadSpecificTxt(string text)
        {
            StreamReader sr = new StreamReader(@"..\Shapes.csv"); //read from updated file

            string line = sr.ReadLine();

            a = squareForm1.sqNum; //grabbing combobox1 from last form
            z = Convert.ToInt32(a); //converting combobox1 to int to see if equal to counter

            while (line != null)
            {
                if (line.Contains(text))
                {
                    //sw.WriteLine(line);
                    if (i == (z - 1)) ///comparing combobox1 to counter to grab specific shape that user choses
                    {
                        sw.WriteLine("Square,CenterX," //writes what value is currently in updown boxes to new file
                                  + showSquare.upDownX
                                  + ",CenterY,"
                                  + showSquare.upDownY
                                  + ",Side Length,"
                                  + showSquare.upDownLength
                                  + ",Orienation,"
                                  + showSquare.orientationFloat
                                  );
                    } 
                    else
                    {
                        sw.WriteLine(line); //writes other of chosen shape that weren't selected by user
                    } i++; //incriment counter
                    
                }
                else
                {
                    sw.WriteLine(line); //writes lines to file that don't contain square
                }
               
                line = sr.ReadLine();
            }
            sw.Flush(); //needed these to make sure all lines are written to new file
            sw.Close(); //needed these to make sure all lines are written to new file
            line = sr.ReadLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); //ends program
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
