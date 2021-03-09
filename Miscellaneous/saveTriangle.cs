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
    public partial class saveTriangle : Form
    {
        static int trianglei = 0;
        static string trianglea;
        static int trianglez;
        public saveTriangle()
        {
            InitializeComponent();
            ReadSpecificTxt("Equilateral Triangle"); //read specific shape only

        }

        static StreamWriter sw = new StreamWriter(@"..\newShapes.csv"); //write to new file

        public static void ReadSpecificTxt(string text)
        {
            StreamReader sr = new StreamReader(@"..\Shapes.csv"); //read from updated file

            string line = sr.ReadLine();

            trianglea = triangleForm.triNum; //grabbing combobox1 from last form
            trianglez = Convert.ToInt32(trianglea); //converting combobox1 to int to see if equal to counter

            while (line != null)
            {
                if (line.Contains(text))
                {
                    //sw.WriteLine(line);
                    if (trianglei == (trianglez - 1)) ///comparing combobox1 to counter to grab specific shape that user choses
                    {
                        sw.WriteLine("Equilateral Triangle,CenterX," //writes what value is currently in updown boxes to new file
                                  + showTriangle.upDownX
                                  + ",CenterY,"
                                  + showTriangle.upDownY
                                  + ",Side Length,"
                                  + showTriangle.upDownLength
                                  + ",Orienation,"
                                  + showTriangle.orientationFloat
                                  );
                    }
                    else
                    {
                        sw.WriteLine(line); //writes other of chosen shape that weren't selected by user
                    }
                    trianglei++; //incriment counter

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
    }
}
