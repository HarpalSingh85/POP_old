using System;
using System.Windows.Forms;
using System.Diagnostics;



namespace popup
{
    public partial class Form1 : Form
    {

        #region Properties and variables
        public int _i { get; set; }
        public int i { get; set; }
        public int _count { get; set; }
        private string _builder { get; set; }
        private int _limit = 3;
        
        public int _orgtme { get; private set; }

        private int _progmaxval { get; set; }

        private int _h = 0, _m = 0, _s = 0;

        private int S
        {
            get { return _s; }
            set { _s = value; }
        }
        private int M
        {
            get { return _m; }
            set { _m = value; }
        }
        private int H
        {
            get { return _h; }
            set { _h = value; }
        }

        #endregion

        #region Mainfrom

        public Form1()
        {
            InitializeComponent();
            Timer.Enabled = true;
            Timer.Interval = 1000;
            //Timer.Tick += Timer_Tick;
            Timer.Tick += UpdateProgress;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            TimerUpdate();
            lblnm.Text = "Pulse Secure 5.3 has been installed on this system. \r\nPlease restart to complete the installation.";
           _countClick();
           this.Focus();
           this.BringToFront();
                      
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown || e.CloseReason == CloseReason.ApplicationExitCall )
            {
                return;
            }
            e.Cancel = true;

            this.Hide();
            _trayNotify("Restart Computer", "Restart your computer to complete installation");

        }

        #endregion

        #region Timers

       private void Timer_Tick(object sender, EventArgs e)
        {

            S -=1;
            
            _orgtme--;

            if (S == -1)
            {
                M -= 1;
                S = 59;
            }

            if (M == -1)
            {
                H -= 1;
                M = 59;
            }

            if (H == -1)
            {
                H = 0;
            }


            //Invoke Before 15 mins remaining

            if (H == 0 && M == 15 && S == 0)
            {
                Show();

                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.Focus();
                    this.BringToFront();
                    trayNt.Visible = false;
                }


            }

            //Invoke Before 5 mins remaining

            if (H == 0 && M == 5 && S == 0)
            {
                Show();

                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.Focus();
                    this.BringToFront();
                    trayNt.Visible = false;
                }


            }

            //Invoke Before 1 min remaining

            if (H == 0 && M == 1 && S == 0)
            {
                Show();

                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.Focus();
                    this.BringToFront();
                    trayNt.Visible = false;
                }

            }

            if (H == 0 && M == 0 && S == 0)
            {
                Timer.Stop();
                restart();
            }

            TimerDisplay(H, M, S);

        }

        #endregion


        #region Button Events

        private void btnPostpone_Click(object sender, EventArgs e)
        {
            _countClick();
            TimerUpdate();
            this.Hide();
            _trayNotify("Restart Posponded","Computer restart have been postponded for next 60 minutes");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            _trayNotify("Restart Computer", "Restart your computer to complete installation");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            restart();
        }


        #endregion

        #region Tray Notification

        private void trayNt_BalloonTipClicked(object sender, EventArgs e)
        {
            Show();
            if (this.WindowState == FormWindowState.Minimized)


            {
                this.WindowState = FormWindowState.Normal;
                this.Focus();
                this.BringToFront();
            }

            trayNt.Visible = false;
        }

        private void _trayNotify(string _headertext, string _subject)
        {
            _i = 20;
            trayNt.Icon = popup.Properties.Resources.Tray;
            trayNt.Visible = true;
            trayNt.Text = _headertext;
            trayNt.ShowBalloonTip(_i, _headertext, _subject, ToolTipIcon.Warning);
        }

        private void trayNt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            if (this.WindowState == FormWindowState.Minimized)


            {
                this.WindowState = FormWindowState.Normal;
                this.Focus();
                this.BringToFront();
            }

            trayNt.Visible = false;
        }

        #endregion

        #region Methods

        private void restart()
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.FileName = "cmd";
            proc.WindowStyle = ProcessWindowStyle.Hidden;
            proc.Arguments = "/C shutdown /r /f /t 000 ";
            Process.Start(proc);
        }
        
        private void _countClick()
        {
                    
            label1.Text = "Reschedule Attempts Left : " + (_limit - _count).ToString();
            label2.Text = "Please ensure you save any documents you are currently working on before you select restart or postpone. Failure to do so could result in your documents being lost.";
            if (_count > 2)
            {
                btnPostpone.Enabled = false;
                label2.Text = "Please ensure you save any documents you are currently working on before you select restart. Failure to do so could result in your documents being lost.";
            }
            else
            {

                btnPostpone.Enabled = true;
            }
            _count++;
        }

        private void TimerDisplay(int H, int M, int S)
        {
            string hh = Convert.ToString(H.ToString("00"));
            string mm = Convert.ToString(M.ToString("00"));
            string ss = Convert.ToString(S.ToString("00"));

            lblDisplay.Text = hh + ":" + mm + ":" + ss;
            
        }

        public Tuple<int, int, int> ConvertTime(int orgtime)
        {
            int h = 0, m = 0, s = 0;

            if (_orgtme > 59 && _orgtme < 3559)
            {
                m = _orgtme / 60;

            }

            if (_orgtme > 3559)
            {
                h = _orgtme / 3600;
                m = (_orgtme % 3600) / 60;
            }

            return Tuple.Create(h, m, s);
        }

        private void TimerUpdate()
        {
            Timer.Stop();
                        
            _orgtme = 3600;
            var time = ConvertTime(_orgtme);

            H = time.Item1;
            M = time.Item2;
            S = time.Item3;

            TimerDisplay(H, M, S);


            _progress.Minimum = 0;
            _progmaxval = _orgtme;
            _progress.Maximum = _progmaxval;
            _progress.Value = 0;
            _progress.Refresh();
            Timer.Start();
        }

        private void UpdateProgress(object sender, EventArgs e)
        {
            _progress.Increment(1);
            if (_progress.Value == _progress.Maximum)
            { Timer.Stop(); }
        }

        #endregion
    }

}
