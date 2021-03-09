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
    public partial class showEllipse : Form
    {
        public showEllipse()
        {
            InitializeComponent();
            ReadSpecificTxt("Ellipse"); //filtering this specific shape only
            Console.ReadLine();

            xUpDown.Value = Convert.ToDecimal(topLeftX); //converting to decimal to be read in numericupdown
            yUpDown.Value = Convert.ToDecimal(topLeftY); //converting to decimal to be read in numericupdown
            R1UpDown.Value = Convert.ToDecimal(fullR1); //converting to decimal to be read in numericupdown
            R2UpDown.Value = Convert.ToDecimal(fullR2); //converting to decimal to be read in numericupdown
            orientionUpDown.Value = Convert.ToDecimal(orientation); //converting to decimal to be read in numericupdown
        
        }


        static int ellipsei = 0;
        static string ellipsea;
        static int ellipsez;

        static string centerXIntWhole;
        static string centerXIntDec;

        static string centerYIntWhole;
        static string centerYIntDec;

        static string R1IntWhole;
        static string R1IntDec;

        static string R2IntWhole;
        static string R2IntDec;

        static double topLeftX;
        static double topLeftY;
        static double fullR1;
        static double fullR2;


        static string stringTopLeftX;
        static string stringTopLeftY;
        static string stringR1;
        static string stringR2;


        static double ellipseArea;
        static double Circumference;

        static string orientation;
        internal static float orientationFloat;

        internal static double upDownX;
        internal static double upDownY;
        internal static double upDownR1;
        internal static double upDownR2;


        static StreamReader sr = new StreamReader(@"..\shapes.csv");

        public static void ReadSpecificTxt(string text)
        {
            string line = sr.ReadLine();
            ellipsea = ellipseForm1.elNum; //grabbing combobox1 from last form
            ellipsez = Convert.ToInt32(ellipsea); //converting combobox1 to int to see if equal to counter
            while (line != null)
            {
                if (line.Contains(text))
                {
                    if (ellipsei == (ellipsez - 1)) //comparing combobox1 to counter to grab specific shape that user choses
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
                        R1IntWhole = rl[0]; //whole number before decimal point
                        R1IntDec = rl[1]; //decimal number after decimal point
                        stringR1 = R1IntWhole + "." + R1IntDec; //joins the whole and decimal to create full number
                        
                        string[] r2 = entries[8].Split('.'); //splitting side length into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                        R2IntWhole = r2[0]; //whole number before decimal point
                        R2IntDec = r2[1]; //decimal number after decimal point
                        stringR2 = R2IntWhole + "." + R2IntDec; //joins the whole and decimal to create full number

                        orientation = entries[10]; //grabbing orientation value


                        topLeftX = Double.Parse(stringTopLeftX); //converting x coordinate into double
                        topLeftY = Double.Parse(stringTopLeftY); //converting y coordinate into double
                        fullR1 = Double.Parse(stringR1); //converting side length into double
                        fullR2 = Double.Parse(stringR2); //converting side length into double

                    }
                    ellipsei++; //increment counter
                    //MessageBox.Show(ellipsez.ToString());
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
            upDownR1 = Convert.ToDouble(R1UpDown.Value); //converting side length updown value to double once button is clicked
            upDownR2 = Convert.ToDouble(R2UpDown.Value); //converting side length updown value to double once button is clicked

            orientationFloat = (float)orientionUpDown.Value; //converting orientation into float so it can be read in rotateTransform
            ellipseArea = Math.PI * (Double)R1UpDown.Value * (Double)R2UpDown.Value; //pi*R1*R2
            
            Circumference = Math.PI * 
                (3*((Double)R1UpDown.Value + 
                (Double)R2UpDown.Value) - 
                Math.Sqrt((3*(Double)R1UpDown.Value + 
                (Double)R2UpDown.Value)*((Double)R1UpDown.Value + 
                3*(Double)R2UpDown.Value))); // c = pi[3(a+b) - sqrt((3a+b)(a+3b))] (Approximation)

            areaLabel.Text = ellipseArea.ToString(); //sets area label to area value
            circumferenceLabel.Text = Circumference.ToString(); //sets Circumference label to Cicumference value

            Graphics g = this.CreateGraphics();
            Rectangle shape = new Rectangle((int)upDownX, //draws rectangle (square) based on x,y,sidelength values
                                            (int)upDownY,
                                            (int)upDownR1,
                                            (int)upDownR2);
            g.RotateTransform(orientationFloat); //rotating shape based on orientation value



            if (ellipseForm1.ellipseColor == "Blue")
            {
                Pen p = new Pen(Color.Blue, 3);
                g.DrawEllipse(p, shape); //draws shape in blue
            }
            else if (ellipseForm1.ellipseColor == "Green")
            {
                Pen p = new Pen(Color.Green, 3);
                g.DrawEllipse(p, shape); //draws shape in green
            }
            else if (ellipseForm1.ellipseColor == "Yellow")
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
            saveEllipse sEL = new saveEllipse();
            sEL.Show(); //open next form
            this.Hide(); //close this form
        }
    }
}
