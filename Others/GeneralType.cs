using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmProgram
{
    //화면상태
    public enum DispayStatus
    {
        None,
        Config,
        Setting,
        Alarm
    }
    //알람상태
    public enum AlarmStatus
    {
        On,
        Wait,
        Off
    }
    //Data 저장상태
    public enum SaveStatus
    {
        None,
        Add,
        Modify,
        Delete
    }
    //ListView 정렬
    public enum SortingType
    {
        No,
        Time
    }
    //관리자모드
    public enum AdminMode
    {
        Administrator,
        Normal
    }
}
