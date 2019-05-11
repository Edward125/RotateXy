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




        private RotateFlag _ROTATE;
        private int _RBIT = 1;//计算结果保留位数



        /// <summary>
        /// 自定义坐标类
        /// </summary>
        public class pXY
        {
            public double X {set; get; }
            public double Y { set; get; }

        }


        public enum RotateFlag
        {
            EASTERN,   //逆时针
            CLOCKWISE  //顺时针

        }




        /// <summary>
        /// 将角度转换成弧度
        /// </summary>
        /// <param name="_angle"></param>
        private double  Angel2Pi(int angle)
        {
            double _angle = (double ) angle;
            return (angle / 180.0) * Math.PI;
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
            comboBit.SelectedIndex = 0;
            radEastern.Checked = true;
            _RBIT = comboBit.SelectedIndex + 1;


        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void panelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void btnCalcSingle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOldX.Text.Trim()))
                return;
            if (string.IsNullOrEmpty(txtOldY.Text.Trim()))
                return;
            if (string.IsNullOrEmpty(txtAngle.Text.Trim()))
                return;






         //   double radx = Angel2Pi(Convert.ToInt16(txtAngle.Text.Trim()));
            //double x1 = Convert.ToDouble(txtOldX.Text.Trim()) * Math.Cos(radx);
            //double x2 = Convert.ToDouble(txtOldY.Text.Trim()) * Math.Sin(radx);
            //double y1 = Convert.ToDouble(txtOldY.Text.Trim()) * Math.Cos(radx);
            //double y2 = Convert.ToDouble(txtOldX.Text.Trim()) * Math.Sin(radx);
            //txtNewX.Text = Math.Round((x1 - x2), 1).ToString();
            //txtNewY.Text = Math.Round((y1 + y2), 1).ToString();

            int Angle = Convert.ToInt16 (txtAngle.Text.Trim());
            pXY OldPxy = new pXY();
            OldPxy.X = Convert.ToDouble(txtOldX.Text.Trim());
            OldPxy.Y = Convert.ToDouble(txtOldY.Text.Trim());

            pXY NewPxy = CalcRoateXy(Angle, _ROTATE, OldPxy, _RBIT);
            txtNewX.Text = NewPxy.X.ToString();
            txtNewY.Text = NewPxy.Y.ToString();

        }



        /// <summary>
        /// 计算旋转后的新坐标
        /// </summary>
        /// <param name="angle"></param>
        /// <param name="rotate"></param>
        /// <param name="oldpxy"></param>
        /// <returns></returns>
        private pXY CalcRoateXy(int angle, RotateFlag rotate, pXY oldpxy,int rbit)
        {
            pXY newpxy = new pXY();
            double radx = Angel2Pi(angle);
            double x1 = oldpxy.X * Math.Cos(radx);
            double x2 = oldpxy.Y * Math.Sin(radx);

            double y1 = oldpxy.Y * Math.Cos(radx);
            double y2 = oldpxy.X * Math.Sin(radx);
            if (rotate == RotateFlag.EASTERN)
            {
                newpxy.X = Math.Round((x1 - x2),rbit);
                newpxy.Y = Math.Round((y1 + y2),rbit);
            }

            if (rotate == RotateFlag.CLOCKWISE)
            {
                newpxy.X = Math.Round((x1 + x2), rbit);
                newpxy.Y = Math.Round((y1 - y2), rbit);
            }



            return newpxy;
        }

        private void radEastern_CheckedChanged(object sender, EventArgs e)
        {
            if (radEastern.Checked)
                _ROTATE = RotateFlag.EASTERN;
            if (radClockwise.Checked)
                _ROTATE = RotateFlag.CLOCKWISE;
        }

        private void radClockwise_CheckedChanged(object sender, EventArgs e)
        {
            if (radClockwise.Checked)
                _ROTATE = RotateFlag.CLOCKWISE;
            if (radEastern.Checked)
                _ROTATE = RotateFlag.EASTERN;
        }

        private void comboBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            _RBIT = comboBit.SelectedIndex + 1;
        }

        private void btnCopyNew_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty (txtNewX.Text)  && !string.IsNullOrEmpty (txtNewY.Text))
                Clipboard.SetDataObject(txtNewX.Text + "," + txtNewY.Text);
        }
    }
}
