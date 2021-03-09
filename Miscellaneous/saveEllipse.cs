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
    public partial class saveEllipse : Form
    {
        static int ellipsei = 0;
        static string ellipsea;
        static int ellipsez;
        public saveEllipse()
        {
            InitializeComponent();
            ReadSpecificTxt("Ellipse"); //read specific shape only
        }
        static StreamWriter sw = new StreamWriter(@"..\newShapes.csv"); //write to new file

        public static void ReadSpecificTxt(string text)
        {
            StreamReader sr = new StreamReader(@"..\Shapes.csv"); //read from updated file

            string line = sr.ReadLine();

            ellipsea = ellipseForm1.elNum; //grabbing combobox1 from last form
            ellipsez = Convert.ToInt32(ellipsea); //converting combobox1 to int to see if equal to counter

            while (line != null)
            {
                if (line.Contains(text))
                {
                    //sw.WriteLine(line);
                    if (ellipsei == (ellipsez - 1)) ///comparing combobox1 to counter to grab specific shape that user choses
                    {
                        sw.WriteLine("Ellipse,CenterX," //writes what value is currently in updown boxes to new file
                                  + showEllipse.upDownX
                                  + ",CenterY,"
                                  + showEllipse.upDownY
                                  + ",R1,"
                                  + showEllipse.upDownR1
                                  + ",R2,"
                                  + showEllipse.upDownR2
                                  + ",Orienation,"
                                  + showEllipse.orientationFloat
                                  );
                    }
                    else
                    {
                        sw.WriteLine(line); //writes other of chosen shape that weren't selected by user
                    }
                    ellipsei++; //incriment counter

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
