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
        
        
        public Form1()
        {
            InitializeComponent();
            lbTitle.Text = "La mia prima calcolatrice";
        }

       

        void acqVal()
        {
            val1 = double.Parse(tbInsert.Text);
            val2 = double.Parse(tbInsert2.Text);

        }

        

        private void Btn_Click(object sender, EventArgs e)
        {
            Button tmp = (Button)sender;
            acqVal();

            switch (tmp.Name)
            {
                case "btnSomma":
                    result = val1 + val2;

                    break;

                case "btnDivide":
                    result = val1 / val2;

                    break;

                case "btnSottrae":
                    result = val1 - val2;

                    break;

                case "btnMoltiplica":
                    result = val1 * val2;

                    break;

            }
            tbResult.Text = result.ToString();

        }

    }
}
