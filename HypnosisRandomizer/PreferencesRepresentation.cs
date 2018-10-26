using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HypnosisRandomizer
{
    public class PreferencesRepresentation
    {
        public List<Program.ScriptFeatures> EnabledScriptFeatures = new List<Program.ScriptFeatures>();
        public EnumHelper enum_helper = new EnumHelper();
        public Dictionary<Program.ScriptFeatures, Program.PreferenceEnums> PrefsDictionary = new Dictionary<Program.ScriptFeatures, Program.PreferenceEnums>();

        public void SetPrefsKeys()
        {
            PrefsDictionary.Add(Program.ScriptFeatures.IsPunishSegment, Program.PreferenceEnums.UsePunishSegments);
            PrefsDictionary.Add(Program.ScriptFeatures.IsRewardSegment, Program.PreferenceEnums.UseRewardSegments);
            PrefsDictionary.Add(Program.ScriptFeatures.IsInduction, Program.PreferenceEnums.UseInductionScripts);
            PrefsDictionary.Add(Program.ScriptFeatures.IsDeepener, Program.PreferenceEnums.UseDeepenerSegments);
            PrefsDictionary.Add(Program.ScriptFeatures.ContainsRandomTriggering, Program.PreferenceEnums.AllowRandomTriggering);
            PrefsDictionary.Add(Program.ScriptFeatures.IncludeInRandomTriggerInstallPool, Program.PreferenceEnums.AllowRandomTriggerInstall);
            PrefsDictionary.Add(Program.ScriptFeatures.IsInteractive, Program.PreferenceEnums.AllowInteractiveScripts);
            PrefsDictionary.Add(Program.ScriptFeatures.IsFractionationSegment, Program.PreferenceEnums.UseFractionationSegments);
            PrefsDictionary.Add(Program.ScriptFeatures.ImmobilityWhileUnder, Program.PreferenceEnums.AllowImmobilizeWhileUnder);
            PrefsDictionary.Add(Program.ScriptFeatures.InstallsImmobilityTrigger, Program.PreferenceEnums.AllowImmobilityTriggerInstall);
            PrefsDictionary.Add(Program.ScriptFeatures.AllowsCustomImmobilityTrigger, Program.PreferenceEnums.CustomImmobilizeTriggerInRandomTriggerPool);
            PrefsDictionary.Add(Program.ScriptFeatures.IQDropWhileUnder, Program.PreferenceEnums.AllowIQDropUnder); 
            //Allow IQ drop WHILE under.
            PrefsDictionary.Add(Program.ScriptFeatures.InstallsOpenTrigger, Program.PreferenceEnums.AllowOpenTriggerInstall);
            //Allows triggers which require you to trust your trigger-er or they won't work.
            PrefsDictionary.Add(Program.ScriptFeatures.InstallsTrustedTrigger, Program.PreferenceEnums.AllowSelectiveTriggerInstalls);
            PrefsDictionary.Add(Program.ScriptFeatures.DeclaresFeatures, Program.PreferenceEnums.OnlyIncludeTaggedScriptsInRandomPool);
            PrefsDictionary.Add(Program.ScriptFeatures.IsTrustedScript, Program.PreferenceEnums.OnlyIncludeTrustedScriptsInRandomPool);
            PrefsDictionary.Add(Program.ScriptFeatures.PermanentChanges, Program.PreferenceEnums.AllowPermanentChanges);
            PrefsDictionary.Add(Program.ScriptFeatures.BodyChangesWhileUnder, Program.PreferenceEnums.AllowBodyChangesUnder);
            PrefsDictionary.Add(Program.ScriptFeatures.InstallsTriggerTransformation, Program.PreferenceEnums.AllowTransformationTriggerInstall);
            PrefsDictionary.Add(Program.ScriptFeatures.IsLongScript, Program.PreferenceEnums.UseLongScripts);
            PrefsDictionary.Add(Program.ScriptFeatures.BodyChangesPermanent, Program.PreferenceEnums.AllowBodyChangesPermanent);
            PrefsDictionary.Add(Program.ScriptFeatures.GenericReinforcement, Program.PreferenceEnums.UseGenericReinforcementScripts);
            PrefsDictionary.Add(Program.ScriptFeatures.PersonalityChangePermanent, Program.PreferenceEnums.AllowPersonalityChangePermanent);
            PrefsDictionary.Add(Program.ScriptFeatures.ObedienceTraining, Program.PreferenceEnums.AllowObedienceTraining);
            PrefsDictionary.Add(Program.ScriptFeatures.IncludeInTriggerOnWakePool, Program.PreferenceEnums.UseRandomTriggerSegmentsOnWake);
            PrefsDictionary.Add(Program.ScriptFeatures.InstallsAccidental_RandomTrigger, Program.PreferenceEnums.AllowAccidentalTriggerInstall);
            PrefsDictionary.Add(Program.ScriptFeatures.InstallsIQDropTriggerOpen, Program.PreferenceEnums.AllowIQDropTriggerInstall_OpenUsage);
            PrefsDictionary.Add(Program.ScriptFeatures.ContainsStripSegment, Program.PreferenceEnums.AllowForcedStripUnder);
            PrefsDictionary.Add(Program.ScriptFeatures.ContainsMasturbation, Program.PreferenceEnums.AllowForcedMasturbation);
            PrefsDictionary.Add(Program.ScriptFeatures.EnslaveTraining, Program.PreferenceEnums.AllowSlaveTraining);
            PrefsDictionary.Add(Program.ScriptFeatures.AllowsCustomName, Program.PreferenceEnums.AllowCustomNameUse);
        }

        public bool HasFeatureAsString(string feature)
        {
            bool feature_included = false;
            int target_index = SearchFeature(enum_helper.Get_Enum(feature));
            if (target_index> -1)
            {
                feature_included = true;
            }
            return feature_included;
        }

        public bool HasFeatureAsEnum(Program.ScriptFeatures checkfeature)
        {
            bool feature_included = false;
            int target_index = SearchFeature(checkfeature);
            if (target_index> -1)
            {
                feature_included = true;
            }
            return feature_included;
        }

        public void AddFeature(Program.ScriptFeatures feature_addition)
        {
            if (!HasFeatureAsEnum(feature_addition))
            {
                EnabledScriptFeatures.Add(feature_addition);
            }
        }

        public void RemoveFeature(Program.ScriptFeatures feature_removal)
        {
            if (HasFeatureAsEnum(feature_removal))
            {
               EnabledScriptFeatures.Remove(feature_removal);
            }
        }

        public int SearchFeature(Program.ScriptFeatures target_feature)
        {
            int target_index = -1;
            int current_index = 0;
            foreach(Program.ScriptFeatures f in EnabledScriptFeatures)
            {
                if (f == target_feature)
                {
                    //end the search for the index in our list
                    target_index = current_index;
                    break;
                }
            }
            return target_index;
        }

        public List<string> GetPrefsAsStringList()
        {
            List<string> PrefsListAsString = new List<string>();
            foreach(Program.ScriptFeatures f in EnabledScriptFeatures)
            {
                PrefsListAsString.Add(f.ToString());
            }
            return PrefsListAsString;
        }

    }
}
