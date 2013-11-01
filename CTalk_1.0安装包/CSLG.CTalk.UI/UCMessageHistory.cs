using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSLG.CTalk.UI
{
    public partial class UCMessageHistory : UserControl
    {
        public UCMessageHistory()
        {
            InitializeComponent();
        }

        private  string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value;
            this.lblMessage.Text = _message;
            }
        }
        private DateTime _time;

        public DateTime Time
        {
            get { return _time; }
            set { _time = value;
            }
        }
        private string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        private int _ucid;

        public int Ucid
        {
            get { return _ucid; }
            set { _ucid = value; }
        }
        private bool _me;

        public bool Me
        {
            get { return _me; }
            set { _me = value; }
        }
        private bool _isChosed;

        public bool IsChosed
        {
            get { return _isChosed; }
            set { _isChosed = value; }
        }
        private void UCMessageHistory_Load(object sender, EventArgs e)
        {
            if (Me )
            {
                this.lblTime.ForeColor = Color.Blue;
                this.lblTime.Text = this._username + " " + this._time.ToString(); 
            }
            else
            {
                this.lblTime.ForeColor = Color.Red;
                this.lblTime.Text = this._username + " " + this._time.ToString();
            }
        }
    }
}
