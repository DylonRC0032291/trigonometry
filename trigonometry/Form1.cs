using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trigonometry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            
            {
                double Force = double.Parse(textBox1.Text);
                double a = double.Parse(textBox2.Text);

                double ans = Force * cos(a);
                label5.Text = ans.ToString();

                ans = Force * sin(a);
                label1.Text = ans.ToString();
                
            }
            catch
            {
                MessageBox.Show("wrong box idiot");
            }
        }

        double sin(double a)
        {
            double rad = a* Math.PI/ 180.0  ;
            return Math.Sin(rad);

           


        }

        double cos(double a)
        {
            double rad = a* Math.PI/ 180.0 ;
            return Math.Cos(rad);
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
