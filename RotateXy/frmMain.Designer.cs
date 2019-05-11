namespace RotateXy
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOldX = new System.Windows.Forms.TextBox();
            this.txtOldY = new System.Windows.Forms.TextBox();
            this.txtNewX = new System.Windows.Forms.TextBox();
            this.txtNewY = new System.Windows.Forms.TextBox();
            this.btnCalcSingle = new System.Windows.Forms.Button();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBit = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radClockwise = new System.Windows.Forms.RadioButton();
            this.radEastern = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCopyNew = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOldX
            // 
            this.txtOldX.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtOldX.Location = new System.Drawing.Point(92, 30);
            this.txtOldX.Name = "txtOldX";
            this.txtOldX.Size = new System.Drawing.Size(60, 22);
            this.txtOldX.TabIndex = 0;
            this.txtOldX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOldY
            // 
            this.txtOldY.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtOldY.Location = new System.Drawing.Point(92, 65);
            this.txtOldY.Name = "txtOldY";
            this.txtOldY.Size = new System.Drawing.Size(60, 22);
            this.txtOldY.TabIndex = 1;
            this.txtOldY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNewX
            // 
            this.txtNewX.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtNewX.Location = new System.Drawing.Point(231, 30);
            this.txtNewX.Name = "txtNewX";
            this.txtNewX.ReadOnly = true;
            this.txtNewX.Size = new System.Drawing.Size(60, 22);
            this.txtNewX.TabIndex = 2;
            this.txtNewX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNewY
            // 
            this.txtNewY.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.txtNewY.Location = new System.Drawing.Point(231, 64);
            this.txtNewY.Name = "txtNewY";
            this.txtNewY.ReadOnly = true;
            this.txtNewY.Size = new System.Drawing.Size(60, 22);
            this.txtNewY.TabIndex = 3;
            this.txtNewY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcSingle
            // 
            this.btnCalcSingle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(118)))), ((int)(((byte)(216)))));
            this.btnCalcSingle.FlatAppearance.BorderSize = 0;
            this.btnCalcSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcSingle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCalcSingle.ForeColor = System.Drawing.Color.White;
            this.btnCalcSingle.Location = new System.Drawing.Point(312, 17);
            this.btnCalcSingle.Name = "btnCalcSingle";
            this.btnCalcSingle.Size = new System.Drawing.Size(78, 35);
            this.btnCalcSingle.TabIndex = 4;
            this.btnCalcSingle.Text = "計算新坐標";
            this.btnCalcSingle.UseVisualStyleBackColor = false;
            this.btnCalcSingle.Click += new System.EventHandler(this.btnCalcSingle_Click);
            // 
            // txtAngle
            // 
            this.txtAngle.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngle.Location = new System.Drawing.Point(90, 130);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(39, 22);
            this.txtAngle.TabIndex = 7;
            this.txtAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(118)))), ((int)(((byte)(216)))));
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Controls.Add(this.lblClose);
            this.panelTitle.Controls.Add(this.lblMinimize);
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(571, 42);
            this.panelTitle.TabIndex = 8;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(12, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(154, 21);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "拼板坐標旋轉計算器";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblClose.Location = new System.Drawing.Point(527, 16);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(17, 19);
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            this.lblClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblClose_MouseMove);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMinimize.Location = new System.Drawing.Point(506, 15);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(15, 17);
            this.lblMinimize.TabIndex = 1;
            this.lblMinimize.Text = "_";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseLeave += new System.EventHandler(this.lblMinimize_MouseLeave);
            this.lblMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMinimize_MouseMove);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.comboBit);
            this.panelLeft.Controls.Add(this.label13);
            this.panelLeft.Controls.Add(this.label12);
            this.panelLeft.Controls.Add(this.label11);
            this.panelLeft.Controls.Add(this.label10);
            this.panelLeft.Controls.Add(this.radClockwise);
            this.panelLeft.Controls.Add(this.radEastern);
            this.panelLeft.Controls.Add(this.label9);
            this.panelLeft.Controls.Add(this.txtAngle);
            this.panelLeft.Location = new System.Drawing.Point(0, 42);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(162, 455);
            this.panelLeft.TabIndex = 9;
            this.panelLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(26, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "关于软件";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(26, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "查看原理";
            // 
            // comboBit
            // 
            this.comboBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBit.FormattingEnabled = true;
            this.comboBit.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBit.Location = new System.Drawing.Point(90, 196);
            this.comboBit.Name = "comboBit";
            this.comboBit.Size = new System.Drawing.Size(39, 22);
            this.comboBit.TabIndex = 13;
            this.comboBit.SelectedIndexChanged += new System.EventHandler(this.comboBit_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label13.Location = new System.Drawing.Point(25, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "保留位数";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(3, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "其  他";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(3, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "旋轉角度";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label10.Location = new System.Drawing.Point(25, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "输入角度";
            // 
            // radClockwise
            // 
            this.radClockwise.AutoSize = true;
            this.radClockwise.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radClockwise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.radClockwise.Location = new System.Drawing.Point(29, 63);
            this.radClockwise.Name = "radClockwise";
            this.radClockwise.Size = new System.Drawing.Size(97, 24);
            this.radClockwise.TabIndex = 19;
            this.radClockwise.Text = "顺时针旋转";
            this.radClockwise.UseVisualStyleBackColor = true;
            this.radClockwise.CheckedChanged += new System.EventHandler(this.radClockwise_CheckedChanged);
            // 
            // radEastern
            // 
            this.radEastern.AutoSize = true;
            this.radEastern.Checked = true;
            this.radEastern.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radEastern.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.radEastern.Location = new System.Drawing.Point(29, 33);
            this.radEastern.Name = "radEastern";
            this.radEastern.Size = new System.Drawing.Size(97, 24);
            this.radEastern.TabIndex = 13;
            this.radEastern.TabStop = true;
            this.radEastern.Text = "逆时针旋转";
            this.radEastern.UseVisualStyleBackColor = true;
            this.radEastern.CheckedChanged += new System.EventHandler(this.radEastern_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(3, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "旋轉方向";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.btnCopyNew);
            this.panelTop.Controls.Add(this.label7);
            this.panelTop.Controls.Add(this.label8);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.txtOldX);
            this.panelTop.Controls.Add(this.txtNewX);
            this.panelTop.Controls.Add(this.txtOldY);
            this.panelTop.Controls.Add(this.txtNewY);
            this.panelTop.Controls.Add(this.btnCalcSingle);
            this.panelTop.Location = new System.Drawing.Point(162, 45);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(409, 113);
            this.panelTop.TabIndex = 10;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // btnCopyNew
            // 
            this.btnCopyNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCopyNew.FlatAppearance.BorderSize = 0;
            this.btnCopyNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyNew.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCopyNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnCopyNew.Location = new System.Drawing.Point(312, 57);
            this.btnCopyNew.Name = "btnCopyNew";
            this.btnCopyNew.Size = new System.Drawing.Size(78, 35);
            this.btnCopyNew.TabIndex = 5;
            this.btnCopyNew.Text = "復制新坐標";
            this.btnCopyNew.UseVisualStyleBackColor = false;
            this.btnCopyNew.Click += new System.EventHandler(this.btnCopyNew_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label7.Location = new System.Drawing.Point(167, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "新坐標y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label8.Location = new System.Drawing.Point(167, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "新坐標x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label6.Location = new System.Drawing.Point(26, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "原坐標y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "單個坐標計算";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label5.Location = new System.Drawing.Point(26, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "原坐標x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(166, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "boardxy批量轉換";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(572, 497);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOldX;
        private System.Windows.Forms.TextBox txtOldY;
        private System.Windows.Forms.TextBox txtNewX;
        private System.Windows.Forms.TextBox txtNewY;
        private System.Windows.Forms.Button btnCalcSingle;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCopyNew;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radClockwise;
        private System.Windows.Forms.RadioButton radEastern;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

