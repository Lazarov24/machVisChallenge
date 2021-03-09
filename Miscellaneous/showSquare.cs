using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace machVisChallenge
{
    public partial class showSquare : Form
    {
        public showSquare()
        {
            InitializeComponent();
            ReadSpecificTxt("Square"); //filtering this specific shape only
            Console.ReadLine();
            
            xUpDown.Value = Convert.ToDecimal(topLeftX); //converting to decimal to be read in numericupdown
            yUpDown.Value = Convert.ToDecimal(topLeftY); //converting to decimal to be read in numericupdown
            lengthUpDown.Value = Convert.ToDecimal(fullSideLength); //converting to decimal to be read in numericupdown
            orientionUpDown.Value = Convert.ToDecimal(orientation); //converting to decimal to be read in numericupdown
        }
        public void button2_Click(object sender, EventArgs e)
        {
            saveSquare ssq = new saveSquare();         
            ssq.Show(); //open next form
            this.Hide(); //close this form
        }


        static float i = 0; 
        static string a; 
        static int z;
     
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
            a = squareForm1.sqNum; //grabbing combobox1 from last form
            z = Convert.ToInt32(a); //converting combobox1 to int to see if equal to counter

            while (line != null)
            {
                if (line.Contains(text))
                {
                    if (i == (z - 1)) //comparing combobox1 to counter to grab specific shape that user choses
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
                    i++; //increment counter
                }
                line = sr.ReadLine();
            }
            line = sr.ReadLine();   
            sr.Close();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            upDownX = Convert.ToDouble(xUpDown.Value); //converting X updown value to double once button is clicked 
            upDownY = Convert.ToDouble(yUpDown.Value); //converting Y updown value to double once button is clicked
            upDownLength = Convert.ToDouble(lengthUpDown.Value); //converting side length updown value to double once button is clicked
            orientationFloat = (float)orientionUpDown.Value; //converting orientation into float so it can be read in rotateTransform
            Area = (Double)lengthUpDown.Value * (Double)lengthUpDown.Value; //squares side length
            Perimeter = (Double)lengthUpDown.Value * 4; //multiplies side length by 4

            areaLabel.Text = Area.ToString(); //sets area label to area value
            perimeterLabel.Text = Perimeter.ToString(); //sets perimeter label to perimeter value

            Graphics g = this.CreateGraphics();
            Rectangle shape = new Rectangle((int)upDownX, //draws rectangle (square) based on x,y,sidelength values
                                            (int)upDownY,
                                            (int)upDownLength,
                                            (int)upDownLength);
            g.RotateTransform(orientationFloat); //rotating shape based on orientation value

            

            if (squareForm1.squareColor == "Blue")
            {
                Pen p = new Pen(Color.Blue, 3);
                g.DrawRectangle(p, shape); //draws shape in blue
            }
            else if (squareForm1.squareColor == "Green")
            {
                Pen p = new Pen(Color.Green, 3);
                g.DrawRectangle(p, shape); //draws shape in green
            }
            else if (squareForm1.squareColor == "Yellow")
            {
                Pen p = new Pen(Color.Yellow, 3);
                g.DrawRectangle(p, shape); //draws shape in yellow
            }
            else
            {
                Pen p = new Pen(Color.Red, 3);
                g.DrawRectangle(p, shape); //draws shape in red if no other value is selected
            }
        }
    }
}