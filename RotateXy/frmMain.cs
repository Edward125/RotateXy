using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Edward;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;


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

        private  Dictionary<pXY, pXY> RotateXY = new Dictionary<pXY, pXY>();
        private List<pXY> OldXyList = new List<pXY>();
        private List<pXY> NewXyList = new List<pXY>();
        private BoardXyFileType _BoardXyFile;

        private bool IsRotating = false;


        public delegate void RotateFile();//定度委托
        /// <summary>
        /// 在线程上执行委托
        /// </summary>
        public void SetRotateFile()
        {
            this.Invoke(new RotateFile (Rotate));//在线程上执行指定的委托
        }


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
        /// board_xy类型,tebo ict，坐标一位小数点，agilent ict 坐标无小数点
        /// </summary>
        public enum BoardXyFileType
        {
            TEBO_ICT,
            AGILENT_ICT
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
            if (!IsRotating)
            {
                DialogResult dr = MessageBox.Show("是否確認退出軟件,退出點擊是(Y),不退出點擊否(N)?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        Environment.Exit(0);
                    }
                    catch (Exception)
                    {
                        
                    }
                   
                }
            }
               

          
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
            txtoldboardxy.SetWatermark("雙擊此處選擇boarxy文件.");
            progressBar1.Visible = false;
            lblPercent.Visible = false;
           // lblTitle.Text = "拼板坐標旋轉計算器,Ver:" + Application.ProductVersion;
            


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

        /// <summary>
        /// 计算旋转后的新坐标
        /// </summary>
        /// <param name="angle"></param>
        /// <param name="rotate"></param>
        /// <param name="oldpxy"></param>
        /// <returns></returns>
        private pXY CalcRoateXy(int angle, RotateFlag rotate, pXY oldpxy)
        {
            pXY newpxy = new pXY();
            double radx = Angel2Pi(angle);
            double x1 = oldpxy.X * Math.Cos(radx);
            double x2 = oldpxy.Y * Math.Sin(radx);

            double y1 = oldpxy.Y * Math.Cos(radx);
            double y2 = oldpxy.X * Math.Sin(radx);
            if (rotate == RotateFlag.EASTERN)
            {
                newpxy.X = Math.Round((x1 - x2), 0);
                newpxy.Y = Math.Round((y1 + y2), 0);
            }

            if (rotate == RotateFlag.CLOCKWISE)
            {
                newpxy.X = Math.Round((x1 + x2), 0);
                newpxy.Y = Math.Round((y1 - y2), 0);
            }



            return newpxy;
        }


        /// <summary>
        /// 判断这行文字是否含有坐标
        /// </summary>
        /// <param name="linestr"></param>
        /// <returns></returns>
        private bool IsLocationLine(string linestr)
        {
            string MatchFlag = @"[-0-9.]*, *[-0-9.]*";
            Match match = Regex.Match(linestr, MatchFlag);
            if (match.Success)
                return true;
            else
                return false;
        }




        /// <summary>
        /// 判断这行文字是否含有坐标，如果有就返回坐标
        /// </summary>
        /// <param name="linestr"></param>
        /// <param name="oldpxy"></param>
        /// <returns></returns>
        private bool IsLocationLine(string linestr,out pXY oldpxy)
        {
            oldpxy = new pXY();
            string MatchFlag = @"[-0-9.]*, *[-0-9.]*";
            if (linestr.StartsWith("!"))
                return false;
            Match match = Regex.Match(linestr, MatchFlag);
            if (match.Success)
            {
                string xystr = match.Groups[0].Value;
                string x = xystr.Split(',')[0];
                string y = xystr.Split(',')[1];
                //if (y.Contains(","))
                //    y = y.Replace(",", "");
                //if (y.Contains(";"))
                //    y = y.Replace(";", "");
                oldpxy.X = Convert.ToDouble(x);
                oldpxy.Y = Convert.ToDouble(y);

                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="linestr"></param>
        /// <param name="oldxy"></param>
        /// <param name="newxy"></param>
        /// <returns></returns>
        private string ReplaceOldXy2NewXy(string linestr, pXY newxy)
        {
            string MatchFlag = @"[-0-9.]*, *[-0-9.]*";
            if (linestr.StartsWith("!"))
                return linestr;
            Match match = Regex.Match(linestr, MatchFlag);
            if (match.Success)
            {
                string xystr = match.Groups[0].Value;
                linestr = linestr.Replace(xystr, newxy.X.ToString() + "," + newxy.Y.ToString().PadLeft(8, ' '));
            }
            return linestr;
        }

        /// <summary>
        /// 更新信息到listbox中
        /// </summary>
        /// <param name="listbox">listbox name</param>
        /// <param name="message">message</param>
        public static void updateMessage(ListBox listbox, string message)
        {
            if (listbox.Items.Count > 1000)
                listbox.Items.RemoveAt(0);

            string item = string.Empty;
            //listbox.Items.Add("");
            item = DateTime.Now.ToString("HH:mm:ss") + " " + @message;
            listbox.Items.Add(item);
            if (listbox.Items.Count > 1)
            {
                listbox.TopIndex = listbox.Items.Count - 1;
                listbox.SetSelected(listbox.Items.Count - 1, true);
            }
        }



        /// <summary>
        /// 返回文本行数
        /// </summary>
        /// <param name="FilePath"></param>
        /// <returns></returns>

        public int GetRows(string FilePath)
        {
            using (StreamReader read = new StreamReader(FilePath, Encoding.Default))
            {
                return read.ReadToEnd().Split('\n').Length;
            }
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

        private void txtoldboardxy_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog()  == DialogResult.OK)
                txtoldboardxy.Text = openfile.FileName;
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {

            //Rotate();
            Thread r = new Thread(new ThreadStart(SetRotateFile));
            r.Start();
        }




        private  void Rotate()
        {
            IsRotating = true;
            if (string.IsNullOrEmpty(txtoldboardxy.Text.Trim()))
            {
                updateMessage(lstMsg, "請選擇boardxy文件.");
                txtoldboardxy.Focus();
                IsRotating = false;
                return;
            }

            FileInfo fi = new FileInfo(txtoldboardxy.Text.Trim());
            if (!fi.Exists)
            {
                updateMessage(lstMsg, fi.Name + "不存在.");
                txtoldboardxy.SelectAll();
                txtoldboardxy.Focus();
                IsRotating = false;
                return;
            }


            if (string.IsNullOrEmpty(txtAngle.Text.Trim()))
            {
                updateMessage(lstMsg, "旋轉角度不能為空.");
                txtAngle.Focus();
                IsRotating = false;
                return;
            }
            int Angle = Convert.ToInt16(txtAngle.Text.Trim());

            RotateXY.Clear();
            OldXyList.Clear();
            NewXyList.Clear();
            int Rows = GetRows(fi.FullName);
            progressBar1.Visible = true;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = Rows;
            string destboardxy = fi.FullName + @"." + Angle;
            StreamReader sr = new StreamReader(fi.FullName);
            StreamWriter sw = new StreamWriter(destboardxy);
            string line = string.Empty;
            int lines = 0;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                lines++;
                progressBar1.Value = lines;
                lblPercent.Visible = true;
                lblPercent.Text = (((double)lines) / ((double)Rows)).ToString("P2");

                pXY oldpxy = new pXY();

                if (IsLocationLine(line, out oldpxy))
                {
                    OldXyList.Add(oldpxy);
                    pXY NewPxy = CalcRoateXy(Angle, _ROTATE, oldpxy);
                    RotateXY.Add(oldpxy, NewPxy);
                  //  string nline = line.Replace(oldpxy.X.ToString(), NewPxy.X.ToString()).Replace(oldpxy.Y.ToString(), NewPxy.Y.ToString());
                    // nline = nline.Replace(oldpxy.Y.ToString(), NewPxy.Y.ToString());
                    string nline = ReplaceOldXy2NewXy(line, NewPxy);
                    sw.WriteLine(nline);
                }
                else
                    sw.WriteLine(line);
            }

            sw.Close();
            sr.Close();
            progressBar1.Visible = false;
            lblPercent.Visible = false;
            IsRotating = false;
            updateMessage(lstMsg, "新文件地址:" + destboardxy);
            updateMessage(lstMsg, "處理完畢...");
            System.Diagnostics.Process.Start(fi.DirectoryName);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.ShowDialog();
        }


    }
}
