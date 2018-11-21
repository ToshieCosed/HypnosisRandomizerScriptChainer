using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypnosisRandomizer
{
        //Utility class to help us grab properties and tags from script files to identify them through.
    class ScriptScanner
    {
        public string GetProperty(string line)
           {
            string property = "NoProperty";
            string cutstring = "";
            if (line.Contains("<IncludesFeature:"))
            {
                cutstring = "<IncludesFeature:";
                string FeatureString = line.Substring(cutstring.Length);
                    //Trim the ">" out of FeatureString Next.
                FeatureString = FeatureString.Substring(0, FeatureString.Length - 1);
                property = FeatureString;
            }
            //return the property string honorably no matter what as promised =p
            return property;
        }

        public List<string> getproperties(string[] lines)
        {
            List<string> FeatureProperties = new List<string>();
            foreach(string line in lines)
            {
                string Returned_Property = GetProperty(line);
                if (Returned_Property != "NoProperty")
                {
                        //Cleverly add it from our search
                    FeatureProperties.Add(Returned_Property);
                }
            }
            return FeatureProperties;
        }
    }
}
