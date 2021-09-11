using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appcalc
{
    public partial class Form1 : Form
    {
        double val1, val2, result;
        List<Tasto> listMyButton = new List<Tasto>();
        string valInsert = "";
        string app1, app2, resultValue, funzione;
        public Form1()
        {
            InitializeComponent();
            lbTitle.Text = "La mia prima calcolatrice";

            listMyButton.Add(defineButton(43, 252, 76, 248, 42, 285, 76, 287, "AC ", true));
            listMyButton.Add(defineButton(105, 249, 144, 248, 106, 288, 142, 289, "+/-", true));
            listMyButton.Add(defineButton(172, 244, 208, 247, 171, 288, 206, 290, "%", true));
            listMyButton.Add(defineButton(237, 244, 273, 248, 237, 288, 269, 288, "/", true));
            listMyButton.Add(defineButton(40, 312, 79, 312, 40, 351, 77, 351, "7"));
            listMyButton.Add(defineButton(107, 311, 144, 312, 106, 352, 143, 351, "8"));
            listMyButton.Add(defineButton(172, 311, 209, 312, 171, 353, 207, 353, "9"));
            listMyButton.Add(defineButton(236, 313, 272, 313, 235, 351, 275, 350, "*", true));
            listMyButton.Add(defineButton(41, 377, 78, 377, 40, 415, 78, 417, "4"));
            listMyButton.Add(defineButton(105, 378, 146, 378, 107, 416, 144, 416, "5"));
            listMyButton.Add(defineButton(173, 376, 207, 376, 171, 416, 208, 417, "6"));
            listMyButton.Add(defineButton(236, 376, 272, 375, 236, 416, 274, 416, "-", true));
            listMyButton.Add(defineButton(42, 440, 79, 441, 41, 481, 78, 482, "1"));
            listMyButton.Add(defineButton(105, 440, 142, 441, 107, 480, 146, 479, "2"));
            listMyButton.Add(defineButton(171, 440, 209, 440, 172, 481, 209, 482, "3"));
            listMyButton.Add(defineButton(238, 440, 271, 440, 237, 482, 275, 479, "+", true));
            listMyButton.Add(defineButton(39, 503, 144, 504, 42, 547, 143, 547, "0"));
            listMyButton.Add(defineButton(169, 504, 206, 504, 172, 547, 209, 545, ","));
            listMyButton.Add(defineButton(235, 504, 273, 505, 235, 547, 273, 548, "=", true));

        }

        public bool contain(Point m)
        {
            for (int n = 0; n < listMyButton.Count; n++)
            {
                if (m.X > listMyButton[n].a.X && m.X < listMyButton[n].b.X && m.Y > listMyButton[n].a.Y && m.Y < listMyButton[n].c.Y)
                {
                    if (!listMyButton[n].tastoFunction)
                    {
                        bool checkVirgola = false;
                        char[] pippo = valInsert.ToCharArray();

                        for (int b = 0; b < pippo.Length; b++)
                        {
                            if (pippo[b] == ',' && listMyButton[n].funzione == ",")
                                checkVirgola = true;
                        }

                        if (!checkVirgola)
                            valInsert += listMyButton[n].funzione;

                        lbValue.Text = valInsert;

                    }
                    else
                    {
                        funzioni(listMyButton[n].funzione);
                    }
                    return true;
                }

            }
            return false;
        }
        public Tasto defineButton(int a_x, int a_y, int b_x, int b_y, int c_x, int c_y, int d_x, int d_y, string funzione, bool tastoFunction = false)
        {
            Point a = new Point(a_x, a_y);
            Point b = new Point(b_x, b_y);
            Point c = new Point(c_x, c_y);
            Point d = new Point(d_x, d_y);
            bool appfunct = tastoFunction;
            Tasto tmp = new Tasto(a, b, c, d, funzione, appfunct);
            return tmp;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs tmp = (MouseEventArgs)e;
            Point mioPunto = tmp.Location;
            string ciccio = mioPunto.X.ToString() + "," + mioPunto.Y.ToString();
            label2.Text = ciccio;
            label3.Text = contain(mioPunto).ToString();
            Clipboard.SetText(ciccio);
        }

        private void funzioni(string miaFunzione)
        {

            
            switch (miaFunzione)
            {
                case "AC":
                    app1 = "";
                    valInsert = "";
                    lbApp.Text = "";
                    lbValue.Text = "";

                    break;


                case "=":

                    calcola(funzione, double.Parse(app1), double.Parse(valInsert));

                    break;

                default:
                    funzione = miaFunzione;
                    app1 = valInsert;
                    valInsert = "";
                    lbApp.Text = app1;
                    lbValue.Text = "";
                    break;
            }

        }
        private void calcola(string function, double a, double b)
        {
            switch (function)
            {
                case "+":
                    lbApp.Text = "";
                    lbValue.Text = (a + b).ToString();

                    break;


                case "-":
                    lbApp.Text = "";
                    lbValue.Text = (a - b).ToString();

                    break;

                case "/":
                    lbApp.Text = "";
                    lbValue.Text = (a / b).ToString();

                    break;

                case "*":
                    lbApp.Text = "";
                    lbValue.Text = (a * b).ToString();
                    break;
            }


        }
    }
}
