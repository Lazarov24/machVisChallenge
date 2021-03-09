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
    public partial class showCircle : Form
    {
        public showCircle()
        {
            InitializeComponent();
            ReadSpecificTxt("Circle"); //filtering this specific shape only
            Console.ReadLine();

            xUpDown.Value = Convert.ToDecimal(topLeftX); //converting to decimal to be read in numericupdown
            yUpDown.Value = Convert.ToDecimal(topLeftY); //converting to decimal to be read in numericupdown
            radiusUpDown.Value = Convert.ToDecimal(fullRadius); //converting to decimal to be read in numericupdown
        }



        static int circlei = 0;
        static string circlea;
        static int circlez;

        static string centerXIntWhole;
        static string centerXIntDec;

        static string centerYIntWhole;
        static string centerYIntDec;

        static string radiusIntWhole;
        static string radiusIntDec;

        static double topLeftX;
        static double topLeftY;
        static double fullRadius;

        static string stringTopLeftX;
        static string stringTopLeftY;
        static string stringRadius;

        static double Area;
        static double Circumference;


        internal static double upDownX;
        internal static double upDownY;
        internal static double upDownRadius;

        static StreamReader sr = new StreamReader(@"..\shapes.csv");



        public static void ReadSpecificTxt(string text)
        {
            string line = sr.ReadLine();
            circlea = circleForm1.ciNum; //grabbing combobox1 from last form
            circlez = Convert.ToInt32(circlea); //converting combobox1 to int to see if equal to counter
            while (line != null)
            {
                if (line.Contains(text))
                {
                    if (circlei == (circlez - 1)) //comparing combobox1 to counter to grab specific shape that user choses
                    {

                        string[] entries = line.Split(','); //splitting each value in specifically chosen line from combobox1

                        string[] x = entries[2].Split('.'); //splitting x coordinate into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                        centerXIntWhole = (x[0]); //whole number before decimal point
                        centerXIntDec = (x[1]); //decimal number after decimal point
                        stringTopLeftX = centerXIntWhole + "." + centerXIntDec; //joins the whole and decimal to create full number

                        string[] y = entries[4].Split('.'); //splitting y coordinate into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                        centerYIntWhole = y[0]; //whole number before decimal point
                        centerYIntDec = y[1]; //decimal number after decimal point
                        stringTopLeftY = centerYIntWhole + "." + centerYIntDec; //joins the whole and decimal to create full number

                        string[] rl = entries[6].Split('.'); //splitting side length into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                        radiusIntWhole = rl[0]; //whole number before decimal point
                        radiusIntDec = rl[1]; //decimal number after decimal point
                        stringRadius = radiusIntWhole + "." + radiusIntDec; //joins the whole and decimal to create full number

                        topLeftX = Double.Parse(stringTopLeftX); //converting x coordinate into double
                        topLeftY = Double.Parse(stringTopLeftY); //converting y coordinate into double
                        fullRadius = Double.Parse(stringRadius); //converting side length into double
                    }
                    circlei++; //increment counter
                }
                line = sr.ReadLine();
            }
            line = sr.ReadLine();
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            upDownX = Convert.ToDouble(xUpDown.Value); //converting X updown value to double once button is clicked 
            upDownY = Convert.ToDouble(yUpDown.Value); //converting Y updown value to double once button is clicked
            upDownRadius = Convert.ToDouble(radiusUpDown.Value); //converting side length updown value to double once button is clicked
            //orientationFloat = (float)orientionUpDown.Value; //converting orientation into float so it can be read in rotateTransform
            Area = (Double)radiusUpDown.Value * (Double)radiusUpDown.Value; //squares side length
            Circumference = (Double)radiusUpDown.Value * 4; //multiplies side length by 4

            areaLabel.Text = Area.ToString(); //sets area label to area value
            circumferenceLabel.Text = Circumference.ToString(); //sets perimeter label to perimeter value

            Graphics g = this.CreateGraphics();
            Rectangle shape = new Rectangle((int)upDownX, //draws rectangle (square) based on x,y,sidelength values
                                            (int)upDownY,
                                            (int)upDownRadius,
                                            (int)upDownRadius);
            //g.RotateTransform(orientationFloat); //rotating shape based on orientation value



            if (circleForm1.circleColor == "Blue")
            {
                Pen p = new Pen(Color.Blue, 3);
                g.DrawEllipse(p, shape); //draws shape in blue
            }
            else if (circleForm1.circleColor == "Green")
            {
                Pen p = new Pen(Color.Green, 3);
                g.DrawEllipse(p, shape); //draws shape in green
            }
            else if (circleForm1.circleColor == "Yellow")
            {
                Pen p = new Pen(Color.Yellow, 3);
                g.DrawEllipse(p, shape); //draws shape in yellow
            }
            else
            {
                Pen p = new Pen(Color.Red, 3);
                g.DrawEllipse(p, shape); //draws shape in red if no other value is selected
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveCircle sc = new saveCircle();
            sc.Show(); //open next form
            this.Hide(); //close this form
        }
    }
}
