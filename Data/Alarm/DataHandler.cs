using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AlarmProgram
{
    public class DataHandler
    {
        public DataHandler()
        {

        }
        //24시간 기준 시간의 AM/PM을 Boolean 형식으로 설정
        public bool CheckAMPMToBool(int Hour)
        {
            bool rv = true;
            if (Hour >= 12) rv = false;
            else rv = true;

            return rv;
        }
        //24시간 기준 시간의 AM/PM을 String 형식으로 설정
        public string CheckAMPMToString(int Hour)
        {
            string rv;
            if (Hour >= 12) rv = "PM";
            else rv = "AM";

            return rv;
        }
        //24시간 기준에서 12시간 기준으로 변환
        public int ConvertTo12H(int Hour)
        {
            int rv = 0;
            if (Hour == 0) rv = 12;
            else if (Hour > 12) rv = Hour - 12;
            else rv = Hour;

            return rv;
        }
        //12시간 기준에서 24시간 기준으로 변환
        public int ConvertTo24H(bool AM, int Hour)
        {
            int rv = 0;
            if (AM)
            {
                if (Hour == 12) rv = 0;
                else rv = Hour;
            }
            else
            {
                if (Hour == 12) rv = 12;
                else rv = Hour + 12;
            }

            return rv;
        }
        //List형식 그대로 복사하는 함수
        public T CopyList<T>(T obj)
        {
            using (var stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
                stream.Position = 0;

                return (T)formatter.Deserialize(stream);
            }
        }
    }
}
