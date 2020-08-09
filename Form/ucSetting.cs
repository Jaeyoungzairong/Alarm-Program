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
    public partial class ucSetting : UserControl
    {
        private AudioManager m_AudioManager;
        private DataHandler m_DataHandler;
        private OpenFileDialog m_OpenFileDialog;

        private readonly int[] m_DurationTime = { 1, 2, 3, 4, 5 };
        private string m_SelectedMusicPath = null;
        private int m_SelectedDurationTime = 1;

        public ucSetting()
        {
            InitializeComponent();
            
            m_AudioManager = new AudioManager();
            m_DataHandler = new DataHandler();
            m_OpenFileDialog = new OpenFileDialog();

            ComboBoxesInit();
        }

        private void ComboBoxesInit()
        {
            MusicDataManager.Instance.Read();

            cbMusic.Items.Clear();
            cbDurationTime.Items.Clear();

            foreach (MusicData data in MusicDataManager.Instance.m_MusicDataList)
            {
                cbMusic.Items.Add(data.MusicName);
            }

            for (int i = 0; i < m_DurationTime.Length; i++)
            {
                cbDurationTime.Items.Add(m_DurationTime[i].ToString() + " min");
            }
        }

        private bool CheckTimeDataOverlap(int Hour, int Minute)
        {
            bool DataOverlap = false;
            var list = AlarmDataManager.Instance.m_AlarmDataList;

            for (int i = 0; i < list.Count; i++)
            {
                DataOverlap = Hour == list[i].Hour ? true : false;
                DataOverlap &= Minute == list[i].Minute ? true : false;
                if (GV.SaveMode == SaveStatus.Modify)
                {
                    DataOverlap &= GV.SelectedNo != list[i].No ? true : false;
                }
                if (DataOverlap) break;
            }

            return DataOverlap;
        }

        private bool CheckMusicPath(string Path)
        {
            bool ErrorCheck = false;
            if (Path == null)
            {
                return ErrorCheck;
            }
            else
            {
                ErrorCheck = Path.Length > 5 ? true : false;
                ErrorCheck &= Path.Substring(Path.Length - 3, 3) == "mp3" ? true : false;

                return ErrorCheck;
            }
        }

        private int DurationTimeConverToIndex(int val)
        {
            int rv = 0;
            for (int i = 0; i < m_DurationTime.Length; i++)
            {
                if (m_DurationTime[i] == val) rv = i;
            }

            return rv;
        }

        private void LbMusicPlay_Click(object sender, EventArgs e)
        {
            if (m_AudioManager.NowPlaying())
            {
                lbTitle.Text = "MUSIC STOP";
                lbTitle.BackColor = Color.DarkOrange;
                lbMusicPlay.Image = AlarmProgram.Properties.Resources.motor_servo_on;
                m_AudioManager.Stop();
            }
            else
            {
                lbTitle.Text = "MUSIC START";
                lbTitle.BackColor = Color.DarkBlue;
                lbMusicPlay.Image = AlarmProgram.Properties.Resources.motor_stop;
                m_AudioManager.Initialize(m_SelectedMusicPath);
                m_AudioManager.Play();
            }
        }

        private void LbSave_Click(object sender, EventArgs e)
        {
            bool AlarmOn = cbAlarmON.Checked;
            bool AM = cbAM.Checked;
            int Hour = Convert.ToInt32(udHour.Value);
            int Minute = Convert.ToInt32(udMinute.Value);
            string MusicPath = m_SelectedMusicPath;
            int AlarmDuration = m_SelectedDurationTime;

            Hour = m_DataHandler.ConvertTo24H(AM, Hour);

            if (CheckTimeDataOverlap(Hour, Minute))
            {
                lbTitle.Text = "SAME TIME IS ALREADY EXIST";
                lbTitle.BackColor = Color.DarkRed;
            }
            else
            {
                if (CheckMusicPath(MusicPath))
                {
                    if (GV.SaveMode == SaveStatus.Add)
                    {
                        AlarmDataManager.Instance.Add(AlarmOn, Hour, Minute, MusicPath, AlarmDuration);
                    }
                    else if (GV.SaveMode == SaveStatus.Modify)
                    {
                        AlarmDataManager.Instance.Modify(AlarmOn, Hour, Minute, MusicPath, AlarmDuration);
                    }

                    GV.UpdateData = true;
                    GV.SaveMode = SaveStatus.None;
                    GV.UpdateDisplayStatus = DispayStatus.Config;
                }
                else
                {
                    lbTitle.Text = "MUSIC FORMAT ERROR";
                    lbTitle.BackColor = Color.DarkRed;
                }
            }  

            if (m_AudioManager.NowPlaying())
            {
                lbMusicPlay.Image = AlarmProgram.Properties.Resources.motor_servo_on;
                m_AudioManager.Stop();
            }
        }

        private void LbCancel_Click(object sender, EventArgs e)
        {
            if (m_AudioManager.NowPlaying())
            {
                lbMusicPlay.Image = AlarmProgram.Properties.Resources.motor_servo_on;
                m_AudioManager.Stop();
            }
            GV.SaveMode = SaveStatus.None;
            GV.UpdateDisplayStatus = DispayStatus.Config;
        }

        private void LbLoadMusic_Click(object sender, EventArgs e)
        {
            m_OpenFileDialog.InitialDirectory = GV.StartupMusicPath;
            m_OpenFileDialog.Filter = "MP3 File|*.mp3";
            m_OpenFileDialog.Multiselect = true;
            if (m_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                lbTitle.Text = "MUSIC UPLOAD COMPLETE";
                lbTitle.BackColor = Color.DarkGreen;
                MusicDataManager.Instance.SetData(m_OpenFileDialog.SafeFileNames, m_OpenFileDialog.FileNames);
                ComboBoxesInit();
            }
        }

        private void LbDataInit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Start Initializing Alarm Data", "Initialization", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AlarmDataManager.Instance.AlarmDataInit();
                GV.UpdateData = true;
                GV.SaveMode = SaveStatus.None;
                GV.UpdateDisplayStatus = DispayStatus.Config;
            }
        }

        private void UcSetting_VisibleChanged(object sender, EventArgs e)
        {
            if (GV.SaveMode == SaveStatus.Add)
            {
                cbAM.Checked = m_DataHandler.CheckAMPMToBool(DateTime.Now.Hour);
                udHour.Value = m_DataHandler.ConvertTo12H(DateTime.Now.Hour);
                udMinute.Value = DateTime.Now.Minute;
                cbAlarmON.Checked = true;
                cbMusic.SelectedIndex = 0;
                cbDurationTime.SelectedIndex = 0;
            }
            else if (GV.SaveMode == SaveStatus.Modify)
            {
                var list = AlarmDataManager.Instance.m_AlarmDataList;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].No == GV.SelectedNo)
                    {
                        if (list[i].AlarmOn) cbAlarmON.Checked = true;
                        else cbAlarmON.Checked = false;

                        cbAM.Checked = m_DataHandler.CheckAMPMToBool(list[i].Hour);
                        udHour.Value = m_DataHandler.ConvertTo12H(list[i].Hour);
                        udMinute.Value = list[i].Minute;

                        int index = MusicDataManager.Instance.MusicPathConvertToNo(list[i].MusicPath);
                        cbMusic.SelectedIndex = index;

                        index = DurationTimeConverToIndex(list[i].AlarmDuration);
                        cbDurationTime.SelectedIndex = index;
                    }
                }
            }

            if (cbAlarmON.Checked)
            {
                cbAlarmON.BackColor = Color.DarkGreen;
                cbAlarmON.Text = "ON";
            }
            else
            {
                cbAlarmON.BackColor = Color.DimGray;
                cbAlarmON.Text = "OFF";
            }

            if (GV.ProgramMode == AdminMode.Administrator)
            {
                lbTitle.Text = "ADMIN MODE ON";
                lbTitle.BackColor = Color.YellowGreen;
                LayoutAdminMode.Visible = true;
            }
            else
            {
                lbTitle.Text = "ALARM SETTING";
                lbTitle.BackColor = Color.DimGray;
                LayoutAdminMode.Visible = false;
            }
        }

        private void CbAlarmON_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAlarmON.Checked)
            {
                cbAlarmON.BackColor = Color.DarkGreen;
                cbAlarmON.Text = "ON";
            }
            else
            {
                cbAlarmON.BackColor = Color.DimGray;
                cbAlarmON.Text = "OFF";
            }
        }

        private void CbAM_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAM.Checked) cbAM.Text = "AM";
            else cbAM.Text = "PM";
        }

        private void CbMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbMusic.SelectedIndex;
            m_SelectedMusicPath = MusicDataManager.Instance.m_MusicDataList[index].MusicPath;
            tbMusicPath.Text = m_SelectedMusicPath;
        }

        private void CbDurationTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbDurationTime.SelectedIndex;
            m_SelectedDurationTime = m_DurationTime[index];
        }
    }
}
