using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmProgram
{
    public partial class ucAlarm : UserControl
    {
        private Timer m_Timer = new Timer();
        private Random m_Random = new Random();
        private AudioManager m_AudioManager;

        private int m_AlarmOffHour = 0;
        private int m_AlarmOffMinute = 0;
        private int m_DuarationTime = 0;

        public ucAlarm()
        {
            InitializeComponent();

            m_AudioManager = new AudioManager();

            //0.5초마다 Timer 이벤트가 작동
            m_Timer.Interval = 500;
            m_Timer.Tick += new EventHandler(Timer_Tick);
            m_Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (GV.UpdateAlarmStatus == AlarmStatus.Wait)
            {
                if (!m_AudioManager.NowPlaying())
                {
                    m_AudioManager.Initialize(GV.SelectedMusic);
                    m_AudioManager.Play();
                }

                //알람 지속시간동안 버튼을 누르지 않을 경우 자동적으로 알람을 해제한다.
                bool Check = true;
                Check &= DateTime.Now.Hour == m_AlarmOffHour ? true : false;
                Check &= DateTime.Now.Minute == m_AlarmOffMinute ? true : false;
                Check &= DateTime.Now.Second > 57 ? true : false;
                if (Check)
                {
                    GV.UpdateAlarmStatus = AlarmStatus.Off;
                    GV.UpdateDisplayStatus = DispayStatus.Config;
                }

                if (this.BackColor == Color.Black)
                {
                    this.BackColor = Color.DarkRed;
                    btnAlarmOff.BackColor = Color.DarkRed;
                }
                else if (this.BackColor == Color.DarkRed)
                {
                    this.BackColor = Color.DarkBlue;
                    btnAlarmOff.BackColor = Color.DarkBlue;
                }
                else if (this.BackColor == Color.DarkBlue)
                {
                    this.BackColor = Color.DarkOrange;
                    btnAlarmOff.BackColor = Color.DarkOrange;
                }
                else if (this.BackColor == Color.DarkOrange)
                {
                    this.BackColor = Color.DarkGreen;
                    btnAlarmOff.BackColor = Color.DarkGreen;
                }
                else
                {
                    this.BackColor = Color.Black;
                    btnAlarmOff.BackColor = Color.Black;
                }

                //int X = m_Random.Next(0, this.Size.Width - 100);
                //int Y = m_Random.Next(0, this.Size.Height - 100);
                //btnAlarmOff.Location = new Point(X, Y);
            }
            else if (GV.UpdateAlarmStatus == AlarmStatus.On)
            {
                //알람음악을 재생하고 알람상태를 Wait로 바꾼다
                if (GV.SelectedMusic == null)
                {
                    GV.UpdateAlarmStatus = AlarmStatus.Off;
                    GV.UpdateDisplayStatus = DispayStatus.Config;
                }
                else
                {
                    //알람 지속시간 계산
                    m_DuarationTime = GV.SelectedAlarmDuration - 1;
                    if (GV.SelectedMinute + m_DuarationTime > 59)
                    {
                        m_AlarmOffHour = GV.SelectedHour + 1;
                        m_AlarmOffMinute = m_DuarationTime - 1;
                    }
                    else
                    {
                        m_AlarmOffHour = GV.SelectedHour;
                        m_AlarmOffMinute = GV.SelectedMinute + m_DuarationTime;
                    }

                    GV.UpdateAlarmStatus = AlarmStatus.Wait;
                }

            }
            else if (GV.UpdateAlarmStatus == AlarmStatus.Off)
            {
                //음악 종료
                if (m_AudioManager.NowPlaying())
                {
                    m_AudioManager.Stop();
                }
            }
        }

        private void BtnAlarmOff_Click(object sender, EventArgs e)
        {
            //알람상태를 OFF로 바꾸고 화면을 Cofig창으로 전환한다.
            GV.UpdateAlarmStatus = AlarmStatus.Off;
            GV.UpdateDisplayStatus = DispayStatus.Config;
        }
    }
}
