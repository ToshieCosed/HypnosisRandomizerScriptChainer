using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HypnosisRandomizer
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (Program.userpreferences.EnabledScriptFeatures.Count > 0)
            {

                //Is maze mode meant to run?
                if (Program.userpreferences.EnabledScriptFeatures.Contains(Program.ScriptFeatures.IncludeInMazeModePool))
                {
                    //This should be all we need to kick off maze mode now (hopefully)
                    MapForm MazeModeMap = new MapForm();
                    

                    SessionGeneratorBase genner = new SessionGeneratorBase();
                    genner.PopulateScriptPoolNoPrefs();

                    genner.Remove_NonPrefs();
                    //The other prefs format, I cannot remember why I set up prefs-mirroring.
                    //Something something -script chaining logic. yeah. Not really needed now. Maybe?
                    Program.userpreferences.ResetAndFillPrefs();

                        //Generate session with 5 to start.
                        genner.GenerateGenericSession(5);
                        MazeModeMap.Show(this.Owner);
                        //Hide this form so it doesn't get in the way.
                        this.Hide();
                        

                    Random MazeRng = new Random(System.DateTime.Now.Second + System.DateTime.Now.Year + System.DateTime.Now.Minute);

                        //You cannot update dictionary's values directly UGH, they are readonly. UGHHH!!
                    ICollection<Vector2<int,int>> keys = new List<Vector2<int,int>>(MazeModeMap.mazemap.rooms.Keys);
                        //Randomize the finish room too.
                    int roomindex = MazeRng.Next(0, MazeModeMap.mazemap.rooms.Keys.Count);
                    int countindex = 0;
                    foreach (Vector2<int,int> key in keys)
                    {
                       
                            //If the finish is shown display it alongside the actual room.
                        if (countindex == roomindex)
                        {
                            MazeModeMap.mazemap.SetFinishRoom(key.X, key.Y);
                            MazeModeMap.RevealRoomTile(key.X, key.Y, MazeModeMap.PalletizedTiles);
                        }

                            //One final touch up to visually correct a backwards tile on start or something.
                                //--Dont ask questions this fixes stuff.
                        if (key.X == MazeModeMap.mazemap.StartRoom.X && key.Y == MazeModeMap.mazemap.StartRoom.Y)
                        {
                            MazeModeMap.RevealRoomTile(key.X, key.Y, MazeModeMap.PalletizedTiles);
                        }

                            //Just some RNG for defining if a tile has a session on it.
                       int value = MazeRng.Next(13);
                       if (value > 5)
                        {
                            MazeRoom troom_ = MazeModeMap.mazemap.rooms[key];
                            int index = MazeRng.Next(0, genner.Session_List.Count());
                            troom_.SessionName = genner.Session_List.ToArray()[index].FileName;
                            MazeModeMap.mazemap.rooms[key] = troom_;
                           
                        }
                        countindex++;
                    }

                    //And the game loop begins here. Maze Mode Only.
                    
                    MazeModeMap.Player_Move();

                }


                if (!Program.userpreferences.EnabledScriptFeatures.Contains(Program.ScriptFeatures.IncludeInMazeModePool))
                {
                    SessionGeneratorBase genner = new SessionGeneratorBase();
                    genner.PopulateScriptPoolNoPrefs();
                    genner.Remove_NonPrefs();
                    //The other prefs format, I cannot remember why I set up prefs-mirroring.
                    //Something something -script chaining logic. yeah. Not really needed now. Maybe?
                    Program.userpreferences.ResetAndFillPrefs();
                    genner.GenerateGenericSession(5);


                    //f.UpdateTileAt(5, 5, 26);

                    //f.make_map(new Vector2<int, int>(5, 5), new Vector2<int, int>(10, 10), 25);
                    this.Hide();
                    bool first_time = true;
                    foreach (ScriptRepresentation rep in genner.Session_List)
                    {
                        SpeechScriptInterpreter interpreter = new SpeechScriptInterpreter();

                        if (first_time)
                        {
                            interpreter.init();
                            first_time = false;
                            Console.WriteLine("Hypnosis Randomizer Online. Programming you now.");
                        }else
                        { interpreter.Init_Voice(Program.voicename); }
                        //interpreter.say_default("This is a test");
                        interpreter.parse(rep.FileName);
                    }
                }
                Console.WriteLine("Session finished. You may close this window.");

            }
            else
            {
                NoPreferencesSelectedError DialogePopup = new NoPreferencesSelectedError();
                DialogePopup.ShowDialog();
            }
            }

            //new Object();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxPunishSegments.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.IsPunishSegment); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.IsPunishSegment);
            }

        }

        private void LabelTeaseTrigger_Click(object sender, EventArgs e)
        {

        }

        private void LabelDropTrigger_Click(object sender, EventArgs e)
        {

        }

        private void CheckBoxRewardSegments_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxRewardSegments.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.IsRewardSegment); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.IsRewardSegment);
            }

        }

        private void CheckBoxUseInduction_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxUseInduction.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.IsInduction); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.IsInduction);
            }
        }

        private void CheckBoxUseDeepener_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxUseDeepener.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.IsDeepener); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.IsDeepener);
            }
        }

        private void CheckBoxIncludeRandomTriggering_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxIncludeRandomTriggering.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.ContainsRandomTriggering); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.ContainsRandomTriggering);
            }
        }

        private void CheckBoxRandomTriggerInstalls_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxRandomTriggerInstalls.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.IncludeInRandomTriggerInstallPool); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.IncludeInRandomTriggerInstallPool);
            }
        }

        private void CheckBoxUseDialogScripts_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxUseDialogScripts.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.IsInteractive); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.IsInteractive);
            }
        }

        private void CheckBoxUseAwakener_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxUseAwakener.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.IsAwakener); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.IsAwakener);
            }
        }

        private void CheckBoxAllowFractionate_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxAllowFractionate.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.IsFractionationSegment); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.IsFractionationSegment);
            }
        }

        private void CheckBoxAllowImmobilizeUnder_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxAllowImmobilizeUnder.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.ImmobilityWhileUnder); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.ImmobilityWhileUnder);
            }
        }

        private void CheckBoxAllowImmobilityTriggerInstall_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxAllowImmobilityTriggerInstall.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.InstallsImmobilityTrigger); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.InstallsImmobilityTrigger);
            }
        }

        private void CheckBoxCustomImmobilizeTrigger_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxCustomImmobilizeTrigger.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.AllowsCustomImmobilityTrigger); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.AllowsCustomImmobilityTrigger);
            }
        }

        private void CheckBoxAllowIQDropWhileUnder_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxAllowIQDropWhileUnder.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.IQDropWhileUnder); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.IQDropWhileUnder);
            }
        }

        private void CheckBoxAllowOpenTriggerInstalls_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxAllowOpenTriggerInstalls.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.InstallsOpenTrigger); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.InstallsOpenTrigger);
            }
        }

        private void CheckBoxAllowTrustTriggerInstalls_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxAllowTrustTriggerInstalls.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.InstallsTrustedTrigger); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.InstallsTrustedTrigger);
            }
        }

        private void CheckBoxTrustedScripts_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxDeclareFeatures.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.DeclaresFeatures); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.DeclaresFeatures);
            }
        }

        private void CheckBoxTrustedScripts_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.CheckBoxTrustedScripts.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.IsTrustedScript);
                Feature_Not_Implemented popup = new Feature_Not_Implemented();
                popup.ShowDialog();
            }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.IsTrustedScript);
            }
        }

        private void CheckBoxPermanentChanges_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxPermanentChanges.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.PermanentChanges); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.PermanentChanges);
            }
        }

        private void CheckBoxAllowBodyChangesWhileUnder_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxAllowBodyChangesWhileUnder.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.BodyChangesWhileUnder); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.BodyChangesWhileUnder);
            }
        }

        private void CheckBoxAllowBodyChangeTriggerInstalls_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxAllowBodyChangeTriggerInstalls.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.InstallsTriggerTransformation); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.InstallsTriggerTransformation);
            }
        }

        private void CheckBoxAllowLongScripts_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxAllowLongScripts.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.IsLongScript); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.IsLongScript);
            }
        }

        private void CheckBoxAllowPermanentBodyChanges_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxAllowPermanentBodyChanges.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.BodyChangesPermanent); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.BodyChangesPermanent);
            }
        }

        private void CheckBoxAllowGenericReinforcement_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxAllowGenericReinforcement.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.GenericReinforcement); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.GenericReinforcement);
            }
        }

        private void CheckBoxAllowPersonalityChangesPermanent_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxAllowPersonalityChangesPermanent.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.PersonalityChangePermanent); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.PersonalityChangePermanent);
            }
        }

        private void CheckBoxAllowObedienceTraining_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxAllowObedienceTraining.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.ObedienceTraining); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.ObedienceTraining);
            }
        }

        private void CheckBoxTriggerAfterAwaken_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxTriggerAfterAwaken.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.IncludeInTriggerOnWakePool); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.IncludeInTriggerOnWakePool);
            }
        }

        private void CheckBoxAllowAccidentalTriggers_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxAllowAccidentalTriggers.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.InstallsAccidental_RandomTrigger); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.InstallsAccidental_RandomTrigger);
            }
        }

        private void CheckBoxAllowIQDropTriggers_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxAllowIQDropTriggers.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.InstallsIQDropTriggerOpen); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.InstallsIQDropTriggerOpen);
            }
        }

        private void CheckBoxAllowStrip_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxAllowStrip.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.ContainsStripSegment); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.ContainsStripSegment);
            }
        }

        private void CheckBoxAllowMasturbation_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxAllowMasturbation.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.ContainsMasturbation); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.InstallsAccidental_RandomTrigger);
            }
        }

        private void CheckBoxAllowSlaveryBrainWash_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxAllowSlaveryBrainWash.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.EnslaveTraining); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.EnslaveTraining);
            }
        }

        private void CheckBoxUseName_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxUseName.Checked) { Program.userpreferences.AddFeature(Program.ScriptFeatures.AllowsCustomName); }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.AllowsCustomName);
            }
        }

        private void CheckBoxChaosModeEnabled_CheckedChanged(object sender, EventArgs e)
        {
            Feature_Not_Implemented not_implemented = new Feature_Not_Implemented();
            not_implemented.ShowDialog();
        }

        private void CheckBoxAllowRandomScriptLogic_CheckedChanged(object sender, EventArgs e)
        {
            Feature_Not_Implemented not_implemented = new Feature_Not_Implemented();
            not_implemented.ShowDialog();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.CheckBoxMazeMode.Checked)
            {
                Program.userpreferences.AddFeature(Program.ScriptFeatures.IncludeInMazeModePool);
            }else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.IncludeInMazeModePool);
            }
            }

        private void CheckBoxMazeModeOnlyImprt_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxMazeModeOnlyImprt.Checked)
            {
                Program.userpreferences.AddFeature(Program.ScriptFeatures.MazeModeOnly);
            }
            else
            {
                Program.userpreferences.RemoveFeature(Program.ScriptFeatures.MazeModeOnly);
            }
        }
    }
    }
