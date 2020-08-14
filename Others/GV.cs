using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmProgram
{
    public class GV
    {
        public readonly static int Capacity = 10; //Data 저장 용량
        public readonly static string StartupMusicPath= Application.StartupPath + "\\Music"; //초기 알람음악 경로

        public static int SelectedIndex = 0; //ListView에서 선택된 Index 번호
        public static int SelectedNo = 0; //ListView에서 선택된 알람데이터 번호

        public static int SelectedHour = 0; //알람 실행시 저장된 시
        public static int SelectedMinute = 0; //알람 실행시 저장된 분
        public static string SelectedMusic = null; //알람 실행시 재생할 음악경로
        public static int SelectedAlarmDuration = 1; //알람 실행시 알람지속시간
        public static bool UpdateData = true; //Data Update Trigger

        public static SaveStatus SaveMode = SaveStatus.None; //Data저장상태 Trigger
        public static AlarmStatus UpdateAlarmStatus = AlarmStatus.Off; //알람상태 Trigger
        public static DispayStatus UpdateDisplayStatus = DispayStatus.Config; //화면상태 Trigger
        public static AdminMode ProgramMode = AdminMode.Normal; //관리자 모드 Trigger
    }
}
