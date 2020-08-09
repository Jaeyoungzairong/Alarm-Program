using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace AlarmProgram
{
    public class AlarmDataManager
    {
        public readonly static AlarmDataManager Instance = new AlarmDataManager();

        private string m_Path = Application.StartupPath + "\\AlarmData.xml"; //Xml Data 경로
        private XmlDocument m_XmlDocument;
        private DataHandler m_DataHandler;
        public List<AlarmData> m_AlarmDataList;

        public AlarmDataManager()
        {
            m_XmlDocument = new XmlDocument();
            m_DataHandler = new DataHandler();
            m_AlarmDataList = new List<AlarmData>();
        }

        public bool Read()
        {
            try
            {
                m_AlarmDataList.Clear();

                m_XmlDocument.Load(m_Path);
                m_XmlDocument.SelectNodes("/AlarmData");

                int NodeCount = m_XmlDocument.LastChild.ChildNodes.Count; //현대 Xml에 저장된 Alarm Data 개수

                int[] No = new int[NodeCount];
                bool[] AlarmOn = new bool[NodeCount];
                int[] Hour = new int[NodeCount];
                int[] Minute = new int[NodeCount];
                string[] MusicPath = new string[NodeCount];
                int[] AlarmDuration = new int[NodeCount];


                XmlNodeList[] NoList = new XmlNodeList[NodeCount];
                XmlNodeList[] HourList = new XmlNodeList[NodeCount];
                XmlNodeList[] MinuteList = new XmlNodeList[NodeCount];
                XmlNodeList[] AlarmOnList = new XmlNodeList[NodeCount];
                XmlNodeList[] MusicPathList = new XmlNodeList[NodeCount];
                XmlNodeList[] AlarmDurationList = new XmlNodeList[NodeCount];

                string path = "/AlarmData/Alarm";

                for (int i = 0; i < NodeCount; i++)
                {
                    NoList[i] = m_XmlDocument.SelectNodes(path + i.ToString() + "/No");
                    AlarmOnList[i] = m_XmlDocument.SelectNodes(path + i.ToString() + "/AlarmOn");
                    HourList[i] = m_XmlDocument.SelectNodes(path + i.ToString() + "/Hour");
                    MinuteList[i] = m_XmlDocument.SelectNodes(path + i.ToString() + "/Minute");
                    MusicPathList[i] = m_XmlDocument.SelectNodes(path + i.ToString() + "/MusicPath");
                    AlarmDurationList[i] = m_XmlDocument.SelectNodes(path + i.ToString() + "/AlarmDuration");

                    foreach (XmlNode tempNo in NoList[i]) No[i] = Convert.ToInt32(tempNo.InnerText);
                    foreach (XmlNode tempAlarmOn in AlarmOnList[i]) AlarmOn[i] = Convert.ToBoolean(tempAlarmOn.InnerText);
                    foreach (XmlNode tempHour in HourList[i]) Hour[i] = Convert.ToInt32(tempHour.InnerText);
                    foreach (XmlNode tempMinute in MinuteList[i]) Minute[i] = Convert.ToInt32(tempMinute.InnerText);
                    foreach (XmlNode tempMusicPath in MusicPathList[i]) MusicPath[i] = tempMusicPath.InnerText;
                    foreach (XmlNode tempAlarmDuration in AlarmDurationList[i]) AlarmDuration[i] = Convert.ToInt32(tempAlarmDuration.InnerText);

                    //AlarmData를 List로 만들어 관리한다
                    m_AlarmDataList.Add(new AlarmData(No[i], AlarmOn[i], Hour[i], Minute[i], MusicPath[i], AlarmDuration[i]));
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool Write()
        {
            try
            {
                XmlTextWriter m_textWriter = new XmlTextWriter(m_Path, Encoding.UTF8);
                m_textWriter.Formatting = Formatting.Indented;
                m_textWriter.WriteStartDocument();
                m_textWriter.WriteStartElement("AlarmData");

                for (int i = 0; i < m_AlarmDataList.Count; i++)
                {
                    m_textWriter.WriteStartElement("Alarm" + i.ToString());
                    m_textWriter.WriteStartElement("No");
                    m_textWriter.WriteString(m_AlarmDataList[i].No.ToString());
                    m_textWriter.WriteEndElement();
                    m_textWriter.WriteStartElement("AlarmOn");
                    m_textWriter.WriteString(m_AlarmDataList[i].AlarmOn.ToString());
                    m_textWriter.WriteEndElement();
                    m_textWriter.WriteStartElement("Hour");
                    m_textWriter.WriteString(m_AlarmDataList[i].Hour.ToString("D2"));
                    m_textWriter.WriteEndElement();
                    m_textWriter.WriteStartElement("Minute");
                    m_textWriter.WriteString(m_AlarmDataList[i].Minute.ToString("D2"));
                    m_textWriter.WriteEndElement();
                    m_textWriter.WriteStartElement("MusicPath");
                    m_textWriter.WriteString(m_AlarmDataList[i].MusicPath);
                    m_textWriter.WriteEndElement();
                    m_textWriter.WriteStartElement("AlarmDuration");
                    m_textWriter.WriteString(m_AlarmDataList[i].AlarmDuration.ToString());
                    m_textWriter.WriteEndElement();
                    m_textWriter.WriteEndElement();
                }
                m_textWriter.WriteEndElement();
                m_textWriter.WriteEndDocument();
                m_textWriter.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Add(bool AddAlarmOn, int AddHour, int AddMinute, string AddMusicPath, int AddAlarmDuration)
        {
            //원래 있는 ListData에 새로 만든 Alarm Data를 ADD
            int No = m_AlarmDataList.Count;
            m_AlarmDataList.Add(new AlarmData(No, AddAlarmOn, AddHour, AddMinute, AddMusicPath, AddAlarmDuration));

            if (!Write())
            {
                MessageBox.Show("Alarm Data Add Error");
            }
        }

        public void Delete()
        {
            //ListView에서 선택된 Data는 제거하고 다시 AlamrData를 List로 저장한다.
            var data = m_DataHandler.CopyList(m_AlarmDataList);
            int cnt = 0;

            m_AlarmDataList.Clear();

            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].No != GV.SelectedNo)
                {
                    m_AlarmDataList.Add(new AlarmData(cnt, data[i].AlarmOn, data[i].Hour, data[i].Minute, data[i].MusicPath, data[i].AlarmDuration));
                    cnt++;
                }
            }

            if (!Write())
            {
                MessageBox.Show("Alarm Data Delete Error");
            }
        }

        public void Modify(bool ModAlarmOn, int ModHour, int ModMinute, string ModMusicPath, int ModAlarmDuration)
        {
            //ListView에서 선택된 Alarm Data의 값을 바꾼다
            for (int i = 0; i < m_AlarmDataList.Count; i++)
            {
                if (m_AlarmDataList[i].No == GV.SelectedNo)
                {
                    m_AlarmDataList[i].AlarmOn = ModAlarmOn;
                    m_AlarmDataList[i].Hour = ModHour;
                    m_AlarmDataList[i].Minute = ModMinute;
                    m_AlarmDataList[i].MusicPath = ModMusicPath;
                    m_AlarmDataList[i].AlarmDuration = ModAlarmDuration;
                }
            }

            if (!Write())
            {
                MessageBox.Show("Alarm Data Modify Error");
            }
        }

        public void AlarmDataInit()
        {
            //초기화된 하나의 Data만 다시 저장한다
            m_AlarmDataList.Clear();
            //m_AlarmDataList.Add(new AlarmData(0, false, 0, 0, GV.StartupMusicPath, 1));

            if (!Write())
            {
                MessageBox.Show("Data Initialize Error");
            }
        }
    }


}
