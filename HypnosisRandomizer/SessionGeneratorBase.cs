using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HypnosisRandomizer
{
    public class SessionGeneratorBase
    {
        public List<ScriptRepresentation> Base_Session = new List<ScriptRepresentation>();
        public ScriptChainer Chainer = new ScriptChainer();
        public List<ScriptRepresentation> ScriptPoolUnfiltered = new List<ScriptRepresentation>();


        public void GenericPoolFilter()
        {

        }

        public void PopulateScriptPoolNoPrefs()
        {
                //Use of ScriptChainer to fill generic pool
            ScriptChainer ScriptFetcher = new ScriptChainer();
            string Directory_ = Application.StartupPath;
                //Set it to point to /Scripts
            Directory_ += "/scripts/";
            string[] Script_Pool = Directory.GetFiles(Directory_);
            //new object();
            foreach(string scriptname in Script_Pool)
            {
                ScriptFetcher.chain_script(scriptname);
            }

                //And finally re-use this lovely object to load the un-filtered script pool into memory!
            ScriptPoolUnfiltered = ScriptFetcher.Get_Scripts();
        }


    }
}
