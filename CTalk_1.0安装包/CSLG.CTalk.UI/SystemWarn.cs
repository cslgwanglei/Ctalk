﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace CSLG.CTalk.UI
{
      

    public partial class SystemWarn : Form
    {
        public SystemWarn()
        {
            InitializeComponent();
        }
        private Model.friendRequest _friendrequest;
        private FrmMain _frm;
        public SystemWarn(Model.friendRequest m,FrmMain frm)
        {
            InitializeComponent();
            this._friendrequest = m;
            this._frm = frm;
        }
         [DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags); 
         private const int AW_HOR_POSITIVE = 0x0001;//自左向右显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志  
      private const int AW_HOR_NEGATIVE = 0x0002;//自右向左显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志  
       private const int AW_VER_POSITIVE = 0x0004;//自顶向下显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志  
      private const int AW_VER_NEGATIVE = 0x0008;//自下向上显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志该标志  
      private const int AW_CENTER = 0x0010;//若使用了AW_HIDE标志，则使窗口向内重叠；否则向外扩展  
       private const int AW_HIDE = 0x10000;//隐藏窗口  
       private const int AW_ACTIVE = 0x20000;//激活窗口，在使用了AW_HIDE标志后不要使用这个标志  
       private const int AW_SLIDE = 0x40000;//使用滑动类型动画效果，默认为滚动动画类型，当使用AW_CENTER标志时，这个标志就被忽略  
       private const int AW_BLEND = 0x80000;//使用淡入淡出效果  

        private void SystemWarn_Load(object sender, EventArgs e)
        {
             int x = Screen.PrimaryScreen.WorkingArea.Right - this.Width;  
          int y = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;  
           this.Location = new Point(x, y);//设置窗体在屏幕右下角显示  
           AnimateWindow(this.Handle, 1000, AW_SLIDE | AW_ACTIVE | AW_VER_NEGATIVE);

           this.lblwarn.Text = "您有"+this._friendrequest.senderID +"的好友请求！";
        }

        private void SystemWarn_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void SystemWarn_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimateWindow(this.Handle, 1000, AW_BLEND | AW_HIDE);  
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            FrmShowMSG frm = new FrmShowMSG(this._friendrequest ,this._frm );
            frm.Show();
            this.Close();
        }
    }
}
