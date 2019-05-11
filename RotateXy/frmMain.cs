using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace RotateXy
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }



        #region 界面移动
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        #endregion











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
            if (string.IsNullOrEmpty (txtAngle.Text.Trim ()))
                return;

            double radx = Angel2Pi (Convert.ToInt16 ( txtAngle.Text.Trim()));



            //textBox3.Text = Math.Sin(Math.PI / 6).ToString();

            //MessageBox.Show(Math.Sin ( radx).ToString ());

            //return;

           // MessageBox.Show(Math.Cos(Math.PI/2).ToString());


            double x1 = Convert.ToDouble (textBox1.Text.Trim()) * Math.Cos(radx);
            double x2 = Convert.ToDouble(textBox2.Text.Trim()) * Math.Sin(radx);
            double y1 = Convert.ToDouble(textBox2.Text.Trim()) * Math.Cos(radx);
            double y2 = Convert.ToDouble(textBox1.Text.Trim()) * Math.Sin(radx);


            textBox3.Text = Math.Round((x1 - x2), 1).ToString();
            textBox4.Text = Math.Round((y1 + y2), 1).ToString();
           
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);

        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }


        private void lblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblMinimize_MouseLeave(object sender, EventArgs e)
        {
            lblMinimize.BackColor = Color.Transparent;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.Transparent;
        }

        private void lblMinimize_MouseMove(object sender, MouseEventArgs e)
        {
            lblMinimize.BackColor = Color.FromArgb(150, 200, 240);
        }

        private void lblClose_MouseMove(object sender, MouseEventArgs e)
        {
            lblClose.BackColor = Color.Red;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
    }
}
