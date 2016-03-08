using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Sleep_Timer
{
    public partial class SleepTimer : Form
    {
        private int counter = 0;
        private Timer timer;
        public SleepTimer()
        {
            InitializeComponent();
            this.cancelBtn.Visible = false;
        }

        private void sleepBtn_Click(object sender, EventArgs e)
        {
            int time = GetTime();
            if (time <= 0)
            {
                return;
            }
            SleepFn(time);
            
            this.ToggleInputFileds(false);
            this.sleepBtn.Visible = false;
            this.cancelBtn.Visible = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            CancelTimer();
            this.ToggleInputFileds(true);
            this.sleepBtn.Visible = true;
            this.cancelBtn.Visible = false;
        }

        private void ToggleInputFileds( bool state )
        {
            this.hoursInput.Enabled = state;
            this.minutesField.Enabled = state;
            this.secondsField.Enabled = state;
        }  

        private int GetTime()
        {
            int seconds = (int) this.secondsField.Value;
            int minutesToSeconds = (int)this.minutesField.Value * 60;
            int hoursToSeconds = (int)this.hoursInput.Value * 3600;

            var time = seconds + minutesToSeconds + hoursToSeconds;
            return time;
        }
        
        private void SleepFn(int time)
        {
           
            if (time <=0)
            {
                return ;
            }
            counter = time;

            timer = new Timer();
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = 1000; // 1 second
            timer.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;

            if (counter == 0)
            {
                CancelTimer();
                Application.SetSuspendState(PowerState.Suspend, true, true);
                //Environment.Exit(0);
            }

            TimeSpan ts = TimeSpan.FromSeconds(counter);

            this.secondsField.Value = ts.Seconds;
            this.minutesField.Value = ts.Minutes;
            this.hoursInput.Value = ts.Hours;
        }

        private void CancelTimer()
        {
            timer.Stop();
            timer.Dispose();
            timer = null;
            GC.Collect();
        }

        private void SleepTimerFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CancelTimer();
            System.Diagnostics.Process.Start("shutdown", "/a");
        }
    }
}
