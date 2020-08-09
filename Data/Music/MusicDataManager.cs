using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
//using System.IO;

namespace AlarmProgram
{
    public class MusicDataManager
    {
        public readonly static MusicDataManager Instance = new MusicDataManager();

        private string m_Path = Application.StartupPath + "\\MusicData.xml"; //Xml Data 경로
        private XmlDocument m_XmlDocument;
        public List<MusicData> m_MusicDataList;

        public MusicDataManager()
        {
            m_XmlDocument = new XmlDocument();
            m_MusicDataList = new List<MusicData>();
        }

        public bool Read()
        {
            try
            {
                m_MusicDataList.Clear();

                m_XmlDocument.Load(m_Path);
                m_XmlDocument.SelectNodes("/MusicData");

                int NodeCount = m_XmlDocument.LastChild.ChildNodes.Count; //현대 Xml에 저장된 Alarm Data 개수

                int[] No = new int[NodeCount];
                string[] MusicName = new string[NodeCount];
                string[] MusicPath = new string[NodeCount];


                XmlNodeList[] NoList = new XmlNodeList[NodeCount];
                XmlNodeList[] MusicNameList = new XmlNodeList[NodeCount];
                XmlNodeList[] MusicPathList = new XmlNodeList[NodeCount];

                string path = "/MusicData/Music";

                for (int i = 0; i < NodeCount; i++)
                {
                    NoList[i] = m_XmlDocument.SelectNodes(path + i.ToString() + "/No");
                    MusicNameList[i] = m_XmlDocument.SelectNodes(path + i.ToString() + "/MusicName");
                    MusicPathList[i] = m_XmlDocument.SelectNodes(path + i.ToString() + "/MusicPath");

                    foreach (XmlNode tempNo in NoList[i]) No[i] = Convert.ToInt32(tempNo.InnerText);
                    foreach (XmlNode tempMusicName in MusicNameList[i]) MusicName[i] = tempMusicName.InnerText;
                    foreach (XmlNode tempMusicPath in MusicPathList[i]) MusicPath[i] = tempMusicPath.InnerText;

                    //MusicData를 List로 만들어 관리한다
                    m_MusicDataList.Add(new MusicData(No[i], MusicName[i], MusicPath[i]));
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
                m_textWriter.WriteStartElement("MusicData");

                for (int i = 0; i < m_MusicDataList.Count; i++)
                {
                    m_textWriter.WriteStartElement("Music" + i.ToString());
                    m_textWriter.WriteStartElement("No");
                    m_textWriter.WriteString(m_MusicDataList[i].No.ToString());
                    m_textWriter.WriteEndElement();
                    m_textWriter.WriteStartElement("MusicName");
                    m_textWriter.WriteString(m_MusicDataList[i].MusicName);
                    m_textWriter.WriteEndElement();
                    m_textWriter.WriteStartElement("MusicPath");
                    m_textWriter.WriteString(m_MusicDataList[i].MusicPath);
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

        public void SetData(string[] MusicName, string[] MusicPath)
        {
            m_MusicDataList.Clear();
            for (int i = 0; i < MusicPath.Length; i++)
            {
                string name = MusicName[i].Substring(0, MusicName[i].Length - 4);
                m_MusicDataList.Add(new MusicData(i, name, MusicPath[i]));
            }

            if (!Write())
            {
                MessageBox.Show("Music Data Setting Error");
            }
        }

        public int MusicPathConvertToNo(string Path)
        {
            int rv = 0;
            foreach (MusicData item in m_MusicDataList)
            {
                if (item.MusicPath == Path) rv = item.No;
            }
            return rv;
        }
    }
}
