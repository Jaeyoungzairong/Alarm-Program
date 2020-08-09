using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmProgram
{
    public delegate void DelVoid_Void();
    public delegate void DelVoid_String(string val);
    public delegate void DelVoid_String2(string val1, string val2);
    public delegate bool DelBool_Void();
    public delegate void DelVoid_Int(int val);
}
