using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace RotateXy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }








        /// <summary>
        /// 
        /// </summary>
        /// <param name="_angle"></param>
        private double  Angel2Pi(int angle)
        {
           
            double _angle = (double ) angle;



            return (angle / 180.0) * Math.PI;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty (textBox1.Text.Trim ()))
                return;
            if (string.IsNullOrEmpty (textBox2.Text.Trim ()))
                return;
            if (string.IsNullOrEmpty (textBox5.Text.Trim ()))
                return;

            double radx = Angel2Pi (Convert.ToInt16 ( textBox5.Text.Trim()));



            //textBox3.Text = Math.Sin(Math.PI / 6).ToString();

            //MessageBox.Show(Math.Sin ( radx).ToString ());

            //return;

            MessageBox.Show(Math.Cos(Math.PI/2).ToString());


            double x1 = Convert.ToDouble (textBox1.Text.Trim()) * Math.Cos(radx);
            double x2 = Convert.ToDouble(textBox2.Text.Trim()) * Math.Sin(radx);
            double y1 = Convert.ToDouble(textBox2.Text.Trim()) * Math.Cos(radx);
            double y2 = Convert.ToDouble(textBox1.Text.Trim()) * Math.Sin(radx);


            textBox3.Text = (x1-x2 ).ToString ();
            textBox4.Text = (y1 + y2).ToString();
           
        }
    }
}
