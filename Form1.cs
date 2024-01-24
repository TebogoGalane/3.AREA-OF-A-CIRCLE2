using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.AREA_OF_A_CIRCLE2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Write("Enter Radius");
            double r;
            double PI = 3.14;
            double A;

            r = Convert.ToDouble(txtr.Text);
            A = 2 * PI * r;
            textBox2.Text = A.ToString();

            
           
            


        }
    }
}
