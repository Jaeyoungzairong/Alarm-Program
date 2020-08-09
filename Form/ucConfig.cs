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
    public partial class ucConfig : UserControl
    {
        private DataHandler m_DataHandler = new DataHandler();
        private SortingType m_SortingType = SortingType.Time;
        public ucConfig()
        {
            InitializeComponent();
        }

        public void UpdateListView()
        {
            string[] temp = new string[5];
            lvConfig.Clear();
            if (GV.ProgramMode == AdminMode.Administrator)
            {
                lvConfig.Columns.Add("NO", 50);
                lvConfig.Columns.Add("ALARM", 80);
                lvConfig.Columns.Add("TIME", 130);
                lvConfig.Columns.Add("MUSIC", 200);
                lvConfig.Columns.Add("D", 50);
            }
            else
            {
                lvConfig.Columns.Add("NO", 0);
                lvConfig.Columns.Add("ALARM", 100);
                lvConfig.Columns.Add("TIME", 400);
                lvConfig.Columns.Add("MUSIC", 0);
                lvConfig.Columns.Add("D", 0);
            }


            lvConfig.Columns[0].TextAlign = HorizontalAlignment.Center;
            lvConfig.Columns[1].TextAlign = HorizontalAlignment.Center;
            lvConfig.Columns[2].TextAlign = HorizontalAlignment.Center;
            lvConfig.Columns[3].TextAlign = HorizontalAlignment.Left;
            lvConfig.Columns[4].TextAlign = HorizontalAlignment.Center;

            if (AlarmDataManager.Instance.Read())
            {
                //Alarm Data를 복사하고 복사한 Data를 시간에 따라 오름차순으로 정렬하여 ListView에 보여준다
                var SortingData = m_DataHandler.CopyList(AlarmDataManager.Instance.m_AlarmDataList);
                if (m_SortingType == SortingType.Time)
                {
                    foreach (AlarmData item in SortingData) SortingData.Sort(CompareMinute);
                    foreach (AlarmData item in SortingData) SortingData.Sort(CompareHour);
                }

                for (int i = 0; i < SortingData.Count; i++)
                {
                    string AM = m_DataHandler.CheckAMPMToString(SortingData[i].Hour);
                    int Hour = m_DataHandler.ConvertTo12H(SortingData[i].Hour);

                    temp[0] = SortingData[i].No.ToString();
                    temp[1] = SortingData[i].AlarmOn == true ? "ON" : "OFF";
                    //temp[2] = SortingData[i].Hour.ToString("D2") + ":" + SortingData[i].Minute.ToString("D2");
                    temp[2] = AM + " " + Hour.ToString("D2") + ":" + SortingData[i].Minute.ToString("D2");
                    temp[3] = SortingData[i].MusicPath.Split('\\')[SortingData[i].MusicPath.Split('\\').Length - 1];
                    temp[4] = SortingData[i].AlarmDuration.ToString();

                    ListViewItem item = new ListViewItem(temp);
                    lvConfig.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Update ListView Error");
            }
        }

        private int CompareHour(AlarmData a, AlarmData b)
        {
            int rv = a.Hour.CompareTo(b.Hour);// Ascending
            //int rv = b.Hour.CompareTo(a.Hour);// Descending
            return rv;
        }

        private int CompareMinute(AlarmData a, AlarmData b)
        {
            int rv = a.Minute.CompareTo(b.Minute);// Ascending
            //int rv = b.Minute.CompareTo(a.Minute);// Descending
            return rv;
        }

        private void LbAdd_Click(object sender, EventArgs e)
        {
            //화면상태를 Setting창으로 전환하고 저장상태를 ADD로 설정한다
            if (lvConfig.Items.Count < GV.Capacity)
            {
                GV.UpdateDisplayStatus = DispayStatus.Setting;
                GV.SaveMode = SaveStatus.Add;
            }
            else
            {
                MessageBox.Show("No More Place to Save Data");
            }
        }

        private void LbDelete_Click(object sender, EventArgs e)
        {
            //선택된 Data 삭제
            if (lvConfig.Items.Count < 1)
            {
                MessageBox.Show("No More Data to Delete");
            }
            else if (lvConfig.SelectedIndices.Count == 1)
            {
                GV.SaveMode = SaveStatus.Delete;
                AlarmDataManager.Instance.Delete();
                GV.UpdateData = true;
            }
            else
            {
                MessageBox.Show("Please Choose One Item");
            }
        }

        private void LbModify_Click(object sender, EventArgs e)
        {
            //화면상태를 Setting창으로 전환하고 저장상태를 Modify로 설정한다
            if (lvConfig.SelectedIndices.Count == 1)
            {
                GV.UpdateDisplayStatus = DispayStatus.Setting;
                GV.SaveMode = SaveStatus.Modify;
            }
            else
            {
                MessageBox.Show("Please Choose One Item");
            }
        }

        private void LvConfig_MouseClick(object sender, MouseEventArgs e)
        {
            //ListView 아이템 선택 시 선택된 Index번호와 Alarm Data 번호를 저장한다
            GV.SelectedIndex = lvConfig.SelectedIndices[0];
            GV.SelectedNo = Convert.ToInt32(lvConfig.FocusedItem.SubItems[0].Text);

            if (e.Button.Equals(MouseButtons.Right))
            {
                ContextMenu M = new ContextMenu();
                MenuItem m1 = new MenuItem();
                MenuItem m2 = new MenuItem();
                MenuItem m3 = new MenuItem();

                m1.Text = "ADD";
                m2.Text = "DELETE";
                m3.Text = "MODIFY";

                m1.Click += new EventHandler(LbAdd_Click);
                m2.Click += new EventHandler(LbDelete_Click);
                m3.Click += new EventHandler(LbModify_Click);

                //Alarm Data가 설정한 용량을 초과하지 않도록 한다.
                if (lvConfig.Items.Count < GV.Capacity) M.MenuItems.Add(m1);
                //if (lvConfig.Items.Count > 1) M.MenuItems.Add(m2);
                M.MenuItems.Add(m2);
                M.MenuItems.Add(m3);
                M.Show(lvConfig, e.Location);
            }
        }

        private void LvConfig_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //화면상태를 Setting창으로 전환하고 저장상태를 Modify로 설정한다
            if (lvConfig.SelectedIndices.Count == 1)
            {
                GV.UpdateDisplayStatus = DispayStatus.Setting;
                GV.SaveMode = SaveStatus.Modify;
            }
            else
            {
                MessageBox.Show("Please Choose One Item");
            }
        }

        private void LvConfig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.Alt | Keys.Enter))
            {
                GV.ProgramMode = AdminMode.Administrator;
                UpdateListView();
            }
        }
    }
}
