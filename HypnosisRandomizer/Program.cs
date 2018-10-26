using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HypnosisRandomizer
{
    public static class Program
    {
        public static PreferencesRepresentation userpreferences = new PreferencesRepresentation();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            userpreferences.SetPrefsKeys();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
        public enum ScriptFeatures
        {
            IsInduction = 01, IsDeepener = 02, InstallsTrigger = 03, InstallsOpenTrigger = 04, InstallsTrustedTrigger = 05,
            PermanentChanges = 06, InstallsAccidental_RandomTrigger = 07, IQDropWhileUnder = 08, InstallsIQDropTriggerOpen = 09,
            PersonalityChangePermanent = 10, BodyChangesWhileUnder = 11, IsInteractive = 12, InstallsImmobilityTrigger = 13,
            ImmobilityWhileUnder = 14, AllowsCustomName = 15, AllowsCustomRewardTrigger = 16, AllowsCustomPunishTrigger = 17,
            AllowsCustomDropTrigger = 18, AllowsCustomTeaseTrigger = 19, AllowsCustomImmobilityTrigger = 20, 
            AllowsCustomMobilityTrigger = 21, AllowsCustomOwnerTitle = 22, InstallsTriggerTransformation = 23,
            EnslaveTraining = 24, ObedienceTraining = 25, IsAmnesiaFile = 26, GenericReinforcement = 27, BodyChangesPermanent = 28,
            IsAwakener = 29, IsPunishSegment = 30, IsRewardSegment = 31, IsTriggerSegment = 32, ContainsArousalSegment =33,
            ContainsStripSegment = 34, ContainsOrgasm = 35, ContainsRandomTriggering = 36, IncludeInRandomTriggerInstallPool = 37,
            IncludeInChaosMode = 38, IsFractionationSegment = 39, DeclaresFeatures = 40, IsTrustedScript = 41, IsLongScript = 42,
            IncludeInTriggerOnWakePool = 43, ContainsMasturbation = 44
        }
        

        //Selective Trigger Installs mean triggers that only people you trust can use.
            //todo by default "only allow scripts that declare their features" checkbox should be on.
                //A note, accidental triggers go off even if you don't want them to, the circumstances are up to the script writer.
        public enum PreferenceEnums
        {
            UsePunishSegments = 0, UseRewardSegments = 1, UseInductionScripts = 2, UseDeepenerSegments = 3,
            AllowRandomTriggering = 4, AllowRandomTriggerInstall = 5, AllowInteractiveScripts = 6,
            UseFractionationSegments = 7, AllowImmobilizeWhileUnder = 8, AllowImmobilityTriggerInstall = 9,
            CustomImmobilizeTriggerInRandomTriggerPool = 10, AllowIQDropUnder = 11, AllowOpenTriggerInstall =12,
            AllowSelectiveTriggerInstalls = 13, OnlyIncludeTaggedScriptsInRandomPool = 14,
            OnlyIncludeTrustedScriptsInRandomPool = 15, AllowPermanentChanges = 16, AllowBodyChangesUnder = 17,
            AllowTransformationTriggerInstall = 18, UseLongScripts = 19, AllowBodyChangesPermanent = 20,
            UseGenericReinforcementScripts = 21, AllowPersonalityChangePermanent = 22,
            AllowObedienceTraining = 23, UseRandomTriggerSegmentsOnWake = 24, AllowAccidentalTriggerInstall = 25,
            AllowIQDropTriggerInstall_OpenUsage = 26, AllowForcedStripUnder = 27, AllowForcedMasturbation = 28,
            AllowSlaveTraining = 29, AllowCustomNameUse = 30




        }
    }

}
