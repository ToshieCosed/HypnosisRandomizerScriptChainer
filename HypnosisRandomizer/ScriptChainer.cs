using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HypnosisRandomizer
{
    public class ScriptChainer
    {
        public List<ScriptRepresentation> ScriptList = new List<ScriptRepresentation>();

        public void init()
        {
            //whatever
        }

            //Chains the script to the ScriptChainer List without any logic
        public void chain_script(string ScriptName)
        {
            ScriptRepresentation rep = new ScriptRepresentation();
            string BaseFilename = Application.StartupPath;
            BaseFilename += "/Scripts/"+ ScriptName;
            //rep.FileName = "/Scripts/Tags_Test.txt";
            rep.init(BaseFilename);
            ScriptList.Add(rep);
        }

        public List<ScriptRepresentation> Get_Scripts()
        {
            return ScriptList;
        }
    }
}
