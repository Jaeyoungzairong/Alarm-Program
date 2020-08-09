using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AlarmProgram
{
    public partial class MainForm : Form
    {
        private Thread m_Thread;

        public MainForm()
        {
            InitializeComponent();

            this.Size = new System.Drawing.Size(540, 200); //Minimum Size로 MainForm을 시작한다
            //this.Size = new System.Drawing.Size(540, 580); //Maximum Size로 MainForm을 시작한다.

            m_Thread = new Thread(new ThreadStart(ThreadProc));
            m_Thread.Start();
        }

        private void ThreadProc()
        {
            while (true)
            {
                string Day = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + " " + DateTime.Now.DayOfWeek.ToString();
                string Time = DateTime.Now.ToString("tt hh:mm:ss", new System.Globalization.CultureInfo("en-US"));
                //string Time = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
                UpdateTimer(Day, Time); //현재시간을 표시
                UpdateDisplayStatus(); //화면상태를 표시
                UpdateAlarmDataStatus(); //알람상태를 검사
            }
        }

        private void UpdateTimer(string Day, string Time)
        {
            if (this.InvokeRequired)
            {
                DelVoid_String2 del = new DelVoid_String2(UpdateTimer);
                this.Invoke(del, Day, Time);
            }
            else
            {
                ucTimer1.lbDate.Text = Day;
                ucTimer1.lbTime.Text = Time;
            }
        }

        private void UpdateDisplayStatus()
        {
            if (GV.UpdateDisplayStatus != DispayStatus.None)
            {
                if (this.InvokeRequired)
                {
                    DelVoid_Void del = new DelVoid_Void(UpdateDisplayStatus);
                    this.Invoke(del);
                }
                else
                {
                    if (GV.UpdateDisplayStatus == DispayStatus.Config)
                    {
                        ucConfig1.Show();
                        ucSetting1.Hide();
                        ucAlarm1.Hide();
                    }
                    else if (GV.UpdateDisplayStatus == DispayStatus.Setting)
                    {
                        ucConfig1.Hide();
                        ucSetting1.Show();
                        ucAlarm1.Hide();
                    }
                    else if (GV.UpdateDisplayStatus == DispayStatus.Alarm)
                    {
                        ucConfig1.Hide();
                        ucSetting1.Hide();
                        ucAlarm1.Show();

                        //알람 진행시 Form의 Size 및 활성화 설정 
                        this.Size = new Size(540, 580);
                        lbMaximun.Visible = false;
                        this.WindowState = FormWindowState.Normal; 
                    }
                }
                GV.UpdateDisplayStatus = DispayStatus.None;
            }
        }

        private void UpdateAlarmDataStatus()
        {
            if (GV.UpdateData)
            {
                if (this.InvokeRequired)
                {
                    DelVoid_Void del = new DelVoid_Void(UpdateAlarmDataStatus);
                    this.Invoke(del);
                }
                else
                {
                    ucConfig1.UpdateListView();  
                }
                GV.UpdateData = false;
            }

            try
            {
                var list = AlarmDataManager.Instance.m_AlarmDataList;
                for (int i = 0; i < list.Count; i++)
                {
                    bool Check = list[i].AlarmOn;
                    Check &= DateTime.Now.Hour == list[i].Hour ? true : false;
                    Check &= DateTime.Now.Minute == list[i].Minute == true ? true : false;
                    Check &= DateTime.Now.Second < 1 ? true : false;
                    Check &= GV.UpdateAlarmStatus == AlarmStatus.Off ? true : false;
                    if (Check)
                    {
                        GV.SelectedHour = list[i].Hour;
                        GV.SelectedMinute = list[i].Minute;
                        GV.SelectedMusic = list[i].MusicPath;
                        GV.SelectedAlarmDuration = list[i].AlarmDuration;
                        GV.UpdateAlarmStatus = AlarmStatus.On;
                        GV.UpdateDisplayStatus = DispayStatus.Alarm;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void LbMaximun_Click(object sender, EventArgs e)
        {
            this.Size = new Size(540, 580);
            lbMaximun.Visible = false;
        }

        private void LbMinimum_Click(object sender, EventArgs e)
        {
            this.Size = new Size(540, 200);
            lbMaximun.Visible = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_Thread.Abort();
        }
    }
}
