using System;
using System.Windows.Forms;
using System.IO;

namespace machVisChallenge
{
    public partial class savePolygon : Form
    {
        static int polygoni = 0;
        static string polygona;
        static int polygonz;
        public savePolygon()
        {
            InitializeComponent();
            ReadSpecificTxt("Polygon"); //read specific shape only

        }
        static StreamWriter sw = new StreamWriter(@"..\newShapes.csv"); //write to new file

        public static void ReadSpecificTxt(string text)
        {
            StreamReader sr = new StreamReader(@"..\Shapes.csv"); //read from updated file

            string line = sr.ReadLine();

            polygona = polygonForm.polNum; //grabbing combobox1 from last form
            polygonz = Convert.ToInt32(polygona); //converting combobox1 to int to see if equal to counter

            while (line != null)
            {
                if (line.Contains(text))
                {
                    //sw.WriteLine(line);
                    if (polygoni == (polygonz - 1)) ///comparing combobox1 to counter to grab specific shape that user choses
                    {
                        sw.WriteLine("Polygon,X0," //writes what value is currently in updown boxes to new file
                                  + showPolygon.upDownX0
                                  + ",Y0,"
                                  + showPolygon.upDownY0
                                  + ",X1,"
                                  + showPolygon.upDownX1
                                  + ",Y1,"
                                  + showPolygon.upDownY1
                                  + ",X2,"
                                  + showPolygon.upDownX2
                                  + ",Y2,"
                                  + showPolygon.upDownY2
                                  + ",X3,"
                                  + showPolygon.upDownX3
                                  + ",Y3,"
                                  + showPolygon.upDownY3
                                  + ",X4,"
                                  + showPolygon.upDownX4
                                  + ",Y4,"
                                  + showPolygon.upDownY4
                                  + ",X5,"
                                  + showPolygon.upDownX5
                                  + ",Y5,"
                                  + showPolygon.upDownY5
                                  + ",X6,"
                                  + showPolygon.upDownX6
                                  + ",Y6,"
                                  + showPolygon.upDownY6
                                  + ",X7,"
                                  + showPolygon.upDownX7
                                  + ",Y7,"
                                  + showPolygon.upDownY7
                                  + ",X8,"
                                  + showPolygon.upDownX8
                                  + ",Y8,"
                                  + showPolygon.upDownY8
                                  + ",X9,"
                                  + showPolygon.upDownX9
                                  + ",Y9,"
                                  + showPolygon.upDownY9
                                  + ",X10,"
                                  + showPolygon.upDownX10
                                  + ",Y10,"
                                  + showPolygon.upDownY10
                                  + ",X11,"
                                  + showPolygon.upDownX11
                                  + ",Y11,"
                                  + showPolygon.upDownY11
                                  );
                    }
                    else
                    {
                        sw.WriteLine(line); //writes other of chosen shape that weren't selected by user
                    }
                    polygoni++; //incriment counter

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
