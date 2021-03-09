using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace machVisChallenge
{
    public partial class showTriangle : Form
    {
        public showTriangle()
        {
            InitializeComponent();
            ReadSpecificTxt("Equilateral Triangle"); //filtering this specific shape only
            Console.ReadLine();

            xUpDown.Value = Convert.ToDecimal(topLeftX); //converting to decimal to be read in numericupdown
            yUpDown.Value = Convert.ToDecimal(topLeftY); //converting to decimal to be read in numericupdown
            lengthUpDown.Value = Convert.ToDecimal(fullSideLength); //converting to decimal to be read in numericupdown
            orientionUpDown.Value = Convert.ToDecimal(orientation); //converting to decimal to be read in numericupdown
        }
        static float trianglei = 0;
        static string trianglea;
        static int trianglez;

        static string centerXIntWhole;
        static string centerXIntDec;

        static string centerYIntWhole;
        static string centerYIntDec;

        static string sideLengthIntWhole;
        static string sideLengthIntDec;

        static double topLeftX;
        static double topLeftY;
        static double fullSideLength;

        static string stringTopLeftX;
        static string stringTopLeftY;
        static string stringSideLength;

        static double Area;
        static double Perimeter;

        static string orientation;
        internal static float orientationFloat;

        internal static double upDownX;
        internal static double upDownY;
        internal static double upDownLength;

        static StreamReader sr = new StreamReader(@"..\shapes.csv");

        public static void ReadSpecificTxt(string text)
        {
            string line = sr.ReadLine();
            trianglea = triangleForm.triNum; //grabbing combobox1 from last form
            trianglez = Convert.ToInt32(trianglea); //converting combobox1 to int to see if equal to counter

            while (line != null)
            {
                if (line.Contains(text))
                {
                    if (trianglei == (trianglez - 1)) //comparing combobox1 to counter to grab specific shape that user choses
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

                        string[] sl = entries[6].Split('.'); //splitting side length into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                        sideLengthIntWhole = sl[0]; //whole number before decimal point
                        sideLengthIntDec = sl[1]; //decimal number after decimal point
                        stringSideLength = sideLengthIntWhole + "." + sideLengthIntDec; //joins the whole and decimal to create full number

                        orientation = entries[8]; //grabbing orientation value


                        topLeftX = Double.Parse(stringTopLeftX); //converting x coordinate into double
                        topLeftY = Double.Parse(stringTopLeftY); //converting y coordinate into double
                        fullSideLength = Double.Parse(stringSideLength); //converting side length into double
                    }
                    trianglei++; //increment counter
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
            upDownLength = Convert.ToDouble(lengthUpDown.Value); //converting side length updown value to double once button is clicked
            orientationFloat = (float)orientionUpDown.Value; //converting orientation into float so it can be read in rotateTransform
            Area = Math.Sqrt(3) / 4 * Math.Pow((Double)lengthUpDown.Value,2); // (sqrt(3)/4)*side length^2
            Perimeter = (Double)lengthUpDown.Value * 3; //multiplies side length by 3

            areaLabel.Text = Area.ToString(); //sets area label to area value
            perimeterLabel.Text = Perimeter.ToString(); //sets perimeter label to perimeter value


            //using side length and centroid to calculate distance to vertice A
            double verticeAX = upDownX;
            double verticeAY = upDownLength * .5 * Math.Sqrt(3) * 2 / 3 + upDownY; //((1/2) * √3 * side length) * (2/3)
            string verticeA = (verticeAX.ToString() + ", " + verticeAY.ToString());
            label10.Text = verticeA;

            //using side length and centroid to calculate distance to vertice B
            double calcBX = upDownLength / 2; // (1/2)side length + cendroid
            double verticeBX = upDownX + calcBX;
            double calcBY = upDownLength * .5 * Math.Sqrt(3) * 1 / 3; //((1/2) * √3 * side length) * (1/3)
            double verticeBY = upDownY - calcBY;
            string verticeB = (verticeBX.ToString() + ", " + verticeBY.ToString());
            label11.Text = verticeB;

            //using side length and centroid to calculate distance to vertice C
            double calcCX = upDownLength / 2; // centroid - (1/2) * side length
            double verticeCX = upDownX - calcCX;
            double calcCY = upDownLength * .5 * Math.Sqrt(3) * 1 / 3; //((1/2) * √3 * side length) * (1/3)
            double verticeCY = upDownY - calcCY;
            string verticeC = (verticeCX.ToString() + ", " + verticeCY.ToString());
            label12.Text = verticeC;

            Graphics g = this.CreateGraphics();
            Point[] tri =
            {
                new Point((int)verticeAX, (int)verticeAY),
                new Point((int)verticeBX, (int)verticeBY),
                new Point((int)verticeCX, (int)verticeCY)
            };      
            g.RotateTransform(orientationFloat); //rotating shape based on orientation value. This could use work.

            if (triangleForm.triangleColor == "Blue")
            {
                Pen p = new Pen(Color.Blue, 3);
                g.DrawPolygon(p, tri); //draws shape in blue
            }
            else if (triangleForm.triangleColor == "Green")
            {
                Pen p = new Pen(Color.Green, 3);
                g.DrawPolygon(p, tri); //draws shape in green
            }
            else if (triangleForm.triangleColor == "Yellow")
            {
                Pen p = new Pen(Color.Yellow, 3);
                g.DrawPolygon(p, tri); //draws shape in yellow
            }
            else
            {
                Pen p = new Pen(Color.Red, 3);
                g.DrawPolygon(p, tri); //draws shape in red if no other value is selected
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveTriangle stri = new saveTriangle();
            stri.Show(); //open next form
            this.Hide(); //close this form
        }
    }
}
