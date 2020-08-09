using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmProgram
{
    public class MusicData
    {
        private int m_No = 0; //번호
        private string m_MusicName = null; //알람음악 이름
        private string m_MusicPath = GV.StartupMusicPath; //알람음악 경로

        public MusicData(int No, string MusicName, string MusicPath)
        {
            m_No = No;
            m_MusicName = MusicName;
            m_MusicPath = MusicPath;
        }

        public int No
        {
            get { return m_No; }
            set { m_No = value; }
        }

        public string MusicName
        {
            get { return m_MusicName; }
            set { m_MusicName = value; }
        }

        public string MusicPath
        {
            get { return m_MusicPath; }
            set { m_MusicPath = value; }
        }
    }


}
