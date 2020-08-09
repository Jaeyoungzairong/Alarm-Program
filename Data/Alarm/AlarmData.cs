using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmProgram
{
    [Serializable]
    public class AlarmData
    {
        private int m_No = 0; //알람번호
        private bool m_AlarmOn = false; //알람 ON/OFF
        private int m_Hour= 0; //시
        private int m_Minute = 0; //분
        private string m_MusicPath = GV.StartupMusicPath; //알람음악 경로
        private int m_AlarmDuration = 1; //알람 지속시간

        public AlarmData(int No ,bool AlarmOn, int Hour, int Minute, string MusicPath, int AlarmDuration)
        {
            m_No = No;
            m_AlarmDuration = AlarmDuration;
            m_AlarmOn = AlarmOn;
            m_Hour = Hour;
            m_Minute = Minute;
            m_MusicPath = MusicPath;
        }

        public int No
        {
            get { return m_No; }
            set { m_No = value; }
        }

        public bool AlarmOn
        {
            get { return m_AlarmOn; }
            set { m_AlarmOn = value; }
        }

        public int Hour
        {
            get { return m_Hour; }
            set { m_Hour = value; }
        }

        public int Minute
        {
            get { return m_Minute; }
            set { m_Minute = value; }
        }

        public string MusicPath
        {
            get { return m_MusicPath; }
            set { m_MusicPath = value; }
        }

        public int AlarmDuration
        {
            get { return m_AlarmDuration; }
            set { m_AlarmDuration = value; }
        }
    }
}
