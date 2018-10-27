using System;

namespace HypnosisRandomizer
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.GenerateSession = new System.Windows.Forms.Button();
            this.Preferences = new System.Windows.Forms.GroupBox();
            this.CheckBoxUseName = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllowSlaveryBrainWash = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllowMasturbation = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllowStrip = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllowIQDropTriggers = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllowAccidentalTriggers = new System.Windows.Forms.CheckBox();
            this.CheckBoxTriggerAfterAwaken = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllowObedienceTraining = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllowPersonalityChangesPermanent = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllowGenericReinforcement = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllowPermanentBodyChanges = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllowLongScripts = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllowBodyChangeTriggerInstalls = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllowBodyChangesWhileUnder = new System.Windows.Forms.CheckBox();
            this.CheckBoxPermanentChanges = new System.Windows.Forms.CheckBox();
            this.CheckBoxTrustedScripts = new System.Windows.Forms.CheckBox();
            this.CheckBoxDeclareFeatures = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllowTrustTriggerInstalls = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllowOpenTriggerInstalls = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllowIQDropWhileUnder = new System.Windows.Forms.CheckBox();
            this.CheckBoxCustomImmobilizeTrigger = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllowImmobilityTriggerInstall = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllowImmobilizeUnder = new System.Windows.Forms.CheckBox();
            this.CheckBoxAllowFractionate = new System.Windows.Forms.CheckBox();
            this.CheckBoxUseAwakener = new System.Windows.Forms.CheckBox();
            this.CheckBoxUseDialogScripts = new System.Windows.Forms.CheckBox();
            this.CheckBoxRandomTriggerInstalls = new System.Windows.Forms.CheckBox();
            this.CheckBoxIncludeRandomTriggering = new System.Windows.Forms.CheckBox();
            this.CheckBoxUseDeepener = new System.Windows.Forms.CheckBox();
            this.CheckBoxUseInduction = new System.Windows.Forms.CheckBox();
            this.CheckBoxRewardSegments = new System.Windows.Forms.CheckBox();
            this.CheckBoxPunishSegments = new System.Windows.Forms.CheckBox();
            this.GroupBoxCustomTriggers = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LabelMasterTitle = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelSubjectName = new System.Windows.Forms.Label();
            this.TextBoxReMobilizeTrigger = new System.Windows.Forms.TextBox();
            this.LabelReMobilizeTrigger = new System.Windows.Forms.Label();
            this.TextBoxImmobilizeTrigger = new System.Windows.Forms.TextBox();
            this.LabelCustomImmobile = new System.Windows.Forms.Label();
            this.TextBoxTeaseTrigger = new System.Windows.Forms.TextBox();
            this.LabelTeaseTrigger = new System.Windows.Forms.Label();
            this.TextBoxDropTrigger = new System.Windows.Forms.TextBox();
            this.LabelDropTrigger = new System.Windows.Forms.Label();
            this.TextBoxPunishTrigger = new System.Windows.Forms.TextBox();
            this.LabelPunishTrigger = new System.Windows.Forms.Label();
            this.TextBoxRewardTrigger = new System.Windows.Forms.TextBox();
            this.LabelRewardTrigger = new System.Windows.Forms.Label();
            this.GroupBoxDangerousSettings = new System.Windows.Forms.GroupBox();
            this.CheckBoxAllowRandomScriptLogic = new System.Windows.Forms.CheckBox();
            this.CheckBoxChaosModeEnabled = new System.Windows.Forms.CheckBox();
            this.WarningTextBox = new System.Windows.Forms.RichTextBox();
            this.Preferences.SuspendLayout();
            this.GroupBoxCustomTriggers.SuspendLayout();
            this.GroupBoxDangerousSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerateSession
            // 
            this.GenerateSession.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.GenerateSession.Location = new System.Drawing.Point(981, 456);
            this.GenerateSession.Name = "GenerateSession";
            this.GenerateSession.Size = new System.Drawing.Size(147, 82);
            this.GenerateSession.TabIndex = 0;
            this.GenerateSession.Text = "Generate Session";
            this.GenerateSession.UseVisualStyleBackColor = false;
            this.GenerateSession.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Preferences
            // 
            this.Preferences.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Preferences.Controls.Add(this.GroupBoxDangerousSettings);
            this.Preferences.Controls.Add(this.GenerateSession);
            this.Preferences.Controls.Add(this.CheckBoxUseName);
            this.Preferences.Controls.Add(this.GroupBoxCustomTriggers);
            this.Preferences.Controls.Add(this.CheckBoxAllowSlaveryBrainWash);
            this.Preferences.Controls.Add(this.CheckBoxAllowMasturbation);
            this.Preferences.Controls.Add(this.CheckBoxAllowStrip);
            this.Preferences.Controls.Add(this.CheckBoxAllowIQDropTriggers);
            this.Preferences.Controls.Add(this.CheckBoxAllowAccidentalTriggers);
            this.Preferences.Controls.Add(this.CheckBoxTriggerAfterAwaken);
            this.Preferences.Controls.Add(this.CheckBoxAllowObedienceTraining);
            this.Preferences.Controls.Add(this.CheckBoxAllowPersonalityChangesPermanent);
            this.Preferences.Controls.Add(this.CheckBoxAllowGenericReinforcement);
            this.Preferences.Controls.Add(this.CheckBoxAllowPermanentBodyChanges);
            this.Preferences.Controls.Add(this.CheckBoxAllowLongScripts);
            this.Preferences.Controls.Add(this.CheckBoxAllowBodyChangeTriggerInstalls);
            this.Preferences.Controls.Add(this.CheckBoxAllowBodyChangesWhileUnder);
            this.Preferences.Controls.Add(this.CheckBoxPermanentChanges);
            this.Preferences.Controls.Add(this.CheckBoxTrustedScripts);
            this.Preferences.Controls.Add(this.CheckBoxDeclareFeatures);
            this.Preferences.Controls.Add(this.CheckBoxAllowTrustTriggerInstalls);
            this.Preferences.Controls.Add(this.CheckBoxAllowOpenTriggerInstalls);
            this.Preferences.Controls.Add(this.CheckBoxAllowIQDropWhileUnder);
            this.Preferences.Controls.Add(this.CheckBoxCustomImmobilizeTrigger);
            this.Preferences.Controls.Add(this.CheckBoxAllowImmobilityTriggerInstall);
            this.Preferences.Controls.Add(this.CheckBoxAllowImmobilizeUnder);
            this.Preferences.Controls.Add(this.CheckBoxAllowFractionate);
            this.Preferences.Controls.Add(this.CheckBoxUseAwakener);
            this.Preferences.Controls.Add(this.CheckBoxUseDialogScripts);
            this.Preferences.Controls.Add(this.CheckBoxRandomTriggerInstalls);
            this.Preferences.Controls.Add(this.CheckBoxIncludeRandomTriggering);
            this.Preferences.Controls.Add(this.CheckBoxUseDeepener);
            this.Preferences.Controls.Add(this.CheckBoxUseInduction);
            this.Preferences.Controls.Add(this.CheckBoxRewardSegments);
            this.Preferences.Controls.Add(this.CheckBoxPunishSegments);
            this.Preferences.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Preferences.Location = new System.Drawing.Point(11, 12);
            this.Preferences.Name = "Preferences";
            this.Preferences.Size = new System.Drawing.Size(1134, 551);
            this.Preferences.TabIndex = 1;
            this.Preferences.TabStop = false;
            this.Preferences.Text = "Preferences";
            // 
            // CheckBoxUseName
            // 
            this.CheckBoxUseName.AutoSize = true;
            this.CheckBoxUseName.Location = new System.Drawing.Point(338, 192);
            this.CheckBoxUseName.Name = "CheckBoxUseName";
            this.CheckBoxUseName.Size = new System.Drawing.Size(204, 17);
            this.CheckBoxUseName.TabIndex = 32;
            this.CheckBoxUseName.Text = "Allow Segments That Use Your Name";
            this.CheckBoxUseName.UseVisualStyleBackColor = true;
            this.CheckBoxUseName.CheckedChanged += new System.EventHandler(this.CheckBoxUseName_CheckedChanged);
            // 
            // CheckBoxAllowSlaveryBrainWash
            // 
            this.CheckBoxAllowSlaveryBrainWash.AutoSize = true;
            this.CheckBoxAllowSlaveryBrainWash.Location = new System.Drawing.Point(6, 479);
            this.CheckBoxAllowSlaveryBrainWash.Name = "CheckBoxAllowSlaveryBrainWash";
            this.CheckBoxAllowSlaveryBrainWash.Size = new System.Drawing.Size(261, 17);
            this.CheckBoxAllowSlaveryBrainWash.TabIndex = 31;
            this.CheckBoxAllowSlaveryBrainWash.Text = "Allow Segments that condition you to be enslaved";
            this.CheckBoxAllowSlaveryBrainWash.UseVisualStyleBackColor = true;
            this.CheckBoxAllowSlaveryBrainWash.CheckedChanged += new System.EventHandler(this.CheckBoxAllowSlaveryBrainWash_CheckedChanged);
            // 
            // CheckBoxAllowMasturbation
            // 
            this.CheckBoxAllowMasturbation.AutoSize = true;
            this.CheckBoxAllowMasturbation.Location = new System.Drawing.Point(7, 456);
            this.CheckBoxAllowMasturbation.Name = "CheckBoxAllowMasturbation";
            this.CheckBoxAllowMasturbation.Size = new System.Drawing.Size(300, 17);
            this.CheckBoxAllowMasturbation.TabIndex = 30;
            this.CheckBoxAllowMasturbation.Text = "Allow Segments That Make You Masturbate Or Even Cum";
            this.CheckBoxAllowMasturbation.UseVisualStyleBackColor = true;
            this.CheckBoxAllowMasturbation.CheckedChanged += new System.EventHandler(this.CheckBoxAllowMasturbation_CheckedChanged);
            // 
            // CheckBoxAllowStrip
            // 
            this.CheckBoxAllowStrip.AutoSize = true;
            this.CheckBoxAllowStrip.Location = new System.Drawing.Point(338, 215);
            this.CheckBoxAllowStrip.Name = "CheckBoxAllowStrip";
            this.CheckBoxAllowStrip.Size = new System.Drawing.Size(207, 17);
            this.CheckBoxAllowStrip.TabIndex = 29;
            this.CheckBoxAllowStrip.Text = "Allow Segments That Make You Nude";
            this.CheckBoxAllowStrip.UseVisualStyleBackColor = true;
            this.CheckBoxAllowStrip.CheckedChanged += new System.EventHandler(this.CheckBoxAllowStrip_CheckedChanged);
            // 
            // CheckBoxAllowIQDropTriggers
            // 
            this.CheckBoxAllowIQDropTriggers.AutoSize = true;
            this.CheckBoxAllowIQDropTriggers.Location = new System.Drawing.Point(6, 502);
            this.CheckBoxAllowIQDropTriggers.Name = "CheckBoxAllowIQDropTriggers";
            this.CheckBoxAllowIQDropTriggers.Size = new System.Drawing.Size(319, 17);
            this.CheckBoxAllowIQDropTriggers.TabIndex = 28;
            this.CheckBoxAllowIQDropTriggers.Text = "Allow the installation of IQ Dropping Triggers (anyone can use)";
            this.CheckBoxAllowIQDropTriggers.UseVisualStyleBackColor = true;
            this.CheckBoxAllowIQDropTriggers.CheckedChanged += new System.EventHandler(this.CheckBoxAllowIQDropTriggers_CheckedChanged);
            // 
            // CheckBoxAllowAccidentalTriggers
            // 
            this.CheckBoxAllowAccidentalTriggers.AutoSize = true;
            this.CheckBoxAllowAccidentalTriggers.Location = new System.Drawing.Point(7, 433);
            this.CheckBoxAllowAccidentalTriggers.Name = "CheckBoxAllowAccidentalTriggers";
            this.CheckBoxAllowAccidentalTriggers.Size = new System.Drawing.Size(261, 17);
            this.CheckBoxAllowAccidentalTriggers.TabIndex = 27;
            this.CheckBoxAllowAccidentalTriggers.Text = "Install Triggers that go off randomly or accidentally";
            this.CheckBoxAllowAccidentalTriggers.UseVisualStyleBackColor = true;
            this.CheckBoxAllowAccidentalTriggers.CheckedChanged += new System.EventHandler(this.CheckBoxAllowAccidentalTriggers_CheckedChanged);
            // 
            // CheckBoxTriggerAfterAwaken
            // 
            this.CheckBoxTriggerAfterAwaken.AutoSize = true;
            this.CheckBoxTriggerAfterAwaken.Location = new System.Drawing.Point(7, 410);
            this.CheckBoxTriggerAfterAwaken.Name = "CheckBoxTriggerAfterAwaken";
            this.CheckBoxTriggerAfterAwaken.Size = new System.Drawing.Size(276, 17);
            this.CheckBoxTriggerAfterAwaken.TabIndex = 26;
            this.CheckBoxTriggerAfterAwaken.Text = "Allow Random Triggering Segments After Waking Up";
            this.CheckBoxTriggerAfterAwaken.UseVisualStyleBackColor = true;
            this.CheckBoxTriggerAfterAwaken.CheckedChanged += new System.EventHandler(this.CheckBoxTriggerAfterAwaken_CheckedChanged);
            // 
            // CheckBoxAllowObedienceTraining
            // 
            this.CheckBoxAllowObedienceTraining.AutoSize = true;
            this.CheckBoxAllowObedienceTraining.Location = new System.Drawing.Point(338, 8);
            this.CheckBoxAllowObedienceTraining.Name = "CheckBoxAllowObedienceTraining";
            this.CheckBoxAllowObedienceTraining.Size = new System.Drawing.Size(197, 17);
            this.CheckBoxAllowObedienceTraining.TabIndex = 25;
            this.CheckBoxAllowObedienceTraining.Text = "Allow Obedience Training Segments";
            this.CheckBoxAllowObedienceTraining.UseVisualStyleBackColor = true;
            this.CheckBoxAllowObedienceTraining.CheckedChanged += new System.EventHandler(this.CheckBoxAllowObedienceTraining_CheckedChanged);
            // 
            // CheckBoxAllowPersonalityChangesPermanent
            // 
            this.CheckBoxAllowPersonalityChangesPermanent.AutoSize = true;
            this.CheckBoxAllowPersonalityChangesPermanent.Location = new System.Drawing.Point(7, 387);
            this.CheckBoxAllowPersonalityChangesPermanent.Name = "CheckBoxAllowPersonalityChangesPermanent";
            this.CheckBoxAllowPersonalityChangesPermanent.Size = new System.Drawing.Size(209, 17);
            this.CheckBoxAllowPersonalityChangesPermanent.TabIndex = 24;
            this.CheckBoxAllowPersonalityChangesPermanent.Text = "Allow Personality Changes (permanent)";
            this.CheckBoxAllowPersonalityChangesPermanent.UseVisualStyleBackColor = true;
            this.CheckBoxAllowPersonalityChangesPermanent.CheckedChanged += new System.EventHandler(this.CheckBoxAllowPersonalityChangesPermanent_CheckedChanged);
            // 
            // CheckBoxAllowGenericReinforcement
            // 
            this.CheckBoxAllowGenericReinforcement.AutoSize = true;
            this.CheckBoxAllowGenericReinforcement.Location = new System.Drawing.Point(7, 364);
            this.CheckBoxAllowGenericReinforcement.Name = "CheckBoxAllowGenericReinforcement";
            this.CheckBoxAllowGenericReinforcement.Size = new System.Drawing.Size(163, 17);
            this.CheckBoxAllowGenericReinforcement.TabIndex = 23;
            this.CheckBoxAllowGenericReinforcement.Text = "Allow Generic Reinforcement";
            this.CheckBoxAllowGenericReinforcement.UseVisualStyleBackColor = true;
            this.CheckBoxAllowGenericReinforcement.CheckedChanged += new System.EventHandler(this.CheckBoxAllowGenericReinforcement_CheckedChanged);
            // 
            // CheckBoxAllowPermanentBodyChanges
            // 
            this.CheckBoxAllowPermanentBodyChanges.AutoSize = true;
            this.CheckBoxAllowPermanentBodyChanges.Location = new System.Drawing.Point(6, 341);
            this.CheckBoxAllowPermanentBodyChanges.Name = "CheckBoxAllowPermanentBodyChanges";
            this.CheckBoxAllowPermanentBodyChanges.Size = new System.Drawing.Size(210, 17);
            this.CheckBoxAllowPermanentBodyChanges.TabIndex = 22;
            this.CheckBoxAllowPermanentBodyChanges.Text = "Allow Permanent Body Transformations";
            this.CheckBoxAllowPermanentBodyChanges.UseVisualStyleBackColor = true;
            this.CheckBoxAllowPermanentBodyChanges.CheckedChanged += new System.EventHandler(this.CheckBoxAllowPermanentBodyChanges_CheckedChanged);
            // 
            // CheckBoxAllowLongScripts
            // 
            this.CheckBoxAllowLongScripts.AutoSize = true;
            this.CheckBoxAllowLongScripts.Location = new System.Drawing.Point(6, 318);
            this.CheckBoxAllowLongScripts.Name = "CheckBoxAllowLongScripts";
            this.CheckBoxAllowLongScripts.Size = new System.Drawing.Size(201, 17);
            this.CheckBoxAllowLongScripts.TabIndex = 21;
            this.CheckBoxAllowLongScripts.Text = "Allow Long Running Script Segments";
            this.CheckBoxAllowLongScripts.UseVisualStyleBackColor = true;
            this.CheckBoxAllowLongScripts.CheckedChanged += new System.EventHandler(this.CheckBoxAllowLongScripts_CheckedChanged);
            // 
            // CheckBoxAllowBodyChangeTriggerInstalls
            // 
            this.CheckBoxAllowBodyChangeTriggerInstalls.AutoSize = true;
            this.CheckBoxAllowBodyChangeTriggerInstalls.Location = new System.Drawing.Point(6, 272);
            this.CheckBoxAllowBodyChangeTriggerInstalls.Name = "CheckBoxAllowBodyChangeTriggerInstalls";
            this.CheckBoxAllowBodyChangeTriggerInstalls.Size = new System.Drawing.Size(213, 17);
            this.CheckBoxAllowBodyChangeTriggerInstalls.TabIndex = 20;
            this.CheckBoxAllowBodyChangeTriggerInstalls.Text = "Allow Transformation Trigger Installation";
            this.CheckBoxAllowBodyChangeTriggerInstalls.UseVisualStyleBackColor = true;
            this.CheckBoxAllowBodyChangeTriggerInstalls.CheckedChanged += new System.EventHandler(this.CheckBoxAllowBodyChangeTriggerInstalls_CheckedChanged);
            // 
            // CheckBoxAllowBodyChangesWhileUnder
            // 
            this.CheckBoxAllowBodyChangesWhileUnder.AutoSize = true;
            this.CheckBoxAllowBodyChangesWhileUnder.Location = new System.Drawing.Point(6, 249);
            this.CheckBoxAllowBodyChangesWhileUnder.Name = "CheckBoxAllowBodyChangesWhileUnder";
            this.CheckBoxAllowBodyChangesWhileUnder.Size = new System.Drawing.Size(187, 17);
            this.CheckBoxAllowBodyChangesWhileUnder.TabIndex = 19;
            this.CheckBoxAllowBodyChangesWhileUnder.Text = "Allow Body Changes When Under";
            this.CheckBoxAllowBodyChangesWhileUnder.UseVisualStyleBackColor = true;
            this.CheckBoxAllowBodyChangesWhileUnder.CheckedChanged += new System.EventHandler(this.CheckBoxAllowBodyChangesWhileUnder_CheckedChanged);
            // 
            // CheckBoxPermanentChanges
            // 
            this.CheckBoxPermanentChanges.AutoSize = true;
            this.CheckBoxPermanentChanges.Location = new System.Drawing.Point(7, 226);
            this.CheckBoxPermanentChanges.Name = "CheckBoxPermanentChanges";
            this.CheckBoxPermanentChanges.Size = new System.Drawing.Size(249, 17);
            this.CheckBoxPermanentChanges.TabIndex = 18;
            this.CheckBoxPermanentChanges.Text = "Allow Scripts That Feature Permanent Changes";
            this.CheckBoxPermanentChanges.UseVisualStyleBackColor = true;
            this.CheckBoxPermanentChanges.CheckedChanged += new System.EventHandler(this.CheckBoxPermanentChanges_CheckedChanged);
            // 
            // CheckBoxTrustedScripts
            // 
            this.CheckBoxTrustedScripts.AutoSize = true;
            this.CheckBoxTrustedScripts.Location = new System.Drawing.Point(6, 203);
            this.CheckBoxTrustedScripts.Name = "CheckBoxTrustedScripts";
            this.CheckBoxTrustedScripts.Size = new System.Drawing.Size(305, 17);
            this.CheckBoxTrustedScripts.TabIndex = 17;
            this.CheckBoxTrustedScripts.Text = "Only Include Trusted Scripts Via CheckSums (WebService)";
            this.CheckBoxTrustedScripts.UseVisualStyleBackColor = true;
            this.CheckBoxTrustedScripts.CheckedChanged += new System.EventHandler(this.CheckBoxTrustedScripts_CheckedChanged_1);
            // 
            // CheckBoxDeclareFeatures
            // 
            this.CheckBoxDeclareFeatures.AutoSize = true;
            this.CheckBoxDeclareFeatures.Location = new System.Drawing.Point(6, 180);
            this.CheckBoxDeclareFeatures.Name = "CheckBoxDeclareFeatures";
            this.CheckBoxDeclareFeatures.Size = new System.Drawing.Size(240, 17);
            this.CheckBoxDeclareFeatures.TabIndex = 16;
            this.CheckBoxDeclareFeatures.Text = "Only Allow Scripts That Define Their Features";
            this.CheckBoxDeclareFeatures.UseVisualStyleBackColor = true;
            this.CheckBoxDeclareFeatures.CheckedChanged += new System.EventHandler(this.CheckBoxTrustedScripts_CheckedChanged);
            // 
            // CheckBoxAllowTrustTriggerInstalls
            // 
            this.CheckBoxAllowTrustTriggerInstalls.AutoSize = true;
            this.CheckBoxAllowTrustTriggerInstalls.Location = new System.Drawing.Point(6, 157);
            this.CheckBoxAllowTrustTriggerInstalls.Name = "CheckBoxAllowTrustTriggerInstalls";
            this.CheckBoxAllowTrustTriggerInstalls.Size = new System.Drawing.Size(307, 17);
            this.CheckBoxAllowTrustTriggerInstalls.TabIndex = 15;
            this.CheckBoxAllowTrustTriggerInstalls.Text = "Allow Selective Trigger Installs (Someone you trust can use)";
            this.CheckBoxAllowTrustTriggerInstalls.UseVisualStyleBackColor = true;
            this.CheckBoxAllowTrustTriggerInstalls.CheckedChanged += new System.EventHandler(this.CheckBoxAllowTrustTriggerInstalls_CheckedChanged);
            // 
            // CheckBoxAllowOpenTriggerInstalls
            // 
            this.CheckBoxAllowOpenTriggerInstalls.AutoSize = true;
            this.CheckBoxAllowOpenTriggerInstalls.Location = new System.Drawing.Point(338, 77);
            this.CheckBoxAllowOpenTriggerInstalls.Name = "CheckBoxAllowOpenTriggerInstalls";
            this.CheckBoxAllowOpenTriggerInstalls.Size = new System.Drawing.Size(151, 17);
            this.CheckBoxAllowOpenTriggerInstalls.TabIndex = 14;
            this.CheckBoxAllowOpenTriggerInstalls.Text = "Allow Open Trigger Installs";
            this.CheckBoxAllowOpenTriggerInstalls.UseVisualStyleBackColor = true;
            this.CheckBoxAllowOpenTriggerInstalls.CheckedChanged += new System.EventHandler(this.CheckBoxAllowOpenTriggerInstalls_CheckedChanged);
            // 
            // CheckBoxAllowIQDropWhileUnder
            // 
            this.CheckBoxAllowIQDropWhileUnder.AutoSize = true;
            this.CheckBoxAllowIQDropWhileUnder.Location = new System.Drawing.Point(338, 100);
            this.CheckBoxAllowIQDropWhileUnder.Name = "CheckBoxAllowIQDropWhileUnder";
            this.CheckBoxAllowIQDropWhileUnder.Size = new System.Drawing.Size(153, 17);
            this.CheckBoxAllowIQDropWhileUnder.TabIndex = 13;
            this.CheckBoxAllowIQDropWhileUnder.Text = "Allow IQ Drop While Under";
            this.CheckBoxAllowIQDropWhileUnder.UseVisualStyleBackColor = true;
            this.CheckBoxAllowIQDropWhileUnder.CheckedChanged += new System.EventHandler(this.CheckBoxAllowIQDropWhileUnder_CheckedChanged);
            // 
            // CheckBoxCustomImmobilizeTrigger
            // 
            this.CheckBoxCustomImmobilizeTrigger.AutoSize = true;
            this.CheckBoxCustomImmobilizeTrigger.Location = new System.Drawing.Point(7, 134);
            this.CheckBoxCustomImmobilizeTrigger.Name = "CheckBoxCustomImmobilizeTrigger";
            this.CheckBoxCustomImmobilizeTrigger.Size = new System.Drawing.Size(263, 17);
            this.CheckBoxCustomImmobilizeTrigger.TabIndex = 12;
            this.CheckBoxCustomImmobilizeTrigger.Text = "Custom Immobilize Trigger In Random Trigger Pool";
            this.CheckBoxCustomImmobilizeTrigger.UseVisualStyleBackColor = true;
            this.CheckBoxCustomImmobilizeTrigger.CheckedChanged += new System.EventHandler(this.CheckBoxCustomImmobilizeTrigger_CheckedChanged);
            // 
            // CheckBoxAllowImmobilityTriggerInstall
            // 
            this.CheckBoxAllowImmobilityTriggerInstall.AutoSize = true;
            this.CheckBoxAllowImmobilityTriggerInstall.Location = new System.Drawing.Point(7, 111);
            this.CheckBoxAllowImmobilityTriggerInstall.Name = "CheckBoxAllowImmobilityTriggerInstall";
            this.CheckBoxAllowImmobilityTriggerInstall.Size = new System.Drawing.Size(165, 17);
            this.CheckBoxAllowImmobilityTriggerInstall.TabIndex = 11;
            this.CheckBoxAllowImmobilityTriggerInstall.Text = "Allow Immobility Trigger Install";
            this.CheckBoxAllowImmobilityTriggerInstall.UseVisualStyleBackColor = true;
            this.CheckBoxAllowImmobilityTriggerInstall.CheckedChanged += new System.EventHandler(this.CheckBoxAllowImmobilityTriggerInstall_CheckedChanged);
            // 
            // CheckBoxAllowImmobilizeUnder
            // 
            this.CheckBoxAllowImmobilizeUnder.AutoSize = true;
            this.CheckBoxAllowImmobilizeUnder.Location = new System.Drawing.Point(6, 88);
            this.CheckBoxAllowImmobilizeUnder.Name = "CheckBoxAllowImmobilizeUnder";
            this.CheckBoxAllowImmobilizeUnder.Size = new System.Drawing.Size(161, 17);
            this.CheckBoxAllowImmobilizeUnder.TabIndex = 10;
            this.CheckBoxAllowImmobilizeUnder.Text = "Allow Immobility While Under";
            this.CheckBoxAllowImmobilizeUnder.UseVisualStyleBackColor = true;
            this.CheckBoxAllowImmobilizeUnder.CheckedChanged += new System.EventHandler(this.CheckBoxAllowImmobilizeUnder_CheckedChanged);
            // 
            // CheckBoxAllowFractionate
            // 
            this.CheckBoxAllowFractionate.AutoSize = true;
            this.CheckBoxAllowFractionate.Location = new System.Drawing.Point(338, 169);
            this.CheckBoxAllowFractionate.Name = "CheckBoxAllowFractionate";
            this.CheckBoxAllowFractionate.Size = new System.Drawing.Size(144, 17);
            this.CheckBoxAllowFractionate.TabIndex = 9;
            this.CheckBoxAllowFractionate.Text = "Use Fractionation Scripts";
            this.CheckBoxAllowFractionate.UseVisualStyleBackColor = true;
            this.CheckBoxAllowFractionate.CheckedChanged += new System.EventHandler(this.CheckBoxAllowFractionate_CheckedChanged);
            // 
            // CheckBoxUseAwakener
            // 
            this.CheckBoxUseAwakener.AutoSize = true;
            this.CheckBoxUseAwakener.Location = new System.Drawing.Point(6, 65);
            this.CheckBoxUseAwakener.Name = "CheckBoxUseAwakener";
            this.CheckBoxUseAwakener.Size = new System.Drawing.Size(161, 17);
            this.CheckBoxUseAwakener.TabIndex = 8;
            this.CheckBoxUseAwakener.Text = "Use Awakener After Session";
            this.CheckBoxUseAwakener.UseVisualStyleBackColor = true;
            this.CheckBoxUseAwakener.CheckedChanged += new System.EventHandler(this.CheckBoxUseAwakener_CheckedChanged);
            // 
            // CheckBoxUseDialogScripts
            // 
            this.CheckBoxUseDialogScripts.AutoSize = true;
            this.CheckBoxUseDialogScripts.Location = new System.Drawing.Point(338, 54);
            this.CheckBoxUseDialogScripts.Name = "CheckBoxUseDialogScripts";
            this.CheckBoxUseDialogScripts.Size = new System.Drawing.Size(149, 17);
            this.CheckBoxUseDialogScripts.TabIndex = 7;
            this.CheckBoxUseDialogScripts.Text = "Include Interactive Scripts";
            this.CheckBoxUseDialogScripts.UseVisualStyleBackColor = true;
            this.CheckBoxUseDialogScripts.CheckedChanged += new System.EventHandler(this.CheckBoxUseDialogScripts_CheckedChanged);
            // 
            // CheckBoxRandomTriggerInstalls
            // 
            this.CheckBoxRandomTriggerInstalls.AutoSize = true;
            this.CheckBoxRandomTriggerInstalls.Location = new System.Drawing.Point(6, 295);
            this.CheckBoxRandomTriggerInstalls.Name = "CheckBoxRandomTriggerInstalls";
            this.CheckBoxRandomTriggerInstalls.Size = new System.Drawing.Size(202, 17);
            this.CheckBoxRandomTriggerInstalls.TabIndex = 6;
            this.CheckBoxRandomTriggerInstalls.Text = "Allow Randomized Trigger Installation";
            this.CheckBoxRandomTriggerInstalls.UseVisualStyleBackColor = true;
            this.CheckBoxRandomTriggerInstalls.CheckedChanged += new System.EventHandler(this.CheckBoxRandomTriggerInstalls_CheckedChanged);
            // 
            // CheckBoxIncludeRandomTriggering
            // 
            this.CheckBoxIncludeRandomTriggering.AutoSize = true;
            this.CheckBoxIncludeRandomTriggering.Location = new System.Drawing.Point(6, 42);
            this.CheckBoxIncludeRandomTriggering.Name = "CheckBoxIncludeRandomTriggering";
            this.CheckBoxIncludeRandomTriggering.Size = new System.Drawing.Size(154, 17);
            this.CheckBoxIncludeRandomTriggering.TabIndex = 5;
            this.CheckBoxIncludeRandomTriggering.Text = "Include Random Triggering";
            this.CheckBoxIncludeRandomTriggering.UseVisualStyleBackColor = true;
            this.CheckBoxIncludeRandomTriggering.CheckedChanged += new System.EventHandler(this.CheckBoxIncludeRandomTriggering_CheckedChanged);
            // 
            // CheckBoxUseDeepener
            // 
            this.CheckBoxUseDeepener.AutoSize = true;
            this.CheckBoxUseDeepener.Location = new System.Drawing.Point(338, 31);
            this.CheckBoxUseDeepener.Name = "CheckBoxUseDeepener";
            this.CheckBoxUseDeepener.Size = new System.Drawing.Size(100, 17);
            this.CheckBoxUseDeepener.TabIndex = 4;
            this.CheckBoxUseDeepener.Text = "Use Deepeners";
            this.CheckBoxUseDeepener.UseVisualStyleBackColor = true;
            this.CheckBoxUseDeepener.CheckedChanged += new System.EventHandler(this.CheckBoxUseDeepener_CheckedChanged);
            // 
            // CheckBoxUseInduction
            // 
            this.CheckBoxUseInduction.AutoSize = true;
            this.CheckBoxUseInduction.Location = new System.Drawing.Point(7, 19);
            this.CheckBoxUseInduction.Name = "CheckBoxUseInduction";
            this.CheckBoxUseInduction.Size = new System.Drawing.Size(92, 17);
            this.CheckBoxUseInduction.TabIndex = 3;
            this.CheckBoxUseInduction.Text = "Use Induction";
            this.CheckBoxUseInduction.UseVisualStyleBackColor = true;
            this.CheckBoxUseInduction.CheckedChanged += new System.EventHandler(this.CheckBoxUseInduction_CheckedChanged);
            // 
            // CheckBoxRewardSegments
            // 
            this.CheckBoxRewardSegments.AutoSize = true;
            this.CheckBoxRewardSegments.Location = new System.Drawing.Point(338, 123);
            this.CheckBoxRewardSegments.Name = "CheckBoxRewardSegments";
            this.CheckBoxRewardSegments.Size = new System.Drawing.Size(135, 17);
            this.CheckBoxRewardSegments.TabIndex = 2;
            this.CheckBoxRewardSegments.Text = "Use Reward Segments";
            this.CheckBoxRewardSegments.UseVisualStyleBackColor = true;
            this.CheckBoxRewardSegments.CheckedChanged += new System.EventHandler(this.CheckBoxRewardSegments_CheckedChanged);
            // 
            // CheckBoxPunishSegments
            // 
            this.CheckBoxPunishSegments.AutoSize = true;
            this.CheckBoxPunishSegments.Location = new System.Drawing.Point(338, 146);
            this.CheckBoxPunishSegments.Name = "CheckBoxPunishSegments";
            this.CheckBoxPunishSegments.Size = new System.Drawing.Size(130, 17);
            this.CheckBoxPunishSegments.TabIndex = 1;
            this.CheckBoxPunishSegments.Text = "Use Punish Segments";
            this.CheckBoxPunishSegments.UseVisualStyleBackColor = true;
            this.CheckBoxPunishSegments.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // GroupBoxCustomTriggers
            // 
            this.GroupBoxCustomTriggers.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GroupBoxCustomTriggers.Controls.Add(this.textBox2);
            this.GroupBoxCustomTriggers.Controls.Add(this.LabelMasterTitle);
            this.GroupBoxCustomTriggers.Controls.Add(this.TextBoxName);
            this.GroupBoxCustomTriggers.Controls.Add(this.LabelSubjectName);
            this.GroupBoxCustomTriggers.Controls.Add(this.TextBoxReMobilizeTrigger);
            this.GroupBoxCustomTriggers.Controls.Add(this.LabelReMobilizeTrigger);
            this.GroupBoxCustomTriggers.Controls.Add(this.TextBoxImmobilizeTrigger);
            this.GroupBoxCustomTriggers.Controls.Add(this.LabelCustomImmobile);
            this.GroupBoxCustomTriggers.Controls.Add(this.TextBoxTeaseTrigger);
            this.GroupBoxCustomTriggers.Controls.Add(this.LabelTeaseTrigger);
            this.GroupBoxCustomTriggers.Controls.Add(this.TextBoxDropTrigger);
            this.GroupBoxCustomTriggers.Controls.Add(this.LabelDropTrigger);
            this.GroupBoxCustomTriggers.Controls.Add(this.TextBoxPunishTrigger);
            this.GroupBoxCustomTriggers.Controls.Add(this.LabelPunishTrigger);
            this.GroupBoxCustomTriggers.Controls.Add(this.TextBoxRewardTrigger);
            this.GroupBoxCustomTriggers.Controls.Add(this.LabelRewardTrigger);
            this.GroupBoxCustomTriggers.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.GroupBoxCustomTriggers.Location = new System.Drawing.Point(551, 8);
            this.GroupBoxCustomTriggers.Name = "GroupBoxCustomTriggers";
            this.GroupBoxCustomTriggers.Size = new System.Drawing.Size(561, 276);
            this.GroupBoxCustomTriggers.TabIndex = 2;
            this.GroupBoxCustomTriggers.TabStop = false;
            this.GroupBoxCustomTriggers.Text = "Custom Triggers";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 221);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(366, 20);
            this.textBox2.TabIndex = 15;
            // 
            // LabelMasterTitle
            // 
            this.LabelMasterTitle.AutoSize = true;
            this.LabelMasterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMasterTitle.Location = new System.Drawing.Point(7, 221);
            this.LabelMasterTitle.Name = "LabelMasterTitle";
            this.LabelMasterTitle.Size = new System.Drawing.Size(147, 20);
            this.LabelMasterTitle.TabIndex = 14;
            this.LabelMasterTitle.Text = "Owners Title(if any):";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(189, 188);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(366, 20);
            this.TextBoxName.TabIndex = 13;
            // 
            // LabelSubjectName
            // 
            this.LabelSubjectName.AutoSize = true;
            this.LabelSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSubjectName.Location = new System.Drawing.Point(6, 188);
            this.LabelSubjectName.Name = "LabelSubjectName";
            this.LabelSubjectName.Size = new System.Drawing.Size(93, 20);
            this.LabelSubjectName.TabIndex = 12;
            this.LabelSubjectName.Text = "Your Name:";
            // 
            // TextBoxReMobilizeTrigger
            // 
            this.TextBoxReMobilizeTrigger.Location = new System.Drawing.Point(189, 159);
            this.TextBoxReMobilizeTrigger.Name = "TextBoxReMobilizeTrigger";
            this.TextBoxReMobilizeTrigger.Size = new System.Drawing.Size(366, 20);
            this.TextBoxReMobilizeTrigger.TabIndex = 11;
            // 
            // LabelReMobilizeTrigger
            // 
            this.LabelReMobilizeTrigger.AutoSize = true;
            this.LabelReMobilizeTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReMobilizeTrigger.Location = new System.Drawing.Point(6, 159);
            this.LabelReMobilizeTrigger.Name = "LabelReMobilizeTrigger";
            this.LabelReMobilizeTrigger.Size = new System.Drawing.Size(132, 20);
            this.LabelReMobilizeTrigger.TabIndex = 10;
            this.LabelReMobilizeTrigger.Text = "Unfreeze Trigger:";
            // 
            // TextBoxImmobilizeTrigger
            // 
            this.TextBoxImmobilizeTrigger.Location = new System.Drawing.Point(189, 126);
            this.TextBoxImmobilizeTrigger.Name = "TextBoxImmobilizeTrigger";
            this.TextBoxImmobilizeTrigger.Size = new System.Drawing.Size(366, 20);
            this.TextBoxImmobilizeTrigger.TabIndex = 9;
            // 
            // LabelCustomImmobile
            // 
            this.LabelCustomImmobile.AutoSize = true;
            this.LabelCustomImmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCustomImmobile.Location = new System.Drawing.Point(6, 126);
            this.LabelCustomImmobile.Name = "LabelCustomImmobile";
            this.LabelCustomImmobile.Size = new System.Drawing.Size(116, 20);
            this.LabelCustomImmobile.TabIndex = 8;
            this.LabelCustomImmobile.Text = "Freeze Trigger:";
            // 
            // TextBoxTeaseTrigger
            // 
            this.TextBoxTeaseTrigger.Location = new System.Drawing.Point(189, 97);
            this.TextBoxTeaseTrigger.Name = "TextBoxTeaseTrigger";
            this.TextBoxTeaseTrigger.Size = new System.Drawing.Size(366, 20);
            this.TextBoxTeaseTrigger.TabIndex = 7;
            // 
            // LabelTeaseTrigger
            // 
            this.LabelTeaseTrigger.AutoSize = true;
            this.LabelTeaseTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTeaseTrigger.Location = new System.Drawing.Point(6, 97);
            this.LabelTeaseTrigger.Name = "LabelTeaseTrigger";
            this.LabelTeaseTrigger.Size = new System.Drawing.Size(110, 20);
            this.LabelTeaseTrigger.TabIndex = 6;
            this.LabelTeaseTrigger.Text = "Tease Trigger:";
            this.LabelTeaseTrigger.Click += new System.EventHandler(this.LabelTeaseTrigger_Click);
            // 
            // TextBoxDropTrigger
            // 
            this.TextBoxDropTrigger.Location = new System.Drawing.Point(189, 71);
            this.TextBoxDropTrigger.Name = "TextBoxDropTrigger";
            this.TextBoxDropTrigger.Size = new System.Drawing.Size(366, 20);
            this.TextBoxDropTrigger.TabIndex = 5;
            // 
            // LabelDropTrigger
            // 
            this.LabelDropTrigger.AutoSize = true;
            this.LabelDropTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDropTrigger.Location = new System.Drawing.Point(7, 71);
            this.LabelDropTrigger.Name = "LabelDropTrigger";
            this.LabelDropTrigger.Size = new System.Drawing.Size(101, 20);
            this.LabelDropTrigger.TabIndex = 4;
            this.LabelDropTrigger.Text = "Drop Trigger:";
            this.LabelDropTrigger.Click += new System.EventHandler(this.LabelDropTrigger_Click);
            // 
            // TextBoxPunishTrigger
            // 
            this.TextBoxPunishTrigger.Location = new System.Drawing.Point(189, 45);
            this.TextBoxPunishTrigger.Name = "TextBoxPunishTrigger";
            this.TextBoxPunishTrigger.Size = new System.Drawing.Size(366, 20);
            this.TextBoxPunishTrigger.TabIndex = 3;
            // 
            // LabelPunishTrigger
            // 
            this.LabelPunishTrigger.AutoSize = true;
            this.LabelPunishTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPunishTrigger.Location = new System.Drawing.Point(7, 45);
            this.LabelPunishTrigger.Name = "LabelPunishTrigger";
            this.LabelPunishTrigger.Size = new System.Drawing.Size(114, 20);
            this.LabelPunishTrigger.TabIndex = 2;
            this.LabelPunishTrigger.Text = "Punish Trigger:";
            // 
            // TextBoxRewardTrigger
            // 
            this.TextBoxRewardTrigger.Location = new System.Drawing.Point(189, 19);
            this.TextBoxRewardTrigger.Name = "TextBoxRewardTrigger";
            this.TextBoxRewardTrigger.Size = new System.Drawing.Size(366, 20);
            this.TextBoxRewardTrigger.TabIndex = 1;
            // 
            // LabelRewardTrigger
            // 
            this.LabelRewardTrigger.AutoSize = true;
            this.LabelRewardTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRewardTrigger.Location = new System.Drawing.Point(7, 20);
            this.LabelRewardTrigger.Name = "LabelRewardTrigger";
            this.LabelRewardTrigger.Size = new System.Drawing.Size(121, 20);
            this.LabelRewardTrigger.TabIndex = 0;
            this.LabelRewardTrigger.Text = "Reward Trigger:";
            // 
            // GroupBoxDangerousSettings
            // 
            this.GroupBoxDangerousSettings.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.GroupBoxDangerousSettings.Controls.Add(this.CheckBoxAllowRandomScriptLogic);
            this.GroupBoxDangerousSettings.Controls.Add(this.CheckBoxChaosModeEnabled);
            this.GroupBoxDangerousSettings.Controls.Add(this.WarningTextBox);
            this.GroupBoxDangerousSettings.ForeColor = System.Drawing.Color.Indigo;
            this.GroupBoxDangerousSettings.Location = new System.Drawing.Point(338, 292);
            this.GroupBoxDangerousSettings.Name = "GroupBoxDangerousSettings";
            this.GroupBoxDangerousSettings.Size = new System.Drawing.Size(422, 227);
            this.GroupBoxDangerousSettings.TabIndex = 3;
            this.GroupBoxDangerousSettings.TabStop = false;
            this.GroupBoxDangerousSettings.Text = "Dangerous Settings";
            // 
            // CheckBoxAllowRandomScriptLogic
            // 
            this.CheckBoxAllowRandomScriptLogic.AutoSize = true;
            this.CheckBoxAllowRandomScriptLogic.ForeColor = System.Drawing.Color.Pink;
            this.CheckBoxAllowRandomScriptLogic.Location = new System.Drawing.Point(11, 187);
            this.CheckBoxAllowRandomScriptLogic.Name = "CheckBoxAllowRandomScriptLogic";
            this.CheckBoxAllowRandomScriptLogic.Size = new System.Drawing.Size(361, 17);
            this.CheckBoxAllowRandomScriptLogic.TabIndex = 2;
            this.CheckBoxAllowRandomScriptLogic.Text = "Allow Random Scripts (with logic) -IGNORES PREFS for random scripts";
            this.CheckBoxAllowRandomScriptLogic.UseVisualStyleBackColor = true;
            this.CheckBoxAllowRandomScriptLogic.CheckedChanged += new System.EventHandler(this.CheckBoxAllowRandomScriptLogic_CheckedChanged);
            // 
            // CheckBoxChaosModeEnabled
            // 
            this.CheckBoxChaosModeEnabled.AutoSize = true;
            this.CheckBoxChaosModeEnabled.ForeColor = System.Drawing.Color.LightPink;
            this.CheckBoxChaosModeEnabled.Location = new System.Drawing.Point(11, 164);
            this.CheckBoxChaosModeEnabled.Name = "CheckBoxChaosModeEnabled";
            this.CheckBoxChaosModeEnabled.Size = new System.Drawing.Size(181, 17);
            this.CheckBoxChaosModeEnabled.TabIndex = 1;
            this.CheckBoxChaosModeEnabled.Text = "Enable Chaos Mode (dangerous)";
            this.CheckBoxChaosModeEnabled.UseVisualStyleBackColor = true;
            this.CheckBoxChaosModeEnabled.CheckedChanged += new System.EventHandler(this.CheckBoxChaosModeEnabled_CheckedChanged);
            // 
            // WarningTextBox
            // 
            this.WarningTextBox.Location = new System.Drawing.Point(11, 25);
            this.WarningTextBox.Name = "WarningTextBox";
            this.WarningTextBox.ReadOnly = true;
            this.WarningTextBox.Size = new System.Drawing.Size(397, 133);
            this.WarningTextBox.TabIndex = 0;
            this.WarningTextBox.Text = resources.GetString("WarningTextBox.Text");
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 568);
            this.Controls.Add(this.Preferences);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Preferences.ResumeLayout(false);
            this.Preferences.PerformLayout();
            this.GroupBoxCustomTriggers.ResumeLayout(false);
            this.GroupBoxCustomTriggers.PerformLayout();
            this.GroupBoxDangerousSettings.ResumeLayout(false);
            this.GroupBoxDangerousSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Preferences_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button GenerateSession;
        private System.Windows.Forms.GroupBox Preferences;
        private System.Windows.Forms.CheckBox CheckBoxPunishSegments;
        private System.Windows.Forms.CheckBox CheckBoxRandomTriggerInstalls;
        private System.Windows.Forms.CheckBox CheckBoxIncludeRandomTriggering;
        private System.Windows.Forms.CheckBox CheckBoxUseDeepener;
        private System.Windows.Forms.CheckBox CheckBoxUseInduction;
        private System.Windows.Forms.CheckBox CheckBoxRewardSegments;
        private System.Windows.Forms.GroupBox GroupBoxCustomTriggers;
        private System.Windows.Forms.TextBox TextBoxTeaseTrigger;
        private System.Windows.Forms.Label LabelTeaseTrigger;
        private System.Windows.Forms.TextBox TextBoxDropTrigger;
        private System.Windows.Forms.Label LabelDropTrigger;
        private System.Windows.Forms.TextBox TextBoxPunishTrigger;
        private System.Windows.Forms.Label LabelPunishTrigger;
        private System.Windows.Forms.TextBox TextBoxRewardTrigger;
        private System.Windows.Forms.Label LabelRewardTrigger;
        private System.Windows.Forms.CheckBox CheckBoxUseName;
        private System.Windows.Forms.CheckBox CheckBoxAllowSlaveryBrainWash;
        private System.Windows.Forms.CheckBox CheckBoxAllowMasturbation;
        private System.Windows.Forms.CheckBox CheckBoxAllowStrip;
        private System.Windows.Forms.CheckBox CheckBoxAllowIQDropTriggers;
        private System.Windows.Forms.CheckBox CheckBoxAllowAccidentalTriggers;
        private System.Windows.Forms.CheckBox CheckBoxTriggerAfterAwaken;
        private System.Windows.Forms.CheckBox CheckBoxAllowObedienceTraining;
        private System.Windows.Forms.CheckBox CheckBoxAllowPersonalityChangesPermanent;
        private System.Windows.Forms.CheckBox CheckBoxAllowGenericReinforcement;
        private System.Windows.Forms.CheckBox CheckBoxAllowPermanentBodyChanges;
        private System.Windows.Forms.CheckBox CheckBoxAllowLongScripts;
        private System.Windows.Forms.CheckBox CheckBoxAllowBodyChangeTriggerInstalls;
        private System.Windows.Forms.CheckBox CheckBoxAllowBodyChangesWhileUnder;
        private System.Windows.Forms.CheckBox CheckBoxPermanentChanges;
        private System.Windows.Forms.CheckBox CheckBoxTrustedScripts;
        private System.Windows.Forms.CheckBox CheckBoxDeclareFeatures;
        private System.Windows.Forms.CheckBox CheckBoxAllowTrustTriggerInstalls;
        private System.Windows.Forms.CheckBox CheckBoxAllowOpenTriggerInstalls;
        private System.Windows.Forms.CheckBox CheckBoxAllowIQDropWhileUnder;
        private System.Windows.Forms.CheckBox CheckBoxCustomImmobilizeTrigger;
        private System.Windows.Forms.CheckBox CheckBoxAllowImmobilityTriggerInstall;
        private System.Windows.Forms.CheckBox CheckBoxAllowImmobilizeUnder;
        private System.Windows.Forms.CheckBox CheckBoxAllowFractionate;
        private System.Windows.Forms.CheckBox CheckBoxUseAwakener;
        private System.Windows.Forms.CheckBox CheckBoxUseDialogScripts;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LabelMasterTitle;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelSubjectName;
        private System.Windows.Forms.TextBox TextBoxReMobilizeTrigger;
        private System.Windows.Forms.Label LabelReMobilizeTrigger;
        private System.Windows.Forms.TextBox TextBoxImmobilizeTrigger;
        private System.Windows.Forms.Label LabelCustomImmobile;
        private System.Windows.Forms.GroupBox GroupBoxDangerousSettings;
        private System.Windows.Forms.CheckBox CheckBoxAllowRandomScriptLogic;
        private System.Windows.Forms.CheckBox CheckBoxChaosModeEnabled;
        private System.Windows.Forms.RichTextBox WarningTextBox;
    }
}

