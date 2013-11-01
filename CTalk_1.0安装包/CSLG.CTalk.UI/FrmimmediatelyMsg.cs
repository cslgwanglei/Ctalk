using System;
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
    public partial class FrmimmediatelyMsg : Form
    {
        public FrmimmediatelyMsg()
        {
            InitializeComponent();
        }
        private Model.userInfo _me;
        private Model.userInfo _friend;
        private string _nickName;
        private FrmMain _frm;
        private List<RelFriendToFrmTalk> _ft;
        public FrmimmediatelyMsg(List<RelFriendToFrmTalk> ft, FrmMain frm, Model.userInfo me, Model.userInfo friend, string nickName)
        {
            InitializeComponent();
            this._me = me;
            this._friend = friend;
            this._nickName = nickName;
            this._frm = frm;
            this._ft = ft;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTalk frm = new FrmTalk(this._ft , this._frm , this._me ,this._friend , this._nickName );
            frm.Show();
            this.Close();
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

        private void FrmimmediatelyMsg_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Right - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;
            this.Location = new Point(x, y);//设置窗体在屏幕右下角显示  
            AnimateWindow(this.Handle, 1000, AW_SLIDE | AW_ACTIVE | AW_VER_NEGATIVE);
            this.label1.Text = this._friend.userName +"的即时消息！";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
