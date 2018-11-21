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
        public List<ScriptRepresentation> Base_Pool = new List<ScriptRepresentation>();
        public List<ScriptRepresentation> Session_List = new List<ScriptRepresentation>();

        public ScriptChainer Chainer = new ScriptChainer();
        public List<ScriptRepresentation> ScriptPoolUnfiltered = new List<ScriptRepresentation>();

            //Add a seperate inductions pool to draw sweet liquid hypno nectar from.
        public List<ScriptRepresentation> Inductions_List = new List<ScriptRepresentation>();

            //Add a seperate Awakeners list to draw that sweet morning dew off the grass from. Mmm. hypnotic. Or is it? ;)
        public List<ScriptRepresentation> Awakening_List = new List<ScriptRepresentation>();

        //Just in case we need it, add a sweet sweet triggering awakener list :P Guarenteed one per session if selected
        public List<ScriptRepresentation> Triggering_List = new List<ScriptRepresentation>();
       
        //The amount of segments to include
        public void GenerateGenericSession(int chain_amount)
        {
            string[] Chain_Segments = new string[chain_amount+1];
                //Fill with blank strings so it doesn't get nulled.
            for (int i=0; i<chain_amount+1; i++)
            {
                Chain_Segments[i] = "";
            }

            //we basically want to get all of the types of induction and awakener (anyway)
            Inductions_List = MakeScriptListWithFeature(Base_Pool, Program.ScriptFeatures.IsInduction);
            //And now get a list of all awakeners
            Awakening_List = MakeScriptListWithFeature(Base_Pool, Program.ScriptFeatures.IsAwakener);
            //And now we need a list of only triggering segments to randomize from
            Triggering_List = MakeScriptListWithFeature(Base_Pool, Program.ScriptFeatures.IncludeInTriggerOnWakePool);

            //Now that we made our lists we can remove Awakeners, and Inductions from the base pool.

            RemoveScriptsWithFeature(Base_Pool, Program.ScriptFeatures.IsInduction);
            RemoveScriptsWithFeature(Base_Pool, Program.ScriptFeatures.IsAwakener);
            
            if (Program.userpreferences.HasFeatureAsString(("IsInduction"))){ Chain_Segments[0] = "Induction"; }else
            {
                Chain_Segments[0] = "Randomize";
            }
                //If there is a wakener, and a triggering segment before wake up then gaurentee a triggering segment before wake up and shift awakener backwards
                    //One slot to make room for triggering segment upon awaken.
            if (Program.userpreferences.HasFeatureAsString("IncludeInTriggerOnWakePool") && Program.userpreferences.HasFeatureAsString("IsAwakener"))
            { Chain_Segments[chain_amount-1] = "Awakener";
                Chain_Segments[chain_amount] = "TriggeringSegment";
            }

            //Same as above except account for there being no awakener.
            if (Program.userpreferences.HasFeatureAsString("IncludeInTriggerOnWakePool") && !Program.userpreferences.HasFeatureAsString("IsAwakener"))
            {
                Chain_Segments[chain_amount] = "TriggeringSegment";
            }


            //This is to be called after all the Non prefs are removed. Unless in chaos mode.

            for (int i=0; i< chain_amount; i++)
            {
                if (Chain_Segments[i] == "")
                {
                    Chain_Segments[i] = "Randomize";
                }
            }

            GetScrambledMidList(Base_Pool);

                //Finally generate the session
            for (int i=0; i<chain_amount; i++)
            {
                switch (Chain_Segments[i])
                {
                    case "Randomize":
                        ScriptRepresentation Rando_Script = FetchRandom(Base_Pool);
                        if (Rando_Script.FileName != "NoProperty")
                        {
                            Session_List.Add(Rando_Script);
                            //Patched so we remove scripts from the base pool after they have been included.
                            Base_Pool.Remove(Rando_Script);
                        }
                        break;

                    case "TriggeringSegment":
                        ScriptRepresentation Trig_Script = FetchRandom(Triggering_List);
                        if (Trig_Script.FileName != "NoProperty")
                        {
                            Session_List.Add(Trig_Script);
                            //Patched so we remove scripts from the base pool after they have been included.
                            Base_Pool.Remove(Trig_Script);
                        }
                        break;

                    case "Awakener":
                        ScriptRepresentation Awaken_Script = FetchRandom(Awakening_List);
                        if (Awaken_Script.FileName != "NoProperty")
                        { 
                        Session_List.Add(Awaken_Script);
                        }
                        break;

                    case "Induction":
                        ScriptRepresentation Induction = FetchRandom(Inductions_List);
                        if (Induction.FileName != "NoProperty")
                        {
                            Session_List.Add(Induction);
                        }
                        break;

                }
            }

        }

        public void RemoveScriptsWithFeature(List<ScriptRepresentation> Ilist, Program.ScriptFeatures TargetFeature)
        {
            Ilist.RemoveAll((Item => Item.FeaturesList.Contains(TargetFeature)));
        }

        public ScriptRepresentation FetchRandom(List<ScriptRepresentation> Ilist)
        {
            ScriptRepresentation Ireturned = new ScriptRepresentation();
            Ilist.Shuffle();
            Random rng = new Random();
            int ListAmount = Ilist.Count();
                //grab a random index
            int RandomIndex = rng.Next(ListAmount);
            ScriptRepresentation[] Iarray = Ilist.ToArray();
            if (Iarray.Length > 0)
            {
                 Ireturned = Iarray[RandomIndex];
            }else
            { Ireturned.FileName = "NoProperty"; }
            return Ireturned;
        }

            //If a Script Representation with the filename of NoProperty is returned
                //We will omit it and assume we couldn't find an induction
                    //And return to randomizing =p
        public ScriptRepresentation FindScriptWithFeature(List<ScriptRepresentation> Ilist, Program.ScriptFeatures TargetFeature)
        {
            ScriptRepresentation I_returner = new ScriptRepresentation();
            I_returner.FileName = "NoProperty";
            foreach(ScriptRepresentation n in Ilist)
            {

                if (n.FeaturesList.Contains(TargetFeature))
                {
                        //We found a script with the target feature -- cancel search.
                    I_returner = n;
                    break;
                }
            }
            return I_returner;
        }

            //Helper function to basically search script lists
                //and extract all of one type of script.
        public List<ScriptRepresentation> MakeScriptListWithFeature(List<ScriptRepresentation> Ilist, Program.ScriptFeatures TargetFeature)
        {
            List<ScriptRepresentation> I_returner = new List<ScriptRepresentation>();

            
            foreach (ScriptRepresentation n in Ilist)
            {

                if (n.FeaturesList.Contains(TargetFeature))
                {
                    
                    I_returner.Add(n);
                }
            }
            return I_returner;
        }

        //Is used to omit induction, awakening, and trigger segment scripts
        //And then continue along to scramble the list.
        public List<ScriptRepresentation> GetScrambledMidList(List<ScriptRepresentation> InputList)
        {
            InputList.Shuffle();
            return InputList;
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

        public void Remove_NonPrefs()
        {
                foreach(ScriptRepresentation rep in ScriptPoolUnfiltered)
            {
                bool copy_script = true;
                List<Program.ScriptFeatures> localfeatures = rep.FeaturesList;
                    //Double foreach bleck
                        foreach(Program.ScriptFeatures feature in localfeatures)
                {
                       
                           if (!Program.userpreferences.HasFeatureAsEnum(feature) && feature!= Program.ScriptFeatures.IncludeInMazeModePool){
                           copy_script = false;
                    }

                }

                        if (copy_script) { Base_Pool.Add(rep); }

            }
        }


    }
}
