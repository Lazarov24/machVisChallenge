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
    public partial class showPolygon : Form
    {
        public showPolygon()
        {
            InitializeComponent();
            ReadSpecificTxt("Polygon"); //filtering this specific shape only
            Console.ReadLine();

            x0UpDown.Value = Convert.ToDecimal(doubX0); //converting to decimal to be read in numericupdown
            y0UpDown.Value = Convert.ToDecimal(doubY0); //converting to decimal to be read in numericupdown
            x1UpDown.Value = Convert.ToDecimal(doubX1); //converting to decimal to be read in numericupdown
            y1UpDown.Value = Convert.ToDecimal(doubY1); //converting to decimal to be read in numericupdown
            x2UpDown.Value = Convert.ToDecimal(doubX2); //converting to decimal to be read in numericupdown
            y2UpDown.Value = Convert.ToDecimal(doubY2); //converting to decimal to be read in numericupdown
            x3UpDown.Value = Convert.ToDecimal(doubX3); //converting to decimal to be read in numericupdown
            y3UpDown.Value = Convert.ToDecimal(doubY3); //converting to decimal to be read in numericupdown
            x4UpDown.Value = Convert.ToDecimal(doubX4); //converting to decimal to be read in numericupdown
            y4UpDown.Value = Convert.ToDecimal(doubY4); //converting to decimal to be read in numericupdown
            x5UpDown.Value = Convert.ToDecimal(doubX5); //converting to decimal to be read in numericupdown
            y5UpDown.Value = Convert.ToDecimal(doubY5); //converting to decimal to be read in numericupdown
            x6UpDown.Value = Convert.ToDecimal(doubX6); //converting to decimal to be read in numericupdown
            y6UpDown.Value = Convert.ToDecimal(doubY6); //converting to decimal to be read in numericupdown
            x7UpDown.Value = Convert.ToDecimal(doubX7); //converting to decimal to be read in numericupdown
            y7UpDown.Value = Convert.ToDecimal(doubY7); //converting to decimal to be read in numericupdown
            x8UpDown.Value = Convert.ToDecimal(doubX8); //converting to decimal to be read in numericupdown
            y8UpDown.Value = Convert.ToDecimal(doubY8); //converting to decimal to be read in numericupdown
            x9UpDown.Value = Convert.ToDecimal(doubX9); //converting to decimal to be read in numericupdown
            y9UpDown.Value = Convert.ToDecimal(doubY9); //converting to decimal to be read in numericupdown
            x10UpDown.Value = Convert.ToDecimal(doubX10); //converting to decimal to be read in numericupdown
            y10UpDown.Value = Convert.ToDecimal(doubY10); //converting to decimal to be read in numericupdown}
            x11UpDown.Value = Convert.ToDecimal(doubX11); //converting to decimal to be read in numericupdown
            y11UpDown.Value = Convert.ToDecimal(doubY11); //converting to decimal to be read in numericupdown
        }
            static float polygoni = 0;
        static string polygona;
        static int polygonz;

        static string X0Whole;
        static string X0Dec;
        static string Y0Whole;
        static string Y0Dec;

        static string X1Whole;
        static string X1Dec;
        static string Y1Whole;
        static string Y1Dec;

        static string X2Whole;
        static string X2Dec;
        static string Y2Whole;
        static string Y2Dec;

        static string X3Whole;
        static string X3Dec;
        static string Y3Whole;
        static string Y3Dec;

        static string X4Whole;
        static string X4Dec;
        static string Y4Whole;
        static string Y4Dec;

        static string X5Whole;
        static string X5Dec;
        static string Y5Whole;
        static string Y5Dec;

        static string X6Whole;
        static string X6Dec;
        static string Y6Whole;
        static string Y6Dec;

        static string X7Whole;
        static string X7Dec;
        static string Y7Whole;
        static string Y7Dec;

        static string X8Whole;
        static string X8Dec;
        static string Y8Whole;
        static string Y8Dec;

        static string X9Whole;
        static string X9Dec;
        static string Y9Whole;
        static string Y9Dec;

        static string X10Whole;
        static string X10Dec;
        static string Y10Whole;
        static string Y10Dec;

        static string X11Whole;
        static string X11Dec;
        static string Y11Whole;
        static string Y11Dec;

        static double doubX0;
        static double doubY0;
        static double doubX1;
        static double doubY1;
        static double doubX2;
        static double doubY2;
        static double doubX3;
        static double doubY3;
        static double doubX4;
        static double doubY4;
        static double doubX5;
        static double doubY5;
        static double doubX6;
        static double doubY6;
        static double doubX7;
        static double doubY7;
        static double doubX8;
        static double doubY8;
        static double doubX9;
        static double doubY9;
        static double doubX10;
        static double doubY10;
        static double doubX11;
        static double doubY11;

        static string stringX0;
        static string stringY0;
        static string stringX1;
        static string stringY1;
        static string stringX2;
        static string stringY2;
        static string stringX3;
        static string stringY3;
        static string stringX4;
        static string stringY4;
        static string stringX5;
        static string stringY5;
        static string stringX6;
        static string stringY6;
        static string stringX7;
        static string stringY7;
        static string stringX8;
        static string stringY8;
        static string stringX9;
        static string stringY9;
        static string stringX10;
        static string stringY10;
        static string stringX11;
        static string stringY11;



        internal static double upDownX0;
        internal static double upDownY0;
        internal static double upDownX1;
        internal static double upDownY1;
        internal static double upDownX2;
        internal static double upDownY2;
        internal static double upDownX3;
        internal static double upDownY3;
        internal static double upDownX4;
        internal static double upDownY4;
        internal static double upDownX5;
        internal static double upDownY5;
        internal static double upDownX6;
        internal static double upDownY6;
        internal static double upDownX7;
        internal static double upDownY7;
        internal static double upDownX8;
        internal static double upDownY8;
        internal static double upDownX9;
        internal static double upDownY9;
        internal static double upDownX10;
        internal static double upDownY10;
        internal static double upDownX11;
        internal static double upDownY11;

        internal static string[] entries;
        

        

        static StreamReader sr = new StreamReader(@"..\shapes.csv");

        public static void ReadSpecificTxt(string text)
        {
            string line = sr.ReadLine();
            polygona = polygonForm.polNum; //grabbing combobox1 from last form
            polygonz = Convert.ToInt32(polygona); //converting combobox1 to int to see if equal to counter

            while (line != null)
            {
                if (line.Contains(text))
                {
                    if (polygoni == (polygonz - 1)) //comparing combobox1 to counter to grab specific shape that user choses
                    {

                        entries = line.Split(','); //splitting each value in specifically chosen line from combobox1
                        if (entries.Length >= 5)
                        {
                            string[] x0 = entries[2].Split('.'); //splitting x coordinate into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                            X0Whole = (x0[0]); //whole number before decimal point
                            X0Dec = (x0[1]); //decimal number after decimal point
                            stringX0 = X0Whole + "." + X0Dec; //joins the whole and decimal to create full number

                            string[] y0 = entries[4].Split('.'); //splitting y coordinate into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                            Y0Whole = y0[0]; //whole number before decimal point
                            Y0Dec = y0[1]; //decimal number after decimal point
                            stringY0 = Y0Whole + "." + Y0Dec; //joins the whole and decimal to create full number

                            if (entries.Length >= 9)
                            {
                                string[] xl = entries[6].Split('.'); //splitting side length into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                X1Whole = xl[0]; //whole number before decimal point
                                X1Dec = xl[1]; //decimal number after decimal point
                                stringX1 = X1Whole + "." + X1Dec; //joins the whole and decimal to create full number

                                string[] y1 = entries[8].Split('.'); //splitting y coordinate into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                Y1Whole = y1[0]; //whole number before decimal point
                                Y1Dec = y1[1]; //decimal number after decimal point
                                stringY1 = Y1Whole + "." + Y1Dec; //joins the whole and decimal to create full number

                                if (entries.Length >= 13)
                                {
                                    string[] x2 = entries[10].Split('.'); //splitting side length into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                    X2Whole = x2[0]; //whole number before decimal point
                                    X2Dec = x2[1]; //decimal number after decimal point
                                    stringX2 = X2Whole + "." + X2Dec; //joins the whole and decimal to create full number

                                    string[] y2 = entries[12].Split('.'); //splitting y coordinate into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                    Y2Whole = y2[0]; //whole number before decimal point
                                    Y2Dec = y2[1]; //decimal number after decimal point
                                    stringY2 = Y2Whole + "." + Y2Dec; //joins the whole and decimal to create full number

                                    if (entries.Length >= 17)
                                    {
                                        string[] x3 = entries[14].Split('.'); //splitting side length into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                        X3Whole = x3[0]; //whole number before decimal point
                                        X3Dec = x3[1]; //decimal number after decimal point
                                        stringX3 = X3Whole + "." + X3Dec; //joins the whole and decimal to create full number

                                        string[] y3 = entries[16].Split('.'); //splitting y coordinate into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                        Y3Whole = y3[0]; //whole number before decimal point
                                        Y3Dec = y3[1]; //decimal number after decimal point
                                        stringY3 = Y3Whole + "." + Y3Dec; //joins the whole and decimal to create full number
                                        if (entries.Length >= 21)
                                        {
                                            string[] x4 = entries[18].Split('.'); //splitting side length into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                            X4Whole = x4[0]; //whole number before decimal point
                                            X4Dec = x4[1]; //decimal number after decimal point
                                            stringX4 = X4Whole + "." + X4Dec; //joins the whole and decimal to create full number

                                            string[] y4 = entries[20].Split('.'); //splitting y coordinate into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                            Y4Whole = y4[0]; //whole number before decimal point
                                            Y4Dec = y4[1]; //decimal number after decimal point
                                            stringY4 = Y4Whole + "." + Y4Dec; //joins the whole and decimal to create full number
                                            
                                            if (entries.Length >= 25)
                                            {
                                                string[] x5 = entries[22].Split('.'); //splitting side length into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                                X5Whole = x5[0]; //whole number before decimal point
                                                X5Dec = x5[1]; //decimal number after decimal point
                                                stringX5 = X5Whole + "." + X5Dec; //joins the whole and decimal to create full number

                                                string[] y5 = entries[24].Split('.'); //splitting y coordinate into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                                Y5Whole = y5[0]; //whole number before decimal point
                                                Y5Dec = y5[1]; //decimal number after decimal point
                                                stringY5 = Y5Whole + "." + Y5Dec; //joins the whole and decimal to create full number
                                                if (entries.Length >= 29)
                                                {
                                                    string[] x6 = entries[26].Split('.'); //splitting side length into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                                    X6Whole = x6[0]; //whole number before decimal point
                                                    X6Dec = x6[1]; //decimal number after decimal point
                                                    stringX6 = X6Whole + "." + X6Dec; //joins the whole and decimal to create full number

                                                    string[] y6 = entries[28].Split('.'); //splitting y coordinate into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                                    Y6Whole = y6[0]; //whole number before decimal point
                                                    Y6Dec = y6[1]; //decimal number after decimal point
                                                    stringY6 = Y6Whole + "." + Y6Dec; //joins the whole and decimal to create full number
                                                    if (entries.Length >= 33)
                                                    {
                                                        string[] x7 = entries[30].Split('.'); //splitting side length into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                                        X7Whole = x7[0]; //whole number before decimal point
                                                        X7Dec = x7[1]; //decimal number after decimal point
                                                        stringX7 = X7Whole + "." + X7Dec; //joins the whole and decimal to create full number

                                                        string[] y7 = entries[32].Split('.'); //splitting y coordinate into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                                        Y7Whole = y7[0]; //whole number before decimal point
                                                        Y7Dec = y7[1]; //decimal number after decimal point
                                                        stringY7 = Y7Whole + "." + Y7Dec; //joins the whole and decimal to create full number
                                                        if (entries.Length >= 37)
                                                        {
                                                            string[] x8 = entries[34].Split('.'); //splitting side length into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                                            X8Whole = x8[0]; //whole number before decimal point
                                                            X8Dec = x8[1]; //decimal number after decimal point
                                                            stringX8 = X8Whole + "." + X8Dec; //joins the whole and decimal to create full number

                                                            string[] y8 = entries[36].Split('.'); //splitting y coordinate into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                                            Y8Whole = y8[0]; //whole number before decimal point
                                                            Y8Dec = y8[1]; //decimal number after decimal point
                                                            stringY8 = Y8Whole + "." + Y8Dec; //joins the whole and decimal to create full number
                                                            if (entries.Length >= 41)
                                                            {
                                                                string[] x9 = entries[38].Split('.'); //splitting side length into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                                                X9Whole = x9[0]; //whole number before decimal point
                                                                X9Dec = x9[1]; //decimal number after decimal point
                                                                stringX9 = X9Whole + "." + X9Dec; //joins the whole and decimal to create full number

                                                                string[] y9 = entries[40].Split('.'); //splitting y coordinate into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                                                Y9Whole = y9[0]; //whole number before decimal point
                                                                Y9Dec = y9[1]; //decimal number after decimal point
                                                                stringY9 = Y9Whole + "." + Y9Dec; //joins the whole and decimal to create full number
                                                                if (entries.Length >= 45)
                                                                {
                                                                    string[] x10 = entries[42].Split('.'); //splitting side length into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                                                    X10Whole = x10[0]; //whole number before decimal point
                                                                    X10Dec = x10[1]; //decimal number after decimal point
                                                                    stringX10 = X10Whole + "." + X10Dec; //joins the whole and decimal to create full number

                                                                    string[] y10 = entries[44].Split('.'); //splitting y coordinate into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                                                    Y10Whole = y10[0]; //whole number before decimal point
                                                                    Y10Dec = y10[1]; //decimal number after decimal point
                                                                    stringY10 = Y10Whole + "." + Y10Dec; //joins the whole and decimal to create full number
                                                                    if (entries.Length >= 49)
                                                                    {
                                                                        string[] x11 = entries[46].Split('.'); //splitting side length into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                                                        X11Whole = x11[0]; //whole number before decimal point
                                                                        X11Dec = x11[1]; //decimal number after decimal point
                                                                        stringX11 = X11Whole + "." + X11Dec; //joins the whole and decimal to create full number

                                                                        string[] y11 = entries[48].Split('.'); //splitting y coordinate into whole and decimal so that it can be read as a decimal on UpDown and also later converted into double for calculation
                                                                        Y11Whole = y11[0]; //whole number before decimal point
                                                                        Y11Dec = y11[1]; //decimal number after decimal point
                                                                        stringY11 = Y11Whole + "." + Y11Dec; //joins the whole and decimal to create full number
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (entries.Length >= 5)
                        {
                            doubX0 = Double.Parse(stringX0); //converting x0 coordinate into double
                            doubY0 = Double.Parse(stringY0); //converting y0 coordinate into double
                            if (entries.Length >= 9)
                            {
                                doubX1 = Double.Parse(stringX1); //converting x1 coordinate into double
                                doubY1 = Double.Parse(stringY1); //converting y1 coordinate into double
                                if (entries.Length >= 13)
                                {
                                    doubX2 = Double.Parse(stringX2); //converting x2 coordinate into double
                                    doubY2 = Double.Parse(stringY2); //converting y2 coordinate into double
                                    if (entries.Length >= 17)
                                    {
                                        doubX3 = Double.Parse(stringX3); //converting x3 coordinate into double
                                        doubY3 = Double.Parse(stringY3); //converting y3 coordinate into double
                                        if (entries.Length >= 21)
                                        {
                                            doubX4 = Double.Parse(stringX4); //converting x4 coordinate into double
                                            doubY4 = Double.Parse(stringY4); //converting y4 coordinate into double
                                            if (entries.Length >= 25)
                                            {
                                                doubX5 = Double.Parse(stringX5); //converting x5 coordinate into double
                                                doubY5 = Double.Parse(stringY5); //converting y5 coordinate into double
                                                if (entries.Length >= 29)
                                                {
                                                    doubX6 = Double.Parse(stringX6); //converting x6 coordinate into double
                                                    doubY6 = Double.Parse(stringY6); //converting y6 coordinate into double
                                                    if (entries.Length >= 33)
                                                    {
                                                        doubX7 = Double.Parse(stringX7); //converting x7 coordinate into double
                                                        doubY7 = Double.Parse(stringY7); //converting y7 coordinate into double
                                                        if (entries.Length >= 37)
                                                        {
                                                            doubX8 = Double.Parse(stringX8); //converting x8 coordinate into double
                                                            doubY8 = Double.Parse(stringY8); //converting y8 coordinate into double
                                                            if (entries.Length >= 41)
                                                            {
                                                                doubX9 = Double.Parse(stringX9); //converting x9 coordinate into double
                                                                doubY9 = Double.Parse(stringY9); //converting y9 coordinate into double
                                                                if (entries.Length >= 45)
                                                                {
                                                                    doubX10 = Double.Parse(stringX10); //converting x10 coordinate into double
                                                                    doubY10 = Double.Parse(stringY10); //converting y10 coordinate into double
                                                                    if (entries.Length >= 49)
                                                                    {
                                                                        doubX11 = Double.Parse(stringX11); //converting x11 coordinate into double
                                                                        doubY11 = Double.Parse(stringY11); //converting y11 coordinate into double
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }


                    polygoni++; //increment counter
                }
                line = sr.ReadLine();
            }
            line = sr.ReadLine();
            sr.Close();
        }
        //Static Point[] pol;
        private void button1_Click(object sender, EventArgs e)
        {
            upDownX0 = Convert.ToDouble(x0UpDown.Value); //converting X updown value to double once button is clicked 
            upDownY0 = Convert.ToDouble(y0UpDown.Value); //converting Y updown value to double once button is clicked
            upDownX1 = Convert.ToDouble(x1UpDown.Value); //converting X updown value to double once button is clicked 
            upDownY1 = Convert.ToDouble(y1UpDown.Value); //converting Y updown value to double once button is clicked
            upDownX2 = Convert.ToDouble(x2UpDown.Value); //converting X updown value to double once button is clicked 
            upDownY2 = Convert.ToDouble(y2UpDown.Value); //converting Y updown value to double once button is clicked
            upDownX3 = Convert.ToDouble(x3UpDown.Value); //converting X updown value to double once button is clicked 
            upDownY3 = Convert.ToDouble(y3UpDown.Value); //converting Y updown value to double once button is clicked
            upDownX4 = Convert.ToDouble(x4UpDown.Value); //converting X updown value to double once button is clicked 
            upDownY4 = Convert.ToDouble(y4UpDown.Value); //converting Y updown value to double once button is clicked
            upDownX5 = Convert.ToDouble(x5UpDown.Value); //converting X updown value to double once button is clicked 
            upDownY5 = Convert.ToDouble(y5UpDown.Value); //converting Y updown value to double once button is clicked
            upDownX6 = Convert.ToDouble(x6UpDown.Value); //converting X updown value to double once button is clicked 
            upDownY6 = Convert.ToDouble(y6UpDown.Value); //converting Y updown value to double once button is clicked
            upDownX7 = Convert.ToDouble(x7UpDown.Value); //converting X updown value to double once button is clicked 
            upDownY7 = Convert.ToDouble(y7UpDown.Value); //converting Y updown value to double once button is clicked
            upDownX8 = Convert.ToDouble(x8UpDown.Value); //converting X updown value to double once button is clicked 
            upDownY8 = Convert.ToDouble(y8UpDown.Value); //converting Y updown value to double once button is clicked
            upDownX9 = Convert.ToDouble(x9UpDown.Value); //converting X updown value to double once button is clicked 
            upDownY9 = Convert.ToDouble(y9UpDown.Value); //converting Y updown value to double once button is clicked
            upDownX10 = Convert.ToDouble(x10UpDown.Value); //converting X updown value to double once button is clicked 
            upDownY10 = Convert.ToDouble(y10UpDown.Value); //converting Y updown value to double once button is clicked
            upDownX11 = Convert.ToDouble(x11UpDown.Value); //converting X updown value to double once button is clicked 
            upDownY11 = Convert.ToDouble(y11UpDown.Value); //converting Y updown value to double once button is clicked 

            //upDownLength = Convert.ToDouble(x2UpDown.Value); //converting side length updown value to double once button is clicked
            //Area = (Double)lengthUpDown.Value * (Double)lengthUpDown.Value; //squares side length
            //Perimeter = (Double)lengthUpDown.Value * 4; //multiplies side length by 4

            //areaLabel.Text = Area.ToString(); //sets area label to area value
            //perimeterLabel.Text = Perimeter.ToString(); //sets perimeter label to perimeter value

            Graphics g = this.CreateGraphics();
            if (entries.Length == 5)
            {
                Point[] pol =
                              {
                new Point((int)upDownX0, (int)upDownY0),
            };
                if (polygonForm.polygonColor == "Blue")
                {
                    Pen p = new Pen(Color.Blue, 3);
                    g.DrawPolygon(p, pol); //draws shape in blue
                }
                else if (polygonForm.polygonColor == "Green")
                {
                    Pen p = new Pen(Color.Green, 3);
                    g.DrawPolygon(p, pol); //draws shape in green
                }
                else if (polygonForm.polygonColor == "Yellow")
                {
                    Pen p = new Pen(Color.Yellow, 3);
                    g.DrawPolygon(p, pol); //draws shape in yellow
                }
                else
                {
                    Pen p = new Pen(Color.Red, 3);
                    g.DrawPolygon(p, pol); //draws shape in red if no other value is selected
                }
            }
            else if (entries.Length == 9)
            {
                Point[] pol =
                              {
                new Point((int)upDownX0, (int)upDownY0),
                new Point((int)upDownX1, (int)upDownY1),
            };
                if (polygonForm.polygonColor == "Blue")
                {
                    Pen p = new Pen(Color.Blue, 3);
                    g.DrawPolygon(p, pol); //draws shape in blue
                }
                else if (polygonForm.polygonColor == "Green")
                {
                    Pen p = new Pen(Color.Green, 3);
                    g.DrawPolygon(p, pol); //draws shape in green
                }
                else if (polygonForm.polygonColor == "Yellow")
                {
                    Pen p = new Pen(Color.Yellow, 3);
                    g.DrawPolygon(p, pol); //draws shape in yellow
                }
                else
                {
                    Pen p = new Pen(Color.Red, 3);
                    g.DrawPolygon(p, pol); //draws shape in red if no other value is selected
                }
            }
            else if (entries.Length == 13)
            {
                Point[] pol =
                              {
                new Point((int)upDownX0, (int)upDownY0),
                new Point((int)upDownX1, (int)upDownY1),
                new Point((int)upDownY2, (int)upDownY2),
            };
                if (polygonForm.polygonColor == "Blue")
                {
                    Pen p = new Pen(Color.Blue, 3);
                    g.DrawPolygon(p, pol); //draws shape in blue
                }
                else if (polygonForm.polygonColor == "Green")
                {
                    Pen p = new Pen(Color.Green, 3);
                    g.DrawPolygon(p, pol); //draws shape in green
                }
                else if (polygonForm.polygonColor == "Yellow")
                {
                    Pen p = new Pen(Color.Yellow, 3);
                    g.DrawPolygon(p, pol); //draws shape in yellow
                }
                else
                {
                    Pen p = new Pen(Color.Red, 3);
                    g.DrawPolygon(p, pol); //draws shape in red if no other value is selected
                }
            }
            else if (entries.Length == 17)
            {
                Point[] pol =
                              {
                new Point((int)upDownX0, (int)upDownY0),
                new Point((int)upDownX1, (int)upDownY1),
                new Point((int)upDownY2, (int)upDownY2),
                new Point((int)upDownY3, (int)upDownY3),
            };
                if (polygonForm.polygonColor == "Blue")
                {
                    Pen p = new Pen(Color.Blue, 3);
                    g.DrawPolygon(p, pol); //draws shape in blue
                }
                else if (polygonForm.polygonColor == "Green")
                {
                    Pen p = new Pen(Color.Green, 3);
                    g.DrawPolygon(p, pol); //draws shape in green
                }
                else if (polygonForm.polygonColor == "Yellow")
                {
                    Pen p = new Pen(Color.Yellow, 3);
                    g.DrawPolygon(p, pol); //draws shape in yellow
                }
                else
                {
                    Pen p = new Pen(Color.Red, 3);
                    g.DrawPolygon(p, pol); //draws shape in red if no other value is selected
                }
            }
            else if (entries.Length == 21)
            {
                Point[] pol =
                              {
                new Point((int)upDownX0, (int)upDownY0),
                new Point((int)upDownX1, (int)upDownY1),
                new Point((int)upDownY2, (int)upDownY2),
                new Point((int)upDownY3, (int)upDownY3),
                new Point((int)upDownY4, (int)upDownY4),
            };
                if (polygonForm.polygonColor == "Blue")
                {
                    Pen p = new Pen(Color.Blue, 3);
                    g.DrawPolygon(p, pol); //draws shape in blue
                }
                else if (polygonForm.polygonColor == "Green")
                {
                    Pen p = new Pen(Color.Green, 3);
                    g.DrawPolygon(p, pol); //draws shape in green
                }
                else if (polygonForm.polygonColor == "Yellow")
                {
                    Pen p = new Pen(Color.Yellow, 3);
                    g.DrawPolygon(p, pol); //draws shape in yellow
                }
                else
                {
                    Pen p = new Pen(Color.Red, 3);
                    g.DrawPolygon(p, pol); //draws shape in red if no other value is selected
                }
            }
            else if (entries.Length == 25)
            {
                Point[] pol =
                              {
                new Point((int)upDownX0, (int)upDownY0),
                new Point((int)upDownX1, (int)upDownY1),
                new Point((int)upDownY2, (int)upDownY2),
                new Point((int)upDownY3, (int)upDownY3),
                new Point((int)upDownY4, (int)upDownY4),
                new Point((int)upDownY5, (int)upDownY5),
            };
                if (polygonForm.polygonColor == "Blue")
                {
                    Pen p = new Pen(Color.Blue, 3);
                    g.DrawPolygon(p, pol); //draws shape in blue
                }
                else if (polygonForm.polygonColor == "Green")
                {
                    Pen p = new Pen(Color.Green, 3);
                    g.DrawPolygon(p, pol); //draws shape in green
                }
                else if (polygonForm.polygonColor == "Yellow")
                {
                    Pen p = new Pen(Color.Yellow, 3);
                    g.DrawPolygon(p, pol); //draws shape in yellow
                }
                else
                {
                    Pen p = new Pen(Color.Red, 3);
                    g.DrawPolygon(p, pol); //draws shape in red if no other value is selected
                }
            }
            else if (entries.Length == 29)
            {
                Point[] pol =
                              {
                new Point((int)upDownX0, (int)upDownY0),
                new Point((int)upDownX1, (int)upDownY1),
                new Point((int)upDownY2, (int)upDownY2),
                new Point((int)upDownY3, (int)upDownY3),
                new Point((int)upDownY4, (int)upDownY4),
                new Point((int)upDownY5, (int)upDownY5),
                new Point((int)upDownY6, (int)upDownY6),
            };
                if (polygonForm.polygonColor == "Blue")
                {
                    Pen p = new Pen(Color.Blue, 3);
                    g.DrawPolygon(p, pol); //draws shape in blue
                }
                else if (polygonForm.polygonColor == "Green")
                {
                    Pen p = new Pen(Color.Green, 3);
                    g.DrawPolygon(p, pol); //draws shape in green
                }
                else if (polygonForm.polygonColor == "Yellow")
                {
                    Pen p = new Pen(Color.Yellow, 3);
                    g.DrawPolygon(p, pol); //draws shape in yellow
                }
                else
                {
                    Pen p = new Pen(Color.Red, 3);
                    g.DrawPolygon(p, pol); //draws shape in red if no other value is selected
                }
            }
            else if (entries.Length == 33)
            {
                Point[] pol =
                              {
                new Point((int)upDownX0, (int)upDownY0),
                new Point((int)upDownX1, (int)upDownY1),
                new Point((int)upDownY2, (int)upDownY2),
                new Point((int)upDownY3, (int)upDownY3),
                new Point((int)upDownY4, (int)upDownY4),
                new Point((int)upDownY5, (int)upDownY5),
                new Point((int)upDownY6, (int)upDownY6),
                new Point((int)upDownY7, (int)upDownY7),
            };
                if (polygonForm.polygonColor == "Blue")
                {
                    Pen p = new Pen(Color.Blue, 3);
                    g.DrawPolygon(p, pol); //draws shape in blue
                }
                else if (polygonForm.polygonColor == "Green")
                {
                    Pen p = new Pen(Color.Green, 3);
                    g.DrawPolygon(p, pol); //draws shape in green
                }
                else if (polygonForm.polygonColor == "Yellow")
                {
                    Pen p = new Pen(Color.Yellow, 3);
                    g.DrawPolygon(p, pol); //draws shape in yellow
                }
                else
                {
                    Pen p = new Pen(Color.Red, 3);
                    g.DrawPolygon(p, pol); //draws shape in red if no other value is selected
                }
            }
            else if (entries.Length == 37)
            {
                Point[] pol =
                              {
                new Point((int)upDownX0, (int)upDownY0),
                new Point((int)upDownX1, (int)upDownY1),
                new Point((int)upDownY2, (int)upDownY2),
                new Point((int)upDownY3, (int)upDownY3),
                new Point((int)upDownY4, (int)upDownY4),
                new Point((int)upDownY5, (int)upDownY5),
                new Point((int)upDownY6, (int)upDownY6),
                new Point((int)upDownY7, (int)upDownY7),
                new Point((int)upDownY8, (int)upDownY8),
            };
                if (polygonForm.polygonColor == "Blue")
                {
                    Pen p = new Pen(Color.Blue, 3);
                    g.DrawPolygon(p, pol); //draws shape in blue
                }
                else if (polygonForm.polygonColor == "Green")
                {
                    Pen p = new Pen(Color.Green, 3);
                    g.DrawPolygon(p, pol); //draws shape in green
                }
                else if (polygonForm.polygonColor == "Yellow")
                {
                    Pen p = new Pen(Color.Yellow, 3);
                    g.DrawPolygon(p, pol); //draws shape in yellow
                }
                else
                {
                    Pen p = new Pen(Color.Red, 3);
                    g.DrawPolygon(p, pol); //draws shape in red if no other value is selected
                }
            }
            else if (entries.Length == 41)
            {
                Point[] pol =
                              {
                new Point((int)upDownX0, (int)upDownY0),
                new Point((int)upDownX1, (int)upDownY1),
                new Point((int)upDownY2, (int)upDownY2),
                new Point((int)upDownY3, (int)upDownY3),
                new Point((int)upDownY4, (int)upDownY4),
                new Point((int)upDownY5, (int)upDownY5),
                new Point((int)upDownY6, (int)upDownY6),
                new Point((int)upDownY7, (int)upDownY7),
                new Point((int)upDownY8, (int)upDownY8),
                new Point((int)upDownY9, (int)upDownY9),
            };
                if (polygonForm.polygonColor == "Blue")
                {
                    Pen p = new Pen(Color.Blue, 3);
                    g.DrawPolygon(p, pol); //draws shape in blue
                }
                else if (polygonForm.polygonColor == "Green")
                {
                    Pen p = new Pen(Color.Green, 3);
                    g.DrawPolygon(p, pol); //draws shape in green
                }
                else if (polygonForm.polygonColor == "Yellow")
                {
                    Pen p = new Pen(Color.Yellow, 3);
                    g.DrawPolygon(p, pol); //draws shape in yellow
                }
                else
                {
                    Pen p = new Pen(Color.Red, 3);
                    g.DrawPolygon(p, pol); //draws shape in red if no other value is selected
                }
            }
            else if (entries.Length == 45)
            {
                Point[] pol =
                              {
                new Point((int)upDownX0, (int)upDownY0),
                new Point((int)upDownX1, (int)upDownY1),
                new Point((int)upDownY2, (int)upDownY2),
                new Point((int)upDownY3, (int)upDownY3),
                new Point((int)upDownY4, (int)upDownY4),
                new Point((int)upDownY5, (int)upDownY5),
                new Point((int)upDownY6, (int)upDownY6),
                new Point((int)upDownY7, (int)upDownY7),
                new Point((int)upDownY8, (int)upDownY8),
                new Point((int)upDownY9, (int)upDownY9),
                new Point((int)upDownY10, (int)upDownY10),
            };
                if (polygonForm.polygonColor == "Blue")
                {
                    Pen p = new Pen(Color.Blue, 3);
                    g.DrawPolygon(p, pol); //draws shape in blue
                }
                else if (polygonForm.polygonColor == "Green")
                {
                    Pen p = new Pen(Color.Green, 3);
                    g.DrawPolygon(p, pol); //draws shape in green
                }
                else if (polygonForm.polygonColor == "Yellow")
                {
                    Pen p = new Pen(Color.Yellow, 3);
                    g.DrawPolygon(p, pol); //draws shape in yellow
                }
                else
                {
                    Pen p = new Pen(Color.Red, 3);
                    g.DrawPolygon(p, pol); //draws shape in red if no other value is selected
                }
            }
            else if (entries.Length == 49)
            {
                Point[] pol =
                              {
                new Point((int)upDownX0, (int)upDownY0),
                new Point((int)upDownX1, (int)upDownY1),
                new Point((int)upDownY2, (int)upDownY2),
                new Point((int)upDownY3, (int)upDownY3),
                new Point((int)upDownY4, (int)upDownY4),
                new Point((int)upDownY5, (int)upDownY5),
                new Point((int)upDownY6, (int)upDownY6),
                new Point((int)upDownY7, (int)upDownY7),
                new Point((int)upDownY8, (int)upDownY8),
                new Point((int)upDownY9, (int)upDownY9),
                new Point((int)upDownY10, (int)upDownY10),
                new Point((int)upDownY11, (int)upDownY11)
            };
                if (polygonForm.polygonColor == "Blue")
                {
                    Pen p = new Pen(Color.Blue, 3);
                    g.DrawPolygon(p, pol); //draws shape in blue
                }
                else if (polygonForm.polygonColor == "Green")
                {
                    Pen p = new Pen(Color.Green, 3);
                    g.DrawPolygon(p, pol); //draws shape in green
                }
                else if (polygonForm.polygonColor == "Yellow")
                {
                    Pen p = new Pen(Color.Yellow, 3);
                    g.DrawPolygon(p, pol); //draws shape in yellow
                }
                else
                {
                    Pen p = new Pen(Color.Red, 3);
                    g.DrawPolygon(p, pol); //draws shape in red if no other value is selected
                }
            }
           



            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            savePolygon sp = new savePolygon();
            sp.Show(); //open next form
            this.Hide(); //close this form
        }
    }
}
