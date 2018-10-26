using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypnosisRandomizer
{
    public class EnumHelper
    {
        public Program.ScriptFeatures Get_Enum(string input)
        {
            Program.ScriptFeatures TempFeature = (Program.ScriptFeatures)Enum.Parse(typeof(Program.ScriptFeatures), input);
            return TempFeature;
        }
    }
}
