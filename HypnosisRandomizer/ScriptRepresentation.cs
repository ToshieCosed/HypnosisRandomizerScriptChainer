using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypnosisRandomizer
{
    public class ScriptRepresentation
    {
        //We need a list of features to hold per-script
        public List<Program.ScriptFeatures> FeaturesList = new List<Program.ScriptFeatures>();
        public string FileName;
        public string InternalFilename;
        public string RequiresScript; //Will be updated to a list later to allow dynamic inclusion of more than one script neccesity
        public bool Trusted_Script = false;
        public Program.ScriptFeatures ScriptType = new Program.ScriptFeatures();
        EnumHelper enumhelper = new EnumHelper(); //Added an enum helper so the function Get_Enums(string) can be used from within any class.

        public void init(string filename)
        {
            string[] file_lines = System.IO.File.ReadAllLines(filename);
            ScriptScanner scanner = new ScriptScanner();
            List<string> Feature_Strings = scanner.getproperties(file_lines);
            FeaturesList = ConvertFeaturesToLocalEnumList(Feature_Strings);
        }

        public List<Program.ScriptFeatures> ConvertFeaturesToLocalEnumList(List<string> LocalStringList)
        {
            List<Program.ScriptFeatures> TempFeatureList = new List<Program.ScriptFeatures>();
            foreach (string s in LocalStringList)
            {
                Program.ScriptFeatures Temp_Enum = enumhelper.Get_Enum(s);
                TempFeatureList.Add(Temp_Enum);

            }
            return TempFeatureList;
        }
        
    }
}
